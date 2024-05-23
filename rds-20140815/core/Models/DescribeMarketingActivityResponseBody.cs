// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMarketingActivityResponseBody : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// *   China site: 26842
        /// *   International site: 26888
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        /// <summary>
        /// The activity parameters
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeMarketingActivityResponseBodyItems> Items { get; set; }
        public class DescribeMarketingActivityResponseBodyItems : TeaModel {
            /// <summary>
            /// The RDS edition of the instance. Valid values:
            /// 
            /// *   **Basic**: RDS Basic Edition
            /// *   **HighAvailability**: RDS High-availability Edition
            /// *   **AlwaysOn**: RDS Cluster Edition
            /// *   **Finance**: RDS Enterprise Edition
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The payment type. Valid values:
            /// 
            /// *   POSTPAY: pay-as-you-go
            /// *   PREPAY: subscription
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The instance type. For more information, see [Primary ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/26312.html) and [Read-only ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/145759.html).
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// The instance family. For more information, see [Overview of instance families](https://help.aliyun.com/document_detail/57184.html).
            /// </summary>
            [NameInMap("ClassGroup")]
            [Validation(Required=false)]
            public string ClassGroup { get; set; }

            /// <summary>
            /// The number of CPU cores that are supported by the instance type. Unit: cores.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// The disk capacity per node. Unit: GB.
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

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
            /// The maximum I/O throughput. Unit: Mbit/s.
            /// </summary>
            [NameInMap("MaxIombps")]
            [Validation(Required=false)]
            public int? MaxIombps { get; set; }

            /// <summary>
            /// The maximum IOPS.
            /// </summary>
            [NameInMap("MaxIops")]
            [Validation(Required=false)]
            public int? MaxIops { get; set; }

            /// <summary>
            /// The memory size.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// The storage type of the instance. Valid values:
            /// 
            /// *   **local_ssd**: local SSD
            /// *   **cloud_ssd**: standard SSD
            /// *   **cloud_essd**: performance level 1 (PL1) enhanced SSD (ESSD)
            /// *   **cloud_essd2**: PL2 ESSD
            /// *   **cloud_essd3**: PL3 ESSD
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// The RDS edition after the upgrade.
            /// </summary>
            [NameInMap("UpgradeCategory")]
            [Validation(Required=false)]
            public string UpgradeCategory { get; set; }

            /// <summary>
            /// The instance type after the upgrade.
            /// </summary>
            [NameInMap("UpgradeClassCode")]
            [Validation(Required=false)]
            public string UpgradeClassCode { get; set; }

            /// <summary>
            /// The instance family after the upgrade.
            /// </summary>
            [NameInMap("UpgradeClassGroup")]
            [Validation(Required=false)]
            public string UpgradeClassGroup { get; set; }

            /// <summary>
            /// The number of CPU cores after the upgrade.
            /// </summary>
            [NameInMap("UpgradeCpu")]
            [Validation(Required=false)]
            public string UpgradeCpu { get; set; }

            /// <summary>
            /// The description of the upgrade.
            /// </summary>
            [NameInMap("UpgradeDescContent")]
            [Validation(Required=false)]
            public string UpgradeDescContent { get; set; }

            /// <summary>
            /// The disk capacity after the upgrade.
            /// </summary>
            [NameInMap("UpgradeDiskSize")]
            [Validation(Required=false)]
            public int? UpgradeDiskSize { get; set; }

            /// <summary>
            /// The maximum number of concurrent connections after the upgrade.
            /// </summary>
            [NameInMap("UpgradeMaxConnections")]
            [Validation(Required=false)]
            public int? UpgradeMaxConnections { get; set; }

            /// <summary>
            /// The maximum I/O throughput after the upgrade. Unit: Mbit/s.
            /// </summary>
            [NameInMap("UpgradeMaxIombps")]
            [Validation(Required=false)]
            public int? UpgradeMaxIombps { get; set; }

            /// <summary>
            /// The maximum IOPS after the upgrade.
            /// </summary>
            [NameInMap("UpgradeMaxIops")]
            [Validation(Required=false)]
            public int? UpgradeMaxIops { get; set; }

            /// <summary>
            /// The memory size after the upgrade.
            /// </summary>
            [NameInMap("UpgradeMemory")]
            [Validation(Required=false)]
            public long? UpgradeMemory { get; set; }

            /// <summary>
            /// The reference price of the upgrade.
            /// </summary>
            [NameInMap("UpgradeReferencePrice")]
            [Validation(Required=false)]
            public string UpgradeReferencePrice { get; set; }

            /// <summary>
            /// The storage type after the upgrade.
            /// </summary>
            [NameInMap("UpgradeStorageType")]
            [Validation(Required=false)]
            public string UpgradeStorageType { get; set; }

        }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
