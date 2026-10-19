// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class RestartNodeRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. </para>
        /// <remarks>
        /// <para>If the instance is a sharded cluster instance, you must also specify <c>NodeId</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bpxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Instance ID of the Mongos node, Shard node, or ConfigServer node in the sharded cluster instance. You can call the <a href="https://help.aliyun.com/document_detail/62010.html">DescribeDBInstanceAttribute</a> operation to query instance IDs of Mongos nodes, Shard nodes, or ConfigServer nodes.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DBInstanceId</b> is set to instance ID of a sharded cluster instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp128a003436****</para>
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

        /// <summary>
        /// <para>The role ID of the node.</para>
        /// <ol>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/468469.html">DescribeReplicaSetRole</a> operation to query the node IDs of a replica set instance.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/468472.html">DescribeRoleZoneInfo</a> operation to query the node IDs of a sharded cluster instance.</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6025****</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// <para>The execution time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: immediately. This is the default value.</description></item>
        /// <item><description><b>1</b>: during the maintenance window.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/473775.html">ModifyInstanceMaintainTime</a> operation to modify the maintenance window of the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public string SwitchMode { get; set; }

    }

}
