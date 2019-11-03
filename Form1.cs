using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3b
{   /*
     * Author: Huy Mac - 000775402
     * Date: 24, October 2019
     * Purpose: Execute the controls' function in the form.
     * Statement of Authorship: This is my own work 
     */
    public partial class Form1 : Form
    {
        private bool isHairdresserSelected;// Declare hairdresserSelected variable
        private decimal totalCost = 0.0M; // Declare total cost variable
        public Form1()
        {
            isHairdresserSelected = false; // Set false valuse to isHairdresserSelected variable, it means no option at the beginning
            InitializeComponent();
            calculateTotalPriceButton.Enabled = false;// Set Enabled function off of Total Price Button at the beginning.
        }
        /// <summary>
        /// Add Service Button will execute the button such as adding the hairdresser, service and prices to listbox
        /// </summary>
        /// <param name="sender">The object name sender</param>
        /// <param name="e">The event Argument name e</param>
        private void addServiceButton_Click(object sender, EventArgs e)
        {
            calculateTotalPriceButton.Enabled = true;// Set Enabled function on after clicking the add button
            // Handle hairdresser
            if (isHairdresserSelected == false)
            {
                isHairdresserSelected = true;// Set true value to isHairdresserSelected variable, it means option 
                hairdresserComboBox.Enabled = false;// Set Enabled function off 
                // Add Hairdresser price
                if (hairdresserComboBox.SelectedItem == "Jane Samley")
                {
                    itemListBox.Items.Add("Jane Samley");
                    priceListBox.Items.Add("$30.00");
                    totalCost = 30.0M; ;
                }
                // Add Hairdresser price
                else if (hairdresserComboBox.SelectedItem == "Pat Johnson")
                {
                    itemListBox.Items.Add("Pat Johnson");
                    priceListBox.Items.Add("$45.00");
                    totalCost = 45.0M;
                }
                // Add Hairdresser price
                else if (hairdresserComboBox.SelectedItem == "Ron Chambers")
                {
                    itemListBox.Items.Add("Ron Chambers");
                    priceListBox.Items.Add("$40.00");
                    totalCost = 40.0M;
                }
                // Add Hairdresser price
                else if (hairdresserComboBox.SelectedItem == "Sue Pallon")
                {
                    itemListBox.Items.Add("Sue Pallon");
                    priceListBox.Items.Add("$50.00");
                    totalCost = 50.0M;
                }
                // Add Hairdresser price
                else if (hairdresserComboBox.SelectedItem == "Laura Renkins")
                {
                    itemListBox.Items.Add("Laura Renkins");
                    priceListBox.Items.Add("$55.00");
                    totalCost = 55.0M;
                }
            }

            // Handle adding services
            itemListBox.Items.Add(serviceListBox.SelectedItem);// Add services' name to the listbox
            // Add service price
            if (serviceListBox.SelectedItem == "Cut")
            {
                priceListBox.Items.Add("$30.00");
                totalCost += 30.0M;
            }
            // Add service price
            else if (serviceListBox.SelectedItem == "Wash, blow-dry, and style")
            {
                priceListBox.Items.Add("$20.00");
                totalCost += 20.0M;
            }
            // Add service price
            else if (serviceListBox.SelectedItem == "Colour")
            {
                priceListBox.Items.Add("$40.00");
                totalCost += 40.0M;
            }
            // Add service price
            else if (serviceListBox.SelectedItem == "Highlights")
            {
                priceListBox.Items.Add("$50.00");
                totalCost += 50.0M;
            }
            // Add service price
            else if (serviceListBox.SelectedItem == "Extensions")
            {
                priceListBox.Items.Add("$200.00");
                totalCost += 200.0M;
            }
            // Add service price
            else if (serviceListBox.SelectedItem == "Up-do")
            {
                priceListBox.Items.Add("$60.00");
                totalCost += 60.0M;
            }
        }
        /// <summary>
        /// Total Price button uses to calculate the total price
        /// </summary>
        /// <param name="sender">The object name sender</param>
        /// <param name="e">The event Argument name e</param>
        private void calculateTotalPriceButton_Click(object sender, EventArgs e)
        {
            priceTextBox.Text = $"${Math.Round((totalCost), 2)}";// The fomula
        }
        /// <summary>
        /// Reset button uses to clear all information in controls
        /// </summary>
        /// <param name="sender">The object name sender</param>
        /// <param name="e">The event Argument name e</param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            isHairdresserSelected = false;// Set false valuse to isHairdresserSelected variable, it means no option
            itemListBox.Items.Clear();// Clear itemListBox
            priceListBox.Items.Clear();// Clear priceListBox
            priceTextBox.Clear();// Clear priceTextBox
            hairdresserComboBox.Enabled = true;// Enabled hairdresserComBox
            calculateTotalPriceButton.Enabled = false;// Disable the totalPriceButton

        }
        /// <summary>
        /// Exit the form
        /// </summary>
        /// <param name="sender">The object name sender</param>
        /// <param name="e">The event Argument name e</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();// Close the form
        }
    }
}
