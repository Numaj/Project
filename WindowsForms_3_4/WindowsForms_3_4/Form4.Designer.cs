namespace WindowsForms_3_4
{
    partial class Form4
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
            this.button1_gestion_stock = new System.Windows.Forms.Button();
            this.button2_Gestion_commande = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_gestion_stock
            // 
            this.button1_gestion_stock.Location = new System.Drawing.Point(25, 37);
            this.button1_gestion_stock.Name = "button1_gestion_stock";
            this.button1_gestion_stock.Size = new System.Drawing.Size(140, 23);
            this.button1_gestion_stock.TabIndex = 0;
            this.button1_gestion_stock.Text = "Gestion du stock";
            this.button1_gestion_stock.UseVisualStyleBackColor = true;
            this.button1_gestion_stock.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_Gestion_commande
            // 
            this.button2_Gestion_commande.Location = new System.Drawing.Point(25, 77);
            this.button2_Gestion_commande.Name = "button2_Gestion_commande";
            this.button2_Gestion_commande.Size = new System.Drawing.Size(140, 23);
            this.button2_Gestion_commande.TabIndex = 1;
            this.button2_Gestion_commande.Text = "Gestion de commande";
            this.button2_Gestion_commande.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.button2_Gestion_commande);
            this.Controls.Add(this.button1_gestion_stock);
            this.Name = "Form4";
            this.Text = "Kitbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_gestion_stock;
        private System.Windows.Forms.Button button2_Gestion_commande;
    }
}