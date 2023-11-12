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
    public partial class fmQuanlinhanvien : Form
    {
        public fmQuanlinhanvien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clear();
            settrue();
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            themmoi = "themmoi";
        }

                private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = "sua";
            settrue();
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Database.SqlConnection.State == ConnectionState.Closed)
            {
                Database.SqlConnection.Open();
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chon == DialogResult.Yes)
                {
                    string sql = "delete from HOTENNHANVIEN Where MANHANVIEN = N'" + txtManv.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
                    cmd.ExecuteNonQuery();
                    Refresh();
                    Load_DataGridView();
                    Database.SqlConnection.Close();
                    clear();
                }
                else MessageBox.Show("Chọn thông tin cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Database.SqlConnection.Close();
        }

        private void fmQuanlinhanvien_Load(object sender, EventArgs e)
        {

        }
    }
}
