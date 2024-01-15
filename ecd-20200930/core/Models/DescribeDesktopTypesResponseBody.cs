// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopTypesResponseBody : TeaModel {
        /// <summary>
        /// Details of cloud desktop types.
        /// </summary>
        [NameInMap("DesktopTypes")]
        [Validation(Required=false)]
        public List<DescribeDesktopTypesResponseBodyDesktopTypes> DesktopTypes { get; set; }
        public class DescribeDesktopTypesResponseBodyDesktopTypes : TeaModel {
            /// <summary>
            /// The number of vCPUs.
            /// </summary>
            [NameInMap("CpuCount")]
            [Validation(Required=false)]
            public string CpuCount { get; set; }

            /// <summary>
            /// The size of the data disk. Unit: GiB.
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            /// <summary>
            /// The ID of the cloud desktop type.
            /// </summary>
            [NameInMap("DesktopTypeId")]
            [Validation(Required=false)]
            public string DesktopTypeId { get; set; }

            /// <summary>
            /// The status of the cloud desktop type. If SUFFICIENT is returned, the number of cloud desktops of the type is sufficient.
            /// </summary>
            [NameInMap("DesktopTypeStatus")]
            [Validation(Required=false)]
            public string DesktopTypeStatus { get; set; }

            /// <summary>
            /// The number of GPUs.
            /// </summary>
            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            /// <summary>
            /// The GPU memory.
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// The family of the cloud desktop type.
            /// </summary>
            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            /// <summary>
            /// The memory size. Unit: MiB.
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            /// <summary>
            /// The size of the system disk. Unit: GiB.
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public string SystemDiskSize { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
