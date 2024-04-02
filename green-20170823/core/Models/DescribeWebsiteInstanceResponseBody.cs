// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeWebsiteInstanceResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("WebsiteInstanceList")]
        [Validation(Required=false)]
        public List<DescribeWebsiteInstanceResponseBodyWebsiteInstanceList> WebsiteInstanceList { get; set; }
        public class DescribeWebsiteInstanceResponseBodyWebsiteInstanceList : TeaModel {
            [NameInMap("BuyTime")]
            [Validation(Required=false)]
            public string BuyTime { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("IndexPage")]
            [Validation(Required=false)]
            public string IndexPage { get; set; }

            [NameInMap("IndexPageScanInterval")]
            [Validation(Required=false)]
            public int? IndexPageScanInterval { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("WebsiteScanInterval")]
            [Validation(Required=false)]
            public int? WebsiteScanInterval { get; set; }

        }

    }

}
