// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DeleteShardingNodeRequest : TeaModel {
        /// <summary>
        /// <para>The time when the proxy deletion takes effect if proxy nodes are deleted when you delete shards from a cluster instance in proxy mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0 or Immediately</b>: Takes effect immediately. This is the default value.</description></item>
        /// <item><description><b>1 or MaintainTime</b>: Takes effect during the maintenance window.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/473775.html">ModifyInstanceMaintainTime</a> operation to modify the maintenance window of the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable forced migration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Before the upgrade/downgrade, the system checks the current minor engine version of the instance. If the kernel version is too low, an error is reported. You must upgrade the minor engine version and retry.</description></item>
        /// <item><description><b>true</b>: Skips the checks and directly executes the upgrade/downgrade operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceTrans")]
        [Validation(Required=false)]
        public bool? ForceTrans { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the data shard node to be deleted. To specify multiple shard node IDs, separate them with commas (,).</para>
        /// <remarks>
        /// <para>If both the NodeId and ShardCount parameters are specified, the NodeId parameter takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****-db-0,r-bp1zxszhcgatnx****-db-1</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        [Obsolete]
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
        /// <para>The number of shards to be deleted. The system deletes the specified number of shard nodes starting from the end.</para>
        /// <remarks>
        /// <para>For example, if an instance has five shard nodes: db-0, db-1, db-2, db-3, and db-4, and you set this parameter to 2, the db-3 and db-4 nodes are deleted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

    }

}
