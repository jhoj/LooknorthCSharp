using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WCFService)))
            {
                host.Open();
                Console.WriteLine("Server is open!");
                Console.WriteLine("Press any key to close the server.");
                Console.ReadLine();
            }
        }
    }
}
