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
namespace tinhdiemctxhhuit
{
    public partial class HoatDongDaDK : Form
    {
        SqlConnection connection;
        public HoatDongDaDK()
        {
            connection = new SqlConnection(ConnectCSDL.sqlcon);
            InitializeComponent();
            LoadMaHoatDongToComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaHoatDong = comboBox1.SelectedItem.ToString();

            SqlConnection connection = new SqlConnection(ConnectCSDL.sqlcon);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM SinhVienDangKiHoatDong WHERE MaHoatDong = @MaHoatDong", connection);
            command.Parameters.AddWithValue("@MaHoatDong", selectedMaHoatDong);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Hiển thị dữ liệu trên DataGridView
            dtgv_hd.DataSource = dataTable;

            connection.Close();
        }
        private void LoadMaHoatDongToComboBox()
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


        
    }
}
