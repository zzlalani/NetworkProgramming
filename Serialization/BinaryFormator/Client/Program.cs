using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

using ClassObject;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Loopback, 1000);
            TcpClient client = new TcpClient();
            client.Connect(endpoint);

            Class1 c1 = new Class1();
            c1.Type = "Extra";
            c1.Version = "1.0.0.1";

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(client.GetStream(), c1);

            Console.ReadLine();

        }
    }
}
