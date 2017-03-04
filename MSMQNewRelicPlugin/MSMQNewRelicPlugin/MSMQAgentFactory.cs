using NewRelic.Platform.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMQNewRelicPlugin
{
    class MSMQAgentFactory : AgentFactory
    {
        public override Agent CreateAgentWithConfiguration(IDictionary<string, object> properties)
        {
            string name = (string)properties["name"];
            string host = (string)properties["host"];
            string domain = (string)properties["domain"];
            string username = (string)properties["username"];
            string password = (string)properties["password"];
         
            return new MSMQAgent(name, host, domain, username, password);
        }
    }
}
