using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_terminal
{
    public partial class Form1 : Form
    {

        int latte = 30;
        int kapuchino = 35;
        int aspresso = 40;
        int americano = 45;
        int mokko = 46;

        int vznos;
        int cost;



        public Form1()
        {
            InitializeComponent();
          
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = String.Format("Количество кусочков сахара: {0}", trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked || radioButton3.Checked || radioButton2.Checked || radioButton5.Checked || radioButton1.Checked)
            {

            }
            else
            {
                MessageBox.Show(
        "Напиток не выбран",
        "Сообщение",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
            }

            vznos = Convert.ToInt32(textBox2.Text);
            cost = Convert.ToInt32(textBox1.Text);
            if (vznos >= cost)
            {
                this.timer1.Start();
                MessageBox.Show(
                                  "Ваш кофе готовиться,ждите",
                                  "Сообщение",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information,
                                  MessageBoxDefaultButton.Button1,
                                  MessageBoxOptions.DefaultDesktopOnly);


            }
            else
            {
                MessageBox.Show(
         "Ошибка,не хватает средств для завершения операции",
        "Сообщение",
         MessageBoxButtons.OK,
         MessageBoxIcon.Error,
         MessageBoxDefaultButton.Button1,
         MessageBoxOptions.DefaultDesktopOnly);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(latte);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(kapuchino);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(aspresso);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(americano);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(mokko);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                MessageBox.Show(
                                                "Ваш кофе готов",
                                                  "Сообщение",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Information,
                                                  MessageBoxDefaultButton.Button1,
                                                  MessageBoxOptions.DefaultDesktopOnly);

                this.timer1.Stop();
                progressBar1.Value = 0;
                Application.DoEvents();
                if (vznos > cost)
                {
                    int sdt = vznos - cost;
                    MessageBox.Show(
                                               "Сдача:"+ sdt +"руб",
                                                 "Сообщение",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information,
                                                 MessageBoxDefaultButton.Button1,
                                                 MessageBoxOptions.DefaultDesktopOnly);
                }


            }
            
            else
            {

                this.progressBar1.Increment(1);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}


