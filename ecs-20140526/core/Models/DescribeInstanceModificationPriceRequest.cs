// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceModificationPriceRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribeInstanceModificationPriceRequestSystemDisk SystemDisk { get; set; }
        public class DescribeInstanceModificationPriceRequestSystemDisk : TeaModel {
            /// <summary>
            /// The category of the system disk. You must specify this parameter only when you upgrade a non-I/O optimized instance of a retired instance type to an I/O optimized instance of an available instance type. For more information about instance types, see [Instance families](https://help.aliyun.com/document_detail/25378.html) and [Retired instance types](https://help.aliyun.com/document_detail/55263.html).
            /// 
            /// Valid values:
            /// 
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
            /// 
            /// This parameter is empty by default.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

        }

        /// <summary>
        /// The information about data disks.
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<DescribeInstanceModificationPriceRequestDataDisk> DataDisk { get; set; }
        public class DescribeInstanceModificationPriceRequestDataDisk : TeaModel {
            /// <summary>
            /// The category of data disk N. You can specify this parameter if you want to query the pricing information about newly attached subscription data disks. Valid values of N: 1 to 16. Valid values:
            /// 
            /// *   cloud_efficiency: utra disk.
            /// *   cloud_ssd: standard SSD.
            /// *   cloud_essd: ESSD.
            /// *   cloud: basic disk.
            /// 
            /// This parameter is empty by default.
            /// 
            /// >  When you call the DescribeInstanceModificationPrice operation, you must specify at least one of the following parameters: `InstanceType` and `DataDisk.N.*`.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The performance level of data disk N that is an enhanced SSD (ESSD). The value of N must be the same as that in `DataDisk.N.Category` when DataDisk.N.Category is set to cloud_essd. Valid values:
            /// 
            /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
            /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
            /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
            /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
            /// 
            /// Default value: PL1.
            /// 
            /// For more information about ESSD performance levels, see [ESSDs](https://help.aliyun.com/document_detail/122389.html).
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// The capacity of data disk N. Valid values of N: 1 to 16. Unit: GiB. Valid values:
            /// 
            /// *   Valid values when DataDisk.N.Category is set to cloud_efficiency: 20 to 32768.
            /// 
            /// *   Valid values when DataDisk.N.Category is set to cloud_ssd: 20 to 32768.
            /// 
            /// *   Valid values when DataDisk.N.Category is set to cloud_essd: vary based on the `DataDisk.N.PerformanceLevel` value.
            /// 
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL0: 1 to 32768.
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL1: 20 to 32768.
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL2: 461 to 32768.
            ///     *   Valid values when DataDisk.N.PerformanceLevel is set to PL3: 1261 to 32768.
            /// 
            /// *   Valid values when DataDisk.N.Category is set to cloud: 5 to 2000.
            /// 
            /// The default value is the minimum capacity allowed for the specified data disk category.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// The ID of the instance for which you want to query pricing information for a configuration upgrade.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The new instance type. We recommend that you call the [DescribeResourcesModification](https://help.aliyun.com/document_detail/66187.html) operation to query the instance types available for configuration upgrades in a specified zone.
        /// 
        /// > When you call the DescribeInstanceModificationPrice operation, you must specify at least one of the following parameters: `InstanceType` and `DataDisk.N.*`.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
