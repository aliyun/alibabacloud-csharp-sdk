// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskSpecRequest : TeaModel {
        /// <summary>
        /// The new category of the disk. Valid values:
        /// 
        /// *   cloud_essd: enhanced SSD (ESSD)
        /// *   cloud_auto: ESSD AutoPL disk
        /// *   cloud_ssd: standard SSD
        /// *   cloud_efficiency: ultra disk
        /// 
        /// This parameter is empty by default, which indicates that the disk category is not changed.
        /// 
        /// > 
        /// 
        /// *   The preceding values are listed in descending order of disk performance. Subscription disks cannot be downgraded.
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// The disk ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   true: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, service limits, and insufficient ECS resources. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   false: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The disk performance specifications.
        /// </summary>
        [NameInMap("PerformanceControlOptions")]
        [Validation(Required=false)]
        public ModifyDiskSpecRequestPerformanceControlOptions PerformanceControlOptions { get; set; }
        public class ModifyDiskSpecRequestPerformanceControlOptions : TeaModel {
            /// <summary>
            /// The new IOPS rate of the disk. You can modify the IOPS rate of only disks in dedicated block storage clusters.
            /// 
            /// Valid values: 900 to maximum IOPS per disk (with an increment of 100).
            /// 
            /// For more information, see [Block storage performance](https://help.aliyun.com/document_detail/25382.html).
            /// </summary>
            [NameInMap("IOPS")]
            [Validation(Required=false)]
            public int? IOPS { get; set; }

            /// <summary>
            /// Specifies whether to reset the IOPS rate and throughput of the disk. This parameter takes effect only when the disk belongs to a dedicated block storage cluster.
            /// 
            /// After you specify this parameter, PerformanceControlOptions.IOPS and PerformanceControlOptions.Throughput do not take effect.
            /// 
            /// Set the value to All, which indicates that the IOPS rate and throughput of the disk are reset to the initial values.
            /// </summary>
            [NameInMap("Recover")]
            [Validation(Required=false)]
            public string Recover { get; set; }

            /// <summary>
            /// The new throughput of the disk. You can modify the throughput of only disks in dedicated block storage clusters. Unit: MB/s.
            /// 
            /// Valid values: 60 to maximum throughput per disk.
            /// 
            /// For more information, see [Block storage performance](https://help.aliyun.com/document_detail/25382.html).
            /// </summary>
            [NameInMap("Throughput")]
            [Validation(Required=false)]
            public int? Throughput { get; set; }

        }

        /// <summary>
        /// The new performance level of the ESSD. Valid values:
        /// 
        /// *   PL0: An ESSD can deliver up to 10,000 random read/write IOPS.
        /// *   PL1: An ESSD can deliver up to 50,000 random read/write IOPS.
        /// *   PL2: An ESSD can deliver up to 100,000 random read/write IOPS.
        /// *   PL3: An ESSD delivers up to 1,000,000 random read/write IOPS.
        /// 
        /// Default value: PL1.
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}
        /// 
        /// Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}
        /// 
        /// >  This parameter is available only if the DiskCategory parameter is set to cloud_auto. For more information, see [ESSD AutoPL disks](https://help.aliyun.com/document_detail/368372.html) and [Modify the performance configurations of an ESSD AutoPL disk](https://help.aliyun.com/document_detail/413275.html).
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
