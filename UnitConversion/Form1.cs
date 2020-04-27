using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConversion
{
    public partial class Form1 : Form
    {
        int option;
        int value;
        public Form1()
        {
            InitializeComponent();      
        }
      
        public void convertButton_Click(object sender, EventArgs e)
        {
            option = Convert.ToInt32(optionBox.Text);
            value = Convert.ToInt32(valueBox.Text);
            if (option == 1)
            {
                double final = InchesToCm(value);
                outputLabel.Text = value + " Inches  = " + final.ToString("0.00") + " Centimetres";
            }
            else if (option == 2)
            {
                double final = FeetToCm(value);
                outputLabel.Text = value + " Feet  = " + final.ToString("0.00") + " Centimetres";
            }
            else if (option == 3)
            {
                double final = YardsToMetres(value);
                outputLabel.Text = value + " Yards  = " + final.ToString("0.00") + " Metres";
            }
            else if (option == 4)
            {
                double final = MilesToKm(value);
                outputLabel.Text = value + " Miles  = " + final.ToString("0.00") + " Kilometres";
            }
        }
        /// <summary>
        /// converts inches to centimetres
        /// </summary>
        /// <param name="val">the value inputted to be converted</param>
        /// <returns>product of calculation</returns>
        public static double InchesToCm(int val)
        {
            double conversion = 0.00;
            conversion = val * 2.54;
            return conversion;

        }
        /// <summary>
        /// converts feet to centimetres
        /// </summary>
        /// <param name="val">the value inputted to be converted</param>
        /// <returns>product of calculation</returns>
        public static double FeetToCm(int val)
        {
            double conversion = 0.00;
            conversion = val * 30.48;
            return conversion;
        }
        /// <summary>
        /// converts yards to metres
        /// </summary>
        /// <param name="val">the value inputted to be converted</param>
        /// <returns>product of calculation</returns>
        public static double YardsToMetres(int val)
        {
            double conversion = 0.00;
            conversion = val * 0.91;
            return conversion;
        }
        /// <summary>
        /// converts miles to kilometeres
        /// </summary>
        /// <param name="val">the value inputted to be converted</param>
        /// <returns>product of calculation</returns>
        public static double MilesToKm(int val)
        {
            double conversion = 0.00;
            conversion = val * 1.6;
            return conversion;
        }

    }
}
