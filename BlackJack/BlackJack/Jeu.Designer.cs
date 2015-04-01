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
         this.SuspendLayout();
         // 
         // BTN_Commencer
         // 
         this.BTN_Commencer.BackColor = System.Drawing.Color.Green;
         this.BTN_Commencer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.BTN_Commencer.Location = new System.Drawing.Point(12, 12);
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
         this.BTN_Quit.Location = new System.Drawing.Point(12, 88);
         this.BTN_Quit.Name = "BTN_Quit";
         this.BTN_Quit.Size = new System.Drawing.Size(164, 70);
         this.BTN_Quit.TabIndex = 10;
         this.BTN_Quit.Text = "Arrêter";
         this.BTN_Quit.UseVisualStyleBackColor = false;
         this.BTN_Quit.Click += new System.EventHandler(this.BTN_Quit_Click);
         // 
         // Jeu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(751, 172);
         this.Controls.Add(this.BTN_Quit);
         this.Controls.Add(this.BTN_Commencer);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Jeu";
         this.Text = "BlackJack !";
         this.Load += new System.EventHandler(this.Jeu_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button BTN_Commencer;
      private System.Windows.Forms.Button BTN_Quit;

   }
}