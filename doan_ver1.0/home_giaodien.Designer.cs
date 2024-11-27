using System.Runtime.CompilerServices;

namespace doan_ver1._0
{
    partial class home_giaodien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_giaodien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_account = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_seach = new System.Windows.Forms.PictureBox();
            this.cb_seach = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_seach = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.table_info_accout = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.app_account = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.app_store = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pic_bill = new System.Windows.Forms.PictureBox();
            this.app_bill = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel_account.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_info_accout)).BeginInit();
            this.app_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.app_store.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bill)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel_account);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(331, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 482);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(247, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(443, 46);
            this.label7.TabIndex = 1;
            this.label7.Text = "Công ty điện máy HTĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(282, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 46);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quản Lý khoa hàng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel_account
            // 
            this.panel_account.BackColor = System.Drawing.Color.Transparent;
            this.panel_account.Controls.Add(this.tabControl1);
            this.panel_account.Controls.Add(this.table_info_accout);
            this.panel_account.Location = new System.Drawing.Point(3, 2);
            this.panel_account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_account.Name = "panel_account";
            this.panel_account.Size = new System.Drawing.Size(880, 462);
            this.panel_account.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(37, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 227);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_seach);
            this.tabPage1.Controls.Add(this.cb_seach);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txt_seach);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_seach
            // 
            this.btn_seach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_seach.Image = global::doan_ver1._0.Properties.Resources.find;
            this.btn_seach.Location = new System.Drawing.Point(566, 45);
            this.btn_seach.Name = "btn_seach";
            this.btn_seach.Size = new System.Drawing.Size(66, 50);
            this.btn_seach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_seach.TabIndex = 16;
            this.btn_seach.TabStop = false;
            this.btn_seach.Click += new System.EventHandler(this.btn_seach_Click);
            // 
            // cb_seach
            // 
            this.cb_seach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_seach.FormattingEnabled = true;
            this.cb_seach.Items.AddRange(new object[] {
            "Mã tài khoản",
            "Tên Đăng Nhập",
            "Họ và Tên",
            "Email",
            "Vai trò",
            "Thời gian tạo",
            ""});
            this.cb_seach.Location = new System.Drawing.Point(171, 58);
            this.cb_seach.Name = "cb_seach";
            this.cb_seach.Size = new System.Drawing.Size(159, 28);
            this.cb_seach.TabIndex = 15;
            this.cb_seach.Text = "Mã Sản Phẩm:";
            this.cb_seach.SelectedIndexChanged += new System.EventHandler(this.cb_seach_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(346, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 62);
            this.button1.TabIndex = 14;
            this.button1.Text = "Đăng ký TK";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txt_seach
            // 
            this.txt_seach.Location = new System.Drawing.Point(346, 58);
            this.txt_seach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_seach.Name = "txt_seach";
            this.txt_seach.Size = new System.Drawing.Size(197, 22);
            this.txt_seach.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(849, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // table_info_accout
            // 
            this.table_info_accout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_info_accout.DefaultCellStyle = dataGridViewCellStyle1;
            this.table_info_accout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table_info_accout.Location = new System.Drawing.Point(0, 265);
            this.table_info_accout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table_info_accout.Name = "table_info_accout";
            this.table_info_accout.ReadOnly = true;
            this.table_info_accout.RowHeadersWidth = 51;
            this.table_info_accout.RowTemplate.Height = 24;
            this.table_info_accout.Size = new System.Drawing.Size(880, 197);
            this.table_info_accout.TabIndex = 4;
            this.table_info_accout.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_info_accout_CellDoubleClick);
            // 
            // app_account
            // 
            this.app_account.BackColor = System.Drawing.Color.RosyBrown;
            this.app_account.Controls.Add(this.pictureBox1);
            this.app_account.Controls.Add(this.label1);
            this.app_account.Location = new System.Drawing.Point(12, 60);
            this.app_account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.app_account.Name = "app_account";
            this.app_account.Size = new System.Drawing.Size(279, 62);
            this.app_account.TabIndex = 1;
            this.app_account.Click += new System.EventHandler(this.app_account_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::doan_ver1._0.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.app_account_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản & nhân viên";
            this.label1.Click += new System.EventHandler(this.app_account_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // app_store
            // 
            this.app_store.BackColor = System.Drawing.Color.Silver;
            this.app_store.Controls.Add(this.pictureBox2);
            this.app_store.Controls.Add(this.label2);
            this.app_store.Location = new System.Drawing.Point(12, 143);
            this.app_store.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.app_store.Name = "app_store";
            this.app_store.Size = new System.Drawing.Size(279, 62);
            this.app_store.TabIndex = 2;
            this.app_store.Click += new System.EventHandler(this.app_store_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::doan_ver1._0.Properties.Resources.profile;
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách cửa hàng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 222);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 62);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::doan_ver1._0.Properties.Resources.profile;
            this.pictureBox3.Location = new System.Drawing.Point(0, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Sách Kho";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.pic_bill);
            this.panel5.Controls.Add(this.app_bill);
            this.panel5.Location = new System.Drawing.Point(12, 304);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 62);
            this.panel5.TabIndex = 2;
            // 
            // pic_bill
            // 
            this.pic_bill.Image = global::doan_ver1._0.Properties.Resources.bill;
            this.pic_bill.Location = new System.Drawing.Point(0, 10);
            this.pic_bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_bill.Name = "pic_bill";
            this.pic_bill.Size = new System.Drawing.Size(72, 50);
            this.pic_bill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_bill.TabIndex = 1;
            this.pic_bill.TabStop = false;
            // 
            // app_bill
            // 
            this.app_bill.AutoSize = true;
            this.app_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_bill.Location = new System.Drawing.Point(69, 23);
            this.app_bill.Name = "app_bill";
            this.app_bill.Size = new System.Drawing.Size(93, 25);
            this.app_bill.TabIndex = 0;
            this.app_bill.Text = "Hóa đơn";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(12, 383);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 62);
            this.panel6.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::doan_ver1._0.Properties.Resources.profile;
            this.pictureBox5.Location = new System.Drawing.Point(0, 2);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(72, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quản lý tài khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(635, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quản Lý tài khoản";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "find.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // home_giaodien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1253, 569);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.app_store);
            this.Controls.Add(this.app_account);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "home_giaodien";
            this.Text = "home_giaodien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.home_giaodien_FormClosed);
            this.Load += new System.EventHandler(this.home_giaodien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_account.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_seach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_info_accout)).EndInit();
            this.app_account.ResumeLayout(false);
            this.app_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.app_store.ResumeLayout(false);
            this.app_store.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bill)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel app_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_account;
        private System.Windows.Forms.Panel app_store;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pic_bill;
        private System.Windows.Forms.Label app_bill;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView table_info_accout;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox btn_seach;
        private System.Windows.Forms.ComboBox cb_seach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_seach;
        private System.Windows.Forms.TabPage tabPage2;
        
    }
    
}