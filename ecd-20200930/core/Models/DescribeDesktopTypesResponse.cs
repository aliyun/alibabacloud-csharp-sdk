// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopTypesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DesktopTypes")]
        [Validation(Required=true)]
        public List<DescribeDesktopTypesResponseDesktopTypes> DesktopTypes { get; set; }
        public class DescribeDesktopTypesResponseDesktopTypes : TeaModel {
            [NameInMap("DesktopTypeId")]
            [Validation(Required=true)]
            public string DesktopTypeId { get; set; }

            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=true)]
            public string InstanceTypeFamily { get; set; }

            [NameInMap("CpuCount")]
            [Validation(Required=true)]
            public string CpuCount { get; set; }

            [NameInMap("MemorySize")]
            [Validation(Required=true)]
            public string MemorySize { get; set; }

            [NameInMap("GpuCount")]
            [Validation(Required=true)]
            public float? GpuCount { get; set; }

            [NameInMap("GpuSpec")]
            [Validation(Required=true)]
            public string GpuSpec { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=true)]
            public string SystemDiskSize { get; set; }

            [NameInMap("DataDiskSize")]
            [Validation(Required=true)]
            public string DataDiskSize { get; set; }

            [NameInMap("AllowDiskSize")]
            [Validation(Required=true)]
            public List<DescribeDesktopTypesResponseDesktopTypesAllowDiskSize> AllowDiskSize { get; set; }
            public class DescribeDesktopTypesResponseDesktopTypesAllowDiskSize : TeaModel {
                [NameInMap("SystemDiskSize")]
                [Validation(Required=true)]
                public int? SystemDiskSize { get; set; }

                [NameInMap("DataDiskSize")]
                [Validation(Required=true)]
                public int? DataDiskSize { get; set; }

            }

        }

    }

}
