using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            /// TODO - Place method calls here

            PrintSignature();
            RectangleArea();
            AddNumber();
            FindArea();
            NumberCheck();

        }

        /// 1. Print a signature to the screen

        public void PrintSignature()
        {
            q1Output.Text = "Your's truly, \n\nGrace Hopper.";
        }

        /// 2. Create a method to calculate the area of a rectangle with
        /// dimensions 5x7, and then use the variables to display: 5 * 7(times)
        /// 
        /// The area of a 5 x 7 rectangle is 35 units squared

        public void RectangleArea()
        {
            int width = 5;
            int height = 7;
            int area = (width - height);

            area = width * height;

            q2Output.Text = $"the area of a {width} x {height} is {area} units squared ";
        }

        /// 3. Create a method to get numbers from q3Num1Input and q3Num2Input,
        /// add them together, and then display output as follows:
        /// 
        /// 5 + 4 = 9 
        /// 

        public void AddNumber()
        {
            int num1 = Convert.ToInt16(q3Num1Input.Text);
            int num2 = Convert.ToInt16(q3Num2Input.Text);

           

            int sum = num1 + num2;
          



            q3Output.Text = $"{num1} = {num2} = {sum}";

        }
            


        
        /// 4. Create a method to calculate the area of a circle based on  
        /// the radius entered in radiusInput, then display output as follows:
        /// 
        /// The area of a circle with radius of 4 is 50.24 units squared
        /// 

        public void FindArea()
        {
            int num1 = Convert.ToUInt16(radiusInput.Text);
            double pie = 3.14;
            double area = pie;

            int square = num1 * num1;           

            q4Output.Text = $"the area of the cirlce with radius of {num1} is {area} units squared";




        }



        /// 5. 3U Only - Create a method that will determine and display
        /// the maximum of 3 values entered into q5Num1Input, q5Num2Input,
        /// and q5Num3Input. Sample input and output is shown below:
        /// 
        /// Inputs: 5, 7, 2
        /// he largest value is 7


        public void NumberCheck()
        {
            int num1 = Convert.ToInt16(q5Num1Input.Text);
            int num2 = Convert.ToInt32(q5Num2Input.Text);
            int num3 = Convert.ToInt32(q5Num3Input.Text);

            int checkNum1 = num2 - num1;
            int checkNum2 = num3 - num2;
            int checkNum3 = num1 - num3;

            if (checkNum3 > 0)
            {
                q5Output.Text = $"the biggest number is {num1}";
            }
            if(checkNum1 > 0)
            {
                q5Output.Text = $"thebiggest number is {num2}";
            }
            if(checkNum2 > 0)
            {
                q5Output.Text = $"the bigget number is {num3}"
            }
            
            
            

            
           

            


        }
    }
}
