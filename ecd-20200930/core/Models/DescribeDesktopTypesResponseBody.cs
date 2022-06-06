// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopTypesResponseBody : TeaModel {
        [NameInMap("DesktopTypes")]
        [Validation(Required=false)]
        public List<DescribeDesktopTypesResponseBodyDesktopTypes> DesktopTypes { get; set; }
        public class DescribeDesktopTypesResponseBodyDesktopTypes : TeaModel {
            [NameInMap("CpuCount")]
            [Validation(Required=false)]
            public string CpuCount { get; set; }

            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            [NameInMap("DesktopTypeId")]
            [Validation(Required=false)]
            public string DesktopTypeId { get; set; }

            [NameInMap("DesktopTypeStatus")]
            [Validation(Required=false)]
            public string DesktopTypeStatus { get; set; }

            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public string SystemDiskSize { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
