using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class Class1
    {
        private string name;
        public string type;
        protected string version;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public override string ToString()
        {
            string s = "Class: Class1" + Environment.NewLine;
            s += "Name: " + Name + Environment.NewLine;
            s += "Type: " + Type + Environment.NewLine;
            s += "Version: " + Version + Environment.NewLine;
            return s;
        }

    }
}
