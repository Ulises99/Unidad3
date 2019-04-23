﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            listBox1.Items.Clear();
            DriveInfo[] u = DriveInfo.GetDrives();

            foreach (DriveInfo unidad in u)
            {

                try
                {
                    listBox1.Items.Add(unidad.Name);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("ERROR DE LECTURA" + ex.Message);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            String unidades = listBox1.SelectedIndex.ToString();
            listBox2.Items.Add(unidades);
        }
    }
}
