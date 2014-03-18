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
        public String Type;
        public String Version;
        public int System;

        public override string ToString()
        {
            //return base.ToString();


            string s = "Type: " + Type + Environment.NewLine;
            s += "Version: " + Version + Environment.NewLine;
            s += "System: " + System.ToString();

            return s;
        }

    }
}
