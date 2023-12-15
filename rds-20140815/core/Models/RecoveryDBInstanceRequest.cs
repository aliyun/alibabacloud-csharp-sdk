// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RecoveryDBInstanceRequest : TeaModel {
        /// <summary>
        /// The backup set ID. You can call the DescribeBackups operation to query the backup set ID.
        /// 
        /// If you specify this parameter, you do not need to specify **DBInstanceId**.
        /// 
        /// >  You must specify at least one of the **BackupId** or **RestoreTime** parameters.
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// The instance type of the new instance. For more information, see [Instance types](~~26312~~).
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The ID of the original instance.
        /// 
        /// > 
        /// 
        /// *   If you specify BackupId, you do not need to specify this parameter.
        /// 
        /// *   If you specify RestoreTime, you must also specify this parameter.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The storage capacity of the new instance. Unit: GB. For more information, see [Instance types](~~26312~~).
        /// 
        /// >  You must set this parameter to a value that is greater than or equal to the storage capacity of the original instance.
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// The storage type of the new instance. Valid values:
        /// 
        /// *   **local_ssd/ephemeral_ssd**: local SSD
        /// *   **cloud_ssd**: standard SSD.
        /// *   **cloud_essd**: enhanced SSD (ESSD)
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// The name of the database.
        /// 
        /// *   If you want to restore databases to a new instance, the value is in the format of `Original database name 1,New database name 2`.
        /// *   If you want to restore databases to an existing instance, the value is in the format of `{"Original database name 1":"New database name 1","Original database name 2":"New database name 2"`.
        /// </summary>
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public string DbNames { get; set; }

        /// <summary>
        /// The network type of the new instance. Valid values:
        /// 
        /// *   **Classic**
        /// *   **VPC**
        /// 
        /// By default, the new instance uses the same network type as the original instance.
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// The billing method of the new instance. Valid values:
        /// 
        /// *   **Postpaid**: pay-as-you-go.
        /// *   **Prepaid**: subscription.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The unit that is used to calculate the billing cycle of the new instance. This parameter takes effect only when you select the subscription billing method for the new instance. Valid values:
        /// 
        /// *   **Year**
        /// *   **Month**
        /// 
        /// > This parameter must be specified when **PayType** is set to **Prepaid**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The internal IP address of the new instance. The internal IP address must be within the CIDR block that is supported by the specified vSwitch. The system automatically assigns an internal IP address based on the values of the **VPCId** and **VSwitchId** parameters.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The point in time to which you want to restore data. The point in time must fall within the specified log backup retention period. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// If you specify this parameter, you must also specify **DBInstanceId**.
        /// 
        /// > You must specify at least one of **BackupId** and **RestoreTime**.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// The ID of the destination instance.
        /// </summary>
        [NameInMap("TargetDBInstanceId")]
        [Validation(Required=false)]
        public string TargetDBInstanceId { get; set; }

        /// <summary>
        /// The subscription duration of the instance. Valid values:
        /// 
        /// *   Valid values when **Period** is set to **Year**: **1 to 3**.****
        /// *   Valid values when **Period** is set to **Month**: **1 to 9**.****
        /// 
        /// > This parameter must be specified when PayType is set to **Prepaid**.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// The VPC ID of the new instance.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The vSwitch ID of the new instance. If you specify more than one vSwitch ID, you must separate the IDs with commas (,).
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
