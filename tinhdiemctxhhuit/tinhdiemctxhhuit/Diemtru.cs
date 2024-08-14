using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinhdiemctxhhuit
{
    public partial class Diemtru : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From DiemTru";
        public Diemtru()
        {
            InitializeComponent();
            ConnectCSDL.connectCSDL(chuoi, dtgv_diemtru);// goi ne
            Namecolumn();
        }
        private void Namecolumn()
        {

            dtgv_diemtru.Columns[0].HeaderText = "Mã điểm trừ"; dtgv_diemtru.Columns[0].Width = 130;
            dtgv_diemtru.Columns[1].HeaderText = "Mã hoạt động"; dtgv_diemtru.Columns[1].Width = 130;
            dtgv_diemtru.Columns[2].HeaderText = "Tên hoạt động"; dtgv_diemtru.Columns[2].Width = 130;
            dtgv_diemtru.Columns[3].HeaderText = "Lí do"; dtgv_diemtru.Columns[3].Width = 100;
            dtgv_diemtru.Columns[4].HeaderText = "Điểm trừ"; dtgv_diemtru.Columns[4].Width = 100;

            int sc = dtgv_diemtru.Rows.Count;
            index = 0;
            last = sc - 1;

        }
        public void Clear()
        {
            txt_MaDT.Text = "";
            txt_diemtru.Text = "";
            txt_hoatdongDT.Text = "";
            txt_MahdDT.Text = "";
            txt_lido.Text = "";
            btn_xoaDT.Enabled = true;
            btn_suaDT.Enabled = true;
            btn_themDT.Enabled = true;


        }

        private void btn_themDT_Click(object sender, EventArgs e)
        {
            if (txt_MaDT.Text == "" || txt_diemtru.Text == "" || txt_hoatdongDT.Text == "" || txt_MahdDT.Text == "" || txt_lido.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "insert into DiemTru values('" + txt_MaDT.Text + "','" + txt_MahdDT.Text + "','" + txt_hoatdongDT.Text + "','" + txt_lido.Text + "','" + txt_diemtru.Text + "')";
                ConnectCSDL.them_dl(sql1, dtgv_diemtru);
                ConnectCSDL.connectCSDL(chuoi, dtgv_diemtru);
                Namecolumn();
                Clear();
            }
        }

        private void btn_xoaDT_Click(object sender, EventArgs e)
        {
            string sql = "Delete from DiemTru where ma_hd = N'" + txt_MahdDT.Text + "'";
            ConnectCSDL.Xoa(sql);
            ConnectCSDL.connectCSDL(chuoi, dtgv_diemtru);
            Namecolumn();
            Clear();
        }

        private void btn_suaDT_Click(object sender, EventArgs e)
        {
            string sql = "update DiemTru set ma_hd ='" + txt_MahdDT.Text + "', ten_hd ='" + txt_hoatdongDT.Text + "', li_do='" + txt_lido.Text + "', diem_tru='" + txt_diemtru.Text + "' where ma_diem_tru ='" + txt_MaDT.Text + "'";
            ConnectCSDL.Sua(sql);
            ConnectCSDL.connectCSDL(chuoi, dtgv_diemtru);
            Namecolumn();
            Clear();
        }

        private void dtgv_diemtru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_diemtru.CurrentRow.Index;
            txt_MaDT.Text = dtgv_diemtru.Rows[i].Cells[0].Value.ToString();
            txt_MahdDT.Text = dtgv_diemtru.Rows[i].Cells[1].Value.ToString();
            txt_hoatdongDT.Text = dtgv_diemtru.Rows[i].Cells[2].Value.ToString();
            txt_lido.Text = dtgv_diemtru.Rows[i].Cells[3].Value.ToString();
            txt_diemtru.Text = dtgv_diemtru.Rows[i].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_MahdDT.Text = "";
            txt_MaDT.Text = "";
            txt_diemtru.Text = "";
            txt_hoatdongDT.Text = "";
            txt_MahdDT.Text = "";
            txt_lido.Text = "";
            btn_xoaDT.Enabled = true;
            btn_suaDT.Enabled = true;
            btn_themDT.Enabled = true;
        }

    }
}
