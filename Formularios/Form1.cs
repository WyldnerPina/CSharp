using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVerde Verde = new frmVerde();
            Verde.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVermelho Vermelho = new frmVermelho();
            Vermelho.Show();
            Vermelho.mensagem = "fprmulario form1";
        }
    }
}