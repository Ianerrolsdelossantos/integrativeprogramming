using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Guessing_Game_Windows_Application
{
    public partial class wordToGuess : Form
    {

        
        private string correctWord = "computer";

        public wordToGuess()
        {
            InitializeComponent();


           
            lblWord.Text = CreateHint(correctWord);
        }

        
        private string CreateHint(string word)
        {
            StringBuilder hint = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                
                if (i == 0 || i == 4 || i == 6)
                {
                    hint.Append(char.ToUpper(word[i]));
                }
                else
                {
                    hint.Append("?");
                }
            }

            return hint.ToString();
        }




        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string userGuess = txtGuess.Text.Trim().ToLower();

            if (userGuess == "")
            {
                MessageBox.Show("Please enter a word.");
                return;
            }

            
            if (userGuess == correctWord)
            {
                lblWord.Text = "Correct! The word is: " + correctWord;
                MessageBox.Show("You guessed it!");
            }
            else
            {
                lstWrongGuesses.Items.Add(userGuess);
                MessageBox.Show("Incorrect, try again.");
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }


    }
}

