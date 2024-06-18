// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateGADInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the primary instance. You can call the DescribeDBInstances operation to query the instance ID. The primary instance serves as the central node of the global active database cluster.
        /// 
        /// > *   A primary instance can serve only as the central node of a single global active database cluster.
        /// > *   The primary instance can serve as the central node of the global active database cluster only in the following regions: China (Hangzhou), China (Shanghai), China (Qingdao), China (Beijing), China (Zhangjiakou), China (Shenzhen), and China (Chengdu).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CentralDBInstanceId")]
        [Validation(Required=false)]
        public string CentralDBInstanceId { get; set; }

        /// <summary>
        /// The username of the privileged account of the central node. You can call the DescribeAccounts operation to query the privileged account of the central node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CentralRdsDtsAdminAccount")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminAccount { get; set; }

        /// <summary>
        /// The password of the privileged account of the central node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CentralRdsDtsAdminPassword")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminPassword { get; set; }

        /// <summary>
        /// The region ID of the central node. You can call the DescribeRegions operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CentralRegionId")]
        [Validation(Required=false)]
        public string CentralRegionId { get; set; }

        /// <summary>
        /// A JSON array that consists of the information about a specified database on the central node. All database information that you specify in this array is synchronized to the unit nodes of the global active database cluster. The JSON array contains the following fields:
        /// 
        /// *   **name**: the name of the database.
        /// *   **all**: specifies whether to synchronize all data in the database or the table. Valid values: **true** and **false**.
        /// *   **Table**: the name of the table. If you set the **all** field to **false**, you must nest the name of the table that you want to synchronize into the JSON array.
        /// 
        /// Example: `{ "testdb": { "name": "testdb", "all": false, "Table": { "order": { "name": "order", "all": true }, "ordernew": { "name": "ordernew", "all": true } } } }`
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBList")]
        [Validation(Required=false)]
        public string DBList { get; set; }

        /// <summary>
        /// The name of the global active database cluster.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// An array that consists of the details about the tag.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateGADInstanceRequestTag> Tag { get; set; }
        public class CreateGADInstanceRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag. You can create N tag keys at a time. Valid values of N: **1 to 20**. The value of this parameter cannot be an empty string.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. You can create N tag values at a time. Valid values of N: **1 to 20**. The value of this parameter can be an empty string.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The information about the unit node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UnitNode")]
        [Validation(Required=false)]
        public List<CreateGADInstanceRequestUnitNode> UnitNode { get; set; }
        public class CreateGADInstanceRequestUnitNode : TeaModel {
            /// <summary>
            /// The name of the unit node that you want to create. The name must meet the following requirements:
            /// 
            /// *   The name must be **2 to 255** characters in length.
            /// *   The name can contain letters, digits, underscores (_), and hyphens (-) and must start with a letter.
            /// *   The name cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("DBInstanceDescription")]
            [Validation(Required=false)]
            public string DBInstanceDescription { get; set; }

            /// <summary>
            /// The storage capacity of the unit node that you want to create. Unit: GB You can adjust the storage capacity in increments of 5 GB. For more information, see [Primary ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/26312.html). You can also call the DescribeAvailableResource operation to query the storage capacity range that is supported by the new instance type.
            /// </summary>
            [NameInMap("DBInstanceStorage")]
            [Validation(Required=false)]
            public long? DBInstanceStorage { get; set; }

            /// <summary>
            /// The storage type of the instance. Valid values:
            /// 
            /// *   **local_ssd**: local SSD. This is the recommended storage type.
            /// *   **cloud_ssd**: standard SSD. This storage type is not recommended. Standard SSDs are no longer available for purchase in some Alibaba Cloud regions.
            /// *   **cloud_essd**: PL1 ESSD
            /// *   **cloud_essd2**: PL2 ESSD
            /// *   **cloud_essd3**: PL3 ESSD
            /// 
            /// The default value of this parameter is determined by the instance type specified by the **DBInstanceClass** parameter.
            /// 
            /// *   If the instance type specifies the local SSD storage type, the default value of this parameter is **local_ssd**.
            /// *   If the instance type specifies the cloud disk storage type, the default value of this parameter is **cloud_essd**.
            /// </summary>
            [NameInMap("DBInstanceStorageType")]
            [Validation(Required=false)]
            public string DBInstanceStorageType { get; set; }

            /// <summary>
            /// The instance type of the unit node that you want to create. For more information, see [Primary ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/26312.html). You can call the DescribeAvailableResource operation to query the available instance types in a region.
            /// </summary>
            [NameInMap("DbInstanceClass")]
            [Validation(Required=false)]
            public string DbInstanceClass { get; set; }

            /// <summary>
            /// The conflict resolution policy based on which Data Transmission Service (DTS) responds to primary key conflicts during data synchronization to the unit node that you want to create. Valid values:
            /// 
            /// *   **overwrite**: DTS overwrites the conflicting primary key on the destination node.
            /// *   **interrupt**: DTS stops the synchronization task, reports an error, and then exits.
            /// *   **ignore**: DTS hides the conflicting primary key on the node.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DtsConflict")]
            [Validation(Required=false)]
            public string DtsConflict { get; set; }

            /// <summary>
            /// The specifications of the data synchronization task for the unit node that you want to create. Valid values:
            /// 
            /// *   **small**
            /// *   **medium**
            /// *   **large**
            /// *   **micro**
            /// 
            /// >  For more information, see [Specifications of data synchronization tasks](https://help.aliyun.com/document_detail/26605.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DtsInstanceClass")]
            [Validation(Required=false)]
            public string DtsInstanceClass { get; set; }

            /// <summary>
            /// The database engine of the unit node that you want to create. Set the value to **MySQL**.
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// The database engine version of the unit node that you want to create. Valid values:
            /// 
            /// *   **8.0**
            /// *   **5.7**
            /// *   **5.6**
            /// *   **5.5**
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// The billing method of the unit node that you want to create. Valid values:
            /// 
            /// *   **Postpaid**: pay-as-you-go
            /// *   **Prepaid**: subscription
            /// 
            /// >  The system automatically generates a purchase order and completes the payment. You do not need to manually confirm the purchase order or complete the payment.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The region ID of the unit node that you want to create. You can call the DescribeRegions operation to query the most recent region list.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            /// <summary>
            /// The [IP address whitelist](https://help.aliyun.com/document_detail/43185.html) of the unit node that you want to create. If you want to add more than one entry to the IP address whitelist, separate the entries with commas (,). Each entry must be unique. The IP address whitelist can contain up to 1,000 entries. The entries in the IP address whitelist must be in one of the following formats:
            /// 
            /// *   IP addresses, such as `10.10.10.10`.
            /// *   CIDR blocks, such as `10.10.10.10/24`. In this example, **24** indicates that the prefix of the IP address in the whitelist is 24 bits in length. You can replace 24 with a value within the range of **1 to 32**.
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// The vSwitch ID of the unit node that you want to create.
            /// </summary>
            [NameInMap("VSwitchID")]
            [Validation(Required=false)]
            public string VSwitchID { get; set; }

            /// <summary>
            /// The virtual private cloud (VPC) ID of the unit node that you want to create.
            /// </summary>
            [NameInMap("VpcID")]
            [Validation(Required=false)]
            public string VpcID { get; set; }

            /// <summary>
            /// The zone ID of the unit node that you want to create. You can call the DescribeRegions operation to query the zone ID.
            /// </summary>
            [NameInMap("ZoneID")]
            [Validation(Required=false)]
            public string ZoneID { get; set; }

            /// <summary>
            /// The zone ID of the secondary node of the unit node that you want to create. You can call the DescribeRegions operation to query the zone ID.
            /// 
            /// *   If the value of this parameter is the same as the **zone ID** of the unit node that you want to create, the single-zone deployment method is used.
            /// *   If the value of this parameter is different from the **zone ID** of the unit node that you want to create, the multiple-zone deployment method is used.
            /// </summary>
            [NameInMap("ZoneIDSlave1")]
            [Validation(Required=false)]
            public string ZoneIDSlave1 { get; set; }

            /// <summary>
            /// The zone ID of the logger node of the unit node that you want to create. You can call the DescribeRegions operation to query the zone ID.
            /// 
            /// *   If the value of this parameter is the same as the **zone ID** of the unit node that you want to create, the single-zone deployment method is used.
            /// *   If the value of this parameter is different from the **zone ID** of the unit node that you want to create, the multiple-zone deployment method is used.
            /// </summary>
            [NameInMap("ZoneIDSlave2")]
            [Validation(Required=false)]
            public string ZoneIDSlave2 { get; set; }

        }

    }

}
