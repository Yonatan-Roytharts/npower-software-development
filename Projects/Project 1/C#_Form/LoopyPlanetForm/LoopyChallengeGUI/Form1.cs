using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopyChallengeGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void jupiterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(weightTextBox.Text))
                outputMessage.Text = "Weight field can not be EMPTY!";
            else
            {
                double result = 2.64 * Convert.ToDouble(weightTextBox.Text);

                outputMessage.Text = "Your weight on Jupiter will be " + string.Format("{0:0.0}", result) + " pounds";
            }
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(weightTextBox.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only positive numbers.");
                weightTextBox.Text = weightTextBox.Text.Remove(weightTextBox.Text.Length - 1);
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program will quit");
            this.Close();
        }

        private void marsButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(weightTextBox.Text))
                outputMessage.Text = "Weight field can not be EMPTY!";
            else
            {
                double result = 0.38 * Convert.ToDouble(weightTextBox.Text);

                outputMessage.Text = "Your weight on Mars will be " + string.Format("{0:0.0}", result) + " pounds";
            }
        }

        private void mercuryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(weightTextBox.Text))
                outputMessage.Text = "Weight field can not be EMPTY!";
            else
            {
                double result = 0.37 * Convert.ToDouble(weightTextBox.Text);

                outputMessage.Text = "Your weight on Mercury will be " + string.Format("{0:0.0}", result) + " pounds";
            }
        }

        private void neptuneButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(weightTextBox.Text))
                outputMessage.Text = "Weight field can not be EMPTY!";
            else
            {
                double result = 1.12 * Convert.ToDouble(weightTextBox.Text);

                outputMessage.Text = "Your weight on Neptune will be " + string.Format("{0:0.0}", result) + " pounds";
            }
        }

        private void plutoButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(weightTextBox.Text))
                outputMessage.Text = "Weight field can not be EMPTY!";
            else
            {
                double result = 0.04 * Convert.ToDouble(weightTextBox.Text);

                outputMessage.Text = "Your weight on Pluto will be " + string.Format("{0:0.0}", result) + " pounds";
            }
        }

        private void saturnButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(weightTextBox.Text))
                outputMessage.Text = "Weight field can not be EMPTY!";
            else
            {
                double result = 1.15 * Convert.ToDouble(weightTextBox.Text);

                outputMessage.Text = "Your weight on Saturn will be " + string.Format("{0:0.0}", result) + " pounds";
            }
        }

        private void uranusButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(weightTextBox.Text))
                outputMessage.Text = "Weight field can not be EMPTY!";
            else
            {
                double result = 1.15 * Convert.ToDouble(weightTextBox.Text);

                outputMessage.Text = "Your weight on Uranus will be " + string.Format("{0:0.0}", result) + " pounds";
            }
        }

        private void venusButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(weightTextBox.Text))
                outputMessage.Text = "Weight field can not be EMPTY!";
            else
            {
                double result = 0.88 * Convert.ToDouble(weightTextBox.Text);

                outputMessage.Text = "Your weight on Venus will be " + string.Format("{0:0.0}", result) + " pounds";
            }
        }
    }
}
