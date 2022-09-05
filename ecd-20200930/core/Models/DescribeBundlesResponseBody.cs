// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeBundlesResponseBody : TeaModel {
        [NameInMap("Bundles")]
        [Validation(Required=false)]
        public List<DescribeBundlesResponseBodyBundles> Bundles { get; set; }
        public class DescribeBundlesResponseBodyBundles : TeaModel {
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            [NameInMap("BundleName")]
            [Validation(Required=false)]
            public string BundleName { get; set; }

            [NameInMap("BundleType")]
            [Validation(Required=false)]
            public string BundleType { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            [NameInMap("DesktopTypeAttribute")]
            [Validation(Required=false)]
            public DescribeBundlesResponseBodyBundlesDesktopTypeAttribute DesktopTypeAttribute { get; set; }
            public class DescribeBundlesResponseBodyBundlesDesktopTypeAttribute : TeaModel {
                [NameInMap("CpuCount")]
                [Validation(Required=false)]
                public int? CpuCount { get; set; }

                [NameInMap("GpuCount")]
                [Validation(Required=false)]
                public float? GpuCount { get; set; }

                [NameInMap("GpuSpec")]
                [Validation(Required=false)]
                public string GpuSpec { get; set; }

                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public int? MemorySize { get; set; }

            }

            [NameInMap("DesktopTypeFamily")]
            [Validation(Required=false)]
            public string DesktopTypeFamily { get; set; }

            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeBundlesResponseBodyBundlesDisks> Disks { get; set; }
            public class DescribeBundlesResponseBodyBundlesDisks : TeaModel {
                [NameInMap("DiskPerformanceLevel")]
                [Validation(Required=false)]
                public string DiskPerformanceLevel { get; set; }

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            [NameInMap("StockState")]
            [Validation(Required=false)]
            public string StockState { get; set; }

            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
