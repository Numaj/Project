namespace Kitbox
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
            this.btn_help_form1 = new System.Windows.Forms.Button();
            this.label1_form1 = new System.Windows.Forms.Label();
            this.btn_compose_form1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_help_form1
            // 
            this.btn_help_form1.Location = new System.Drawing.Point(157, 80);
            this.btn_help_form1.Name = "btn_help_form1";
            this.btn_help_form1.Size = new System.Drawing.Size(115, 23);
            this.btn_help_form1.TabIndex = 1;
            this.btn_help_form1.Text = "Catalog and Help";
            this.btn_help_form1.UseVisualStyleBackColor = true;
            // 
            // label1_form1
            // 
            this.label1_form1.AutoSize = true;
            this.label1_form1.Location = new System.Drawing.Point(83, 40);
            this.label1_form1.Name = "label1_form1";
            this.label1_form1.Size = new System.Drawing.Size(94, 13);
            this.label1_form1.TabIndex = 2;
            this.label1_form1.Text = "Order a cabinet kit";
            // 
            // btn_compose_form1
            // 
            this.btn_compose_form1.Location = new System.Drawing.Point(13, 80);
            this.btn_compose_form1.Name = "btn_compose_form1";
            this.btn_compose_form1.Size = new System.Drawing.Size(110, 23);
            this.btn_compose_form1.TabIndex = 3;
            this.btn_compose_form1.Text = "Compose an order";
            this.btn_compose_form1.UseVisualStyleBackColor = true;
            this.btn_compose_form1.Click += new System.EventHandler(this.btn_compose_form1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 139);
            this.Controls.Add(this.btn_compose_form1);
            this.Controls.Add(this.label1_form1);
            this.Controls.Add(this.btn_help_form1);
            this.Name = "Form1";
            this.Text = "Kitbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_help_form1;
        private System.Windows.Forms.Label label1_form1;
        private System.Windows.Forms.Button btn_compose_form1;
    }
}