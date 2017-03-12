namespace Kitbox
{
    partial class Form2
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
            this.label1_form2 = new System.Windows.Forms.Label();
            this.label2_form2 = new System.Windows.Forms.Label();
            this.textBx_NbrCabinets = new System.Windows.Forms.TextBox();
            this.checkBx_idmHeight_form2 = new System.Windows.Forms.CheckBox();
            this.btn_back_form2 = new System.Windows.Forms.Button();
            this.btn_next_form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_form2
            // 
            this.label1_form2.AutoSize = true;
            this.label1_form2.Location = new System.Drawing.Point(23, 41);
            this.label1_form2.Name = "label1_form2";
            this.label1_form2.Size = new System.Drawing.Size(99, 13);
            this.label1_form2.TabIndex = 0;
            this.label1_form2.Text = "Number of cabinets";
            // 
            // label2_form2
            // 
            this.label2_form2.AutoSize = true;
            this.label2_form2.Location = new System.Drawing.Point(23, 103);
            this.label2_form2.Name = "label2_form2";
            this.label2_form2.Size = new System.Drawing.Size(123, 13);
            this.label2_form2.TabIndex = 1;
            this.label2_form2.Text = "Identical height for racks";
            // 
            // textBx_NbrCabinets
            // 
            this.textBx_NbrCabinets.Location = new System.Drawing.Point(159, 34);
            this.textBx_NbrCabinets.Name = "textBx_NbrCabinets";
            this.textBx_NbrCabinets.Size = new System.Drawing.Size(75, 20);
            this.textBx_NbrCabinets.TabIndex = 2;
            // 
            // checkBx_idmHeight_form2
            // 
            this.checkBx_idmHeight_form2.AutoSize = true;
            this.checkBx_idmHeight_form2.Location = new System.Drawing.Point(159, 103);
            this.checkBx_idmHeight_form2.Name = "checkBx_idmHeight_form2";
            this.checkBx_idmHeight_form2.Size = new System.Drawing.Size(15, 14);
            this.checkBx_idmHeight_form2.TabIndex = 5;
            this.checkBx_idmHeight_form2.UseVisualStyleBackColor = true;
            // 
            // btn_back_form2
            // 
            this.btn_back_form2.Location = new System.Drawing.Point(26, 158);
            this.btn_back_form2.Name = "btn_back_form2";
            this.btn_back_form2.Size = new System.Drawing.Size(75, 23);
            this.btn_back_form2.TabIndex = 6;
            this.btn_back_form2.Text = "Back";
            this.btn_back_form2.UseVisualStyleBackColor = true;
            this.btn_back_form2.Click += new System.EventHandler(this.btn_back_form2_Click);
            // 
            // btn_next_form2
            // 
            this.btn_next_form2.Location = new System.Drawing.Point(159, 158);
            this.btn_next_form2.Name = "btn_next_form2";
            this.btn_next_form2.Size = new System.Drawing.Size(75, 23);
            this.btn_next_form2.TabIndex = 7;
            this.btn_next_form2.Text = "Next";
            this.btn_next_form2.UseVisualStyleBackColor = true;
            this.btn_next_form2.Click += new System.EventHandler(this.btn_next_form2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 212);
            this.Controls.Add(this.btn_next_form2);
            this.Controls.Add(this.btn_back_form2);
            this.Controls.Add(this.checkBx_idmHeight_form2);
            this.Controls.Add(this.textBx_NbrCabinets);
            this.Controls.Add(this.label2_form2);
            this.Controls.Add(this.label1_form2);
            this.Name = "Form2";
            this.Text = "Kitbox";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_form2;
        private System.Windows.Forms.Label label2_form2;
        private System.Windows.Forms.TextBox textBx_NbrCabinets;
        private System.Windows.Forms.CheckBox checkBx_idmHeight_form2;
        private System.Windows.Forms.Button btn_back_form2;
        private System.Windows.Forms.Button btn_next_form2;
    }
}