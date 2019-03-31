using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.checkBox1.Checked==true)
            {
                label1.Text = "Selecciono el Check1";
            }
            if (this.checkBox2.Checked == true)
            {
                label1.Text = "Selecciono el Check2";
            }
            if (this.checkBox3.Checked == true)
            {
                label1.Text = "Selecciono el Check3";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            if (this.checkBox1.Checked == true)
            {
                radioButton1.Checked = true;
                radioButton4.Checked = true;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;

            if (this.checkBox2.Checked == true)
            {
                radioButton2.Checked = true;
                radioButton4.Checked = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;

            if (this.checkBox3.Checked == true)
            {
                radioButton1.Checked = true;
                radioButton3.Checked = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Un solo click";
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "Doble solo click";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.radioButton1.Checked==true)
            {
                label1.Text = "Selecciono SUMA";
            }

            if (this.radioButton2.Checked == true)
            {
                label1.Text = "Selecciono RESTA";
            }

            if (this.radioButton3.Checked == true)
            {
                label1.Text = "Selecciono MULTIPLICACION";
            }

            if (this.radioButton4.Checked == true)
            {
                label1.Text = "Selecciono DIVISION";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CAMBIO DE COLOR
            if(comboBox1.SelectedIndex==0)
            {
                this.BackColor = Color.Blue;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                this.BackColor = Color.Red;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                this.BackColor= Color.Green;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //AÑADIR ITEMS
            int i;
            for (i=0;i<10;i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //copiar entre tect
            textBox2.Text = textBox1.Text;
        }

        
    }
}
