// Assignment: Create a working cash register about your choice of three items,
// calculate and print the items on a reciept
// 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
using System.Net.Security;
using System.Media;

namespace project
{

    
    

    public partial class Form1 : Form
    {
        // three int variables for storing numbers of items, and three prices for each respectful item.
        // Introducing more global variables for ease of accessibility throughout the program

        double whiskeyPrice = 4.35, cigarPrice = 2.50, ammoPrice = 10.97, taxTotal,
            totalCost, change, subTotalCost, taxRate = 0.13;

        int numWhiskey = 0, numCigars = 0, numAmmo = 0, tendered;


        private void restartButton_Click(object sender, EventArgs e)
        {
            //Create a working restart button that resets the variables and allows further experimentation
            try
            {
                // reset inputted values

                numWhiskey = 0;
                numCigars = 0;
                numAmmo = 0;
                totalCost = 0;
                change = 0;
                subTotalCost = 0;
                tendered = 0;

                printButton.Enabled = false;
                restartButton.Enabled = false;
                changeButton.Enabled = false;

                // reset output displays + reciept display

                recieptOutput.Text = "";
                subTotalOutput.Text = "";
                changeOutput.Text = "";
                taxOutput.Text = "";
                totalOutput.Text = "";

                tenderedInput.Text = "0";
                whiskeyInput.Text = "0";
                cigarInput.Text = "0";
                ammoInput.Text = "0";

                
            }
            catch
            {
                recieptOutput.Text = $"Something Went Wrong. . .";
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {

            //Print a Receipt that will display every transaction, items bought, subtotal, tax and total cost
            try
            {
                //state soundplayer and sound

                SoundPlayer player = new SoundPlayer(Properties.Resources.pageturn);
                player.Play();

                //switch sound for more dramatic and emmursive effect

                player = new SoundPlayer(Properties.Resources.writing);

                recieptOutput.Text = $"\n\n\n               Variety Saloon Inc.";
                player.Play();
                Thread.Sleep(1000);
                Refresh();

                recieptOutput.Text += $"\n\n    Order Number 104";
                player.Play();
                Thread.Sleep(1000);
                Refresh();

                recieptOutput.Text += $"\n\n    Febuary 27th 2023";
                player.Play();
                Thread.Sleep(1000);
                Refresh();

                // do not display prices if they are not purchased if statements to check

                if (numWhiskey > 0)
                {
                    recieptOutput.Text += $"\n\n    Whiskey Bottles:        x{numWhiskey} : @ ${whiskeyPrice}";
                    player.Play();
                    Thread.Sleep(1000);
                    Refresh();
                }

                // do not display prices if they are not purchased if statements to check

                if (numCigars > 0)
                {
                    recieptOutput.Text += $"\n\n    Cigar Packs:            x{numCigars} : @ ${cigarPrice}";
                    player.Play();
                    Thread.Sleep(1000);
                    Refresh();
                }

                // do not display prices if they are not purchased if statements to check

                if (numAmmo > 0)
                {
                    recieptOutput.Text += $"\n\n    Ammunition Packs: 9mm : x{numAmmo} : @ ${ammoPrice}";
                    player.Play();
                    Thread.Sleep(1000);
                    Refresh();
                }

                recieptOutput.Text += $"\n\n    Subtotal:                      ${subTotalCost.ToString("0.00")}";
                player.Play();
                Thread.Sleep(1000);
                Refresh();

                recieptOutput.Text += $"\n\n    Tax:                           ${taxTotal.ToString("0.00")}";
                player.Play();
                Thread.Sleep(1000);
                Refresh();

                recieptOutput.Text += $"\n\n    Total:                         ${totalCost.ToString("0.00")}";
                player.Play();

                // If statement to change a negative tendered value to "In-Sufficient Funds".

                Thread.Sleep(1000);
                Refresh();

                // if tendered is not enough to pay

                if (change < 0)
                {
                    recieptOutput.Text += $"\n\n    Tendered:                      ${tendered.ToString("0.00")}";
                    player.Play();
                    Thread.Sleep(1000);
                    Refresh();

                    recieptOutput.Text += $"\n\n    Change: In-sufficient Funds";
                    player.Play();
                    Thread.Sleep(1000);
                    Refresh();

                    player = new SoundPlayer(Properties.Resources.ting);
                    player.Play();

                    //because change is negative in this senario, change the tab value to positive to display what the player owes.

                    recieptOutput.Text += $"\n\n      Tab:                        {change.ToString("C")}";

                }

                // if tendered is enough to pay

                if (change > 0)
                {
                    recieptOutput.Text += $"\n\n    Tendered:                      ${tendered.ToString("0.00")}";
                    Thread.Sleep(1000);
                    Refresh();
                    player.Play();

                    recieptOutput.Text += $"\n\n    Change:                        ${change.ToString("0.00")}";
                    Thread.Sleep(1000);
                    Refresh();

                    player = new SoundPlayer(Properties.Resources.ting);
                    player.Play();
                    recieptOutput.Text += $"\n\n      Thank you For your Purchase";

                }

                // enables new order button and removes pressing of other buttons

                Thread.Sleep(1000);
                Refresh();

                printButton.Enabled = false;
                changeButton.Enabled = false;
                restartButton.Enabled = true;
            }
            catch
            {
                recieptOutput.Text = $"\n\n\n Please Calculate Before Printing . . .";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // tendered ammount converts text into a value, then calcalculates change dependant on the global variable
                tendered = Convert.ToInt32(tenderedInput.Text);

                change = tendered - totalCost;

                changeOutput.Text = change.ToString("C");

                printButton.Enabled = true;

            }
            catch
            {
                changeOutput.Text = $"Calculate First";
            }
        }


        public Form1()
        {
            InitializeComponent();

            // initiialize all inputs to 0

            whiskeyInput.Text = "0";
            cigarInput.Text = "0";
            ammoInput.Text = "0";
            tenderedInput.Text = "0";

            // disable print button, change button and restart button

            printButton.Enabled = false;
            changeButton.Enabled = false;
            restartButton.Enabled = false;
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {

            // if statement to take good inputs

            try
            {
                // make the variables hold a value inputted into their text.box

                numWhiskey = Convert.ToInt16(whiskeyInput.Text);
                numCigars = Convert.ToInt16(cigarInput.Text);
                numAmmo = Convert.ToInt16(ammoInput.Text);
            }
            catch
            {
                subTotalOutput.Text = $"Number's Only";
            }


            {
                // calculating total cost and taxtotal
                subTotalCost = (numWhiskey * whiskeyPrice) + (numCigars * cigarPrice) + (ammoPrice * numAmmo);

                taxTotal = subTotalCost * taxRate;

                totalCost = taxTotal + subTotalCost;

                // outputting text with correct decimal places

                subTotalOutput.Text = subTotalCost.ToString("$0.00");
                taxOutput.Text = taxTotal.ToString("$0.00");
                totalOutput.Text = totalCost.ToString("$0.00");

                //allowing the press of the change button

                changeButton.Enabled = true;

            }

           



            

        }
    }
}
