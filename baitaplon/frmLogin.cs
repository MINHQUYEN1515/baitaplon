using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplon
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public static string QUYEN = "";
        private string LAYQUYEN()
        {
            string Q = "";
            try
            {
                if (Database.SqlConnection.State == ConnectionState.Closed)
                    Database.SqlConnection.Open();
                string sql = "select Quyen from TAIKHOAN where (Tentk = '" + txtTendangnhap.Text + "') and(matkhau = '" + txtPass.Text + "')";
                SqlDataAdapter Myadapter = new SqlDataAdapter(sql, Database.SqlConnection);
                DataTable MyTable = new DataTable();
                Myadapter.Fill(MyTable);
                if (MyTable != null)
                {
                    foreach (DataRow MyRow in MyTable.Rows)
                        Q = MyRow["Quyen"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi đăng nhập");
            }
            finally
            {
                Database.SqlConnection.Close();
            }
            return Q;
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (Database.SqlConnection.State == ConnectionState.Closed)
                Database.SqlConnection.Open();
            QUYEN = LAYQUYEN();
            if (QUYEN != "")
            {
                MessageBox.Show("Ban đã đăng nhập với quyền " + QUYEN, "Thông báo");


                Form1 frmM = new Form1();
                frmM.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không  đúng ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtTendangnhap.ResetText();
                txtPass.ResetText();
                this.txtTendangnhap.Focus();
            }
            Database.SqlConnection.Close();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult Traloi;
            Traloi = MessageBox.Show("Bạn có chắc thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Traloi == DialogResult.Yes)
                this.Close();
        }
    }
}
