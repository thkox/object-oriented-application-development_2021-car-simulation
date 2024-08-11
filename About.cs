using System;
using System.Windows.Forms;

namespace P20094_FirstProject
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = $"       Crossroad Simulation Game {Environment.NewLine}{Environment.NewLine}Created by: Theodore Koxanoglou {Environment.NewLine}AM:P20094" +
                $"{Environment.NewLine}{Environment.NewLine}About the Game: {Environment.NewLine} I have created two buttons. One to start and stop the timers of the game and one more to check certain cases of the simulation." +
                $"{Environment.NewLine}{Environment.NewLine}When you are going to check the 'cases button', the button was designed in a way that it will guide you through all the different scenarios that the cars will be in." +
                $"{Environment.NewLine}{Environment.NewLine}   When you are ready, press close.";
            richTextBox1.ReadOnly = true;
            richTextBox1.TabStop = false;
        }

        private void exitAbout_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
