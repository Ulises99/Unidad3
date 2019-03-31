using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace Tarea_Operaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            Suma obj = new Suma();

            obj.S1 = double.Parse(textBox1.Text);
            obj.S2 = double.Parse(textBox2.Text);

            label3.Text = obj.Calculo().ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            Resta obj = new Resta();

            obj.R1 = double.Parse(textBox1.Text);
            obj.R2 = double.Parse(textBox2.Text);

            label3.Text = obj.Calculo().ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;

            Multiplicacion obj = new Multiplicacion();

            obj.M1 = double.Parse(textBox1.Text);
            obj.M2 = double.Parse(textBox2.Text);

            label3.Text = obj.Calculo().ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            Division obj = new Division();

            obj.D1 = double.Parse(textBox1.Text);
            obj.D2 = double.Parse(textBox2.Text);

            label3.Text = obj.Calculo().ToString();
        }
    }
}
