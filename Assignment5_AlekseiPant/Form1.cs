using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_AlekseiPant
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int number = 0;
        int guesses = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            enterNumber.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
            number = random.Next(1, 100);
            guesses = 0;
        }

        private void checkButton(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(enterNumber.Text);
            guesses += 1;
            if (i == number)
            {
                textBox2.Text = "Congratulations, you guessed the number " + number + "!" + "\r" + "\n" + "You guessed " + guesses + " times";
                enterNumber.Text = "";
                guesses = 0;
            }
            else if (i < number)
            {
                textBox2.Text = "Too low, try again" + "\r" + "\n" + "You guessed " + guesses + " times";
            }
            else
            {
                textBox2.Text = "Too high, try again" + "\r" + "\n" + "You guessed " + guesses + " times";
            }
        }
    }
}
