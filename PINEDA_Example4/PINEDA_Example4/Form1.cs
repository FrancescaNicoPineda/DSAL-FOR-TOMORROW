using Microsoft.VisualBasic.ApplicationServices;
using PINEDA_EXAMPLE4.Properties;
using System.Reflection.Metadata;

namespace PINEDA_EXAMPLE4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCyan;
            foodBRdbtn.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C: \Users\Francesca\source\repos\PINEDA_EXAMPLE4\PINEDA_EXAMPLE4\Resources\FOOD BUNDLE A.jpg");
            A_ChickenCheckBox.Checked = true;
            A_FriesCheckBox.Enabled = true;
            A_CokeCheckBox.Enabled = true;
            A_SideDishesCheckBox.Enabled = true;
            A_ChickenPoppersCheckBox.Enabled = true;
            B_CurryRicecheckbox.Checked = false;
            B_SteamedBuncheckbox.Checked = false;
            B_IcedTeacheckbox.Checked = false;
            B_Pastacheckbox.Checked = false;
            B_VanilaCakecheckbox.Checked = false;
            pricetxtbox.Text = "P1,000.00";
            discounttxtbox.Text = "(20% of the Price) P200.00";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            foodARdbtn.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Francesca\\source\\repos\\PINEDA_EXAMPLE4\\PINEDA_EXAMPLE4\\Resources\\FOOD BUNDLE B.png");
            A_ChickenCheckBox.Checked = false;
            A_FriesCheckBox.Enabled = false;
            A_CokeCheckBox.Enabled = false;
            A_SideDishesCheckBox.Enabled = false;
            A_ChickenPoppersCheckBox.Enabled = false;
            B_CurryRicecheckbox.Checked = true;
            B_SteamedBuncheckbox.Checked = true;
            B_IcedTeacheckbox.Checked = true;
            B_Pastacheckbox.Checked = true;
            B_VanilaCakecheckbox.Checked = true;
            pricetxtbox.Text = "P1,299.00";
            discounttxtbox.Text = "(15% of the Price) P194.85";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;
            DisplayPictureBox.Image = null;
            A_ChickenCheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_CokeCheckBox.Checked = false;
            A_SideDishesCheckBox.Checked = false;
            A_ChickenPoppersCheckBox.Checked = false;
            B_CurryRicecheckbox.Checked = false;
            B_SteamedBuncheckbox.Checked = false;
            B_IcedTeacheckbox.Checked = false;
            B_Pastacheckbox.Checked = false;
            B_VanilaCakecheckbox.Checked = false;
            pricetxtbox.Clear();
            discounttxtbox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
