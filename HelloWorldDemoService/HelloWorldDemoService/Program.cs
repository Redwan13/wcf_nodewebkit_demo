using System;
using System.ServiceModel.Web;

namespace HelloWorldDemoService
{
    class Program
    {
        private const string ServiceUri = "http://localhost:9000/";

        static void Main(string[] args)
        {
            WebServiceHost wh = new WebServiceHost(typeof(HelloWorldService),new Uri(ServiceUri));
            wh.Open();
            Console.WriteLine("Service opened on {0}", ServiceUri);
            Console.WriteLine("Press any key to stop service...");
            Console.ReadKey();
            wh.Close();
        }
    }
}
