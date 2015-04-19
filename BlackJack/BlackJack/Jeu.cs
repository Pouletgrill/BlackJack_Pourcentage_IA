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
        int x = 0;
        List<Carte> paquet = new List<Carte>();
        List<int> ScoreJ1 = new List<int>();
        List<int> ScoreJ2 = new List<int>();
        List<int> ScoreNull = new List<int>();
        //Point CarteJ1 = new Point(15, 100);
        //Point CarteJ2 = new Point(523, 100);
        Joueur J1;
        Joueur J2;
        int pourcentage;
        const int POURCENTSTART = 40;
        const int POURCENTSTOP = 80;
        int A_Qui_Le_Tour = 1;
        int CompteurCarte = 0;
        bool finFinal = false;

        //const int CarteHeight = 127;
        //const int CarteWidth = 88;
        const int BigValueAs = 11;
        const int SmallValueAs = 1;
        const int LimitBlackjack = 21;

        public Jeu()
        {
            InitializeComponent();
        }
        private void Jeu_Load(object sender, EventArgs e)
        {


        }

        private void AutomaticAiLogic()
        {
            string resultat = string.Empty;
            ScoreJ1.Clear();
            ScoreJ2.Clear();
            ScoreNull.Clear();
            for (int q = 0; q < 3; q++)
            {
                for (int i = POURCENTSTART; i <= POURCENTSTOP; i += 5)
                {
                    x = 0;
                    pourcentage = i;
                    ScoreJ1.Add(0);
                    ScoreJ2.Add(0);
                    ScoreNull.Add(0);
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            finFinal = false;
                            J1 = new Joueur(i, true, "J1");
                            if (k == 1 - 1)
                                J2 = new Joueur(50, true, "J2");
                            else if (k == 2 - 1)
                                J2 = new Joueur(65, true, "J2");
                            else if (k == 3 - 1)
                                J2 = new Joueur(80, true, "J2");
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
                            ButtonRefresh();
                            CheckFinPartie();
                        }
                    }
                    //textBox1.Text += "[" + pourcentage.ToString() + "] " + ScoreJ1[x].ToString() + " J1 \r\n" +
                    //"[" + pourcentage.ToString() + "] " + ScoreJ2[x].ToString() + " J2 \r\n" +
                    //"[" + pourcentage.ToString() + "] " + ScoreNull[x].ToString() + " null \r\n" +
                    //"~*~\r\n";
                    resultat += "[" + pourcentage.ToString() + "] " + ScoreJ1[x].ToString() + " J1 " + ScoreJ2[x].ToString() + " J2 " + ScoreNull[x].ToString() + " Null \r\n";
                    x++;
                }
                resultat += "\r\n***\r\n";
            }
            textBox1.Text = resultat;
            BTN_Commencer.Visible = true;
            MessageBox.Show("Fini");

        }

        private void LoadCarte()
        {
            paquet.Clear();
            A_Qui_Le_Tour = 1;
            CompteurCarte = 0;
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
                paquet.Add(new Carte(valeur));
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

                if (joueur.GetTotal() + paquet[posPaquet].GetValeur() > LimitBlackjack && paquet[posPaquet].GetValeur() == BigValueAs)
                {
                    paquet[posPaquet].SetValeur(SmallValueAs);
                }
                joueur.SetTotal(joueur.GetTotal() + paquet[posPaquet].GetValeur());

            }
            else
            {
                MessageBox.Show("Position dans le paquet de carte invalide");

            }
        }

        private void BTN_Commencer_Click(object sender, EventArgs e)
        {
            AutomaticAiLogic();
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
            if (J1.GetTotal() > LimitBlackjack && !finFinal)
            {
                J1.ArreteDeJouer();
                AfficherBlackJack("Gagnant!");
            }
            if (J2.GetTotal() > LimitBlackjack && !finFinal)
            {
                J2.ArreteDeJouer();
                AfficherBlackJack("Gagnant!");
            }
            if ((J1.GetTotal() == 21 || J2.GetTotal() == 21) && !finFinal)
            {
                AfficherBlackJack("BlackJack!");
            }
            else if (!J1.JoueEncore() && !J2.JoueEncore() && !finFinal)
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
                    ScoreJ2[x] += 1;
                    finFinal = true;
                }
                else
                {
                    //Bust J2
                    ScoreJ1[x] += 1;
                    finFinal = true;
                }
                J1.ArreteDeJouer();
            }
            if (J2.GetTotal() < J1.GetTotal())
            {
                if (J1.GetTotal() <= LimitBlackjack)
                {
                    //victoire ++ J1
                    ScoreJ1[x] += 1;
                    finFinal = true;
                }
                else
                {
                    //Bust J1
                    ScoreJ2[x] += 1;
                    finFinal = true;
                }
                J2.ArreteDeJouer();
            }
            if (J1.GetTotal() == J2.GetTotal())
            {
                //partie égal
                //MessageBox.Show(pourcentage.ToString() + " Partie égal");
                ScoreNull[x] += 1;
                finFinal = true;
            }
        }

        private void BTN_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
