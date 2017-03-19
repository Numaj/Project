namespace WindowsForms_3_4
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1_list_commande = new System.Windows.Forms.ListBox();
            this.comboBox1_gestion_commandes = new System.Windows.Forms.ComboBox();
            this.Rechercher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des commandes";
            // 
            // listBox1_list_commande
            // 
            this.listBox1_list_commande.FormattingEnabled = true;
            this.listBox1_list_commande.Location = new System.Drawing.Point(14, 127);
            this.listBox1_list_commande.Name = "listBox1_list_commande";
            this.listBox1_list_commande.Size = new System.Drawing.Size(239, 121);
            this.listBox1_list_commande.TabIndex = 1;
            // 
            // comboBox1_gestion_commandes
            // 
            this.comboBox1_gestion_commandes.FormattingEnabled = true;
            this.comboBox1_gestion_commandes.Location = new System.Drawing.Point(14, 47);
            this.comboBox1_gestion_commandes.Name = "comboBox1_gestion_commandes";
            this.comboBox1_gestion_commandes.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_gestion_commandes.TabIndex = 2;
            // 
            // Rechercher
            // 
            this.Rechercher.Location = new System.Drawing.Point(152, 45);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(75, 23);
            this.Rechercher.TabIndex = 3;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liste des commandes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID, Nom, Prénom, Date, Heure";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.comboBox1_gestion_commandes);
            this.Controls.Add(this.listBox1_list_commande);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Kitbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1_list_commande;
        private System.Windows.Forms.ComboBox comboBox1_gestion_commandes;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

