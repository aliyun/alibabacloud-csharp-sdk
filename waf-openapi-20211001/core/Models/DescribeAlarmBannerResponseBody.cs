// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAlarmBannerResponseBody : TeaModel {
        /// <summary>
        /// <para>The alert banner status information.</para>
        /// </summary>
        [NameInMap("BannerStatus")]
        [Validation(Required=false)]
        public DescribeAlarmBannerResponseBodyBannerStatus BannerStatus { get; set; }
        public class DescribeAlarmBannerResponseBodyBannerStatus : TeaModel {
            /// <summary>
            /// <para>The cause of the alerting. If the Alarm Metric is sandbox (<b>Type</b> is set to <b>sandbox</b>), valid values are:</para>
            /// <list type="bullet">
            /// <item><description><b>fivefold</b>: The clean queries per second (QPS) exceeds the current specifications.</description></item>
            /// <item><description><b>4count</b>: The accumulated actual clean QPS exceeds the current specifications.</description></item>
            /// <item><description><b>exceed10w</b>: The actual peak clean QPS exceeds 100,000.</description></item>
            /// <item><description><b>costProtection</b>: Billing protection is triggered.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4count</para>
            /// </summary>
            [NameInMap("Cause")]
            [Validation(Required=false)]
            public string Cause { get; set; }

            /// <summary>
            /// <para>The usage when alerting is triggered.</para>
            /// <list type="bullet">
            /// <item><description>If the Alarm Metric is sandbox (<b>Type</b> is set to <b>sandbox</b>), this parameter indicates the number of days the quota is exceeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>9008</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The alerting status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Alerting is triggered. If the Alarm Metric is sandbox (<b>Type</b> is set to <b>sandbox</b>), the instance is in the sandbox.</description></item>
            /// <item><description><b>false</b>: No alerting is triggered. If the Alarm Metric is sandbox (<b>Type</b> is set to <b>sandbox</b>), the instance is not in the sandbox.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            /// <summary>
            /// <para>The Alarm Metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>sandbox</b>: sandbox alerting.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sandbox</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5555DC36-0CF2-5AA3-B1C7-D6BD8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
