//Program 2
//CIS 199-01
//Due: 10/22/2017
//By: A5604
//This Program allows the user to input their first character of their last name and class standing to find out when to register for classes
using System;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Submitbutton_Click(object sender, EventArgs e) //This Event handler looks up the date and time tied with their name and class standings
        {
            //Variables
            string SeniorDate = "November 3rd";// Senior Registration Date
            string JuniorDate = "November 6th";// Junior Registration Date
            string UpperAD = "10:00 AM";// Last names beginning A to D and their time to register
            string UpperEI = "11:30 AM";// Last names beginning E to I and their time to register
            string UpperJO = "2:00 PM";// Last names beginning J to O and their time to register
            string UpperPS = "4:00 PM";// Last names beginning P to S and their time to register
            string UpperTZ = "8:30 AM";// Last names beginning T to Z and their time to register

            string SophDate1 = "November 7th";// Sophmore Registration Date for the rest
            string SophDate2 = "November 8th";// Sophmore Registration Date for G-S
            string FreshDate1 = "November 9th";// Freshmen Registration Date for the rest
            string FreshDate2 = "November 10th";// Freshmen Registration Date for G-S
            string LowerAB = "11:30 AM";// Last names beginning A to B and their time to register
            string LowerCD = "2:00 PM";// Last names beginning C to D and their time to register
            string LowerEF = "4:00 PM";// Last names beginning E to F and their time to register
            string LowerGI = "8:30 AM";// Last names beginning G to I and their time to register
            string LowerJL = "10:00 PM";// Last names beginning J to L and their time to register
            string LowerMO = "11:30 PM";// Last names beginning M to O and their time to register
            string LowerPQ = "2:00 PM";// Last names beginning P to Q and their time to register
            string LowerRS = "4:00 PM";// Last names beginning R to S and their time to register
            string LowerTV = "8:30 AM";// Last names beginning T to V and their time to register
            string LowerWZ = "10:00 PM";// Last names beginning W to Z and their time to register

            string GraduateDate = "November 2nd"; //Graduate Date
            string GraduateTime = "10:30 AM"; //Graduate Time to register

            char Letter = char.Parse(LastNameText.Text); //Makes the text in the textbox into a char 

            if (SeniorRadio.Checked || JuniorRadio.Checked)
            {
                //Upperclassmen Date Logic
                if (SeniorRadio.Checked)
                    DateOutput.Text = SeniorDate;
                else
                    DateOutput.Text = JuniorDate;

                //Upperclassmen Time 
                if (char.ToUpper(Letter) <= 'D') //Makes the character into a capital letter if it wasn't already
                    TimeOutput.Text = UpperAD;
                else
                    if (char.ToUpper(Letter) <= 'I')
                    TimeOutput.Text = UpperEI;
                else
                    if (char.ToUpper(Letter) <= 'O')
                    TimeOutput.Text = UpperJO;
                else
                    if (char.ToUpper(Letter) <= 'S')
                    TimeOutput.Text = UpperPS;
                else
                    if (char.ToUpper(Letter) <= 'Z')
                    TimeOutput.Text = UpperTZ;
            }
            else
            {
                if (SophmoreRadio.Checked || FreshmenRadio.Checked)
                {
                    //Lowerclassmen Date
                    if (SophmoreRadio.Checked)
                    {
                        if (char.ToUpper(Letter) >= 'G' && char.ToUpper(Letter) <= 'S')
                            DateOutput.Text = SophDate2;
                        else
                        if (char.ToUpper(Letter) < 'G' || char.ToUpper(Letter) > 'S')
                            DateOutput.Text = SophDate1;
                    }

                    if (FreshmenRadio.Checked)
                    {
                        if (char.ToUpper(Letter) >= 'G' && char.ToUpper(Letter) <= 'S')
                            DateOutput.Text = FreshDate2;
                        else
                        if (char.ToUpper(Letter) < 'G' || char.ToUpper(Letter) > 'S')
                            DateOutput.Text = FreshDate1;
                    }

                    //Lowerclassmen Time  
                    if (char.ToUpper(Letter) <= 'B')
                        TimeOutput.Text = LowerAB;
                    else
                    if (char.ToUpper(Letter) <= 'D')
                        TimeOutput.Text = LowerCD;
                    else
                    if (char.ToUpper(Letter) <= 'F')
                        TimeOutput.Text = LowerEF;
                    else
                    if (char.ToUpper(Letter) <= 'I')
                        TimeOutput.Text = LowerGI;
                    else
                    if (char.ToUpper(Letter) <= 'L')
                        TimeOutput.Text = LowerJL;
                    else
                    if (char.ToUpper(Letter) <= 'O')
                        TimeOutput.Text = LowerMO;
                    else
                    if (char.ToUpper(Letter) <= 'Q')
                        TimeOutput.Text = LowerPQ;
                    else
                    if (char.ToUpper(Letter) <= 'S')
                        TimeOutput.Text = LowerRS;
                    else
                    if (char.ToUpper(Letter) <= 'V')
                        TimeOutput.Text = LowerTV;
                    else
                    if (char.ToUpper(Letter) <= 'Z')
                        TimeOutput.Text = LowerWZ;

                }
                else
                    if (GraduateRadio.Checked)
                {
                    TimeOutput.Text = GraduateTime;
                    DateOutput.Text = GraduateDate;
                }
                    

            }
        }
    }
}