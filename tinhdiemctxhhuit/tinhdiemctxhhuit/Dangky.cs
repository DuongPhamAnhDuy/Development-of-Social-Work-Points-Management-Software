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
    public partial class Dangky : Form
    {
        public static string sqlcon = ConnectCSDL.sqlcon;
        public static SqlConnection mycon;
        public static SqlCommand com;
        public Dangky()
        {
            InitializeComponent();

        }
        private void btn_dk_Click(object sender, EventArgs e)
        {
            string taiKhoan = txt_tk.Text;
            string matKhau = txt_mk.Text;
            string xacNhanMatKhau = txt_rmk.Text;

            // Kiểm tra xác nhận mật khẩu
            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng. Vui lòng nhập lại.");
                return;
            }

            // Thực hiện đăng ký người dùng
            RegisterUser(taiKhoan, matKhau);
        }
        private void RegisterUser(string username, string password)
        {
            // Thực hiện đăng ký người dùng vào cơ sở dữ liệu
            string query = "INSERT INTO NguoiDung (TaiKhoan, MatKhau, PhanQuyen) VALUES (@Username, @Password, @PhanQuyen)";

            using (SqlConnection connection = new SqlConnection(ConnectCSDL.sqlcon))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@PhanQuyen", 1); // Đặt PhanQuyen = 1 cho đăng ký

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đăng ký thành công.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký không thành công. Vui lòng thử lại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện đăng ký: " + ex.Message);
                }
            }
        }
        private void btn_tv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Login a1 = new Login();
                a1.Show();
                this.Close();
            }
        }
    }
}