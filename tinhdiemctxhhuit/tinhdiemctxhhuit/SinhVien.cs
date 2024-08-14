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

    public partial class SinhVien : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From SinhVien";// truy van ne
        public SinhVien()
        {
            InitializeComponent();
            ConnectCSDL.connectCSDL(chuoi, dtgv_sv);// goi ne
            Namecolumn();
        }
        private void Namecolumn()
        {

            dtgv_sv.Columns[0].HeaderText = "Mã so sinh vien"; dtgv_sv.Columns[0].Width = 130;
            dtgv_sv.Columns[1].HeaderText = "Tên Sinh Vien"; dtgv_sv.Columns[1].Width = 130;
            dtgv_sv.Columns[2].HeaderText = "Gioi Tinh"; dtgv_sv.Columns[2].Width = 100;
            dtgv_sv.Columns[3].HeaderText = "Ngay Sinh"; dtgv_sv.Columns[3].Width = 120;
            dtgv_sv.Columns[4].HeaderText = "Lop"; dtgv_sv.Columns[4].Width = 120;

            int sc = dtgv_sv.Rows.Count;
            index = 0;
            last = sc - 1;

        }

        public void Clear()
        {
            txt_masv.Enabled = true;
            txt_tensv.Text = "";
            cbx_gt.Text = "";
            dtp_ngaysinh.Text = "";
            txt_lop.Text = "";
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            txt_masv.Focus();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_masv.Text == "" || txt_tensv.Text == "" || cbx_gt.Text == "" || dtp_ngaysinh.Text == "" || txt_lop.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "insert into SinhVien values('" + txt_masv.Text + "','" + txt_tensv.Text + "','" + cbx_gt.Text + "','" + dtp_ngaysinh.Text + "','" + txt_lop.Text + "')";
                ConnectCSDL.them_dl(sql1, dtgv_sv);
                ConnectCSDL.connectCSDL(chuoi, dtgv_sv);
                Namecolumn();
                Clear();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from SinhVien where ma_sv = N'" + txt_masv.Text + "'";
            ConnectCSDL.Xoa(sql);
            ConnectCSDL.connectCSDL(chuoi, dtgv_sv);
            Namecolumn();

            Clear();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            string sql = "update SinhVien set ho_ten='" + txt_tensv.Text + "', gioi_tinh = '" + cbx_gt.Text + "', ngay_sinh='" + dtp_ngaysinh.Text + "', lop='" + txt_lop.Text + "' where ma_sv='"+txt_masv.Text+"'";
            ConnectCSDL.Sua(sql);
            ConnectCSDL.connectCSDL(chuoi, dtgv_sv);
            Namecolumn();
            Clear();
        }

        private void dtgv_sv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masv.ReadOnly = true;
            int i;
            i = dtgv_sv.CurrentRow.Index;
            txt_masv.Text = dtgv_sv.Rows[i].Cells[0].Value.ToString();
            txt_tensv.Text = dtgv_sv.Rows[i].Cells[1].Value.ToString();
            cbx_gt.Text = dtgv_sv.Rows[i].Cells[2].Value.ToString();
            dtp_ngaysinh.Text = dtgv_sv.Rows[i].Cells[3].Value.ToString();
            txt_lop.Text = dtgv_sv.Rows[i].Cells[4].Value.ToString();
        }




    }
}
