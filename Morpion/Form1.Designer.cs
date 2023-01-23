namespace Morpion
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
            this.lbl_j1 = new System.Windows.Forms.Label();
            this.lbl_j2 = new System.Windows.Forms.Label();
            this.lblj1 = new System.Windows.Forms.Label();
            this.lbl_cptj1 = new System.Windows.Forms.Label();
            this.lblj2 = new System.Windows.Forms.Label();
            this.lbl_cptj2 = new System.Windows.Forms.Label();
            this.lbl_Nul = new System.Windows.Forms.Label();
            this.lbl_cptNul = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btn_re = new System.Windows.Forms.Button();
            this.txtj1 = new System.Windows.Forms.TextBox();
            this.txtj2 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.c5 = new System.Windows.Forms.Button();
            this.c6 = new System.Windows.Forms.Button();
            this.c7 = new System.Windows.Forms.Button();
            this.c8 = new System.Windows.Forms.Button();
            this.c9 = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.Label();
            this.gg = new System.Windows.Forms.Label();
            this.gagnant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_j1
            // 
            this.lbl_j1.AutoSize = true;
            this.lbl_j1.Location = new System.Drawing.Point(205, 17);
            this.lbl_j1.Name = "lbl_j1";
            this.lbl_j1.Size = new System.Drawing.Size(57, 13);
            this.lbl_j1.TabIndex = 0;
            this.lbl_j1.Text = "Joueur 1 : ";
            this.lbl_j1.Click += new System.EventHandler(this.lbl_j1_Click);
            // 
            // lbl_j2
            // 
            this.lbl_j2.AutoSize = true;
            this.lbl_j2.Location = new System.Drawing.Point(483, 20);
            this.lbl_j2.Name = "lbl_j2";
            this.lbl_j2.Size = new System.Drawing.Size(57, 13);
            this.lbl_j2.TabIndex = 1;
            this.lbl_j2.Text = "Joueur 2 : ";
            // 
            // lblj1
            // 
            this.lblj1.AutoSize = true;
            this.lblj1.Location = new System.Drawing.Point(146, 102);
            this.lblj1.Name = "lblj1";
            this.lblj1.Size = new System.Drawing.Size(54, 13);
            this.lblj1.TabIndex = 2;
            this.lblj1.Text = "joueur 1 : ";
            this.lblj1.Visible = false;
            // 
            // lbl_cptj1
            // 
            this.lbl_cptj1.AutoSize = true;
            this.lbl_cptj1.Location = new System.Drawing.Point(186, 102);
            this.lbl_cptj1.Name = "lbl_cptj1";
            this.lbl_cptj1.Size = new System.Drawing.Size(30, 13);
            this.lbl_cptj1.TabIndex = 3;
            this.lbl_cptj1.Text = "cptj1";
            this.lbl_cptj1.Visible = false;
            // 
            // lblj2
            // 
            this.lblj2.AutoSize = true;
            this.lblj2.Location = new System.Drawing.Point(360, 102);
            this.lblj2.Name = "lblj2";
            this.lblj2.Size = new System.Drawing.Size(54, 13);
            this.lblj2.TabIndex = 4;
            this.lblj2.Text = "joueur 2 : ";
            this.lblj2.Visible = false;
            // 
            // lbl_cptj2
            // 
            this.lbl_cptj2.AutoSize = true;
            this.lbl_cptj2.Location = new System.Drawing.Point(402, 102);
            this.lbl_cptj2.Name = "lbl_cptj2";
            this.lbl_cptj2.Size = new System.Drawing.Size(30, 13);
            this.lbl_cptj2.TabIndex = 5;
            this.lbl_cptj2.Text = "cptj2";
            this.lbl_cptj2.Visible = false;
            // 
            // lbl_Nul
            // 
            this.lbl_Nul.AutoSize = true;
            this.lbl_Nul.Location = new System.Drawing.Point(583, 102);
            this.lbl_Nul.Name = "lbl_Nul";
            this.lbl_Nul.Size = new System.Drawing.Size(32, 13);
            this.lbl_Nul.TabIndex = 6;
            this.lbl_Nul.Text = "Nul : ";
            this.lbl_Nul.Visible = false;
            this.lbl_Nul.Click += new System.EventHandler(this.lbl_Nul_Click);
            // 
            // lbl_cptNul
            // 
            this.lbl_cptNul.AutoSize = true;
            this.lbl_cptNul.Location = new System.Drawing.Point(621, 102);
            this.lbl_cptNul.Name = "lbl_cptNul";
            this.lbl_cptNul.Size = new System.Drawing.Size(38, 13);
            this.lbl_cptNul.TabIndex = 7;
            this.lbl_cptNul.Text = "cptNul";
            this.lbl_cptNul.Visible = false;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(356, 53);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(106, 28);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
            // 
            // btn_re
            // 
            this.btn_re.Location = new System.Drawing.Point(332, 563);
            this.btn_re.Name = "btn_re";
            this.btn_re.Size = new System.Drawing.Size(100, 28);
            this.btn_re.TabIndex = 9;
            this.btn_re.Text = "Rejouer";
            this.btn_re.UseVisualStyleBackColor = true;
            this.btn_re.Visible = false;
            // 
            // txtj1
            // 
            this.txtj1.Location = new System.Drawing.Point(259, 14);
            this.txtj1.Name = "txtj1";
            this.txtj1.Size = new System.Drawing.Size(68, 20);
            this.txtj1.TabIndex = 10;
            this.txtj1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtj2
            // 
            this.txtj2.Location = new System.Drawing.Point(534, 17);
            this.txtj2.Name = "txtj2";
            this.txtj2.Size = new System.Drawing.Size(68, 20);
            this.txtj2.TabIndex = 11;
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(208, 185);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(100, 100);
            this.c1.TabIndex = 12;
            this.c1.Text = " ";
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Visible = false;
            this.c1.Click += new System.EventHandler(this.c1_Click_1);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(332, 185);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(100, 100);
            this.c2.TabIndex = 13;
            this.c2.Text = " ";
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Visible = false;
            this.c2.Click += new System.EventHandler(this.c2_Click_1);
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(458, 185);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(100, 100);
            this.c3.TabIndex = 14;
            this.c3.Text = " ";
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Visible = false;
            this.c3.Click += new System.EventHandler(this.c3_Click_1);
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(208, 302);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(100, 100);
            this.c4.TabIndex = 15;
            this.c4.Text = " ";
            this.c4.UseVisualStyleBackColor = true;
            this.c4.Visible = false;
            this.c4.Click += new System.EventHandler(this.c4_Click_1);
            // 
            // c5
            // 
            this.c5.Location = new System.Drawing.Point(332, 302);
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(100, 100);
            this.c5.TabIndex = 16;
            this.c5.Text = " ";
            this.c5.UseVisualStyleBackColor = true;
            this.c5.Visible = false;
            this.c5.Click += new System.EventHandler(this.c5_Click_1);
            // 
            // c6
            // 
            this.c6.Location = new System.Drawing.Point(458, 302);
            this.c6.Name = "c6";
            this.c6.Size = new System.Drawing.Size(100, 100);
            this.c6.TabIndex = 17;
            this.c6.Text = " ";
            this.c6.UseVisualStyleBackColor = true;
            this.c6.Visible = false;
            this.c6.Click += new System.EventHandler(this.c6_Click_1);
            // 
            // c7
            // 
            this.c7.Location = new System.Drawing.Point(208, 419);
            this.c7.Name = "c7";
            this.c7.Size = new System.Drawing.Size(100, 100);
            this.c7.TabIndex = 18;
            this.c7.Text = " ";
            this.c7.UseVisualStyleBackColor = true;
            this.c7.Visible = false;
            this.c7.Click += new System.EventHandler(this.c7_Click_1);
            // 
            // c8
            // 
            this.c8.Location = new System.Drawing.Point(332, 419);
            this.c8.Name = "c8";
            this.c8.Size = new System.Drawing.Size(100, 100);
            this.c8.TabIndex = 19;
            this.c8.Text = " ";
            this.c8.UseVisualStyleBackColor = true;
            this.c8.Visible = false;
            this.c8.Click += new System.EventHandler(this.c8_Click_1);
            // 
            // c9
            // 
            this.c9.Location = new System.Drawing.Point(458, 419);
            this.c9.Name = "c9";
            this.c9.Size = new System.Drawing.Size(100, 100);
            this.c9.TabIndex = 20;
            this.c9.Text = " ";
            this.c9.UseVisualStyleBackColor = true;
            this.c9.Visible = false;
            this.c9.Click += new System.EventHandler(this.c9_Click_1);
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.Location = new System.Drawing.Point(146, 87);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(53, 13);
            this.t1.TabIndex = 21;
            this.t1.Text = "Votre tour";
            this.t1.Visible = false;
            this.t1.Click += new System.EventHandler(this.label1_Click);
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Location = new System.Drawing.Point(365, 84);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(53, 13);
            this.t2.TabIndex = 22;
            this.t2.Text = "Votre tour";
            this.t2.Visible = false;
            // 
            // gg
            // 
            this.gg.AutoSize = true;
            this.gg.Location = new System.Drawing.Point(266, 144);
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(0, 13);
            this.gg.TabIndex = 23;
            this.gg.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // gagnant
            // 
            this.gagnant.AutoSize = true;
            this.gagnant.Location = new System.Drawing.Point(360, 144);
            this.gagnant.Name = "gagnant";
            this.gagnant.Size = new System.Drawing.Size(46, 13);
            this.gagnant.TabIndex = 24;
            this.gagnant.Text = "gagnant";
            this.gagnant.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 616);
            this.Controls.Add(this.gagnant);
            this.Controls.Add(this.gg);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.c9);
            this.Controls.Add(this.c8);
            this.Controls.Add(this.c7);
            this.Controls.Add(this.c6);
            this.Controls.Add(this.c5);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.txtj2);
            this.Controls.Add(this.txtj1);
            this.Controls.Add(this.btn_re);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lbl_cptNul);
            this.Controls.Add(this.lbl_Nul);
            this.Controls.Add(this.lbl_cptj2);
            this.Controls.Add(this.lblj2);
            this.Controls.Add(this.lbl_cptj1);
            this.Controls.Add(this.lblj1);
            this.Controls.Add(this.lbl_j2);
            this.Controls.Add(this.lbl_j1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe !";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_j1;
        private System.Windows.Forms.Label lbl_j2;
        private System.Windows.Forms.Label lblj1;
        private System.Windows.Forms.Label lbl_cptj1;
        private System.Windows.Forms.Label lblj2;
        private System.Windows.Forms.Label lbl_cptj2;
        private System.Windows.Forms.Label lbl_Nul;
        private System.Windows.Forms.Label lbl_cptNul;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btn_re;
        private System.Windows.Forms.TextBox txtj1;
        private System.Windows.Forms.TextBox txtj2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button c5;
        private System.Windows.Forms.Button c6;
        private System.Windows.Forms.Button c7;
        private System.Windows.Forms.Button c8;
        private System.Windows.Forms.Button c9;
        private System.Windows.Forms.Label t1;
        private System.Windows.Forms.Label t2;
        private System.Windows.Forms.Label gg;
        private System.Windows.Forms.Label gagnant;
    }
}

