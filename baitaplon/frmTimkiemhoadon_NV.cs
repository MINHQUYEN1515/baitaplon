using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace baitaplon
{
    public partial class frmTimhoadon_Nhanvien : Form
    {

        public frmTimhoadon_Nhanvien()
        {
            InitializeComponent();
        }

        private void frmTimhoadon_Nhanvien_Load(object sender, EventArgs e)
        {
            LoadcbSelect();
        }
        private void LoadcbSelect()
        {
            Database.SqlConnection.Open();
            String sql = "Select MANV from NHANVIEN";
            SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cmd.ExecuteNonQuery();
            cbSelect.DataSource = ds.Tables[0];

            cbSelect.ValueMember = "Manv";
            Database.SqlConnection.Close();



        }
        private void LoadDataMember()
        {
            Database.SqlConnection.Open();
            String sql = "Select * from NHANVIEN Where Manv=" + "'" + cbSelect.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
            // cmd.Parameters.AddWithValue("@Manv", cbSelect.SelectedValue.ToString());
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            string strFormat = "dd/MM/yyyy";
            while (sqlDataReader.Read())
            {
                txtTen.Text = sqlDataReader.GetString(1).ToString();
                txtphai.Text = sqlDataReader.GetBoolean(2) == true ? "Nam" : "Nữ";
                txtngaysinh.Text = sqlDataReader.GetDateTime(3).ToString(strFormat);
                txthsl.Text = sqlDataReader.GetDouble(4).ToString();
                txtchucvu.Text = sqlDataReader.GetDouble(5).ToString();
                txtmaphong.Text = sqlDataReader.GetString(6).ToString();
            }
            Database.SqlConnection.Close();

        }
       
        private void LoadDataBill()
        {
            Database.SqlConnection.Open();
            String sql = "select HOADON.SOHD ,khachhang,diachi,diachi,ngayhd ,coalesce(CThoadon.SOLUONG , 0) * coalesce(Hanghoa.DONGIA , 0) as thanhtien from HOADON" +
                " \r\ninner join CTHOADON on CTHOADON.SOHD =Hoadon.SOHD " +
                "\r\ninner join HANGHOA on hanghoa.MAHang =CThoadon.MAHang " +
                "where hoadon.MANV =" + "'" + cbSelect.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            DGVhoadon.DataSource = dt;
            DGVhoadon.Columns[0].HeaderText = "Số Hóa Đơn";
            DGVhoadon.Columns[1].HeaderText = "Khách hàng";
            DGVhoadon.Columns[2].HeaderText = "Địa chỉ";
            DGVhoadon.Columns[3].HeaderText = "Điện thoại";
            DGVhoadon.Columns[4].HeaderText = "Ngày lập hóa đơn";
            DGVhoadon.Columns[5].HeaderText = "Tổng tiền";
            Database.SqlConnection.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            LoadDataMember();
            LoadDataBill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
