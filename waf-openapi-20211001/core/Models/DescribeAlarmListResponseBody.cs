// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAlarmListResponseBody : TeaModel {
        /// <summary>
        /// <para>The alerts.</para>
        /// </summary>
        [NameInMap("Alarms")]
        [Validation(Required=false)]
        public List<DescribeAlarmListResponseBodyAlarms> Alarms { get; set; }
        public class DescribeAlarmListResponseBodyAlarms : TeaModel {
            /// <summary>
            /// <para>The cause of the alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>fivefold</b>: The QPS exceeds the limit of the current WAF instance specifications.</para>
            /// </description></item>
            /// <item><description><para><b>4count</b>: The actual QPS has cumulatively exceeded the limit of the current WAF instance specifications.</para>
            /// </description></item>
            /// <item><description><para><b>exceed10w</b>: The peak QPS exceeds 100,000.</para>
            /// </description></item>
            /// <item><description><para><b>costProtection</b>: Billing protection is triggered.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4count</para>
            /// </summary>
            [NameInMap("Cause")]
            [Validation(Required=false)]
            public string Cause { get; set; }

            /// <summary>
            /// <para>The end time of the alert. This is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605600798</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The peak QPS during the alert period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12000</para>
            /// </summary>
            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            /// <summary>
            /// <para>The QPS limit of the current WAF instance specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public long? Spec { get; set; }

            /// <summary>
            /// <para>The start time of the alert. This is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605600767</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The current status of the alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: The queries per second (QPS) limit is exceeded.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: The WAF instance enters the sandbox.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: The WAF instance is removed from the sandbox.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: The QPS no longer exceeds the limit.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The type of the alert. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>qps</b>: a QPS alert.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>qps</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D8EBFB7-E1EB-5236-952A-092EDC72***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
