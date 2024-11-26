using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythuvien
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void quảnLýHọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDocGia f = new frmQuanLyDocGia();
            f.ShowDialog();
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
 
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLySach f = new frmQuanLySach();
           
            f.ShowDialog();
            
        }

        private void quảnLýMượnTrảToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmQuanLyMuonTra f = new frmQuanLyMuonTra();
            f.ShowDialog();
        }

        private void quảnLýDoanhSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoanhThu f = new fDoanhThu();
            f.ShowDialog();
        }
    }
}
