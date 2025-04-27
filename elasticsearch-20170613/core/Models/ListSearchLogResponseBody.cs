// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListSearchLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The level of the log. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>warn: warning log</description></item>
        /// <item><description>info: information log</description></item>
        /// <item><description>error: error log</description></item>
        /// <item><description>trace: trace logs</description></item>
        /// <item><description>debug: debug logs</description></item>
        /// </list>
        /// <para>The level information has been migrated to the contentCollection field.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListSearchLogResponseBodyHeaders Headers { get; set; }
        public class ListSearchLogResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The IP address of the node that generates the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// <para>The list of logs returned by the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F40EAA1-6F1D-4DD9-8DB8-C5F00C4E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The content of the log entry. Migrated to the contentCollection field.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListSearchLogResponseBodyResult> Result { get; set; }
        public class ListSearchLogResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[GC (Allocation Failure) 2018-07-19T17:24:20.682+0800: 7516.513: [ParNew: 6604768K-&gt;81121K(7341504K), 0.0760606 secs] 7226662K-&gt;703015K(31813056K), 0.0762507 secs] [Times: user=0.52 sys=0.00, real=0.07 secs]</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;level&quot;: &quot;info&quot;, &quot;host&quot;: &quot;<c>192.168.**.**</c>&quot;, &quot;time&quot;: &quot;2019-03-18T08:16:12.741Z&quot;,&quot;content&quot;: &quot;[o.e.c.r.a.AllocationService] [MnNASM_] Cluster health status changed from [YELLOW] to [GREEN] (reason: [shards started [[my_index][3]] ...]).&quot;}</para>
            /// </summary>
            [NameInMap("contentCollection")]
            [Validation(Required=false)]
            public Dictionary<string, object> ContentCollection { get; set; }

            /// <summary>
            /// <para>Details of the log entry. Different content fields are returned for different log types.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>192.168.**.**</c></para>
            /// </summary>
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>es-cn-n6w1o1x0w001c****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The timestamp when the log is generated. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>info</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1531985112420</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
