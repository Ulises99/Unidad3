using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, n, suma = 0;

            listBox1.Items.Clear();
            n = int.Parse(textBox1.Text);
            for(x=1;x<=n;x++)
            {
                suma = suma + x;
                if(checkBox1.Checked==true)
                {
                    listBox1.Items.Add("Sumando: " + x + " Suma Parcial: " + suma);
                }
            }
            listBox1.Items.Add("La suma TOTAL es: " + suma);
        }
    }
}
