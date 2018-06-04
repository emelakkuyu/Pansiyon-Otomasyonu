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
    public partial class Frmgiris : Form
    {
        public Frmgiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True");
        private void btngiris_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "select *from giris where kullanici=@Kullaniciadi AND sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("kullaniciadi", txtkullaniciadi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sİfresi", txtsifre.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    AnaForm fr = new AnaForm();
                    fr.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş");
            }
        }
    }
}
