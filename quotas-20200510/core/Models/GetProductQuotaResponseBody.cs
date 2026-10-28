// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The quota details.</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public GetProductQuotaResponseBodyQuota Quota { get; set; }
        public class GetProductQuotaResponseBodyQuota : Darabonba.Model {
            /// <summary>
            /// <para>Indicates whether the quota is adjustable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Adjustable.</para>
            /// </description></item>
            /// <item><description><para>false: Not adjustable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Adjustable")]
            [Validation(Required=false)]
            public bool? Adjustable { get; set; }

            /// <summary>
            /// <para>The applicable range for quota adjustment.</para>
            /// </summary>
            [NameInMap("ApplicableRange")]
            [Validation(Required=false)]
            public List<float?> ApplicableRange { get; set; }

            /// <summary>
            /// <para>The type of quota adjustment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>continuous: Continuous.</para>
            /// </description></item>
            /// <item><description><para>discontinuous: Discontinuous.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>continuous</para>
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
            /// <para>Indicates whether the used quota is displayed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The used quota is displayed.</para>
            /// </description></item>
            /// <item><description><para>false: The used quota is not displayed.</para>
            /// </description></item>
            /// </list>
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
            /// <para>2022-09-28T06:06:00Z</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The UTC time when the quota expires.</para>
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
            /// <item><description>true: The quota item is shared across all regions.</description></item>
            /// <item><description>false: The quota item is independent for each region.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GlobalQuota")]
            [Validation(Required=false)]
            public bool? GlobalQuota { get; set; }

            /// <summary>
            /// <para>The quota period.</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public GetProductQuotaResponseBodyQuotaPeriod Period { get; set; }
            public class GetProductQuotaResponseBodyQuotaPeriod : Darabonba.Model {
                /// <summary>
                /// <para>The unit of the quota period. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>second: Seconds.</para>
                /// </description></item>
                /// <item><description><para>minute: Minutes.</para>
                /// </description></item>
                /// <item><description><para>hour: Hours.</para>
                /// </description></item>
                /// <item><description><para>day: Days.</para>
                /// </description></item>
                /// <item><description><para>week: Weeks.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>day</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>The value of the quota period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodValue")]
                [Validation(Required=false)]
                public int? PeriodValue { get; set; }

            }

            /// <summary>
            /// <para>The abbreviated name of the cloud service.</para>
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
            /// <para>The ARN of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:quotas:cn-hangzhou:120886317861****:quota/ecs/q_security-groups/</para>
            /// </summary>
            [NameInMap("QuotaArn")]
            [Validation(Required=false)]
            public string QuotaArn { get; set; }

            /// <summary>
            /// <para>The quota category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CommonQuota: General quota.</para>
            /// </description></item>
            /// <item><description><para>FlowControl: API rate limit.</para>
            /// </description></item>
            /// <item><description><para>WhiteListLabel: Privilege.</para>
            /// </description></item>
            /// </list>
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
            public List<GetProductQuotaResponseBodyQuotaQuotaItems> QuotaItems { get; set; }
            public class GetProductQuotaResponseBodyQuotaQuotaItems : Darabonba.Model {
                /// <summary>
                /// <para>The quota value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>801</para>
                /// </summary>
                [NameInMap("Quota")]
                [Validation(Required=false)]
                public string Quota { get; set; }

                /// <summary>
                /// <para>The quota unit.</para>
                /// <remarks>
                /// <para>The unit varies for each quota. For example, the unit of the q_cbdch3 quota (maximum number of clusters) for Container Service for Kubernetes is Cluster, and the unit of the q_security-groups quota (maximum number of security groups) for Elastic Compute Service servers is count.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Count</para>
                /// </summary>
                [NameInMap("QuotaUnit")]
                [Validation(Required=false)]
                public string QuotaUnit { get; set; }

                /// <summary>
                /// <para>The quota item type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>BaseQuota: Base quota.</para>
                /// </description></item>
                /// <item><description><para>ReservedQuota: Reserved quota.</para>
                /// </description></item>
                /// </list>
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
                /// <para>26</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

            /// <summary>
            /// <para>The quota name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Maximum Number of Security Groups</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// <para>The quota type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>privilege: Privilege.</para>
            /// </description></item>
            /// <item><description><para>normal: Normal.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("QuotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }

            /// <summary>
            /// <para>The quota unit.</para>
            /// <remarks>
            /// <para>The unit varies for each quota. For example, the unit of the q_cbdch3 quota (maximum number of clusters) for Container Service for Kubernetes is Cluster, and the unit of the q_security-groups quota (maximum number of security groups) for Elastic Compute Service servers is count.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Count</para>
            /// </summary>
            [NameInMap("QuotaUnit")]
            [Validation(Required=false)]
            public string QuotaUnit { get; set; }

            /// <summary>
            /// <para>The supported range of quota values for the current quota item, which can be used as a reference when configuring a quota template.</para>
            /// </summary>
            [NameInMap("SupportedRange")]
            [Validation(Required=false)]
            public List<float?> SupportedRange { get; set; }

            /// <summary>
            /// <para>The quota value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>801</para>
            /// </summary>
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public float? TotalQuota { get; set; }

            /// <summary>
            /// <para>The quota usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public float? TotalUsage { get; set; }

            /// <summary>
            /// <para>The reason why the quota cannot be adjusted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>nonactivated: The service is not activated.</para>
            /// </description></item>
            /// <item><description><para>applicationProcess: The quota application is being processed.</para>
            /// </description></item>
            /// <item><description><para>limitReached: The quota limit is reached.</para>
            /// </description></item>
            /// <item><description><para>supportTicketRequired: A ticket must be submitted for the application.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>limitReached</para>
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
            public GetProductQuotaResponseBodyQuotaUsageMetric UsageMetric { get; set; }
            public class GetProductQuotaResponseBodyQuotaUsageMetric : Darabonba.Model {
                /// <summary>
                /// <para>The CloudMonitor monitoring dimensions.</para>
                /// <para>Format: a collection of <c>key:value</c> pairs. Example:
                /// <c>{&quot;productCode&quot;:&quot;***&quot;,&quot;metricKey&quot;:&quot;***&quot;,&quot;regionId&quot;:&quot;***&quot;,&quot;label&quot;:&quot;***&quot;}</c>.</para>
                /// </summary>
                [NameInMap("MetricDimensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> MetricDimensions { get; set; }

                /// <summary>
                /// <para>The CloudMonitor metric name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Usage</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The CloudMonitor metric namespace.</para>
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

