// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
        /// <summary>
        /// The details of the instance.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDBInstancesResponseBodyItemsDBInstance : TeaModel {
                /// <summary>
                /// Indicates whether the buffer pool extension (BPE) feature is enabled. Valid values:
                /// 
                /// *   **1**
                /// *   **0**
                /// </summary>
                [NameInMap("BpeEnabled")]
                [Validation(Required=false)]
                public string BpeEnabled { get; set; }

                /// <summary>
                /// Indicates whether the I/O burst feature is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// The RDS edition of the instance. Valid values:
                /// 
                /// *   **Basic**: RDS Basic Edition
                /// *   **HighAvailability**: RDS High-availability Edition
                /// *   **Finance**: RDS Enterprise Edition
                /// 
                /// >  This parameter is returned only when the **InstanceLevel** parameter is set to **1**.
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
                /// The endpoint of the instance.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The creation time of the instance. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The instance type of the instance. For information, see [Primary ApsaraDB RDS instance types](~~26312~~).
                /// </summary>
                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

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
                /// The type of the network connection to the instance. Valid values:
                /// 
                /// *   **Internet**
                /// *   **Intranet**
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
                /// The storage type of the instance.
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
                /// The ID of the dedicated cluster.
                /// </summary>
                [NameInMap("DedicatedHostGroupId")]
                [Validation(Required=false)]
                public string DedicatedHostGroupId { get; set; }

                /// <summary>
                /// The name of the dedicated cluster to which the instance belongs.
                /// </summary>
                [NameInMap("DedicatedHostGroupName")]
                [Validation(Required=false)]
                public string DedicatedHostGroupName { get; set; }

                /// <summary>
                /// The ID of the host on which the logger instance resides.
                /// </summary>
                [NameInMap("DedicatedHostIdForLog")]
                [Validation(Required=false)]
                public string DedicatedHostIdForLog { get; set; }

                /// <summary>
                /// The ID of the host on which the primary instance resides.
                /// </summary>
                [NameInMap("DedicatedHostIdForMaster")]
                [Validation(Required=false)]
                public string DedicatedHostIdForMaster { get; set; }

                /// <summary>
                /// The ID of the host on which the secondary instance resides.
                /// </summary>
                [NameInMap("DedicatedHostIdForSlave")]
                [Validation(Required=false)]
                public string DedicatedHostIdForSlave { get; set; }

                /// <summary>
                /// The name of the host on which the logger instance resides.
                /// </summary>
                [NameInMap("DedicatedHostNameForLog")]
                [Validation(Required=false)]
                public string DedicatedHostNameForLog { get; set; }

                /// <summary>
                /// The name of the host on which the primary instance resides.
                /// </summary>
                [NameInMap("DedicatedHostNameForMaster")]
                [Validation(Required=false)]
                public string DedicatedHostNameForMaster { get; set; }

                /// <summary>
                /// The name of the host on which the secondary instance resides.
                /// </summary>
                [NameInMap("DedicatedHostNameForSlave")]
                [Validation(Required=false)]
                public string DedicatedHostNameForSlave { get; set; }

                /// <summary>
                /// The zone ID of the host on which the logger instance resides.
                /// </summary>
                [NameInMap("DedicatedHostZoneIdForLog")]
                [Validation(Required=false)]
                public string DedicatedHostZoneIdForLog { get; set; }

                /// <summary>
                /// The zone ID of the host on which the primary instance resides.
                /// </summary>
                [NameInMap("DedicatedHostZoneIdForMaster")]
                [Validation(Required=false)]
                public string DedicatedHostZoneIdForMaster { get; set; }

                /// <summary>
                /// The zone ID of the host on which the secondary instance resides.
                /// </summary>
                [NameInMap("DedicatedHostZoneIdForSlave")]
                [Validation(Required=false)]
                public string DedicatedHostZoneIdForSlave { get; set; }

                /// <summary>
                /// Indicates whether the release protection feature is enabled for the instance. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// The time when the instance was destroyed. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("DestroyTime")]
                [Validation(Required=false)]
                public string DestroyTime { get; set; }

                /// <summary>
                /// The database engine of the instance.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The database engine version.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The expiration time of the instance. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// 
                /// >  Pay-as-you-go instances never expire.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The name of the dedicated cluster to which the instance belongs. This parameter is returned only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition.
                /// </summary>
                [NameInMap("GeneralGroupName")]
                [Validation(Required=false)]
                public string GeneralGroupName { get; set; }

                /// <summary>
                /// The ID of the disaster recovery instance. This parameter is returned only when the instance is a primary instance and has a disaster recovery instance.
                /// </summary>
                [NameInMap("GuardDBInstanceId")]
                [Validation(Required=false)]
                public string GuardDBInstanceId { get; set; }

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
                /// The lock mode of the instance. Valid values:
                /// 
                /// *   **Unlock**: The instance is not locked.
                /// *   **ManualLock**: The instance is manually locked.
                /// *   **LockByExpiration**: The instance is automatically locked due to instance expiration.
                /// *   **LockByRestoration**: The instance is automatically locked before the instance is rolled back.
                /// *   **LockByDiskQuota**: The instance is automatically locked due to exhausted storage capacity.
                /// *   **Released**: The instance is released. After an instance is released, the instance cannot be unlocked. You can only restore the backup data of the instance to a new instance. This process requires a long period of time.
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
                /// Indicates whether the multi-zone deployment method is used for the instance. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  If the multi-zone deployment method is used for the instance, the zone ID of the instance contains MAZ. Example: `cn-hangzhou-MAZ10(h,i)`.
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
                /// An array that consists of the IDs of the read-only instances that are attached to the instance. This parameter is returned only when the instance is a primary instance and has read-only instances.
                /// </summary>
                [NameInMap("ReadOnlyDBInstanceIds")]
                [Validation(Required=false)]
                public DescribeDBInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceIds ReadOnlyDBInstanceIds { get; set; }
                public class DescribeDBInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceIds : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceIdsReadOnlyDBInstanceId> ReadOnlyDBInstanceId { get; set; }
                    public class DescribeDBInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceIdsReadOnlyDBInstanceId : TeaModel {
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
                /// The resource group ID.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates whether the instance supports weight-based switchovers for high availability. This parameter is returned only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition. Valid values:
                /// 
                /// *   **100**: The instance supports weight-based switchovers for high availability.
                /// *   **0**: The instance does not support weight-based switchovers for high availability.
                /// </summary>
                [NameInMap("SwitchWeight")]
                [Validation(Required=false)]
                public int? SwitchWeight { get; set; }

                /// <summary>
                /// The ID of the temporary instance. This parameter is returned only when the instance is a primary instance and has a temporary instance.
                /// </summary>
                [NameInMap("TempDBInstanceId")]
                [Validation(Required=false)]
                public string TempDBInstanceId { get; set; }

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
                /// *   **2**: The specifications of the read-only instances do not match the specifications of the primary instance, and instance performance may be affected. You must adjust the specifications of these instances based on your business requirements.
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
                /// The virtual private cloud (VPC) ID of the instance.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The VPC name.
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The token that is used to display the next page. If the returned entries are displayed on multiple pages, the next page can be displayed when you call this operation again with **NextToken** specified.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// 
        /// > If you specify **MaxResults** or **NextToken**, only the value **1** is returned. You can ignore the value 1.
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
        /// 
        /// > If you specify **MaxResults** or **NextToken**, only the number of entries on the current page is returned. You can ignore the number.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
