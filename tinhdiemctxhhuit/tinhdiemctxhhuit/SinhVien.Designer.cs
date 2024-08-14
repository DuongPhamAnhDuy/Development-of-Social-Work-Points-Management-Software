namespace tinhdiemctxhhuit
{
    partial class SinhVien
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
            this.dtgv_sv = new System.Windows.Forms.DataGridView();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbl_chucnang = new System.Windows.Forms.GroupBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbx_gt = new System.Windows.Forms.ComboBox();
            this.txt_lop = new System.Windows.Forms.TextBox();
            this.txt_tensv = new System.Windows.Forms.TextBox();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbl_chucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_sv
            // 
            this.dtgv_sv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_sv.Location = new System.Drawing.Point(7, 22);
            this.dtgv_sv.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_sv.Name = "dtgv_sv";
            this.dtgv_sv.Size = new System.Drawing.Size(981, 270);
            this.dtgv_sv.TabIndex = 0;
            this.dtgv_sv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_sv_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_sv);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1001, 310);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // tbl_chucnang
            // 
            this.tbl_chucnang.Controls.Add(this.dtp_ngaysinh);
            this.tbl_chucnang.Controls.Add(this.cbx_gt);
            this.tbl_chucnang.Controls.Add(this.txt_lop);
            this.tbl_chucnang.Controls.Add(this.txt_tensv);
            this.tbl_chucnang.Controls.Add(this.txt_masv);
            this.tbl_chucnang.Controls.Add(this.label5);
            this.tbl_chucnang.Controls.Add(this.label4);
            this.tbl_chucnang.Controls.Add(this.label3);
            this.tbl_chucnang.Controls.Add(this.label2);
            this.tbl_chucnang.Controls.Add(this.label1);
            this.tbl_chucnang.Location = new System.Drawing.Point(19, 380);
            this.tbl_chucnang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbl_chucnang.Name = "tbl_chucnang";
            this.tbl_chucnang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbl_chucnang.Size = new System.Drawing.Size(788, 277);
            this.tbl_chucnang.TabIndex = 2;
            this.tbl_chucnang.TabStop = false;
            this.tbl_chucnang.Text = "Chức Năng";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(471, 33);
            this.dtp_ngaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(176, 22);
            this.dtp_ngaysinh.TabIndex = 11;
            // 
            // cbx_gt
            // 
            this.cbx_gt.FormattingEnabled = true;
            this.cbx_gt.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbx_gt.Location = new System.Drawing.Point(132, 172);
            this.cbx_gt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_gt.Name = "cbx_gt";
            this.cbx_gt.Size = new System.Drawing.Size(121, 24);
            this.cbx_gt.TabIndex = 10;
            // 
            // txt_lop
            // 
            this.txt_lop.Location = new System.Drawing.Point(471, 82);
            this.txt_lop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_lop.Name = "txt_lop";
            this.txt_lop.Size = new System.Drawing.Size(176, 22);
            this.txt_lop.TabIndex = 9;
            // 
            // txt_tensv
            // 
            this.txt_tensv.Location = new System.Drawing.Point(132, 100);
            this.txt_tensv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tensv.Name = "txt_tensv";
            this.txt_tensv.Size = new System.Drawing.Size(176, 22);
            this.txt_tensv.TabIndex = 6;
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(132, 46);
            this.txt_masv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(176, 22);
            this.txt_masv.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 89);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(26, 35);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(26, 77);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(26, 125);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 178);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Location = new System.Drawing.Point(825, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 276);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(628, 39);
            this.label6.TabIndex = 8;
            this.label6.Text = "THÔNG TIN DANH SÁCH SINH VIÊN";
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 689);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbl_chucnang);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SinhVien";
            this.Text = "SinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tbl_chucnang.ResumeLayout(false);
            this.tbl_chucnang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_sv;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox tbl_chucnang;
        private System.Windows.Forms.TextBox txt_lop;
        private System.Windows.Forms.TextBox txt_tensv;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.ComboBox cbx_gt;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
    }
}