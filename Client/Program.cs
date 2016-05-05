using Interfaces;
using System;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int machineId = 1;
            Console.WriteLine("Sending data for machine {0}.", machineId);
            ChannelFactory<IWCFService> channelFactory 
                = new ChannelFactory<IWCFService>("LooknorthServiceEndpoint");
            IWCFService proxy = channelFactory.CreateChannel();
            proxy.SendMachineData(machineId);
            Console.ReadLine();
        }
    }
}
