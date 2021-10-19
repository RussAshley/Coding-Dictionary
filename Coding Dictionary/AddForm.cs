using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coding_Dictionary
{
    public partial class AddForm : Form
    {
        static DefinitionAcess da = new DefinitionAcess("Dictionary.db");
        public AddForm()
        {
            InitializeComponent();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            DefinitionDatabase newdefinitionDatabase = new DefinitionDatabase(0, "", "", "","");
            da.CreateTerm(newdefinitionDatabase);
            DisplayDefinition displayDefinition = new DisplayDefinition(newdefinitionDatabase);
            displayDefinition.Show();
            this.Hide();

        }
    }
}

