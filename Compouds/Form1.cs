using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compounds
{
    public partial class Form1 : Form
    {
        string suit = "";
        bool thisCondition = false;
        bool thatCondition = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void hurricaneButton_Click(object sender, EventArgs e)
        {
            //get the inputted category
            string category = categoryInput.Text;
            
            //check the inputted category with a switch block
            switch (category)
            {
                case "1":
                    categoryOutput.Text = "119-153 km/h";
                    break;
                case "2":
                    categoryOutput.Text = "154-177 km/h";
                    break;
                case "3":
                    categoryOutput.Text = "178-209 km/h";
                    break;
                case "4":
                    categoryOutput.Text = "210-249 km/h";
                    break;
                case "5":
                    categoryOutput.Text = "greater than 249 km/h";
                    break;
                default:
                    categoryOutput.Text = "not a valid category";
                    break;
            }
        }

        private void heartButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "heart";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Goldenrod;
            diamondButton.BackColor = Color.Black;
            clubButton.BackColor = Color.Black;
            spadeButton.BackColor = Color.Black;            
        }

        private void diamondButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "diamond";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Black;
            diamondButton.BackColor = Color.Goldenrod;
            clubButton.BackColor = Color.Black;
            spadeButton.BackColor = Color.Black;
        }

        private void clubButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "club";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Black;
            diamondButton.BackColor = Color.Black;
            clubButton.BackColor = Color.Goldenrod;
            spadeButton.BackColor = Color.Black;
        }

        private void spadeButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "spade";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Black;
            diamondButton.BackColor = Color.Black;
            clubButton.BackColor = Color.Black;
            spadeButton.BackColor = Color.Goldenrod;
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            //use compound if statements to check what suit
            //has been selected and output the colour of the suit
            if (suit == "heart" || suit == "diamond")
            {
                suitOutput.Text = "The card colour is red";
            }
            else if (suit == "club" || suit == "spade")
            {
                suitOutput.Text = "The card colour is red";
            }
            else
            {
                suitOutput.Text = "No suit had been selected";
            }            
        }

        private void thisButton_Click(object sender, EventArgs e)
        {
            //set thisCondition to opposite of what it currently 
            //is, and change BackColor to Black for false and 
            //Goldenrod for true           

            if (thisCondition == true)
            {
                thisCondition = false;
                thisButton.BackColor = Color.Black;
            }
            else
            {
                thisCondition = true;
                thisButton.BackColor = Color.Goldenrod;
            }
        }

        private void thatButton_Click(object sender, EventArgs e)
        {
            //set thatCondition to opposite of what it currently 
            //is, and change BackColor to Black for false and 
            //Goldenrod for true

            if (thatCondition == true)
            {
                thatCondition = false;
                thatButton.BackColor = Color.Black;
            }
            else
            {
                thatCondition = true;
                thatButton.BackColor = Color.Goldenrod;
            }
        }

        private void andButton_Click(object sender, EventArgs e)
        {
            //use compound if statements to see if both conditions
            //are true, false, or different
            if (thisCondition == true && thatCondition == true)
            {
                andLabel.Text = "Both conditions are true";
            }
            else if (thisCondition == false && thatCondition == false)
            {
                andLabel.Text = "Both conditions are false";
            }
            else
            {
                andLabel.Text = "The conditions are different";
            }
        }
    }
}
