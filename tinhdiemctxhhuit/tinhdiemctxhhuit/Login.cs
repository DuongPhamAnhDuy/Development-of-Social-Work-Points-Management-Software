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
    public partial class Login : Form
    {
        private Form currentFormChild;
        public static class UserSession
        {
            public static string LoggedInUsername { get; set; }
            // Các thông tin đăng nhập khác bạn muốn lưu có thể thêm vào đây.
        }
        private class UserInfo
        {
            public string TaiKhoan { get; set; }
            public string MatKhau { get; set; }
            public int PhanQuyen { get; set; }
        }
        private UserInfo currentUser;
        public Login()
        {
            InitializeComponent();
        }
        private UserInfo AuthenticateUser(string username, string password)
        {
            UserInfo user = null;
            string query = "SELECT TaiKhoan, MatKhau, PhanQuyen FROM NguoiDung WHERE TaiKhoan = @Username AND MatKhau = @Password";

            using (SqlConnection connection = new SqlConnection(ConnectCSDL.sqlcon))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        user = new UserInfo
                        {
                            TaiKhoan = reader["TaiKhoan"].ToString(),
                            MatKhau = reader["MatKhau"].ToString(),
                            PhanQuyen = Convert.ToInt32(reader["PhanQuyen"])
                        };
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }

            return user;
        }

        private void DisplayFormsBasedOnPermission()
        {
            if (currentUser.PhanQuyen == 0)
            {
                GiaoDienChung gdc = new GiaoDienChung();
                gdc.Show();
            }
            else if (currentUser.PhanQuyen == 1)
            {
                GiaoDienSV gdsv = new GiaoDienSV();
                gdsv.Show();
            }
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {

            string taiKhoan = txtUsername.Text;
            string matKhau = txtPassword.Text;

            currentUser = AuthenticateUser(taiKhoan, matKhau);

            if (currentUser != null)
            {
                DisplayFormsBasedOnPermission();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại thông tin đăng nhập.");
            }
        }

        private void btn_dk_Click(object sender, EventArgs e)
        {
            Dangky dk = new Dangky();
            dk.Show();
        }
        
    }
}