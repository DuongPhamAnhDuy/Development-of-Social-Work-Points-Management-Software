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
    public partial class GiaoDienChung : Form
    {
        private Form currentFormChild;
        private void OpenChildForm(Form chilFrom)
        {
            if (currentFormChild != null)
            {

               currentFormChild.Close();

            } currentFormChild = chilFrom;
            chilFrom.TopLevel = false;
            chilFrom.FormBorderStyle = FormBorderStyle.None;
            chilFrom.Dock = DockStyle.Fill;
            panel2.Controls.Add(chilFrom);
            panel2.Tag = chilFrom;
            chilFrom.BringToFront();
            chilFrom.Show();


        }
        public GiaoDienChung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SinhVien());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoatDongTrongNam());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DSDK());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TinhDiemTheoNhom());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DangKiHoatDong());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DiemDanh());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Diemtru());
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Login dn = new Login();
            dn.Show();
            this.Close();
        }

        
    }
}
