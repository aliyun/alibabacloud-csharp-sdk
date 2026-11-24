// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaUtilizationReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAM.PERMISSION.DENIED</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to do this action or the API input parameter is invalid.</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The data generation time or statistical date. For general quotas, the time is in UTC and formatted as yyyy-MM-dd\&quot;T\&quot;HH:mm:ss\&quot;Z\&quot;. For API rate quotas, the date is formatted as yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-26T06:24:57Z</para>
        /// </summary>
        [NameInMap("GeneratedAt")]
        [Validation(Required=false)]
        public string GeneratedAt { get; set; }

        /// <summary>
        /// <para>The supplementary description of the report status, such as report generation in progress, report generation needs to be started first, or a newer report is available for re-query. Applications should use Status to determine the status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quota utilization data is available.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token used to query the next page. An empty value indicates that no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjEwLCJvdHNOZXh0VG9rZW4iOiJDQUVTR3dvWkNoY0tFM1J2ZEdGc1gzVnpZV2RsWDNCbGNtTmxiblFRQVJnQkl1RUJDZ2tCQUFBQUFBQUFXVUFLMHdFRHpnQUFBREZUTXpFek9ETXdNemN6TnpNNE16VXpPVE0xTXpjek5qTXpNekV6TlRNNE16Z3VVek01TXpjek5UTTJOalkyTWpZeE16Y3laRFl5TmpJek16WXhNbVF6TkRNMk16RXpOREprTmpFek9UTTRNemN5WkRZMk16WTJORE16TXpVMk16TXhNemt6TURZMk16RXpNUzVUTmpFMk16YzBOamsyWmpabE56UTNNall4TmprMll5NVRNelkyTWpZMU16a3pPRE0yTmpRek1qSmtNekV6TlRNeU5qRXlaRE0wTXpFek1UWTJNbVEyTWpZME16TXpNVEprTXpNMk16WXlOalV6TkRNMU16VXpNalkwTXpVek1qTTMiLCJ0YXNrSWQiOiI5NzU2ZmJhNy1iYjNhLTQ2MTQtYTk4Ny1mNmQzNWMxOTBmMTEiLCJ1aWQiOiIxODA3Nzg1OTU3NjMxNTg4IiwidXRpbGl6YXRpb25TdGF0dXNlcyI6IiJ9</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of quota usage on the current page. An empty list is returned if no matching data exists or no general quota report is available.</para>
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListQuotaUtilizationReportResponseBodyQuotas> Quotas { get; set; }
        public class ListQuotaUtilizationReportResponseBodyQuotas : TeaModel {
            /// <summary>
            /// <para>Indicates whether the quota is adjustable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Adjustable")]
            [Validation(Required=false)]
            public bool? Adjustable { get; set; }

            /// <summary>
            /// <para>Indicates whether the used quota is displayed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Consumable")]
            [Validation(Required=false)]
            public bool? Consumable { get; set; }

            /// <summary>
            /// <para>The quota dimensions. Format: <c>{&quot;regionId&quot;:&quot;region ID&quot;}</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Dimensions { get; set; }

            /// <summary>
            /// <para>The traffic throttling algorithms.</para>
            /// </summary>
            [NameInMap("FlowControlAlgo")]
            [Validation(Required=false)]
            public ListQuotaUtilizationReportResponseBodyQuotasFlowControlAlgo FlowControlAlgo { get; set; }
            public class ListQuotaUtilizationReportResponseBodyQuotasFlowControlAlgo : TeaModel {
                /// <summary>
                /// <para>The type of the throttling algorithm. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>FixedWindow: Fixed window.</description></item>
                /// <item><description>TokenBucket: Token bucket.</description></item>
                /// <item><description>Concurrency: Concurrency limit.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FixedWindow</para>
                /// </summary>
                [NameInMap("AlgoType")]
                [Validation(Required=false)]
                public string AlgoType { get; set; }

                /// <summary>
                /// <para>The time period. This parameter is returned only for FixedWindow and is empty for other algorithms.</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public ListQuotaUtilizationReportResponseBodyQuotasFlowControlAlgoPeriod Period { get; set; }
                public class ListQuotaUtilizationReportResponseBodyQuotasFlowControlAlgoPeriod : TeaModel {
                    /// <summary>
                    /// <para>The unit of the quota calculation period. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>second: Seconds.</description></item>
                    /// <item><description>minute: Minutes.</description></item>
                    /// <item><description>hour: Hours.</description></item>
                    /// <item><description>day: Days.</description></item>
                    /// <item><description>week: Weeks.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>second</para>
                    /// </summary>
                    [NameInMap("PeriodUnit")]
                    [Validation(Required=false)]
                    public string PeriodUnit { get; set; }

                    /// <summary>
                    /// <para>The value of the quota calculation period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PeriodValue")]
                    [Validation(Required=false)]
                    public int? PeriodValue { get; set; }

                }

                /// <summary>
                /// <para>The time interval between two token refills. This parameter is returned only for TokenBucket and is empty for other algorithms. The time unit must be confirmed with the upstream service and is not declared in the current code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RefillInterval")]
                [Validation(Required=false)]
                public int? RefillInterval { get; set; }

                /// <summary>
                /// <para>The number of tokens added per refill. This parameter is returned only for TokenBucket and is empty for other algorithms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TokensPerRefill")]
                [Validation(Required=false)]
                public int? TokensPerRefill { get; set; }

                /// <summary>
                /// <para>The quota value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalQuota")]
                [Validation(Required=false)]
                public double? TotalQuota { get; set; }

            }

            /// <summary>
            /// <para>The abbreviation of the cloud service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The quota ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>q_security-groups</para>
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// <para>The quota ARN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:quotas:cn-hangzhou:120886317861****:quota/ecs/q_security-groups</para>
            /// </summary>
            [NameInMap("QuotaArn")]
            [Validation(Required=false)]
            public string QuotaArn { get; set; }

            /// <summary>
            /// <para>The quota type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CommonQuota</para>
            /// </summary>
            [NameInMap("QuotaCategory")]
            [Validation(Required=false)]
            public string QuotaCategory { get; set; }

            /// <summary>
            /// <para>The quota description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The maximum number of security groups that can be owned by the current account.</para>
            /// </summary>
            [NameInMap("QuotaDescription")]
            [Validation(Required=false)]
            public string QuotaDescription { get; set; }

            /// <summary>
            /// <para>The quota name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g5.2xlarge</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// <para>The quota value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public double? TotalQuota { get; set; }

            /// <summary>
            /// <para>The quota usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1009</para>
            /// </summary>
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public double? TotalUsage { get; set; }

            /// <summary>
            /// <para>The reason why the quota is not adjustable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>applicationProcess</para>
            /// </summary>
            [NameInMap("UnadjustableDetail")]
            [Validation(Required=false)]
            public string UnadjustableDetail { get; set; }

            /// <summary>
            /// <para>The monitoring information of the quota usage in CloudMonitor.</para>
            /// <remarks>
            /// <para>An empty value indicates that no monitoring data for this quota exists in CloudMonitor.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("UsageMetric")]
            [Validation(Required=false)]
            public ListQuotaUtilizationReportResponseBodyQuotasUsageMetric UsageMetric { get; set; }
            public class ListQuotaUtilizationReportResponseBodyQuotasUsageMetric : TeaModel {
                /// <summary>
                /// <para>The CloudMonitor monitoring dimensions.</para>
                /// <para>Format: a collection of key:value pairs. Example:
                /// <c>{&quot;productCode&quot;:&quot;***&quot;,&quot;metricKey&quot;:&quot;***&quot;,&quot;regionId&quot;:&quot;***&quot;,&quot;label&quot;:&quot;***&quot;}</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
                /// </summary>
                [NameInMap("MetricDimensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> MetricDimensions { get; set; }

                /// <summary>
                /// <para>The <a href="https://cms.console.aliyun.com/metric-meta/acs_ecs_dashboard/ecs">monitored metric</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Usage</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The namespace of the CloudMonitor monitoring data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs_quotas_flowcontrol</para>
                /// </summary>
                [NameInMap("MetricNamespace")]
                [Validation(Required=false)]
                public string MetricNamespace { get; set; }

            }

            /// <summary>
            /// <para>The quota utilization rate, without the percentage sign.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.1</para>
            /// </summary>
            [NameInMap("Utilization")]
            [Validation(Required=false)]
            public double? Utilization { get; set; }

            /// <summary>
            /// <para>The risk level determined by the returned Utilization value. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: Less than 80%.</description></item>
            /// <item><description>WARN: Greater than or equal to 80% and less than 95%.</description></item>
            /// <item><description>CRITICAL: Greater than or equal to 95%.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WARN</para>
            /// </summary>
            [NameInMap("UtilizationStatus")]
            [Validation(Required=false)]
            public string UtilizationStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ED584FB-ECBF-4A2A-969D-F54D25EFABF9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the query result for the quota utilization report. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AVAILABLE: The data is available for query.</para>
        /// </description></item>
        /// <item><description><para>GENERATING: A new report is being generated. If an unexpired historical report exists, the most recent historical report is returned.</para>
        /// </description></item>
        /// <item><description><para>UNAVAILABLE: No general quota report is available. You must call StartQuotaUtilizationReport to start report generation first.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet all filter conditions in the current report, rather than the number of entries on the current page. The value is 0 if no matching entries exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
