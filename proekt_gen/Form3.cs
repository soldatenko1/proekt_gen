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

    public partial class Form3 : Form
    {
        public Form3()
        {
            
             
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При регистрации в компьютерной системе каждому пользователю выдаётся пароль, состоящий из 15 символов и содержащий только символы из 12-символьного набора: А, В, C, D, Е, F, G, H, К, L, M, N. В базе данных для хранения сведений о каждом пользователе отведено одинаковое и минимально возможное целое число байт. При этом используют посимвольное кодирование паролей, все символы кодируют одинаковым и минимально возможным количеством бит. Кроме собственно пароля, для каждого пользователя в системе хранятся дополнительные сведения, для чего отведено 12 байт на одного пользователя.\r\n\r\nОпределите объём памяти (в байтах), необходимый для хранения сведений о 50 пользователях. В ответе запишите только целое число  — количество байт.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При регистрации в компьютерной системе каждому пользователю выдаётся пароль, состоящий из 15 символов и содержащий только символы из 12-символьного набора: А, В, C, D, Е, F, G, H, K, L, M, N. В базе данных для хранения сведений о каждом пользователе отведено одинаковое и минимально возможное целое число байт. При этом используют посимвольное кодирование паролей, все символы кодируют одинаковым и минимально возможным количеством бит. Кроме собственно пароля, для каждого пользователя в системе хранятся дополнительные сведения, для чего выделено целое число байт; это число одно и то же для всех пользователей. Для хранения сведений о 20 пользователях потребовалось 400 байт. Сколько байт выделено для хранения дополнительных сведений об одном пользователе? В ответе запишите только целое число – количество байт.\r\n\r\n");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При регистрации в компьютерной системе каждому пользователю выдаётся пароль, состоящий из 15 символов и содержащий только символы из 12 буквенного набора А, В, Е, К, М, Н, О, Р, С, Т, У, X. В базе данных для хранения сведений о каждом пользователе отведено одинаковое и минимально возможное целое число байт. При этом используют посимвольное кодирование паролей, все символы кодируются одинаковым и минимально возможным количеством бит. Кроме пароля для каждого пользователя в системе хранятся дополнительные сведения, для чего отведено 12 байт.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При регистрации в компьютерной системе каждому пользователю выдаётся пароль, состоящий из 6 символов и содержащий только символы из 7 буквенного набора Н, О, Р, С, Т, У, X. В базе данных для хранения сведений о каждом пользователе отведено одинаковое и минимально возможное целое число байт. При этом используют посимвольное кодирование паролей, все символы кодируются одинаковым и минимально возможным количеством бит. Кроме собственно пароля для каждого пользователя в системе хранятся дополнительные сведения, для чего отведено 10 байт.\r\n\r\n ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При регистрации в компьютерной системе каждому пользователю выдаётся пароль, состоящий из 6 символов и содержащий только символы из 7-буквенного набора Н, О, Р, С, Т, У, X. В базе данных для хранения сведений о каждом пользователе отведено одинаковое целое число байт, при этом для хранения сведений о 100 пользователях используется 1400 байт. Для каждого пользователя хранятся пароль и дополнительные сведения. Для хранения паролей используют посимвольное кодирование, все символы кодируются одинаковым и минимально возможным количеством бит. Сколько бит отведено для хранения дополнительных сведений о каждом пользователе?");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При регистрации в компьютерной системе каждому пользователю выдаётся пароль, состоящий из 10 символов и содержащий только символы из 7-буквенного набора Н, О, Р, С, Т, У, X. В базе данных для хранения сведений о каждом пользователе отведено одинаковое целое число байт, при этом для хранения сведений о 100 пользователях используется 1500 байт. Для каждого пользователя хранятся пароль и дополнительные сведения. Для хранения паролей используют посимвольное кодирование, все символы кодируются одинаковым и минимально возможным количеством бит. Сколько бит отведено для хранения дополнительных сведений о каждом пользователе?");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) 1000, 2) 12, 3) 1000, 4) 1300, 5) 94, 6) 90.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans1 = textBox1.Text;
            int ans1_ = 0;
            try
            {
                ans1_ = Convert.ToInt32(ans1);
                if (ans1_ == 1000) { textBox1.BackColor = Color.Green; }
                else { textBox1.BackColor = Color.Red; }
            }
            catch (Exception err)
            {
                textBox1.Text = "";
                Console.WriteLine("{0} Exception caught.", err);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ans2 = textBox2.Text;
            int ans2_ = 0;
            try
            {
                ans2_ = Convert.ToInt32(ans2);
                if (ans2_ == 12) { textBox2.BackColor = Color.Green; }
                else { textBox2.BackColor = Color.Red; }
            }
            catch (Exception err)
            {
                textBox2.Text = "";
                Console.WriteLine("{0} Exception caught.", err);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string ans3 = textBox3.Text;
            int ans3_ = 0;
            try
            {
                ans3_ = Convert.ToInt32(ans3);
                if (ans3_ == 1000) { textBox3.BackColor = Color.Green; }
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
                if (ans4_ == 1300) { textBox4.BackColor = Color.Green; }
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
                if (ans5_ == 94) { textBox5.BackColor = Color.Green; }
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
                if (ans6_ == 90) { textBox6.BackColor = Color.Green; }
                else { textBox6.BackColor = Color.Red; }
            }
            catch ( Exception err)
            { textBox6.Text="";
                Console.WriteLine("{0} Exception caught.", err);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
