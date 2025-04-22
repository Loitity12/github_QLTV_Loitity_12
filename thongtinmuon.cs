using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANG_NHAP
{
    public partial class thongtinmuon : Form
    {
        //private thuvien f3;

        public thongtinmuon(String groupBoxName)
        {
            InitializeComponent();
            groupBoxTheThuVien.Location = groupBoxMuonTraSach.Location;
            groupBoxThongKe.Location = groupBoxMuonTraSach.Location;
            groupBox1.Location = groupBoxMuonTraSach.Location;

            switch (groupBoxName)
            {
                case "MuonTraSach":
                    groupBoxMuonTraSach.Visible = true;
                    break;
                case "TheThuVien":
                    groupBoxTheThuVien.Visible = true;
                    break;
                case "ThongKe":
                    groupBoxThongKe.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_ma.ReadOnly = false;
            txt_ht.ReadOnly = false;
            txt_sdt.ReadOnly = false;
            txt_muon.ReadOnly = false;
            txt_tra.ReadOnly = false;
            rtb_diachi.ReadOnly = false;
            rtb_sachmuon.ReadOnly = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            thuvien f3 = new thuvien();
            f3.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thuvien f3 = new thuvien();
            f3.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBoxMuonTraSach.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            thuvien f3 = new thuvien();
            f3.Show();
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBoxMuonTraSach.Visible = false;
        }
    }
}
