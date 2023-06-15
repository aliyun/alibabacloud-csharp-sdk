// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class StartDBInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can call the [DescribeDBInstances](~~26232~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The policy based on which the system migrates the data of the instance. Valid values:
        /// 
        /// *   **0**: the default value. The system preferentially upgrades or downgrades the instance without a migration. If the resources on the host on which the instance resides are insufficient, the system migrates the instance to another suitable host.
        /// *   **1**: The system upgrades or downgrades the instance without a migration. If the upgrade or downgrade is not supported, the system reports an error.
        /// *   **2**: The system migrates the data of the instance from the host on which the instance resides to another host. You must also specify the **DedicatedHostGroupId**, **TargetDedicatedHostIdForMaster**, and **TargetDedicatedHostIdForSlave** parameters. If you set the DBInstanceTransType parameter to 2, you cannot migrate the data of the instance to the host on which the instance resides. If you migrate the data of the instance to the host on which the instance resides, the migration fails.
        /// 
        /// > Only the instances that are created in dedicated clusters are supported.
        /// </summary>
        [NameInMap("DBInstanceTransType")]
        [Validation(Required=false)]
        public int? DBInstanceTransType { get; set; }

        /// <summary>
        /// The ID of the dedicated cluster. You can call the [DescribeDedicatedHostGroups](~~141946~~) operation to query the ID of the dedicated cluster.
        /// 
        /// > Only the instances that are created in dedicated clusters are supported.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The time at which you want the change to take effect. Valid values:
        /// 
        /// *   **Immediate**: The change immediately takes effect.
        /// *   **MaintainTime**: The change takes effect during the maintenance window that you specified. For more information, see [ModifyDBInstanceMaintainTime](~~26249~~).
        /// *   **SpecificTime**: The change takes effect at a specified point in time.
        /// 
        /// Default value: MaintainTime.
        /// 
        /// > Only the instances that are created in dedicated clusters are supported.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// The database engine version of the instance.
        /// 
        /// > Only the instances that are created in dedicated clusters are supported.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
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
        /// The custom time at which you want the change to take effect. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > 
        /// 
        /// *   This parameter must be specified when you set the **EffectiveTime** parameter to **Specified**.
        /// 
        /// *   Only the instances that are created in dedicated clusters are supported.
        /// </summary>
        [NameInMap("SpecifiedTime")]
        [Validation(Required=false)]
        public string SpecifiedTime { get; set; }

        /// <summary>
        /// The storage capacity of the instance. Valid values: **5 to 2000**. Unit: GB. If you do not specify this parameter, the storage capacity of the instance remains unchanged.
        /// 
        /// > Only the instances that are created in dedicated clusters are supported.
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public int? Storage { get; set; }

        /// <summary>
        /// The instance type of the instance.
        /// 
        /// > Only the instances that are created in dedicated clusters are supported.
        /// </summary>
        [NameInMap("TargetDBInstanceClass")]
        [Validation(Required=false)]
        public string TargetDBInstanceClass { get; set; }

        /// <summary>
        /// The ID of the host on which the logger instance is created.
        /// 
        /// > 
        /// 
        /// *   This parameter is invalid.
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForLog")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForLog { get; set; }

        /// <summary>
        /// The ID of the host on which the primary instance is created.
        /// 
        /// > 
        /// 
        /// *   This parameter must be specified when you set the **DBInstanceTransType** parameter to **2**.
        /// 
        /// *   Only the instances that are created in dedicated clusters are supported.
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// The ID of the host on which the secondary instance is created.
        /// 
        /// > 
        /// 
        /// *   This parameter must be specified when you set the **DBInstanceTransType** parameter to **2**.
        /// 
        /// *   Only the instances that are created in dedicated clusters are supported.
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForSlave")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForSlave { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// 
        /// > Only the instances that are created in dedicated clusters are supported.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The zone ID of the instance.
        /// 
        /// > Only the instances that are created in dedicated clusters are supported.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
