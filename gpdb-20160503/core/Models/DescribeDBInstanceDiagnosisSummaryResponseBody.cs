// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceDiagnosisSummaryResponseBody : TeaModel {
        /// <summary>
        /// The group ID.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceDiagnosisSummaryResponseBodyItems> Items { get; set; }
        public class DescribeDBInstanceDiagnosisSummaryResponseBodyItems : TeaModel {
            /// <summary>
            /// The name of the node.
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// The IP address of the node.
            /// </summary>
            [NameInMap("NodeAddress")]
            [Validation(Required=false)]
            public string NodeAddress { get; set; }

            /// <summary>
            /// The ID of the node group.
            /// </summary>
            [NameInMap("NodeCID")]
            [Validation(Required=false)]
            public string NodeCID { get; set; }

            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("NodeID")]
            [Validation(Required=false)]
            public string NodeID { get; set; }

            /// <summary>
            /// The name of the host where the node resides.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The port number of the node.
            /// </summary>
            [NameInMap("NodePort")]
            [Validation(Required=false)]
            public string NodePort { get; set; }

            /// <summary>
            /// The initial role of the node. Valid values:
            /// 
            /// *   **primary**: primary node
            /// *   **mirror**: secondary node
            /// 
            /// If the value of this parameter is the same as that of **NodeRole**, no primary/secondary switchover occurs. If the value of this parameter is not the same as that of **NodeRole**, a primary/secondary switchover occurs.
            /// </summary>
            [NameInMap("NodePreferredRole")]
            [Validation(Required=false)]
            public string NodePreferredRole { get; set; }

            /// <summary>
            /// The data synchronization state of the node. Valid values:
            /// 
            /// *   **Synced**: The node data is synchronized.
            /// *   **Not Syncing**: The node data is not synchronized.
            /// *   **No sync required**: Data synchronization is not required. This value may be returned only for the coordinator node.
            /// </summary>
            [NameInMap("NodeReplicationMode")]
            [Validation(Required=false)]
            public string NodeReplicationMode { get; set; }

            /// <summary>
            /// The current role of the node. Valid values:
            /// 
            /// *   **primary**: primary node
            /// *   **mirror**: secondary node
            /// </summary>
            [NameInMap("NodeRole")]
            [Validation(Required=false)]
            public string NodeRole { get; set; }

            /// <summary>
            /// The running state of the node. Valid values:
            /// 
            /// *   **UP**: The node is running.
            /// *   **DOWN**: The node is faulty.
            /// </summary>
            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            /// <summary>
            /// The type of the node. Valid values:
            /// 
            /// *   **master**: primary coordinator node
            /// *   **slave**: standby coordinator node
            /// *   **segment**: compute node
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

        }

        /// <summary>
        /// The state information about the coordinator node.
        /// </summary>
        [NameInMap("MasterStatusInfo")]
        [Validation(Required=false)]
        public DescribeDBInstanceDiagnosisSummaryResponseBodyMasterStatusInfo MasterStatusInfo { get; set; }
        public class DescribeDBInstanceDiagnosisSummaryResponseBodyMasterStatusInfo : TeaModel {
            /// <summary>
            /// The number of abnormal nodes.
            /// </summary>
            [NameInMap("ExceptionNodeNum")]
            [Validation(Required=false)]
            public int? ExceptionNodeNum { get; set; }

            /// <summary>
            /// The number of normal nodes.
            /// </summary>
            [NameInMap("NormalNodeNum")]
            [Validation(Required=false)]
            public int? NormalNodeNum { get; set; }

            /// <summary>
            /// The number of nodes whose roles are reversed.
            /// </summary>
            [NameInMap("NotPreferredNodeNum")]
            [Validation(Required=false)]
            public int? NotPreferredNodeNum { get; set; }

            /// <summary>
            /// The number of unsynchronized nodes.
            /// </summary>
            [NameInMap("NotSyncingNodeNum")]
            [Validation(Required=false)]
            public int? NotSyncingNodeNum { get; set; }

            /// <summary>
            /// The number of nodes whose roles are normal.
            /// </summary>
            [NameInMap("PreferredNodeNum")]
            [Validation(Required=false)]
            public int? PreferredNodeNum { get; set; }

            /// <summary>
            /// The number of synchronized nodes.
            /// </summary>
            [NameInMap("SyncedNodeNum")]
            [Validation(Required=false)]
            public int? SyncedNodeNum { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The state information about compute nodes.
        /// </summary>
        [NameInMap("SegmentStatusInfo")]
        [Validation(Required=false)]
        public DescribeDBInstanceDiagnosisSummaryResponseBodySegmentStatusInfo SegmentStatusInfo { get; set; }
        public class DescribeDBInstanceDiagnosisSummaryResponseBodySegmentStatusInfo : TeaModel {
            /// <summary>
            /// The number of abnormal nodes.
            /// </summary>
            [NameInMap("ExceptionNodeNum")]
            [Validation(Required=false)]
            public int? ExceptionNodeNum { get; set; }

            /// <summary>
            /// The number of normal nodes.
            /// </summary>
            [NameInMap("NormalNodeNum")]
            [Validation(Required=false)]
            public int? NormalNodeNum { get; set; }

            /// <summary>
            /// The number of nodes whose roles are reversed.
            /// </summary>
            [NameInMap("NotPreferredNodeNum")]
            [Validation(Required=false)]
            public int? NotPreferredNodeNum { get; set; }

            /// <summary>
            /// The number of unsynchronized nodes.
            /// </summary>
            [NameInMap("NotSyncingNodeNum")]
            [Validation(Required=false)]
            public int? NotSyncingNodeNum { get; set; }

            /// <summary>
            /// The number of nodes whose roles are normal.
            /// </summary>
            [NameInMap("PreferredNodeNum")]
            [Validation(Required=false)]
            public int? PreferredNodeNum { get; set; }

            /// <summary>
            /// The number of synchronized nodes.
            /// </summary>
            [NameInMap("SyncedNodeNum")]
            [Validation(Required=false)]
            public int? SyncedNodeNum { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
