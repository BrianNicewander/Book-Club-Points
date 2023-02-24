using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Club_Points
{
    public partial class bookClubPoints : Form
    {
        public bookClubPoints()
        {
            InitializeComponent();
        }

        private void btnEnterbooks_Click(object sender, EventArgs e)
        {
            int books = 0;
                if (int.TryParse(txtBooks.Text, out books)) //makes sure the user puts in a number
                   { 
                    if(books >= 0) { // checks to make sure the user puts in a postive number

                        if(books == 0) // checks if the user put in 0 
                        {
                            lblOutput.Text = "0"; //shows the user the amount of points they get
                        }

                        else if (books == 1) // checks if the user put in 0 
                    {
                            lblOutput.Text = "5"; //shows the user the amount of points they get
                    }

                        else if(books == 2) // checks if the user put in 1 
                    {
                            lblOutput.Text = "15"; //shows the user the amount of points they get
                    }

                        else if(books == 3) // checks if the user put in 2 
                    {
                            lblOutput.Text = "30"; //shows the user the amount of points they get
                    }

                        else if (books >= 4) // checks if the user put in 4 or higher 
                    {
                            lblOutput.Text = "60"; //shows the user the amount of points they get
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a number 0 or higher"); //shows error if the user puts in a neg number
                }

                }
                else
                {
                MessageBox.Show("Please enter a number 0 or higher"); //shows if the user puts in something other than a number
                }
            }
        }
    }