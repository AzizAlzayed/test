using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickOncePublishExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Application clickonce publish version: {GetVersion()}");
            Console.ReadLine();
        }

        private static object GetVersion()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }

            return "Not published.";
        }
    }
}
