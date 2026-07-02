// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class SwitchInstanceHARequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data shard node. You can call <a href="https://help.aliyun.com/document_detail/473782.html">DescribeRoleZoneInfo</a> to obtain the CustinsId parameter. Separate multiple data shard node IDs with commas (,). To specify all nodes, enter <c>all</c>.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the instance uses the cluster or read/write splitting architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>56<b><b>19,56</b></b>20</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The node ID of the original MASTER node in the shard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52717408</para>
        /// </summary>
        [NameInMap("SourceNodeId")]
        [Validation(Required=false)]
        public string SourceNodeId { get; set; }

        /// <summary>
        /// <para>The execution time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: immediately. This is the default value.</description></item>
        /// <item><description><b>1</b>: during the maintenance window.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/473775.html">ModifyInstanceMaintainTime</a> to modify the maintenance window of the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public int? SwitchMode { get; set; }

        /// <summary>
        /// <para>The switchover mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReliabilityPriority (default)</b>: Reliability is prioritized. The primary/secondary switchover is performed only when primary/secondary synchronization has no latency, which prevents data loss. In scenarios with heavy write workloads and persistent synchronization latency, this mode may cause the primary/secondary switchover to fail.</description></item>
        /// <item><description><b>AvailablePriority</b>: Availability is prioritized. The primary/secondary switchover is performed immediately regardless of primary/secondary latency, which may cause minor data loss.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Evaluate your business requirements for data integrity and service availability before selecting a switchover mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ReliabilityPriority</para>
        /// </summary>
        [NameInMap("SwitchType")]
        [Validation(Required=false)]
        public string SwitchType { get; set; }

        /// <summary>
        /// <para>The node ID of the target MASTER node after the switchover.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52717403</para>
        /// </summary>
        [NameInMap("TargetNodeId")]
        [Validation(Required=false)]
        public string TargetNodeId { get; set; }

        /// <summary>
        /// <para>The shard name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-2zegk3jyxxxwixfo6c-db-1</para>
        /// </summary>
        [NameInMap("TargetShardName")]
        [Validation(Required=false)]
        public string TargetShardName { get; set; }

    }

}
