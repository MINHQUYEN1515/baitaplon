namespace baitaplon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            phanquyen();
        }

        private void quảnLíPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmQLPhongban fmQLPhongban = new fmQLPhongban();
            fmQLPhongban.MdiParent = this;
            fmQLPhongban.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void quảnLíHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLHanghoa hanghoa = new frmQLHanghoa();
            hanghoa.MdiParent = this;
            hanghoa.Show();
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmQuanlinhanvien nhanvien = new fmQuanlinhanvien();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void quảnLíHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLHoadon hoadon = new frmQLHoadon();
            hoadon.MdiParent = this;
            hoadon.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmQuanlinhanvien nhanvien = new fmQuanlinhanvien();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void thốngKêNhânViênTheoPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKNhanvien_Phong thk = new frmTKNhanvien_Phong();
            thk.MdiParent = this;
            thk.Show();
        }

        private void tìmHóaĐơnTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimhoadon_Nhanvien thk = new frmTimhoadon_Nhanvien();
            thk.MdiParent = this;
            thk.Show();
        }

        private void tìmKiếmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 nv = new Form2();
            nv.MdiParent = this;
            nv.Show();
        }

        private void danhSáchTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSTaikhoan n = new frmDSTaikhoan();
            n.MdiParent = this;
            n.Show();
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemTaikhoan n = new frmThemTaikhoan();
            n.MdiParent = this;
            n.Show();
        }
        private void phanquyen()
        {
            if (frmLogin.QUYEN == "User")
            {
                thôngTinTàiKhoảnToolStripMenuItem.Enabled = false;
                nhậpDữLiệuToolStripMenuItem.Enabled = false;
                tHỐNGKÊToolStripMenuItem.Visible = false;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}