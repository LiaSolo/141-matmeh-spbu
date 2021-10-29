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
    public partial class PalindromForm : Form
    {
        string vvod;
        public PalindromForm()
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
            label1.Text = IsPalendrom(vvod) ? "Это палиндром" : "Ты чего(((( нет конечно";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "Тут будет ответ - ";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //НЕНУЖНЫЙ ЛЕЙБЛ ЗАЧЕМ НАЖАЛ БЛИН 
            //пРИВЕТ ЛИЯ
            //ПРИВЕТ АНДРЕЙ 
            //ААА бейби
            // Здесь был Азат
        }

























































        private void PictureReptile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ТЫ ЧЕГО КЛИКАЕШЬ,    УКУСУ нЯм ^-^");
        }

        private void pictureCat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("НЯ ^-^ Охаё оницян");
        }
    }
}
