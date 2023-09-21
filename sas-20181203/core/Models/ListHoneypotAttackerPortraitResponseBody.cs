// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotAttackerPortraitResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListHoneypotAttackerPortraitResponseBodyList> List { get; set; }
        public class ListHoneypotAttackerPortraitResponseBodyList : TeaModel {
            [NameInMap("AttackCount")]
            [Validation(Required=false)]
            public int? AttackCount { get; set; }

            [NameInMap("Browser")]
            [Validation(Required=false)]
            public List<string> Browser { get; set; }

            [NameInMap("Host")]
            [Validation(Required=false)]
            public List<string> Host { get; set; }

            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            [NameInMap("Network")]
            [Validation(Required=false)]
            public ListHoneypotAttackerPortraitResponseBodyListNetwork Network { get; set; }
            public class ListHoneypotAttackerPortraitResponseBodyListNetwork : TeaModel {
                [NameInMap("ExternalIp")]
                [Validation(Required=false)]
                public List<string> ExternalIp { get; set; }

                [NameInMap("InternalIp")]
                [Validation(Required=false)]
                public List<string> InternalIp { get; set; }

                [NameInMap("RealIp")]
                [Validation(Required=false)]
                public List<string> RealIp { get; set; }

            }

            [NameInMap("PortraitId")]
            [Validation(Required=false)]
            public string PortraitId { get; set; }

            [NameInMap("Social")]
            [Validation(Required=false)]
            public List<string> Social { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotAttackerPortraitResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotAttackerPortraitResponseBodyPageInfo : TeaModel {
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
