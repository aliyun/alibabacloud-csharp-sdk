// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaAlarmResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the quota alert.</para>
        /// </summary>
        [NameInMap("QuotaAlarm")]
        [Validation(Required=false)]
        public GetQuotaAlarmResponseBodyQuotaAlarm QuotaAlarm { get; set; }
        public class GetQuotaAlarmResponseBodyQuotaAlarm : TeaModel {
            /// <summary>
            /// <para>The ID of the quota alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78d7e436-4b25-4897-84b5-d7b656bb****</para>
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public string AlarmId { get; set; }

            /// <summary>
            /// <para>The name of the quota alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tf-testacccn-hangzhouquotasquotaalarm81611</para>
            /// </summary>
            [NameInMap("AlarmName")]
            [Validation(Required=false)]
            public string AlarmName { get; set; }

            /// <summary>
            /// <para>The time when the quota alert was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-21T03:47:28Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The alert notification methods.</para>
            /// </summary>
            [NameInMap("NotifyChannels")]
            [Validation(Required=false)]
            public List<string> NotifyChannels { get; set; }

            /// <summary>
            /// <para>The alert contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accountContact</para>
            /// </summary>
            [NameInMap("NotifyTarget")]
            [Validation(Required=false)]
            public string NotifyTarget { get; set; }

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
            /// <para>The quota dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
            /// </summary>
            [NameInMap("QuotaDimension")]
            [Validation(Required=false)]
            public Dictionary<string, object> QuotaDimension { get; set; }

            /// <summary>
            /// <para>The used quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>28</para>
            /// </summary>
            [NameInMap("QuotaUsage")]
            [Validation(Required=false)]
            public float? QuotaUsage { get; set; }

            /// <summary>
            /// <para>The quota value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>804</para>
            /// </summary>
            [NameInMap("QuotaValue")]
            [Validation(Required=false)]
            public float? QuotaValue { get; set; }

            /// <summary>
            /// <para>The numeric value of the alert threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

            /// <summary>
            /// <para>The percentage of the alert threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("ThresholdPercent")]
            [Validation(Required=false)]
            public float? ThresholdPercent { get; set; }

            /// <summary>
            /// <para>The type of the quota alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>used: The alert is created for the used quota.</description></item>
            /// <item><description>usable: The alert is created for the available quota.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>used</para>
            /// </summary>
            [NameInMap("ThresholdType")]
            [Validation(Required=false)]
            public string ThresholdType { get; set; }

            /// <summary>
            /// <para>The webhook URL. Quota Center sends alert notifications to the specified URL by using HTTP POST requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alert.aliyun.com/callback">https://alert.aliyun.com/callback</a></para>
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81B9D511-F3DD-43B1-9A81-1795DDB52ADF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
