using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1_DM_
{
    public partial class Form1 : Form
    {
        public List<int> arrA = new List<int>();
        public List<int> arrB = new List<int>();
        public List<int> arrABit = new List<int>();
        public List<int> arrBBit = new List<int>();
        public List<int> arrU = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Преобразование к битовому ряду
            arrA.Clear();
            arrABit.Clear();
            for(int i=0; i < textBox1.Text.Length; i++)
            {
                arrA.Add(Convert.ToInt32(textBox1.Text[i])-'0');
            }
            string str = "";
            foreach(var i in arrU)
            {
                if (arrA.Contains(i))
                {
                    str += "1 ";
                    arrABit.Add(1);
                }
                else
                {
                    str += "0 ";
                    arrABit.Add(0);
                }

            }
            label4.Text = str;
            label11.Text = str;
            label13.Text = str;
            label15.Text = str;
            label17.Text = str;
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Преорбразование к битовому ряду
            arrB.Clear();
            arrBBit.Clear();
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                arrB.Add(Convert.ToInt32(textBox2.Text[i]) - '0');
            }
            string str = "";
            foreach (var i in arrU)
            {
                if (arrB.Contains(i))
                {
                    str += "1 ";
                    arrBBit.Add(1);
                }
                else
                {
                    str += "0 ";
                    arrBBit.Add(0);
                }

            }
            label5.Text = str;
            label12.Text = str;
            label14.Text = str;
            label16.Text = str;
            label18.Text = str;
            //
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int counter = 0;
            bool first = false;
            foreach(var i in arrA)
            {
                if (arrB.Contains(i))
                {
                    counter++;
                }
            }
            if (counter == arrA.Count)
            {
                label7.Text = "Да";
                first = true;
            }
            else
            {
                label7.Text = "Нет";
            }

            counter = 0;
            bool second = false;
            foreach (var i in arrB)
            {
                if (arrA.Contains(i))
                {
                    counter++;
                }
            }
            if (counter == arrB.Count)
            {
                label8.Text = "Да";
                second = true;
            }
            else
            {
                label8.Text = "Нет";
            }

            if (first == true && second == true)
            {
                label10.Text = "Да";
            }
            else
            {
                label10.Text = "Нет";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string str = "";
            for(int i=0; i < arrABit.Count; i++)
            {
                str += (arrABit[i] & arrBBit[i]).ToString() + " ";
            }
            label19.Text = str;

            string arr = "";
            str = str.Replace(" ", "");
            int counter = 1;
            foreach (var i in str)
            {
                if (i == '1')
                {
                    arr += (counter) + " ";
                }
                counter++;
            }
            label24.Text = arr;

            str = "";
            for (int i=0; i < arrABit.Count; i++)
            {
                str += (arrABit[i] | arrBBit[i]).ToString() + " ";
            }
            label20.Text = str;

            arr = "";
            str = str.Replace(" ", "");
            counter = 1;
            foreach (var i in str)
            {
                if (i == '1')
                {
                    arr += (counter) + " ";
                }
                counter++;
            }
            label25.Text = arr;
            str = "";
            for(int i=0; i < arrABit.Count; i++)
            {
                str += (arrABit[i] ^ arrBBit[i]).ToString() + " ";
            }

            label21.Text = str;

            arr = "";
            str = str.Replace(" ", "");
            counter = 1;
            foreach (var i in str)
            {
                if (i == '1')
                {
                    arr += (counter) + " ";
                }
                counter++;
            }
            label26.Text = arr;

            str = "";
            for (int i = 0; i < arrABit.Count; i++)
            {
                if (~arrABit[i] == -2)
                {
                    str += "0 ";
                }
                else
                {
                    str += "1 ";
                }
            }
            label22.Text = str;
            arr = "";
            str = str.Replace(" ", "");
            counter = 1;
            foreach (var i in str)
            {
                if (i == '1')
                {
                    arr += (counter) + " ";
                }
                counter++;
            }
            label27.Text = arr;

            str = "";
            for (int i = 0; i < arrBBit.Count; i++)
            {
                if (~arrBBit[i] == -2)
                {
                    str += "0 ";
                }
                else
                {
                    str += "1 ";
                }
            }
            label23.Text = str;
            arr = "";
            str = str.Replace(" ", "");
            counter = 1;
            foreach (var i in str)
            {
                if (i == '1')
                {
                    arr += (counter) + " ";
                }
                counter++;
            }
            label28.Text = arr;

            string[,] C = new string[arrA.Count, arrB.Count];

            str = "(";
            for (int i = 0; i < arrA.Count; i++)
            {
                for (int j = 0; j < arrB.Count; j++)
                {
                    C[i, j] = arrA[i].ToString() +","+ arrB[j].ToString();
                    str += "(" + C[i,j]  + ")";
                }
                str += ",";
            }
            str += ")";
            richTextBox1.Text = str;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
