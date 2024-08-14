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
    public partial class HoatDongTrongNam : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From HoatDong";
        public HoatDongTrongNam()
        {
            InitializeComponent();
            ConnectCSDL.connectCSDL(chuoi, dtg_hdtn);
            Namecolumn();
        }
        private void Namecolumn()
        {
            dtg_hdtn.Columns[0].HeaderText = "Mã Hoạt Động"; dtg_hdtn.Columns[0].Width = 130;
            dtg_hdtn.Columns[1].HeaderText = "Tên Hoạt Động"; dtg_hdtn.Columns[1].Width = 130;
            dtg_hdtn.Columns[2].HeaderText = "Nhóm"; dtg_hdtn.Columns[2].Width = 100;
            dtg_hdtn.Columns[3].HeaderText = "Mô tả"; dtg_hdtn.Columns[3].Width = 200;
            dtg_hdtn.Columns[4].HeaderText = "Ngày"; dtg_hdtn.Columns[4].Width = 200;
            dtg_hdtn.Columns[5].HeaderText = "Điểm"; dtg_hdtn.Columns[5].Width = 100;


            int sc = dtg_hdtn.Rows.Count;
            index = 0;
            last = sc - 1;
        }

        public void Clear()
        {
            txt_mahd.Enabled = true;
            txt_thd.Text = "";
            txt_nhom.Text = "";
            txt_mota.Text = "";
            dtp_ngay.Text = "";
            txt_sodiem.Text = "";
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            txt_mahd.Focus();

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_mahd.Text) || string.IsNullOrWhiteSpace(txt_thd.Text) || string.IsNullOrWhiteSpace(txt_nhom.Text) || string.IsNullOrWhiteSpace(txt_mota.Text) || string.IsNullOrWhiteSpace(txt_sodiem.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sqlInsert = "INSERT INTO HoatDong (MaHoatDong, TenHoatDong, Nhom, MoTa, NgayThamGia, DiemMax) VALUES (@MaHoatDong, @TenHoatDong, @Nhom, @MoTa, @NgayThamGia, @DiemMax)";

                using (SqlConnection connection = new SqlConnection(ConnectCSDL.sqlcon))
                {
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        command.Parameters.AddWithValue("@MaHoatDong", txt_mahd.Text);
                        command.Parameters.AddWithValue("@TenHoatDong", txt_thd.Text);
                        command.Parameters.AddWithValue("@Nhom", txt_nhom.Text);
                        command.Parameters.AddWithValue("@MoTa", txt_mota.Text);
                        command.Parameters.AddWithValue("@NgayThamGia", dtp_ngay.Value);
                        command.Parameters.AddWithValue("@DiemMax", int.Parse(txt_sodiem.Text)); // Giả sử txt_sodiem chứa số nguyên

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm hoạt động thành công!");
                            Clear();
                            // Tải lại dữ liệu vào DataGridView
                            ConnectCSDL.connectCSDL(chuoi, dtg_hdtn);
                            Namecolumn();
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



        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from HoatDong where ma_hd = N'" + txt_mahd.Text + "'";
            ConnectCSDL.Xoa(sql);
            ConnectCSDL.connectCSDL(chuoi, dtg_hdtn);
            Namecolumn();

            Clear();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_mahd.Text) || string.IsNullOrWhiteSpace(txt_thd.Text) || string.IsNullOrWhiteSpace(txt_nhom.Text) || string.IsNullOrWhiteSpace(txt_mota.Text) || string.IsNullOrWhiteSpace(txt_sodiem.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "UPDATE HoatDong SET TenHoatDong=@TenHoatDong, Nhom=@Nhom, MoTa=@MoTa, NgayThamGia=@NgayThamGia, DiemMax=@DiemMax WHERE MaHoatDong=@MaHoatDong";

                using (SqlConnection connection = new SqlConnection(ConnectCSDL.sqlcon))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@TenHoatDong", txt_thd.Text);
                        command.Parameters.AddWithValue("@Nhom", txt_nhom.Text);
                        command.Parameters.AddWithValue("@MoTa", txt_mota.Text);
                        command.Parameters.AddWithValue("@NgayThamGia", dtp_ngay.Value);
                        command.Parameters.AddWithValue("@DiemMax", int.Parse(txt_sodiem.Text)); // Giả sử txt_sodiem chứa số nguyên
                        command.Parameters.AddWithValue("@MaHoatDong", txt_mahd.Text);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa thông tin hoạt động thành công!");
                            Clear();
                            ConnectCSDL.connectCSDL(chuoi, dtg_hdtn);
                            Namecolumn();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hoạt động cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lỗi khi sửa thông tin hoạt động: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Xử lý ngoại lệ SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Xử lý các ngoại lệ khác
            }
        }



        private void dtg_hdtn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahd.ReadOnly = true;
            int i;
            i = dtg_hdtn.CurrentRow.Index;
            txt_mahd.Text = dtg_hdtn.Rows[i].Cells[0].Value.ToString();
            txt_thd.Text = dtg_hdtn.Rows[i].Cells[1].Value.ToString();
            txt_nhom.Text = dtg_hdtn.Rows[i].Cells[2].Value.ToString();
            txt_mota.Text = dtg_hdtn.Rows[i].Cells[3].Value.ToString();
            dtp_ngay.Text = dtg_hdtn.Rows[i].Cells[4].Value.ToString();
            txt_sodiem.Text = dtg_hdtn.Rows[i].Cells[5].Value.ToString();
            
        }


        private void btn_lammoi_Click_1(object sender, EventArgs e)
        {
            txt_mahd.Text = "";
            txt_thd.Text = "";
            txt_nhom.Text = "";
            txt_mota.Text = "";
            dtp_ngay.Text = "";
            txt_sodiem.Text = "";
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
        }


    }
}
