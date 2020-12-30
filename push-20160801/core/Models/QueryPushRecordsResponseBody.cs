// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryPushRecordsResponseBody : TeaModel {
        [NameInMap("PushInfos")]
        [Validation(Required=false)]
        public QueryPushRecordsResponseBodyPushInfos PushInfos { get; set; }
        public class QueryPushRecordsResponseBodyPushInfos : TeaModel {
            [NameInMap("PushInfo")]
            [Validation(Required=false)]
            public List<QueryPushRecordsResponseBodyPushInfosPushInfo> PushInfo { get; set; }
            public class QueryPushRecordsResponseBodyPushInfosPushInfo : TeaModel {
                public string Status { get; set; }
                public string MessageId { get; set; }
                public long? AppKey { get; set; }
                public string DeviceType { get; set; }
                public string PushType { get; set; }
                public string Body { get; set; }
                public string Title { get; set; }
                public string Source { get; set; }
                public string PushTime { get; set; }
                public string Target { get; set; }
            }
        };

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

    }

}
