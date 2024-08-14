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
    public partial class GiaoDienSV : Form
    {
        public GiaoDienSV()
        {
            InitializeComponent();
        }
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
            panel3.Controls.Add(chilFrom);
            panel3.Tag = chilFrom;
            chilFrom.BringToFront();
            chilFrom.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TinhDiemTheoNhom());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DangKiHoatDong());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

    }
}
