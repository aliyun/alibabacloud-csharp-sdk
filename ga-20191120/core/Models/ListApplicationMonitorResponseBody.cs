// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListApplicationMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of origin probing tasks.</para>
        /// </summary>
        [NameInMap("ApplicationMonitors")]
        [Validation(Required=false)]
        public List<ListApplicationMonitorResponseBodyApplicationMonitors> ApplicationMonitors { get; set; }
        public class ListApplicationMonitorResponseBodyApplicationMonitors : TeaModel {
            /// <summary>
            /// <para>The ID of the GA instance on which the origin probing task runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1odcab8tmno0hdq****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>The URL or IP address that was probed.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>Indicates whether the automatic diagnostics feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DetectEnable")]
            [Validation(Required=false)]
            public bool? DetectEnable { get; set; }

            /// <summary>
            /// <para>The threshold that is used to trigger the automatic diagnostics feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>１</para>
            /// </summary>
            [NameInMap("DetectThreshold")]
            [Validation(Required=false)]
            public int? DetectThreshold { get; set; }

            /// <summary>
            /// <para>The number of times that are required to reach the threshold before the automatic diagnostics feature can be triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>１</para>
            /// </summary>
            [NameInMap("DetectTimes")]
            [Validation(Required=false)]
            public int? DetectTimes { get; set; }

            /// <summary>
            /// <para>The ID of the listener on which the origin probing task runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsr-bp1bpn0kn908w4nbw****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The extended options of the listener protocol that is used by the origin probing task. The options vary based on the listener protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;http_method&quot;: &quot;get&quot;,&quot;header&quot;: &quot;key:asd&quot;,&quot;acceptable_response_code&quot;: &quot;500&quot;,&quot;cert_verify&quot;: true }</para>
            /// </summary>
            [NameInMap("OptionsJson")]
            [Validation(Required=false)]
            public string OptionsJson { get; set; }

            /// <summary>
            /// <para>The silence period of the automatic diagnostics feature. This parameter indicates the interval at which the automatic diagnostics feature is triggered. If the availability rate does not return to normal after GA triggers an automatic diagnostic task, GA must wait until the silence period ends before GA can trigger another automatic diagnostic task.</para>
            /// <para>If the number of consecutive times that the availability rate drops below the threshold of automatic diagnostics reaches the value of <b>DetectTimes</b> , the automatic diagnostics feature is triggered. The automatic diagnostics feature is not triggered again within the silence period even if the availability rate stays below the threshold. If the availability rate does not return to normal after the silence period ends, the automatic diagnostics feature is triggered again.</para>
            /// <para>Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            /// <summary>
            /// <para>The status of the origin probing task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>active:</b> The origin probing task is running.</description></item>
            /// <item><description><b>inactive:</b> The origin probing task is stopped.</description></item>
            /// <item><description><b>init:</b> The origin probing task is being initialized.</description></item>
            /// <item><description><b>deleting:</b> The origin probing task is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The origin probing task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sm-bp1fpdjfju9k8yr1y****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The origin probing task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task1</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
