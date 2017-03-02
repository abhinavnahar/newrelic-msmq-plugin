using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewRelic.Platform.Sdk;

namespace MSMQNewRelicPlugin
{
    class MSMQConnectSession
    {
        private CimSession session;

        public MSMQConnectSession(CimSession session)
        {
            this.session = session;
        }

        public List<MSMQMeteric> getMSMQMetric()
        {
            var msqmServiceData = session.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_PerfRawdata_MSMQ_MSMQQueue");
            List<MSMQMeteric> meteric = new List<MSMQMeteric>();

            foreach (CimInstance md in msqmServiceData)
            {
                MSMQMeteric msmqMetric = new MSMQMeteric();
                msmqMetric.BytesInJournalQueue = (long.Parse(md.CimInstanceProperties["BytesinJournalQueue"].Value.ToString()));
                msmqMetric.BytesInQueue = (long.Parse(md.CimInstanceProperties["BytesinJournalQueue"].Value.ToString()));
                msmqMetric.MessagesInJournalQueue = (long.Parse(md.CimInstanceProperties["BytesinJournalQueue"].Value.ToString()));
                msmqMetric.MessagesInQueue = (long.Parse(md.CimInstanceProperties["BytesinJournalQueue"].Value.ToString()));
                String name = md.CimInstanceProperties["Name"].Value.ToString();
                int lastIndex = name.LastIndexOf("\\");
                name = name.Substring(lastIndex + 1);
                msmqMetric.Name = name.Replace("\"", "");
                //"os:slc-nsd-tst-01\\private$\\shopping.templates.timeouts
                meteric.Add(msmqMetric);
            }

            return meteric;
        }


        public MSMQServiceMeteric getMSMQServiceMetric()
        {

            var msqmServiceData = session.QueryInstances(@"root\cimv2", "WQL", "SELECT * FROM Win32_PerfRawdata_MSMQ_MSMQService");
            MSMQServiceMeteric msmqServiceMetric = new MSMQServiceMeteric();

            foreach (CimInstance md in msqmServiceData)
            {
                msmqServiceMetric.IncomingMultiCastSessions = (long.Parse(md.CimInstanceProperties["IncomingMulticastSessions"].Value.ToString()));
                msmqServiceMetric.IncomingMessagesPerSec = (long.Parse(md.CimInstanceProperties["IncomingMessagesPersec"].Value.ToString()));
                msmqServiceMetric.IpSessions = (long.Parse(md.CimInstanceProperties["IPSessions"].Value.ToString()));
                msmqServiceMetric.IncomingMessagesCount = (long.Parse(md.CimInstanceProperties["MSMQIncomingMessages"].Value.ToString()));
                msmqServiceMetric.OutgoingMessagesCount = (long.Parse(md.CimInstanceProperties["MSMQOutgoingMessages"].Value.ToString()));
                msmqServiceMetric.OutgoingHttpSessions = (long.Parse(md.CimInstanceProperties["OutgoingHTTPSessions"].Value.ToString()));
                msmqServiceMetric.OutgoingMessagesPerSec = (long.Parse(md.CimInstanceProperties["OutgoingMessagesPersec"].Value.ToString()));
                msmqServiceMetric.OutgoingMulticastSessions = (long.Parse(md.CimInstanceProperties["OutgoingMulticastSessions"].Value.ToString()));
                msmqServiceMetric.Sessions = (long.Parse(md.CimInstanceProperties["Sessions"].Value.ToString()));
                msmqServiceMetric.TotalBytesInAllQueues = (long.Parse(md.CimInstanceProperties["Totalbytesinallqueues"].Value.ToString()));
                msmqServiceMetric.TotalMessagesInAllQueues = (long.Parse(md.CimInstanceProperties["Totalmessagesinallqueues"].Value.ToString()));
            }

            return msmqServiceMetric;
        }
    }
}
