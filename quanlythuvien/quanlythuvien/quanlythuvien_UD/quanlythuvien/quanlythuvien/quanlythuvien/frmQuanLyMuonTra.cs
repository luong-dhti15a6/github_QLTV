using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythuvien
{
    public partial class frmQuanLyMuonTra : Form
    {
        public frmQuanLyMuonTra()
        {
            InitializeComponent();
            load();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }


       public void load()
        {
            Connection KN = new Connection();
            DataTable tb = new DataTable();
            using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
            {
                string query = "Select * from PHIEUMUON";
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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        { Connection KN = new Connection();
            string madg = txtMaDocGia.Text;
            string maS = txtMaSach.Text;
            string tenS = txtTenSach.Text;
            string sl = txtSoLuong.Text;
            DateTime ngayM = dateNgayMuon.Value;
            DateTime ngayT = dateNgayTra.Value;
           decimal gia = decimal.Parse(txtGiaMuon.Text);
          
                using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
                {
                    conn.Open();
                    string query = "INSERT INTO PHIEUMUON(MADOCGIA,MASACH,TENSACH,SOLUONG,NGAYMUON,NGAYTRA,GIAMUON,TRANGTHAI) VALUES(@maDG,@maS,@tenS,@sl,@ngayM,@ngayT,@giaM,@tt)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maDG", madg);
                        cmd.Parameters.AddWithValue("@maS", maS);
                        cmd.Parameters.AddWithValue("@tenS", tenS);
                        cmd.Parameters.AddWithValue("@sl", sl);
                        cmd.Parameters.AddWithValue("@ngayM", ngayM);
                        cmd.Parameters.AddWithValue("@ngayT", ngayT);
                        cmd.Parameters.AddWithValue("@giaM", gia);
                        cmd.Parameters.AddWithValue("@tt", "Đang mượn");

                        cmd.ExecuteNonQuery();
                    }
                string query1 = "UPDATE SACH SET SOLUONG = SOLUONG - @sl WHERE MASACH = @ma";
                using (SqlCommand cmd = new SqlCommand(query1, conn))
                {
                    cmd.Parameters.AddWithValue("@sl", sl);
                    cmd.Parameters.AddWithValue("@ma", maS);
                    cmd.ExecuteNonQuery();
                }
            }
             
        
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                // Lấy dữ liệu từ dòng được chọn
                var selectedRow = dataGridView1.SelectedRows[0];
                string maHD = selectedRow.Cells["MAPHIEU"].Value.ToString();
                string MDG = selectedRow.Cells["MADOCGIA"].Value.ToString();
                string MS = selectedRow.Cells["MASACH"].Value.ToString();
                string tenSach = selectedRow.Cells["TENSACH"].Value.ToString();
                string soLuong = selectedRow.Cells["SOLUONG"].Value.ToString();
                string ngayMuon = selectedRow.Cells["NGAYMUON"].Value.ToString();
                string ngayTra = selectedRow.Cells["NGAYTRA"].Value.ToString();
                string giaMuon = selectedRow.Cells["GIAMUON"].Value.ToString();
                string trangThai = selectedRow.Cells["TRANGTHAI"].Value.ToString();
                // Truyền dữ liệu sang Form2
                
                fChiTiet f = new fChiTiet(maHD,MDG,MS,tenSach,soLuong,ngayMuon,ngayTra,giaMuon,trangThai,this);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để hiển thị chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
