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
                /// <summary>
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("AcceptCount")]
                [Validation(Required=false)]
                public long? AcceptCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("DeletedCount")]
                [Validation(Required=false)]
                public long? DeletedCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>510427</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("OpenedCount")]
                [Validation(Required=false)]
                public long? OpenedCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("ReceivedCount")]
                [Validation(Required=false)]
                public long? ReceivedCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SentCount")]
                [Validation(Required=false)]
                public long? SentCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SmsFailedCount")]
                [Validation(Required=false)]
                public long? SmsFailedCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SmsReceiveFailedCount")]
                [Validation(Required=false)]
                public long? SmsReceiveFailedCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SmsReceiveSuccessCount")]
                [Validation(Required=false)]
                public long? SmsReceiveSuccessCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SmsSentCount")]
                [Validation(Required=false)]
                public long? SmsSentCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SmsSkipCount")]
                [Validation(Required=false)]
                public long? SmsSkipCount { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF195C34-98FB-491A-98D7-19CBC1FA880B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
