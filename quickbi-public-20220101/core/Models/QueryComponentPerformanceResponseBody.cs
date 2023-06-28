// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryComponentPerformanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryComponentPerformanceResponseBodyResult> Result { get; set; }
        public class QueryComponentPerformanceResponseBodyResult : TeaModel {
            [NameInMap("CacheCostTimeAvg")]
            [Validation(Required=false)]
            public double? CacheCostTimeAvg { get; set; }

            [NameInMap("CacheQueryCount")]
            [Validation(Required=false)]
            public int? CacheQueryCount { get; set; }

            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            [NameInMap("CostTimeAvg")]
            [Validation(Required=false)]
            public double? CostTimeAvg { get; set; }

            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public int? QueryCount { get; set; }

            [NameInMap("QueryCountAvg")]
            [Validation(Required=false)]
            public double? QueryCountAvg { get; set; }

            [NameInMap("QueryOverFivePercentNum")]
            [Validation(Required=false)]
            public double? QueryOverFivePercentNum { get; set; }

            [NameInMap("QueryOverFiveSecPercent")]
            [Validation(Required=false)]
            public string QueryOverFiveSecPercent { get; set; }

            [NameInMap("QueryOverTenSecPercent")]
            [Validation(Required=false)]
            public string QueryOverTenSecPercent { get; set; }

            [NameInMap("QueryOverTenSecPercentNum")]
            [Validation(Required=false)]
            public double? QueryOverTenSecPercentNum { get; set; }

            [NameInMap("QueryTimeoutCount")]
            [Validation(Required=false)]
            public int? QueryTimeoutCount { get; set; }

            [NameInMap("QueryTimeoutCountPercent")]
            [Validation(Required=false)]
            public double? QueryTimeoutCountPercent { get; set; }

            [NameInMap("QuickIndexCostTimeAvg")]
            [Validation(Required=false)]
            public double? QuickIndexCostTimeAvg { get; set; }

            [NameInMap("QuickIndexQueryCount")]
            [Validation(Required=false)]
            public int? QuickIndexQueryCount { get; set; }

            [NameInMap("RepeatQueryPercent")]
            [Validation(Required=false)]
            public string RepeatQueryPercent { get; set; }

            [NameInMap("RepeatQueryPercentNum")]
            [Validation(Required=false)]
            public double? RepeatQueryPercentNum { get; set; }

            [NameInMap("RepeatSqlQueryCount")]
            [Validation(Required=false)]
            public int? RepeatSqlQueryCount { get; set; }

            [NameInMap("RepeatSqlQueryPercent")]
            [Validation(Required=false)]
            public string RepeatSqlQueryPercent { get; set; }

            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            [NameInMap("ReportName")]
            [Validation(Required=false)]
            public string ReportName { get; set; }

            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public string ReportType { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
