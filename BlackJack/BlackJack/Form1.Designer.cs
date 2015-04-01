namespace BlackJack
{
   partial class Form1
   {
      /// <summary>
      /// Variable nécessaire au concepteur.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Nettoyage des ressources utilisées.
      /// </summary>
      /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Code généré par le Concepteur Windows Form

      /// <summary>
      /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
      /// le contenu de cette méthode avec l'éditeur de code.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.BTN_Jouer = new System.Windows.Forms.Button();
         this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
         this.SuspendLayout();
         // 
         // BTN_Jouer
         // 
         this.BTN_Jouer.Location = new System.Drawing.Point(12, 12);
         this.BTN_Jouer.Name = "BTN_Jouer";
         this.BTN_Jouer.Size = new System.Drawing.Size(211, 39);
         this.BTN_Jouer.TabIndex = 0;
         this.BTN_Jouer.Text = "Jouer";
         this.BTN_Jouer.UseVisualStyleBackColor = true;
         this.BTN_Jouer.Click += new System.EventHandler(this.BTN_Jouer_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(235, 62);
         this.Controls.Add(this.BTN_Jouer);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Form1";
         this.Text = "BlackJack !";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button BTN_Jouer;
      private System.ComponentModel.BackgroundWorker backgroundWorker1;
   }
}

