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
using System.IO;

namespace Muh_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=diyetisyenprogram;Integrated Security=True");
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog file = new OpenFileDialog();
            //file.InitialDirectory = @"C:\Users\eakku\Source\Repos\Muh_4\dosyalar";
            //file.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.csv";
            //file.FilterIndex = 2;
            //file.ShowDialog();
            string[] ogrprofil = File.ReadAllLines("ogrenciProfil.csv");
            string[] columnTitles = ogrprofil[0].Split(',');
            var query = ogrprofil.Skip(1).Select((r, index) => new
            {
                i = index,
                Data = r.Split(',')
            }).ToList();
            for (int i = 0; i < query.Count; i++)
            {
                dataGridView1.Rows.Add(
                  query[i].Data[0], query[i].Data[1],
                  query[i].Data[2], query[i].Data[3], query[i].Data[4],
                  query[i].Data[5], query[i].Data[6],
                  query[i].Data[7], query[i].Data[8],
                  query[i].Data[9], query[i].Data[10], query[i].Data[11]
                 );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] ogrnetwork = File.ReadAllLines("ogrenciNetwork.csv");
            string[] columnTitles = ogrnetwork[0].Split(',');
            var query = ogrnetwork.Skip(1).Select((r, index) => new
            {
                i = index,
                Data = r.Split(',')
            }).ToList();
            for (int i = 0; i < query.Count; i++)
            {
                dataGridView1.Rows.Add(
                  query[i].Data[0], query[i].Data[1],
                  query[i].Data[2], query[i].Data[3], query[i].Data[4],
                  query[i].Data[5], query[i].Data[6],
                  query[i].Data[7], query[i].Data[8],
                  query[i].Data[9], query[i].Data[10], query[i].Data[11]
                 );
            }
        }
    }
}
