// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeBundlesResponse : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Bundles")]
        [Validation(Required=true)]
        public List<DescribeBundlesResponseBundles> Bundles { get; set; }
        public class DescribeBundlesResponseBundles : TeaModel {
            [NameInMap("ImageId")]
            [Validation(Required=true)]
            public string ImageId { get; set; }

            [NameInMap("BundleId")]
            [Validation(Required=true)]
            public string BundleId { get; set; }

            [NameInMap("BundleType")]
            [Validation(Required=true)]
            public string BundleType { get; set; }

            [NameInMap("BundleName")]
            [Validation(Required=true)]
            public string BundleName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }

            [NameInMap("DesktopType")]
            [Validation(Required=true)]
            public string DesktopType { get; set; }

            [NameInMap("Disks")]
            [Validation(Required=true)]
            public List<DescribeBundlesResponseBundlesDisks> Disks { get; set; }
            public class DescribeBundlesResponseBundlesDisks : TeaModel {
                [NameInMap("DiskSize")]
                [Validation(Required=true)]
                public int? DiskSize { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=true)]
                public string DiskType { get; set; }

            }

            [NameInMap("DesktopTypeAttribute")]
            [Validation(Required=true)]
            public DescribeBundlesResponseBundlesDesktopTypeAttribute DesktopTypeAttribute { get; set; }
            public class DescribeBundlesResponseBundlesDesktopTypeAttribute : TeaModel {
                [NameInMap("CpuCount")]
                [Validation(Required=true)]
                public int? CpuCount { get; set; }
                [NameInMap("MemorySize")]
                [Validation(Required=true)]
                public int? MemorySize { get; set; }
                [NameInMap("GpuCount")]
                [Validation(Required=true)]
                public float? GpuCount { get; set; }
                [NameInMap("GpuSpec")]
                [Validation(Required=true)]
                public string GpuSpec { get; set; }
            };

        }

    }

}
