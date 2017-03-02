using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMQNewRelicPlugin
{
    class MSMQServiceMeteric
    {
        public const String incomingMessagesPerSecLabel = "Incoming-Messages-Per-Second";
        public const String incomingMultiCastSessionsLabel = "Incoming-Multi-CastSession";
        public const String ipSessionsLabel = "Ip-Session";
        public const String incomingMessagesCountLabel = "Incoming-Count";
        public const String outgoingMessagesCountLabel = "Outgoing-Message-Count";
        public const String outgoingHttpSessionsLabel = "Outgoing-Sessions";
        public const String outgoingMessagesPerSecLabel = "Outgoing-Message";
        public const String outgoingMulticastSessionsLabel = "Outgoing-Multicast-Session";
        public const String sessionsLabel = "Sessions";
        public const String totalBytesInAllQueuesLabel = "Total-Bytes-In-All-Queue";
        public const String totalMessagesInAllqueuesLabel = "Total-Messages-In-All-Queues";
        private long incomingMessagesPerSec;
        private long incomingMultiCastSessions;
        private long ipSessions;
        private long incomingMessagesCount;
        private long outgoingMessagesCount;
        private long outgoingHttpSessions;
        private long outgoingMessagesPerSec;
        private long outgoingMulticastSessions;
        private long sessions;
        private long totalBytesInAllQueues;
        private long totalMessagesInAllQueues;

        public long IncomingMessagesPerSec
        {
            get
            {
                return incomingMessagesPerSec;
            }

            set
            {
                incomingMessagesPerSec = value;
            }
        }

        public long IncomingMultiCastSessions
        {
            get
            {
                return incomingMultiCastSessions;
            }

            set
            {
                incomingMultiCastSessions = value;
            }
        }

        public long IpSessions
        {
            get
            {
                return ipSessions;
            }

            set
            {
                ipSessions = value;
            }
        }

        public long IncomingMessagesCount
        {
            get
            {
                return incomingMessagesCount;
            }

            set
            {
                incomingMessagesCount = value;
            }
        }

        public long OutgoingMessagesCount
        {
            get
            {
                return outgoingMessagesCount;
            }

            set
            {
                outgoingMessagesCount = value;
            }
        }

        public long OutgoingHttpSessions
        {
            get
            {
                return outgoingHttpSessions;
            }

            set
            {
                outgoingHttpSessions = value;
            }
        }

        public long OutgoingMessagesPerSec
        {
            get
            {
                return outgoingMessagesPerSec;
            }

            set
            {
                outgoingMessagesPerSec = value;
            }
        }

        public long OutgoingMulticastSessions
        {
            get
            {
                return outgoingMulticastSessions;
            }

            set
            {
                outgoingMulticastSessions = value;
            }
        }

        public long Sessions
        {
            get
            {
                return sessions;
            }

            set
            {
                sessions = value;
            }
        }

        public long TotalBytesInAllQueues
        {
            get
            {
                return totalBytesInAllQueues;
            }

            set
            {
                totalBytesInAllQueues = value;
            }
        }

        public long TotalMessagesInAllQueues
        {
            get
            {
                return totalMessagesInAllQueues;
            }

            set
            {
                totalMessagesInAllQueues = value;
            }
        }
    }
}
