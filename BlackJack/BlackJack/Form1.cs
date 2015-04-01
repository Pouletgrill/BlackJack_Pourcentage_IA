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
   public partial class Form1 : Form
   {

      public Form1()
      {
         InitializeComponent();
      }

      private void BTN_Jouer_Click(object sender, EventArgs e)
      {
         int pourcentage = 40;
         int DifficulterAi = 1;

         for (int i = pourcentage; i <= 80; i++)
         {
            for (int j = 0; i < 10/*Doit etre 1000*/; j++)
            {
               for (int k=0; k<3; k++)
               {
                  Jeu Principal = new Jeu(i, true, DifficulterAi, true);
                  Principal.ShowDialog();
               }               
            }
         }
      }
   }
}
