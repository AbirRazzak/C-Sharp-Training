/*
 * Author: Abir Razzak
 * Date: 9/11/2017
 * Overview: This is a winform application designed to emulate a calculator
 * only operating programmatically via addition.
 * 
 * This program is a solution to DailyProgrammer #331 (see bottom for info)
 */



using System;
using System.Windows.Forms;

namespace TheAddingCalculator
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private int _firstnum;
        private int _secondnum;
        private String operation;
        private int result;

        private void Form1_Load(object sender, EventArgs e)
        {
            operation = "";
        }

        private void numberClick(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Clear();
            if(operation == "reset")
            {
                display.Clear();
                operation = "";
            }
            Button b = (Button)sender;
            display.Text += b.Text;
        }

        private void operationClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //Capture operation clicked
            operation = b.Text;
            //Set first int to display
            _firstnum = int.Parse(display.Text);
            //Reset the display
            display.Text = "0";
        }

        private void clearClick(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        //Operation algorithms
        private int add(int a, int b)
        {
            return a + b;
        }
        private int subtract(int a, int b)
        {
            return a + -b;
        }
        private int multiply(int a, int b)
        {
            int c = 0;

            for(int i=0; i<b; i++)
            {
                c = add(c, a);
            }

            return c;
        }
        private int divide(int a, int b)
        {
            int c = 0;
            int d = subtract(a, b);

            while(d >= 0)
            {
                c++;
                d = subtract(d, b);
            }

            //Error catch
            /*Logic: if d does not equal negative b after the while loop,
            then the integers did not divide evenly. This will also
            catch an error if the while loop is never entered as well.
            */
            if (d != (-b))
                return -1; //we use -1 as an error catch return.

            return c;
        }
        private int power(int a, int b)
        {
            int c = 1;
            for (int i = b; i > 0; i --)
            {
                c = multiply(c, a);
            }

            return c;
        }

        private void equalsClick(object sender, EventArgs e)
        {
            switch(operation)
            {
                case(""):
                    {
                        break;
                    }
                case("+"):
                    {
                        _secondnum = int.Parse(display.Text);
                        result = add(_firstnum, _secondnum);
                        display.Text = result.ToString();
                        break;
                    }
                case ("-"):
                    {
                        _secondnum = int.Parse(display.Text);
                        result = subtract(_firstnum, _secondnum);
                        display.Text = result.ToString();
                        break;
                    }
                case ("*"):
                    {
                        _secondnum = int.Parse(display.Text);
                        result = multiply(_firstnum, _secondnum);
                        display.Text = result.ToString();
                        break;
                    }
                case ("/"):
                    {
                        _secondnum = int.Parse(display.Text);
                        if(_secondnum == 0)
                        {
                            display.Text = "Not-defined";
                            break;
                        }
                        result = divide(_firstnum, _secondnum);
                        if (result == -1)
                            display.Text = "Non-integral answer";
                        else
                            display.Text = result.ToString();
                        break;
                    }
                case ("^"):
                    {
                        _secondnum = int.Parse(display.Text);
                        result = power(_firstnum, _secondnum);
                        display.Text = result.ToString();
                        break;
                    }
            }

            operation = "reset";
        }

    }
}

/*
 * This application is a solution to DailyProgrammer Challenge #331
 * The prompt can be found here: https://www.reddit.com/r/dailyprogrammer/comments/6ze9z0/20170911_challenge_331_easy_the_adding_calculator/
 * 
 * r/DailyProgrammer is a community (aka. 'Subreddit') on Reddit.com that
 * posts daily challenges for programmers. I am in no way sponsored or work
 * for r/DailyProgammer. All code seen above is original code written by Abir Razzak.
 * This code is open-source and free to use to anyone interested. Any modifications
 * and outside implementation of this program will not be under my responsibility.
 * 
 * Any suggestions and bug reports are appreicated!
 * Contact me at: amr439@drexel.edu
 */
