// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryPushStatByAppResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AppPushStats")]
        [Validation(Required=false)]
        public QueryPushStatByAppResponseBodyAppPushStats AppPushStats { get; set; }
        public class QueryPushStatByAppResponseBodyAppPushStats : TeaModel {
            [NameInMap("AppPushStat")]
            [Validation(Required=false)]
            public List<QueryPushStatByAppResponseBodyAppPushStatsAppPushStat> AppPushStat { get; set; }
            public class QueryPushStatByAppResponseBodyAppPushStatsAppPushStat : TeaModel {
                public string Time { get; set; }
                public long? DeletedCount { get; set; }
                public long? OpenedCount { get; set; }
                public long? SmsReceiveSuccessCount { get; set; }
                public long? SmsSkipCount { get; set; }
                public long? SmsReceiveFailedCount { get; set; }
                public long? SmsFailedCount { get; set; }
                public long? ReceivedCount { get; set; }
                public long? SentCount { get; set; }
                public long? SmsSentCount { get; set; }
                public long? AcceptCount { get; set; }
            }
        };

    }

}
