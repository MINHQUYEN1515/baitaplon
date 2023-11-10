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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Loadhoadon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMember();
            Loadhanghoa();
            Sum();
        }
        private void Sum()
        {
            txttong.Text = DVGHH.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt32(t.Cells[4].Value)).ToString();
        }
        private void Loadhanghoa()
        {
            Database.SqlConnection.Open();
            String sql = "select HANghoa.MAHH ,hanghoa.tenhh,soluong,dongia ,coalesce(CThoadon.SOLUONG , 0) * coalesce(Hanghoa.DONGIA , 0) as thanhtien from HOADON " +
                "\r\ninner join CTHOADON on CTHOADON.SOHD =Hoadon.SOHD" +
                " \r\ninner join HANGHOA on hanghoa.MAHH =CThoadon.MAHH " +
                " where CThoadon.SOHD =" + "'" + cbselect.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            DVGHH.DataSource = dt;
            DVGHH.Columns[0].HeaderText = "MÃ HÀNG";
            DVGHH.Columns[1].HeaderText = "TÊN HÀNG";
            DVGHH.Columns[2].HeaderText = "SỐ LƯƠNG";
            DVGHH.Columns[3].HeaderText = "ĐƠN GIÁ";
            DVGHH.Columns[4].HeaderText = "THÀNH TIỀN";

            Database.SqlConnection.Close();
        }
        private void Loadhoadon()
        {
            Database.SqlConnection.Open();
            String sql = "Select Sohd from HOADON";
            SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cmd.ExecuteNonQuery();
            cbselect.DataSource = ds.Tables[0];
            cbselect.ValueMember = "SOHD";
            Database.SqlConnection.Close();

        }
        private void LoadMember()
        {
            Database.SqlConnection.Open();
            String sql = "Select * from HOADON where SOhd=" + "'" + cbselect.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
            // cmd.Parameters.AddWithValue("@Manv", cbSelect.SelectedValue.ToString());
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            string strFormat = "dd/MM/yyyy";
            while (sqlDataReader.Read())
            {
                txtten.Text = sqlDataReader.GetString(1).ToString();
                txtdiachi.Text = sqlDataReader.GetString(2).ToString();
                txtdienthoai.Text = sqlDataReader.GetString(3).ToString();
                txtngayhd.Text = sqlDataReader.GetDateTime(4).ToString(strFormat);
            }
            Database.SqlConnection.Close();
        }

        private void txttong_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
