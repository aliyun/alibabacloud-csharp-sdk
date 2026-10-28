// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductQuotasResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The maximum number of records returned for the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Indicates whether a token for the next query is available.</para>
        /// <list type="bullet">
        /// <item><description>If NextToken is empty, it indicates that no subsequent query is available.</description></item>
        /// <item><description>If NextToken is returned, the value is the token used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The quota details.</para>
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListProductQuotasResponseBodyQuotas> Quotas { get; set; }
        public class ListProductQuotasResponseBodyQuotas : Darabonba.Model {
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
            /// <para>The range of quota values that can be applied for the current quota item, which serves as a reference for quota applications.</para>
            /// </summary>
            [NameInMap("ApplicableRange")]
            [Validation(Required=false)]
            public List<float?> ApplicableRange { get; set; }

            /// <summary>
            /// <para>The quota adjustment type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>discontinuous</para>
            /// </summary>
            [NameInMap("ApplicableType")]
            [Validation(Required=false)]
            public string ApplicableType { get; set; }

            /// <summary>
            /// <para>The sample reasons for applying for a quota adjustment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The business xxx is expected to grow by 50%.</para>
            /// </summary>
            [NameInMap("ApplyReasonTips")]
            [Validation(Required=false)]
            public string ApplyReasonTips { get; set; }

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
            /// <para>The quota dimensions. Format: <c>{&quot;regionId&quot;:&quot;region&quot;}</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dimensions { get; set; }

            /// <summary>
            /// <para>The UTC time when the quota takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-28T06:07:00Z</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The UTC time when the quota expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-29T06:07:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the quota is a global quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GlobalQuota")]
            [Validation(Required=false)]
            public bool? GlobalQuota { get; set; }

            /// <summary>
            /// <para>The quota calculation period.</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public ListProductQuotasResponseBodyQuotasPeriod Period { get; set; }
            public class ListProductQuotasResponseBodyQuotasPeriod : Darabonba.Model {
                /// <summary>
                /// <para>The unit of the quota calculation period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>day</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>The value of the quota calculation period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("PeriodValue")]
                [Validation(Required=false)]
                public int? PeriodValue { get; set; }

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
            /// <para>The ID of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>q_security-groups</para>
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// <para>The ARN of the quota.</para>
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
            /// <para>The quota details.</para>
            /// </summary>
            [NameInMap("QuotaItems")]
            [Validation(Required=false)]
            public List<ListProductQuotasResponseBodyQuotasQuotaItems> QuotaItems { get; set; }
            public class ListProductQuotasResponseBodyQuotasQuotaItems : Darabonba.Model {
                /// <summary>
                /// <para>The quota value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1009</para>
                /// </summary>
                [NameInMap("Quota")]
                [Validation(Required=false)]
                public string Quota { get; set; }

                /// <summary>
                /// <para>The quota unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Count</para>
                /// </summary>
                [NameInMap("QuotaUnit")]
                [Validation(Required=false)]
                public string QuotaUnit { get; set; }

                /// <summary>
                /// <para>The quota category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BaseQuota</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The quota usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1009</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

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
            /// <para>The quota type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>privilege</para>
            /// </summary>
            [NameInMap("QuotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }

            /// <summary>
            /// <para>The quota unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AMOUNT</para>
            /// </summary>
            [NameInMap("QuotaUnit")]
            [Validation(Required=false)]
            public string QuotaUnit { get; set; }

            /// <summary>
            /// <para>The range of quota values supported by the current quota item, which serves as a reference when you configure a quota template.</para>
            /// </summary>
            [NameInMap("SupportedRange")]
            [Validation(Required=false)]
            public List<float?> SupportedRange { get; set; }

            /// <summary>
            /// <para>The quota value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public float? TotalQuota { get; set; }

            /// <summary>
            /// <para>The quota usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1009</para>
            /// </summary>
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public float? TotalUsage { get; set; }

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
            /// <para>An empty value indicates that no monitoring data is available for this quota in CloudMonitor.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("UsageMetric")]
            [Validation(Required=false)]
            public ListProductQuotasResponseBodyQuotasUsageMetric UsageMetric { get; set; }
            public class ListProductQuotasResponseBodyQuotasUsageMetric : Darabonba.Model {
                /// <summary>
                /// <para>The CloudMonitor monitoring dimensions.</para>
                /// <para>Format: a collection of <c>key:value</c> pairs. Example:
                /// <c>{&quot;productCode&quot;:&quot;***&quot;,&quot;metricKey&quot;:&quot;***&quot;,&quot;regionId&quot;:&quot;***&quot;,&quot;label&quot;:&quot;***&quot;}</c>.</para>
                /// </summary>
                [NameInMap("MetricDimensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> MetricDimensions { get; set; }

                /// <summary>
                /// <para>The name of the CloudMonitor monitoring metric.</para>
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

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0131FD5-5397-44FE-BF5A-4B7165B813CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

