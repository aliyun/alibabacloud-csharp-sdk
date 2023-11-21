// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeHostEcsLevelInfoResponseBody : TeaModel {
        /// <summary>
        /// The queried host.
        /// </summary>
        [NameInMap("HostEcsLevelInfos")]
        [Validation(Required=false)]
        public List<DescribeHostEcsLevelInfoResponseBodyHostEcsLevelInfos> HostEcsLevelInfos { get; set; }
        public class DescribeHostEcsLevelInfoResponseBodyHostEcsLevelInfos : TeaModel {
            /// <summary>
            /// The category of the host. Valid values:
            /// 
            /// *   **general**: general-purpose.
            /// *   **compute**: compute-optimized.
            /// *   **ram**: memory-optimized.
            /// *   **dragon**: ECS Bare Metal Instance.
            /// </summary>
            [NameInMap("CddcHostType")]
            [Validation(Required=false)]
            public string CddcHostType { get; set; }

            /// <summary>
            /// The queried host specifications.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeHostEcsLevelInfoResponseBodyHostEcsLevelInfosItems> Items { get; set; }
            public class DescribeHostEcsLevelInfoResponseBodyHostEcsLevelInfosItems : TeaModel {
                /// <summary>
                /// The disk bandwidth. Unit: Gbit/s.
                /// </summary>
                [NameInMap("CloudStorageBandwidth")]
                [Validation(Required=false)]
                public float? CloudStorageBandwidth { get; set; }

                /// <summary>
                /// The number of CPU cores of the host.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// The processor frequency. Unit: GHz.
                /// </summary>
                [NameInMap("CpuFrequency")]
                [Validation(Required=false)]
                public string CpuFrequency { get; set; }

                /// <summary>
                /// The CPU model of the host.
                /// </summary>
                [NameInMap("CpuVersion")]
                [Validation(Required=false)]
                public string CpuVersion { get; set; }

                /// <summary>
                /// The name of the host.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The instance family of the host.
                /// </summary>
                [NameInMap("EcsClass")]
                [Validation(Required=false)]
                public string EcsClass { get; set; }

                /// <summary>
                /// The instance type of the host.
                /// </summary>
                [NameInMap("EcsClassCode")]
                [Validation(Required=false)]
                public string EcsClassCode { get; set; }

                /// <summary>
                /// Indicates whether the host uses cloud disks.
                /// </summary>
                [NameInMap("IsCloudDisk")]
                [Validation(Required=false)]
                public int? IsCloudDisk { get; set; }

                /// <summary>
                /// The local storage.
                /// </summary>
                [NameInMap("LocalStorage")]
                [Validation(Required=false)]
                public string LocalStorage { get; set; }

                /// <summary>
                /// The memory size of the host. Unit: GB.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// The internal bandwidth of the host. Unit: Gbit/s.
                /// </summary>
                [NameInMap("NetBandWidth")]
                [Validation(Required=false)]
                public float? NetBandWidth { get; set; }

                /// <summary>
                /// The packet forwarding rate over the internal network, which is displayed after being divided by 10,000. Unit: packets per second (PPS).
                /// </summary>
                [NameInMap("NetPackage")]
                [Validation(Required=false)]
                public int? NetPackage { get; set; }

                /// <summary>
                /// The instance type of the instance.
                /// </summary>
                [NameInMap("RdsClassCode")]
                [Validation(Required=false)]
                public string RdsClassCode { get; set; }

                /// <summary>
                /// The storage IOPS of the host, which is displayed after being divided by 10,000.
                /// </summary>
                [NameInMap("StorageIops")]
                [Validation(Required=false)]
                public int? StorageIops { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
