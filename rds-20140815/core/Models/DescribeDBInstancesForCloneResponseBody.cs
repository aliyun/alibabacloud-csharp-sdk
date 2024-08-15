// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesForCloneResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details about the instances.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesForCloneResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesForCloneResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesForCloneResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDBInstancesForCloneResponseBodyItemsDBInstance : TeaModel {
                /// <summary>
                /// The RDS edition of the instance. Valid values:
                /// 
                /// *   **Basic**: RDS Basic Edition
                /// *   **HighAvailability**: RDS High-availability Edition
                /// *   **Finance**: RDS Enterprise Edition
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

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
                /// The time when the instance was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The instance type of the instance. For more information, see [Instance types](https://help.aliyun.com/document_detail/26312.html).
                /// </summary>
                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

                /// <summary>
                /// The name of the instance. It must be 2 to 256 characters in length. The value can contain letters, digits, underscores (_), and hyphens (-). The value must start with a letter.
                /// 
                /// > The value cannot start with http:// or https://.
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The network connection type of the instance. Valid values:
                /// 
                /// *   **Internet**
                /// *   **Intranet**
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// The status of the instance. For more information, see [Instance state table](https://help.aliyun.com/document_detail/26315.html).
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// The storage type of the instance. Valid values:
                /// 
                /// *   **local_ssd/ephemeral_ssd**: local SSD
                /// *   **cloud_ssd**: standard SSD.
                /// *   **cloud_essd**: enhanced SSD (ESSD)
                /// </summary>
                [NameInMap("DBInstanceStorageType")]
                [Validation(Required=false)]
                public string DBInstanceStorageType { get; set; }

                /// <summary>
                /// The role of the instance. Valid values:
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
                /// The time when the instance was destroyed. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("DestroyTime")]
                [Validation(Required=false)]
                public string DestroyTime { get; set; }

                /// <summary>
                /// The database engine of the instance. Valid values:
                /// 
                /// *   MySQL
                /// *   SQLServer
                /// *   PostgreSQL
                /// *   PPAS
                /// *   MariaDB
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The version of the database engine.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The time when the instance expired. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The ID of the disaster recovery instance. This parameter is returned only when the instance is a primary instance and has a disaster recovery instance.
                /// </summary>
                [NameInMap("GuardDBInstanceId")]
                [Validation(Required=false)]
                public string GuardDBInstanceId { get; set; }

                /// <summary>
                /// The ID of the instance role.
                /// </summary>
                [NameInMap("InsId")]
                [Validation(Required=false)]
                public int? InsId { get; set; }

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
                /// The lock method of the instance. Valid values:
                /// 
                /// *   **Unlock**: The instance is not locked.
                /// *   **ManualLock**: The instance is manually locked.
                /// *   **LockByExpiration**: The instance is automatically locked after it expires.
                /// *   **LockByRestoration**: The instance is automatically locked before a rollback.
                /// *   **LockByDiskQuota**: The instance is automatically locked because its storage capacity is exhausted and the instance is inaccessible.
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
                /// The ID of the primary instance. If the value of this parameter is null, the instance is a primary instance.
                /// </summary>
                [NameInMap("MasterInstanceId")]
                [Validation(Required=false)]
                public string MasterInstanceId { get; set; }

                /// <summary>
                /// Indicates whether multi-region deployment is used. Valid values:
                /// 
                /// *   **true**: Multi-region deployment is used.
                /// *   **false**: Multi-region deployment is not used.
                /// </summary>
                [NameInMap("MutriORsignle")]
                [Validation(Required=false)]
                public bool? MutriORsignle { get; set; }

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
                /// An array consisting of the IDs of the read-only instances that are attached to the primary instance.
                /// </summary>
                [NameInMap("ReadOnlyDBInstanceIds")]
                [Validation(Required=false)]
                public DescribeDBInstancesForCloneResponseBodyItemsDBInstanceReadOnlyDBInstanceIds ReadOnlyDBInstanceIds { get; set; }
                public class DescribeDBInstancesForCloneResponseBodyItemsDBInstanceReadOnlyDBInstanceIds : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesForCloneResponseBodyItemsDBInstanceReadOnlyDBInstanceIdsReadOnlyDBInstanceId> ReadOnlyDBInstanceId { get; set; }
                    public class DescribeDBInstancesForCloneResponseBodyItemsDBInstanceReadOnlyDBInstanceIdsReadOnlyDBInstanceId : TeaModel {
                        /// <summary>
                        /// The ID of the read-only instance.
                        /// </summary>
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                    }

                }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// None.
                /// </summary>
                [NameInMap("ReplicateId")]
                [Validation(Required=false)]
                public string ReplicateId { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the temporary instance.
                /// </summary>
                [NameInMap("TempDBInstanceId")]
                [Validation(Required=false)]
                public string TempDBInstanceId { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the instance in the VPC.
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

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
