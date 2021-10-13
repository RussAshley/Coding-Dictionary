using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coding_Dictionary
{
    public partial class ImplementationSelect : Form
    {
        public ImplementationSelect()
        {
            InitializeComponent();
        }

        private void button1Iterations_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button1Iterations.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button2Sequence_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button2Sequence.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button3Selection_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button3Selection.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button4Data_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button4Data.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button8Classes_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button8Classes.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button6Objects_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button6Objects.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button7Fields_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button7Fields.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button5Methods_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button5Methods.Text);
            displayDefinition.Show();
            this.Hide();
        }

        private void button9Properties_Click(object sender, EventArgs e)
        {
            DisplayDefinition displayDefinition = new DisplayDefinition(button9Properties.Text);
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
