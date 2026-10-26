// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class StartDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The migration method of the instance. This parameter is only supported for instances in a dedicated cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Default value. The system preferentially performs a local upgrade or downgrade. If local resources are insufficient, the system performs a cross-instance migration.</description></item>
        /// <item><description><b>1</b>: Local upgrade or downgrade. If the system determines that the instance does not support local upgrade or downgrade, an error is returned.</description></item>
        /// <item><description><b>2</b>: Cross-instance migration. The instance is migrated to a specified host. You must specify the <b>DedicatedHostGroupId</b>, <b>TargetDedicatedHostIdForMaster</b>, and <b>TargetDedicatedHostIdForSlave</b> parameters. The instance cannot be migrated to the current host. Otherwise, the migration fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DBInstanceTransType")]
        [Validation(Required=false)]
        public int? DBInstanceTransType { get; set; }

        /// <summary>
        /// <para>This operation also supports starting ApsaraDB RDS instances in a dedicated cluster. In this case, you must specify the dedicated cluster ID. You can call the DescribeDedicatedHostGroups operation to query the dedicated cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-39****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>The effective period. This parameter is only supported for instances in a dedicated cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The changes take effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The changes take effect within the maintenance window. For more information, see ModifyDBInstanceMaintainTime.</description></item>
        /// <item><description><b>SpecificTime</b>: The changes take effect at a specified time.</description></item>
        /// </list>
        /// <para>Default value: MaintainTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The database engine version. This parameter is only supported for instances in a dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.7</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The specified time when the changes take effect. This parameter is only supported for instances in a dedicated cluster. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>You must specify this parameter when <b>EffectiveTime</b> is set to <b>Specified</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-21T10:00:00Z</para>
        /// </summary>
        [NameInMap("SpecifiedTime")]
        [Validation(Required=false)]
        public string SpecifiedTime { get; set; }

        /// <summary>
        /// <para>The custom storage capacity. This parameter is only supported for instances in a dedicated cluster. Valid values: <b>5</b> to <b>2000</b>. Unit: GB. If you do not specify this parameter, the storage capacity remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public int? Storage { get; set; }

        /// <summary>
        /// <para>The instance type of the target instance. This parameter is only supported for instances in a dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds.ebmhfc6.20xlarge</para>
        /// </summary>
        [NameInMap("TargetDBInstanceClass")]
        [Validation(Required=false)]
        public string TargetDBInstanceClass { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated and does not need to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForLog")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForLog { get; set; }

        /// <summary>
        /// <para>The ID of the destination host for the primary node. This parameter is only supported for instances in a dedicated cluster.</para>
        /// <remarks>
        /// <para>You must specify this parameter when <b>DBInstanceTransType</b> is set to <b>2</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// <para>The ID of the destination host for the secondary node. This parameter is only supported for instances in a dedicated cluster.</para>
        /// <remarks>
        /// <para>You must specify this parameter when <b>DBInstanceTransType</b> is set to <b>2</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForSlave")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForSlave { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. This parameter is only supported for instances in a dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID. This parameter is only supported for instances in a dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
