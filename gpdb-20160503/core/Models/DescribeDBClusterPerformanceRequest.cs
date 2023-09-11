// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBClusterPerformanceRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// > You can call the [DescribeDBInstances](~~86911~~) operation to query details about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the `YYYY-MM-DDTHH:mmZ` format.
        /// 
        /// > The end time must be later than the start time. The maximum time range that can be specified is seven days.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The performance metric that you want to query. Separate multiple values with commas (,). For more information, see [Performance parameters](~~86943~~).
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The node type. Valid values:
        /// 
        /// *   **master**: coordinator node.
        /// *   **segment**: compute node.
        /// 
        /// > If you do not specify this parameter, the performance metrics of all nodes are returned.
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// The nodes for which you want to query performance metrics. Separate multiple values with commas (,). Example: `master-10******1,master-10******2`. You can call the [DescribeDBClusterNode](~~390136~~) operation to query the names of nodes.
        /// 
        /// You can also filter the nodes based on their metric values. Valid values:
        /// 
        /// *   **top10**: the 10 nodes that have the highest metric values.
        /// *   **top20**: the 20 nodes that have the highest metric values.
        /// *   **bottom10**: the 10 nodes that have the lowest metric values.
        /// *   **bottom20**: the 20 nodes that have the lowest metric values.
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public string Nodes { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the `YYYY-MM-DDTHH:mmZ` format.
        /// 
        /// > You can query monitoring information only within the last 30 days.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
