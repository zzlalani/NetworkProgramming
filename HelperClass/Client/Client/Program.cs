﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            TcpClient client = new TcpClient();
            client.Connect(IPAddress.Loopback,1000);

            NetworkStream ns = client.GetStream();

            byte[] sendBytes = Encoding.ASCII.GetBytes("This is a Test");
            ns.Write(sendBytes, 0, sendBytes.Length);
            
            ns.Flush();
            Console.ReadLine();


        }
    }
}
