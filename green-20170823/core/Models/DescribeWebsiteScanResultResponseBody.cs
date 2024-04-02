// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeWebsiteScanResultResponseBody : TeaModel {
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

        [NameInMap("WebsiteScanResultList")]
        [Validation(Required=false)]
        public List<DescribeWebsiteScanResultResponseBodyWebsiteScanResultList> WebsiteScanResultList { get; set; }
        public class DescribeWebsiteScanResultResponseBodyWebsiteScanResultList : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("HandleStatus")]
            [Validation(Required=false)]
            public int? HandleStatus { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("ImageRiskCount")]
            [Validation(Required=false)]
            public int? ImageRiskCount { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            [NameInMap("ScanTime")]
            [Validation(Required=false)]
            public string ScanTime { get; set; }

            [NameInMap("SourceRiskCount")]
            [Validation(Required=false)]
            public int? SourceRiskCount { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TextRiskCount")]
            [Validation(Required=false)]
            public int? TextRiskCount { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
