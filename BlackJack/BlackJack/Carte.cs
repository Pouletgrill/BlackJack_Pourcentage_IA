/////////////////////
// Class Carte     //
// Xavier Brosseau //
// Charlie Laplante//
/////////////////////
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
   class Carte
   {
      Image cartePNG_ = null;
      String path_ = null;
      int valeur_;

      public Carte(String Path)
      {
         cartePNG_ = Image.FromFile(Path);
         path_ = Path;
      }
      public Carte(String Path, int Valeur)
      {
         cartePNG_ = Image.FromFile(Path);
         path_ = Path;
         valeur_ = Valeur;
      }

      public void SetValeur(int Valeur)
      {
         valeur_ = Valeur;
      }

      public Image GetImage()
      {
         return cartePNG_;
      }

      public String GetPath()
      {
         return path_;
      }

      public int GetValeur()
      {
         return valeur_;
      }
   }
}
