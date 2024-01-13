using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBlackJack
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
             form2 = new Form2();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            int age;
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            if (!chkAgree.Checked)
            {
                MessageBox.Show("You did not agree to the terms and conditions");
                return;
            }

            if (age < 18)
            {
                MessageBox.Show("You cannot play, you are underage");
                return;
            }

            string gender = radMale.Checked ? "He" : "She";
            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.AppendLine($"The current player playing is {txtFName.Text} {txtLName.Text}.");
            messageBuilder.AppendLine($"{gender} is {age} years of age.");
            messageBuilder.AppendLine($"{gender} has accepted the terms and conditions of play.");

            DialogResult result = MessageBox.Show(messageBuilder.ToString(), "Player Information", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                form2.PlayerName = $"{txtFName.Text}";
                form2.Show();
            }
        }

    }
}
