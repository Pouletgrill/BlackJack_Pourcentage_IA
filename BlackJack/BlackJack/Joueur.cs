/////////////////////
// Class Joueur    //
// Xavier Brosseau //
// Charlie Laplante//
/////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
   class Joueur
   {
      int TotalPoint = 0;
      String Nom_;
      float stats_ = 100;
      int Cpu_Level_ = -1;
      bool Joue_ = true;
      bool Compte_carte_ = false;
      string pense_ = "";

      public string AfficherDetails()
      {
         return pense_;
      }
      public Joueur(String Nom)
      {
         Nom_ = Nom;
      }
      public Joueur(int Cpu_Level, bool CompteCarte, String Nom)
      {
         Nom_ = Nom;
         Cpu_Level_ = Cpu_Level;
         Compte_carte_ = CompteCarte;
      }

      public float GetStat()
      {
         return stats_;
      }
      public int GetTotal()
      {
         return TotalPoint;
      }
      public string GetNom()
      {
         return Nom_;
      }
      public int GetCpuLevel()
      {
         return Cpu_Level_;
      }
      public void SetTotal(int Total)
      {
         TotalPoint = Total;
      }
      public void ArreteDeJouer()
      {
         Joue_ = false;
      }
      public bool JoueEncore()
      {
         return Joue_;
      }
      public bool AIJoueEncore()
      {
         //On vérifie si on continue ou pas
         if (JoueEncore() && GetCpuLevel() == 1 && GetStat() < 50)//Courageux
         {
            ArreteDeJouer();
            pense_ += Nom_ + ": Arrêt Courageux à " + stats_.ToString() + "%\n";
         }
         else if (JoueEncore() && GetCpuLevel() == 2 && GetStat() < 65)//Moyen
         {
            ArreteDeJouer();
            pense_ += Nom_ + ": Arrêt Moyen à " + stats_.ToString() + "%\n";
         }
         else if (JoueEncore() && GetCpuLevel() == 3 && GetStat() < 80)//Prudent
         {
            ArreteDeJouer();
            pense_ += Nom_ + ": Arrêt Prudent à " + stats_.ToString() + "%\n";
         }
         else if (JoueEncore())
         {
            pense_ += Nom_ + ": continue a jouer à " + stats_.ToString() + "%\n";
         }
         return JoueEncore();
      }

      //si les conditions ne sont plus favorable, le joueur s'arrête de lui même
      public void CalculerStat(List<Carte> paquet, int IndexCarte)
      {
         //si le total est trop bas
         if (GetTotal() > 10)
         {
            if (Compte_carte_)//Avec comptage de cartes
            {
               float nbChance = 0;
               for (int i = IndexCarte; i < paquet.Count(); i++)
               {
                  if (paquet[i].GetValeur() <= (21 - GetTotal()))
                  {
                     nbChance += 1;
                  }
                  else if (paquet[i].GetValeur() == 11 && 1 <= (21 - GetTotal()))
                  {
                     nbChance += 1;
                  }
               }
               stats_ = (nbChance / (paquet.Count() - IndexCarte)) * 100;
            }
            else //Sans comptage de cartes
            {
               float nbChance = 0;
               for (int i = 0; i < paquet.Count(); i++)
               {
                  if (paquet[i].GetValeur() <= (21 - GetTotal()))
                  {
                     nbChance += 1;
                  }
                  else if (paquet[i].GetValeur() == 11 && 1 <= (21 - GetTotal()))
                  {
                      nbChance += 1;
                  }
               }
               stats_ = (nbChance / paquet.Count()) * 100;
            }
         }
      }
   }
}
