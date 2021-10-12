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
            codingRequirementsSelect.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           CodingDesignSelect codingDesignSelect= new CodingDesignSelect();
            codingDesignSelect.Show();
        }

        private void button3ImplementationSeelect_Click(object sender, EventArgs e)
        {
            ImplementationSelect implementationSelect = new ImplementationSelect();
            implementationSelect.Show();
        }

        private void button4TestingSelect_Click(object sender, EventArgs e)
        {
            TestingSelect testingSelect = new TestingSelect();
             testingSelect.Show();
        }

        private void button5ManagementSeelect_Click(object sender, EventArgs e)
        {
            ManagementSelect managementSelect = new ManagementSelect();
            managementSelect.Show();
        }

        private void button6MiscSeelect_Click(object sender, EventArgs e)
        {
            MiscSelect miscSelect = new MiscSelect();
            miscSelect.Show();
        }
    }
}
