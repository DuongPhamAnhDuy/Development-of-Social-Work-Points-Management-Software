namespace tinhdiemctxhhuit
{
    partial class TinhDiemTheoNhom
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
            this.dtgv_tdtn = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tinhTongDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ql_diemCTXHHUIT_2023__2024DataSet = new tinhdiemctxhhuit.ql_diemCTXHHUIT_2023__2024DataSet();
            this.tinhTongDiemTableAdapter = new tinhdiemctxhhuit.ql_diemCTXHHUIT_2023__2024DataSetTableAdapters.TinhTongDiemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tdtn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTongDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_diemCTXHHUIT_2023__2024DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_tdtn
            // 
            this.dtgv_tdtn.AllowUserToAddRows = false;
            this.dtgv_tdtn.AllowUserToDeleteRows = false;
            this.dtgv_tdtn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_tdtn.Location = new System.Drawing.Point(1, 22);
            this.dtgv_tdtn.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_tdtn.Name = "dtgv_tdtn";
            this.dtgv_tdtn.ReadOnly = true;
            this.dtgv_tdtn.Size = new System.Drawing.Size(817, 306);
            this.dtgv_tdtn.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(584, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = " SHOW ĐIỂM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐIỂM TỔNG THEO NHÓM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_tdtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 335);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm";
            // 
            // tinhTongDiemBindingSource
            // 
            this.tinhTongDiemBindingSource.DataMember = "TinhTongDiem";
            this.tinhTongDiemBindingSource.DataSource = this.ql_diemCTXHHUIT_2023__2024DataSet;
            // 
            // ql_diemCTXHHUIT_2023__2024DataSet
            // 
            this.ql_diemCTXHHUIT_2023__2024DataSet.DataSetName = "ql_diemCTXHHUIT_2023__2024DataSet";
            this.ql_diemCTXHHUIT_2023__2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tinhTongDiemTableAdapter
            // 
            this.tinhTongDiemTableAdapter.ClearBeforeFill = true;
            // 
            // TinhDiemTheoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TinhDiemTheoNhom";
            this.Text = "TinhDiemTheoNhom";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tdtn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tinhTongDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_diemCTXHHUIT_2023__2024DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_tdtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ql_diemCTXHHUIT_2023__2024DataSet ql_diemCTXHHUIT_2023__2024DataSet;
        private System.Windows.Forms.BindingSource tinhTongDiemBindingSource;
        private ql_diemCTXHHUIT_2023__2024DataSetTableAdapters.TinhTongDiemTableAdapter tinhTongDiemTableAdapter;
    }
}