using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listen = new TcpListener(IPAddress.Parse("127.0.0.1"),1000);
            listen.Start();

            TcpClient client = listen.AcceptTcpClient();

            NetworkStream ns = client.GetStream();

            byte[] bytes = new byte[100];
            int bytesRead = ns.Read(bytes, 0, 100);

            string msg = Encoding.ASCII.GetString(bytes);

            Console.WriteLine(msg);
            Console.ReadLine();
        }
    }
}
