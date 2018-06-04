using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "merhaba emel";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            int red = r.Next(254);
            int green = r.Next(256);
            int blue = r.Next(256);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
                button2.Text = "durdur";
            else
                button2.Text = "baslat";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int red = r.Next(254);
            int green = r.Next(256);
            int blue = r.Next(256);
            this.BackColor = Color.FromArgb(red, green, blue);
            textBox1.Left = textBox1.Left + 4;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
