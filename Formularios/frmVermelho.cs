using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmVermelho : Form
    {
        public string mensagem;

        public frmVermelho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = mensagem;
        }
    }
}