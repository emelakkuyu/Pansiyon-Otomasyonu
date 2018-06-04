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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True");
        private void veriler()
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Stoklar", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                {
                    ekle.Text = dr["Gida"].ToString();
                    ekle.SubItems.Add(dr["İcecek"].ToString());
                    ekle.SubItems.Add(dr["Cerezler"].ToString());
                    listView1.Items.Add(ekle);
                }
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Stoklar(Gida,İcecek,Cerezler) values ('"+txtgida.Text+"','"+txticecek.Text+"','"+txtatistirmalik.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            veriler();

        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
        }
    }
}
