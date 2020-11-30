using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1modica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int f = 1; f <= 10; f++) //número de mesa
            {
                comboBox1.Items.Add(f.ToString());
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Falta ingresar el nombre del mozo");
                return;
            }
            else
            {
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Falta selecionar el número de mesa");
                    return;
                }
                else
                {
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("Falta ingresar un valor en la propina");
                        return;
                    }
                    else
                    {
                        if (radioButton1.Checked==false && radioButton2.Checked == false && radioButton3.Checked == false)
                        {
                            MessageBox.Show("Falta selecionar el menu principal");
                            return;
                        }
                        else
                        {
                            int total=0;

                            total += int.Parse(textBox2.Text); //propina

                            if (comboBox2.SelectedIndex != -1) //postre
                                total += 100;

                            if (checkBox1.Checked) //bebidas
                                total += 120;
                            if (checkBox2.Checked)
                                total += 80;
                            if (checkBox3.Checked)
                                total += 150;
                            if (checkBox4.Checked)
                                total += 130;

                            if (radioButton1.Checked) //menu principal
                                total += 200;
                            if (radioButton2.Checked)
                                total += 300;
                            if (radioButton3.Checked)
                                total += 250;

                            label4.Text = "Costo total: $"+total;
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
