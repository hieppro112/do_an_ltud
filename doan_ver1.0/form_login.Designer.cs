﻿namespace doan_ver1._0
{
    partial class form_login
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
            this.txt_Pass_admin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_user_admin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Pass_admin
            // 
            this.txt_Pass_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass_admin.Location = new System.Drawing.Point(284, 217);
            this.txt_Pass_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass_admin.Multiline = true;
            this.txt_Pass_admin.Name = "txt_Pass_admin";
            this.txt_Pass_admin.Size = new System.Drawing.Size(321, 37);
            this.txt_Pass_admin.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập mật khẩu:";
            // 
            // txt_user_admin
            // 
            this.txt_user_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_admin.Location = new System.Drawing.Point(284, 126);
            this.txt_user_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_user_admin.Multiline = true;
            this.txt_user_admin.Name = "txt_user_admin";
            this.txt_user_admin.Size = new System.Drawing.Size(321, 37);
            this.txt_user_admin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "ĐĂNG NHẬP: ADMIN\r\n";
            // 
            // btn_login_admin
            // 
            this.btn_login_admin.Location = new System.Drawing.Point(342, 309);
            this.btn_login_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login_admin.Name = "btn_login_admin";
            this.btn_login_admin.Size = new System.Drawing.Size(127, 42);
            this.btn_login_admin.TabIndex = 11;
            this.btn_login_admin.Text = "Đăng nhập";
            this.btn_login_admin.UseVisualStyleBackColor = true;
            this.btn_login_admin.Click += new System.EventHandler(this.btn_login_admin_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login_admin);
            this.Controls.Add(this.txt_Pass_admin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_user_admin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "form_login";
            this.Text = "form_login";
            this.Load += new System.EventHandler(this.form_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Pass_admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_user_admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login_admin;
    }
}