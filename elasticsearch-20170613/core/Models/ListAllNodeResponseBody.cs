// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListAllNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D71B597-F3FF-5B56-88D7-74F9D3F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListAllNodeResponseBodyResult> Result { get; set; }
        public class ListAllNodeResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The CPU usage.</para>
            /// <remarks>
            /// <para>When <b>extended</b> is set to <b>true</b> and the monitoring information of the node is being synchronized, the parameter value returns null. In this case, wait 10 seconds and send the request again to retrieve the value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4.2%</para>
            /// </summary>
            [NameInMap("cpuPercent")]
            [Validation(Required=false)]
            public string CpuPercent { get; set; }

            /// <summary>
            /// <para>The disk usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0%</para>
            /// </summary>
            [NameInMap("diskUsedPercent")]
            [Validation(Required=false)]
            public string DiskUsedPercent { get; set; }

            /// <summary>
            /// <para>The health status of the node. Valid values: GREEN, YELLOW, RED, and GRAY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GREEN</para>
            /// </summary>
            [NameInMap("health")]
            [Validation(Required=false)]
            public string Health { get; set; }

            /// <summary>
            /// <para>The JVM memory usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21.6%</para>
            /// </summary>
            [NameInMap("heapPercent")]
            [Validation(Required=false)]
            public string HeapPercent { get; set; }

            /// <summary>
            /// <para>The IP address of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.15.XX.XX</para>
            /// </summary>
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The one-minute load average.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.12</para>
            /// </summary>
            [NameInMap("loadOneM")]
            [Validation(Required=false)]
            public string LoadOneM { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MASTER: dedicated master node</description></item>
            /// <item><description>WORKER: hot node</description></item>
            /// <item><description>WORKER_WARM: warm node</description></item>
            /// <item><description>COORDINATING: client node</description></item>
            /// <item><description>KIBANA: Kibana node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WORKER</para>
            /// </summary>
            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The access port of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9200</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The zone where the node resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
