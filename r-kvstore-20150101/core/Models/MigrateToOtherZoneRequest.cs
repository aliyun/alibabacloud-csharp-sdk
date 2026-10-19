// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class MigrateToOtherZoneRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The time when the database switchover is performed after data migration. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: The switchover is performed immediately after the migration.</description></item>
        /// <item><description><b>MaintainTime</b>: The switchover is performed within the maintenance window.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>Immediately</b>.</para>
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
        /// <para>The number of read-only nodes in the primary zone.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The ReadOnlyCount and SlaveReadOnlyCount parameters apply only to cloud-native instances with read/write splitting enabled. When you migrate an instance to multiple zones, you can use these parameters to adjust the distribution of read-only nodes across the primary and secondary zones. This operation does not support adding or removing nodes. Therefore, the total number of read-only nodes calculated by ReadOnlyCount + SlaveReadOnlyCount must remain the same as that before the migration.</description></item>
        /// <item><description>When you migrate an instance from a single zone to multiple zones and do not specify these parameters, one read-only node is migrated to the secondary zone by default, and the remaining read-only nodes stay in the primary zone.</description></item>
        /// <item><description>If the instance uses the cluster architecture, these parameters specify the number of read-only nodes per shard in the primary and secondary zones.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReadOnlyCount")]
        [Validation(Required=false)]
        public int? ReadOnlyCount { get; set; }

        /// <summary>
        /// <para>The number of secondary nodes in the primary zone.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The ReplicaCount and SlaveReplicaCount parameters apply only to cloud-native instances. When you migrate an instance to multiple zones, you can use these parameters to adjust the distribution of secondary nodes across the primary and secondary zones. This operation does not support adding or removing nodes. Therefore, the total number of secondary nodes calculated by ReplicaCount + SlaveReplicaCount must remain the same as that before the migration.</description></item>
        /// <item><description>When you migrate an instance from a single zone to multiple zones and do not specify these parameters, one secondary node is migrated to the secondary zone by default, and the remaining secondary nodes stay in the primary zone.</description></item>
        /// <item><description>If the instance uses the cluster architecture, these parameters specify the number of secondary nodes per shard in the primary and secondary zones.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>The ID of the destination secondary zone. You can call the <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> operation to query the zone ID.</para>
        /// <remarks>
        /// <para>If you specify this parameter, the primary and secondary data nodes are distributed across different zones. This implements cross-zone disaster recovery and tolerates data center-level failures.</para>
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
        /// <para>The number of read-only nodes in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SlaveReadOnlyCount")]
        [Validation(Required=false)]
        public int? SlaveReadOnlyCount { get; set; }

        /// <summary>
        /// <para>The number of secondary nodes in the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SlaveReplicaCount")]
        [Validation(Required=false)]
        public int? SlaveReplicaCount { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The zone where the vSwitch resides must be the same as the destination zone specified by ZoneId. </description></item>
        /// <item><description>This parameter is required if the network type of the instance is VPC.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the destination primary zone. You can call the <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> operation to query the zone ID.</para>
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
