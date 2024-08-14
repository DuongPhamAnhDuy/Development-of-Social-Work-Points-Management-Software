using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace tinhdiemctxhhuit
{
    public partial class TinhDiemTheoNhom : Form
    {
        public TinhDiemTheoNhom()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectCSDL.sqlcon))
                {
                    using (SqlCommand command = new SqlCommand("TinhDiemVaTongDiemTheoNhom", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        connection.Open();
                        adapter.Fill(dataTable);
                        connection.Close();

                        // Hiển thị dữ liệu lên DataGridView
                        dtgv_tdtn.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //private void btn_xuatexcel_Click(object sender, EventArgs e)
        //{
        //    if (dtgv_tdtn.Rows.Count > 0)
        //    {

        //        Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
        //        xcelApp.Application.Workbooks.Add(Type.Missing);

        //        for (int i = 1; i < dtgv_tdtn.Columns.Count + 1; i++)
        //        {
        //            xcelApp.Cells[1, i] = dtgv_tdtn.Columns[i - 1].HeaderText;
        //        }

        //        for (int i = 0; i < dtgv_tdtn.Rows.Count; i++)
        //        {
        //            for (int j = 0; j < dtgv_tdtn.Columns.Count; j++)
        //            {
        //                xcelApp.Cells[i + 2, j + 1] = dtgv_tdtn.Rows[i].Cells[j].Value.ToString();
        //            }
        //        }
        //        xcelApp.Columns.AutoFit();
        //        xcelApp.Visible = true;
        //    }
        //}

        //private void TinhDiemTheoNhom_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'ql_diemCTXHHUIT_2023__2024DataSet.TinhTongDiem' table. You can move, or remove it, as needed.
        //    this.tinhTongDiemTableAdapter.Fill(this.ql_diemCTXHHUIT_2023__2024DataSet.TinhTongDiem);

        //}
    }
}
