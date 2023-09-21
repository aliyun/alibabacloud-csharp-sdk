// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotAttackerSourceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListHoneypotAttackerSourceResponseBodyList> List { get; set; }
        public class ListHoneypotAttackerSourceResponseBodyList : TeaModel {
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public int? EventCount { get; set; }

            [NameInMap("LastTargetHoneypot")]
            [Validation(Required=false)]
            public string LastTargetHoneypot { get; set; }

            [NameInMap("LastTargetIp")]
            [Validation(Required=false)]
            public string LastTargetIp { get; set; }

            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotAttackerSourceResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotAttackerSourceResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
