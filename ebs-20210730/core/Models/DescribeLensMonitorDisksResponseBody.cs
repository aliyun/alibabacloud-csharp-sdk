// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeLensMonitorDisksResponseBody : TeaModel {
        /// <summary>
        /// Cloud disk information list.
        /// </summary>
        [NameInMap("DiskInfos")]
        [Validation(Required=false)]
        public List<DescribeLensMonitorDisksResponseBodyDiskInfos> DiskInfos { get; set; }
        public class DescribeLensMonitorDisksResponseBodyDiskInfos : TeaModel {
            /// <summary>
            /// The BPS.
            /// </summary>
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public int? Bps { get; set; }

            /// <summary>
            /// Indicates whether the performance burst feature is enabled. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// This parameter is available only if you set `DiskCategory` to `cloud_auto`. For more information, see [ESSD AutoPL disks](https://help.aliyun.com/document_detail/368372.html).
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// The type of the disk. Valid values:
            /// - cloud
            /// - cloud_efficiency
            /// - cloud_ssd
            /// - cloud_essd
            /// - cloud_auto
            /// - cloud_essd_entry
            /// </summary>
            [NameInMap("DiskCategory")]
            [Validation(Required=false)]
            public string DiskCategory { get; set; }

            /// <summary>
            /// The ID of the disk.
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// The name of the disk.
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// The disk status. Valid values:
            /// 
            /// - Available
            /// - Deleted
            /// </summary>
            [NameInMap("DiskStatus")]
            [Validation(Required=false)]
            public string DiskStatus { get; set; }

            /// <summary>
            /// The disk type. Valid values:
            /// *   system: system disk
            /// *   data: data disk
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// The IOPS.
            /// </summary>
            [NameInMap("Iops")]
            [Validation(Required=false)]
            public int? Iops { get; set; }

            /// <summary>
            /// Event tags of the disk.
            /// </summary>
            [NameInMap("LensTags")]
            [Validation(Required=false)]
            public List<string> LensTags { get; set; }

            /// <summary>
            /// The new performance level of the ESSD. Valid values:
            /// 
            /// *   PL0: An ESSD can deliver up to 10,000 random read/write IOPS.
            /// *   PL1: An ESSD can deliver up to 50,000 random read/write IOPS.
            /// *   PL2: An ESSD can deliver up to 100,000 random read/write IOPS.
            /// *   PL3: An ESSD delivers up to 1,000,000 random read/write IOPS.
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}
            /// 
            /// Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}
            /// 
            /// >  This parameter is available only if the DiskCategory parameter is set to cloud_auto. For more information, see [ESSD AutoPL disks](https://www.alibabacloud.com/help/en/ecs/user-guide/essd-autopl-disks)
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public int? ProvisionedIops { get; set; }

            /// <summary>
            /// The region ID of the disk.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The size of the disk. Unit: GiB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// Tags of the disk.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeLensMonitorDisksResponseBodyDiskInfosTags> Tags { get; set; }
            public class DescribeLensMonitorDisksResponseBodyDiskInfosTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The ID of the zone.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
