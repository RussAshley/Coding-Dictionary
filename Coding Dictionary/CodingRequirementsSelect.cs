using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coding_Dictionary
{
    public partial class CodingRequirementsSelect : Form
    {
        public CodingRequirementsSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button1Scrum.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button2Kanban_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button2Kanban.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button3.Text);
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
