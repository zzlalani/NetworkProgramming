using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

using System.Threading;
using System.IO;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {

            TcpListener l = new TcpListener(IPAddress.Loopback,8000);
            l.Start();

            while (true) {
                TcpClient c = l.AcceptTcpClient();
                Thread t = new Thread(new ParameterizedThreadStart(receive));
                t.Start(c);
            }


        }

        static void receive(object obj)
        {
            TcpClient c = (TcpClient)obj;
            NetworkStream ns = c.GetStream();
            StreamReader sr = new StreamReader(ns);
            while (true) {
                Console.WriteLine(sr.ReadLine());
            }
        }

    }
}
