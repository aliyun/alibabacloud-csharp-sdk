// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class EvaluateResourceRequest : TeaModel {
        /// <summary>
        /// <para>The type of the instance.</para>
        /// <remarks>
        /// <para>This parameter is required when you check whether resources are sufficient for creating or upgrading a replica set instance. For more information about instance types, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds.mongo.mid</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The ID of the instance. This parameter is required when you check whether resources are sufficient for upgrading an instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp14bf67a76d****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database engine of the instance. Set the value to <b>MongoDB</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The version of the database engine.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of read-only nodes in the instance. Valid values: <b>1</b> to <b>5</b>.</para>
        /// <remarks>
        /// <para>This parameter is not required for standalone or serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public string ReadonlyReplicas { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of nodes in the instance.</para>
        /// <list type="bullet">
        /// <item><description>Set the value to <b>1</b> for standalone instances.</description></item>
        /// <item><description>Valid values for replica set instances: <b>3</b>, <b>5</b>, and <b>7</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not required for serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public string ReplicationFactor { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The node information about the sharded cluster instance. This parameter is required when you check whether resources are sufficient for creating or upgrading a sharded cluster instance.</para>
        /// <para>To check whether resources are sufficient for creating a sharded cluster instance, specify the specifications of each node in the instance. The value must be a JSON string. Example:</para>
        /// <pre><c>{
        ///      &quot;ConfigSvrs&quot;:
        ///          [{&quot;Storage&quot;:20,&quot;DBInstanceClass&quot;:&quot;dds.cs.mid&quot;}],
        ///      &quot;Mongos&quot;:
        ///          [{&quot;DBInstanceClass&quot;:&quot;dds.mongos.standard&quot;},{&quot;DBInstanceClass&quot;:&quot;dds.mongos.standard&quot;}],
        ///      &quot;Shards&quot;:
        ///          [{&quot;Storage&quot;:50,&quot;DBInstanceClass&quot;:&quot;dds.shard.standard&quot;},{&quot;Storage&quot;:50,&quot;DBInstanceClass&quot;:&quot;dds.shard.standard&quot;},   {&quot;Storage&quot;:50,&quot;DBInstanceClass&quot;:&quot;dds.shard.standard&quot;}]
        ///  }
        /// </c></pre>
        /// <para>Parameters in the example:</para>
        /// <list type="bullet">
        /// <item><description>ConfigSvrs: the Configserver node.</description></item>
        /// <item><description>Mongos: the mongos node.</description></item>
        /// <item><description>Shards: the shard node.</description></item>
        /// <item><description>Storage: the storage space of the node.</description></item>
        /// <item><description>DBInstanceClass: the instance type of the node. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</description></item>
        /// </list>
        /// <para>To check whether resources are sufficient for upgrading a single node of a sharded cluster instance, specify only the information about the node to be upgraded. The value must be a JSON string. Example:</para>
        /// <pre><c>{
        ///      &quot;NodeId&quot;: &quot;d-bp147c4d9ca7****&quot;, &quot;NodeClass&quot;: &quot;dds.shard.standard&quot;
        /// } 
        /// </c></pre>
        /// <para>Parameters in the example:</para>
        /// <list type="bullet">
        /// <item><description>NodeId: the ID of the node.</description></item>
        /// <item><description>NodeClass: the instance type of the node. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NodeId&quot;: &quot;d-bp147c4d9ca7****&quot;, &quot;NodeClass&quot;: &quot;dds.shard.standard&quot;}</para>
        /// </summary>
        [NameInMap("ShardsInfo")]
        [Validation(Required=false)]
        public string ShardsInfo { get; set; }

        /// <summary>
        /// <para>The storage capacity of the replica set instance. Unit: GB.</para>
        /// <remarks>
        /// <para>This parameter is required for the instances that use cloud disks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public string Storage { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the zone ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
