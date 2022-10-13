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
                [NameInMap("AcceptCount")]
                [Validation(Required=false)]
                public long? AcceptCount { get; set; }

                [NameInMap("DeletedCount")]
                [Validation(Required=false)]
                public long? DeletedCount { get; set; }

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

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
