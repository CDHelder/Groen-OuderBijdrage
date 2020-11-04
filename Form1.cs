using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groen__Ouderbijdrage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Hide all things not yet necessary
            HideTextBeforeAgeInput();

            //Only one of the family situation buttons can be selected
            if (oneParentButton.Checked)
                twoParentsButton.Checked = false;
            if (twoParentsButton.Checked)
                oneParentButton.Checked = false;

        }
        private void HideTextBeforeAgeInput()
        {
            labelText2.Visible = false;

            bReset.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
            dateTimePicker5.Visible = false;

            labelText3.Visible = false;
            oneParentButton.Visible = false;
            twoParentsButton.Visible = false;

            bCalculate.Visible = false;

            labelParentalContribution.Visible = false;
            labelParentalContributionAmount.Visible = false;

        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Show amount of dates for the amount of children selected
            switch (numericUpDown1.Value)
            {
                case 1:
                    labelText2.Visible = true;
                    label1.Visible = true;
                    dateTimePicker1.Visible = true;
                    bReset.Visible = true;
                    labelText3.Visible = true;
                    oneParentButton.Visible = true;
                    twoParentsButton.Visible = true;
                    bCalculate.Visible = true;
                    break;
                case 2:
                    labelText2.Visible = true;
                    label1.Visible = true;
                    dateTimePicker1.Visible = true;
                    label2.Visible = true;
                    dateTimePicker2.Visible = true;
                    bReset.Visible = true;
                    labelText3.Visible = true;
                    oneParentButton.Visible = true;
                    twoParentsButton.Visible = true;
                    bCalculate.Visible = true;
                    break;
                case 3:
                    labelText2.Visible = true;
                    label1.Visible = true;
                    dateTimePicker1.Visible = true;
                    label2.Visible = true;
                    dateTimePicker2.Visible = true;
                    label3.Visible = true;
                    dateTimePicker3.Visible = true;
                    bReset.Visible = true;
                    labelText3.Visible = true;
                    oneParentButton.Visible = true;
                    twoParentsButton.Visible = true;
                    bCalculate.Visible = true;
                    break;
                case 4:
                    labelText2.Visible = true;
                    label1.Visible = true;
                    dateTimePicker1.Visible = true;
                    label2.Visible = true;
                    dateTimePicker2.Visible = true;
                    label3.Visible = true;
                    dateTimePicker3.Visible = true;
                    label4.Visible = true;
                    dateTimePicker4.Visible = true;
                    bReset.Visible = true;
                    labelText3.Visible = true;
                    oneParentButton.Visible = true;
                    twoParentsButton.Visible = true;
                    bCalculate.Visible = true;
                    break;
                case 5:
                    labelText2.Visible = true;
                    label1.Visible = true;
                    dateTimePicker1.Visible = true;
                    label2.Visible = true;
                    dateTimePicker2.Visible = true;
                    label3.Visible = true;
                    dateTimePicker3.Visible = true;
                    label4.Visible = true;
                    dateTimePicker4.Visible = true;
                    label5.Visible = true;
                    dateTimePicker5.Visible = true;
                    bReset.Visible = true;
                    labelText3.Visible = true;
                    oneParentButton.Visible = true;
                    twoParentsButton.Visible = true;
                    bCalculate.Visible = true;
                    break;
                default:
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideTextBeforeAgeInput();
        }

        public void bCalculate_Click(object sender, EventArgs e)
        {

            //Check if everything is filled in
            if (dateTimePicker1.Value.Year == DateTime.Now.Year)
            {
                MessageBox.Show("Please make sure you enter the correct age for your child");
            }
            else
            { 
                if (oneParentButton.Checked || twoParentsButton.Checked)
                {
                    Calculate();

                    labelParentalContribution.Visible = true;
                    labelParentalContributionAmount.Visible = true;
                }
                else
                    MessageBox.Show("Please enter your family situation");
            }
        }
        private void Calculate()
        {
            int underTen = 0;
            int aboveNine = 0;

            if (dateTimePicker1.Visible)
            {
                int Age1;
                Age1 = DateTime.Now.Year - dateTimePicker1.Value.Year;
                if (Age1 < 10)
                {
                    underTen += 1;
                }
                else if (Age1 > 9)
                {
                    aboveNine += 1;
                }
            }

            if (dateTimePicker2.Visible)
            {
                int Age2;
                Age2 = DateTime.Now.Year - dateTimePicker2.Value.Year;
                if (Age2 < 10)
                {
                    underTen += 1;
                }
                else if (Age2 > 9)
                {
                    aboveNine += 1;
                }
            }

            if (dateTimePicker3.Visible)
            {
                int Age3;
                Age3 = DateTime.Now.Year - dateTimePicker3.Value.Year;
                if (Age3 < 10)
                {
                    underTen += 1;
                }
                else if (Age3 > 9)
                {
                    aboveNine += 1;
                }
            }

            if (dateTimePicker4.Visible)
            {
                int Age4;
                Age4 = DateTime.Now.Year - dateTimePicker4.Value.Year;
                if (Age4 < 10)
                {
                    underTen += 1;
                }
                else if (Age4 > 9)
                {
                    aboveNine += 1;
                }
            }

            if (dateTimePicker5.Visible)
            {
                int Age5;
                Age5 = DateTime.Now.Year - dateTimePicker5.Value.Year;
                if (Age5 < 10)
                {
                    underTen += 1;
                }
                else if (Age5 > 9)
                {
                    aboveNine += 1;
                }
            }

            int underTenMoney = 0;
            int aboveNineMoney = 0;

            switch (underTen)
            {
                case 1:
                    underTenMoney = 25;
                    break;
                case 2:
                    underTenMoney = 50;
                    break;
                case 3:
                    underTenMoney = 75;
                    break;
                case 4:
                    underTenMoney = 75;
                    break;
                case 5:
                    underTenMoney = 75;
                    break;
                default:
                    break;
            }

            switch (aboveNine)
            {
                case 1:
                    aboveNineMoney = 37;
                    break;
                case 2:
                    aboveNineMoney = 74;
                    break;
                case 3:
                    aboveNineMoney = 74;
                    break;
                case 4:
                    aboveNineMoney = 74;
                    break;
                case 5:
                    aboveNineMoney = 74;
                    break;
                default:
                    break;
            }

            int totalMoney;
            totalMoney = underTenMoney + aboveNineMoney;

            if (totalMoney > 150)
                totalMoney = 150;
            /*
            fix hier dat er 25% van het totaal af gaat als eenoudergezin is
            if (oneParentButton.Checked)
            {
                totalMoney =- ((totalMoney/100)*25);
            }
            */
            labelParentalContributionAmount.Text = totalMoney.ToString();

        }
    }
}
