
namespace Login_APP
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.sv_btn = new System.Windows.Forms.Button();
            this.del_txt = new System.Windows.Forms.Button();
            this.upd_txt = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone:";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(68, 23);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(125, 27);
            this.id_txt.TabIndex = 4;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(68, 59);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(125, 27);
            this.name_txt.TabIndex = 5;
            // 
            // surname_txt
            // 
            this.surname_txt.Location = new System.Drawing.Point(286, 23);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(125, 27);
            this.surname_txt.TabIndex = 6;
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(286, 62);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(125, 27);
            this.phone_txt.TabIndex = 7;
            // 
            // sv_btn
            // 
            this.sv_btn.Location = new System.Drawing.Point(33, 119);
            this.sv_btn.Name = "sv_btn";
            this.sv_btn.Size = new System.Drawing.Size(94, 29);
            this.sv_btn.TabIndex = 8;
            this.sv_btn.Text = "Add\\Save";
            this.sv_btn.UseVisualStyleBackColor = true;
            this.sv_btn.Click += new System.EventHandler(this.sv_btn_Click);
            // 
            // del_txt
            // 
            this.del_txt.Location = new System.Drawing.Point(170, 119);
            this.del_txt.Name = "del_txt";
            this.del_txt.Size = new System.Drawing.Size(94, 29);
            this.del_txt.TabIndex = 9;
            this.del_txt.Text = "Delete";
            this.del_txt.UseVisualStyleBackColor = true;
            this.del_txt.Click += new System.EventHandler(this.del_txt_Click);
            // 
            // upd_txt
            // 
            this.upd_txt.Location = new System.Drawing.Point(299, 119);
            this.upd_txt.Name = "upd_txt";
            this.upd_txt.Size = new System.Drawing.Size(94, 29);
            this.upd_txt.TabIndex = 10;
            this.upd_txt.Text = "Update";
            this.upd_txt.UseVisualStyleBackColor = true;
            this.upd_txt.Click += new System.EventHandler(this.upd_txt_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 167);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(399, 188);
            this.dgv.TabIndex = 11;
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 367);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.upd_txt);
            this.Controls.Add(this.del_txt);
            this.Controls.Add(this.sv_btn);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.surname_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button upd_txt;
        private System.Windows.Forms.Button del_txt;
        private System.Windows.Forms.Button sv_btn;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox surname_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label4;
    }
}
