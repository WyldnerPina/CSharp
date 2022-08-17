using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        string[,] jogadores = new string[11,2];
        int contador = 0;
        int contadorFaltas = 0;

        public Form1()
        {
            InitializeComponent();
        }
            
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (contador <= 10 && textBox1.Text != "")
            {
                jogadores[contador,0] = textBox1.Text;
                contador += 1;
                textBox1.Text = null;
            }
            else
                button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(jogadores[i,0] + " - Total de Faltas: " + jogadores [i,1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (contadorFaltas <= 10 && textBox2.Text != "")
            {
                jogadores[contadorFaltas, 1] = textBox2.Text;
                contadorFaltas += 1;
                textBox2.Text = null;
            }
            else
                button2.Enabled = false;
        }
    }
}