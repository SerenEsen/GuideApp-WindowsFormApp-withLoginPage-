
namespace Login_APP
{
    partial class Form3
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
            this.sign_reg_txt = new System.Windows.Forms.TextBox();
            this.sign_pas_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sign_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sign_reg_txt
            // 
            this.sign_reg_txt.Location = new System.Drawing.Point(168, 73);
            this.sign_reg_txt.Name = "sign_reg_txt";
            this.sign_reg_txt.Size = new System.Drawing.Size(125, 27);
            this.sign_reg_txt.TabIndex = 0;
            // 
            // sign_pas_txt
            // 
            this.sign_pas_txt.Location = new System.Drawing.Point(168, 151);
            this.sign_pas_txt.Name = "sign_pas_txt";
            this.sign_pas_txt.Size = new System.Drawing.Size(125, 27);
            this.sign_pas_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registration Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // sign_btn
            // 
            this.sign_btn.Location = new System.Drawing.Point(168, 238);
            this.sign_btn.Name = "sign_btn";
            this.sign_btn.Size = new System.Drawing.Size(125, 29);
            this.sign_btn.TabIndex = 4;
            this.sign_btn.Text = "Sıgn In";
            this.sign_btn.UseVisualStyleBackColor = true;
            this.sign_btn.Click += new System.EventHandler(this.sign_btn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 365);
            this.Controls.Add(this.sign_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sign_pas_txt);
            this.Controls.Add(this.sign_reg_txt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sign_reg_txt;
        private System.Windows.Forms.TextBox sign_pas_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sign_btn;
    }
}
