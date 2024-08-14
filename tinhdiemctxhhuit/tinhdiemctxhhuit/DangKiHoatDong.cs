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
    public partial class DangKiHoatDong : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From HoatDong";
        public DangKiHoatDong()
        {
            InitializeComponent();
            LoadDataIntoComboBox();
            cbo_mhd.SelectedIndexChanged += cbo_mhd_SelectedIndexChanged;
            LoadDataIntoComboBoxMSSV();
            cbo_mssv.SelectedIndexChanged += cbo_mssv_SelectedIndexChanged;
            ConnectCSDL.connectCSDL(chuoi, dtgv_dkht);
            dtgv_dkht.RowPrePaint += dtgv_RowPrePaint;


        }
        // Sau khi dữ liệu đã được hiển thị trên DataGridView (dtgv)
        private void dtgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_dkht.Rows.Count)
            {
                DataGridViewRow row = dtgv_dkht.Rows[e.RowIndex];
                if (row.Cells["NgayThamGia"].Value != null)
                {
                    DateTime ngayThamGia;
                    if (DateTime.TryParse(row.Cells["NgayThamGia"].Value.ToString(), out ngayThamGia))
                    {
                        if (ngayThamGia < DateTime.Now)
                        {
                            row.DefaultCellStyle.ForeColor = Color.Gray;
                        }
                    }
                }
            }
        }

        private void txt_mssv_TextChanged(object sender, EventArgs e)
        {

        }
        private Dictionary<string, string> mhdDict = new Dictionary<string, string>();

        private void LoadDataIntoComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectCSDL.sqlcon))
                {
                    connection.Open();
                    // Lấy danh sách các hoạt động có NgayThamGia lớn hơn hoặc bằng ngày hiện tại
                    string query = "SELECT MaHoatDong, TenHoatDong FROM HoatDong WHERE NgayThamGia >= GETDATE()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string maHoatDong = reader["MaHoatDong"].ToString();
                                string tenHoatDong = reader["TenHoatDong"].ToString();

                                cbo_mhd.Items.Add(maHoatDong);
                                mhdDict.Add(maHoatDong, tenHoatDong);
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


        private void cbo_mhd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_mhd.SelectedItem != null)
            {
                string selectedMaHoatDong = cbo_mhd.SelectedItem.ToString();

                if (mhdDict.ContainsKey(selectedMaHoatDong))
                {
                    string tenHoatDong = mhdDict[selectedMaHoatDong];
                    txt_thd.Text = tenHoatDong;
                }
                else
                {
                    txt_thd.Text = "";
                }
            }
        }
        private Dictionary<string, string> mhdDictMSSV = new Dictionary<string, string>();

        private void LoadDataIntoComboBoxMSSV()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectCSDL.sqlcon))
                {
                    connection.Open();
                    string query = "SELECT MaSV, ho_ten FROM SinhVien";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string maSV = reader["MaSV"].ToString();
                                string tenSV = reader["ho_ten"].ToString();

                                cbo_mssv.Items.Add(maSV);
                                mhdDictMSSV.Add(maSV, tenSV);
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

        private void cbo_mssv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_mssv.SelectedItem != null)
            {
                string selectedMaSV = cbo_mssv.SelectedItem.ToString();

                if (mhdDictMSSV.ContainsKey(selectedMaSV))
                {
                    string tenSV = mhdDictMSSV[selectedMaSV];
                    txt_ht.Text = tenSV;
                }
                else
                {
                    txt_ht.Text = "";
                }
            }
        }

        private void btn_dk_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(cbo_mssv.Text) || string.IsNullOrWhiteSpace(cbo_mhd.Text) || string.IsNullOrWhiteSpace(txt_thd.Text) || string.IsNullOrWhiteSpace(txt_ht.Text) || string.IsNullOrWhiteSpace(dtp_ndk.Text))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sqlInsert = "INSERT INTO SinhVienDangKiHoatDong ( MaSV, MaHoatDong,TenHoatDong,ho_ten, NgayDangKi) VALUES ( @MaSV, @MaHoatDong,@TenHoatDong, @ho_ten,@NgayDangKi)";

                    using (SqlConnection connection = new SqlConnection(ConnectCSDL.sqlcon))
                    {
                        using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                        {
                            command.Parameters.AddWithValue("@MaSV", cbo_mssv.Text);
                            command.Parameters.AddWithValue("@MaHoatDong", cbo_mhd.Text);
                            command.Parameters.AddWithValue("@TenHoatDong", txt_thd.Text);
                            command.Parameters.AddWithValue("@ho_ten", txt_ht.Text);
                            command.Parameters.AddWithValue("@NgayDangKi", dtp_ndk.Value);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm hoạt động thành công!");

                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm hoạt động!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho trường điểm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi thêm hoạt động: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Xử lý ngoại lệ SQL
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Xử lý các ngoại lệ khác
                }
            }
        }






    }

}

