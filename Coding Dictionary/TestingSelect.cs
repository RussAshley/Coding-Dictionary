using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coding_Dictionary
{
    public partial class TestingSelect : Form
    {
        public TestingSelect()
        {
            InitializeComponent();
        }

        private void TestingSelect_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button1.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button3.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button2.Text);
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
