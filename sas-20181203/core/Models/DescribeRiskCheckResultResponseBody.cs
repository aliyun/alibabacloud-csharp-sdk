// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskCheckResultResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeRiskCheckResultResponseBodyList> List { get; set; }
        public class DescribeRiskCheckResultResponseBodyList : TeaModel {
            [NameInMap("AffectedCount")]
            [Validation(Required=false)]
            public int? AffectedCount { get; set; }

            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public long? CheckTime { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("RemainingTime")]
            [Validation(Required=false)]
            public int? RemainingTime { get; set; }

            [NameInMap("RepairStatus")]
            [Validation(Required=false)]
            public string RepairStatus { get; set; }

            [NameInMap("RiskAssertType")]
            [Validation(Required=false)]
            public string RiskAssertType { get; set; }

            [NameInMap("RiskItemResources")]
            [Validation(Required=false)]
            public List<DescribeRiskCheckResultResponseBodyListRiskItemResources> RiskItemResources { get; set; }
            public class DescribeRiskCheckResultResponseBodyListRiskItemResources : TeaModel {
                [NameInMap("ContentResource")]
                [Validation(Required=false)]
                public Dictionary<string, object> ContentResource { get; set; }

                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

            }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("Sort")]
            [Validation(Required=false)]
            public int? Sort { get; set; }

            [NameInMap("StartStatus")]
            [Validation(Required=false)]
            public string StartStatus { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
