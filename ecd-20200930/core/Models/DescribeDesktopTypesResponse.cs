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

            [NameInMap("GPUCount")]
            [Validation(Required=true)]
            public string GPUCount { get; set; }

            [NameInMap("MemorySize")]
            [Validation(Required=true)]
            public string MemorySize { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=true)]
            public string SystemDiskSize { get; set; }

            [NameInMap("DataDiskSize")]
            [Validation(Required=true)]
            public string DataDiskSize { get; set; }

        }

    }

}
