// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class StartDBInstanceRequest : TeaModel {
        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The data migration method of the instance. This parameter is available only for instances that are created in dedicated clusters. Valid values:
        /// 
        /// *   **0** (default): The system preferentially upgrades or downgrades the instance without a migration. If the resources on the host on which the instance resides are insufficient, the system migrates the instance to another suitable host.
        /// *   **1**: The system upgrades or downgrades the instance without a migration. If the upgrade or downgrade is not supported, the system reports an error.
        /// *   **2**: The system migrates the data of the instance from the host on which the instance resides to another host. You must also specify **DedicatedHostGroupId**, **TargetDedicatedHostIdForMaster**, and **TargetDedicatedHostIdForSlave**. If you set DBInstanceTransType to 2, you cannot migrate the data of the instance to the host on which the instance resides. If you migrate the data of the instance to the host on which the instance resides, the migration fails.
        /// </summary>
        [NameInMap("DBInstanceTransType")]
        [Validation(Required=false)]
        public int? DBInstanceTransType { get; set; }

        /// <summary>
        /// The ID of the dedicated cluster. This parameter is required when you want to resume an instance in a dedicated cluster. You can call the [DescribeDedicatedHostGroups](~~610640~~) operation to query the ID of the dedicated cluster.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The effective time. This parameter is available only for instances that are created in dedicated clusters.
        /// 
        /// *   **Immediate**
        /// *   **MaintainTime**: The effective time is within the maintenance window. For more information, see [ModifyDBInstanceMaintainTime](~~26249~~).
        /// *   **SpecificTime**: The effective time is specified.
        /// 
        /// Default value: MaintainTime.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// The database engine version of the instance. This parameter is available only for instances that are created in dedicated clusters.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~610399~~) operation to query the most recent region list.
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
        /// The switching time. This parameter is available only for instances that are created in dedicated clusters. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > This parameter must be specified when **EffectiveTime** is set to **Specified**.
        /// </summary>
        [NameInMap("SpecifiedTime")]
        [Validation(Required=false)]
        public string SpecifiedTime { get; set; }

        /// <summary>
        /// The storage capacity of the instance. This parameter is available only for instances that are created in dedicated clusters. Valid values: **5 to 2000**. Unit: GB. If you do not specify this parameter, the storage capacity of the instance remains unchanged.
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public int? Storage { get; set; }

        /// <summary>
        /// The instance type of the required instance. This parameter is available only for instances that are created in dedicated clusters.
        /// </summary>
        [NameInMap("TargetDBInstanceClass")]
        [Validation(Required=false)]
        public string TargetDBInstanceClass { get; set; }

        /// <summary>
        /// A deprecated parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForLog")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForLog { get; set; }

        /// <summary>
        /// The ID of the host on which the primary instance is created. This parameter is available only for instances that are created in dedicated clusters.
        /// 
        /// > This parameter must be specified when **DBInstanceTransType** is set to **2**.
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// The ID of the host on which the secondary instance is created. This parameter is available only for instances that are created in dedicated clusters.
        /// 
        /// > This parameter must be specified when **DBInstanceTransType** is set to **2**.
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForSlave")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForSlave { get; set; }

        /// <summary>
        /// The vSwitch ID. This parameter is available only for instances that are created in dedicated clusters.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The zone ID. This parameter is available only for instances that are created in dedicated clusters.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
