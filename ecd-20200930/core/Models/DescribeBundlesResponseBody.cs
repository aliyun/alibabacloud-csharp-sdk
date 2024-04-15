// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeBundlesResponseBody : TeaModel {
        /// <summary>
        /// The details of the queried cloud computer templates.
        /// </summary>
        [NameInMap("Bundles")]
        [Validation(Required=false)]
        public List<DescribeBundlesResponseBodyBundles> Bundles { get; set; }
        public class DescribeBundlesResponseBodyBundles : TeaModel {
            /// <summary>
            /// The ID of the cloud computer template.
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// The name of the cloud computer template.
            /// </summary>
            [NameInMap("BundleName")]
            [Validation(Required=false)]
            public string BundleName { get; set; }

            /// <summary>
            /// The type of the cloud computer template.
            /// 
            /// Valid values:
            /// 
            /// *   SYSTEM: system template
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   CUSTOM: custom template
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("BundleType")]
            [Validation(Required=false)]
            public string BundleType { get; set; }

            /// <summary>
            /// The time when the cloud computer template was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the cloud computer template.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The instance type of the cloud computer.
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// The details of the cloud computer instance type.
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
                /// The memory size. Unit: MiB.
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public int? MemorySize { get; set; }

            }

            /// <summary>
            /// The instance family of the cloud computer.
            /// 
            /// Valid values:
            /// 
            /// *   eds.graphics: graphical instance family
            /// *   eds.hf: instance family with a high clock speed
            /// *   eds.general: general-purpose instance family
            /// </summary>
            [NameInMap("DesktopTypeFamily")]
            [Validation(Required=false)]
            public string DesktopTypeFamily { get; set; }

            /// <summary>
            /// Details of the disks.
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeBundlesResponseBodyBundlesDisks> Disks { get; set; }
            public class DescribeBundlesResponseBodyBundlesDisks : TeaModel {
                /// <summary>
                /// The PL of the disk.
                /// 
                /// Valid values:
                /// 
                /// *   PL1
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   PL0
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   PL3
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   PL2
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
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
                /// The type of the disk.
                /// 
                /// Valid values:
                /// 
                /// *   SYSTEM: system disk
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   DATA: data disk
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            /// <summary>
            /// The image ID.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The image name.
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
            /// The type of the OS.
            /// 
            /// Valid values:
            /// 
            /// *   Linux
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Windows
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// The OS.
            /// 
            /// Valid values:
            /// 
            /// *   Ubuntu
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Windows Server 2022
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   UOS
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   CentOS
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Windows Server 2019
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Windows Server 2016
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// The protocol type.
            /// 
            /// Valid values:
            /// 
            /// *   HDX: HDX protocol
            /// *   ASP: in-house ASP
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The session type.
            /// 
            /// Valid values:
            /// 
            /// *   0: single-session
            /// *   1: multi-session
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// The inventory status of the cloud computer instance type. This parameter is returned only if you set the `CheckStock` parameter to `true`.
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
