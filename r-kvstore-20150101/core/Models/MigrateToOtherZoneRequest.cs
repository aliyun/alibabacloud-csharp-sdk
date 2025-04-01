// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class MigrateToOtherZoneRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Tair (Redis OSS-compatible) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The time when the database is switched after the instance is migrated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: The database is immediately switched after the instance is migrated.</description></item>
        /// <item><description><b>MaintainTime</b>: The database is switched within the maintenance window.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Default value: Immediately.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of read replicas in the primary zone.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The <b>ReadOnlyCount</b> and <b>SlaveReadOnlyCount</b> parameters are applicable only to cloud-native instances for which read/write splitting is enabled. When you migrate an instance to multiple zones, you can use these parameters to adjust the distribution of read replicas in the primary and secondary zones of the instance. This operation does not allow you to increase or decrease the number of nodes. Therefore, the sum of the values of <c>ReadOnlyCount and SlaveReadOnlyCount</c> must be the same as that before the migration.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify these parameters when you migrate an instance from a single zone to multiple zones, one read replica is migrated to the secondary zone, and all other read replicas remain in the primary zone.</para>
        /// </description></item>
        /// <item><description><para>If the instance is a cluster instance, the preceding parameters indicate the number of read replicas per shard in the primary and secondary zones of the instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        /// <summary>
        /// <para>The number of replica nodes in the primary zone.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The <b>ReplicaCount</b> and <b>SlaveReplicaCount</b> parameters are applicable only to cloud-native instances. When you migrate an instance to multiple zones, you can use these parameters to adjust the distribution of replica nodes in the primary and secondary zones of the instance. This operation does not allow you to increase or decrease the number of nodes. Therefore, the sum of the values of <c>ReplicaCount and SlaveReplicaCount</c> must be the same as that before the migration.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify these parameters when you migrate an instance from a single zone to multiple zones, one replica node is migrated to the secondary zone, and all other replica nodes remain in the primary zone.</para>
        /// </description></item>
        /// <item><description><para>If the instance is a cluster instance, the preceding parameters indicate the number of replica nodes per shard in the primary and secondary zones of the instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReplicaCount")]
        [Validation(Required=false)]
        public int? ReplicaCount { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone to which you want to migrate the instance. You can call the <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> operation to query zone IDs.</para>
        /// <remarks>
        /// <para> If you specify this parameter, the master node and replica node of the instance can be deployed in different zones and disaster recovery is implemented across zones. The instance can withstand failures in data centers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The number of read replicas in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SlaveReadOnlyCount")]
        [Validation(Required=false)]
        public int? SlaveReadOnlyCount { get; set; }

        /// <summary>
        /// <para>The number of replica nodes in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SlaveReplicaCount")]
        [Validation(Required=false)]
        public int? SlaveReplicaCount { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The zone where the vSwitch resides must be the same as the ID of the destination zone.</para>
        /// </description></item>
        /// <item><description><para>If the network type of the instance is VPC, this parameter is required.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the destination primary zone. You can call the <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> operation to query zone IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
