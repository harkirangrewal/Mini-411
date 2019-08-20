using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_411
{
    public partial class Form1 : Form
    {
        public string[] PhoneArray = new string[100];
        public string[] NameArray = new string[100];
        public int iCurrentIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string strName, strPhone; //strFirstLetter

                strPhone = Convert.ToString(txtPhoneNumber.Text);
                strName = Convert.ToString(txtName.Text);
                
                strName = strName.Trim();
                strPhone = strPhone.Trim();

                strName = strName.ToLower();
                strPhone = strPhone.ToLower();

                lbPhoneOutput.Items.Clear();
                lbNameOutput.Items.Clear();
                //Both inputs are trimmed, put to lowercase, & output boxes are cleared.

                if (strName == "" || strPhone == "")
                {
                    MessageBox.Show("Please enter a value!!");
                    return;
                }


                /*strFirstLetter = strName.Substring(0, 1);
                strName = strName.Remove(0,1);

                strFirstLetter = strFirstLetter.ToUpper();
                strName = strFirstLetter + strName;*/
                //Converts first letter of name to upper case.
                
                

                if (iCurrentIndex > 100)
                {
                    MessageBox.Show("The phone book is full.");
                    return;
                }
                else
                {
                    NameArray[iCurrentIndex] = strName;
                    PhoneArray[iCurrentIndex] = strPhone;
                    iCurrentIndex++;

                    txtPhoneNumber.Clear();
                    txtName.Clear();
                }
                /* This portion enables the user to input a name, and phone number
                  under the condition that both of the textboxes have an input value. 
                   The number and name save in their corresponding Arrays */
            }

            catch
            {
                MessageBox.Show("The entered value is incorrect");
                txtName.Clear();
                txtPhoneNumber.Clear();
            }
        }

        private void btnNumberofCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                lbNameOutput.Items.Clear();
                lbPhoneOutput.Items.Clear();
                lbNameOutput.Items.Add(iCurrentIndex);
            }
            catch
            {
                MessageBox.Show("The entered value is incorrect");
                return;
            }
            // The number of people in the system is outputted through a listbox.
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int i;

            try
            {
                lbNameOutput.Items.Clear();
                lbPhoneOutput.Items.Clear();
                txtPhoneNumber.Clear();
                txtName.Clear();
                // Clears the output and input boxes, before showing saved data

                for (i = 0; i < iCurrentIndex; i = i + 1)
                {
                    lbNameOutput.Items.Add(NameArray[i]);
                    lbPhoneOutput.Items.Add(PhoneArray[i]);
                }
                /*Loop used to go through each index 
                and display everything added by the user.*/
            }
            catch
            {
                MessageBox.Show("Invalid Input.");
                return;
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                string strName;

                lbPhoneOutput.Items.Clear();
                lbNameOutput.Items.Clear();
                txtPhoneNumber.Clear();

                strName = Convert.ToString(txtName.Text);
                strName = strName.Trim();
                strName = strName.ToLower();

                if (strName == "")
                {
                    MessageBox.Show("Please enter a name!");
                    return;
                }

                for (i = 0; i < iCurrentIndex; i = i + 1)
                {
                    if (strName == NameArray[i])
                    {
                        lbNameOutput.Items.Add(NameArray[i]);
                        lbPhoneOutput.Items.Add(PhoneArray[i]);
                        return;
                    }


                }

                MessageBox.Show("Sorry, this person is not saved within the directory.");


                // Allows the unput of a name, and checks if that name is in the directory.
                // If the name is saved, the program will output the person's name and phone number.
            }
            catch
            {
                MessageBox.Show("That is an invalid entry!");
                return;
            }
        }

        private void btnSearchNumber_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                string strPhone;

                strPhone = Convert.ToString(txtPhoneNumber.Text);

                lbNameOutput.Items.Clear();
                lbPhoneOutput.Items.Clear();
                txtName.Clear();
                strPhone = strPhone.Trim();

                if (strPhone == "")
                {
                    MessageBox.Show("Please enter a number to search!");
                    return;
                }

                for (i = 0; i < iCurrentIndex; i = i + 1)
                {
                    if (strPhone == PhoneArray[i])
                    {
                        lbPhoneOutput.Items.Add(PhoneArray[i]);
                        lbNameOutput.Items.Add(NameArray[i]);
                        return;
                    }
                }
                MessageBox.Show("Sorry. This number does not match with a person.");
            }
            catch
            {
                MessageBox.Show("Invalid Input.");
                return;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void lbNameOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;

            index = lbNameOutput.SelectedIndex;
            lbPhoneOutput.SelectedIndex = index;
        }

        private void lbPhoneOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;

            index = lbPhoneOutput.SelectedIndex;
            lbNameOutput.SelectedIndex = index;
        }

        private void txtEditPhone_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                string strPhone, strName;

                lbPhoneOutput.Items.Clear();
                lbNameOutput.Items.Clear();
                strPhone = Convert.ToString(txtPhoneNumber.Text);

                strName = Convert.ToString(txtName.Text);
                strName = strName.Trim();
                strName = strName.ToLower();
                strPhone = strPhone.Trim();

                if (strName == "")
                {
                    MessageBox.Show("Please enter a name!");
                    return;
                }

                if (strPhone == "")
                {
                    MessageBox.Show("Please enter a new phone number!");
                    return;
                }

                for (i = 0; i < iCurrentIndex; i = i + 1)
                {
                    if (strName == NameArray[i])
                    {
                        PhoneArray[i] = strPhone;
                        MessageBox.Show("Number change successful.");
                        lbPhoneOutput.Items.Add(PhoneArray[i]);
                        lbNameOutput.Items.Add(NameArray[i]);
                        return;
                    }
                    /*Finds person in the NAME ARRAY. Grabs number from PHONE ARRAY. 
                    Changes number to what was put in the text box. 
                    Shows message box indicating that changes were successful.
                    Displays name and new number in the output boxes.*/
                }

                MessageBox.Show("Sorry, this person is not saved within the directory.");

            }
            catch
            {
                MessageBox.Show("That is an invalid entry!");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int i, j;
                string strName;

                strName = Convert.ToString(txtName.Text);

                lbPhoneOutput.Items.Clear();
                lbNameOutput.Items.Clear();

                strName = strName.Trim();

                if (strName == "")
                {
                    MessageBox.Show("Please enter a name to delete.");
                    return;
                }

                for (i = 0; i < iCurrentIndex; i = i + 1)
                {
                    if (strName == NameArray[i])
                    {

                        for (j = i; j < iCurrentIndex; j = j + 1)
                        {
                            NameArray[j] = NameArray[j + 1];
                            PhoneArray[j] = PhoneArray[j + 1];
                        }
                        iCurrentIndex = iCurrentIndex - 1;

                        MessageBox.Show("The data has sucessfully been removed from the system!");
                        txtName.Clear();
                        txtPhoneNumber.Clear();
                        // Find array index with the given name, remove name and number by replacing with index below
                        // The program is then reset.

                        for (i = 0; i < iCurrentIndex; i = i + 1)
                        {
                            lbNameOutput.Items.Add(NameArray[i]);
                            lbPhoneOutput.Items.Add(PhoneArray[i]);
                        }
                        //The rest of the inputted values are then outputted into the list boxes.
                    }
                }
            }

            catch
            {
                MessageBox.Show("That is an invalid entry! ");
                return;
            }
        }
    }
}

