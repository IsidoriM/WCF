﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingServiceHost
{
    class Program
    {
        static void Main()
        {
            HelloRemotingService.HelloRemotingService remotingService =
               new HelloRemotingService.HelloRemotingService();

            TcpChannel channel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(channel);

            RemotingConfiguration.RegisterWellKnownServiceType(
               typeof(HelloRemotingService.HelloRemotingService), "GetMessage",
               WellKnownObjectMode.Singleton);

            Console.WriteLine("Host started @ " + DateTime.Now.ToString());
            Console.ReadLine();
        }
    }
}
