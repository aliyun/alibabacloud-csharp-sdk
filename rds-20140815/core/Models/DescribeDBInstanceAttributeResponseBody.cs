// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details about the instance.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttribute : TeaModel {
                /// <summary>
                /// The maximum number of accounts that can be created on the instance.
                /// </summary>
                [NameInMap("AccountMaxQuantity")]
                [Validation(Required=false)]
                public int? AccountMaxQuantity { get; set; }

                /// <summary>
                /// The advanced features that are enabled for the instance. If multiple advanced features are enabled, the advanced features are separated by commas (,). This parameter is available only to instances that run **SQL Server**. Valid values:
                /// 
                /// *   **LinkedServer**
                /// *   **DistributeTransaction**
                /// </summary>
                [NameInMap("AdvancedFeatures")]
                [Validation(Required=false)]
                public string AdvancedFeatures { get; set; }

                /// <summary>
                /// The method that is used to update the minor engine version of the instance. Valid values:
                /// 
                /// *   **Auto:** automatic update.
                /// *   **Manual**: manual update. The minor engine version of the instance is forcefully updated only when the in-use minor engine version is phased out.
                /// </summary>
                [NameInMap("AutoUpgradeMinorVersion")]
                [Validation(Required=false)]
                public string AutoUpgradeMinorVersion { get; set; }

                /// <summary>
                /// The availability status of the instance in percentage.
                /// </summary>
                [NameInMap("AvailabilityValue")]
                [Validation(Required=false)]
                public string AvailabilityValue { get; set; }

                /// <summary>
                /// The configuration of the Babelfish feature for the ApsaraDB RDS for PostgreSQL instance.
                /// 
                /// >  This parameter is suitable only for ApsaraDB RDS for PostgreSQL instances for which Babelfish is enabled. For more information, see Introduction to Babelfish.[](~~428613~~)
                /// </summary>
                [NameInMap("BabelfishConfig")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeBabelfishConfig BabelfishConfig { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeBabelfishConfig : TeaModel {
                    /// <summary>
                    /// The switch to enable or disable Babelfish.
                    /// 
                    /// >  If Babelfish is enabled when you purchase an ApsaraDB RDS for PostgreSQL instance, this parameter is fixed as **true**.
                    /// </summary>
                    [NameInMap("BabelfishEnabled")]
                    [Validation(Required=false)]
                    public string BabelfishEnabled { get; set; }

                    /// <summary>
                    /// The migration mode for Babelfish. Valid values:
                    /// 
                    /// *   **single-db**
                    /// *   **multi-db**
                    /// 
                    /// >  For more information about migration modes for Babelfish, see [Migration modes](~~428613~~).
                    /// </summary>
                    [NameInMap("MigrationMode")]
                    [Validation(Required=false)]
                    public string MigrationMode { get; set; }

                }

                /// <summary>
                /// An invalid parameter. You can ignore this parameter.
                /// </summary>
                [NameInMap("BpeEnabled")]
                [Validation(Required=false)]
                public string BpeEnabled { get; set; }

                /// <summary>
                /// An invalid parameter. You can ignore this parameter.
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// The RDS edition of the instance. Valid values:
                /// 
                /// *   **Basic**: RDS Basic Edition
                /// *   **HighAvailability**: RDS High-availability Edition
                /// *   **cluster**: RDS Cluster Edition for MySQL
                /// *   **AlwaysOn**: RDS Cluster Edition for SQL Server
                /// *   **Finance**: RDS Enterprise Edition
                /// *   **Serverless_basic**: RDS Serverless Basic Edition
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The character set collation of the instance.
                /// </summary>
                [NameInMap("Collation")]
                [Validation(Required=false)]
                public string Collation { get; set; }

                /// <summary>
                /// The connection mode of the instance. Valid values:
                /// 
                /// *   **Standard**: standard mode
                /// *   **Safe**: database proxy mode
                /// </summary>
                [NameInMap("ConnectionMode")]
                [Validation(Required=false)]
                public string ConnectionMode { get; set; }

                /// <summary>
                /// The internal endpoint of the instance.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The type of the proxy that is used by the instance. Valid values:
                /// 
                /// *   **1**: shared proxy
                /// *   **2**: dedicated proxy
                /// 
                /// >  We recommend that you use the ProxyType parameter instead of this parameter.
                /// </summary>
                [NameInMap("ConsoleVersion")]
                [Validation(Required=false)]
                public string ConsoleVersion { get; set; }

                /// <summary>
                /// The creation time. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The version of the database engine.
                /// </summary>
                [NameInMap("CurrentKernelVersion")]
                [Validation(Required=false)]
                public string CurrentKernelVersion { get; set; }

                /// <summary>
                /// The information about the node in the cluster.
                /// </summary>
                [NameInMap("DBClusterNodes")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeDBClusterNodes DBClusterNodes { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeDBClusterNodes : TeaModel {
                    [NameInMap("DBClusterNode")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeDBClusterNodesDBClusterNode> DBClusterNode { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeDBClusterNodesDBClusterNode : TeaModel {
                        /// <summary>
                        /// The specification of the node.
                        /// </summary>
                        [NameInMap("ClassCode")]
                        [Validation(Required=false)]
                        public string ClassCode { get; set; }

                        [NameInMap("ClassType")]
                        [Validation(Required=false)]
                        public string ClassType { get; set; }

                        [NameInMap("Cpu")]
                        [Validation(Required=false)]
                        public string Cpu { get; set; }

                        [NameInMap("Memory")]
                        [Validation(Required=false)]
                        public string Memory { get; set; }

                        /// <summary>
                        /// The node ID.
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// The region ID.
                        /// </summary>
                        [NameInMap("NodeRegionId")]
                        [Validation(Required=false)]
                        public string NodeRegionId { get; set; }

                        /// <summary>
                        /// The role of the node. Valid values:
                        /// 
                        /// *   **primary**: primary node
                        /// *   **secondary**: secondary node
                        /// </summary>
                        [NameInMap("NodeRole")]
                        [Validation(Required=false)]
                        public string NodeRole { get; set; }

                        /// <summary>
                        /// The zone ID.
                        /// </summary>
                        [NameInMap("NodeZoneId")]
                        [Validation(Required=false)]
                        public string NodeZoneId { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// The number of CPU cores.
                /// </summary>
                [NameInMap("DBInstanceCPU")]
                [Validation(Required=false)]
                public string DBInstanceCPU { get; set; }

                /// <summary>
                /// The instance type of the instance. For more information, see [Primary ApsaraDB RDS instance types](~~26312~~).
                /// </summary>
                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

                /// <summary>
                /// The instance family to which the instance belongs. Valid values:
                /// 
                /// *   **s**: shared instance family
                /// *   **x**: general-purpose instance family
                /// *   **d**: dedicated instance family
                /// *   **h**: dedicated host instance family
                /// </summary>
                [NameInMap("DBInstanceClassType")]
                [Validation(Required=false)]
                public string DBInstanceClassType { get; set; }

                /// <summary>
                /// The description of the instance.
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The memory capacity of the instance. Unit: MB.
                /// </summary>
                [NameInMap("DBInstanceMemory")]
                [Validation(Required=false)]
                public long? DBInstanceMemory { get; set; }

                /// <summary>
                /// The type of the network over which the instance is connected. Valid values:
                /// 
                /// *   **Internet**: Internet
                /// *   **Intranet**: internal network
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// The status of the instance. For more information, see [Instance states](~~26315~~).
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// The storage capacity of the instance. Unit: GB.
                /// </summary>
                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public int? DBInstanceStorage { get; set; }

                /// <summary>
                /// The storage type of the instance. Valid values:
                /// 
                /// *   **local_ssd** and **ephemeral_ssd**: local SSD
                /// *   **cloud_ssd**: standard SSD
                /// *   **cloud_essd**: enhanced SSD (ESSD)
                /// </summary>
                [NameInMap("DBInstanceStorageType")]
                [Validation(Required=false)]
                public string DBInstanceStorageType { get; set; }

                /// <summary>
                /// The type of the instance. Valid values:
                /// 
                /// *   **Primary**: primary instance
                /// *   **Readonly**: read-only instance
                /// *   **Guard**: disaster recovery instance
                /// *   **Temp**: temporary instance
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// The maximum number of databases that can be created on the instance.
                /// </summary>
                [NameInMap("DBMaxQuantity")]
                [Validation(Required=false)]
                public int? DBMaxQuantity { get; set; }

                /// <summary>
                /// The ID of the dedicated cluster.
                /// </summary>
                [NameInMap("DedicatedHostGroupId")]
                [Validation(Required=false)]
                public string DedicatedHostGroupId { get; set; }

                /// <summary>
                /// Indicates whether the release protection feature is enabled. Valid values:
                /// 
                /// *   **true**: The feature is enabled.
                /// *   **false**: The feature is disabled.
                /// </summary>
                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// The database engine of the instance. Valid values:
                /// 
                /// *   **MySQL**
                /// *   **PostgreSQL**
                /// *   **SQLServer**
                /// *   **MariaDB**
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The database engine version of the serverless instance.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The expiration time. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// 
                /// **
                /// 
                /// **Description** Pay-as-you-go instances never expire.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The extended information of the instance.
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeExtra Extra { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeExtra : TeaModel {
                    /// <summary>
                    /// The IDs of the instances.
                    /// </summary>
                    [NameInMap("DBInstanceIds")]
                    [Validation(Required=false)]
                    public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeExtraDBInstanceIds DBInstanceIds { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeExtraDBInstanceIds : TeaModel {
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public List<string> DBInstanceId { get; set; }

                    }

                }

                /// <summary>
                /// The name of the dedicated cluster to which the instance belongs. This parameter is returned only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition.
                /// </summary>
                [NameInMap("GeneralGroupName")]
                [Validation(Required=false)]
                public string GeneralGroupName { get; set; }

                /// <summary>
                /// The ID of the disaster recovery instance that is attached to the instance.
                /// </summary>
                [NameInMap("GuardDBInstanceId")]
                [Validation(Required=false)]
                public string GuardDBInstanceId { get; set; }

                /// <summary>
                /// The type of the IP address. Only **IPv4** addresses are supported.
                /// </summary>
                [NameInMap("IPType")]
                [Validation(Required=false)]
                public string IPType { get; set; }

                /// <summary>
                /// The ID of the instance from which the incremental data comes. The incremental data of a disaster recovery instance or read-only instance comes from its primary instance. If this parameter is not returned, the instance is a primary instance.
                /// </summary>
                [NameInMap("IncrementSourceDBInstanceId")]
                [Validation(Required=false)]
                public string IncrementSourceDBInstanceId { get; set; }

                /// <summary>
                /// The network type of the instance. Valid values:
                /// 
                /// *   **Classic**
                /// *   **VPC**
                /// </summary>
                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                /// <summary>
                /// The architecture type of the instance. Valid values:
                /// 
                /// *   **x86**
                /// *   **arm**
                /// </summary>
                [NameInMap("InstructionSetArch")]
                [Validation(Required=false)]
                public string InstructionSetArch { get; set; }

                /// <summary>
                /// The latest minor engine version that is supported by the instance.
                /// </summary>
                [NameInMap("LatestKernelVersion")]
                [Validation(Required=false)]
                public string LatestKernelVersion { get; set; }

                /// <summary>
                /// The lock mode of the instance. Valid values:
                /// 
                /// *   **Unlock**: The instance is not locked.
                /// *   **ManualLock**: The instance is manually locked.
                /// *   **LockByExpiration**: The instance is automatically locked due to instance expiration.
                /// *   **LockByRestoration**: The instance is automatically locked due to instance restoration.
                /// *   **LockByDiskQuota**: The instance is automatically locked due to exhausted storage.
                /// *   **LockReadInstanceByDiskQuota**: The instance is a read-only instance and is automatically locked due to exhausted storage.
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// The reason why the instance was locked.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// The maintenance window of the instance. The time is displayed in UTC. Take note that the maintenance window displayed in the ApsaraDB RDS console is equal to the value of this parameter plus 8 hours.
                /// </summary>
                [NameInMap("MaintainTime")]
                [Validation(Required=false)]
                public string MaintainTime { get; set; }

                /// <summary>
                /// The ID of the primary instance.
                /// 
                /// **
                /// 
                /// **Description** If this parameter is not returned, the instance is the primary instance.
                /// </summary>
                [NameInMap("MasterInstanceId")]
                [Validation(Required=false)]
                public string MasterInstanceId { get; set; }

                /// <summary>
                /// The zone ID of the primary instance.
                /// </summary>
                [NameInMap("MasterZone")]
                [Validation(Required=false)]
                public string MasterZone { get; set; }

                /// <summary>
                /// The maximum number of concurrent connections.
                /// </summary>
                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public int? MaxConnections { get; set; }

                /// <summary>
                /// The maximum I/O throughput. Unit: MB/s.
                /// </summary>
                [NameInMap("MaxIOMBPS")]
                [Validation(Required=false)]
                public int? MaxIOMBPS { get; set; }

                /// <summary>
                /// The maximum number of I/O requests per second.
                /// </summary>
                [NameInMap("MaxIOPS")]
                [Validation(Required=false)]
                public int? MaxIOPS { get; set; }

                /// <summary>
                /// Indicates whether PgBouncer is enabled.
                /// 
                /// >  This parameter is returned only for RDS instances that run PostgreSQL. If PgBouncer is enabled, the return value is **true**.
                /// </summary>
                [NameInMap("PGBouncerEnabled")]
                [Validation(Required=false)]
                public string PGBouncerEnabled { get; set; }

                /// <summary>
                /// The billing method of the instance. Valid values:
                /// 
                /// *   **Postpaid**: pay-as-you-go
                /// *   **Prepaid**: subscription
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// The port that is used to connect to the instance over an internal network.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The type of the proxy that is supported by the instance. Valid values:
                /// 
                /// *   **0**: The instance does not support database proxies.
                /// *   **1**: The instance supports shared proxies, with which the instance runs in multi-tenant mode.
                /// *   **2**: The instance supports dedicated proxies, with which the instance runs in single-tenant mode.
                /// </summary>
                [NameInMap("ProxyType")]
                [Validation(Required=false)]
                public int? ProxyType { get; set; }

                /// <summary>
                /// The IDs of the read-only instances that are attached to the primary instance.
                /// </summary>
                [NameInMap("ReadOnlyDBInstanceIds")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeReadOnlyDBInstanceIds ReadOnlyDBInstanceIds { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeReadOnlyDBInstanceIds : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeReadOnlyDBInstanceIdsReadOnlyDBInstanceId> ReadOnlyDBInstanceId { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeReadOnlyDBInstanceIdsReadOnlyDBInstanceId : TeaModel {
                        /// <summary>
                        /// The ID of the read-only instance.
                        /// </summary>
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                    }

                }

                /// <summary>
                /// The latency at which the system replicates data to read-only instances. The system replicates data from the primary instance to the read-only instances at the latency that is specified by the **ReadonlyInstanceSQLDelayedTime** parameter. Unit: seconds.
                /// </summary>
                [NameInMap("ReadonlyInstanceSQLDelayedTime")]
                [Validation(Required=false)]
                public string ReadonlyInstanceSQLDelayedTime { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The IP addresses in the IP address whitelist.
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                /// <summary>
                /// The whitelist mode of the instance. Valid values:
                /// 
                /// *   **normal**: standard whitelist mode
                /// *   **safety**: enhanced whitelist mode
                /// </summary>
                [NameInMap("SecurityIPMode")]
                [Validation(Required=false)]
                public string SecurityIPMode { get; set; }

                /// <summary>
                /// The settings of the serverless instance.
                /// </summary>
                [NameInMap("ServerlessConfig")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeServerlessConfig ServerlessConfig { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeServerlessConfig : TeaModel {
                    /// <summary>
                    /// Indicates whether the automatic start and stop feature is enabled for the serverless instance. Valid values:
                    /// 
                    /// *   **true**: The feature is enabled.
                    /// *   **false** (default): The feature is disabled.
                    /// 
                    /// >  After the automatic suspension feature is enabled, if no connections to the instance are established within 10 minutes, the instance is suspended. After a connection to the instance is established, the instance is automatically resumed.
                    /// </summary>
                    [NameInMap("AutoPause")]
                    [Validation(Required=false)]
                    public bool? AutoPause { get; set; }

                    /// <summary>
                    /// The maximum number of RCUs.
                    /// </summary>
                    [NameInMap("ScaleMax")]
                    [Validation(Required=false)]
                    public double? ScaleMax { get; set; }

                    /// <summary>
                    /// The minimum number of RDS Capacity Units (RCUs).
                    /// </summary>
                    [NameInMap("ScaleMin")]
                    [Validation(Required=false)]
                    public double? ScaleMin { get; set; }

                    /// <summary>
                    /// Indicates whether the forced scaling feature is enabled for the serverless instance.
                    /// 
                    /// *   **true**: The feature is enabled.
                    /// *   **false** (default): The feature is disabled.
                    /// 
                    /// >  In most cases, ApsaraDB RDS automatically scales in or out the RCUs of a serverless instance based on business requirements in real time. In rare cases, the scaling does not take effect in real time. You can enable the forced scaling feature to forcefully scales in or out the RCUs of the instance.
                    /// </summary>
                    [NameInMap("SwitchForce")]
                    [Validation(Required=false)]
                    public bool? SwitchForce { get; set; }

                }

                /// <summary>
                /// Information about the zone of the secondary instance.
                /// </summary>
                [NameInMap("SlaveZones")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeSlaveZones SlaveZones { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeSlaveZones : TeaModel {
                    [NameInMap("SlaveZone")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeSlaveZonesSlaveZone> SlaveZone { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeSlaveZonesSlaveZone : TeaModel {
                        /// <summary>
                        /// The zone ID.
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether the instance supports privileged accounts, such as the system administrator (SA) account, the Active Directory (AD) account, and the host account.
                /// 
                /// *   **Enable**: Privileged accounts are supported.
                /// *   **Disabled**: Privileged accounts are not supported.
                /// </summary>
                [NameInMap("SuperPermissionMode")]
                [Validation(Required=false)]
                public string SuperPermissionMode { get; set; }

                /// <summary>
                /// The ID of the temporary instance that is attached to the instance.
                /// </summary>
                [NameInMap("TempDBInstanceId")]
                [Validation(Required=false)]
                public string TempDBInstanceId { get; set; }

                /// <summary>
                /// The time zone of the instance.
                /// </summary>
                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

                /// <summary>
                /// The information about the exception that is detected on the instance. This parameter is returned only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition.
                /// </summary>
                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

                /// <summary>
                /// The severity level of the exception that is detected on the instance. This parameter is returned only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition. Valid values:
                /// 
                /// *   **1**: The instance is normal.
                /// *   **2**: The specifications of the read-only instances do not match the specifications of the primary instance, and the performance is affected. You must adjust the specifications of these instances based on your business requirements.
                /// </summary>
                [NameInMap("TipsLevel")]
                [Validation(Required=false)]
                public int? TipsLevel { get; set; }

                /// <summary>
                /// The vSwitch ID.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The VPC ID.
                /// </summary>
                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC).
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone ID of the instance.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// An internal parameter. You can ignore this parameter.
                /// </summary>
                [NameInMap("kindCode")]
                [Validation(Required=false)]
                public string KindCode { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
