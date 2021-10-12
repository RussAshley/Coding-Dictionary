using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coding_Dictionary
{

   
    public partial class DisplayDefinition : Form
    {
        static DefinitionAcess da = new DefinitionAcess("Data Source= Dictionary.db");
        DefinitionDatabase definitionDatabase;
       
        string termName;


        public DisplayDefinition(string termName)
        {
            InitializeComponent();
            this.termName = termName;
            definitionDatabase = da.ReadTermData(termName);

            label1DefinitionTitle.Text = definitionDatabase.Term1;
            textBoxDefinitionDisplay.Text = definitionDatabase.Definition1;
            richTextBoxImage.Text = definitionDatabase.Image1;
            linkLabelURL.Text = definitionDatabase.URL1;
        }
    }
}
