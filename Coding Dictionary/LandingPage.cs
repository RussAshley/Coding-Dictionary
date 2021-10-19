using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coding_Dictionary
{
    public partial class LandingPage : Form

        

    {

        
        public LandingPage()
        {
            InitializeComponent();
        }

        private void button1CodingRequirements_Click(object sender, EventArgs e)
        {
            CodingRequirementsSelect codingRequirementsSelect = new CodingRequirementsSelect();
            this.Hide();
            codingRequirementsSelect.Show();
            


        }
        private void button2_Click(object sender, EventArgs e)
        {
           CodingDesignSelect codingDesignSelect= new CodingDesignSelect();
            codingDesignSelect.Show();
            this.Hide();
        }

        private void button3ImplementationSeelect_Click(object sender, EventArgs e)
        {
            ImplementationSelect implementationSelect = new ImplementationSelect();
            implementationSelect.Show();
            this.Hide();
        }

        private void button4TestingSelect_Click(object sender, EventArgs e)
        {
            TestingSelect testingSelect = new TestingSelect();
             testingSelect.Show();
        
            this.Hide();
        }

        private void button5ManagementSeelect_Click(object sender, EventArgs e)
        {
            ManagementSelect managementSelect = new ManagementSelect();
            managementSelect.Show();
            this.Hide(); 
        }

        private void button6MiscSeelect_Click(object sender, EventArgs e)
        {
            MiscSelect miscSelect = new MiscSelect();
            miscSelect.Show();
            this.Hide();
        }

        private void button1Search_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
            this.Hide();
        }
    }
}
