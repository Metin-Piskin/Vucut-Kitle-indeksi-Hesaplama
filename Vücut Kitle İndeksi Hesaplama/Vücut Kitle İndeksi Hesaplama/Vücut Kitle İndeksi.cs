using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vücut_Kitle_İndeksi_Hesaplama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, vki;
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToDouble(textBox2.Text);
            vki = kilo / (boy * boy);
            label5.Text = vki.ToString();
            if (vki < 18)
            {
                label6.Text = "Zayıf";
            }
            else if (vki >= 18 && vki < 25)
            {
                label6.Text = "Normal";
            }
            else if (vki >= 25 && vki < 30)
            {
                label6.Text = "Kilolu";
            }
            else if (vki >= 30 && vki < 35)
            {
                label6.Text = "Obez";
            }
            else
            {
                label6.Text = "Ciddi Obez";
            }
            label5.Visible = true;
            label6.Visible = true;
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label5.Visible = false;
            label6.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
