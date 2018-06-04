using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace görselProgramlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Integrated Security=True;Initial Catalog=pansiyon;Integrated Security=True");
        private void verilerigöster()
        {
            listView1.Items.Clear();
            bag.Open();
            SqlCommand com = new SqlCommand("Select *From müsteriler", bag);
            SqlDataReader oku = com.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["oda_no"].ToString());
                ekle.SubItems.Add(oku["Gtarih"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["hesap"].ToString());
                ekle.SubItems.Add(oku["ctarih"].ToString());
                listView1.Items.Add(ekle);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand com = new SqlCommand("insert into müsteriler(id,ad,soyad,oda_no,Gtarih,telefon,hesap,ctarih) values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + dateTimePicker1.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + dateTimePicker2.Text.ToString()+"')", bag);
            com.ExecuteNonQuery();
            bag.Close();
            verilerigöster();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            
        }
        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand com = new SqlCommand("Delete from müsteriler where id=("+id+")",bag);
            com.ExecuteNonQuery();
            bag.Close();
            verilerigöster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[7].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand com = new SqlCommand("update müsteriler set id='" + textBox1.Text.ToString() + "',ad='" + textBox2.Text.ToString() + "'soyad='" + textBox3.Text.ToString() + "',oda_no='" + textBox4.Text.ToString() + "',Gtarih='" + dateTimePicker1.Text.ToString() + "',telefon='" + textBox5.Text.ToString() + "',hesap='" + textBox6.Text.ToString() + "',ctarih='" + dateTimePicker2.Text.ToString() + "',where id='"+id+"",bag);
            com.ExecuteNonQuery();
            bag.Close();
            verilerigöster();
        }
    }
}
