using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Proyecto0002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones ingreso = new Operaciones();
            ingreso.V1 = double.Parse(lblValA.Text);
            ingreso.V2 = double.Parse(lblValB.Text);

            label3.Text=ingreso.Calcular().ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Resta re = new Resta();
            re.R1 = double.Parse(lblValA.Text);
            re.R2 = double.Parse(lblValB.Text);

            label3.Text = re.CalRestar().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Multiplicar mu = new Multiplicar();
            mu.M1 = double.Parse(lblValA.Text);
            mu.M2 = double.Parse(lblValB.Text);

            label3.Text = mu.CalMulti().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dividir di = new Dividir();
            di.D1 = double.Parse(lblValA.Text);
            di.D2 = double.Parse(lblValB.Text);

            label3.Text = di.CalDiv().ToString();
        }
    }
}
