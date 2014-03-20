using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient c = new TcpClient();
            c.Connect(new IPEndPoint(IPAddress.Loopback,8000));

            SoapFormatter sf = new SoapFormatter();
            object obj = sf.Deserialize(c.GetStream());
            Class1 c1 = (Class1)obj;
            Console.WriteLine(c1.ToString());
            Console.ReadLine();
        }
    }
}
