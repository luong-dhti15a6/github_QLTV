using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythuvien
{
    public partial class fDoanhThu : Form
    {
        public fDoanhThu()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            Connection KN = new Connection();
            DataTable tb = new DataTable();
            using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
            {
                string query = "Select * from DOANHTHU";
                using (SqlDataAdapter adt = new SqlDataAdapter(query, conn))
                {
                    conn.Open();
                    adt.Fill(tb);
                    conn.Close();
                }
            }
            dataGridView1.DataSource = tb;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Tắt dòng trống
            dataGridView1.AllowUserToAddRows = false;
            decimal tongCong = 0;

            // Lặp qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra xem dòng có giá trị hợp lệ không (tránh dòng trống)
                if (row.Cells["THANHTIEN"].Value != null)
                {
                    // Cộng giá trị cột "TongTien" vào tổng
                    tongCong += Convert.ToDecimal(row.Cells["THANHTIEN"].Value);
                }
            }
            lbDoanhSo.Text  = tongCong.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                load(); // Gọi hàm load() để tải dữ liệu mặc định
            }
            else
            {
                string thangTK = txtTimKiem.Text.Trim();
                if (DateTime.TryParse(thangTK, out DateTime date))
                {
                    int thang = date.Month;
                    int nam = date.Year;

                    Connection KN = new Connection();
                    DataTable tb = new DataTable();

                    using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
                    {
                        string query = "SELECT * FROM DOANHTHU WHERE MONTH(NGAYTHANHTOAN) = @Thang AND YEAR(NGAYTHANHTOAN) = @Nam";

                        using (SqlDataAdapter adt = new SqlDataAdapter(query, conn))
                        {
                            adt.SelectCommand.Parameters.AddWithValue("@Thang", thang);
                            adt.SelectCommand.Parameters.AddWithValue("@Nam", nam);

                            conn.Open();
                            adt.Fill(tb);
                        }
                    }

                    // Gán dữ liệu vào DataGridView
                    dataGridView1.DataSource = tb;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Tắt dòng trống
                    dataGridView1.AllowUserToAddRows = false;

                    // Tính tổng doanh thu
                    decimal tongCong = 0;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        // Kiểm tra giá trị hợp lệ
                        if (row.Cells["THANHTIEN"].Value != null &&
                            decimal.TryParse(row.Cells["THANHTIEN"].Value.ToString(), out decimal thanhTien))
                        {
                            tongCong += thanhTien;
                        }
                    }

                    // Hiển thị tổng doanh thu
                    lbDoanhSo.Text = tongCong.ToString("N2"); // Hiển thị định dạng tiền tệ (2 số thập phân)
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng ngày tháng (MM/yyyy)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
