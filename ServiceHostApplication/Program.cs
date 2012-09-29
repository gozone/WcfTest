using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ServiceHostApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Uri address = new Uri("net.tcp://localhost:8001");
            ServiceHost host = new ServiceHost(typeof(MainServiceImplementation));

            
            host.Open();

            Console.WriteLine("Host opened");
            Console.ReadKey();

            host.Close();
            
        }
    }
}
