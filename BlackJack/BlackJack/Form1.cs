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

      private void RB_Humain1_and_RB_CPU1_CheckedChanged(object sender, EventArgs e)
      {
         if (RB_CPU1.Checked)
         {
            PN_AI_1.Enabled = true;
         }
         else
         {
            PN_AI_1.Enabled = false;
         }
      }

      private void RB_Humain2_and_RB_CPU2_CheckedChanged(object sender, EventArgs e)
      {
         if (RB_CPU2.Checked)
         {
            PN_AI_2.Enabled = true;
         }
         else
         {
            PN_AI_2.Enabled = false;
         }
      }

      private void BTN_Jouer_Click(object sender, EventArgs e)
      {
         int DifficulterAi1 = 3;
         int DifficulterAi2 = 3;

         if (RB_CPU1.Checked)
         {
            if (RB_AI_Prudent1.Checked)
               DifficulterAi1 = 3;
            else if (RB_AI_Moyen1.Checked)
               DifficulterAi1 = 2;
            else if (RB_AI_Courageux1.Checked)
               DifficulterAi1 = 1;
         }


         if (RB_CPU2.Checked)
         {
            if (RB_AI_Prudent2.Checked)
               DifficulterAi2 = 3;
            else if (RB_AI_Moyen2.Checked)
               DifficulterAi2 = 2;
            else if (RB_AI_Courageux2.Checked)
               DifficulterAi2 = 1;
         }
   

         if (RB_CPU1.Checked && !RB_CPU2.Checked)
         {
            Jeu Principal = new Jeu(DifficulterAi1, CB_Compter1.Checked);
            Principal.ShowDialog();            
         }
         else if (!RB_CPU1.Checked && RB_CPU2.Checked)
         {
            Jeu Principal = new Jeu(DifficulterAi2, CB_Compter2.Checked);
            Principal.ShowDialog();
         }
         else if(RB_CPU1.Checked && RB_CPU2.Checked)
         {
            Jeu Principal = new Jeu(DifficulterAi1, CB_Compter1.Checked, DifficulterAi2, CB_Compter2.Checked);
            Principal.ShowDialog();
         }
         else 
         {
            Jeu Principal = new Jeu();
            Principal.ShowDialog();
         }

      }
   }
}
