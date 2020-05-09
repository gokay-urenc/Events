using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Test";
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
            textBox1.Focus();
            int tiklama_sayisi = Convert.ToInt32(label1.Text);
            tiklama_sayisi++;
            label1.Text = tiklama_sayisi.ToString();
            bool sonuc = Convert.ToBoolean(tiklama_sayisi % 2);
            button1.Text = sonuc.ToString();
        }

        private void textBox1_BackColorChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Yazının rengi değişti.");
        }
    }
}
