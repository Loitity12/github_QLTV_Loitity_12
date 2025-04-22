namespace DANG_NHAP
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thuvien f3 = new thuvien();
            this.Hide();
            f3.Show();
           // this.Close();
        }
    }
}
