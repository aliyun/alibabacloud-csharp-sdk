// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopTypesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DesktopTypes")]
        [Validation(Required=false)]
        public List<DescribeDesktopTypesResponseBodyDesktopTypes> DesktopTypes { get; set; }
        public class DescribeDesktopTypesResponseBodyDesktopTypes : TeaModel {
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public string SystemDiskSize { get; set; }

            [NameInMap("DesktopTypeId")]
            [Validation(Required=false)]
            public string DesktopTypeId { get; set; }

            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            [NameInMap("CpuCount")]
            [Validation(Required=false)]
            public string CpuCount { get; set; }

            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public int? GpuCount { get; set; }

            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            [NameInMap("AllowDiskSize")]
            [Validation(Required=false)]
            public List<DescribeDesktopTypesResponseBodyDesktopTypesAllowDiskSize> AllowDiskSize { get; set; }
            public class DescribeDesktopTypesResponseBodyDesktopTypesAllowDiskSize : TeaModel {
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                [NameInMap("DataDiskSize")]
                [Validation(Required=false)]
                public int? DataDiskSize { get; set; }

            }

        }

    }

}
