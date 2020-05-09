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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          // checkBox1.Checked = !checkBox1.Checked; // true ise false ya da tam tersi.
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked;
            button1.Top += 20;
        }
    }
}
/* Buton 1'in click olayındaki kodun uzun hali:
if (checkBox1.Checked)
{
    checkBox1.Checked = false;
}
else
{
    checkBox1.Checked = true;
}
*/