using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    [Serializable]
    public class Class1
    {
        private string _type;
        private string _version;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }

        public override string ToString()
        {
            string s = "Class: ClassObject" + Environment.NewLine;
            s += "Type: " + Type + Environment.NewLine;
            s += "Version: " + Version + Environment.NewLine;
            return s;
            
        }

    }
}
