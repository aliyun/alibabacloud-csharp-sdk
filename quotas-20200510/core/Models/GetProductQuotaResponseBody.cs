// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the quota.</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public GetProductQuotaResponseBodyQuota Quota { get; set; }
        public class GetProductQuotaResponseBodyQuota : TeaModel {
            /// <summary>
            /// <para>Indicates whether the quota is adjustable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Adjustable")]
            [Validation(Required=false)]
            public bool? Adjustable { get; set; }

            /// <summary>
            /// <para>The range of the quota value that can be requested for the quota item.</para>
            /// </summary>
            [NameInMap("ApplicableRange")]
            [Validation(Required=false)]
            public List<float?> ApplicableRange { get; set; }

            /// <summary>
            /// <para>The type of the adjustable value. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>continuous</description></item>
            /// <item><description>discontinuous</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>continuous</para>
            /// </summary>
            [NameInMap("ApplicableType")]
            [Validation(Required=false)]
            public string ApplicableType { get; set; }

            /// <summary>
            /// <para>The reason for submitting a quota increase request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The business xxx is expected to grow by 50%.</para>
            /// </summary>
            [NameInMap("ApplyReasonTips")]
            [Validation(Required=false)]
            public string ApplyReasonTips { get; set; }

            /// <summary>
            /// <para>Indicates whether the system shows the used value of the quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Consumable")]
            [Validation(Required=false)]
            public bool? Consumable { get; set; }

            /// <summary>
            /// <para>The quota dimensions. Format: <c>{&quot;regionId&quot;:&quot;Region&quot;}</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dimensions { get; set; }

            /// <summary>
            /// <para>The start time of the validity period of the quota. Specify the value in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-28T06:06:00Z</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The end time of the validity period of the quota. Specify the value in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-29T06:06:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the quota is a global quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The quota is shared in all regions.</description></item>
            /// <item><description>false: The quota is independently used in a region.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GlobalQuota")]
            [Validation(Required=false)]
            public bool? GlobalQuota { get; set; }

            /// <summary>
            /// <para>The calculation cycle of the quota.</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public GetProductQuotaResponseBodyQuotaPeriod Period { get; set; }
            public class GetProductQuotaResponseBodyQuotaPeriod : TeaModel {
                /// <summary>
                /// <para>The unit of the calculation cycle of the quota. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>second</description></item>
                /// <item><description>minute</description></item>
                /// <item><description>hour</description></item>
                /// <item><description>day</description></item>
                /// <item><description>week</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Day</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>The value of the calculation cycle of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodValue")]
                [Validation(Required=false)]
                public int? PeriodValue { get; set; }

            }

            /// <summary>
            /// <para>The abbreviation of the Alibaba Cloud service name.</para>
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
            /// <para>The Alibaba Cloud Resource Name (ARN) of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:quotas:cn-hangzhou:120886317861****:quota/ecs/q_security-groups/</para>
            /// </summary>
            [NameInMap("QuotaArn")]
            [Validation(Required=false)]
            public string QuotaArn { get; set; }

            /// <summary>
            /// <para>The type of the quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CommonQuota: general quota</description></item>
            /// <item><description>FlowControl: API rate limit</description></item>
            /// <item><description>WhiteListLabel: whitelist quota</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CommonQuota</para>
            /// </summary>
            [NameInMap("QuotaCategory")]
            [Validation(Required=false)]
            public string QuotaCategory { get; set; }

            /// <summary>
            /// <para>The description of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The maximum number of security groups that can be owned by the current account</para>
            /// </summary>
            [NameInMap("QuotaDescription")]
            [Validation(Required=false)]
            public string QuotaDescription { get; set; }

            /// <summary>
            /// <para>The details of the quota.</para>
            /// </summary>
            [NameInMap("QuotaItems")]
            [Validation(Required=false)]
            public List<GetProductQuotaResponseBodyQuotaQuotaItems> QuotaItems { get; set; }
            public class GetProductQuotaResponseBodyQuotaQuotaItems : TeaModel {
                /// <summary>
                /// <para>The value of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>801</para>
                /// </summary>
                [NameInMap("Quota")]
                [Validation(Required=false)]
                public string Quota { get; set; }

                /// <summary>
                /// <para>The unit of the quota.</para>
                /// <remarks>
                /// <para> The unit of each quota is unique. For example, the quota whose ID is <c>q_cbdch3</c> represents the maximum number of ACK clusters. The unit of this quota is clusters. The quota whose ID is <c>q_security-groups</c> represents the maximum number of security groups. The unit of this quota is security groups.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Count</para>
                /// </summary>
                [NameInMap("QuotaUnit")]
                [Validation(Required=false)]
                public string QuotaUnit { get; set; }

                /// <summary>
                /// <para>The category of the quota. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BaseQuota: base quota.</description></item>
                /// <item><description>ReservedQuota: reserved quota.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BaseQuota</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The used quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

            /// <summary>
            /// <para>The name of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Maximum Number of Security Groups</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// <para>The type of the quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>privilege</description></item>
            /// <item><description>normal</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("QuotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }

            /// <summary>
            /// <para>The unit of the quota.</para>
            /// <remarks>
            /// <para> The unit of each quota is unique. For example, the quota whose ID is <c>q_cbdch3</c> represents the maximum number of Container Service for Kubernetes (ACK) clusters. The unit of this quota is clusters. The quota whose ID is <c>q_security-groups</c> represents the maximum number of security groups. The unit of this quota is security groups.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Count</para>
            /// </summary>
            [NameInMap("QuotaUnit")]
            [Validation(Required=false)]
            public string QuotaUnit { get; set; }

            /// <summary>
            /// <para>The range of the quota value.</para>
            /// </summary>
            [NameInMap("SupportedRange")]
            [Validation(Required=false)]
            public List<float?> SupportedRange { get; set; }

            /// <summary>
            /// <para>The value of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>801</para>
            /// </summary>
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public float? TotalQuota { get; set; }

            /// <summary>
            /// <para>The used quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public float? TotalUsage { get; set; }

            /// <summary>
            /// <para>The reason why the quota is not adjustable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>nonactivated: The service is not activated.</description></item>
            /// <item><description>applicationProcess: The application is being processed.</description></item>
            /// <item><description>limitReached: The quota limit is reached.</description></item>
            /// <item><description>supportTicketRequired: The quota can be increased only by submitting a ticket.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>limitReached</para>
            /// </summary>
            [NameInMap("UnadjustableDetail")]
            [Validation(Required=false)]
            public string UnadjustableDetail { get; set; }

            /// <summary>
            /// <para>The monitoring information of the quota in CloudMonitor.</para>
            /// <remarks>
            /// <para> If this parameter is empty, no monitoring data of the quota exists in CloudMonitor.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("UsageMetric")]
            [Validation(Required=false)]
            public GetProductQuotaResponseBodyQuotaUsageMetric UsageMetric { get; set; }
            public class GetProductQuotaResponseBodyQuotaUsageMetric : TeaModel {
                /// <summary>
                /// <para>The monitoring dimensions.</para>
                /// <para>The value is a collection of <c>key:value</c> pairs. Example: <c>{&quot;productCode&quot;:&quot;***&quot;,&quot;metricKey&quot;:&quot;***&quot;,&quot;regionId&quot;:&quot;***&quot;,&quot;label&quot;:&quot;***&quot;}</c>.</para>
                /// </summary>
                [NameInMap("MetricDimensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> MetricDimensions { get; set; }

                /// <summary>
                /// <para>The monitoring metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Usage</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The monitoring namespace.</para>
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
        /// <para>8FF8CAF0-29D9-4F11-B6A4-FD2CBCA016D3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
