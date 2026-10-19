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
        /// <para>This parameter is required when you evaluate resources for a replica set instance. For more information about instance types, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds.mongo.mid</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID. This parameter is required when you evaluate resources for changing instance specifications.</para>
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
        /// <para>This parameter is not required for standalone instances<ph props ="china"> or serverless instances</ph>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public string ReadonlyReplicas { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> to query available regions.</para>
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
        /// <item><description><para>For a standalone instance, set the value to <b>1</b>.</para>
        /// </description></item>
        /// <item><description><para>For an instance with shared storage, set the value to <b>2</b>.</para>
        /// </description></item>
        /// <item><description><para>For a replica set instance, valid values are <b>3</b>, <b>5</b>, and <b>7</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
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
        /// <para>The shard information of the sharded cluster instance. This parameter is required when you evaluate resources for a sharded cluster instance.</para>
        /// <para>When you evaluate resources for a new sharded cluster instance, you must specify the specifications of each shard in a JSON-formatted character string. Example:</para>
        /// <pre><c>{
        ///      &quot;ConfigSvrs&quot;:
        ///          [{&quot;Storage&quot;:20,&quot;DBInstanceClass&quot;:&quot;dds.cs.mid&quot;}],
        ///      &quot;Mongos&quot;:
        ///          [{&quot;DBInstanceClass&quot;:&quot;dds.mongos.standard&quot;},{&quot;DBInstanceClass&quot;:&quot;dds.mongos.standard&quot;}],
        ///      &quot;Shards&quot;:
        ///          [{&quot;Storage&quot;:50,&quot;DBInstanceClass&quot;:&quot;dds.shard.standard&quot;},{&quot;Storage&quot;:50,&quot;DBInstanceClass&quot;:&quot;dds.shard.standard&quot;},   {&quot;Storage&quot;:50,&quot;DBInstanceClass&quot;:&quot;dds.shard.standard&quot;}]
        ///  }
        /// </c></pre>
        /// <para>The parameter descriptions in the example are as follows:</para>
        /// <list type="bullet">
        /// <item><description>ConfigSvrs: the Configserver nodes.</description></item>
        /// <item><description>Mongos: the mongos nodes.</description></item>
        /// <item><description>Shards: the shard nodes.</description></item>
        /// <item><description>Storage: the storage capacity of the target shard.</description></item>
        /// <item><description>DBInstanceClass: the instance type of the target shard. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</description></item>
        /// </list>
        /// <para>When you evaluate resources for upgrading or downgrading a sharded cluster instance, you only need to specify the node information in a JSON-formatted character string. Example:</para>
        /// <pre><c>{
        ///      &quot;NodeId&quot;: &quot;d-bp147c4d9ca7****&quot;, &quot;NodeClass&quot;: &quot;dds.shard.standard&quot;
        /// } 
        /// </c></pre>
        /// <para>The parameter descriptions in the example are as follows:</para>
        /// <list type="bullet">
        /// <item><description>NodeId: the ID of the target node.</description></item>
        /// <item><description>NodeClass: the instance type of the target node. For more information, see <a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a>.</description></item>
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
        /// <para>This parameter is required when the instance uses cloud disks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public string Storage { get; set; }

        /// <summary>
        /// <para>The zone ID. You can call <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> to query available zones.</para>
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
