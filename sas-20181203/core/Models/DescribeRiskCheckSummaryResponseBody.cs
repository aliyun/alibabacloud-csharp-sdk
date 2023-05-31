// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskCheckSummaryResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The summary information about the check results of cloud service configurations.
        /// </summary>
        [NameInMap("RiskCheckSummary")]
        [Validation(Required=false)]
        public DescribeRiskCheckSummaryResponseBodyRiskCheckSummary RiskCheckSummary { get; set; }
        public class DescribeRiskCheckSummaryResponseBodyRiskCheckSummary : TeaModel {
            /// <summary>
            /// The number of affected assets.
            /// </summary>
            [NameInMap("AffectedAssetCount")]
            [Validation(Required=false)]
            public int? AffectedAssetCount { get; set; }

            /// <summary>
            /// The number of the check items that failed the check.
            /// </summary>
            [NameInMap("DisabledRiskCount")]
            [Validation(Required=false)]
            public int? DisabledRiskCount { get; set; }

            /// <summary>
            /// The number of the check items that passed the check.
            /// </summary>
            [NameInMap("EnabledRiskCount")]
            [Validation(Required=false)]
            public int? EnabledRiskCount { get; set; }

            /// <summary>
            /// An array that consists of the statistics for each type of check item.
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryGroups> Groups { get; set; }
            public class DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryGroups : TeaModel {
                /// <summary>
                /// An array that consists of the statistics about check results.
                /// </summary>
                [NameInMap("CountByStatus")]
                [Validation(Required=false)]
                public List<DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryGroupsCountByStatus> CountByStatus { get; set; }
                public class DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryGroupsCountByStatus : TeaModel {
                    /// <summary>
                    /// The number of detected risk items.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// The status of the check item after the check is finished. Valid values:
                    /// 
                    /// *   **pass**: The check item passed the check, which indicates that the check item is normal.
                    /// *   **failed**: The check item failed the check, which indicates that risks are detected based on the check item.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The ID of the check item type.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The remaining time before the check is complete.
                /// </summary>
                [NameInMap("RemainingTime")]
                [Validation(Required=false)]
                public int? RemainingTime { get; set; }

                /// <summary>
                /// The sequence number of the check item type in the **All Types** drop-down list in the Security Center console.
                /// </summary>
                [NameInMap("Sort")]
                [Validation(Required=false)]
                public int? Sort { get; set; }

                /// <summary>
                /// The status of the check. Valid values:
                /// 
                /// *   **finish**: The check is finished.
                /// *   **running**: The check is in progress.
                /// *   **waiting**: The check is pending.
                /// *   **notStart**: The check is not started.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The name of the check item type.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// The number of check items.
            /// </summary>
            [NameInMap("ItemCount")]
            [Validation(Required=false)]
            public int? ItemCount { get; set; }

            /// <summary>
            /// The number of risk items detected in the last check.
            /// </summary>
            [NameInMap("PreviousCount")]
            [Validation(Required=false)]
            public int? PreviousCount { get; set; }

            /// <summary>
            /// The timestamp of the last check. Unit: milliseconds.
            /// </summary>
            [NameInMap("PreviousTime")]
            [Validation(Required=false)]
            public long? PreviousTime { get; set; }

            /// <summary>
            /// The number of detected risk items.
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public int? RiskCount { get; set; }

            /// <summary>
            /// An array that consists of the number of check items at each risk level.
            /// </summary>
            [NameInMap("RiskLevelCount")]
            [Validation(Required=false)]
            public List<DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryRiskLevelCount> RiskLevelCount { get; set; }
            public class DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryRiskLevelCount : TeaModel {
                /// <summary>
                /// The number of check items at the specified risk level.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The risk level of the check items. Valid values:
                /// 
                /// *   **high**
                /// *   **medium**
                /// *   **low**
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// The proportion of risk items to all check items.
            /// </summary>
            [NameInMap("RiskRate")]
            [Validation(Required=false)]
            public float? RiskRate { get; set; }

        }

    }

}
