namespace WindowsFormsApplication2
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
            this.LabeListeDvd = new System.Windows.Forms.Label();
            this.LstDvd = new System.Windows.Forms.ListBox();
            this.btnAjoutDvd = new System.Windows.Forms.Button();
            this.btnSupprDvd = new System.Windows.Forms.Button();
            this.btnModifDvd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnSupprGenre = new System.Windows.Forms.Button();
            this.btnAjoutGenre = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstActeur = new System.Windows.Forms.ListBox();
            this.btnAjoutActeurDvd = new System.Windows.Forms.Button();
            this.btnSupprActeurDvd = new System.Windows.Forms.Button();
            this.txtAjoutActeur = new System.Windows.Forms.TextBox();
            this.btnSupprActeur = new System.Windows.Forms.Button();
            this.btnAjoutActeur = new System.Windows.Forms.Button();
            this.cboActeur = new System.Windows.Forms.ComboBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabeListeDvd
            // 
            this.LabeListeDvd.AutoSize = true;
            this.LabeListeDvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabeListeDvd.Location = new System.Drawing.Point(12, 9);
            this.LabeListeDvd.Name = "LabeListeDvd";
            this.LabeListeDvd.Size = new System.Drawing.Size(112, 20);
            this.LabeListeDvd.TabIndex = 0;
            this.LabeListeDvd.Text = "Liste des DVD";
            // 
            // LstDvd
            // 
            this.LstDvd.FormattingEnabled = true;
            this.LstDvd.Location = new System.Drawing.Point(12, 35);
            this.LstDvd.Name = "LstDvd";
            this.LstDvd.Size = new System.Drawing.Size(203, 342);
            this.LstDvd.TabIndex = 1;
            this.LstDvd.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAjoutDvd
            // 
            this.btnAjoutDvd.Location = new System.Drawing.Point(231, 35);
            this.btnAjoutDvd.Name = "btnAjoutDvd";
            this.btnAjoutDvd.Size = new System.Drawing.Size(134, 38);
            this.btnAjoutDvd.TabIndex = 2;
            this.btnAjoutDvd.Text = "Ajouter un film";
            this.btnAjoutDvd.UseVisualStyleBackColor = true;
            this.btnAjoutDvd.Click += new System.EventHandler(this.btnAjoutDvd_Click);
            // 
            // btnSupprDvd
            // 
            this.btnSupprDvd.Location = new System.Drawing.Point(231, 79);
            this.btnSupprDvd.Name = "btnSupprDvd";
            this.btnSupprDvd.Size = new System.Drawing.Size(134, 35);
            this.btnSupprDvd.TabIndex = 3;
            this.btnSupprDvd.Text = "Supprimer un film";
            this.btnSupprDvd.UseVisualStyleBackColor = true;
            this.btnSupprDvd.Click += new System.EventHandler(this.btnSupprDvd_Click);
            // 
            // btnModifDvd
            // 
            this.btnModifDvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnModifDvd.Location = new System.Drawing.Point(12, 396);
            this.btnModifDvd.Name = "btnModifDvd";
            this.btnModifDvd.Size = new System.Drawing.Size(860, 46);
            this.btnModifDvd.TabIndex = 4;
            this.btnModifDvd.Text = "Enregistrer les modifications";
            this.btnModifDvd.UseVisualStyleBackColor = true;
            this.btnModifDvd.Click += new System.EventHandler(this.btnModifDvd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(407, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(458, 9);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(414, 20);
            this.txtTitre.TabIndex = 6;
            this.txtTitre.TextChanged += new System.EventHandler(this.txtTitre_TextChanged);
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(458, 37);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(414, 20);
            this.txtDuree.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(394, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Duree";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(395, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Genre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(458, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(273, 20);
            this.textBox4.TabIndex = 11;
            // 
            // btnSupprGenre
            // 
            this.btnSupprGenre.Location = new System.Drawing.Point(738, 69);
            this.btnSupprGenre.Name = "btnSupprGenre";
            this.btnSupprGenre.Size = new System.Drawing.Size(134, 23);
            this.btnSupprGenre.TabIndex = 12;
            this.btnSupprGenre.Text = "Supprimer Genre";
            this.btnSupprGenre.UseVisualStyleBackColor = true;
            // 
            // btnAjoutGenre
            // 
            this.btnAjoutGenre.Location = new System.Drawing.Point(738, 99);
            this.btnAjoutGenre.Name = "btnAjoutGenre";
            this.btnAjoutGenre.Size = new System.Drawing.Size(134, 23);
            this.btnAjoutGenre.TabIndex = 13;
            this.btnAjoutGenre.Text = "Ajouter Genre";
            this.btnAjoutGenre.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(385, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Acteurs";
            // 
            // lstActeur
            // 
            this.lstActeur.FormattingEnabled = true;
            this.lstActeur.Location = new System.Drawing.Point(459, 136);
            this.lstActeur.Name = "lstActeur";
            this.lstActeur.Size = new System.Drawing.Size(273, 173);
            this.lstActeur.TabIndex = 15;
            this.lstActeur.SelectedIndexChanged += new System.EventHandler(this.lstActeur_SelectedIndexChanged);
            // 
            // btnAjoutActeurDvd
            // 
            this.btnAjoutActeurDvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAjoutActeurDvd.Location = new System.Drawing.Point(739, 136);
            this.btnAjoutActeurDvd.Name = "btnAjoutActeurDvd";
            this.btnAjoutActeurDvd.Size = new System.Drawing.Size(75, 34);
            this.btnAjoutActeurDvd.TabIndex = 16;
            this.btnAjoutActeurDvd.Text = "+";
            this.btnAjoutActeurDvd.UseVisualStyleBackColor = true;
            this.btnAjoutActeurDvd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSupprActeurDvd
            // 
            this.btnSupprActeurDvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSupprActeurDvd.Location = new System.Drawing.Point(738, 176);
            this.btnSupprActeurDvd.Name = "btnSupprActeurDvd";
            this.btnSupprActeurDvd.Size = new System.Drawing.Size(76, 35);
            this.btnSupprActeurDvd.TabIndex = 17;
            this.btnSupprActeurDvd.Text = "-";
            this.btnSupprActeurDvd.UseVisualStyleBackColor = true;
            // 
            // txtAjoutActeur
            // 
            this.txtAjoutActeur.Location = new System.Drawing.Point(459, 362);
            this.txtAjoutActeur.Name = "txtAjoutActeur";
            this.txtAjoutActeur.Size = new System.Drawing.Size(272, 20);
            this.txtAjoutActeur.TabIndex = 19;
            // 
            // btnSupprActeur
            // 
            this.btnSupprActeur.Location = new System.Drawing.Point(739, 322);
            this.btnSupprActeur.Name = "btnSupprActeur";
            this.btnSupprActeur.Size = new System.Drawing.Size(133, 23);
            this.btnSupprActeur.TabIndex = 20;
            this.btnSupprActeur.Text = "Supprimer Acteur";
            this.btnSupprActeur.UseVisualStyleBackColor = true;
            // 
            // btnAjoutActeur
            // 
            this.btnAjoutActeur.Location = new System.Drawing.Point(739, 359);
            this.btnAjoutActeur.Name = "btnAjoutActeur";
            this.btnAjoutActeur.Size = new System.Drawing.Size(133, 23);
            this.btnAjoutActeur.TabIndex = 21;
            this.btnAjoutActeur.Text = "Ajouter Acteur";
            this.btnAjoutActeur.UseVisualStyleBackColor = true;
            // 
            // cboActeur
            // 
            this.cboActeur.FormattingEnabled = true;
            this.cboActeur.Location = new System.Drawing.Point(460, 322);
            this.cboActeur.Name = "cboActeur";
            this.cboActeur.Size = new System.Drawing.Size(272, 21);
            this.cboActeur.TabIndex = 22;
            this.cboActeur.SelectedIndexChanged += new System.EventHandler(this.cboActeur_SelectedIndexChanged);
            // 
            // cboGenre
            // 
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(459, 71);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(273, 21);
            this.cboGenre.TabIndex = 23;
            this.cboGenre.SelectedIndexChanged += new System.EventHandler(this.cboGenre_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.cboActeur);
            this.Controls.Add(this.btnAjoutActeur);
            this.Controls.Add(this.btnSupprActeur);
            this.Controls.Add(this.txtAjoutActeur);
            this.Controls.Add(this.btnSupprActeurDvd);
            this.Controls.Add(this.btnAjoutActeurDvd);
            this.Controls.Add(this.lstActeur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAjoutGenre);
            this.Controls.Add(this.btnSupprGenre);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifDvd);
            this.Controls.Add(this.btnSupprDvd);
            this.Controls.Add(this.btnAjoutDvd);
            this.Controls.Add(this.LstDvd);
            this.Controls.Add(this.LabeListeDvd);
            this.Name = "Form1";
            this.Text = "Gestion des DVD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabeListeDvd;
        private System.Windows.Forms.ListBox LstDvd;
        private System.Windows.Forms.Button btnAjoutDvd;
        private System.Windows.Forms.Button btnSupprDvd;
        private System.Windows.Forms.Button btnModifDvd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSupprGenre;
        private System.Windows.Forms.Button btnAjoutGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstActeur;
        private System.Windows.Forms.Button btnAjoutActeurDvd;
        private System.Windows.Forms.Button btnSupprActeurDvd;
        private System.Windows.Forms.TextBox txtAjoutActeur;
        private System.Windows.Forms.Button btnSupprActeur;
        private System.Windows.Forms.Button btnAjoutActeur;
        private System.Windows.Forms.ComboBox cboActeur;
        private System.Windows.Forms.ComboBox cboGenre;
    }
}

