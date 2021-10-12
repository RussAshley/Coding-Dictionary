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
            DisplayDefinition displayDefinition = new DisplayDefinition(Button1Scrum.Text);
            displayDefinition .Show();
        }
    }
}
