using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool IsPalindrome(in string symbols)
        {
            for (int i = 0; i < symbols.Length / 2; i++)
            {
                if (symbols[i] != symbols[symbols.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }


        private void checkButton_Click(object sender, EventArgs e)
        {
            string word = mainTextBox.Text.ToLower().Replace(" ", "");

            if (word == "")
            {
                answerLabel.Text = "Введите слово";
                return;
            }

            if (IsPalindrome(word))
            {
                answerLabel.Text = "Да";
            }
            else
            {
                answerLabel.Text = "Нет";
            }
        }

        private void сlearButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
            answerLabel.Text = "";
        }
    }
}