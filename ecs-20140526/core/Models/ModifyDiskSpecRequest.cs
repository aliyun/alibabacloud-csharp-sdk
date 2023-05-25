// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiskSpecRequest : TeaModel {
        /// <summary>
        /// The new category of the disk. Default value: PL1. Valid values:
        /// 
        /// *   cloud_essd: ESSD.
        /// *   cloud_auto: ESSD AutoPL disk.
        /// *   cloud_ssd: The system creates an SSD.
        /// *   cloud_efficiency: The system creates an ultra disk.
        /// 
        /// This parameter is empty by default, which indicates that the disk category is not changed.
        /// 
        /// > The preceding values are listed in descending order of disk performance. The performance level of a subscription cloud disk cannot be downgraded.
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// The disk ID.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run without performing the actual request. Default value: PL1. Valid values:
        /// 
        /// *   true: performs only a dry run. The system checks the required parameters, request syntax, service limits, and available ECS resources. If the request fails the dry run, the corresponding error message is returned. If the check succeeds, the `DryRunOperation` error code is returned.
        /// *   false: The validity of the request is checked. If the check succeeds, a 2xx HTTP status code is returned and the request is made.
        /// 
        /// Default value: false
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
        /// 磁盘性能控制参数集合
        /// </summary>
        [NameInMap("PerformanceControlOptions")]
        [Validation(Required=false)]
        public ModifyDiskSpecRequestPerformanceControlOptions PerformanceControlOptions { get; set; }
        public class ModifyDiskSpecRequestPerformanceControlOptions : TeaModel {
            /// <summary>
            /// 目标云盘IOPS。仅支持修改专属存储集群云盘IOPS。
            /// 
            /// 取值范围：900~单盘最大IOPS，步长100。
            /// 
            /// 
            /// 更多信息，请参见[云盘性能](~~25382~~)。
            /// </summary>
            [NameInMap("IOPS")]
            [Validation(Required=false)]
            public int? IOPS { get; set; }

            /// <summary>
            /// 重置云盘性能，仅支持专属存储集群云盘。
            /// 
            /// 设置该参数后，PerformanceControlOptions.IOPS和PerformanceControlOptions.Throughput参数不生效。
            /// 
            /// 
            /// 目前仅支持设置为All（重置云盘IOPS和吞吐量到初始值）。
            /// </summary>
            [NameInMap("Recover")]
            [Validation(Required=false)]
            public string Recover { get; set; }

            /// <summary>
            /// 目标云盘吞吐量，仅支持修改专属存储集群云盘吞吐量，单位MB/s。
            /// 
            /// 取值范围：60~单盘最大吞吐量。
            /// 
            /// 更多信息，请参见[云盘性能](~~25382~~)。
            /// </summary>
            [NameInMap("Throughput")]
            [Validation(Required=false)]
            public int? Throughput { get; set; }

        }

        /// <summary>
        /// The new performance level of the ESSD. Default value: PL1. Valid values:
        /// 
        /// *   PL0: An ESSD can deliver up to 10,000 random read/write IOPS.
        /// *   PL1: An ESSD can deliver up to 50,000 random read/write IOPS.
        /// *   PL2: An ESSD can deliver up to 100,000 random read/write IOPS.
        /// *   PL3: An ESSD delivers up to 1,000,000 random read/write IOPS.
        /// 
        /// Default value: PL1
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}
        /// 
        /// Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}
        /// 
        /// > This parameter is available only if you set DiskCategory to cloud_auto. For more information, see [ESSD AutoPL disks](~~368372~~) and [Modify the performance configurations of an ESSD AutoPL disk](~~413275~~).
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
