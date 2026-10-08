// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class StartDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is supported only for dedicated cluster instances. The migration method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Default value. The system preferentially performs a local specification change. If local resources are insufficient, a cross-instance migration is performed.</description></item>
        /// <item><description><b>1</b>: Local specification change. If the system determines that the instance does not support a local specification change, an error is returned.</description></item>
        /// <item><description><b>2</b>: Cross-instance migration. The instance is migrated to a specified host. You must specify <b>DedicatedHostGroupId</b>, <b>TargetDedicatedHostIdForMaster</b>, and <b>TargetDedicatedHostIdForSlave</b>. The instance cannot be migrated to the host on which it currently resides. Otherwise, the migration fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DBInstanceTransType")]
        [Validation(Required=false)]
        public int? DBInstanceTransType { get; set; }

        /// <summary>
        /// <para>This operation also supports starting an ApsaraDB RDS instance in a dedicated cluster. In this case, specify the dedicated cluster ID. You can call DescribeDedicatedHostGroups to query the dedicated cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-39****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is supported only for dedicated cluster instances. The effective period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The operation takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The operation takes effect during the maintenance window. For more information, see ModifyDBInstanceMaintainTime.</description></item>
        /// <item><description><b>SpecificTime</b>: The operation takes effect at a specified time.</description></item>
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
        /// <para>This parameter is supported only for dedicated cluster instances. The database engine version.</para>
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
        /// <para>The region ID. You can call DescribeRegions to query the region ID.</para>
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
        /// <para>This parameter is supported only for dedicated cluster instances. The specified switchover time. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
        /// <remarks>
        /// <para>This parameter is required when <b>EffectiveTime</b> is set to <b>Specified</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-21T10:00:00Z</para>
        /// </summary>
        [NameInMap("SpecifiedTime")]
        [Validation(Required=false)]
        public string SpecifiedTime { get; set; }

        /// <summary>
        /// <para>This parameter is supported only for dedicated cluster instances. The custom storage capacity. Valid values: <b>5 to 2000</b>. Unit: GB. If you do not specify this parameter, the storage capacity remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public int? Storage { get; set; }

        /// <summary>
        /// <para>This parameter is supported only for dedicated cluster instances. The instance type of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds.ebmhfc6.20xlarge</para>
        /// </summary>
        [NameInMap("TargetDBInstanceClass")]
        [Validation(Required=false)]
        public string TargetDBInstanceClass { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated and does not need to be configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForLog")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForLog { get; set; }

        /// <summary>
        /// <para>This parameter is supported only for dedicated cluster instances. Specifies the ID of the destination host for the primary node.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DBInstanceTransType</b> is set to <b>2</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// <para>This parameter is supported only for dedicated cluster instances. Specifies the ID of the destination host for the secondary node.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DBInstanceTransType</b> is set to <b>2</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForSlave")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForSlave { get; set; }

        /// <summary>
        /// <para>This parameter is supported only for dedicated cluster instances. The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>This parameter is supported only for dedicated cluster instances. The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
