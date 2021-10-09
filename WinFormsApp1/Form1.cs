using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MaximizeBox = false;
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = 0;
            int con = 0;
            try
            {
                con = Convert.ToInt32(textBox1.Text);
            }
            catch
            {

            }
            if (con <= 30)
            {
                try
                {
                    length = Convert.ToInt32(textBox1.Text);
                }
                catch
                {

                }
            }
            else
            {
                
            }
            
            string password = string.Empty;

            if (checkBox1.Checked == true)
            {
                string symb = "1 2 3 4 5 6 7 8 9 0";
                string[] symbols = symb.Split();
                for (int i = 0; i < length; i++)
                {
                    Random inr = new Random();
                    string symbol = symbols[inr.Next(0, symbols.Length - 1)];
                    password += symbol;

                }
                if (password is not null)
                {
                    textBox2.Text = password;
                }

            }


            else if (checkBox2.Checked == true && checkBox4.Checked == true)
            {
                string symb = "q w e r t y u i o p a s d f g h j k l z x c v b n m Q W E R T Y U I O P A S D F G H J K L Z X C V B N M";
                string[] symbols = symb.Split();
                for (int i = 0; i < length; i++)
                {
                    Random inr = new Random();
                    string symbol = symbols[inr.Next(0, symbols.Length - 1)];
                    password += symbol;
                }
                if (password is not null)
                {
                    textBox2.Text = password;
                }
            }
            else if (checkBox3.Checked == true && checkBox4.Checked == true)
            {
                string symb = "q w e r t y u i o p a s d f g h j k l z x c v b n m Q W E R T Y U I O P A S D F G H J K L Z X C V B N M 1 2 3 4 5 6 7 8 9 0";
                string[] symbols = symb.Split();
                for (int i = 0; i < length; i++)
                {
                    Random inr = new Random();
                    string symbol = symbols[inr.Next(0, symbols.Length - 1)];
                    password += symbol;

                }
                if (password is not null)
                {
                    textBox2.Text = password;
                }
            }

            else if (checkBox2.Checked == true && checkBox4.Checked == false)
            {
                string symb = "q w e r t y u i o p a s d f g h j k l z x c v b n m";
                string[] symbols = symb.Split();
                for (int i = 0; i < length; i++)
                {
                    Random inr = new Random();
                    string symbol = symbols[inr.Next(0, symbols.Length - 1)];
                    password += symbol;

                }
                if (password is not null)
                {
                    textBox2.Text = password;
                }
            }

            else if (checkBox3.Checked == true && checkBox4.Checked == false)
            {
                string symb = "q w e r t y u i o p a s d f g h j k l z x c v b n m 1 2 3 4 5 6 7 8 9 0";
                string [] symbols = symb.Split();
                for (int i = 0; i < length; i++)
                {
                    Random inr = new Random();
                    string symbol = symbols[inr.Next(0, symbols.Length - 1)];
                    password += symbol;
                }
                if (password is not null)
                {
                    textBox2.Text = password;
                }
            }

            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string password = textBox2.Text;
            if (password != null)
            {
                try
                {
                    Clipboard.SetText(password);
                }
                catch
                {

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox4.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {   
            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
            }
           
        }
    }
}