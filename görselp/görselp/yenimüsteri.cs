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
    public partial class yenimüsteri : Form
    {
        public yenimüsteri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True");
        private void yenimüsteri_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from Oda101", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                btn101.Text = dr["Adi"].ToString() + " " + dr["Soyadi"].ToString();
            }
            con.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
                btn101.Enabled = false;
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
                btn102.Enabled = false;
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
                btn103.Enabled = false;
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
                btn104.Enabled = false;
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
                btn105.Enabled = false;
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
                btn106.Enabled = false;
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
                btn107.Enabled = false;
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
                btn108.Enabled = false;
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
                btn109.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            TxtOdano.Text="109";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda109 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "101";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda101 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "102";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda102 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "103";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda103 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", con);
            con.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "104";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda104 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "105";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda105 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "106";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda106 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "107";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda107 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "108";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda108 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btndolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void btnbos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");
        }

        private void datacıkıs_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(dtpGiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(datacıkıs.Text);
            TimeSpan sonuc;
            sonuc = BuyukTarih - KucukTarih;
            label11.Text = sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(label11.Text) * 60;
            txtucret.Text = ucret.ToString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,Odano,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text+"','" + TxtSoyadi.Text+"','" + comboBox1.Text+ "','"+Msktelefon.Text+ "','" +TxtMail.Text+ "','" +TxtTcno.Text+ "','" +TxtOdano.Text+ "','" +txtucret.Text+ "','"+ dtpGiris.Value.ToString("yyy-MM-dd")+ "','"+datacıkıs.Value.ToString("yyy-MM-dd")+ "')" , con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı");
        }
    }
}
//Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True