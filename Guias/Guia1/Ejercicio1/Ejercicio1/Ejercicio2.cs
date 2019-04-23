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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, password;
            usuario = txtLogin.Text.TrimEnd();
            password = txtPassword.Text.TrimEnd();
            if((usuario=="UTEC")&&(password=="programacion1"))
            {
                MessageBox.Show("BIENVENIDOS AL SISTEMA");
            }
            else
            {
                MessageBox.Show("VERIFIQUE USUARIO Y PASS");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
