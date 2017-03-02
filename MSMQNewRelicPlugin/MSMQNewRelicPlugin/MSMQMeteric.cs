using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMQNewRelicPlugin
{
    class MSMQMeteric
    {
        public const String bytesInJournalQueueLabel = "Bytes-In-Journal-Queue";
        public const String bytesInQueueLabel = "Bytes-In-Queue";
        public const String messagesInJournalQueueLabel = "Messages-In-Journal-Queue";
        public const String messagesInQueueLabel = "Messages-In-Queue";

        private String name;
        private long bytesInJournalQueue;
        private long bytesInQueue;
        private long messagesInJournalQueue;
        private long messagesInQueue;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public long BytesInJournalQueue
        {
            get
            {
                return bytesInJournalQueue;
            }

            set
            {
                bytesInJournalQueue = value;
            }
        }

        public long BytesInQueue
        {
            get
            {
                return bytesInQueue;
            }

            set
            {
                bytesInQueue = value;
            }
        }

        public long MessagesInJournalQueue
        {
            get
            {
                return messagesInJournalQueue;
            }

            set
            {
                messagesInJournalQueue = value;
            }
        }

        public long MessagesInQueue
        {
            get
            {
                return messagesInQueue;
            }

            set
            {
                messagesInQueue = value;
            }
        }
    }
}
