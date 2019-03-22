using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, r;
            string datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a + b;
            datos="Resultado"+r.ToString();
            label1.Text = datos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, r;
            string datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a - b;
            datos = "Resultado" + r.ToString();
            label1.Text = datos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, r;
            string datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a * b;
            datos = "Resultado" + r.ToString();
            label1.Text = datos;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, r;
            string datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
           
            if(b==0)
            {
                label1.Text = "ERROR";
            }
            else {
                r = a / b;
                datos = "Resultado" + r.ToString();
                label1.Text = datos;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
