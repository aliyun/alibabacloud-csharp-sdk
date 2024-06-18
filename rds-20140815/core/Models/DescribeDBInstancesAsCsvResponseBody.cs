// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesAsCsvResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the fields in **DBInstanceAttribute**.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesAsCsvResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesAsCsvResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesAsCsvResponseBodyItemsDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeDBInstancesAsCsvResponseBodyItemsDBInstanceAttribute : TeaModel {
                /// <summary>
                /// The maximum number of accounts.
                /// </summary>
                [NameInMap("AccountMaxQuantity")]
                [Validation(Required=false)]
                public int? AccountMaxQuantity { get; set; }

                /// <summary>
                /// The type of the account.
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// The service availability of the instance in percentage.
                /// </summary>
                [NameInMap("AvailabilityValue")]
                [Validation(Required=false)]
                public string AvailabilityValue { get; set; }

                /// <summary>
                /// The category of the instance.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The connection mode of the instance. Valid values:
                /// 
                /// *   **Performance**: standard mode.
                /// *   **Safety**: enhanced mode
                /// </summary>
                [NameInMap("ConnectionMode")]
                [Validation(Required=false)]
                public string ConnectionMode { get; set; }

                /// <summary>
                /// The internal endpoint.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The number of CPU cores.
                /// </summary>
                [NameInMap("DBInstanceCPU")]
                [Validation(Required=false)]
                public string DBInstanceCPU { get; set; }

                /// <summary>
                /// The instance type of the instance.
                /// </summary>
                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

                /// <summary>
                /// The instance family.
                /// </summary>
                [NameInMap("DBInstanceClassType")]
                [Validation(Required=false)]
                public string DBInstanceClassType { get; set; }

                /// <summary>
                /// The instance description.
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
                /// The network type of the instance. Valid values:
                /// 
                /// *   **Internet**
                /// *   **Intranet**
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// The instance status.
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
                /// The instance type. Valid values:
                /// 
                /// *   **Primary**: primary instance
                /// *   **ReadOnly**: read-only instance
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
                /// The database engine of the instance.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The engine version.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The expiration time.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// A deprecated parameter. You do not need to specify this parameter.
                /// </summary>
                [NameInMap("ExportKey")]
                [Validation(Required=false)]
                public string ExportKey { get; set; }

                /// <summary>
                /// The ID of the disaster recovery instance that is attached to the primary instance.
                /// </summary>
                [NameInMap("GuardDBInstanceId")]
                [Validation(Required=false)]
                public string GuardDBInstanceId { get; set; }

                /// <summary>
                /// The ID of the instance from which incremental data comes. The incremental data of a disaster recovery instance comes from its primary instance. The incremental data of a read-only instance comes from its primary instance. If this parameter is not returned, the instance is a primary instance.
                /// </summary>
                [NameInMap("IncrementSourceDBInstanceId")]
                [Validation(Required=false)]
                public string IncrementSourceDBInstanceId { get; set; }

                /// <summary>
                /// The network type.
                /// </summary>
                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                /// <summary>
                /// The lock mode of the instance.
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
                /// The maintenance window of the instance. The time follows the ISO 8601 standard and is displayed in UTC. In the ApsaraDB RDS console, the maintenance window is displayed in UTC+8.
                /// </summary>
                [NameInMap("MaintainTime")]
                [Validation(Required=false)]
                public string MaintainTime { get; set; }

                /// <summary>
                /// The primary instance ID.
                /// </summary>
                [NameInMap("MasterInstanceId")]
                [Validation(Required=false)]
                public string MasterInstanceId { get; set; }

                /// <summary>
                /// The maximum number of concurrent connections.
                /// </summary>
                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public int? MaxConnections { get; set; }

                /// <summary>
                /// The maximum number of I/O requests per second.
                /// </summary>
                [NameInMap("MaxIOPS")]
                [Validation(Required=false)]
                public int? MaxIOPS { get; set; }

                /// <summary>
                /// The billing method of the instance.
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
                /// The latency of data replication from the primary instance to the read-only instance. This parameter is valid for read-only instances.
                /// </summary>
                [NameInMap("ReadDelayTime")]
                [Validation(Required=false)]
                public string ReadDelayTime { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The IP addresses in the whitelist.
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                /// <summary>
                /// A deprecated parameter. You do not need to specify this parameter.
                /// </summary>
                [NameInMap("SlaveZones")]
                [Validation(Required=false)]
                public DescribeDBInstancesAsCsvResponseBodyItemsDBInstanceAttributeSlaveZones SlaveZones { get; set; }
                public class DescribeDBInstancesAsCsvResponseBodyItemsDBInstanceAttributeSlaveZones : TeaModel {
                    [NameInMap("slaveRegion")]
                    [Validation(Required=false)]
                    public List<string> SlaveRegion { get; set; }

                }

                /// <summary>
                /// N/A.
                /// </summary>
                [NameInMap("SupportUpgradeAccountType")]
                [Validation(Required=false)]
                public string SupportUpgradeAccountType { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// The ID of the temporary instance that is attached to the primary instance.
                /// </summary>
                [NameInMap("TempDBInstanceId")]
                [Validation(Required=false)]
                public string TempDBInstanceId { get; set; }

                /// <summary>
                /// The vSwitch ID.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The virtual private cloud (VPC) ID.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

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
