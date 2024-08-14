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
    public partial class ChamDiem : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From ChamDiem";
        public ChamDiem()
        {
            InitializeComponent();
            ConnectCSDL.connectCSDL(chuoi, dtgv_sv);
            Namecolumn();
        }
        private void Namecolumn()
        {

            dtgv_sv.Columns[0].HeaderText = "Mã Chấm Điểm"; dtgv_sv.Columns[0].Width = 130;
            dtgv_sv.Columns[1].HeaderText = "Mã Số Sinh Vien"; dtgv_sv.Columns[1].Width = 130;
            dtgv_sv.Columns[2].HeaderText = "Mã hoạt động 1"; dtgv_sv.Columns[2].Width = 100;
            dtgv_sv.Columns[3].HeaderText = "Mã hoạt động 2"; dtgv_sv.Columns[3].Width = 120;
            dtgv_sv.Columns[4].HeaderText = "Mã hoạt động 3"; dtgv_sv.Columns[4].Width = 120;
            dtgv_sv.Columns[5].HeaderText = "Họ tên"; dtgv_sv.Columns[5].Width = 120;
            dtgv_sv.Columns[6].HeaderText = "Lớp"; dtgv_sv.Columns[6].Width = 120;
            dtgv_sv.Columns[7].HeaderText = "Điểm nhóm 1"; dtgv_sv.Columns[7].Width = 120;
            dtgv_sv.Columns[8].HeaderText = "Số lần tham gia nhóm 1"; dtgv_sv.Columns[8].Width = 120;
            dtgv_sv.Columns[9].HeaderText = "Điểm nhóm 2"; dtgv_sv.Columns[9].Width = 120;
            dtgv_sv.Columns[10].HeaderText = "Số lần tham gia nhóm 2"; dtgv_sv.Columns[10].Width = 120;
            dtgv_sv.Columns[11].HeaderText = "Điểm nhóm 3"; dtgv_sv.Columns[11].Width = 120;
            dtgv_sv.Columns[12].HeaderText = "Số lần tham gia nhóm 3"; dtgv_sv.Columns[12].Width = 120;
            dtgv_sv.Columns[13].HeaderText = "Điểm trừ"; dtgv_sv.Columns[13].Width = 120;
            dtgv_sv.Columns[14].HeaderText = "Tổng điểm"; dtgv_sv.Columns[14].Width = 120;
            dtgv_sv.Columns[15].HeaderText = "Kết quả"; dtgv_sv.Columns[15].Width = 120;

            int sc = dtgv_sv.Rows.Count;
            index = 0;
            last = sc - 1;

        }

        private void dtgv_sv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mcd.ReadOnly = true;
            int i;
            i = dtgv_sv.CurrentRow.Index;
            txt_mcd.Text = dtgv_sv.Rows[i].Cells[0].Value.ToString();
            txt_mssv.Text = dtgv_sv.Rows[i].Cells[1].Value.ToString();
            txt_mhd1.Text = dtgv_sv.Rows[i].Cells[2].Value.ToString();
            txt_mhd2.Text = dtgv_sv.Rows[i].Cells[3].Value.ToString();
            txt_mhd3.Text = dtgv_sv.Rows[i].Cells[4].Value.ToString();
            txt_ht.Text = dtgv_sv.Rows[i].Cells[5].Value.ToString();
            txt_l.Text = dtgv_sv.Rows[i].Cells[6].Value.ToString();
            txt_dn1.Text = dtgv_sv.Rows[i].Cells[7].Value.ToString();
            txt_sltg1.Text = dtgv_sv.Rows[i].Cells[8].Value.ToString();
            txt_dn2.Text = dtgv_sv.Rows[i].Cells[9].Value.ToString();
            txt_sltg2.Text = dtgv_sv.Rows[i].Cells[10].Value.ToString();
            txt_dn3.Text = dtgv_sv.Rows[i].Cells[11].Value.ToString();
            txt_sltg3.Text = dtgv_sv.Rows[i].Cells[12].Value.ToString();
            txt_dt.Text = dtgv_sv.Rows[i].Cells[13].Value.ToString();
            txt_td.Text = dtgv_sv.Rows[i].Cells[14].Value.ToString();
            txt_kq.Text = dtgv_sv.Rows[i].Cells[15].Value.ToString();

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txt_mcd.Enabled = true;
            txt_mcd.Text = "";
            txt_mssv.Text = "";
            txt_mhd1.Text = "";
            txt_mhd2.Text = "";
            txt_mhd3.Text = "";
            txt_l.Text = "";
            txt_ht.Text = "";
            txt_td.Text = "";
            txt_kq.Text = "";
            txt_dn1.Text = "";
            txt_dn2.Text = "";
            txt_dn3.Text = "";
            txt_dt.Text = "";
            txt_sltg1.Text = "";
            txt_sltg2.Text = "";
            txt_sltg3.Text = "";
            btn_sua.Enabled = true;

            txt_mcd.Focus();

        }
        
        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE ChamDiem SET hoten=@hoten, lop=@lop, diemnhom1=@diemnhom1, diemnhom2=@diemnhom2, diemnhom3=@diemnhom3, solanthamgianhom1=@solanthamgianhom1, solanthamgianhom2=@solanthamgianhom2, solanthamgianhom3=@solanthamgianhom3, diemtru=@diemtru, tongdiem=@tongdiem, kq=@kq WHERE ma_cham_diem=@ma_cham_diem";

                using (SqlConnection connection = new SqlConnection(ConnectCSDL.sqlcon))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@hoten", txt_ht.Text);
                        command.Parameters.AddWithValue("@lop", txt_l.Text);

                        int diemnhom1, diemnhom2, diemnhom3, solanthamgianhom1, solanthamgianhom2, solanthamgianhom3, diemtru, tongdiem, ma_cham_diem;

                        if (int.TryParse(txt_dn1.Text, out diemnhom1))
                            command.Parameters.AddWithValue("@diemnhom1", diemnhom1);
                        else
                            command.Parameters.AddWithValue("@diemnhom1", DBNull.Value);

                        if (int.TryParse(txt_sltg1.Text, out solanthamgianhom1))
                            command.Parameters.AddWithValue("@solanthamgianhom1", solanthamgianhom1);
                        else
                            command.Parameters.AddWithValue("@solanthamgianhom1", DBNull.Value);

                        if (int.TryParse(txt_dn2.Text, out diemnhom2))
                            command.Parameters.AddWithValue("@diemnhom2", diemnhom2);
                        else
                            command.Parameters.AddWithValue("@diemnhom2", DBNull.Value);

                        if (int.TryParse(txt_sltg2.Text, out solanthamgianhom2))
                            command.Parameters.AddWithValue("@solanthamgianhom2", solanthamgianhom2);
                        else
                            command.Parameters.AddWithValue("@solanthamgianhom2", DBNull.Value);

                        if (int.TryParse(txt_dn3.Text, out diemnhom3))
                            command.Parameters.AddWithValue("@diemnhom3", diemnhom3);
                        else
                            command.Parameters.AddWithValue("@diemnhom3", DBNull.Value);

                        if (int.TryParse(txt_sltg3.Text, out solanthamgianhom3))
                            command.Parameters.AddWithValue("@solanthamgianhom3", solanthamgianhom3);
                        else
                            command.Parameters.AddWithValue("@solanthamgianhom3", DBNull.Value);

                        if (int.TryParse(txt_dt.Text, out diemtru))
                            command.Parameters.AddWithValue("@diemtru", diemtru);
                        else
                            command.Parameters.AddWithValue("@diemtru", DBNull.Value);

                        if (int.TryParse(txt_td.Text, out tongdiem))
                            command.Parameters.AddWithValue("@tongdiem", tongdiem);
                        else
                            command.Parameters.AddWithValue("@tongdiem", DBNull.Value);

                        command.Parameters.AddWithValue("@kq", txt_kq.Text);

                        if (int.TryParse(txt_mcd.Text, out ma_cham_diem))
                            command.Parameters.AddWithValue("@ma_cham_diem", ma_cham_diem);
                        else
                            command.Parameters.AddWithValue("@ma_cham_diem", DBNull.Value);

                        command.ExecuteNonQuery();
                    }
                }

                // Cập nhật lại DataGridView sau khi thực hiện cập nhật
                ConnectCSDL.connectCSDL(chuoi, dtgv_sv);
                Namecolumn();
                Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thực thi câu lệnh SQL: " + ex.Message, "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo");
            }
        }


        private void btn_nl_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        
    }
}
