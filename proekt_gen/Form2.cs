using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt_gen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans1 = textBox1.Text;
            int ans1_ = 0;
            try
            {
                ans1_ = Convert.ToInt32(ans1);
                if (ans1_ == 100) { textBox1.BackColor = Color.Green; }
                else { textBox1.BackColor = Color.Red; }
            }
            catch (Exception err)
            {
                textBox1.Text = "";
                Console.WriteLine("{0} Exception caught.", err);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При регистрации в компьютерной системе каждому пользователю выдаётся пароль, состоящий из 11 символов и содержащий только символы А, Б, В, Г, Д, Е. Каждый такой пароль в компьютерной программе записывается минимально возможным и одинаковым целым количеством байт, при этом используют посимвольное кодирование и все символы кодируются одинаковым и минимально возможным количеством бит. Определите, сколько байт необходимо для хранения 20 паролей.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При регистрации в компьютерной системе каждому пользователю выдаётся пароль, состоящий из 11 символов и содержащий только символы А, Б, В, Е, Ж, М, Н, Р, У, Я (таким образом, используется 10 различных символов). Каждый такой пароль в компьютерной системе записывается минимально возможным и одинаковым целым количеством байт (при этом используют посимвольное кодирование и все символы кодируются одинаковым и минимально возможным количеством бит). Укажите объём памяти в байтах, отводимый этой системой для записи 70 паролей.\r\n\r\nВ ответе запишите только число, слово «байт» писать не нужно.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ans2 = textBox2.Text;
            int ans2_ = 0;
            try
            {
                ans2_ = Convert.ToInt32(ans2);
                if (ans2_ == 320) { textBox2.BackColor = Color.Green; }
                else { textBox2.BackColor = Color.Red; }
            }
            catch (Exception err)
            {
                textBox2.Text = "";
                Console.WriteLine("{0} Exception caught.", err);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При регистрации в компьютерной системе каждому пользователю выдаётся пароль, состоящий из 20 символов и содержащий только символы А, Б, В, Г, Д. Каждый такой пароль в компьютерной программе записывается минимально возможным и одинаковым целым количеством байт, при этом используют посимвольное кодирование и все символы кодируются одинаковым и минимально возможным количеством бит. Определите, сколько байт необходимо для хранения 50 паролей.");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string ans3 = textBox3.Text;
            int ans3_ = 0;
            try
            {
                ans3_ = Convert.ToInt32(ans3);
                if (ans3_ == 420) { textBox3.BackColor = Color.Green; }
                else { textBox3.BackColor = Color.Red; }
            }
            catch (Exception err)
            {
                textBox3.Text = "";
                Console.WriteLine("{0} Exception caught.", err);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string ans4 = textBox6.Text;
            int ans4_ = 0;
            try
            {
                ans4_ = Convert.ToInt32(ans4);
                if (ans4_ == 450) { textBox4.BackColor = Color.Green; }
                else { textBox4.BackColor = Color.Red; }
            }
            catch (Exception err)
            {
                textBox4.Text = "";
                Console.WriteLine("{0} Exception caught.", err);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string ans5 = textBox5.Text;
            int ans5_ = 0;
            try
            {
                ans5_ = Convert.ToInt32(ans5);
                if (ans5_ == 100) { textBox5.BackColor = Color.Green; }
                else { textBox5.BackColor = Color.Red; }
            }
            catch (Exception err)
            {
                textBox5.Text = "";
                Console.WriteLine("{0} Exception caught.", err);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string ans6 = textBox6.Text;
            int ans6_ = 0;
            try
            {
                ans6_ = Convert.ToInt32(ans6);
                if (ans6_ == 400) { textBox6.BackColor = Color.Green; }
                else { textBox6.BackColor = Color.Red; }
            }
            catch (Exception err)
            {
                textBox6.Text = "";
                Console.WriteLine("{0} Exception caught.", err);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При регистрации в компьютерной системе каждому пользователю выдаётся пароль, состоящий из 21 символов и содержащий только символы A, D, F, H, X, Y, Z (таким образом, используется 7 различных символов). Каждый такой пароль в компьютерной программе записывается минимально возможным и одинаковым целым количеством байт (при этом используют посимвольное кодирование и все символы кодируются одинаковым и минимально возможным количеством бит). Определите объём памяти в байтах, отводимый этой программой для записи 40 паролей.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При регистрации в компьютерной системе каждому пользователю выдаётся пароль, состоящий из 23 символов и содержащий только символы A, F, G, Y, S, L (таким образом, используется 6 различных символов). Каждый такой пароль в компьютерной программе записывается минимально возможным и одинаковым целым количеством байт (при этом используют посимвольное кодирование и все символы кодируются одинаковым и минимально возможным количеством бит). Определите объём памяти в байтах, отводимый этой программой для записи 50 паролей. В ответе укажите только число, слово \"байт\" писать не нужно.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При регистрации в компьютерной системе каждому пользователю выдаётся пароль, состоящий из 12 символов и содержащий только символы А, Б, В, Г, Д, Е. Каждый такой пароль в компьютерной программе записывается минимально возможным и одинаковым целым количеством байт, при этом используют посимвольное кодирование и все символы кодируются одинаковым и минимально возможным количеством бит. Определите, сколько байт необходимо для хранения 20 паролей.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) 100, 2) 320, 3) 420, 4) 450, 5) 100, 6) 400.");
        }
    }
}
