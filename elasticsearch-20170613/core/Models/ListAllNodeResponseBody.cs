// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListAllNodeResponseBody : TeaModel {
        /// <summary>
        /// The zone ID of the node.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The CPU utilization.
        /// 
        /// >  If the **extended** request parameter is set to **true** and the monitoring information of the nodes in the cluster is being synchronized, the value of the cpuPercent parameter is null. In this case, you need to send a request again after 10 seconds to obtain the value of the cpuPercent parameter.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListAllNodeResponseBodyResult> Result { get; set; }
        public class ListAllNodeResponseBodyResult : TeaModel {
            /// <summary>
            /// The disk usage.
            /// </summary>
            [NameInMap("cpuPercent")]
            [Validation(Required=false)]
            public string CpuPercent { get; set; }

            /// <summary>
            /// The health status of the node. Valid values: GREEN, YELLOW, RED, and GRAY.
            /// </summary>
            [NameInMap("diskUsedPercent")]
            [Validation(Required=false)]
            public string DiskUsedPercent { get; set; }

            [NameInMap("health")]
            [Validation(Required=false)]
            public string Health { get; set; }

            /// <summary>
            /// The IP address of the node.
            /// </summary>
            [NameInMap("heapPercent")]
            [Validation(Required=false)]
            public string HeapPercent { get; set; }

            /// <summary>
            /// The port that is used to connect to the node.
            /// </summary>
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("loadOneM")]
            [Validation(Required=false)]
            public string LoadOneM { get; set; }

            /// <summary>
            /// The 1-minute load of the node.
            /// </summary>
            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The type of the nodes. Valid values:
            /// 
            /// *   MASTER: dedicated master node
            /// *   WORKER: hot node
            /// *   WORKER_WARM: warm node
            /// *   COORDINATING: client node
            /// *   KIBANA: Kibana node
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
