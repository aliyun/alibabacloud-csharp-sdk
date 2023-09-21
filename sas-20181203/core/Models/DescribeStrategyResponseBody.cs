// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the baseline check policies.
        /// </summary>
        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public List<DescribeStrategyResponseBodyStrategies> Strategies { get; set; }
        public class DescribeStrategyResponseBodyStrategies : TeaModel {
            /// <summary>
            /// The details of the assets to which the baseline check policy is applied.
            /// </summary>
            [NameInMap("ConfigTargets")]
            [Validation(Required=false)]
            public List<DescribeStrategyResponseBodyStrategiesConfigTargets> ConfigTargets { get; set; }
            public class DescribeStrategyResponseBodyStrategiesConfigTargets : TeaModel {
                /// <summary>
                /// Indicates whether the baseline check policy is applied to the asset group. Valid values:
                /// 
                /// *   **add**: The baseline check policy is applied to the asset group.
                /// *   **del**: the baseline check policy is not applied to the asset group.
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public string Flag { get; set; }

                /// <summary>
                /// The asset group ID or UUID of the asset to which the baseline check policy is applied.
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// The condition by which the baseline check policy is applied to the asset. Valid values:
                /// 
                /// *   **groupId**: the ID of the asset group
                /// *   **uuid**: the UUID of the asset
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// The type of the baseline check policy. Valid values:
            /// 
            /// *   **common**
            /// *   **custom**
            /// </summary>
            [NameInMap("CustomType")]
            [Validation(Required=false)]
            public string CustomType { get; set; }

            /// <summary>
            /// The cycle of the baseline check. Valid values:
            /// 
            /// *   **1**: every 2 days
            /// *   **3**: every 4 days
            /// *   **7**: every 8 days
            /// *   30: every 31 days
            /// </summary>
            [NameInMap("CycleDays")]
            [Validation(Required=false)]
            public int? CycleDays { get; set; }

            /// <summary>
            /// The time when the baseline check starts. Valid values:
            /// 
            /// *   **0**: The baseline check starts within the time range from 00:00 to 06:00.
            /// *   **6**: The baseline check starts within the time range from 06:00 to 12:00.
            /// *   **12**: The baseline check starts within the time range from 12:00 to 18:00.
            /// *   **18**: The baseline check starts within the time range from 18:00 to 24:00.
            /// </summary>
            [NameInMap("CycleStartTime")]
            [Validation(Required=false)]
            public int? CycleStartTime { get; set; }

            /// <summary>
            /// The number of the assets to which the baseline check policy is applied.
            /// </summary>
            [NameInMap("EcsCount")]
            [Validation(Required=false)]
            public int? EcsCount { get; set; }

            /// <summary>
            /// The end time of the baseline check policy.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The status of the baseline check policy. Valid values:
            /// 
            /// *   **1**: not executed
            /// *   **2**: executing
            /// </summary>
            [NameInMap("ExecStatus")]
            [Validation(Required=false)]
            public int? ExecStatus { get; set; }

            /// <summary>
            /// The ID of the baseline check policy.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The name of the baseline check policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The proportion of risky baselines in the baseline check result.
            /// </summary>
            [NameInMap("PassRate")]
            [Validation(Required=false)]
            public int? PassRate { get; set; }

            /// <summary>
            /// The number of the assets on which the baseline check is complete.
            /// </summary>
            [NameInMap("ProcessRate")]
            [Validation(Required=false)]
            public int? ProcessRate { get; set; }

            /// <summary>
            /// The number of baseline check items in the baseline check policy.
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public int? RiskCount { get; set; }

            /// <summary>
            /// The start time of the baseline check policy.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The source type of the baseline check policy. Valid values:
            /// 
            /// *   **1**: indicates a built-in policy provided and performed by Security Center by default.
            /// *   **2**: indicates a user-defined policy. It can be a standard or custom baseline check policy.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
