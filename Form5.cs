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
    public partial class Form5 : Form
    {
        private Form3 f3;

        public Form5(Form3 f3, String groupBoxName)
        {
            InitializeComponent();

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
    }
}
