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
            this.BTN_Continuer_J1 = new System.Windows.Forms.Button();
            this.BTN_Arreter_J1 = new System.Windows.Forms.Button();
            this.BTN_Continuer_J2 = new System.Windows.Forms.Button();
            this.BTN_Arreter_J2 = new System.Windows.Forms.Button();
            this.BTN_Commencer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_Total_J1 = new System.Windows.Forms.Label();
            this.LB_Total_J2 = new System.Windows.Forms.Label();
            this.BTN_Quit = new System.Windows.Forms.Button();
            this.LB_J1_Depasse = new System.Windows.Forms.Label();
            this.LB_J2_Depasse = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_J1_Stats = new System.Windows.Forms.Label();
            this.LB_J2_Stats = new System.Windows.Forms.Label();
            this.BTN_J2_Details = new System.Windows.Forms.Button();
            this.BTN_J1_Details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Continuer_J1
            // 
            this.BTN_Continuer_J1.BackColor = System.Drawing.Color.Green;
            this.BTN_Continuer_J1.Enabled = false;
            this.BTN_Continuer_J1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Continuer_J1.Location = new System.Drawing.Point(15, 252);
            this.BTN_Continuer_J1.Name = "BTN_Continuer_J1";
            this.BTN_Continuer_J1.Size = new System.Drawing.Size(103, 31);
            this.BTN_Continuer_J1.TabIndex = 0;
            this.BTN_Continuer_J1.Text = "Continuer";
            this.BTN_Continuer_J1.UseVisualStyleBackColor = false;
            this.BTN_Continuer_J1.Click += new System.EventHandler(this.BTN_Continuer_J1_Click);
            // 
            // BTN_Arreter_J1
            // 
            this.BTN_Arreter_J1.BackColor = System.Drawing.Color.Green;
            this.BTN_Arreter_J1.Enabled = false;
            this.BTN_Arreter_J1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Arreter_J1.Location = new System.Drawing.Point(124, 252);
            this.BTN_Arreter_J1.Name = "BTN_Arreter_J1";
            this.BTN_Arreter_J1.Size = new System.Drawing.Size(107, 31);
            this.BTN_Arreter_J1.TabIndex = 1;
            this.BTN_Arreter_J1.Text = "Arrêter";
            this.BTN_Arreter_J1.UseVisualStyleBackColor = false;
            this.BTN_Arreter_J1.Click += new System.EventHandler(this.BTN_Arreter_J1_Click);
            // 
            // BTN_Continuer_J2
            // 
            this.BTN_Continuer_J2.BackColor = System.Drawing.Color.Green;
            this.BTN_Continuer_J2.Enabled = false;
            this.BTN_Continuer_J2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Continuer_J2.Location = new System.Drawing.Point(523, 252);
            this.BTN_Continuer_J2.Name = "BTN_Continuer_J2";
            this.BTN_Continuer_J2.Size = new System.Drawing.Size(103, 31);
            this.BTN_Continuer_J2.TabIndex = 2;
            this.BTN_Continuer_J2.Text = "Continuer";
            this.BTN_Continuer_J2.UseVisualStyleBackColor = false;
            this.BTN_Continuer_J2.Click += new System.EventHandler(this.BTN_Continuer_J2_Click);
            // 
            // BTN_Arreter_J2
            // 
            this.BTN_Arreter_J2.BackColor = System.Drawing.Color.Green;
            this.BTN_Arreter_J2.Enabled = false;
            this.BTN_Arreter_J2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Arreter_J2.Location = new System.Drawing.Point(632, 252);
            this.BTN_Arreter_J2.Name = "BTN_Arreter_J2";
            this.BTN_Arreter_J2.Size = new System.Drawing.Size(107, 31);
            this.BTN_Arreter_J2.TabIndex = 3;
            this.BTN_Arreter_J2.Text = "Arrêter";
            this.BTN_Arreter_J2.UseVisualStyleBackColor = false;
            this.BTN_Arreter_J2.Click += new System.EventHandler(this.BTN_Arreter_J2_Click);
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
            // LB_J1_Depasse
            // 
            this.LB_J1_Depasse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LB_J1_Depasse.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_J1_Depasse.Location = new System.Drawing.Point(15, 133);
            this.LB_J1_Depasse.Name = "LB_J1_Depasse";
            this.LB_J1_Depasse.Size = new System.Drawing.Size(216, 44);
            this.LB_J1_Depasse.TabIndex = 11;
            this.LB_J1_Depasse.Text = "Dépassé !";
            this.LB_J1_Depasse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_J1_Depasse.Visible = false;
            // 
            // LB_J2_Depasse
            // 
            this.LB_J2_Depasse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LB_J2_Depasse.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_J2_Depasse.Location = new System.Drawing.Point(523, 133);
            this.LB_J2_Depasse.Name = "LB_J2_Depasse";
            this.LB_J2_Depasse.Size = new System.Drawing.Size(216, 44);
            this.LB_J2_Depasse.TabIndex = 12;
            this.LB_J2_Depasse.Text = "Dépassé !";
            this.LB_J2_Depasse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_J2_Depasse.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(68, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Chance :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(576, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chance :";
            // 
            // LB_J1_Stats
            // 
            this.LB_J1_Stats.AutoSize = true;
            this.LB_J1_Stats.BackColor = System.Drawing.Color.Green;
            this.LB_J1_Stats.Location = new System.Drawing.Point(125, 25);
            this.LB_J1_Stats.Name = "LB_J1_Stats";
            this.LB_J1_Stats.Size = new System.Drawing.Size(33, 13);
            this.LB_J1_Stats.TabIndex = 15;
            this.LB_J1_Stats.Text = "100%";
            // 
            // LB_J2_Stats
            // 
            this.LB_J2_Stats.AutoSize = true;
            this.LB_J2_Stats.BackColor = System.Drawing.Color.Green;
            this.LB_J2_Stats.Location = new System.Drawing.Point(632, 26);
            this.LB_J2_Stats.Name = "LB_J2_Stats";
            this.LB_J2_Stats.Size = new System.Drawing.Size(33, 13);
            this.LB_J2_Stats.TabIndex = 16;
            this.LB_J2_Stats.Text = "100%";
            // 
            // BTN_J2_Details
            // 
            this.BTN_J2_Details.BackColor = System.Drawing.Color.Green;
            this.BTN_J2_Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_J2_Details.Location = new System.Drawing.Point(468, 12);
            this.BTN_J2_Details.Name = "BTN_J2_Details";
            this.BTN_J2_Details.Size = new System.Drawing.Size(47, 23);
            this.BTN_J2_Details.TabIndex = 17;
            this.BTN_J2_Details.Text = "Details";
            this.BTN_J2_Details.UseVisualStyleBackColor = false;
            this.BTN_J2_Details.Visible = false;
            this.BTN_J2_Details.Click += new System.EventHandler(this.BTN_J2_Details_Click);
            // 
            // BTN_J1_Details
            // 
            this.BTN_J1_Details.BackColor = System.Drawing.Color.Green;
            this.BTN_J1_Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_J1_Details.Location = new System.Drawing.Point(245, 13);
            this.BTN_J1_Details.Name = "BTN_J1_Details";
            this.BTN_J1_Details.Size = new System.Drawing.Size(47, 23);
            this.BTN_J1_Details.TabIndex = 18;
            this.BTN_J1_Details.Text = "Details";
            this.BTN_J1_Details.UseVisualStyleBackColor = false;
            this.BTN_J1_Details.Visible = false;
            this.BTN_J1_Details.Click += new System.EventHandler(this.BTN_J1_Details_Click);
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 289);
            this.Controls.Add(this.BTN_J1_Details);
            this.Controls.Add(this.BTN_J2_Details);
            this.Controls.Add(this.LB_J2_Stats);
            this.Controls.Add(this.LB_J1_Stats);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_J2_Depasse);
            this.Controls.Add(this.LB_J1_Depasse);
            this.Controls.Add(this.BTN_Quit);
            this.Controls.Add(this.LB_Total_J2);
            this.Controls.Add(this.LB_Total_J1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Commencer);
            this.Controls.Add(this.BTN_Arreter_J2);
            this.Controls.Add(this.BTN_Continuer_J2);
            this.Controls.Add(this.BTN_Arreter_J1);
            this.Controls.Add(this.BTN_Continuer_J1);
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

      private System.Windows.Forms.Button BTN_Continuer_J1;
      private System.Windows.Forms.Button BTN_Arreter_J1;
      private System.Windows.Forms.Button BTN_Continuer_J2;
      private System.Windows.Forms.Button BTN_Arreter_J2;
      private System.Windows.Forms.Button BTN_Commencer;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label LB_Total_J1;
      private System.Windows.Forms.Label LB_Total_J2;
      private System.Windows.Forms.Button BTN_Quit;
      private System.Windows.Forms.Label LB_J1_Depasse;
      private System.Windows.Forms.Label LB_J2_Depasse;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label LB_J1_Stats;
      private System.Windows.Forms.Label LB_J2_Stats;
      private System.Windows.Forms.Button BTN_J2_Details;
      private System.Windows.Forms.Button BTN_J1_Details;
   }
}