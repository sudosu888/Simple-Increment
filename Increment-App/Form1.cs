/* See LICENSE file for license and copyright details */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Increment_App
{
    public partial class IncrementForm : Form
    {
        public IncrementForm()
        {
            InitializeComponent();
        }

        /*
         * This is where the numbers are stored! 😊
         */
        int value = 0;
        int goal = 0;

        /*
         * When the box is changed, check the parse, if it fails
         * change the NumDisplay color to black. If it's successfull,
         * convert the GoalBox into an integer then compute accordingly.
         * 
         * -- This turns into what would normally cause an error into a feature! --
         * 
         */
        private void GoalBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(GoalBox.Text, out goal))
            {
                goal = Convert.ToInt32(GoalBox.Text);
            }

            else
            {
                NumDisplay.ForeColor = Color.Black;
            }
        }
        
        /* 
         * Increment code, the Add button adds to the Value integer,
         * while the Subtract button subtracts from the Value integer.
         */
        private void button_Add_Click(object sender, EventArgs e)
        {
            value++;
            NumDisplay.Text = Convert.ToString(value);
        }

        private void button_Subtract_Click(object sender, EventArgs e)
        {
            value--;
            NumDisplay.Text = Convert.ToString(value);
        }

        /*
         * This one is basically the rest of the functionality for the
         * 'goal' feature.. If the correct conditions are met the NumDisplay
         * forecolor will change depending on the appropriate conditions.
         */
        public void NumDisplay_TextChanged(object sender, EventArgs e)
        {
            if (value == goal && goal >= 1)
            {
                NumDisplay.ForeColor = Color.Green;
            }

            else if (value > goal && goal >= 1)
            {
                NumDisplay.ForeColor = Color.Red;
            }

            else if (value < goal || goal == 0)
            {
                NumDisplay.ForeColor = Color.Black;
            }
        }

        /*
         * The Reset button, it's pretty self-explanatory
         */
        private void Button_Reset_Click(object sender, EventArgs e)
        {
            const string confirm = "Are you sure you want to reset?";
            const string caption = "Reset";

            var result = MessageBox.Show(confirm, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                value = 0;
                goal = 0;
                NumDisplay.Text = "0";
                GoalBox.Text = "";
            }
        }
    }
}