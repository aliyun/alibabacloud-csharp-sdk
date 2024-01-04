// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class MigrateToOtherZoneRequest : TeaModel {
        /// <summary>
        /// The RDS edition of the instance. Valid values:
        /// 
        /// *   **Basic**: RDS Basic Edition
        /// *   **HighAvailability**: RDS High-availability Edition
        /// *   **AlwaysOn**: SQL Server on RDS Cluster Edition
        /// *   **cluster**: MySQL on RDS Cluster Edition
        /// *   **Finance**: RDS Enterprise Edition
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The new instance type of the instance. You can change the instance type of the instance. You cannot change the storage type of the instance. If you set **IsModifySpec** to **true**, you must specify at least one of DBInstanceClass and **DBInstanceStorage**.
        /// 
        /// For more information about instance types, see [Primary ApsaraDB RDS for MySQL instance types](~~276975~~).
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The new storage capacity of the instance. If you set **IsModifySpec** to **true**, you must specify at least one of DBInstanceStorage and **DBInstanceClass**.
        /// 
        /// Unit: GB. The available storage capacity range varies based on the instance type of the instance. For more information, see [Primary ApsaraDB RDS for MySQL instance types](~~276975~~).
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public long? DBInstanceStorage { get; set; }

        /// <summary>
        /// The time when you want the change to take effect. Valid values:
        /// 
        /// *   **Immediately** (default): The change immediately takes effect.
        /// *   **MaintainTime**: The change takes effect during the maintenance window. For more information, see ModifyDBInstanceMaintainTime.
        /// *   **ScheduleTime**: The change takes effect at the point in time that you specify.
        /// 
        /// >  If you set this parameter to **ScheduleTime**, you must specify the **SwitchTime** parameter.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        [NameInMap("IoAccelerationEnabled")]
        [Validation(Required=false)]
        public string IoAccelerationEnabled { get; set; }

        /// <summary>
        /// Specifies whether to change the specifications of the instance during the cross-zone migration. Valid values:
        /// 
        /// *   **true**: You want to change the specifications of the instance during the cross-zone migration. If you set this parameter to **true**, you must specify at least one of **DBInstanceClass** and **DBInstanceStorage**.
        /// *   **false** (default): You do not want to change the specifications of the instance during the cross-zone migration.
        /// 
        /// > This parameter applies only to instances that run MySQL.
        /// </summary>
        [NameInMap("IsModifySpec")]
        [Validation(Required=false)]
        public string IsModifySpec { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The migration time. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > This parameter is used with **EffectiveTime**. You must specify this parameter only when **EffectiveTime** is set to **ScheduleTime**.
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC). Do not change the VPC of the instance when you migrate the instance across zones.
        /// 
        /// *   This parameter must be specified when the instance resides in a VPC.
        /// *   If the instance runs SQL Server, you can change the VPC of the instance.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The vSwitch ID.
        /// 
        /// *   This parameter must be specified when the instance resides in a VPC. You can call the DescribeVSwitches operation to query existing vSwitches.
        /// *   If the instance runs PostgreSQL or SQL Server and a secondary zone is specified for the instance, you can specify multiple vSwitch IDs, each of which corresponds to a zone. Separate the vSwitch IDs with commas (,).
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the destination zone. You can call the DescribeRegions operation to query the most recent region list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// The secondary zone 1 of the instance.
        /// 
        /// >  This parameter must be configured if the instance runs RDS editions other than RDS Basic Edition.
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// The secondary zone 2 of the instance.
        /// 
        /// >  You can specify this parameter only for instances that run RDS Enterprise Edition.
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
