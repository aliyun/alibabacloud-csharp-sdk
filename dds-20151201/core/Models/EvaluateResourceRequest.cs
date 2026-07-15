// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class EvaluateResourceRequest : TeaModel {
        /// <summary>
        /// <para>The instance type.</para>
        /// <remarks>
        /// <para>This parameter is required when you evaluate resources for a replica set instance. For details about instance types, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds.mongo.mid</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID. This parameter is required when you evaluate resources for an instance upgrade or downgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp14bf67a76d****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database engine. Set the value to <b>MongoDB</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4.2</para>
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
        /// <para>This parameter is not required for standalone instances&lt;props=&quot;china&quot;&gt; and Serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public string ReadonlyReplicas { get; set; }

        /// <summary>
        /// <para>The ID of the region. For more information, see <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a>.</para>
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
        /// <item><description><para>Set the value to <b>1</b> for a standalone instance.</para>
        /// </description></item>
        /// <item><description><para>Set the value to <b>2</b> for an instance that uses shared storage.</para>
        /// </description></item>
        /// <item><description><para>For a replica set instance, valid values are <b>3</b>, <b>5</b>, and <b>7</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter is not required for Serverless instances.</para>
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
        /// <para>The shard information of the sharded cluster. This parameter is required when you evaluate resources for a sharded cluster instance.</para>
        /// <para>To evaluate resources for a new sharded cluster instance, specify the instance type for each shard in a JSON string. Example:</para>
        /// <pre><c>{
        ///      &quot;ConfigSvrs&quot;:
        ///          [{&quot;Storage&quot;:20,&quot;DBInstanceClass&quot;:&quot;dds.cs.mid&quot;}],
        ///      &quot;Mongos&quot;:
        ///          [{&quot;DBInstanceClass&quot;:&quot;dds.mongos.standard&quot;},{&quot;DBInstanceClass&quot;:&quot;dds.mongos.standard&quot;}],
        ///      &quot;Shards&quot;:
        ///          [{&quot;Storage&quot;:50,&quot;DBInstanceClass&quot;:&quot;dds.shard.standard&quot;},{&quot;Storage&quot;:50,&quot;DBInstanceClass&quot;:&quot;dds.shard.standard&quot;},   {&quot;Storage&quot;:50,&quot;DBInstanceClass&quot;:&quot;dds.shard.standard&quot;}]
        ///  }
        /// </c></pre>
        /// <para>The parameters in the example are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>ConfigSvrs: The ConfigServer nodes.</para>
        /// </description></item>
        /// <item><description><para>Mongos: The Mongos nodes.</para>
        /// </description></item>
        /// <item><description><para>Shards: The shard nodes.</para>
        /// </description></item>
        /// <item><description><para>Storage: The storage space of the target shard.</para>
        /// </description></item>
        /// <item><description><para>DBInstanceClass: The instance type of the target shard. For details about instance types, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>To evaluate resources for upgrading or downgrading a sharded cluster instance, specify only the node information in a JSON string. Example:</para>
        /// <pre><c>{
        ///      &quot;NodeId&quot;: &quot;d-bp147c4d9ca7****&quot;, &quot;NodeClass&quot;: &quot;dds.shard.standard&quot;
        /// } 
        /// </c></pre>
        /// <para>The parameters in the example are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>NodeId: The ID of the target node.</para>
        /// </description></item>
        /// <item><description><para>NodeClass: The instance type of the target node. For details about instance types, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NodeId&quot;: &quot;d-bp147c4d9ca7****&quot;, &quot;NodeClass&quot;: &quot;dds.shard.standard&quot;}</para>
        /// </summary>
        [NameInMap("ShardsInfo")]
        [Validation(Required=false)]
        public string ShardsInfo { get; set; }

        /// <summary>
        /// <para>The storage space of the replica set. Unit: GB.</para>
        /// <remarks>
        /// <para>This parameter is required if the instance uses cloud disks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public string Storage { get; set; }

        /// <summary>
        /// <para>The ID of the zone. For more information, see <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a>.</para>
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
