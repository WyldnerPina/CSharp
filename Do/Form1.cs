using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Do
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 20;
            do
            {
                contador++;
                listBox1.Items.Add(contador);
                if (contador == 10)
                {
                    break;
                }
            }
            while (contador < 20) ;
        }
    }
}