using NewRelic.Platform.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMQNewRelicPlugin
{
    class MSMQAgent : Agent
    {
        public override string Guid { get { return "com.netradius.msmqplugin"; } }

        public override string Version { get { return "1.0.0"; } }

        private String host, domain, username, password, agentName;

        public MSMQAgent(String agentName, String host, String domain, String username, String password) {
            this.agentName = agentName;
            this.host = host;
            this.domain = domain;
            this.username = username;
            this.password = password;
        }

        public override string GetAgentName()
        {
            return this.agentName;
        }

        public override void PollCycle()
        {
            MSMQConnectSession connection = MSMQConnectionUtil.connect(this.host, this.domain, this.username, this.password);
            MSMQServiceMeteric serviceMetric = connection.getMSMQServiceMetric();
            List<MSMQMeteric> msmqMetric = connection.getMSMQMetric();
            Console.WriteLine("reporting meteric");
            ReportMetric("ALL/" + MSMQServiceMeteric.incomingMessagesPerSecLabel, "Messages Per Second", float.Parse(serviceMetric.IncomingMessagesPerSec.ToString()));
            ReportMetric("ALL/" + MSMQServiceMeteric.incomingMultiCastSessionsLabel, "Session", float.Parse(serviceMetric.IncomingMultiCastSessions.ToString()));
            ReportMetric("ALL/" + MSMQServiceMeteric.ipSessionsLabel, "Session", float.Parse(serviceMetric.IpSessions.ToString()));
            ReportMetric("ALL/" + MSMQServiceMeteric.incomingMessagesCountLabel, "Message", float.Parse(serviceMetric.IncomingMessagesCount.ToString()));
            ReportMetric("ALL/" + MSMQServiceMeteric.outgoingMessagesCountLabel, "Message", float.Parse(serviceMetric.OutgoingMessagesCount.ToString()));
            ReportMetric("ALL/" + MSMQServiceMeteric.outgoingHttpSessionsLabel, "Session", float.Parse(serviceMetric.OutgoingHttpSessions.ToString()));
            ReportMetric("ALL/" + MSMQServiceMeteric.outgoingMessagesPerSecLabel, "Messages Per Second", float.Parse(serviceMetric.OutgoingMessagesPerSec.ToString()));
            ReportMetric("ALL/" + MSMQServiceMeteric.outgoingMulticastSessionsLabel, "Session", float.Parse(serviceMetric.OutgoingMulticastSessions.ToString()));
            ReportMetric("ALL/" + MSMQServiceMeteric.sessionsLabel, "Session", float.Parse(serviceMetric.Sessions.ToString()));
            ReportMetric("ALL/" + MSMQServiceMeteric.totalBytesInAllQueuesLabel, "Bytes", float.Parse(serviceMetric.TotalBytesInAllQueues.ToString()));
            ReportMetric("ALL/" + MSMQServiceMeteric.totalMessagesInAllqueuesLabel, "Message", float.Parse(serviceMetric.TotalMessagesInAllQueues.ToString()));

            foreach (MSMQMeteric m in msmqMetric) {
                ReportMetric(m.Name + "/" + MSMQMeteric.bytesInJournalQueueLabel, "Bytes", float.Parse(m.BytesInJournalQueue.ToString()));
                ReportMetric(m.Name + "/" + MSMQMeteric.bytesInQueueLabel, "Bytes", float.Parse(m.BytesInQueue.ToString()));
                ReportMetric(m.Name + "/" + MSMQMeteric.messagesInJournalQueueLabel, "Message", float.Parse(m.MessagesInJournalQueue.ToString()));
                ReportMetric(m.Name + "/" + MSMQMeteric.messagesInQueueLabel, "Message", float.Parse(m.MessagesInQueue.ToString()));
            }
         }
    }
}
