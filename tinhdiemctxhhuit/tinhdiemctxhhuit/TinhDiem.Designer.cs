namespace tinhdiemctxhhuit
{
    partial class TinhDiem
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
            this.dtgv_tinhdiem = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ql_diemCTXHHUIT_2023__2024DataSet1 = new tinhdiemctxhhuit.ql_diemCTXHHUIT_2023__2024DataSet1();
            this.tinhTongDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinhTongDiemTableAdapter = new tinhdiemctxhhuit.ql_diemCTXHHUIT_2023__2024DataSet1TableAdapters.TinhTongDiemTableAdapter();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDiemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketQuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tinhdiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ql_diemCTXHHUIT_2023__2024DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTongDiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_tinhdiem
            // 
            this.dtgv_tinhdiem.AllowUserToAddRows = false;
            this.dtgv_tinhdiem.AllowUserToDeleteRows = false;
            this.dtgv_tinhdiem.AutoGenerateColumns = false;
            this.dtgv_tinhdiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_tinhdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_tinhdiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.tongDiemDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.ketQuaDataGridViewTextBoxColumn});
            this.dtgv_tinhdiem.DataSource = this.tinhTongDiemBindingSource;
            this.dtgv_tinhdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_tinhdiem.Location = new System.Drawing.Point(3, 18);
            this.dtgv_tinhdiem.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_tinhdiem.Name = "dtgv_tinhdiem";
            this.dtgv_tinhdiem.ReadOnly = true;
            this.dtgv_tinhdiem.Size = new System.Drawing.Size(940, 350);
            this.dtgv_tinhdiem.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 22);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xuất Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_tinhdiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 371);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(301, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // ql_diemCTXHHUIT_2023__2024DataSet1
            // 
            this.ql_diemCTXHHUIT_2023__2024DataSet1.DataSetName = "ql_diemCTXHHUIT_2023__2024DataSet1";
            this.ql_diemCTXHHUIT_2023__2024DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tinhTongDiemBindingSource
            // 
            this.tinhTongDiemBindingSource.DataMember = "TinhTongDiem";
            this.tinhTongDiemBindingSource.DataSource = this.ql_diemCTXHHUIT_2023__2024DataSet1;
            // 
            // tinhTongDiemTableAdapter
            // 
            this.tinhTongDiemTableAdapter.ClearBeforeFill = true;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongDiemDataGridViewTextBoxColumn
            // 
            this.tongDiemDataGridViewTextBoxColumn.DataPropertyName = "TongDiem";
            this.tongDiemDataGridViewTextBoxColumn.HeaderText = "TongDiem";
            this.tongDiemDataGridViewTextBoxColumn.Name = "tongDiemDataGridViewTextBoxColumn";
            this.tongDiemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "ho_ten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "ho_ten";
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            this.hotenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ketQuaDataGridViewTextBoxColumn
            // 
            this.ketQuaDataGridViewTextBoxColumn.DataPropertyName = "KetQua";
            this.ketQuaDataGridViewTextBoxColumn.HeaderText = "KetQua";
            this.ketQuaDataGridViewTextBoxColumn.Name = "ketQuaDataGridViewTextBoxColumn";
            this.ketQuaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TinhDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TinhDiem";
            this.Text = "TinhDiem";
            this.Load += new System.EventHandler(this.TinhDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tinhdiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ql_diemCTXHHUIT_2023__2024DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTongDiemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_tinhdiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ql_diemCTXHHUIT_2023__2024DataSet1 ql_diemCTXHHUIT_2023__2024DataSet1;
        private System.Windows.Forms.BindingSource tinhTongDiemBindingSource;
        private ql_diemCTXHHUIT_2023__2024DataSet1TableAdapters.TinhTongDiemTableAdapter tinhTongDiemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDiemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketQuaDataGridViewTextBoxColumn;
    }
}