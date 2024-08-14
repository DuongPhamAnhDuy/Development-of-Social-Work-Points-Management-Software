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
    public partial class DSDK : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select * From SinhVienDangKiHoatDong"; // truy van ne

        public DSDK()
        {
            InitializeComponent();
            ConnectCSDL.connectCSDL(chuoi, dtgv_dkdk); // goi ne
            Namecolumn();
        }

        private void Namecolumn()
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
            string tukhoa = txt_tk.Text;
            String chuoi1 = "";
            if (String.Compare(cbo_tk.Text, "MaHoatDong", true) == 0 || cbo_tk.SelectedItem == null)
            {
                chuoi1 = "Select * from SinhVienDangKiHoatDong where MaHoatDong like N'%" + tukhoa + "%'";
            }
            else if (String.Compare(cbo_tk.Text, "Kết Quả", true) == 0)
            {
                chuoi1 = "Select * from SinhVienDangKiHoatDong where KetQua like N'%" + tukhoa + "%'";
            }

            else
            {
                chuoi1 = "Select * from SinhVienDangKiHoatDong where MaHoatDong like N'%" + tukhoa + "%'";
            }

            ConnectCSDL.timkiem(chuoi1, dtgv_dkdk);
            Namecolumn();
        }
        }

    }

