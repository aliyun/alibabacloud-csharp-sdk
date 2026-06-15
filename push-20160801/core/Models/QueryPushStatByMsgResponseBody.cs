// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryPushStatByMsgResponseBody : TeaModel {
        [NameInMap("PushStats")]
        [Validation(Required=false)]
        public QueryPushStatByMsgResponseBodyPushStats PushStats { get; set; }
        public class QueryPushStatByMsgResponseBodyPushStats : TeaModel {
            [NameInMap("PushStat")]
            [Validation(Required=false)]
            public List<QueryPushStatByMsgResponseBodyPushStatsPushStat> PushStat { get; set; }
            public class QueryPushStatByMsgResponseBodyPushStatsPushStat : TeaModel {
                [NameInMap("AcceptCount")]
                [Validation(Required=false)]
                public long? AcceptCount { get; set; }

                [NameInMap("DeletedCount")]
                [Validation(Required=false)]
                public long? DeletedCount { get; set; }

                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                [NameInMap("OpenedCount")]
                [Validation(Required=false)]
                public long? OpenedCount { get; set; }

                [NameInMap("ReceivedCount")]
                [Validation(Required=false)]
                public long? ReceivedCount { get; set; }

                [NameInMap("SentCount")]
                [Validation(Required=false)]
                public long? SentCount { get; set; }

                [NameInMap("SmsFailedCount")]
                [Validation(Required=false)]
                public long? SmsFailedCount { get; set; }

                [NameInMap("SmsReceiveFailedCount")]
                [Validation(Required=false)]
                public long? SmsReceiveFailedCount { get; set; }

                [NameInMap("SmsReceiveSuccessCount")]
                [Validation(Required=false)]
                public long? SmsReceiveSuccessCount { get; set; }

                [NameInMap("SmsSentCount")]
                [Validation(Required=false)]
                public long? SmsSentCount { get; set; }

                [NameInMap("SmsSkipCount")]
                [Validation(Required=false)]
                public long? SmsSkipCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF195C34-98FB-491A-98D7-19CBC1FA880B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
