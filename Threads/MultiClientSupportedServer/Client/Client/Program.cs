using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            TcpClient c = new TcpClient();
            c.Connect(new IPEndPoint(IPAddress.Loopback, 8000));

            NetworkStream ns = c.GetStream();

            StreamWriter sw = new StreamWriter(ns);
            while(true) {
                sw.WriteLine(Console.ReadLine());
                sw.Flush();
            }
        }
    }
}
