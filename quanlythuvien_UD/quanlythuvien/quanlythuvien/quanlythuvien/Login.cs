using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythuvien
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int count = 0;
            Connection kn = new Connection();
            using (SqlConnection conn = new SqlConnection(kn.ConnectionString()))
            {
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TAIKHOAN = @tk AND MATKHAU = @mk";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tk", txtTaiKhoan.Text.Trim());
                    cmd.Parameters.AddWithValue("@mk", txtMatKhau.Text.Trim());
                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                    conn.Close();
                }
            }

            if (count > 0)
            {
                // Hiển thị form MainMenu
                MainMenu f = new MainMenu();
                f.Show();

                // Đóng form đăng nhập
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
