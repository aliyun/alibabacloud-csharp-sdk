// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryPushStatByAppResponseBody : TeaModel {
        [NameInMap("AppPushStats")]
        [Validation(Required=false)]
        public QueryPushStatByAppResponseBodyAppPushStats AppPushStats { get; set; }
        public class QueryPushStatByAppResponseBodyAppPushStats : TeaModel {
            [NameInMap("AppPushStat")]
            [Validation(Required=false)]
            public List<QueryPushStatByAppResponseBodyAppPushStatsAppPushStat> AppPushStat { get; set; }
            public class QueryPushStatByAppResponseBodyAppPushStatsAppPushStat : TeaModel {
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>2016-07-25T00:00:00Z</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9998B3CC-ED9E-4CB3-A8FB-DCC61296BFBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
