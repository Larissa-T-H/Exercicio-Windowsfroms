using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nome = { "Messa", "Cadeira", "Fogão", "Geladeira", "Bicicleta", "Geladeira" };

            foreach (string item in nome)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (object item in listBox1.Items)
            {
                comboBox1.Items.Add(item.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                MessageBox.Show("O CheckBox está marcado");
            }
            else
            {
                MessageBox.Show("O CheckBox não está marcado");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String dt = textBox4.Text;
                DateTime data = Convert.ToDateTime(dt);
                label1.Text = $"Dia: {data.Day}";
                label2.Text = $"Mês: {data.Month}";
                label3.Text = $"Ano: {data.Year}";
            }
            catch(InvalidCastException)
            {
                MessageBox.Show("Formato de data errado!!");
            }
        }

    }
}
