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

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listner = new TcpListener(new IPEndPoint(IPAddress.Loopback, 8000));
            listner.Start();

            TcpClient client = listner.AcceptTcpClient();

            BinaryFormatter bf = new BinaryFormatter();
            object obj = bf.Deserialize(client.GetStream());

            Class1 cls = (Class1)obj;
            Console.WriteLine(cls.ToString());

            Console.ReadLine();


        }
    }
}
