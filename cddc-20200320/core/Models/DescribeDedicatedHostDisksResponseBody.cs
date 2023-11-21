// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedHostDisksResponseBody : TeaModel {
        /// <summary>
        /// The host ID.
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// The queried disks.
        /// </summary>
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public List<DescribeDedicatedHostDisksResponseBodyDisks> Disks { get; set; }
        public class DescribeDedicatedHostDisksResponseBodyDisks : TeaModel {
            /// <summary>
            /// The storage type of the host. Valid values:
            /// 
            /// *   **cloud_ssd**: local SSD.
            /// *   **cloud_essd**: ESSD.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The ID of the instance that uses the disk.
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// The device name of the instance to which the ESSD or local SSD is attached.
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// The ID of the ESSD or local SSD.
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// Indicates whether the disk is attached to instances. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("HasDBInstance")]
            [Validation(Required=false)]
            public bool? HasDBInstance { get; set; }

            /// <summary>
            /// The maximum IOPS of the disk, which is displayed after being divided by 10,000.
            /// </summary>
            [NameInMap("MaxIOPS")]
            [Validation(Required=false)]
            public int? MaxIOPS { get; set; }

            /// <summary>
            /// The maximum throughput of the disk. Unit: MB/s.
            /// </summary>
            [NameInMap("MaxThroughput")]
            [Validation(Required=false)]
            public int? MaxThroughput { get; set; }

            /// <summary>
            /// The performance level of the ESSD.
            /// 
            /// >  ApsaraDB for MyBase provides the following types of ESSDs: **ESSD**, **PL2 ESSD**, and **PL3 ESSD**. The higher performance level delivers better ESSD performance.
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// The size of the ESSD or local SSD. Unit: GB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// The state of the ESSD. Valid values:
            /// 
            /// *   **In_use**
            /// *   **Available**
            /// *   **Attaching**
            /// *   **Detaching**
            /// *   **Creating**
            /// *   **ReIniting**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The disk type of the enhanced SSD (ESSD) or local SSD. Valid values:
            /// 
            /// *   **system**: system disk.
            /// *   **data**: data disk.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The zone ID of the ESSD or local SSD.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
