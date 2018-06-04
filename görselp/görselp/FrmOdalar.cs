using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace görselp
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True");
        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from Oda101", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                btn101.Text = dr["Adi"].ToString()+" "+dr["Soyadi"].ToString();
            }
            con.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
            }
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select *from Oda102", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                btn102.Text = dr1["Adi"].ToString() + " " + dr1["Soyadi"].ToString();
            }
            con.Close();
            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
            }
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select *from Oda103", con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                btn103.Text = dr2["Adi"].ToString() + " " + dr2["Soyadi"].ToString();
            }
            con.Close();
            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
            }
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select *from Oda104", con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                btn104.Text = dr3["Adi"].ToString() + " " + dr3["Soyadi"].ToString();
            }
            con.Close();
            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
            }
            con.Open();
            SqlCommand cmd4 = new SqlCommand("select *from Oda105", con);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                btn105.Text = dr4["Adi"].ToString() + " " + dr4["Soyadi"].ToString();
            }
            con.Close();
            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.Red;
            }
            con.Open();
            SqlCommand cmd5 = new SqlCommand("select *from Oda106", con);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                btn106.Text = dr5["Adi"].ToString() + " " + dr5["Soyadi"].ToString();
            }
            con.Close();
            if (btn106.Text != "106")
            {
                btn106.BackColor = Color.Red;
            }
            con.Open();
            SqlCommand cmd6 = new SqlCommand("select *from Oda107", con);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                btn107.Text = dr6["Adi"].ToString() + " " + dr6["Soyadi"].ToString();
            }
            con.Close();
            if (btn107.Text != "107")
            {
                btn107.BackColor = Color.Red;
            }
            con.Open();
            SqlCommand cmd7 = new SqlCommand("select *from Oda108", con);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            while (dr7.Read())
            {
                btn108.Text = dr7["Adi"].ToString() + " " + dr7["Soyadi"].ToString();
            }
            con.Close();
            if (btn108.Text != "108")
            {
                btn108.BackColor = Color.Red;
            }
            con.Open();
            SqlCommand cmd8 = new SqlCommand("select *from Oda109", con);
            SqlDataReader dr8 = cmd8.ExecuteReader();
            while (dr8.Read())
            {
                btn109.Text = dr8["Adi"].ToString() + " " + dr8["Soyadi"].ToString();
            }
            con.Close();
            if (btn109.Text != "109")
            {
                btn109.BackColor = Color.Red;
            }
        }

        private void btn101_Click(object sender, EventArgs e)
        {

        }

        private void btn103_Click(object sender, EventArgs e)
        {

        }
    }
}
