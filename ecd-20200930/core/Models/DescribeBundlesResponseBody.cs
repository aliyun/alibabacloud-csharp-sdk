// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeBundlesResponseBody : TeaModel {
        /// <summary>
        /// Details about the cloud desktop templates.
        /// </summary>
        [NameInMap("Bundles")]
        [Validation(Required=false)]
        public List<DescribeBundlesResponseBodyBundles> Bundles { get; set; }
        public class DescribeBundlesResponseBodyBundles : TeaModel {
            /// <summary>
            /// The ID of the cloud desktop template.
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// The name of the cloud desktop template.
            /// </summary>
            [NameInMap("BundleName")]
            [Validation(Required=false)]
            public string BundleName { get; set; }

            /// <summary>
            /// The type of the cloud desktop template. Valid values:
            /// 
            /// *   SYSTEM: the system template
            /// *   CUSTOM: the custom template
            /// </summary>
            [NameInMap("BundleType")]
            [Validation(Required=false)]
            public string BundleType { get; set; }

            /// <summary>
            /// The time when the cloud desktop template was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the cloud desktop template.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The type of the cloud desktop.
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// Details about the cloud desktop type.
            /// </summary>
            [NameInMap("DesktopTypeAttribute")]
            [Validation(Required=false)]
            public DescribeBundlesResponseBodyBundlesDesktopTypeAttribute DesktopTypeAttribute { get; set; }
            public class DescribeBundlesResponseBodyBundlesDesktopTypeAttribute : TeaModel {
                /// <summary>
                /// The number of vCPUs.
                /// </summary>
                [NameInMap("CpuCount")]
                [Validation(Required=false)]
                public int? CpuCount { get; set; }

                /// <summary>
                /// The number of GPUs.
                /// </summary>
                [NameInMap("GpuCount")]
                [Validation(Required=false)]
                public float? GpuCount { get; set; }

                /// <summary>
                /// The GPU type.
                /// </summary>
                [NameInMap("GpuSpec")]
                [Validation(Required=false)]
                public string GpuSpec { get; set; }

                /// <summary>
                /// The memory size. Unit: MB.
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public int? MemorySize { get; set; }

            }

            /// <summary>
            /// The family of the cloud desktop type. Valid values:
            /// 
            /// *   eds.general: General Office
            /// *   eds.hf: High Frequency
            /// *   eds.graphics: Graphics
            /// </summary>
            [NameInMap("DesktopTypeFamily")]
            [Validation(Required=false)]
            public string DesktopTypeFamily { get; set; }

            /// <summary>
            /// Details about the disks.
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeBundlesResponseBodyBundlesDisks> Disks { get; set; }
            public class DescribeBundlesResponseBodyBundlesDisks : TeaModel {
                /// <summary>
                /// The performance level (PL) of the disk.
                /// </summary>
                [NameInMap("DiskPerformanceLevel")]
                [Validation(Required=false)]
                public string DiskPerformanceLevel { get; set; }

                /// <summary>
                /// The size of the disk. Unit: GiB.
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// The disk type. Valid values:
                /// 
                /// *   SYSTEM: the system disk
                /// *   DATA: the data disk
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            /// <summary>
            /// The ID of the image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The name of the image.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// The status of the image.
            /// </summary>
            [NameInMap("ImageStatus")]
            [Validation(Required=false)]
            public string ImageStatus { get; set; }

            /// <summary>
            /// The OS language of the image.
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// The OS type.
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// The information about the OS platform. Valid values:
            /// 
            /// * CentOS
            /// * Ubuntu
            /// * Windows Server 2016
            /// * Windows Server 2019
            /// * UOS
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// The protocol type.
            /// 
            /// *   HDX
            /// *   ASP (Recommend)
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The session type. Valid values:
            /// 
            /// *   0: single_session
            /// *   1: multiple_session
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// The inventory status of the cloud desktop type, which is returned when the CheckStock parameter is set to true.
            /// </summary>
            [NameInMap("StockState")]
            [Validation(Required=false)]
            public string StockState { get; set; }

            /// <summary>
            /// Indicates whether disk encryption is enabled.
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// The ID of the Key Management Service (KMS) key that is used when disk encryption is enabled.
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        /// <summary>
        /// The token that is used for the next query. If this parameter is empty, all results have been returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
