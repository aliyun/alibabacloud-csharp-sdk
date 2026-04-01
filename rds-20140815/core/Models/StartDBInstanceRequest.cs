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
        /// <para>The data migration method of the instance. This parameter is available only for instances that are created in dedicated clusters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): The system preferentially upgrades or downgrades the instance without a migration. If the resources on the host on which the instance resides are insufficient, the system migrates the instance to another suitable host.</description></item>
        /// <item><description><b>1</b>: The system upgrades or downgrades the instance without a migration. If the upgrade or downgrade is not supported, the system reports an error.</description></item>
        /// <item><description><b>2</b>: The system migrates the data of the instance from the host on which the instance resides to another host. You must also specify <b>DedicatedHostGroupId</b>, <b>TargetDedicatedHostIdForMaster</b>, and <b>TargetDedicatedHostIdForSlave</b>. If you set DBInstanceTransType to 2, you cannot migrate the data of the instance to the host on which the instance resides. If you migrate the data of the instance to the host on which the instance resides, the migration fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DBInstanceTransType")]
        [Validation(Required=false)]
        public int? DBInstanceTransType { get; set; }

        /// <summary>
        /// <para>The dedicated cluster ID. This parameter is supported if you call this operation to suspend an RDS instance in the dedicated cluster. You can call the DescribeDedicatedHostGroups operation to query the dedicated cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-39****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>The effective time. This parameter is available only for instances that are created in dedicated clusters.</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b></description></item>
        /// <item><description><b>MaintainTime</b>: The change takes effect during the planned maintenance window. For more information, see ModifyDBInstanceMaintainTime.</description></item>
        /// <item><description><b>SpecificTime</b>: The change takes effect at a specified point in time.</description></item>
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
        /// <para>The database engine version of the instance. This parameter is available only for instances that are created in dedicated clusters.</para>
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
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
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
        /// <para>The switching time. This parameter is available only for instances that are created in dedicated clusters. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>This parameter must be specified when <b>EffectiveTime</b> is set to <b>Specified</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-21T10:00:00Z</para>
        /// </summary>
        [NameInMap("SpecifiedTime")]
        [Validation(Required=false)]
        public string SpecifiedTime { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance. This parameter is available only for instances that are created in dedicated clusters. Valid values: <b>5 to 2000</b>. Unit: GB. If you do not specify this parameter, the storage capacity of the instance remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public int? Storage { get; set; }

        /// <summary>
        /// <para>The instance type of the required instance. This parameter is available only for instances that are created in dedicated clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds.ebmhfc6.20xlarge</para>
        /// </summary>
        [NameInMap("TargetDBInstanceClass")]
        [Validation(Required=false)]
        public string TargetDBInstanceClass { get; set; }

        /// <summary>
        /// <para>A deprecated parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForLog")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForLog { get; set; }

        /// <summary>
        /// <para>The ID of the host on which the primary instance is created. This parameter is available only for instances that are created in dedicated clusters.</para>
        /// <remarks>
        /// <para>This parameter must be specified when <b>DBInstanceTransType</b> is set to <b>2</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// <para>The ID of the host on which the secondary instance is created. This parameter is available only for instances that are created in dedicated clusters.</para>
        /// <remarks>
        /// <para>This parameter must be specified when <b>DBInstanceTransType</b> is set to <b>2</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForSlave")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForSlave { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. This parameter is available only for instances that are created in dedicated clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID. This parameter is available only for instances that are created in dedicated clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
