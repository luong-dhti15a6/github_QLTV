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
   
    public partial class fChiTiet : Form
    {
        private frmQuanLyMuonTra form;
        protected decimal thanhTien;
        DateTime ngaymuon;
        DateTime ngayTra;
        string maSach, soluong;
        public fChiTiet(string maHD,string mDG, string mS,string tenS,string sl,string ngayM,string ngayT,string giaM,string tt,frmQuanLyMuonTra frm)
        {
            InitializeComponent();
            lbMaHD.Text = maHD;
            lbMaDG.Text = mDG;
            lbTenSach.Text = tenS;
            lbNgayMuon.Text = ngayM.Trim();
            lbNgayTra.Text = ngayT;
            lbSoLuong.Text = sl;
            lbGiaMuon.Text = giaM;
            decimal giaMuon = decimal.Parse(giaM);
            ngaymuon = DateTime.Parse(ngayM);   
            ngayTra = DateTime.Parse(ngayT);
            TimeSpan ngays = ngayTra - ngaymuon;
            int days = ngays.Days;
            thanhTien = giaMuon*days;
            lbThanhTien.Text = thanhTien.ToString();
            lbtt.Text = tt;
            maSach = mS;
            soluong = sl;
            this.form = frm;
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tt = lbtt.Text.Trim();
            decimal thanhTien = decimal.Parse(lbThanhTien.Text);
            if(tt == "Đang mượn") { 
            Connection KN = new Connection();
            using (SqlConnection conn = new SqlConnection(KN.ConnectionString()))
            {
                conn.Open();
                string query = "INSERT INTO DOANHTHU(MAPHIEU,NGAYTHANHTOAN,THANHTIEN) VALUES(@maphieu,@ngayT,@thanhtien)";
                    string query1 = "UPDATE PHIEUMUON SET TRANGTHAI = @tt WHERE MAPHIEU = @ma";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maphieu", lbMaHD.Text);

                            
                        cmd.Parameters.AddWithValue("@ngayT", ngayTra);
       
                        cmd.Parameters.AddWithValue("@thanhTien", thanhTien);
                        cmd.ExecuteNonQuery();
                    }
                    using(SqlCommand  cmd = new SqlCommand(query1, conn))
                    {
                        cmd.Parameters.AddWithValue("@tt", "Đã Trả");


                        cmd.Parameters.AddWithValue("@ma", lbMaHD.Text);
                        cmd.ExecuteNonQuery();
                    }

                    string query2 = "UPDATE SACH SET SOLUONG = SOLUONG + @sl WHERE MASACH = @ma";
                    using (SqlCommand cmd = new SqlCommand(query2, conn))
                    {
                        cmd.Parameters.AddWithValue("@sl", soluong);
                        cmd.Parameters.AddWithValue("@ma", maSach);
                        cmd.ExecuteNonQuery();
                    }
                }
            
                form.load();
                MessageBox.Show("Đã hoàn thành hóa đơn phiếu mượn!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Phiếu mượn đã được trả!");
            }

        }
    }
}
