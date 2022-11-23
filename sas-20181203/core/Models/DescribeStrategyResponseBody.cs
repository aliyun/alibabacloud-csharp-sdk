// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public List<DescribeStrategyResponseBodyStrategies> Strategies { get; set; }
        public class DescribeStrategyResponseBodyStrategies : TeaModel {
            [NameInMap("ConfigTargets")]
            [Validation(Required=false)]
            public List<DescribeStrategyResponseBodyStrategiesConfigTargets> ConfigTargets { get; set; }
            public class DescribeStrategyResponseBodyStrategiesConfigTargets : TeaModel {
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public string Flag { get; set; }

                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            [NameInMap("CustomType")]
            [Validation(Required=false)]
            public string CustomType { get; set; }

            [NameInMap("CycleDays")]
            [Validation(Required=false)]
            public int? CycleDays { get; set; }

            [NameInMap("CycleStartTime")]
            [Validation(Required=false)]
            public int? CycleStartTime { get; set; }

            [NameInMap("EcsCount")]
            [Validation(Required=false)]
            public int? EcsCount { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("ExecStatus")]
            [Validation(Required=false)]
            public int? ExecStatus { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PassRate")]
            [Validation(Required=false)]
            public int? PassRate { get; set; }

            [NameInMap("ProcessRate")]
            [Validation(Required=false)]
            public int? ProcessRate { get; set; }

            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public int? RiskCount { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
