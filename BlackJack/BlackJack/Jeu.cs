/////////////////////
// Form Jeu        //
// Xavier Brosseau //
// Charlie Laplante//
/////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BlackJack
{
   public partial class Jeu : Form
   {
      List<Carte> paquet = new List<Carte>();
      Point CarteJ1 = new Point(15, 100);
      Point CarteJ2 = new Point(523, 100);
      Joueur J1;
      Joueur J2;
      int A_Qui_Le_Tour = 1;
      int CompteurCarte = 0;

      const int CarteHeight = 127;
      const int CarteWidth = 88;
      const int BigValueAs = 11;
      const int SmallValueAs = 1;
      const int LimitBlackjack = 21;

      public Jeu()
      {
         InitializeComponent();
         J1 = new Joueur("J1");
         J2 = new Joueur("J2");
      }
      public Jeu(int CPU_Level, bool Compter)
      {
         InitializeComponent();
         J1 = new Joueur(CPU_Level, Compter, "J1");
         J2 = new Joueur("J2");
      }
      public Jeu(int CPU_Level1, bool Compter1, int CPU_Level2, bool Compter2)
      {
         InitializeComponent();
         J1 = new Joueur(CPU_Level1, Compter1, "J1");
         J2 = new Joueur(CPU_Level2, Compter2, "J2");

      }
      private void Jeu_Load(object sender, EventArgs e)
      {
         try
         {
            LoadCarte();
            MixCards();
         }
         catch (Exception es)
         {
            MessageBox.Show(es.Message.ToString());
            this.Close();
         }
      }

      private void LoadCarte()
      {

         //Création des objet cartes dans paquet
         int valeur = 1;
         for (int i = 0; i < 52; ++i)
         {
            if (valeur <= 9 && (i % 4) == 0)
            {
               valeur++;
            }
            else if (valeur == 10 && (i % 16) == 0)
            {
               valeur++;
            }
            paquet.Add(new Carte(null, valeur));
         }

      }

      private void MixCards()
      {
         List<Carte> Temp = new List<Carte>(paquet);
         Random rnd = new Random();
         int NbTemp;
         paquet.Clear();
         for (int i = 0; i < 52; i++)
         {
            do
            {
               NbTemp = rnd.Next(0, 52);
            } while (paquet.Contains(Temp[NbTemp]));
            paquet.Add(Temp[NbTemp]);
         }
      }

      private void AfficherUneCarte(int posPaquet, Joueur joueur)
      {
         if (posPaquet < 52 && posPaquet >= 0)
         {
            PictureBox PBox = new PictureBox();
            PBox.BackgroundImage = paquet[posPaquet].GetImage();
            PBox.Height = CarteHeight;
            PBox.Width = CarteWidth;

            PBox.BackgroundImageLayout = ImageLayout.Stretch;
            if (joueur.GetNom() == "J1")
            {
               PBox.Location = CarteJ1;
               CarteJ1.X += 18;
               CarteJ1.Y -= 2;
            }
            else
            {
               PBox.Location = CarteJ2;
               CarteJ2.X += 18;
               CarteJ2.Y -= 2;
            }

            if (joueur.GetTotal() + paquet[posPaquet].GetValeur() > LimitBlackjack && paquet[posPaquet].GetValeur() == BigValueAs)
            {
               paquet[posPaquet].SetValeur(SmallValueAs);
            }
            joueur.SetTotal(joueur.GetTotal() + paquet[posPaquet].GetValeur());

            this.Controls.Add(PBox);
            PBox.BringToFront();
         }
         else
         {
            MessageBox.Show("Position dans le paquet de carte invalide");

         }
         LB_Total_J1.Text = J1.GetTotal().ToString();
         LB_Total_J2.Text = J2.GetTotal().ToString();
      }

      private void BTN_Commencer_Click(object sender, EventArgs e)
      {
         BTN_Commencer.Visible = false;
         while (CompteurCarte < 4)
         {
            if (A_Qui_Le_Tour == 1)
            {
               AfficherUneCarte(CompteurCarte, J1);
               J1.CalculerStat(paquet, CompteurCarte);
               A_Qui_Le_Tour = 2;
            }
            else
            {
               AfficherUneCarte(CompteurCarte, J2);
               J2.CalculerStat(paquet, CompteurCarte);
               A_Qui_Le_Tour = 1;
            }
            CompteurCarte++;
         }         
         ButtonRefresh();
         CheckFinPartie();
         if (J1.GetCpuLevel() > 0 && J2.GetCpuLevel() > 0)
         {
            while (J1.JoueEncore() || J2.JoueEncore())
            {
               JouerAi();
            }
         }
      }

      private void ButtonRefresh()
      {
         //Si seulement le joueur 1 est un CPU
         if (A_Qui_Le_Tour == 1 && !J1.JoueEncore() && J2.JoueEncore())
         {            
            A_Qui_Le_Tour = 2;
         }
         else if (A_Qui_Le_Tour == 2 && J1.JoueEncore() && !J2.JoueEncore()) //Ajout impromptu
         {
            A_Qui_Le_Tour = 1;
         }
      }

      private void BTN_Continuer_J1_Click(object sender, EventArgs e)
      {
         Jouer(1);
         J1.CalculerStat(paquet, CompteurCarte);
      }

      private void BTN_Continuer_J2_Click(object sender, EventArgs e)
      {
         Jouer(2);
         J2.CalculerStat(paquet, CompteurCarte);
         J1.CalculerStat(paquet, CompteurCarte);
         J1.AIJoueEncore();
         if (J1.JoueEncore() && J1.GetCpuLevel() > 0)
         {
            Jouer(1);
         }
         else if (J1.GetCpuLevel() > 0 && !J1.JoueEncore())
         {
            ButtonRefresh();
         }
         CheckFinPartie();
      }

      private void JouerAi()
      {
         J1.CalculerStat(paquet, CompteurCarte);
         J2.CalculerStat(paquet, CompteurCarte);
         if (A_Qui_Le_Tour == 1 && J1.JoueEncore() && J1.AIJoueEncore())
         {
            AfficherUneCarte(CompteurCarte, J1);
            CompteurCarte++;
            ButtonRefresh();
         }
         A_Qui_Le_Tour = 2;
         if (A_Qui_Le_Tour == 2 && J2.JoueEncore() && J2.AIJoueEncore())
         {
            AfficherUneCarte(CompteurCarte, J2);
            CompteurCarte++;
            ButtonRefresh();
         }
         A_Qui_Le_Tour = 1;
         CheckFinPartie();
      }

      private void Jouer(int QuiJoue)
      {
         if (QuiJoue == 1 && J1.JoueEncore())
         {
            AfficherUneCarte(CompteurCarte, J1);
            CompteurCarte++;
            A_Qui_Le_Tour = 2;
            QuiJoue = 2;
            ButtonRefresh();
         }
         else if (QuiJoue == 2 && J2.JoueEncore())
         {
            AfficherUneCarte(CompteurCarte, J2);
            CompteurCarte++;
            A_Qui_Le_Tour = 1;
            QuiJoue = 1;
            ButtonRefresh();
         }
         else if (QuiJoue == 1 && !J1.JoueEncore())
         {
            A_Qui_Le_Tour = 2;
            QuiJoue = 2;
            ButtonRefresh();
         }
         CheckFinPartie();
      }

      private void CheckFinPartie()
      {
         if (J1.GetTotal() > LimitBlackjack)
         {
            J1.ArreteDeJouer();
            AfficherBlackJack("Gagnant!");
         }
         if (J2.GetTotal() > LimitBlackjack)
         {
            J2.ArreteDeJouer();
            AfficherBlackJack("Gagnant!");
         }
         if (J1.GetTotal() == 21 || J2.GetTotal() == 21)
         {
            AfficherBlackJack("BlackJack!");
         }
         else if (!J1.JoueEncore() && !J2.JoueEncore())
         {
            AfficherBlackJack("Gagnant!");
         }

      }

      private void AfficherBlackJack(String message)
      {
         if (J1.GetTotal() < J2.GetTotal())
         {
            if (J2.GetTotal() <= LimitBlackjack)
            {
               //victoire ++ J2
            }
            else
            {
               //Bust J2
            }
            J1.ArreteDeJouer();
         }
         if (J2.GetTotal() < J1.GetTotal())
         {
            if (J1.GetTotal() <= LimitBlackjack)
            {
               //victoire ++ J1
            }
            else
            {
               //Bust J1
            }
            J2.ArreteDeJouer();
         }
         if (J1.GetTotal() == J2.GetTotal())
         {
            //partie égal
         }
      }

      private void BTN_Quit_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
