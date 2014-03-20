using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Soap;

using ClassLibrary;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener l = new TcpListener(new IPEndPoint(IPAddress.Loopback,8000));
            l.Start();

            TcpClient c = l.AcceptTcpClient();

            Class1 c1 = new Class1();
            c1.Name = "Opportunity";
            c1.Type = "Extra+";
            c1.Version = "1.0.0.2B";

            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(c.GetStream(),c1);

            Console.ReadLine();
        }
    }
}
