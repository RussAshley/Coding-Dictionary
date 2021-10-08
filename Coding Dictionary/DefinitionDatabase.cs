using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Dictionary
{
    class DefinitionDatabase
    {
        private int ID;
        private string Term;
         private string Definition;
        private string Image;
        private string URL;

        public DefinitionDatabase(int iD, string term, string definition, string image, string uRL)
        {
            ID1 = iD;
            Term1 = term;
            Definition1 = definition;
            Image1 = image;
            URL1 = uRL;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Term1 { get => Term; set => Term = value; }
        public string Definition1 { get => Definition; set => Definition = value; }
        public string Image1 { get => Image; set => Image = value; }
        public string URL1 { get => URL; set => URL = value; }
    }
}
