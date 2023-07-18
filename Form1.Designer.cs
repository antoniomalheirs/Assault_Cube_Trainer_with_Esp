namespace Esp_Hack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Infitelife = new CheckBox();
            Infiniteshield = new CheckBox();
            Infinitebullets = new CheckBox();
            Infinitepbullets = new CheckBox();
            Infiteexplosive = new CheckBox();
            Frezzyposition = new CheckBox();
            Showlistview = new CheckBox();
            Setentitylife = new CheckBox();
            Enemyfrezzy = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(44, 35);
            label1.Name = "label1";
            label1.Size = new Size(120, 19);
            label1.TabIndex = 1;
            label1.Text = "Funções do Trainer";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Infitelife
            // 
            Infitelife.AutoSize = true;
            Infitelife.Location = new Point(63, 57);
            Infitelife.Name = "Infitelife";
            Infitelife.Size = new Size(75, 19);
            Infitelife.TabIndex = 2;
            Infitelife.Text = "Infite Life";
            Infitelife.UseVisualStyleBackColor = true;
            Infitelife.CheckedChanged += Infitelife_CheckedChanged;
            // 
            // Infiniteshield
            // 
            Infiniteshield.AutoSize = true;
            Infiniteshield.Location = new Point(63, 82);
            Infiniteshield.Name = "Infiniteshield";
            Infiniteshield.Size = new Size(98, 19);
            Infiniteshield.TabIndex = 3;
            Infiniteshield.Text = "Infinite Shield";
            Infiniteshield.UseVisualStyleBackColor = true;
            Infiniteshield.CheckedChanged += Infiniteshield_CheckedChanged;
            // 
            // Infinitebullets
            // 
            Infinitebullets.AutoSize = true;
            Infinitebullets.Location = new Point(63, 107);
            Infinitebullets.Name = "Infinitebullets";
            Infinitebullets.Size = new Size(101, 19);
            Infinitebullets.TabIndex = 4;
            Infinitebullets.Text = "Infinite Bullets";
            Infinitebullets.UseVisualStyleBackColor = true;
            Infinitebullets.CheckedChanged += Infinitebullets_CheckedChanged;
            // 
            // Infinitepbullets
            // 
            Infinitepbullets.AutoSize = true;
            Infinitepbullets.Location = new Point(63, 132);
            Infinitepbullets.Name = "Infinitepbullets";
            Infinitepbullets.Size = new Size(133, 19);
            Infinitepbullets.TabIndex = 5;
            Infinitepbullets.Text = "Infinite Pistol Bullets";
            Infinitepbullets.UseVisualStyleBackColor = true;
            Infinitepbullets.CheckedChanged += Infinitepbullets_CheckedChanged;
            // 
            // Infiteexplosive
            // 
            Infiteexplosive.AutoSize = true;
            Infiteexplosive.Location = new Point(63, 157);
            Infiteexplosive.Name = "Infiteexplosive";
            Infiteexplosive.Size = new Size(115, 19);
            Infiteexplosive.TabIndex = 6;
            Infiteexplosive.Text = "Infinite Explosive";
            Infiteexplosive.UseVisualStyleBackColor = true;
            Infiteexplosive.CheckedChanged += Infiteexplosive_CheckedChanged;
            // 
            // Frezzyposition
            // 
            Frezzyposition.AutoSize = true;
            Frezzyposition.Location = new Point(63, 182);
            Frezzyposition.Name = "Frezzyposition";
            Frezzyposition.Size = new Size(104, 19);
            Frezzyposition.TabIndex = 7;
            Frezzyposition.Text = "Frezzy Position";
            Frezzyposition.UseVisualStyleBackColor = true;
            Frezzyposition.CheckedChanged += Frezzyposition_CheckedChanged;
            // 
            // Showlistview
            // 
            Showlistview.AutoSize = true;
            Showlistview.Location = new Point(63, 207);
            Showlistview.Name = "Showlistview";
            Showlistview.Size = new Size(101, 19);
            Showlistview.TabIndex = 9;
            Showlistview.Text = "Show ListView";
            Showlistview.UseVisualStyleBackColor = true;
            Showlistview.CheckedChanged += Showlistview_CheckedChanged;
            // 
            // Setentitylife
            // 
            Setentitylife.AutoSize = true;
            Setentitylife.Location = new Point(63, 232);
            Setentitylife.Name = "Setentitylife";
            Setentitylife.Size = new Size(70, 19);
            Setentitylife.TabIndex = 10;
            Setentitylife.Text = "1 Hit Kill";
            Setentitylife.UseVisualStyleBackColor = true;
            Setentitylife.CheckedChanged += Setentitylife_CheckedChanged;
            // 
            // Enemyfrezzy
            // 
            Enemyfrezzy.AutoSize = true;
            Enemyfrezzy.Location = new Point(63, 257);
            Enemyfrezzy.Name = "Enemyfrezzy";
            Enemyfrezzy.Size = new Size(97, 19);
            Enemyfrezzy.TabIndex = 11;
            Enemyfrezzy.Text = "Enemy Frezzy";
            Enemyfrezzy.UseVisualStyleBackColor = true;
            Enemyfrezzy.CheckedChanged += Enemyfrezzy_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 332);
            Controls.Add(Enemyfrezzy);
            Controls.Add(Setentitylife);
            Controls.Add(Showlistview);
            Controls.Add(Frezzyposition);
            Controls.Add(Infiteexplosive);
            Controls.Add(Infinitepbullets);
            Controls.Add(Infinitebullets);
            Controls.Add(Infiniteshield);
            Controls.Add(Infitelife);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox Infitelife;
        private CheckBox Infiniteshield;
        private CheckBox Infinitebullets;
        private CheckBox Infinitepbullets;
        private CheckBox Infiteexplosive;
        private CheckBox Frezzyposition;
        private CheckBox Showlistview;
        private CheckBox Setentitylife;
        private CheckBox Enemyfrezzy;
    }
}