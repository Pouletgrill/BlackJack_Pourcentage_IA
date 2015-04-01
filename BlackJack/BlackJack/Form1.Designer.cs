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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.PN_AI_1 = new System.Windows.Forms.Panel();
         this.RB_AI_Prudent1 = new System.Windows.Forms.RadioButton();
         this.RB_AI_Moyen1 = new System.Windows.Forms.RadioButton();
         this.RB_AI_Courageux1 = new System.Windows.Forms.RadioButton();
         this.RB_CPU1 = new System.Windows.Forms.RadioButton();
         this.RB_Humain1 = new System.Windows.Forms.RadioButton();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.PN_AI_2 = new System.Windows.Forms.Panel();
         this.RB_AI_Prudent2 = new System.Windows.Forms.RadioButton();
         this.RB_AI_Moyen2 = new System.Windows.Forms.RadioButton();
         this.RB_AI_Courageux2 = new System.Windows.Forms.RadioButton();
         this.RB_CPU2 = new System.Windows.Forms.RadioButton();
         this.RB_Humain2 = new System.Windows.Forms.RadioButton();
         this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
         this.CB_Compter1 = new System.Windows.Forms.CheckBox();
         this.CB_Compter2 = new System.Windows.Forms.CheckBox();
         this.groupBox1.SuspendLayout();
         this.PN_AI_1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.PN_AI_2.SuspendLayout();
         this.SuspendLayout();
         // 
         // BTN_Jouer
         // 
         this.BTN_Jouer.Location = new System.Drawing.Point(12, 258);
         this.BTN_Jouer.Name = "BTN_Jouer";
         this.BTN_Jouer.Size = new System.Drawing.Size(211, 39);
         this.BTN_Jouer.TabIndex = 0;
         this.BTN_Jouer.Text = "Jouer";
         this.BTN_Jouer.UseVisualStyleBackColor = true;
         this.BTN_Jouer.Click += new System.EventHandler(this.BTN_Jouer_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.PN_AI_1);
         this.groupBox1.Controls.Add(this.RB_CPU1);
         this.groupBox1.Controls.Add(this.RB_Humain1);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(211, 117);
         this.groupBox1.TabIndex = 3;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Joueur 1";
         // 
         // PN_AI_1
         // 
         this.PN_AI_1.Controls.Add(this.CB_Compter1);
         this.PN_AI_1.Controls.Add(this.RB_AI_Prudent1);
         this.PN_AI_1.Controls.Add(this.RB_AI_Moyen1);
         this.PN_AI_1.Controls.Add(this.RB_AI_Courageux1);
         this.PN_AI_1.Enabled = false;
         this.PN_AI_1.Location = new System.Drawing.Point(88, 10);
         this.PN_AI_1.Name = "PN_AI_1";
         this.PN_AI_1.Size = new System.Drawing.Size(117, 101);
         this.PN_AI_1.TabIndex = 2;
         // 
         // RB_AI_Prudent1
         // 
         this.RB_AI_Prudent1.AutoSize = true;
         this.RB_AI_Prudent1.Location = new System.Drawing.Point(5, 56);
         this.RB_AI_Prudent1.Name = "RB_AI_Prudent1";
         this.RB_AI_Prudent1.Size = new System.Drawing.Size(62, 17);
         this.RB_AI_Prudent1.TabIndex = 5;
         this.RB_AI_Prudent1.Text = "Prudent";
         this.RB_AI_Prudent1.UseVisualStyleBackColor = true;
         // 
         // RB_AI_Moyen1
         // 
         this.RB_AI_Moyen1.AutoSize = true;
         this.RB_AI_Moyen1.Location = new System.Drawing.Point(5, 33);
         this.RB_AI_Moyen1.Name = "RB_AI_Moyen1";
         this.RB_AI_Moyen1.Size = new System.Drawing.Size(57, 17);
         this.RB_AI_Moyen1.TabIndex = 4;
         this.RB_AI_Moyen1.Text = "Moyen";
         this.RB_AI_Moyen1.UseVisualStyleBackColor = true;
         // 
         // RB_AI_Courageux1
         // 
         this.RB_AI_Courageux1.AutoSize = true;
         this.RB_AI_Courageux1.Checked = true;
         this.RB_AI_Courageux1.Location = new System.Drawing.Point(5, 10);
         this.RB_AI_Courageux1.Name = "RB_AI_Courageux1";
         this.RB_AI_Courageux1.Size = new System.Drawing.Size(76, 17);
         this.RB_AI_Courageux1.TabIndex = 3;
         this.RB_AI_Courageux1.TabStop = true;
         this.RB_AI_Courageux1.Text = "Courageux";
         this.RB_AI_Courageux1.UseVisualStyleBackColor = true;
         // 
         // RB_CPU1
         // 
         this.RB_CPU1.AutoSize = true;
         this.RB_CPU1.Location = new System.Drawing.Point(7, 43);
         this.RB_CPU1.Name = "RB_CPU1";
         this.RB_CPU1.Size = new System.Drawing.Size(47, 17);
         this.RB_CPU1.TabIndex = 1;
         this.RB_CPU1.Text = "CPU";
         this.RB_CPU1.UseVisualStyleBackColor = true;
         this.RB_CPU1.CheckedChanged += new System.EventHandler(this.RB_Humain1_and_RB_CPU1_CheckedChanged);
         // 
         // RB_Humain1
         // 
         this.RB_Humain1.AutoSize = true;
         this.RB_Humain1.Checked = true;
         this.RB_Humain1.Location = new System.Drawing.Point(7, 20);
         this.RB_Humain1.Name = "RB_Humain1";
         this.RB_Humain1.Size = new System.Drawing.Size(61, 17);
         this.RB_Humain1.TabIndex = 0;
         this.RB_Humain1.TabStop = true;
         this.RB_Humain1.Text = "Humain";
         this.RB_Humain1.UseVisualStyleBackColor = true;
         this.RB_Humain1.CheckedChanged += new System.EventHandler(this.RB_Humain1_and_RB_CPU1_CheckedChanged);
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.PN_AI_2);
         this.groupBox2.Controls.Add(this.RB_CPU2);
         this.groupBox2.Controls.Add(this.RB_Humain2);
         this.groupBox2.Location = new System.Drawing.Point(12, 135);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(211, 117);
         this.groupBox2.TabIndex = 4;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Joueur 2";
         // 
         // PN_AI_2
         // 
         this.PN_AI_2.Controls.Add(this.CB_Compter2);
         this.PN_AI_2.Controls.Add(this.RB_AI_Prudent2);
         this.PN_AI_2.Controls.Add(this.RB_AI_Moyen2);
         this.PN_AI_2.Controls.Add(this.RB_AI_Courageux2);
         this.PN_AI_2.Enabled = false;
         this.PN_AI_2.Location = new System.Drawing.Point(88, 10);
         this.PN_AI_2.Name = "PN_AI_2";
         this.PN_AI_2.Size = new System.Drawing.Size(117, 101);
         this.PN_AI_2.TabIndex = 2;
         // 
         // RB_AI_Prudent2
         // 
         this.RB_AI_Prudent2.AutoSize = true;
         this.RB_AI_Prudent2.Location = new System.Drawing.Point(5, 56);
         this.RB_AI_Prudent2.Name = "RB_AI_Prudent2";
         this.RB_AI_Prudent2.Size = new System.Drawing.Size(62, 17);
         this.RB_AI_Prudent2.TabIndex = 5;
         this.RB_AI_Prudent2.Text = "Prudent";
         this.RB_AI_Prudent2.UseVisualStyleBackColor = true;
         // 
         // RB_AI_Moyen2
         // 
         this.RB_AI_Moyen2.AutoSize = true;
         this.RB_AI_Moyen2.Location = new System.Drawing.Point(5, 33);
         this.RB_AI_Moyen2.Name = "RB_AI_Moyen2";
         this.RB_AI_Moyen2.Size = new System.Drawing.Size(57, 17);
         this.RB_AI_Moyen2.TabIndex = 4;
         this.RB_AI_Moyen2.Text = "Moyen";
         this.RB_AI_Moyen2.UseVisualStyleBackColor = true;
         // 
         // RB_AI_Courageux2
         // 
         this.RB_AI_Courageux2.AutoSize = true;
         this.RB_AI_Courageux2.Checked = true;
         this.RB_AI_Courageux2.Location = new System.Drawing.Point(5, 10);
         this.RB_AI_Courageux2.Name = "RB_AI_Courageux2";
         this.RB_AI_Courageux2.Size = new System.Drawing.Size(76, 17);
         this.RB_AI_Courageux2.TabIndex = 3;
         this.RB_AI_Courageux2.TabStop = true;
         this.RB_AI_Courageux2.Text = "Courageux";
         this.RB_AI_Courageux2.UseVisualStyleBackColor = true;
         // 
         // RB_CPU2
         // 
         this.RB_CPU2.AutoSize = true;
         this.RB_CPU2.Location = new System.Drawing.Point(7, 43);
         this.RB_CPU2.Name = "RB_CPU2";
         this.RB_CPU2.Size = new System.Drawing.Size(47, 17);
         this.RB_CPU2.TabIndex = 1;
         this.RB_CPU2.Text = "CPU";
         this.RB_CPU2.UseVisualStyleBackColor = true;
         this.RB_CPU2.CheckedChanged += new System.EventHandler(this.RB_Humain2_and_RB_CPU2_CheckedChanged);
         // 
         // RB_Humain2
         // 
         this.RB_Humain2.AutoSize = true;
         this.RB_Humain2.Checked = true;
         this.RB_Humain2.Location = new System.Drawing.Point(7, 20);
         this.RB_Humain2.Name = "RB_Humain2";
         this.RB_Humain2.Size = new System.Drawing.Size(61, 17);
         this.RB_Humain2.TabIndex = 0;
         this.RB_Humain2.TabStop = true;
         this.RB_Humain2.Text = "Humain";
         this.RB_Humain2.UseVisualStyleBackColor = true;
         this.RB_Humain2.CheckedChanged += new System.EventHandler(this.RB_Humain2_and_RB_CPU2_CheckedChanged);
         // 
         // CB_Compter1
         // 
         this.CB_Compter1.AutoSize = true;
         this.CB_Compter1.Location = new System.Drawing.Point(5, 79);
         this.CB_Compter1.Name = "CB_Compter1";
         this.CB_Compter1.Size = new System.Drawing.Size(97, 17);
         this.CB_Compter1.TabIndex = 6;
         this.CB_Compter1.Text = "Compter cartes";
         this.CB_Compter1.UseVisualStyleBackColor = true;
         // 
         // CB_Compter2
         // 
         this.CB_Compter2.AutoSize = true;
         this.CB_Compter2.Location = new System.Drawing.Point(5, 79);
         this.CB_Compter2.Name = "CB_Compter2";
         this.CB_Compter2.Size = new System.Drawing.Size(97, 17);
         this.CB_Compter2.TabIndex = 7;
         this.CB_Compter2.Text = "Compter cartes";
         this.CB_Compter2.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(235, 305);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.BTN_Jouer);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Form1";
         this.Text = "BlackJack !";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.PN_AI_1.ResumeLayout(false);
         this.PN_AI_1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.PN_AI_2.ResumeLayout(false);
         this.PN_AI_2.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button BTN_Jouer;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Panel PN_AI_1;
      private System.Windows.Forms.RadioButton RB_AI_Prudent1;
      private System.Windows.Forms.RadioButton RB_AI_Moyen1;
      private System.Windows.Forms.RadioButton RB_AI_Courageux1;
      private System.Windows.Forms.RadioButton RB_CPU1;
      private System.Windows.Forms.RadioButton RB_Humain1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Panel PN_AI_2;
      private System.Windows.Forms.RadioButton RB_AI_Prudent2;
      private System.Windows.Forms.RadioButton RB_AI_Moyen2;
      private System.Windows.Forms.RadioButton RB_AI_Courageux2;
      private System.Windows.Forms.RadioButton RB_CPU2;
      private System.Windows.Forms.RadioButton RB_Humain2;
      private System.ComponentModel.BackgroundWorker backgroundWorker1;
      private System.Windows.Forms.CheckBox CB_Compter1;
      private System.Windows.Forms.CheckBox CB_Compter2;
   }
}

