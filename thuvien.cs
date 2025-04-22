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
    public partial class thuvien : Form
    {
        
        private thongtinmuon form5;

        public thuvien()
        {
            InitializeComponent();
           
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap f1 = new dangnhap();
            this.Close();
            f1.Show();
        }

        private void mƯỢNTRẢSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtinmuon f5 = new thongtinmuon("MuonTraSach");
            this.Close();
            f5.Show();
        }

        private void tHẺTHƯVIỆNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtinmuon f5 = new thongtinmuon("TheThuVien");
            this.Close();
            f5.Show();
        }

        private void tHỐNGKÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtinmuon f5 = new thongtinmuon("ThongKe");
            this.Close();
            f5.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.Columns.Add("MaSach", "Mã Sách");
            dataGridView1.Columns.Add("TenSach", "Tên Sách");
            dataGridView1.Columns.Add("TacGia", "Tác Giả");
            dataGridView1.Columns.Add("TheLoai", "Thể Loại");
            dataGridView1.Columns.Add("SoLuong", "Số Lượng");
            dataGridView1.Columns.Add("TinhTrang", "Tình Trạng");
            dataGridView1.Columns.Add("NXB", "NXB");
            dataGridView1.Columns.Add("NamXuatBan", "Năm Xuất Bản");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_masach.Text) || string.IsNullOrWhiteSpace(tb_tensach.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mã sách và tên sách!", "Thông báo");
                return;
            }

            if (cbb_theloai.SelectedItem == null || cbb_tinhtrang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại và tình trạng!", "Thông báo");
                return;
            }


            string maSach = tb_masach.Text;
            string tenSach = tb_tensach.Text;
            string tacGia = tb_tacgia.Text;
            string theLoai = cbb_theloai.SelectedItem?.ToString();
            string soLuong = numericUpDown1.Value.ToString();
            string tinhTrang = cbb_tinhtrang.SelectedItem?.ToString();
            string nxb = tb_nxb.Text;
            string namXuatBan = tb_namxb.Text;

            string thongTinSach = $"Mã Sách: {maSach}\nTên Sách: {tenSach}\nTác Giả: {tacGia}\nThể Loại: {theLoai}\nSố Lượng: {soLuong}\nTình Trạng: {tinhTrang}\nNXB: {nxb}\nNăm Xuất Bản: {namXuatBan}";
            dataGridView1.Rows.Add(maSach, tenSach, tacGia, theLoai, soLuong, tinhTrang, nxb, namXuatBan);

            tb_masach.Clear();
            tb_tensach.Clear();
            tb_tacgia.Clear();
            cbb_theloai.SelectedIndex = -1;
            numericUpDown1.Value = numericUpDown1.Minimum;
            cbb_tinhtrang.SelectedIndex = -1;
            tb_nxb.Clear();
            tb_namxb.Clear();
        }
    }
}
