using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coding_Dictionary
{
    public partial class CodingDesignSelect : Form
    {
        public CodingDesignSelect()
        {
            InitializeComponent();
        }

        private void button1StructuredData_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button1StructuredData.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button1UnstructedData_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button1UnstructedData.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button2Databases_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button2Databases.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button3DatabaseQueries_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button3DatabaseQueries.Text);
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
