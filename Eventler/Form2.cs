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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int karakter_sayisi = textBox1.Text.Length;
            int fark = 140 - karakter_sayisi;
            label_karakter_sayisi.Text = fark.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            bool kalan = Convert.ToInt32(label_karakter_sayisi.Text) <= 0;
            e.SuppressKeyPress = kalan && e.KeyCode != Keys.Back;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Clipboard.GetText().Length > (140 - textBox1.Text.Length) && e.KeyChar == 22;
        }
    }
}