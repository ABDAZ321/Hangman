using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        string[] word;
        string[] DisplayWord;
        string[] UsedWord = new string[26];

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateWord(object sender, EventArgs e)
        {
            // Make a collection of random words
            string[] wordCollection = new string[] { "Hour","Dodge","Swarmer","Manner" };

            Random rand = new Random();

            string RandWord = wordCollection[rand.Next(wordCollection.Length)];
          
            word = new string[RandWord.Length];

            for(int i = 0; i < RandWord.Length; i++)
            {
                word[i] = RandWord[i].ToString();
            }

            DisplayWord = new string[word.Length];

            for(int i = 0; i < word.Length; i++)
            {
                DisplayWord[i] = "_";
            }

            MainWordContainer.Text = String.Join(" ",DisplayWord).ToUpper(); ;
        }

        private void InputLetterBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_letter(object sender, EventArgs e)
        {
            bool wasRight = false;
            if (InputLetterBox.Text != null && word != null)
            {
                for(int i = 0; i < word.Length; i++)
                {
                    if(word[i].ToLower() == InputLetterBox.Text.ToLower())
                    {
                        DisplayWord[i] = word[i];
                        wasRight = true;
                    }
                }
                MainWordContainer.Text = String.Join(" ", DisplayWord).ToUpper();
            }
            if (!wasRight)
            {
                MessageBox.Show("NAH FAM");
            }

            if(word == DisplayWord)
            {
                MessageBox.Show("You won");
            }
        }
    }
}
