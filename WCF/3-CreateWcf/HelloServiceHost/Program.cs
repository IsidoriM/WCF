﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloServiceHost
{
    class Program
    {
        static void Main()
        {
            using (System.ServiceModel.ServiceHost host = new
                System.ServiceModel.ServiceHost(typeof(HelloService.HelloService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
