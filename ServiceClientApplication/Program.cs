using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceClientApplication.ServiceReference1;

namespace ServiceClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MainServiceClient client = new MainServiceClient())
            {
                string answer = client.HelloMethod("Andrew");
                Console.WriteLine(answer);
                Console.ReadKey();
            }        
        }
    }
}
