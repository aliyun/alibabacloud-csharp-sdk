// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceDiagnosisSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The group ID.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceDiagnosisSummaryResponseBodyItems> Items { get; set; }
        public class DescribeDBInstanceDiagnosisSummaryResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gp-t4np568qe9710****-master-100984919</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The IP address of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("NodeAddress")]
            [Validation(Required=false)]
            public string NodeAddress { get; set; }

            /// <summary>
            /// <para>The node group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("NodeCID")]
            [Validation(Required=false)]
            public string NodeCID { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeID")]
            [Validation(Required=false)]
            public string NodeID { get; set; }

            /// <summary>
            /// <para>The name of the host where the node resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-southeast-1.i-t4n4c4ryr0yr441d****</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The port number of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("NodePort")]
            [Validation(Required=false)]
            public string NodePort { get; set; }

            /// <summary>
            /// <para>The initial role of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>primary</b>: primary node.</description></item>
            /// <item><description><b>mirror</b>: secondary node.</description></item>
            /// </list>
            /// <para>If the value of this parameter is the same as that of <b>NodeRole</b>, no primary/secondary switchover occurs. If the value of this parameter is different from that of <b>NodeRole</b>, a primary/secondary switchover occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>primary</para>
            /// </summary>
            [NameInMap("NodePreferredRole")]
            [Validation(Required=false)]
            public string NodePreferredRole { get; set; }

            /// <summary>
            /// <para>The data synchronization state of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Synced</b>: The node data is synchronized.</description></item>
            /// <item><description><b>Not Syncing</b>: The node data is not synchronized.</description></item>
            /// <item><description><b>No sync required</b>: Data synchronization is not required. This value may be returned only for the coordinator node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Synced</para>
            /// </summary>
            [NameInMap("NodeReplicationMode")]
            [Validation(Required=false)]
            public string NodeReplicationMode { get; set; }

            /// <summary>
            /// <para>The current role of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>primary</b>: primary node.</description></item>
            /// <item><description><b>mirror</b>: secondary node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>primary</para>
            /// </summary>
            [NameInMap("NodeRole")]
            [Validation(Required=false)]
            public string NodeRole { get; set; }

            /// <summary>
            /// <para>The running state of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UP</b>: The node is running.</description></item>
            /// <item><description><b>DOWN</b>: The node is faulty.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UP</para>
            /// </summary>
            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            /// <summary>
            /// <para>The type of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>master</b>: primary coordinator node.</description></item>
            /// <item><description><b>slave</b>: standby coordinator node.</description></item>
            /// <item><description><b>segment</b>: compute node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

        }

        /// <summary>
        /// <para>The state information about the coordinator node.</para>
        /// </summary>
        [NameInMap("MasterStatusInfo")]
        [Validation(Required=false)]
        public DescribeDBInstanceDiagnosisSummaryResponseBodyMasterStatusInfo MasterStatusInfo { get; set; }
        public class DescribeDBInstanceDiagnosisSummaryResponseBodyMasterStatusInfo : TeaModel {
            /// <summary>
            /// <para>The number of abnormal nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExceptionNodeNum")]
            [Validation(Required=false)]
            public int? ExceptionNodeNum { get; set; }

            /// <summary>
            /// <para>The number of normal nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NormalNodeNum")]
            [Validation(Required=false)]
            public int? NormalNodeNum { get; set; }

            /// <summary>
            /// <para>The number of nodes whose roles are reversed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NotPreferredNodeNum")]
            [Validation(Required=false)]
            public int? NotPreferredNodeNum { get; set; }

            /// <summary>
            /// <para>The number of unsynchronized nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NotSyncingNodeNum")]
            [Validation(Required=false)]
            public int? NotSyncingNodeNum { get; set; }

            /// <summary>
            /// <para>The number of nodes whose roles are normal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PreferredNodeNum")]
            [Validation(Required=false)]
            public int? PreferredNodeNum { get; set; }

            /// <summary>
            /// <para>The number of synchronized nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SyncedNodeNum")]
            [Validation(Required=false)]
            public int? SyncedNodeNum { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>070534EC-78D5-5519-83CC-E7B1A9213483</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The state information about compute nodes.</para>
        /// </summary>
        [NameInMap("SegmentStatusInfo")]
        [Validation(Required=false)]
        public DescribeDBInstanceDiagnosisSummaryResponseBodySegmentStatusInfo SegmentStatusInfo { get; set; }
        public class DescribeDBInstanceDiagnosisSummaryResponseBodySegmentStatusInfo : TeaModel {
            /// <summary>
            /// <para>The number of abnormal nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExceptionNodeNum")]
            [Validation(Required=false)]
            public int? ExceptionNodeNum { get; set; }

            /// <summary>
            /// <para>The number of normal nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("NormalNodeNum")]
            [Validation(Required=false)]
            public int? NormalNodeNum { get; set; }

            /// <summary>
            /// <para>The number of nodes whose roles are reversed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NotPreferredNodeNum")]
            [Validation(Required=false)]
            public int? NotPreferredNodeNum { get; set; }

            /// <summary>
            /// <para>The number of unsynchronized nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("NotSyncingNodeNum")]
            [Validation(Required=false)]
            public int? NotSyncingNodeNum { get; set; }

            /// <summary>
            /// <para>The number of nodes whose roles are normal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("PreferredNodeNum")]
            [Validation(Required=false)]
            public int? PreferredNodeNum { get; set; }

            /// <summary>
            /// <para>The number of synchronized nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SyncedNodeNum")]
            [Validation(Required=false)]
            public int? SyncedNodeNum { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
