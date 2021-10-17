using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Палиндром
{
    public partial class Form1 : Form
    {
        string vvod;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            vvod = textBox1.Text;
        }

        static bool IsPalendrom(string vvod)
        {
            vvod = vvod.ToUpper();
            vvod = vvod.Replace(" ", "");
            for (int k = 0; k <= vvod.Length / 2; k++)
            {
                if (vvod[k]!=vvod[vvod.Length-k-1])
                {
                    return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = IsPalendrom(vvod) ? "Это палиндром" : "Я так не думаю";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "Тут будет ответ";
        }
    }
}
