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
    public partial class frmQuanLyDocGia : Form
    {
        public frmQuanLyDocGia()
        {
            InitializeComponent();
            Load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Load()
        {
            Connection KN = new Connection();
            DataTable tb = new DataTable();
            using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
            {
                string query = "Select * from DOCGIA";
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

        private void frmQuanLyDocGia_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        
            string maDocGia = txtMaDocGia.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string gioiTinh = txtGioiTinh.Text.Trim();
            DateTime ngaySinh = dateNgaySinh.Value;
            string diaChi = txtDiaChi.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            DateTime ngayLam = dateNgayLam.Value;

            
            if (string.IsNullOrEmpty(maDocGia) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string query = "INSERT INTO DOCGIA (MADOCGIA, HOTEN, NGAYSINH, GIOITINH, DIACHI, DIENTHOAI, CMND, NGAYLAMTHE) " +
                           "VALUES (@MADOCGIA, @HOTEN, @NGAYSINH, @GIOITINH, @DIACHI, @DIENTHOAI, @CMND, @NGAYLAMTHE)";

            try
            {
                Connection KN = new Connection();
                using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Gắn giá trị cho các tham số
                        cmd.Parameters.AddWithValue("@MADOCGIA", maDocGia);
                        cmd.Parameters.AddWithValue("@HOTEN", hoTen);
                        cmd.Parameters.AddWithValue("@GIOITINH", gioiTinh);
                        cmd.Parameters.AddWithValue("@NGAYSINH", ngaySinh);
                        cmd.Parameters.AddWithValue("@DIACHI", diaChi);
                        cmd.Parameters.AddWithValue("@DIENTHOAI", sdt);
                        cmd.Parameters.AddWithValue("@CMND", cmnd);
                        cmd.Parameters.AddWithValue("@NGAYLAMTHE", ngayLam);

                        // Thực thi lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            Load();
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không thêm được dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Clear()
        {
            
            txtMaDocGia.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtGioiTinh.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtCMND.Text = string.Empty;

            
            dateNgaySinh.Value = DateTime.Now;
            dateNgayLam.Value = DateTime.Now;

            
            txtMaDocGia.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView hay chưa
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy MaDocGia từ dòng được chọn
            string maDocGia = dataGridView1.SelectedRows[0].Cells["MADOCGIA"].Value.ToString();

            // Câu lệnh SQL để xóa dữ liệu
            string query = "DELETE FROM DOCGIA WHERE MADOCGIA = @MADOCGIA";

            try
            {
                Connection KN = new Connection();
                using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Gắn giá trị cho tham số
                        cmd.Parameters.AddWithValue("@MADOCGIA", maDocGia);

                        // Thực thi lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Sau khi xóa, gọi lại Load() để cập nhật DataGridView
                            Load();
                        }
                        else
                        {
                            MessageBox.Show("Không xóa được dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy MaDocGia cần sửa từ TextBox
            string maDocGia = txtMaDocGia.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string gioiTinh = txtGioiTinh.Text.Trim();
            DateTime ngaySinh = dateNgaySinh.Value;
            string diaChi = txtDiaChi.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            DateTime ngayLam = dateNgayLam.Value;

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(maDocGia))
            {
                MessageBox.Show("Vui lòng nhập Mã Độc Giả để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Câu lệnh SQL để cập nhật dữ liệu
            string query = "UPDATE DOCGIA SET " +
                           "HOTEN = @HOTEN, " +
                           "NGAYSINH = @NGAYSINH, " +
                           "GIOITINH = @GIOITINH, " +
                           "DIACHI = @DIACHI, " +
                           "DIENTHOAI = @DIENTHOAI, " +
                           "CMND = @CMND, " +
                           "NGAYLAMTHE = @NGAYLAMTHE " +
                           "WHERE MADOCGIA = @MADOCGIA";

            try
            {
                Connection KN = new Connection();
                using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Gắn giá trị cho các tham số
                        cmd.Parameters.AddWithValue("@MADOCGIA", maDocGia);
                        cmd.Parameters.AddWithValue("@HOTEN", hoTen);
                        cmd.Parameters.AddWithValue("@NGAYSINH", ngaySinh);
                        cmd.Parameters.AddWithValue("@GIOITINH", gioiTinh);
                        cmd.Parameters.AddWithValue("@DIACHI", diaChi);
                        cmd.Parameters.AddWithValue("@DIENTHOAI", sdt);
                        cmd.Parameters.AddWithValue("@CMND", cmnd);
                        cmd.Parameters.AddWithValue("@NGAYLAMTHE", ngayLam);

                        // Thực thi lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Làm mới DataGridView
                            Load();
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Lấy mã độc giả từ ô TextBox
            string timKiem = txtTimKiem.Text.Trim();

            // Kiểm tra xem người dùng đã nhập mã độc giả chưa
            if (string.IsNullOrEmpty(timKiem))
            {
                MessageBox.Show("Vui lòng nhập Mã Độc Giả để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Câu lệnh SQL để tìm kiếm theo MaDocGia
            string query = "SELECT * FROM DOCGIA WHERE MADOCGIA LIKE @MADOCGIA";

            try
            {
                Connection KN = new Connection();
                DataTable tb = new DataTable();
                using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Gắn giá trị cho tham số
                        cmd.Parameters.AddWithValue("@MADOCGIA", "%" + timKiem + "%");

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
                    MessageBox.Show("Không tìm thấy Mã Độc Giả này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Làm mới DataGridView nếu không có kết quả
                    dataGridView1.DataSource = null;
                    Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQuanLyDocGia_Load_1(object sender, EventArgs e)
        {

        }
    }
}
