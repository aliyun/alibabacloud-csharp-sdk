// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAlarmListResponseBody : TeaModel {
        /// <summary>
        /// <para>The alert list.</para>
        /// </summary>
        [NameInMap("Alarms")]
        [Validation(Required=false)]
        public List<DescribeAlarmListResponseBodyAlarms> Alarms { get; set; }
        public class DescribeAlarmListResponseBodyAlarms : TeaModel {
            /// <summary>
            /// <para>The cause of the alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>fivefold</b>: The service QPS exceeds the current specifications.</description></item>
            /// <item><description><b>4count</b>: The cumulative actual service QPS exceeds the current specifications.</description></item>
            /// <item><description><b>exceed10w</b>: The actual peak service QPS exceeds 100,000.</description></item>
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
            /// <para>The end time of the alert. The value is a UNIX timestamp in UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605600798</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The peak QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12000</para>
            /// </summary>
            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            /// <summary>
            /// <para>The current specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public long? Spec { get; set; }

            /// <summary>
            /// <para>The start time of the alert. The value is a UNIX timestamp in UTC. Unit: milliseconds.</para>
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
            /// <item><description><b>1</b>: The QPS limit is exceeded.</description></item>
            /// <item><description><b>2</b>: The instance is added to the sandbox.</description></item>
            /// <item><description><b>3</b>: The instance is removed from the sandbox.</description></item>
            /// <item><description><b>4</b>: The QPS limit is no longer exceeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The Alarm Metric for alerting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>qps</b>: The QPS alerts for the service.</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D8EBFB7-E1EB-5236-952A-092EDC72***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
