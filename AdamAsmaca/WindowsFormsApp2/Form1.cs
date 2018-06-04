using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class adamasmaca
        {
            public struct y_kelime
            {
                public string kelime;
                public string katagori;

            }
            public y_kelime kelime_olustur(string kelime, string katogeri)
            {
                y_kelime kelimemiz = new y_kelime();
                kelimemiz.kelime = kelime;
                kelimemiz.katagori = katogeri;
                return kelimemiz;

            }
        }
    }
}
