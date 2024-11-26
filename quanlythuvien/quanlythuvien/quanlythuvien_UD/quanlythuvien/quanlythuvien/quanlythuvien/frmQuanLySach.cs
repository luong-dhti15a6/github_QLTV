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
    public partial class frmQuanLySach : Form
    {
        public frmQuanLySach()
        {
            InitializeComponent();
            Load();

        }
        public void Load()
        {
            Connection KN = new Connection();
            DataTable tb = new DataTable();
            using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
            {
                string query = "Select * from SACH";
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
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                // Lấy dữ liệu từ các TextBox và DateTimePicker
                string maSach = txtMaSach.Text.Trim();
                string tenSach = txtTenSach.Text.Trim();
                string theLoai = txtTheLoai.Text.Trim();
                string nxb = txtNXB.Text.Trim();
                DateTime ngayXuatBan = dateXuatBan.Value;
                string tenTacGia = txtTenTacGia.Text.Trim();
                int soLuong;
                decimal giaTien;

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(maSach) || string.IsNullOrEmpty(tenSach) ||
                    !int.TryParse(txtSoLuong.Text.Trim(), out soLuong) ||
                    !decimal.TryParse(txtGiaTien.Text.Trim(), out giaTien))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Kết nối cơ sở dữ liệu
                    Connection KN = new Connection();
                    using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
                    {
                        conn.Open();

                        // Câu lệnh SQL cập nhật dữ liệu theo MASACH
                        string query = "UPDATE SACH SET TENSACH = @TENSACH, THELOAI = @THELOAI, NHAXUATBAN = @NHAXUATBAN, " +
                                       "NGAYXUATBAN = @NGAYXUATBAN, TENTACGIA = @TENTACGIA, SOLUONG = @SOLUONG, GIATIEN = @GIATIEN " +
                                       "WHERE MASACH = @MASACH";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Gắn giá trị cho các tham số
                            cmd.Parameters.AddWithValue("@MASACH", maSach);
                            cmd.Parameters.AddWithValue("@TENSACH", tenSach);
                            cmd.Parameters.AddWithValue("@THELOAI", theLoai);
                            cmd.Parameters.AddWithValue("@NHAXUATBAN", nxb);
                            cmd.Parameters.AddWithValue("@NGAYXUATBAN", ngayXuatBan);
                            cmd.Parameters.AddWithValue("@TENTACGIA", tenTacGia);
                            cmd.Parameters.AddWithValue("@SOLUONG", soLuong);
                            cmd.Parameters.AddWithValue("@GIASACH", giaTien);

                            // Thực thi lệnh
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Cập nhật lại danh sách sách hiển thị
                                Load();

                                Clear();
                            }
                            else
                            {
                                MessageBox.Show("Không thể cập nhật sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void quảnLýHọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                // Lấy dữ liệu từ các TextBox và DateTimePicker
                string maSach = txtMaSach.Text.Trim();
                string tenSach = txtTenSach.Text.Trim();
                string theLoai = txtTheLoai.Text.Trim();
                string nxb = txtNXB.Text.Trim();
                DateTime ngayXuatBan = dateXuatBan.Value;
                string tenTacGia = txtTenTacGia.Text.Trim();
                int soLuong;
                decimal giaTien;

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(maSach) || string.IsNullOrEmpty(tenSach) ||
                    !int.TryParse(txtSoLuong.Text.Trim(), out soLuong) ||
                    !decimal.TryParse(txtGiaTien.Text.Trim(), out giaTien))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Kết nối cơ sở dữ liệu
                    Connection KN = new Connection();
                    using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
                    {
                        conn.Open();

                        // Câu lệnh SQL thêm dữ liệu
                        string query = "INSERT INTO SACH (MASACH, TENSACH, THELOAI, NHAXUATBAN, NGAYXUATBAN, TENTACGIA, SOLUONG, GIASACH) " +
                                       "VALUES (@MASACH, @TENSACH, @THELOAI, @NHAXUATBAN, @NGAYXUATBAN, @TENTACGIA, @SOLUONG, @GIATIEN)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Gắn giá trị cho các tham số
                            cmd.Parameters.AddWithValue("@MASACH", maSach);
                            cmd.Parameters.AddWithValue("@TENSACH", tenSach);
                            cmd.Parameters.AddWithValue("@THELOAI", theLoai);
                            cmd.Parameters.AddWithValue("@NHAXUATBAN", nxb);
                            cmd.Parameters.AddWithValue("@NGAYXUATBAN", ngayXuatBan);
                            cmd.Parameters.AddWithValue("@TENTACGIA", tenTacGia);
                            cmd.Parameters.AddWithValue("@SOLUONG", soLuong);
                            cmd.Parameters.AddWithValue("@GIATIEN", giaTien);

                            // Thực thi lệnh
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Cập nhật lại danh sách sách hiển thị
                                Load();

                                Clear();

                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Clear()
        {
            // Xóa dữ liệu trong các TextBox
            txtMaSach.Text = string.Empty;
            txtTenSach.Text = string.Empty;
            txtTheLoai.Text = string.Empty;
            txtNXB.Text = string.Empty;
            txtTenTacGia.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtGiaTien.Text = string.Empty;


            dateXuatBan.Value = DateTime.Now;


            txtMaSach.Focus();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView hay chưa
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy MaSach từ dòng được chọn
            string maSach = dataGridView1.SelectedRows[0].Cells["MASACH"].Value.ToString();

            // Câu lệnh SQL để xóa dữ liệu
            string query = "DELETE FROM SACH WHERE MASACH = @MASACH";

            try
            {
                Connection KN = new Connection();
                using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Gắn giá trị cho tham số
                        cmd.Parameters.AddWithValue("@MASACH", maSach);

                        // Thực thi lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Sau khi xóa, gọi lại Load() để cập nhật DataGridView
                            Load();
                        }
                        else
                        {
                            MessageBox.Show("Không xóa được sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy mã sách từ ô TextBox
            string timKiem = txtTimKiem.Text.Trim();

            // Kiểm tra xem người dùng đã nhập mã sách chưa
            if (string.IsNullOrEmpty(timKiem))
            {
                MessageBox.Show("Vui lòng nhập Mã Sách để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Câu lệnh SQL để tìm kiếm theo MASACH
            string query = "SELECT * FROM SACH WHERE MASACH LIKE @MASACH";

            try
            {
                Connection KN = new Connection();
                DataTable tb = new DataTable();
                using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Gắn giá trị cho tham số
                        cmd.Parameters.AddWithValue("@MASACH", "%" + timKiem + "%");

                        using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                        {
                            conn.Open();
                            adt.Fill(tb); // Đổ dữ liệu vào DataTable
                            conn.Close();
                        }
                    }
                }

                // Kiểm tra dữ liệu
                if (tb.Rows.Count > 0)
                {
                    // Hiển thị dữ liệu tìm thấy trong DataGridView
                    dataGridView1.DataSource = tb;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AllowUserToAddRows = false;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Mã Sách này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Làm mới DataGridView nếu không có kết quả
                    dataGridView1.DataSource = null;
                    Load();  // Cập nhật lại DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
