// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trusted_server20200613.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyItems> Items { get; set; }
        public class DescribeEventsResponseBodyItems : TeaModel {
            [NameInMap("Accumulation")]
            [Validation(Required=false)]
            public string Accumulation { get; set; }

            [NameInMap("EventAffiliation")]
            [Validation(Required=false)]
            public string EventAffiliation { get; set; }

            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            [NameInMap("EventStatus")]
            [Validation(Required=false)]
            public string EventStatus { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("EventUuid")]
            [Validation(Required=false)]
            public string EventUuid { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtHandle")]
            [Validation(Required=false)]
            public long? GmtHandle { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("HandleType")]
            [Validation(Required=false)]
            public string HandleType { get; set; }

            [NameInMap("PropertyName")]
            [Validation(Required=false)]
            public string PropertyName { get; set; }

            [NameInMap("PropertyPrivateIp")]
            [Validation(Required=false)]
            public string PropertyPrivateIp { get; set; }

            [NameInMap("PropertyPublicIp")]
            [Validation(Required=false)]
            public string PropertyPublicIp { get; set; }

            [NameInMap("PropertyUuid")]
            [Validation(Required=false)]
            public string PropertyUuid { get; set; }

            [NameInMap("Suspect")]
            [Validation(Required=false)]
            public string Suspect { get; set; }

            [NameInMap("SuspectSig")]
            [Validation(Required=false)]
            public string SuspectSig { get; set; }

            [NameInMap("SuspectWhiteList")]
            [Validation(Required=false)]
            public string SuspectWhiteList { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
