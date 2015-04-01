namespace BlackJack
{
   partial class Jeu
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jeu));
         this.BTN_Commencer = new System.Windows.Forms.Button();
         this.BTN_Quit = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.LB_Total_J2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.LB_Total_J1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // BTN_Commencer
         // 
         this.BTN_Commencer.BackColor = System.Drawing.Color.Green;
         this.BTN_Commencer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.BTN_Commencer.Location = new System.Drawing.Point(298, 12);
         this.BTN_Commencer.Name = "BTN_Commencer";
         this.BTN_Commencer.Size = new System.Drawing.Size(164, 70);
         this.BTN_Commencer.TabIndex = 4;
         this.BTN_Commencer.Text = "Commencer";
         this.BTN_Commencer.UseVisualStyleBackColor = false;
         this.BTN_Commencer.Click += new System.EventHandler(this.BTN_Commencer_Click);
         // 
         // BTN_Quit
         // 
         this.BTN_Quit.BackColor = System.Drawing.Color.Green;
         this.BTN_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.BTN_Quit.Location = new System.Drawing.Point(343, 252);
         this.BTN_Quit.Name = "BTN_Quit";
         this.BTN_Quit.Size = new System.Drawing.Size(75, 23);
         this.BTN_Quit.TabIndex = 10;
         this.BTN_Quit.Text = "Arrêter le jeu";
         this.BTN_Quit.UseVisualStyleBackColor = false;
         this.BTN_Quit.Click += new System.EventHandler(this.BTN_Quit_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Green;
         this.label2.Location = new System.Drawing.Point(545, 13);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(81, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "Total Joueur 2 :";
         // 
         // LB_Total_J2
         // 
         this.LB_Total_J2.AutoSize = true;
         this.LB_Total_J2.BackColor = System.Drawing.Color.Green;
         this.LB_Total_J2.Location = new System.Drawing.Point(632, 12);
         this.LB_Total_J2.Name = "LB_Total_J2";
         this.LB_Total_J2.Size = new System.Drawing.Size(13, 13);
         this.LB_Total_J2.TabIndex = 8;
         this.LB_Total_J2.Text = "0";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Green;
         this.label1.Location = new System.Drawing.Point(37, 12);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(81, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Total Joueur 1 :";
         // 
         // LB_Total_J1
         // 
         this.LB_Total_J1.AutoSize = true;
         this.LB_Total_J1.BackColor = System.Drawing.Color.Green;
         this.LB_Total_J1.Location = new System.Drawing.Point(125, 11);
         this.LB_Total_J1.Name = "LB_Total_J1";
         this.LB_Total_J1.Size = new System.Drawing.Size(13, 13);
         this.LB_Total_J1.TabIndex = 7;
         this.LB_Total_J1.Text = "0";
         // 
         // Jeu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(751, 289);
         this.Controls.Add(this.BTN_Quit);
         this.Controls.Add(this.LB_Total_J2);
         this.Controls.Add(this.LB_Total_J1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.BTN_Commencer);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Jeu";
         this.Text = "BlackJack !";
         this.Load += new System.EventHandler(this.Jeu_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button BTN_Commencer;
      private System.Windows.Forms.Button BTN_Quit;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label LB_Total_J2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label LB_Total_J1;

   }
}