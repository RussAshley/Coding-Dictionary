using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

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
            pictureDefinition.Image = Image.FromFile(definitionDatabase.Image1);
           // Image image1 = Image.FromFile("c:\\FakePhoto1.jpg");
            linkLabelURL.Text = definitionDatabase.URL1;
        }

        public DisplayDefinition(DefinitionDatabase searchedTerm)
        {
            InitializeComponent();
            
            

            label1DefinitionTitle.Text = searchedTerm.Term1;
            textBoxDefinitionDisplay.Text = searchedTerm.Definition1;
            pictureDefinition.Image = Image.FromFile(searchedTerm.Image1);
            
            linkLabelURL.Text = searchedTerm.URL1;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
        }

        private void linkLabelURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception )
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabelURL.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            var processes = Process.GetProcessesByName("Chrome");
            var path = processes.FirstOrDefault()?.MainModule?.FileName;
            Process.Start(path, linkLabelURL.Text);
            
        }

        private void button1Modify_Click(object sender, EventArgs e)
        {
            definitionDatabase.Definition1 = textBoxDefinitionDisplay.Text;
            da.ModifyTerm(definitionDatabase);



        }
    }
}
