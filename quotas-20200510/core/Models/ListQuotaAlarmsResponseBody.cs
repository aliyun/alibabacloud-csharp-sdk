// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaAlarmsResponseBody : Darabonba.Model {
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
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// <remarks>
        /// <para>If this parameter is empty, all results have been returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The details of the quota usage alerts.</para>
        /// </summary>
        [NameInMap("QuotaAlarms")]
        [Validation(Required=false)]
        public List<ListQuotaAlarmsResponseBodyQuotaAlarms> QuotaAlarms { get; set; }
        public class ListQuotaAlarmsResponseBodyQuotaAlarms : Darabonba.Model {
            /// <summary>
            /// <para>The alert ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2efa7fc-832f-47bb-8054-39e28012****</para>
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public string AlarmId { get; set; }

            /// <summary>
            /// <para>The alert name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>q_hvnoqv alarm</para>
            /// </summary>
            [NameInMap("AlarmName")]
            [Validation(Required=false)]
            public string AlarmName { get; set; }

            /// <summary>
            /// <para>The time when the quota usage alert was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-27T07:23:34Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the quota usage exceeds the alert threshold. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>false</para>
            /// </description></item>
            /// <item><description><para>true</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ExceedThreshold")]
            [Validation(Required=false)]
            public bool? ExceedThreshold { get; set; }

            /// <summary>
            /// <para>The notification channels of the quota alert.</para>
            /// </summary>
            [NameInMap("NotifyChannels")]
            [Validation(Required=false)]
            public List<string> NotifyChannels { get; set; }

            /// <summary>
            /// <para>The notification object of the alert.</para>
            /// <remarks>
            /// <para>The value can only be accountContact, which specifies the contacts of the account.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>accountContact</para>
            /// </summary>
            [NameInMap("NotifyTarget")]
            [Validation(Required=false)]
            public string NotifyTarget { get; set; }

            /// <summary>
            /// <para>The abbreviation of the Alibaba Cloud service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>config</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The quota ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>q_hvnoqv</para>
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// <para>The quota dimensions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("QuotaDimensions")]
            [Validation(Required=false)]
            public Dictionary<string, object> QuotaDimensions { get; set; }

            /// <summary>
            /// <para>The used quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>73</para>
            /// </summary>
            [NameInMap("QuotaUsage")]
            [Validation(Required=false)]
            public float? QuotaUsage { get; set; }

            /// <summary>
            /// <para>The quota value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("QuotaValue")]
            [Validation(Required=false)]
            public float? QuotaValue { get; set; }

            /// <summary>
            /// <para>The numeric value of the alert threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

            /// <summary>
            /// <para>The percentage of the alert threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ThresholdPercent")]
            [Validation(Required=false)]
            public float? ThresholdPercent { get; set; }

            /// <summary>
            /// <para>The type of the quota alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>used: an alert for the used quota.</para>
            /// </description></item>
            /// <item><description><para>usable: an alert for the available quota.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>used</para>
            /// </summary>
            [NameInMap("ThresholdType")]
            [Validation(Required=false)]
            public string ThresholdType { get; set; }

            /// <summary>
            /// <para>The webhook URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com/webhook">https://www.aliyun.com/webhook</a></para>
            /// </summary>
            [NameInMap("WebHook")]
            [Validation(Required=false)]
            public string WebHook { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87F3B755-3BD2-4C76-B36A-93247002918C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of quota usage alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

