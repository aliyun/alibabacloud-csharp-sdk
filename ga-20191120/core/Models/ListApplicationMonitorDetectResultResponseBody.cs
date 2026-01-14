// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListApplicationMonitorDetectResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the diagnostic result of the origin probing task.</para>
        /// </summary>
        [NameInMap("ApplicationMonitorDetectResultList")]
        [Validation(Required=false)]
        public List<ListApplicationMonitorDetectResultResponseBodyApplicationMonitorDetectResultList> ApplicationMonitorDetectResultList { get; set; }
        public class ListApplicationMonitorDetectResultResponseBodyApplicationMonitorDetectResultList : TeaModel {
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
            /// <para>The response content returned by the origin probing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>502 BadGateway</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The description of the diagnostic result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>All forward nodes work well.:</b> The origin server is normal.</description></item>
            /// <item><description><b>Endpoint network error.:</b> The origin server is abnormal. You must check whether the origin server is running as expected.</description></item>
            /// <item><description><b>Public network error.:</b> An Internet error occurred, which is a network error that occurred when the client connected to the acceleration region.</description></item>
            /// <item><description><b>Ga internal error.:</b> An internal error occurred. For example, an exception occurred when GA processed a request.</description></item>
            /// <item><description><b>Ga has been deleted.:</b> The current GA instance is deleted.</description></item>
            /// <item><description><b>Ga state is not stable.:</b> The current GA instance is in an unstable state, such as the Configuring state.</description></item>
            /// <item><description><b>Ga has no listener configuration.:</b> No listener is configured for the current GA instance.</description></item>
            /// <item><description><b>Missing endpoint configuration.:</b> No endpoint is configured.</description></item>
            /// <item><description><b>Missing acceleration region configuration.:</b> No acceleration region is configured.</description></item>
            /// <item><description><b>Missing endpointgroup configuration.:</b> No endpoint group is configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>All forward nodes work well</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The time when the diagnosis of the origin probing task ends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1663205460</para>
            /// </summary>
            [NameInMap("DetectTime")]
            [Validation(Required=false)]
            public string DetectTime { get; set; }

            /// <summary>
            /// <para>The diagnostic result of the origin probing task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success:</b> The origin probing task succeeded.</description></item>
            /// <item><description><b>failed:</b> The origin probing task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("DiagStatus")]
            [Validation(Required=false)]
            public string DiagStatus { get; set; }

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
            /// <para>The listener port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The network transmission protocol that is used by the listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp:</b> TCP.</description></item>
            /// <item><description><b>udp:</b> UDP.</description></item>
            /// <item><description><b>http:</b> HTTP.</description></item>
            /// <item><description><b>https:</b> HTTPS.</description></item>
            /// </list>
            /// <remarks>
            /// <para> UDP listeners do not support probing.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The error code returned by the origin probing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>502</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// <para>The origin probing task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sm-bp1fpdjfju9k8yr1y****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

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
