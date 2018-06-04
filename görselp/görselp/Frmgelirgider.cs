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
    public partial class Frmgelirgider : Form
    {
        public Frmgelirgider()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            lblpersonelmaas.Text = (personel * 1500).ToString();
            int sonuc;
            sonuc=Convert.ToInt32(lblkasadatoplam.Text)-(Convert.ToInt32(lblpersonelmaas.Text)+Convert.ToInt32(lblalinanurunler1.Text)+ Convert.ToInt32(lblalinanurunler2.Text)+ Convert.ToInt32(lblalinanurunler3.Text));
            lblsnc.Text = sonuc.ToString();
        }

        private void Frmgelirgider_Load(object sender, EventArgs e)
        {//kasadaki toplam tutar
            con.Open();
            SqlCommand cmd = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblkasadatoplam.Text = dr["toplam"].ToString();
            }
            con.Close();
         

            //gidalar
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select sum(Gida) as toplam1 from Stoklar", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                lblalinanurunler1.Text = dr1["toplam1"].ToString();
            }
            con.Close();

            //icecek
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select sum(İcecek) as toplam2 from Stoklar", con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lblalinanurunler2.Text = dr2["toplam2"].ToString();
            }
            con.Close();

            //cerezleer
            con.Open();
            SqlCommand cmd3 = new SqlCommand("Select sum(Cerezler) as toplam3 from Stoklar", con);
            SqlDataReader dr3= cmd3.ExecuteReader();
            while (dr3.Read())
            {
                lblalinanurunler3.Text = dr3["toplam3"].ToString();
            }
            con.Close();


        }
    }
}
