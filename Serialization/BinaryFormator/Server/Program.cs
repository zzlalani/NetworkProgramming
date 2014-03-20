using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

using ClassObject;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Loopback, 1000);
            TcpListener listen = new TcpListener(endpoint);
            listen.Start();

            TcpClient client = listen.AcceptTcpClient();

            BinaryFormatter bf = new BinaryFormatter();
            object obj = bf.Deserialize(client.GetStream());

            Class1 c1 = (Class1)obj;
            Console.WriteLine(c1.ToString());

            Console.ReadLine();

        }
    }
}
