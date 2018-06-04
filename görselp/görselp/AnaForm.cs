using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görselp
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmgiris fr = new Frmgiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yenimüsteri fr = new yenimüsteri();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmmusteriler fr = new frmmusteriler();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmgelirgider fr = new Frmgelirgider();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStoklar fr = new FrmStoklar();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SifreGuncelle sg = new SifreGuncelle();
            sg.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmMesajlar fm = new frmMesajlar();
            fm.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
