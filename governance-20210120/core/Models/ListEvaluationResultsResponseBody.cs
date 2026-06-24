// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>Member account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>176618589410****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD57329E-131A-59F4-8746-E1CD8D7B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Evaluation results, including overall evaluation status and sub-item evaluation results.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public ListEvaluationResultsResponseBodyResults Results { get; set; }
        public class ListEvaluationResultsResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>Overall evaluation end time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-13T03:35:00Z</para>
            /// </summary>
            [NameInMap("EvaluationTime")]
            [Validation(Required=false)]
            public string EvaluationTime { get; set; }

            /// <summary>
            /// <para>Evaluation results.</para>
            /// </summary>
            [NameInMap("MetricResults")]
            [Validation(Required=false)]
            public List<ListEvaluationResultsResponseBodyResultsMetricResults> MetricResults { get; set; }
            public class ListEvaluationResultsResponseBodyResultsMetricResults : TeaModel {
                /// <summary>
                /// <para>Evaluation item account assessment summary.</para>
                /// </summary>
                [NameInMap("AccountSummary")]
                [Validation(Required=false)]
                public ListEvaluationResultsResponseBodyResultsMetricResultsAccountSummary AccountSummary { get; set; }
                public class ListEvaluationResultsResponseBodyResultsMetricResultsAccountSummary : TeaModel {
                    /// <summary>
                    /// <para>Number of non-compliant accounts.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NonCompliant")]
                    [Validation(Required=false)]
                    public int? NonCompliant { get; set; }

                }

                /// <summary>
                /// <para>List of available remediations.</para>
                /// </summary>
                [NameInMap("AvailableRemediation")]
                [Validation(Required=false)]
                public List<ListEvaluationResultsResponseBodyResultsMetricResultsAvailableRemediation> AvailableRemediation { get; set; }
                public class ListEvaluationResultsResponseBodyResultsMetricResultsAvailableRemediation : TeaModel {
                    /// <summary>
                    /// <para>Remediation template ID.</para>
                    /// </summary>
                    [NameInMap("RemediationTemplateId")]
                    [Validation(Required=false)]
                    public string RemediationTemplateId { get; set; }

                }

                /// <summary>
                /// <para>Error information.</para>
                /// <remarks>
                /// <para>This error information is returned when <c>Status</c> is <c>Failed</c>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ErrorInfo")]
                [Validation(Required=false)]
                public ListEvaluationResultsResponseBodyResultsMetricResultsErrorInfo ErrorInfo { get; set; }
                public class ListEvaluationResultsResponseBodyResultsMetricResultsErrorInfo : TeaModel {
                    /// <summary>
                    /// <para>Error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EcsInsightEnableFailed</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>Error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Unable to enable ECS Insight due to a server error.</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }

                /// <summary>
                /// <para>Individual evaluation item end time (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-12-13T03:34:02Z</para>
                /// </summary>
                [NameInMap("EvaluationTime")]
                [Validation(Required=false)]
                public string EvaluationTime { get; set; }

                /// <summary>
                /// <para>Evaluation item ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r7xdcu****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Potential score increase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2</para>
                /// </summary>
                [NameInMap("PotentialScoreIncrease")]
                [Validation(Required=false)]
                public double? PotentialScoreIncrease { get; set; }

                /// <summary>
                /// <para>Evaluation item resource assessment summary.</para>
                /// </summary>
                [NameInMap("ResourcesSummary")]
                [Validation(Required=false)]
                public ListEvaluationResultsResponseBodyResultsMetricResultsResourcesSummary ResourcesSummary { get; set; }
                public class ListEvaluationResultsResponseBodyResultsMetricResultsResourcesSummary : TeaModel {
                    /// <summary>
                    /// <para>Number of non-compliant resources.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("NonCompliant")]
                    [Validation(Required=false)]
                    public int? NonCompliant { get; set; }

                }

                /// <summary>
                /// <para>Evaluation item resource compliance rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.67</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public double? Result { get; set; }

                /// <summary>
                /// <para>Evaluation risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Error: High risk.</description></item>
                /// <item><description>Warning: Medium risk.</description></item>
                /// <item><description>None: No risk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Error</para>
                /// </summary>
                [NameInMap("Risk")]
                [Validation(Required=false)]
                public string Risk { get; set; }

                /// <summary>
                /// <para>Individual evaluation item status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Running: Evaluation in progress.</description></item>
                /// <item><description>Finished: Evaluation completed.</description></item>
                /// <item><description>Failed: Evaluation failed.</description></item>
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
            /// <para>Overall evaluation status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running: Evaluation in progress.</description></item>
            /// <item><description>Finished: Evaluation completed.</description></item>
            /// <item><description>Failed: Evaluation failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Overall score.</para>
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
