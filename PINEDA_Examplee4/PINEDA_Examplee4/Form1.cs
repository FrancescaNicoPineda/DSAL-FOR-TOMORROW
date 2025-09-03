using Microsoft.VisualBasic.ApplicationServices;
using PINEDA_Examplee4.Properties;
using System.Reflection.Metadata;

namespace PINEDA_Examplee4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bundleA_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            bundleB.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Francesca\\source\\repos\\PINEDA_Examplee4\\PINEDA_Examplee4\\Resources\\FOOD BUNDLE A.jpg");
            A_chickencheck.Checked = true;
            A_Fries.Checked = true;
            A_Milkis.Checked = true;
            A_Side.Checked = true;
            A_ChickenPoppers.Checked = true;
            B_Curry.Checked = false;
            B_Bun.Checked = false;
            B_Tea.Checked = false;
            B_Pasta.Checked = false;
            B_Cake.Checked = false;
            pricetxtbox.Text = "1299.00";
            discountxtbox.Text = "(15% of the Price) P194.85}";
        }

        private void bundleB_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            bundleA.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Francesca\\source\\repos\\PINEDA_Examplee4\\PINEDA_Examplee4\\Resources\\FOOD BUNDLE B.jpg");
            A_chickencheck.Checked = false;
            A_Fries.Checked = false;
            A_Milkis.Checked = false;
            A_Side.Checked = false;
            A_ChickenPoppers.Checked = false;
            B_Curry.Checked = true;
            B_Bun.Checked = true;
            B_Tea.Checked = true;
            B_Pasta.Checked = true;
            B_Cake.Checked = true;
            pricetxtbox.Text = "1000.00";
            discountxtbox.Text = "(15% of the Price) P200.00}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            bundleA.Checked = false;
            bundleB.Checked = false;
            DisplayPictureBox.Image = null;
            A_chickencheck.Checked = false;
            A_Fries.Checked = false;
            A_Milkis.Checked = false;
            A_Side.Checked = false;
            A_ChickenPoppers.Checked = false;
            B_Curry.Checked = false;
            B_Bun.Checked = false;
            B_Tea.Checked = false;
            B_Pasta.Checked = false;
            B_Cake.Checked = false;
            pricetxtbox.Clear();
            discountxtbox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}