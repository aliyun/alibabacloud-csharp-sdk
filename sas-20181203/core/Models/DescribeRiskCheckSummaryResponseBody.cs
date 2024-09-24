// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskCheckSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>291B49F9-1685-4005-9D34-606B6F78740F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The summary information about the check results of cloud service configurations.</para>
        /// </summary>
        [NameInMap("RiskCheckSummary")]
        [Validation(Required=false)]
        public DescribeRiskCheckSummaryResponseBodyRiskCheckSummary RiskCheckSummary { get; set; }
        public class DescribeRiskCheckSummaryResponseBodyRiskCheckSummary : TeaModel {
            /// <summary>
            /// <para>The number of affected assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AffectedAssetCount")]
            [Validation(Required=false)]
            public int? AffectedAssetCount { get; set; }

            /// <summary>
            /// <para>The number of the check items that failed the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DisabledRiskCount")]
            [Validation(Required=false)]
            public int? DisabledRiskCount { get; set; }

            /// <summary>
            /// <para>The number of the check items that passed the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("EnabledRiskCount")]
            [Validation(Required=false)]
            public int? EnabledRiskCount { get; set; }

            /// <summary>
            /// <para>An array that consists of the statistics for each type of check item.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryGroups> Groups { get; set; }
            public class DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryGroups : TeaModel {
                /// <summary>
                /// <para>An array that consists of the statistics about check results.</para>
                /// </summary>
                [NameInMap("CountByStatus")]
                [Validation(Required=false)]
                public List<DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryGroupsCountByStatus> CountByStatus { get; set; }
                public class DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryGroupsCountByStatus : TeaModel {
                    /// <summary>
                    /// <para>The number of detected risk items.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>The status of the check item after the check is finished. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>pass</b>: The check item passed the check, which indicates that the check item is normal.</description></item>
                    /// <item><description><b>failed</b>: The check item failed the check, which indicates that risks are detected based on the check item.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pass</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The ID of the check item type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The remaining time before the check is complete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainingTime")]
                [Validation(Required=false)]
                public int? RemainingTime { get; set; }

                /// <summary>
                /// <para>The sequence number of the check item type in the <b>All Types</b> drop-down list in the Security Center console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sort")]
                [Validation(Required=false)]
                public int? Sort { get; set; }

                /// <summary>
                /// <para>The status of the check. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>finish</b>: The check is finished.</description></item>
                /// <item><description><b>running</b>: The check is in progress.</description></item>
                /// <item><description><b>waiting</b>: The check is pending.</description></item>
                /// <item><description><b>notStart</b>: The check is not started.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>finish</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The name of the check item type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Identity authentication and permissions</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The number of check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ItemCount")]
            [Validation(Required=false)]
            public int? ItemCount { get; set; }

            /// <summary>
            /// <para>The number of risk items detected in the last check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PreviousCount")]
            [Validation(Required=false)]
            public int? PreviousCount { get; set; }

            /// <summary>
            /// <para>The timestamp of the last check. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1545012926000</para>
            /// </summary>
            [NameInMap("PreviousTime")]
            [Validation(Required=false)]
            public long? PreviousTime { get; set; }

            /// <summary>
            /// <para>The number of detected risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public int? RiskCount { get; set; }

            /// <summary>
            /// <para>An array that consists of the number of check items at each risk level.</para>
            /// </summary>
            [NameInMap("RiskLevelCount")]
            [Validation(Required=false)]
            public List<DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryRiskLevelCount> RiskLevelCount { get; set; }
            public class DescribeRiskCheckSummaryResponseBodyRiskCheckSummaryRiskLevelCount : TeaModel {
                /// <summary>
                /// <para>The number of check items at the specified risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The risk level of the check items. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>high</b></description></item>
                /// <item><description><b>medium</b></description></item>
                /// <item><description><b>low</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>medium</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>The proportion of risk items to all check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("RiskRate")]
            [Validation(Required=false)]
            public float? RiskRate { get; set; }

        }

    }

}
