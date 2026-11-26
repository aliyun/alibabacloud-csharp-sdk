// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceDiagnosisSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of node details for the instance.</para>
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
            /// <para>The group ID.</para>
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
            /// <para>The original role of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>primary</b>: The primary node.</description></item>
            /// <item><description><b>mirror</b>: The mirror node.</description></item>
            /// </list>
            /// <para>If the value of this parameter is the same as the value of the <b>NodeRole</b> parameter, no role reversal (primary/secondary switchover) has occurred. If the values are different, a role reversal has occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>primary</para>
            /// </summary>
            [NameInMap("NodePreferredRole")]
            [Validation(Required=false)]
            public string NodePreferredRole { get; set; }

            /// <summary>
            /// <para>The data synchronization status of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Synced</b>: The data is synchronized.</description></item>
            /// <item><description><b>Not Syncing</b>: The data is not synchronized.</description></item>
            /// <item><description><b>No sync required</b>: No synchronization is required. This mode applies only to coordinator nodes.</description></item>
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
            /// <item><description><b>primary</b>: The primary node.</description></item>
            /// <item><description><b>mirror</b>: The mirror node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>primary</para>
            /// </summary>
            [NameInMap("NodeRole")]
            [Validation(Required=false)]
            public string NodeRole { get; set; }

            /// <summary>
            /// <para>The running status of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UP</b>: The node is running.</description></item>
            /// <item><description><b>DOWN</b>: The node has failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UP</para>
            /// </summary>
            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>master</b>: The coordinator node.</description></item>
            /// <item><description><b>slave</b>: The secondary coordinator node.</description></item>
            /// <item><description><b>segment</b>: The compute node.</description></item>
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
        /// <para>The statistics information about the status of coordinator nodes.</para>
        /// </summary>
        [NameInMap("MasterStatusInfo")]
        [Validation(Required=false)]
        public DescribeDBInstanceDiagnosisSummaryResponseBodyMasterStatusInfo MasterStatusInfo { get; set; }
        public class DescribeDBInstanceDiagnosisSummaryResponseBodyMasterStatusInfo : TeaModel {
            /// <summary>
            /// <para>The number of nodes in the abnormal state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExceptionNodeNum")]
            [Validation(Required=false)]
            public int? ExceptionNodeNum { get; set; }

            /// <summary>
            /// <para>The number of nodes in the normal state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NormalNodeNum")]
            [Validation(Required=false)]
            public int? NormalNodeNum { get; set; }

            /// <summary>
            /// <para>The number of nodes whose roles have been switched due to a primary/secondary switchover.</para>
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
            /// <para>The number of nodes with normal roles.</para>
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
        /// <para>The current page number.</para>
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
        /// <para>The statistics information about the status of compute nodes.</para>
        /// </summary>
        [NameInMap("SegmentStatusInfo")]
        [Validation(Required=false)]
        public DescribeDBInstanceDiagnosisSummaryResponseBodySegmentStatusInfo SegmentStatusInfo { get; set; }
        public class DescribeDBInstanceDiagnosisSummaryResponseBodySegmentStatusInfo : TeaModel {
            /// <summary>
            /// <para>The number of nodes in the abnormal state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExceptionNodeNum")]
            [Validation(Required=false)]
            public int? ExceptionNodeNum { get; set; }

            /// <summary>
            /// <para>The number of nodes in the normal state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("NormalNodeNum")]
            [Validation(Required=false)]
            public int? NormalNodeNum { get; set; }

            /// <summary>
            /// <para>The number of nodes whose roles have been switched due to a primary/secondary switchover.</para>
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
            /// <para>The number of nodes with normal roles.</para>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
