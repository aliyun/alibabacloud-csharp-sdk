// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductQuotasResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of records that are returned for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
        /// <list type="bullet">
        /// <item><description>If NextToken is empty, no next page exists.</description></item>
        /// <item><description>If a value of NextToken is returned, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAd98/tlL5GF2aM7UMKQGM8LZesIPr0CbfxASQvHV/pwcmVKNfdBbW8OPld3NvG9Cy8+dNcyFzyUttQA3IONfBhRGpXFyiVoTgK+dupBsP2mX</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The details of the quotas.</para>
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListProductQuotasResponseBodyQuotas> Quotas { get; set; }
        public class ListProductQuotasResponseBodyQuotas : TeaModel {
            /// <summary>
            /// <para>Indicates whether the quota is adjustable.</para>
            /// <para>Valid values:</para>
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
            /// <para>The type of the adjustable value.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>continuous</description></item>
            /// <item><description>discontinuous</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>discontinuous</para>
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
            /// <para>Indicates whether the system shows the used value of the quota.</para>
            /// <para>Valid values:</para>
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
            /// <para>The quota dimension. Format: <c>{&quot;regionId&quot;:&quot;Region&quot;}</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dimensions { get; set; }

            /// <summary>
            /// <para>The start time of the validity period of the quota. The value is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-28T06:07:00Z</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The end time of the validity period of the quota. The value is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-29T06:07:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the quota is a global quota.</para>
            /// <para>Valid values:</para>
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
            public ListProductQuotasResponseBodyQuotasPeriod Period { get; set; }
            public class ListProductQuotasResponseBodyQuotasPeriod : TeaModel {
                /// <summary>
                /// <para>The unit of the calculation cycle.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>week</description></item>
                /// <item><description>hour</description></item>
                /// <item><description>day</description></item>
                /// <item><description>second</description></item>
                /// <item><description>minute</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>day</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>The value of the calculation cycle.</para>
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
            /// <para>ecs-spec</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The quota ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g5.2xlarge</para>
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:quotas:cn-hangzhou:107992689699****:quota/ecs/ecs.g5.2xlarge/postpaid/vpc/cn-hangzhou/instancetype/cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("QuotaArn")]
            [Validation(Required=false)]
            public string QuotaArn { get; set; }

            /// <summary>
            /// <para>The type of the quota.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FlowControl: API rate limit</description></item>
            /// <item><description>WhiteListLabel: whitelist quota</description></item>
            /// <item><description>CommonQuota: general quota</description></item>
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
            /// <para>ecs.g5.2xlarge</para>
            /// </summary>
            [NameInMap("QuotaDescription")]
            [Validation(Required=false)]
            public string QuotaDescription { get; set; }

            /// <summary>
            /// <para>The details of the quotas.</para>
            /// </summary>
            [NameInMap("QuotaItems")]
            [Validation(Required=false)]
            public List<ListProductQuotasResponseBodyQuotasQuotaItems> QuotaItems { get; set; }
            public class ListProductQuotasResponseBodyQuotasQuotaItems : TeaModel {
                /// <summary>
                /// <para>The value of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Quota")]
                [Validation(Required=false)]
                public string Quota { get; set; }

                /// <summary>
                /// <para>The unit of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AMOUNT</para>
                /// </summary>
                [NameInMap("QuotaUnit")]
                [Validation(Required=false)]
                public string QuotaUnit { get; set; }

                /// <summary>
                /// <para>The category of the quota.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BaseQuota: base quota</description></item>
                /// <item><description>ReservedQuota: reserved quota</description></item>
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

            }

            /// <summary>
            /// <para>The name of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g5.2xlarge</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// <para>The type of the quota.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>normal</description></item>
            /// <item><description>privilege</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>privilege</para>
            /// </summary>
            [NameInMap("QuotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }

            /// <summary>
            /// <para>The unit of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AMOUNT</para>
            /// </summary>
            [NameInMap("QuotaUnit")]
            [Validation(Required=false)]
            public string QuotaUnit { get; set; }

            /// <summary>
            /// <para>The range of the quota value that can be requested for the current quota item. When you configure a quota template, you can use the range as a reference.</para>
            /// </summary>
            [NameInMap("SupportedRange")]
            [Validation(Required=false)]
            public List<float?> SupportedRange { get; set; }

            /// <summary>
            /// <para>The value of the quota.</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public float? TotalUsage { get; set; }

            /// <summary>
            /// <para>The reason why the quota is not adjustable.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>limitReached: The quota limit is reached.</description></item>
            /// <item><description>nonactivated: The service is not activated.</description></item>
            /// <item><description>applicationProcess: The application is being processed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>applicationProcess</para>
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
            public ListProductQuotasResponseBodyQuotasUsageMetric UsageMetric { get; set; }
            public class ListProductQuotasResponseBodyQuotasUsageMetric : TeaModel {
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
        /// <para>D0131FD5-5397-44FE-BF5A-4B7165B813CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
