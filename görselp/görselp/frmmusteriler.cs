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
    public partial class frmmusteriler : Form
    {
        public frmmusteriler()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True");
        private void VerilerGöster()
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from MusteriEkle", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["Musteriid"].ToString();
                ekle.SubItems.Add(dr["Adi"].ToString());
                ekle.SubItems.Add(dr["Soyadi"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Mail"].ToString());
                ekle.SubItems.Add(dr["TC"].ToString());
                ekle.SubItems.Add(dr["Odano"].ToString());
                ekle.SubItems.Add(dr["Ucret"].ToString());
                ekle.SubItems.Add(dr["GirisTarihi"].ToString());
                ekle.SubItems.Add(dr["CikisTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerilerGöster();
        }

        private void frmmusteriler_Load(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            Msktelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTcno.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdano.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpGiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            datacıkıs.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            if (TxtOdano.Text == "101")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda101", con);
                cmd.ExecuteNonQuery();
                con.Close();
                VerilerGöster();
            }

            if (TxtOdano.Text == "102")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda102", con);
                cmd.ExecuteNonQuery();
                con.Close();
                VerilerGöster();
            }

            if (TxtOdano.Text == "103")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda103", con);
                cmd.ExecuteNonQuery();
                con.Close();
                VerilerGöster();
            }

            if (TxtOdano.Text == "104")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda104", con);
                cmd.ExecuteNonQuery();
                con.Close();
                VerilerGöster();
            }

            if (TxtOdano.Text == "105")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda105", con);
                cmd.ExecuteNonQuery();
                con.Close();
                VerilerGöster();
            }

            if (TxtOdano.Text == "106")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda106", con);
                cmd.ExecuteNonQuery();
                con.Close();
                VerilerGöster();
            }

            if (TxtOdano.Text == "107")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda107", con);
                cmd.ExecuteNonQuery();
                con.Close();
                VerilerGöster();
            }

            if (TxtOdano.Text == "108")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda108", con);
                cmd.ExecuteNonQuery();
                con.Close();
                VerilerGöster();
            }

            if (TxtOdano.Text == "109")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Oda109", con);
                cmd.ExecuteNonQuery();
                con.Close();
                VerilerGöster();
            }
            //con.Open();
            //SqlCommand cmd = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", con);
            //cmd.ExecuteNonQuery();
            //con.Close();
            //VerilerGöster();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update MusteriEkle set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + Msktelefon.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtTcno.Text + "',Odano='" + TxtOdano.Text + "',Ucret='" + txtucret.Text + "',GirisTarihi='" + dtpGiris.Value.ToString("yyy-MM-dd") + "',CikisTarihi='" + datacıkıs.Value.ToString("yyy-MM-dd") + "'where Musteriid=" + id + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            VerilerGöster();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from MusteriEkle where Adi like '%"+textBox1.Text+"%'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["Musteriid"].ToString();
                ekle.SubItems.Add(dr["Adi"].ToString());
                ekle.SubItems.Add(dr["Soyadi"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Mail"].ToString());
                ekle.SubItems.Add(dr["TC"].ToString());
                ekle.SubItems.Add(dr["Odano"].ToString());
                ekle.SubItems.Add(dr["Ucret"].ToString());
                ekle.SubItems.Add(dr["GirisTarihi"].ToString());
                ekle.SubItems.Add(dr["CikisTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True
