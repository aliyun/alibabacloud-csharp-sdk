// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMarketingActivityResponseBody : TeaModel {
        /// <summary>
        /// The unique ID (UID) of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// The BID of the account to which the Anycast EIP belongs.
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        /// <summary>
        /// The details of the instance.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeMarketingActivityResponseBodyItems> Items { get; set; }
        public class DescribeMarketingActivityResponseBodyItems : TeaModel {
            /// <summary>
            /// The RDS edition of the instance. Valid values:
            /// 
            /// *   **Basic**: RDS Basic Edition
            /// *   **HighAvailability**: High-availability Edition
            /// *   **Finance**: RDS Enterprise Edition
            /// 
            /// > This parameter is returned only when **InstanceLevel** is set to **1**.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The billing method of the instance. Valid values:
            /// 
            /// *   **PostPaid** (default): pay-as-you-go
            /// *   **PrePaid**: subscription
            /// 
            /// > **Period** is required if you set the value of this parameter to **PrePaid**.
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The code of the instance type. For more information, see [Primary ApsaraDB RDS instance types](~~26312~~) and [Read-only ApsaraDB RDS instance types](~~145759~~).
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// The instance family. For more information, see [Overview of instance families](~~57184~~).
            /// </summary>
            [NameInMap("ClassGroup")]
            [Validation(Required=false)]
            public string ClassGroup { get; set; }

            /// <summary>
            /// The number of vCPU cores. Unit: cores.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// The disk size. Unit: GB.
            /// 
            /// *   The disk size that you specify must be greater than or equal to the current disk size of the instance.
            /// *   For more information about the valid values, see [Billing](~~84737~~).
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

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
            /// The database engine version.
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The instance name.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The maximum number of concurrent connections.
            /// </summary>
            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public int? MaxConnections { get; set; }

            /// <summary>
            /// MaxIombps
            /// </summary>
            [NameInMap("MaxIombps")]
            [Validation(Required=false)]
            public int? MaxIombps { get; set; }

            /// <summary>
            /// MaxIops
            /// </summary>
            [NameInMap("MaxIops")]
            [Validation(Required=false)]
            public int? MaxIops { get; set; }

            /// <summary>
            /// The memory size that you applied for each instance. Unit: MB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// The storage type of the instance. Valid values:
            /// 
            /// *   **local_ssd**: local SSD
            /// *   **cloud_ssd**: standard SSD
            /// *   **cloud_essd**: enhanced SSD (ESSD) of performance level 1 (PL1)
            /// *   **cloud_essd2**: ESSD of PL2
            /// *   **cloud_essd3**: ESSD of PL3
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// UpgradeCategory
            /// </summary>
            [NameInMap("UpgradeCategory")]
            [Validation(Required=false)]
            public string UpgradeCategory { get; set; }

            /// <summary>
            /// UpgradeClassCode
            /// </summary>
            [NameInMap("UpgradeClassCode")]
            [Validation(Required=false)]
            public string UpgradeClassCode { get; set; }

            /// <summary>
            /// UpgradeClassGroup
            /// </summary>
            [NameInMap("UpgradeClassGroup")]
            [Validation(Required=false)]
            public string UpgradeClassGroup { get; set; }

            /// <summary>
            /// UpgradeCpu
            /// </summary>
            [NameInMap("UpgradeCpu")]
            [Validation(Required=false)]
            public string UpgradeCpu { get; set; }

            /// <summary>
            /// UpgradeDescContent
            /// </summary>
            [NameInMap("UpgradeDescContent")]
            [Validation(Required=false)]
            public string UpgradeDescContent { get; set; }

            /// <summary>
            /// UpgradeDiskSize
            /// </summary>
            [NameInMap("UpgradeDiskSize")]
            [Validation(Required=false)]
            public int? UpgradeDiskSize { get; set; }

            /// <summary>
            /// UpgradeMaxConnections
            /// </summary>
            [NameInMap("UpgradeMaxConnections")]
            [Validation(Required=false)]
            public int? UpgradeMaxConnections { get; set; }

            /// <summary>
            /// UpgradeMaxIombps
            /// </summary>
            [NameInMap("UpgradeMaxIombps")]
            [Validation(Required=false)]
            public int? UpgradeMaxIombps { get; set; }

            /// <summary>
            /// UpgradeMaxIops
            /// </summary>
            [NameInMap("UpgradeMaxIops")]
            [Validation(Required=false)]
            public int? UpgradeMaxIops { get; set; }

            /// <summary>
            /// UpgradeMemory
            /// </summary>
            [NameInMap("UpgradeMemory")]
            [Validation(Required=false)]
            public long? UpgradeMemory { get; set; }

            /// <summary>
            /// UpgradeReferencePrice
            /// </summary>
            [NameInMap("UpgradeReferencePrice")]
            [Validation(Required=false)]
            public string UpgradeReferencePrice { get; set; }

            /// <summary>
            /// UpgradeStorageType
            /// </summary>
            [NameInMap("UpgradeStorageType")]
            [Validation(Required=false)]
            public string UpgradeStorageType { get; set; }

        }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
