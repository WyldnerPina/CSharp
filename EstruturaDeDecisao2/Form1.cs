using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstruturaDeDecusao2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToString(listBox1.SelectedItem))
            {
                case "Fevereiro":
                    MessageBox.Show ("este mes tem 28 dias");
                    break;
                case "Abril":
                case "Junho":
                case "Setembro":
                case "Novembro":
                    MessageBox.Show("este mes tem 30 dias");
                    break;
                default:
                    MessageBox.Show("este mes tem 31 dias");
                    break;

            }
        }
    }
}