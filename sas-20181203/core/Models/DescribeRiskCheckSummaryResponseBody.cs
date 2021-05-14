// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskCheckSummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskCheckSummary")]
        [Validation(Required=false)]
        public DescribeRiskCheckSummaryResponseBodyRiskCheckSummary RiskCheckSummary { get; set; }
        public class DescribeRiskCheckSummaryResponseBodyRiskCheckSummary : TeaModel {
            [NameInMap("ItemCount")]
            [Validation(Required=false)]
            public int? ItemCount { get; set; }
            [NameInMap("AffectedAssetCount")]
            [Validation(Required=false)]
            public int? AffectedAssetCount { get; set; }
            [NameInMap("DisabledRiskCount")]
            [Validation(Required=false)]
            public int? DisabledRiskCount { get; set; }
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public int? RiskCount { get; set; }
            [NameInMap("RiskRate")]
            [Validation(Required=false)]
            public float? RiskRate { get; set; }
            [NameInMap("PreviousCount")]
            [Validation(Required=false)]
            public int? PreviousCount { get; set; }
            [NameInMap("PreviousTime")]
            [Validation(Required=false)]
            public long? PreviousTime { get; set; }
            [NameInMap("EnabledRiskCount")]
            [Validation(Required=false)]
            public int? EnabledRiskCount { get; set; }
            [NameInMap("RiskLevelCount")]
            [Validation(Required=false)]
            public List<DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryRiskLevelCount> RiskLevelCount { get; set; }
            public class DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryRiskLevelCount : TeaModel {
                public string Key { get; set; }
                public int? Count { get; set; }
            }
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryGroups> Groups { get; set; }
            public class DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryGroups : TeaModel {
                public int? RemainingTime { get; set; }
                public string Status { get; set; }
                public int? Sort { get; set; }
                public string Title { get; set; }
                public long? Id { get; set; }
                public List<DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryGroupsCountByStatus> CountByStatus { get; set; }
                public class DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryGroupsCountByStatus : TeaModel {
                    public string Status { get; set; }
                    public int? Count { get; set; }
                }
            }
        };

    }

}
