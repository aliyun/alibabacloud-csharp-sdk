// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaUtilizationReportResponseBody : Darabonba.Model {
        /// <summary>
        /// <b>Example:</b>
        /// <para>RAM.PERMISSION.DENIED</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>You are not authorized to do this action or the API input parameter is invalid.</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-10-26T06:24:57Z</para>
        /// </summary>
        [NameInMap("GeneratedAt")]
        [Validation(Required=false)]
        public string GeneratedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Quota utilization data is available.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjEwLCJvdHNOZXh0VG9rZW4iOiJDQUVTR3dvWkNoY0tFM1J2ZEdGc1gzVnpZV2RsWDNCbGNtTmxiblFRQVJnQkl1RUJDZ2tCQUFBQUFBQUFXVUFLMHdFRHpnQUFBREZUTXpFek9ETXdNemN6TnpNNE16VXpPVE0xTXpjek5qTXpNekV6TlRNNE16Z3VVek01TXpjek5UTTJOalkyTWpZeE16Y3laRFl5TmpJek16WXhNbVF6TkRNMk16RXpOREprTmpFek9UTTRNemN5WkRZMk16WTJORE16TXpVMk16TXhNemt6TURZMk16RXpNUzVUTmpFMk16YzBOamsyWmpabE56UTNNall4TmprMll5NVRNelkyTWpZMU16a3pPRE0yTmpRek1qSmtNekV6TlRNeU5qRXlaRE0wTXpFek1UWTJNbVEyTWpZME16TXpNVEprTXpNMk16WXlOalV6TkRNMU16VXpNalkwTXpVek1qTTMiLCJ0YXNrSWQiOiI5NzU2ZmJhNy1iYjNhLTQ2MTQtYTk4Ny1mNmQzNWMxOTBmMTEiLCJ1aWQiOiIxODA3Nzg1OTU3NjMxNTg4IiwidXRpbGl6YXRpb25TdGF0dXNlcyI6IiJ9</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListQuotaUtilizationReportResponseBodyQuotas> Quotas { get; set; }
        public class ListQuotaUtilizationReportResponseBodyQuotas : Darabonba.Model {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Adjustable")]
            [Validation(Required=false)]
            public bool? Adjustable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Consumable")]
            [Validation(Required=false)]
            public bool? Consumable { get; set; }

            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Dimensions { get; set; }

            [NameInMap("FlowControlAlgo")]
            [Validation(Required=false)]
            public ListQuotaUtilizationReportResponseBodyQuotasFlowControlAlgo FlowControlAlgo { get; set; }
            public class ListQuotaUtilizationReportResponseBodyQuotasFlowControlAlgo : Darabonba.Model {
                /// <summary>
                /// <b>Example:</b>
                /// <para>FixedWindow</para>
                /// </summary>
                [NameInMap("AlgoType")]
                [Validation(Required=false)]
                public string AlgoType { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public ListQuotaUtilizationReportResponseBodyQuotasFlowControlAlgoPeriod Period { get; set; }
                public class ListQuotaUtilizationReportResponseBodyQuotasFlowControlAlgoPeriod : Darabonba.Model {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>second</para>
                    /// </summary>
                    [NameInMap("PeriodUnit")]
                    [Validation(Required=false)]
                    public string PeriodUnit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PeriodValue")]
                    [Validation(Required=false)]
                    public int? PeriodValue { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RefillInterval")]
                [Validation(Required=false)]
                public int? RefillInterval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TokensPerRefill")]
                [Validation(Required=false)]
                public int? TokensPerRefill { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalQuota")]
                [Validation(Required=false)]
                public double? TotalQuota { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>q_security-groups</para>
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:quotas:cn-hangzhou:120886317861****:quota/ecs/q_security-groups</para>
            /// </summary>
            [NameInMap("QuotaArn")]
            [Validation(Required=false)]
            public string QuotaArn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CommonQuota</para>
            /// </summary>
            [NameInMap("QuotaCategory")]
            [Validation(Required=false)]
            public string QuotaCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The maximum number of security groups that can be owned by the current account.</para>
            /// </summary>
            [NameInMap("QuotaDescription")]
            [Validation(Required=false)]
            public string QuotaDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs.g5.2xlarge</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public double? TotalQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1009</para>
            /// </summary>
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public double? TotalUsage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>applicationProcess</para>
            /// </summary>
            [NameInMap("UnadjustableDetail")]
            [Validation(Required=false)]
            public string UnadjustableDetail { get; set; }

            [NameInMap("UsageMetric")]
            [Validation(Required=false)]
            public ListQuotaUtilizationReportResponseBodyQuotasUsageMetric UsageMetric { get; set; }
            public class ListQuotaUtilizationReportResponseBodyQuotasUsageMetric : Darabonba.Model {
                [NameInMap("MetricDimensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> MetricDimensions { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Usage</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acs_quotas_flowcontrol</para>
                /// </summary>
                [NameInMap("MetricNamespace")]
                [Validation(Required=false)]
                public string MetricNamespace { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.1</para>
            /// </summary>
            [NameInMap("Utilization")]
            [Validation(Required=false)]
            public double? Utilization { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WARN</para>
            /// </summary>
            [NameInMap("UtilizationStatus")]
            [Validation(Required=false)]
            public string UtilizationStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7ED584FB-ECBF-4A2A-969D-F54D25EFABF9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

