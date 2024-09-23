namespace binary_digit_helper
{
    public partial class Form1 : Form
    {
        //make a feild to keep adding up the binary digits
        //as we check them
        //scoped the the form because its within the class
        //we call it a field
        int totalValue = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //this event  will fire when the check box is checked or unchecked

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            //CHeck the checked property
            //parsing true/false didnt work
            //int int1= int.Parse(chk1.Checked.ToString());
            //this will parse a boolean into our number
            int int1 = Convert.ToInt32(chk1.Checked);
            int int2 = Convert.ToInt32(chk2.Checked);
            int int4 = Convert.ToInt32(chk4.Checked);
            int int8 = Convert.ToInt32(chk8.Checked);
            int int16 = Convert.ToInt32(chk16.Checked);
            //show the number in the chk1 text property
            chk1.Text = int1.ToString();
            chk2.Text = int2.ToString();
            chk4.Text = int4.ToString();
            chk8.Text = int8.ToString();
            chk16.Text = int16.ToString();
            //Use math to calculate our total number
            int newOutput = (int1 * 1) + (int2 * 2) + (int4 * 4) + (int8 * 8) + (int16 * 16);
            //show it in totaldecvalue label
            lbldecvalue.Text = newOutput.ToString();

            //we do some math to figure out what number we add to our total
           //nt valueToAdd = int1 * 1;
            //actually add it to our total
            //talValue = totalValue + valueToAdd;
            //display the new total value
            //ldecvalue.Text = totalValue.ToString();
        }
        //this event is another we can access, it seems to work the same
        //will have distinct features
        private void chk1_CheckStateChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Check state changed");
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
          

        }
    }
}
