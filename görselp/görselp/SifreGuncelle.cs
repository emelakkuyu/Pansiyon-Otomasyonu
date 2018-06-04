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
    public partial class SifreGuncelle : Form
    {
        public SifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True");

        private void btngiris_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update giris set kullanici='" + txtkullaniciadi.Text + "',sifre='" + txtsifre.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncellenmiştir.");
        }
    }
}
