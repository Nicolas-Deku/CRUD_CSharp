namespace WindowsFormsApplication
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.plafficheimage = new System.Windows.Forms.PictureBox();
            this.btnparccour = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plimage = new System.Windows.Forms.Panel();
            this.btnsupp = new System.Windows.Forms.Button();
            this.btnmodif = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbliste = new System.Windows.Forms.DataGridView();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnenreg = new System.Windows.Forms.Button();
            this.txtannee = new System.Windows.Forms.TextBox();
            this.txtmodele = new System.Windows.Forms.TextBox();
            this.txtmarque = new System.Windows.Forms.TextBox();
            this.txtmatricule = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.MATRICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plafficheimage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbliste)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.plafficheimage);
            this.panel1.Controls.Add(this.btnparccour);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtprix);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnannuler);
            this.panel1.Controls.Add(this.btnenreg);
            this.panel1.Controls.Add(this.txtannee);
            this.panel1.Controls.Add(this.txtmodele);
            this.panel1.Controls.Add(this.txtmarque);
            this.panel1.Controls.Add(this.txtmatricule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 566);
            this.panel1.TabIndex = 0;
            // 
            // plafficheimage
            // 
            this.plafficheimage.Location = new System.Drawing.Point(28, 375);
            this.plafficheimage.Name = "plafficheimage";
            this.plafficheimage.Size = new System.Drawing.Size(100, 50);
            this.plafficheimage.TabIndex = 16;
            this.plafficheimage.TabStop = false;
            // 
            // btnparccour
            // 
            this.btnparccour.Location = new System.Drawing.Point(147, 375);
            this.btnparccour.Name = "btnparccour";
            this.btnparccour.Size = new System.Drawing.Size(89, 43);
            this.btnparccour.TabIndex = 15;
            this.btnparccour.Text = "PARCOURIR ";
            this.btnparccour.UseVisualStyleBackColor = true;
            this.btnparccour.Click += new System.EventHandler(this.btnparccour_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(23, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "IMAGE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "PRIX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(23, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "ANNEE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "MODELE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "MARQUE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATRICULE";
            // 
            // txtprix
            // 
            this.txtprix.Location = new System.Drawing.Point(26, 311);
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(212, 20);
            this.txtprix.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.plimage);
            this.panel2.Controls.Add(this.btnsupp);
            this.panel2.Controls.Add(this.btnmodif);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbliste);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(295, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 566);
            this.panel2.TabIndex = 6;
            // 
            // plimage
            // 
            this.plimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plimage.Location = new System.Drawing.Point(598, 110);
            this.plimage.Name = "plimage";
            this.plimage.Size = new System.Drawing.Size(284, 273);
            this.plimage.TabIndex = 16;
            // 
            // btnsupp
            // 
            this.btnsupp.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupp.Location = new System.Drawing.Point(313, 476);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(212, 43);
            this.btnsupp.TabIndex = 15;
            this.btnsupp.Text = "SUPPRIMER";
            this.btnsupp.UseVisualStyleBackColor = true;
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click);
            // 
            // btnmodif
            // 
            this.btnmodif.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodif.Location = new System.Drawing.Point(54, 476);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(212, 43);
            this.btnmodif.TabIndex = 14;
            this.btnmodif.Text = "MODIFIER";
            this.btnmodif.UseVisualStyleBackColor = true;
            this.btnmodif.Click += new System.EventHandler(this.btnmodif_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(160, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 36);
            this.label7.TabIndex = 1;
            this.label7.Text = "AJOUT VOITURE";
            // 
            // tbliste
            // 
            this.tbliste.AllowUserToAddRows = false;
            this.tbliste.AllowUserToDeleteRows = false;
            this.tbliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATRICULE,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.tbliste.Location = new System.Drawing.Point(21, 78);
            this.tbliste.Name = "tbliste";
            this.tbliste.ReadOnly = true;
            this.tbliste.Size = new System.Drawing.Size(544, 348);
            this.tbliste.TabIndex = 0;
            this.tbliste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbliste_CellClick);
            // 
            // btnannuler
            // 
            this.btnannuler.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.Location = new System.Drawing.Point(28, 503);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(212, 43);
            this.btnannuler.TabIndex = 5;
            this.btnannuler.Text = "ANNULER";
            this.btnannuler.UseVisualStyleBackColor = true;
            // 
            // btnenreg
            // 
            this.btnenreg.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenreg.Location = new System.Drawing.Point(28, 441);
            this.btnenreg.Name = "btnenreg";
            this.btnenreg.Size = new System.Drawing.Size(212, 43);
            this.btnenreg.TabIndex = 4;
            this.btnenreg.Text = "ENREGISTRER";
            this.btnenreg.UseVisualStyleBackColor = true;
            this.btnenreg.Click += new System.EventHandler(this.btnenreg_Click);
            // 
            // txtannee
            // 
            this.txtannee.Location = new System.Drawing.Point(26, 250);
            this.txtannee.Name = "txtannee";
            this.txtannee.Size = new System.Drawing.Size(212, 20);
            this.txtannee.TabIndex = 3;
            // 
            // txtmodele
            // 
            this.txtmodele.Location = new System.Drawing.Point(26, 192);
            this.txtmodele.Name = "txtmodele";
            this.txtmodele.Size = new System.Drawing.Size(212, 20);
            this.txtmodele.TabIndex = 2;
            // 
            // txtmarque
            // 
            this.txtmarque.Location = new System.Drawing.Point(26, 135);
            this.txtmarque.Name = "txtmarque";
            this.txtmarque.Size = new System.Drawing.Size(212, 20);
            this.txtmarque.TabIndex = 1;
            // 
            // txtmatricule
            // 
            this.txtmatricule.Location = new System.Drawing.Point(26, 78);
            this.txtmatricule.Name = "txtmatricule";
            this.txtmatricule.Size = new System.Drawing.Size(212, 20);
            this.txtmatricule.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(271, 441);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 17;
            this.txtid.Visible = false;
            // 
            // MATRICULE
            // 
            this.MATRICULE.HeaderText = "MATRICULE";
            this.MATRICULE.Name = "MATRICULE";
            this.MATRICULE.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MARQUE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MODELE";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ANNEE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PRIX";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "IMAGE";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 566);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\' une voiture";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plafficheimage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbliste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprix;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tbliste;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnenreg;
        private System.Windows.Forms.TextBox txtannee;
        private System.Windows.Forms.TextBox txtmodele;
        private System.Windows.Forms.TextBox txtmarque;
        private System.Windows.Forms.TextBox txtmatricule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel plimage;
        private System.Windows.Forms.Button btnsupp;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.Button btnparccour;
        private System.Windows.Forms.PictureBox plafficheimage;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATRICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

