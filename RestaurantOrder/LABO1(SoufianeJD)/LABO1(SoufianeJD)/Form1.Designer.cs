namespace LABO1_SoufianeJD_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_prix_et_reduction = new System.Windows.Forms.Label();
            this.combobox_soupe = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Soupe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.combobox_entre = new System.Windows.Forms.ComboBox();
            this.label_Entré = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_platprincipaux = new System.Windows.Forms.Label();
            this.combobox_plat = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_alldesserts = new System.Windows.Forms.Label();
            this.checkbox_choux = new System.Windows.Forms.CheckBox();
            this.checkbox_sirop = new System.Windows.Forms.CheckBox();
            this.checkbox_tartepomme = new System.Windows.Forms.CheckBox();
            this.checkbox_cream = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rb_membre = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rb_ainee = new System.Windows.Forms.RadioButton();
            this.rb_enfant = new System.Windows.Forms.RadioButton();
            this.rb_adult = new System.Windows.Forms.RadioButton();
            this.label_categorie = new System.Windows.Forms.Label();
            this.panel_calculatricedecor = new System.Windows.Forms.Panel();
            this.btn_total = new System.Windows.Forms.Button();
            this.label_affichetotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_prix_et_reduction
            // 
            this.label_prix_et_reduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_prix_et_reduction.Location = new System.Drawing.Point(475, 4);
            this.label_prix_et_reduction.Name = "label_prix_et_reduction";
            this.label_prix_et_reduction.Size = new System.Drawing.Size(215, 193);
            this.label_prix_et_reduction.TabIndex = 0;
            this.label_prix_et_reduction.Text = resources.GetString("label_prix_et_reduction.Text");
            // 
            // combobox_soupe
            // 
            this.combobox_soupe.FormattingEnabled = true;
            this.combobox_soupe.Items.AddRange(new object[] {
            "Chiken-Soupe",
            "Beef-Soupe",
            "JD-Soupe",
            "Asian-Soupe"});
            this.combobox_soupe.Location = new System.Drawing.Point(6, 36);
            this.combobox_soupe.Name = "combobox_soupe";
            this.combobox_soupe.Size = new System.Drawing.Size(97, 21);
            this.combobox_soupe.TabIndex = 1;
            this.combobox_soupe.Text = "Aucune";
            this.combobox_soupe.SelectedIndexChanged += new System.EventHandler(this.combobox_soupe_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label_Soupe);
            this.panel1.Controls.Add(this.combobox_soupe);
            this.panel1.Location = new System.Drawing.Point(77, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 60);
            this.panel1.TabIndex = 2;
            // 
            // label_Soupe
            // 
            this.label_Soupe.AutoSize = true;
            this.label_Soupe.Location = new System.Drawing.Point(3, 5);
            this.label_Soupe.Name = "label_Soupe";
            this.label_Soupe.Size = new System.Drawing.Size(61, 13);
            this.label_Soupe.TabIndex = 2;
            this.label_Soupe.Text = "Les soupes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.combobox_entre);
            this.panel2.Controls.Add(this.label_Entré);
            this.panel2.Location = new System.Drawing.Point(249, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 60);
            this.panel2.TabIndex = 3;
            // 
            // combobox_entre
            // 
            this.combobox_entre.FormattingEnabled = true;
            this.combobox_entre.Items.AddRange(new object[] {
            "Salade-Verte",
            "Cake-Fromage",
            "Salade-fruits"});
            this.combobox_entre.Location = new System.Drawing.Point(6, 36);
            this.combobox_entre.Name = "combobox_entre";
            this.combobox_entre.Size = new System.Drawing.Size(101, 21);
            this.combobox_entre.TabIndex = 1;
            this.combobox_entre.Text = "Aucune";
            // 
            // label_Entré
            // 
            this.label_Entré.AutoSize = true;
            this.label_Entré.Location = new System.Drawing.Point(3, 5);
            this.label_Entré.Name = "label_Entré";
            this.label_Entré.Size = new System.Drawing.Size(62, 13);
            this.label_Entré.TabIndex = 0;
            this.label_Entré.Text = "Les entrées";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label_platprincipaux);
            this.panel3.Controls.Add(this.combobox_plat);
            this.panel3.Location = new System.Drawing.Point(152, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 76);
            this.panel3.TabIndex = 2;
            // 
            // label_platprincipaux
            // 
            this.label_platprincipaux.AutoSize = true;
            this.label_platprincipaux.Location = new System.Drawing.Point(3, 10);
            this.label_platprincipaux.Name = "label_platprincipaux";
            this.label_platprincipaux.Size = new System.Drawing.Size(100, 13);
            this.label_platprincipaux.TabIndex = 2;
            this.label_platprincipaux.Text = "Les plats principaux";
            // 
            // combobox_plat
            // 
            this.combobox_plat.FormattingEnabled = true;
            this.combobox_plat.Items.AddRange(new object[] {
            "Beef-Steak",
            "Poulet-Grillé",
            "Pizza",
            "Burger"});
            this.combobox_plat.Location = new System.Drawing.Point(6, 46);
            this.combobox_plat.Name = "combobox_plat";
            this.combobox_plat.Size = new System.Drawing.Size(97, 21);
            this.combobox_plat.TabIndex = 0;
            this.combobox_plat.Text = "Aucune";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label_alldesserts);
            this.panel4.Controls.Add(this.checkbox_choux);
            this.panel4.Controls.Add(this.checkbox_sirop);
            this.panel4.Controls.Add(this.checkbox_tartepomme);
            this.panel4.Controls.Add(this.checkbox_cream);
            this.panel4.Location = new System.Drawing.Point(54, 254);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 141);
            this.panel4.TabIndex = 3;
            // 
            // label_alldesserts
            // 
            this.label_alldesserts.AutoSize = true;
            this.label_alldesserts.Location = new System.Drawing.Point(114, 18);
            this.label_alldesserts.Name = "label_alldesserts";
            this.label_alldesserts.Size = new System.Drawing.Size(66, 13);
            this.label_alldesserts.TabIndex = 8;
            this.label_alldesserts.Text = "Les desserts";
            this.label_alldesserts.Click += new System.EventHandler(this.label_alldesserts_Click);
            // 
            // checkbox_choux
            // 
            this.checkbox_choux.AutoSize = true;
            this.checkbox_choux.Location = new System.Drawing.Point(184, 98);
            this.checkbox_choux.Name = "checkbox_choux";
            this.checkbox_choux.Size = new System.Drawing.Size(108, 17);
            this.checkbox_choux.TabIndex = 7;
            this.checkbox_choux.Text = "Choux a la crème";
            this.checkbox_choux.UseVisualStyleBackColor = true;
            // 
            // checkbox_sirop
            // 
            this.checkbox_sirop.AutoSize = true;
            this.checkbox_sirop.Location = new System.Drawing.Point(36, 98);
            this.checkbox_sirop.Name = "checkbox_sirop";
            this.checkbox_sirop.Size = new System.Drawing.Size(90, 17);
            this.checkbox_sirop.TabIndex = 6;
            this.checkbox_sirop.Text = "Sirop d\'érable";
            this.checkbox_sirop.UseVisualStyleBackColor = true;
            // 
            // checkbox_tartepomme
            // 
            this.checkbox_tartepomme.AutoSize = true;
            this.checkbox_tartepomme.Location = new System.Drawing.Point(184, 54);
            this.checkbox_tartepomme.Name = "checkbox_tartepomme";
            this.checkbox_tartepomme.Size = new System.Drawing.Size(103, 17);
            this.checkbox_tartepomme.TabIndex = 5;
            this.checkbox_tartepomme.Text = "Tarte au pomme";
            this.checkbox_tartepomme.UseVisualStyleBackColor = true;
            this.checkbox_tartepomme.CheckedChanged += new System.EventHandler(this.checkbox_tartepomme_CheckedChanged);
            // 
            // checkbox_cream
            // 
            this.checkbox_cream.AutoSize = true;
            this.checkbox_cream.Location = new System.Drawing.Point(36, 54);
            this.checkbox_cream.Name = "checkbox_cream";
            this.checkbox_cream.Size = new System.Drawing.Size(91, 17);
            this.checkbox_cream.TabIndex = 4;
            this.checkbox_cream.Text = "Crème glacée";
            this.checkbox_cream.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.rb_membre);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label_categorie);
            this.panel5.Location = new System.Drawing.Point(478, 205);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 164);
            this.panel5.TabIndex = 9;
            // 
            // rb_membre
            // 
            this.rb_membre.AutoSize = true;
            this.rb_membre.Location = new System.Drawing.Point(116, 97);
            this.rb_membre.Name = "rb_membre";
            this.rb_membre.Size = new System.Drawing.Size(63, 17);
            this.rb_membre.TabIndex = 3;
            this.rb_membre.TabStop = true;
            this.rb_membre.Text = "Membre";
            this.rb_membre.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.rb_ainee);
            this.panel6.Controls.Add(this.rb_enfant);
            this.panel6.Controls.Add(this.rb_adult);
            this.panel6.Location = new System.Drawing.Point(3, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(107, 100);
            this.panel6.TabIndex = 1;
            // 
            // rb_ainee
            // 
            this.rb_ainee.AutoSize = true;
            this.rb_ainee.Location = new System.Drawing.Point(7, 57);
            this.rb_ainee.Name = "rb_ainee";
            this.rb_ainee.Size = new System.Drawing.Size(58, 17);
            this.rb_ainee.TabIndex = 2;
            this.rb_ainee.TabStop = true;
            this.rb_ainee.Text = "Ainé(e)";
            this.rb_ainee.UseVisualStyleBackColor = true;
            // 
            // rb_enfant
            // 
            this.rb_enfant.AutoSize = true;
            this.rb_enfant.Location = new System.Drawing.Point(7, 33);
            this.rb_enfant.Name = "rb_enfant";
            this.rb_enfant.Size = new System.Drawing.Size(56, 17);
            this.rb_enfant.TabIndex = 1;
            this.rb_enfant.TabStop = true;
            this.rb_enfant.Text = "Enfant";
            this.rb_enfant.UseVisualStyleBackColor = true;
            // 
            // rb_adult
            // 
            this.rb_adult.AutoSize = true;
            this.rb_adult.Location = new System.Drawing.Point(7, 13);
            this.rb_adult.Name = "rb_adult";
            this.rb_adult.Size = new System.Drawing.Size(55, 17);
            this.rb_adult.TabIndex = 0;
            this.rb_adult.TabStop = true;
            this.rb_adult.Text = "Adulte";
            this.rb_adult.UseVisualStyleBackColor = true;
            // 
            // label_categorie
            // 
            this.label_categorie.AutoSize = true;
            this.label_categorie.Location = new System.Drawing.Point(27, 14);
            this.label_categorie.Name = "label_categorie";
            this.label_categorie.Size = new System.Drawing.Size(95, 13);
            this.label_categorie.TabIndex = 0;
            this.label_categorie.Text = "Catégorie du client";
            // 
            // panel_calculatricedecor
            // 
            this.panel_calculatricedecor.BackgroundImage = global::LABO1_SoufianeJD_.Properties.Resources.calcul_calculatrice1;
            this.panel_calculatricedecor.Location = new System.Drawing.Point(488, 375);
            this.panel_calculatricedecor.Name = "panel_calculatricedecor";
            this.panel_calculatricedecor.Size = new System.Drawing.Size(129, 81);
            this.panel_calculatricedecor.TabIndex = 10;
            this.panel_calculatricedecor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_calculatricedecor_Paint);
            // 
            // btn_total
            // 
            this.btn_total.Location = new System.Drawing.Point(623, 405);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(67, 23);
            this.btn_total.TabIndex = 0;
            this.btn_total.Text = "Total";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // label_affichetotal
            // 
            this.label_affichetotal.Location = new System.Drawing.Point(462, 459);
            this.label_affichetotal.Name = "label_affichetotal";
            this.label_affichetotal.Size = new System.Drawing.Size(183, 60);
            this.label_affichetotal.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 413);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 103);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LABO1_SoufianeJD_.Properties.Resources.Indoor_Anime_Landscape__Scenery___Background__116;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_affichetotal);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.panel_calculatricedecor);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_prix_et_reduction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_prix_et_reduction;
        private System.Windows.Forms.ComboBox combobox_soupe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Soupe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox combobox_entre;
        private System.Windows.Forms.Label label_Entré;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_platprincipaux;
        private System.Windows.Forms.ComboBox combobox_plat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_alldesserts;
        private System.Windows.Forms.CheckBox checkbox_choux;
        private System.Windows.Forms.CheckBox checkbox_sirop;
        private System.Windows.Forms.CheckBox checkbox_tartepomme;
        private System.Windows.Forms.CheckBox checkbox_cream;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rb_membre;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rb_ainee;
        private System.Windows.Forms.RadioButton rb_enfant;
        private System.Windows.Forms.RadioButton rb_adult;
        private System.Windows.Forms.Label label_categorie;
        private System.Windows.Forms.Panel panel_calculatricedecor;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Label label_affichetotal;
        private System.Windows.Forms.TextBox textBox1;
    }
}

