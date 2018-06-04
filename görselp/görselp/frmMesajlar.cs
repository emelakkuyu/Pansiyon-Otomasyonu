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
    public partial class frmMesajlar : Form
    {
        public frmMesajlar()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True");
        private void VerilerGöster()
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Mesajlar", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["Mesajid"].ToString();
                ekle.SubItems.Add(dr["AdSoyad"].ToString());
                ekle.SubItems.Add(dr["Mesaj"].ToString());
                listView1.Items.Add(ekle);
            }
            con.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Mesajlar(AdSoyad,Mesaj) values('" + textBox1.Text + "','" + richTextBox1.Text + "')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            VerilerGöster();
        }

        private void frmMesajlar_Load(object sender, EventArgs e)
        {
            VerilerGöster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
