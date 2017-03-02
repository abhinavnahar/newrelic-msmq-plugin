using NewRelic.Platform.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using System.Security;

namespace MSMQNewRelicPlugin
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Runner runner = new Runner();

                runner.Add(new MSMQAgentFactory());

                runner.SetupAndRun();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred, unable to continue.\n", e.Message);
             
            }
        
        }
    }
}
