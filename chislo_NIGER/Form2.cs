using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chislo_NIGER
{
    public partial class Form2 : Form
    {
        int popok;
        int rand;
        int num;
        int op;
        public Form2(int o)
        {
            this.num = o;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            switch (num)
            {
                case 0:
                    rand = new Random().Next(0, 10);
                    label1.Text = "угадай число от 0 до 10";
                    label3.Text = "попыток осталось: inf";
                    label4.Text = "Подсказки от бота";
                    break;

                case 1:
                    rand = new Random().Next(0, 100);
                    label1.Text = "угадай число от 0 до 100";
                    popok = 10;
                    label3.Text = "попыток осталось: " + popok.ToString();
                    label4.Text = "Подсказки от бота";
                    break;

                case 2:
                    rand = new Random().Next(0, 100);
                    label1.Text = "угадай число от 0 до 100";
                    popok = 5;
                    label3.Text = "попыток осталось: " + popok.ToString();
                    label4.Text = "5 уникальных вопросов, которые можно спросить у бота";
                    break;

                default: break;
            }

            label2.Text = rand.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iapidoras();
        }

        private void iapidoras()
        {

            switch (num)
            {
                case 0:
                    if (int.Parse(textBox1.Text) < rand)
                    {
                        label4.Text = "число больше";
                    }
                    else if (int.Parse(textBox1.Text) > rand)
                    {
                        label4.Text = "число меньше";
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button1.Visible = false;
                        MessageBox.Show("COCU");
                    }
                    break;
                case 1:
                    if (int.Parse(textBox1.Text) < rand)
                    {
                        label4.Text = "число больше";
                    }
                    else if (int.Parse(textBox1.Text) > rand)
                    {
                        label4.Text = "число меньше";
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button1.Visible = false;
                        MessageBox.Show("COCU");
                    }

                    popok--;
                    label3.Text = "попыток осталось: " + popok.ToString();

                    if (popok <= 0)
                    {
                        textBox1.Visible = false;
                        button1.Visible = false;
                        MessageBox.Show("Bce");
                    }
                    break;
                /*case 2:
                    if (int.Parse(textBox1.Text) < rand)
                    {
                        label4.Text = "число больше";
                    }
                    else if (int.Parse(textBox1.Text) > rand)
                    {
                        label4.Text = "число меньше";
                    }
                    else
                    {
                        textBox1.Visible = false;
                        button1.Visible = false;
                        MessageBox.Show("COCU");
                    }

                    popok--;
                    label3.Text = "попыток осталось: " + popok.ToString();

                    if (popok <= 0)
                    {
                        textBox1.Visible = false;
                        button1.Visible = false;
                        MessageBox.Show("Bce");
                    }*/
            }
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (rand == 0) { }
        }
    }
}
