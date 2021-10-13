using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coding_Dictionary
{
    public partial class ManagementSelect : Form
    {
        public ManagementSelect()
        {
            InitializeComponent();
        }

        private void button1DeploymentPlanning_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button1DeploymentPlanning.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button1Build_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button1Build.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button4.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
        }
    }
}
