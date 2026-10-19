// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class SwitchInstanceHARequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data shard node. You can call the <a href="https://help.aliyun.com/document_detail/473782.html">DescribeRoleZoneInfo</a> operation to obtain the CustinsId parameter. Separate multiple data shard node IDs with commas (,). To specify all nodes, enter <c>all</c>.</para>
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
        /// <para>The ID of the original primary node of the shard.</para>
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
        /// <item><description><b>0</b>: executes the operation immediately. This is the default value.</description></item>
        /// <item><description><b>1</b>: executes the operation within the maintenance window.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/473775.html">ModifyInstanceMaintainTime</a> operation to modify the maintenance window of the instance.</para>
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
        /// <item><description><b>ReliabilityPriority</b> (default): prioritizes reliability. The primary/secondary switchover is performed only when there is no synchronization latency between the primary and secondary nodes, ensuring no data loss. In scenarios with a large write volume and continuous synchronization latency, this mode may cause the switchover to fail.</description></item>
        /// <item><description><b>AvailablePriority</b>: prioritizes availability. The primary/secondary switchover is performed immediately regardless of the synchronization latency between the primary and secondary nodes, which may result in a small amount of data loss.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Select a switchover mode based on your business requirements for data and services.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ReliabilityPriority</para>
        /// </summary>
        [NameInMap("SwitchType")]
        [Validation(Required=false)]
        public string SwitchType { get; set; }

        /// <summary>
        /// <para>The ID of the target primary node after the switchover.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52717403</para>
        /// </summary>
        [NameInMap("TargetNodeId")]
        [Validation(Required=false)]
        public string TargetNodeId { get; set; }

        /// <summary>
        /// <para>The name of the instance shard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-2zegk3jyxxxwixfo6c-db-1</para>
        /// </summary>
        [NameInMap("TargetShardName")]
        [Validation(Required=false)]
        public string TargetShardName { get; set; }

    }

}
