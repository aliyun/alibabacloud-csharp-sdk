// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CloneDBInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the automatic payment feature for the new instance. Valid values:
        /// 
        /// 1.  **true**: enables the feature. You must make sure that your account balance is sufficient.
        /// 2.  **false**: disables the feature. An unpaid order is generated.
        /// 
        /// >  Default value: true. If your account balance is insufficient, you can set the AutoPay parameter to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to complete the payment.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The backup set ID.
        /// 
        /// You can call the DescribeBackups operation to query the backup set ID.
        /// 
        /// >  You must specify at least one of the **BackupId** or **RestoreTime** parameters.
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// The type of backup that is used to restore the data of the original instance. Valid values:
        /// 
        /// *   **FullBackup**
        /// *   **IncrementalBackup**
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// A reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("BpeEnabled")]
        [Validation(Required=false)]
        public string BpeEnabled { get; set; }

        /// <summary>
        /// An invalid parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// The RDS edition of the instance. Valid values:
        /// 
        /// *   **Basic**: RDS Basic Edition.
        /// *   **HighAvailability**: RDS High-availability Edition.
        /// *   **AlwaysOn**: RDS Cluster Edition for ApsaraDB RDS for SQL Server.
        /// *   **cluster**: RDS Cluster Edition for ApsaraDB RDS for MySQL.
        /// *   **Finance**: RDS Enterprise Edition. This edition is available only on the China site (aliyun.com).
        /// 
        /// **Serverless instances**
        /// 
        /// *   **serverless_basic**: RDS Basic Edition. This edition is available only for serverless instances that run MySQL and PostgreSQL.
        /// *   **serverless_standard**: RDS High-availability Edition for ApsaraDB RDS for MySQL
        /// *   **serverless_ha**: RDS High-availability Edition for ApsaraDB RDS for SQL Server
        /// 
        /// >  You do not need to configure this parameter. The value of this parameter is the same as that of the original instance.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance type of the new instance. For information, see [Primary ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/26312.html).
        /// 
        /// > By default, the new instance uses the same instance type as the original primary instance.
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The storage capacity of the new instance. Unit: GB. You can increase the storage capacity in increments of 5 GB. For more information, see [Primary ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/26312.html).
        /// 
        /// > By default, the new instance has the same storage capacity as the original primary instance.
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// The storage type of the new instance. Valid values:
        /// 
        /// *   **general_essd** (recommend): general Enterprise SSD (ESSD)
        /// *   **local_ssd**: local SSD
        /// *   **cloud_ssd**: standard SSD
        /// *   **cloud_essd**: performance level 1 (PL1) ESSD
        /// *   **cloud_essd2**: PL2 ESSD
        /// *   **cloud_essd3**: PL3 ESSD
        /// 
        /// >  Serverless instances support only PL1 ESSDs and general ESSDs.
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// The name of the database. If you specify more than one database, the value is in the following format: `Original database name 1,Original database name 2`.
        /// </summary>
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public string DbNames { get; set; }

        /// <summary>
        /// The ID of the dedicated cluster.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// Specifies whether to enable the release protection feature for the new instance. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// The network type of the new instance. Valid values:
        /// 
        /// *   **VPC**
        /// *   **Classic**
        /// 
        /// > By default, the new instance has the same network type as the original primary instance.
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("IoAccelerationEnabled")]
        [Validation(Required=false)]
        public string IoAccelerationEnabled { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **Postpaid**: pay-as-you-go.
        /// *   **Prepaid**: subscription.
        /// *   **Serverless**: serverless. This value is not supported for instances that run MariaDB. For more information, see [Overview of serverless ApsaraDB RDS for MySQL instances](https://help.aliyun.com/document_detail/411291.html), [Overview of serverless ApsaraDB RDS for SQL Server instances](https://help.aliyun.com/document_detail/604344.html), and [Overview of serverless ApsaraDB RDS for PostgreSQL instances](https://help.aliyun.com/document_detail/607742.html).
        /// 
        /// This parameter is required.
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
        /// >  If you set the PayType parameter to **Prepaid**, you must specify this parameter.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The internal IP address of the new instance, which must be within the CIDR block supported by the specified vSwitch. The system automatically assigns an internal IP address based on the values of the **VPCId** and **VSwitchId** parameters.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to restore only the databases and tables that you specify. The value **1** specifies to restore only the specified databases and tables. If you do not want to restore only the specified databases or tables, you do not need to specify this parameter.
        /// </summary>
        [NameInMap("RestoreTable")]
        [Validation(Required=false)]
        public string RestoreTable { get; set; }

        /// <summary>
        /// The point in time to which you want to restore data. The point in time must fall within the specified backup retention period. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > You must specify at least one of the **BackupId** and **RestoreTime** parameters.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// The specifications for the serverless instance. You must specify this parameter only when you restore data to a new serverless instance.
        /// 
        /// >  This parameter is available only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public CloneDBInstanceRequestServerlessConfig ServerlessConfig { get; set; }
        public class CloneDBInstanceRequestServerlessConfig : TeaModel {
            /// <summary>
            /// Specifies whether to enable the automatic start and stop feature for the serverless ApsaraDB RDS for MySQL instance. After the automatic start and stop feature is enabled, if no connections to the instance are established within 10 minutes, the instance is suspended. After a connection is established to the instance, the instance is automatically resumed. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > *   This parameter is supported only for serverless ApsaraDB RDS for MySQL instances.
            /// > *   This parameter is available only on the China site (aliyun.com).
            /// </summary>
            [NameInMap("AutoPause")]
            [Validation(Required=false)]
            public bool? AutoPause { get; set; }

            /// <summary>
            /// The maximum number of RDS Capacity Units (RCUs). Valid values:
            /// 
            /// *   Serverless ApsaraDB RDS for MySQL instances: **1 to 8**
            /// *   Serverless ApsaraDB RDS for SQL Server instances: **2 to 8**
            /// *   Serverless ApsaraDB RDS for PostgreSQL instances: **1 to 12**
            /// 
            /// > *   The value of this parameter must be greater than or equal to the value of **MinCapacity** and can be specified only to an **integer**.
            /// > *   This parameter is available only on the China site (aliyun.com).
            /// </summary>
            [NameInMap("MaxCapacity")]
            [Validation(Required=false)]
            public double? MaxCapacity { get; set; }

            /// <summary>
            /// The minimum number of RCUs. Valid values:
            /// 
            /// *   Serverless ApsaraDB RDS for MySQL instances: **0.5 to 8**.
            /// *   Serverless ApsaraDB RDS for SQL Server instances: **2 to 8**. Only integers are supported.
            /// *   Serverless ApsaraDB RDS for PostgreSQL instances: **0.5 to 12**.
            /// 
            /// > *   The value of this parameter must be less than or equal to the value of **MaxCapacity**.
            /// > *   This parameter is available only on the China site (aliyun.com).
            /// </summary>
            [NameInMap("MinCapacity")]
            [Validation(Required=false)]
            public double? MinCapacity { get; set; }

            /// <summary>
            /// Specifies whether to enable the forced scaling feature for the serverless ApsaraDB RDS for MySQL instance. In most cases, ApsaraDB RDS automatically scales in or out the RCUs of a serverless instance based on business requirements in real time. In rare cases, the scaling does not take effect in real time. You can enable the forced scaling feature to forcefully scales in or out the RCUs of the instance. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > 
            /// 
            /// *   This parameter is supported only for serverless ApsaraDB RDS for MySQL instances.
            /// 
            /// *   This parameter is available only on the China site (aliyun.com).
            /// </summary>
            [NameInMap("SwitchForce")]
            [Validation(Required=false)]
            public bool? SwitchForce { get; set; }

        }

        /// <summary>
        /// The information about the database and table that you want to restore. The value is in the following format: `[{"type":"db","name":"Name of Database 1","newname":"New name of Database 1","tables":[{"type":"table","name":"Name of Table 1 in Database 1","newname":"New name of Table 1"},{"type":"table","name":"Name of Table 2 in Database 1","newname":"New name of Table 2"}]},{"type":"db","name":"Name of Database 2","newname":"New name of Database 2","tables":[{"type":"table","name":"Name of Table 1 in Database 2","newname":"New name of Table 1"},{"type":"table","name":"Name of Table 2 in Database 2","newname":"New name of Table 2"}]}]`
        /// </summary>
        [NameInMap("TableMeta")]
        [Validation(Required=false)]
        public string TableMeta { get; set; }

        /// <summary>
        /// The subscription duration of the new instance. Valid values:
        /// 
        /// *   If you set the **Period** parameter to **Year**, the value of the UsedTime parameter ranges from **1 to 3**.
        /// *   If you set the **Period** parameter to **Month**, the value of the UsedTime parameter ranges from **1 to 9**.
        /// 
        /// > If you set the PayType parameter to **Prepaid**, you must also specify this parameter.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC).
        /// 
        /// >  Make sure that the VPC belongs to the required region.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The ID of the vSwitch. The vSwitch must belong to the zone that is specified by **ZoneId**.
        /// 
        /// *   If you set **InstanceNetworkType** to **VPC**, you must also specify this parameter.
        /// *   If you specify the **ZoneSlaveId1** parameter, you must specify the IDs of two vSwitches for this parameter and separate the IDs with a comma (,).
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The zone ID of the primary instance. You can call the DescribeRegions operation to query the zone ID.
        /// 
        /// >  Set this value to the zone ID of the original instance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// The zone ID of the secondary instance. If you set the ZoneIdSlave1 parameter and the **ZoneId** parameter to the same value, the single-zone deployment method is used. If you set the ZoneIdSlave1 parameter and the **ZoneId** parameter to different values, the multi-zone deployment method is used.
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// The zone ID of the logger instance. If you set the ZoneIdSlave2 parameter to the same value as the **ZoneId** parameter, the single-zone deployment method is used. If you set the ZoneIdSlave2 parameter to a different value from the **ZoneId** parameter, the multi-zone deployment method is used.
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
