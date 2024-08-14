using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace tinhdiemctxhhuit
{
    class ConnectCSDL
    {
        public static string sqlcon = (@"Data Source=LAPTOP-I6CQI33O\ANHDUY;Initial Catalog=ql_diemCTXHHUIT_2023__2024;Integrated Security=True");
        private static SqlConnection mycon;

        public static SqlConnection Mycon
        {
            get { return ConnectCSDL.mycon; }
            set { ConnectCSDL.mycon = value; }
        }
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        // DataTable table;
        public static BindingSource code;
        public static SqlCommandBuilder bd;
        public static void connectCSDL(string chuoi, DataGridView db1)
        {
            try
            {

                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }
       
        // Them vao du lieu
        public static void them_dl(string sql1, DataGridView dt)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                dt.DataSource = tb;
                MessageBox.Show("Them Thanh công !", "Thong báo ");
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }

        }
        //xoa du lieu
        public static void Xoa(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn Xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //try
                //{
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                //}
                //catch
                //{
                //    MessageBox.Show("Tài khoản bạn sửa trùng với tài khoản đã có ! Vui lòng ktra lại ");
                //}
            }
        }
        public static void Sua(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn sửa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    mycon.Close();
                    MessageBox.Show("Bạn sửa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }
        public static void timkiem(string chuoi, DataGridView db2)
        {
            try
            {
                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        // hàm xử lý combobox
        public static void xulycbx(string chuoi, ComboBox cbx)
        {
            ad = new SqlDataAdapter(chuoi, sqlcon);
            dt = new DataTable();

            ad.Fill(dt);
            cbx.DataSource = dt;
        }
        public static void luu(string sql)
        {


            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                com.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }

        //public static void Themdangky(string select, String tk, String mk, String sql1)
        //{

        //    int i;
        //    mycon = new SqlConnection(sqlcon);
        //    mycon.Open();
        //    string sql = select;
        //    com = new SqlCommand(sql, mycon);
        //    i = (int)com.ExecuteScalar();


        //    if (i != 0)
        //    {
        //        MessageBox.Show("Tài khoản đã tồn tại ! ", "Error", MessageBoxButtons.OK);
        //    }
        //    else
        //    {
        //        try
        //        {
        //            luu(sql1);


        //            if (MessageBox.Show("Đăng ký thành công !Bạn có muốn đăng nhập luôn không ?\n", "Thông Báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
        //            {
        //                Login dt = new Login();
        //                dt.Show();
        //                Dangky a = new Dangky();
        //                a.Close();
        //            }
        //            // mycon.Close();
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
        //        }
        //    }
        //}

    }
}
