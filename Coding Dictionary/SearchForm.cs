using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coding_Dictionary
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        

       private void buttonSearch_Click(object sender, EventArgs e)
        {

            DefinitionAcess definitionAcess = new DefinitionAcess("Data Source= Dictionary.db");
            
            DefinitionDatabase searchResult = definitionAcess.ReadTermData(textBoxSearchdb.Text);

            if (searchResult.Term1 == textBoxSearchdb.Text)
            {
                DisplayDefinition displayDefinition = new DisplayDefinition(searchResult);
                displayDefinition.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("No result Found");
            }
                 




            // if Term in SearchForm = Term in database then display result in Display definition, else show "Term not found'
        }
   }
}
