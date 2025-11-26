// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>176618589410****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD57329E-131A-59F4-8746-E1CD8D7B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The check results, including the status of the overall check and the results of check items.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public ListEvaluationResultsResponseBodyResults Results { get; set; }
        public class ListEvaluationResultsResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The end time of the overall check. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-13T03:35:00Z</para>
            /// </summary>
            [NameInMap("EvaluationTime")]
            [Validation(Required=false)]
            public string EvaluationTime { get; set; }

            /// <summary>
            /// <para>The check result.</para>
            /// </summary>
            [NameInMap("MetricResults")]
            [Validation(Required=false)]
            public List<ListEvaluationResultsResponseBodyResultsMetricResults> MetricResults { get; set; }
            public class ListEvaluationResultsResponseBodyResultsMetricResults : TeaModel {
                [NameInMap("AccountSummary")]
                [Validation(Required=false)]
                public ListEvaluationResultsResponseBodyResultsMetricResultsAccountSummary AccountSummary { get; set; }
                public class ListEvaluationResultsResponseBodyResultsMetricResultsAccountSummary : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NonCompliant")]
                    [Validation(Required=false)]
                    public int? NonCompliant { get; set; }

                }

                [NameInMap("AvailableRemediation")]
                [Validation(Required=false)]
                public List<ListEvaluationResultsResponseBodyResultsMetricResultsAvailableRemediation> AvailableRemediation { get; set; }
                public class ListEvaluationResultsResponseBodyResultsMetricResultsAvailableRemediation : TeaModel {
                    [NameInMap("RemediationTemplateId")]
                    [Validation(Required=false)]
                    public string RemediationTemplateId { get; set; }

                }

                /// <summary>
                /// <para>The error information.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the value of <c>Status</c> is <c>Failed</c>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ErrorInfo")]
                [Validation(Required=false)]
                public ListEvaluationResultsResponseBodyResultsMetricResultsErrorInfo ErrorInfo { get; set; }
                public class ListEvaluationResultsResponseBodyResultsMetricResultsErrorInfo : TeaModel {
                    /// <summary>
                    /// <para>The error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EcsInsightEnableFailed</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Unable to enable ECS Insight due to a server error.</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }

                /// <summary>
                /// <para>The end time of the check item. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-12-13T03:34:02Z</para>
                /// </summary>
                [NameInMap("EvaluationTime")]
                [Validation(Required=false)]
                public string EvaluationTime { get; set; }

                /// <summary>
                /// <para>The ID of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r7xdcu****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("PotentialScoreIncrease")]
                [Validation(Required=false)]
                public double? PotentialScoreIncrease { get; set; }

                /// <summary>
                /// <para>The checked resources.</para>
                /// </summary>
                [NameInMap("ResourcesSummary")]
                [Validation(Required=false)]
                public ListEvaluationResultsResponseBodyResultsMetricResultsResourcesSummary ResourcesSummary { get; set; }
                public class ListEvaluationResultsResponseBodyResultsMetricResultsResourcesSummary : TeaModel {
                    /// <summary>
                    /// <para>The number of non-compliant resources.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("NonCompliant")]
                    [Validation(Required=false)]
                    public int? NonCompliant { get; set; }

                }

                /// <summary>
                /// <para>The rate of the non-compliant resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.67</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public double? Result { get; set; }

                /// <summary>
                /// <para>The risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Error: high risk</description></item>
                /// <item><description>Warning: medium risk</description></item>
                /// <item><description>None: no risk</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Error</para>
                /// </summary>
                [NameInMap("Risk")]
                [Validation(Required=false)]
                public string Risk { get; set; }

                /// <summary>
                /// <para>The status of the check item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Running: The check is in progress.</description></item>
                /// <item><description>Finished: The check is complete.</description></item>
                /// <item><description>failed: The check fails.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The status of the overall check. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running: The check is in progress.</description></item>
            /// <item><description>Finished: The check is complete.</description></item>
            /// <item><description>failed: The check fails.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The overall score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6453</para>
            /// </summary>
            [NameInMap("TotalScore")]
            [Validation(Required=false)]
            public double? TotalScore { get; set; }

        }

    }

}
