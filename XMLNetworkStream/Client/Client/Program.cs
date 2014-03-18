using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using ClassLibrary;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            TcpClient client = new TcpClient();
            client.Connect(new IPEndPoint(IPAddress.Loopback, 8000));

            Class1 cls = new Class1();
            cls.Type = "Abstract";
            cls.Version = "1.0.0.1";
            cls.System = 9;

            
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(client.GetStream(), cls);

            Console.ReadLine();


        }
    }
}
