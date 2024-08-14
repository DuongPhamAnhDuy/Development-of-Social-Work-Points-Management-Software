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
    public partial class DiemDanh : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From DiemDanh";
        public DiemDanh()
        {
            InitializeComponent();
            ConnectCSDL.connectCSDL(chuoi, dtgv_dd);// goi ne
            Namecolumn();
            Load();
        }
        public void Namecolumn()
        {
            dtgv_dd.Columns[0].HeaderText = "ID"; dtgv_dd.Columns[0].Width = 130;
            dtgv_dd.Columns[1].HeaderText = "Mã số sinh viên"; dtgv_dd.Columns[1].Width = 130;
            dtgv_dd.Columns[2].HeaderText = "Mã hoạt động"; dtgv_dd.Columns[2].Width = 100;
            dtgv_dd.Columns[3].HeaderText = "Họ tên"; dtgv_dd.Columns[3].Width = 100;

            dtgv_dd.Columns[4].HeaderText = "Đã Có Mặt"; dtgv_dd.Columns[4].Width = 120;

            int sc = dtgv_dd.Rows.Count;
            index = 0;
            last = sc - 1;
        }

        public void Clear()
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaHoatDong = comboBox1.SelectedItem.ToString();

            SqlConnection connection = new SqlConnection(ConnectCSDL.sqlcon);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM DiemDanh WHERE MaHoatDong = @MaHoatDong", connection);
            command.Parameters.AddWithValue("@MaHoatDong", selectedMaHoatDong);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Hiển thị dữ liệu trên DataGridView
            dtgv_dd.DataSource = dataTable;

            connection.Close();
        }
        public void Load()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectCSDL.sqlcon))
                {
                    connection.Open();
                    string query = "SELECT MaHoatDong FROM HoatDong";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader["MaHoatDong"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectCSDL.sqlcon);

            try
            {
                connection.Open();

                // Lấy ID của bản ghi đầu tiên thỏa mãn điều kiện
                string selectIDQuery = "SELECT TOP 1 ID FROM DiemDanh WHERE DaCoMat IS NULL";

                SqlCommand selectIDCommand = new SqlCommand(selectIDQuery, connection);

                int? recordID = selectIDCommand.ExecuteScalar() as int?;

                if (recordID.HasValue)
                {
                    // Cập nhật bản ghi với ID đã lấy được
                    string updateQuery = "UPDATE DiemDanh SET DaCoMat = @DaCoMat WHERE ID = @ID";

                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);

                    updateCommand.Parameters.AddWithValue("@DaCoMat", true);
                    updateCommand.Parameters.AddWithValue("@ID", recordID.Value);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có bản ghi nào được cập nhật.");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bản ghi để cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


    }
}


