// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListAlertItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, the authorization is successful.</description></item>
        /// <item><description>Other status codes indicate authorization failure. If authorization fails, check the <c>message</c> field for detailed error messages.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;NODE&quot;: {
        ///       &quot;Saturation&quot;: [
        ///         &quot;Node CPU utilization detection&quot;,
        ///         &quot;Node kernel-mode CPU utilization detection&quot;,
        ///         &quot;Node softirq CPU utilization detection&quot;,
        ///         &quot;Node memory usage detection&quot;,
        ///         &quot;Node kernel memory usage detection&quot;,
        ///         &quot;Node file descriptor usage detection&quot;,
        ///         &quot;Node root file system usage detection&quot;,
        ///         &quot;Node cgroup leak detection&quot;,
        ///         &quot;Node socket usage detection&quot;,
        ///         &quot;Node TCP memory usage detection&quot;
        ///       ],
        ///       &quot;Latency&quot;: [
        ///         &quot;Node scheduling latency detection&quot;,
        ///         &quot;Node network latency detection&quot;,
        ///         &quot;Node disk write latency detection&quot;,
        ///         &quot;Node disk read latency detection&quot;
        ///       ],
        ///       &quot;Load&quot;: [
        ///         &quot;Node disk I/O traffic detection&quot;,
        ///         &quot;Node load average detection&quot;
        ///       ],
        ///       &quot;Errors&quot;: [
        ///         &quot;Node network packet loss detection&quot;,
        ///         &quot;Node OOM stall prediction and detection&quot;
        ///       ]
        ///     },
        ///     &quot;POD&quot;: {
        ///       &quot;Saturation&quot;: [
        ///         &quot;Pod memory usage detection&quot;,
        ///         &quot;Pod CPU utilization detection&quot;
        ///       ],
        ///       &quot;Errors&quot;: [
        ///         &quot;Pod CPU throttling detection&quot;,
        ///         &quot;Pod OOM event detection&quot;
        ///       ]
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.</description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
