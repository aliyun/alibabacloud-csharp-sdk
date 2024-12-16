// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of cloud desktop types.</para>
        /// </summary>
        [NameInMap("DesktopTypes")]
        [Validation(Required=false)]
        public List<DescribeDesktopTypesResponseBodyDesktopTypes> DesktopTypes { get; set; }
        public class DescribeDesktopTypesResponseBodyDesktopTypes : TeaModel {
            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CpuCount")]
            [Validation(Required=false)]
            public string CpuCount { get; set; }

            /// <summary>
            /// <para>The size of the data disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            /// <summary>
            /// <para>The ID of the cloud desktop type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd.graphics.xlarge</para>
            /// </summary>
            [NameInMap("DesktopTypeId")]
            [Validation(Required=false)]
            public string DesktopTypeId { get; set; }

            /// <summary>
            /// <para>The status of the cloud desktop type. If SUFFICIENT is returned, the number of cloud desktops of the type is sufficient.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUFFICIENT</para>
            /// </summary>
            [NameInMap("DesktopTypeStatus")]
            [Validation(Required=false)]
            public string DesktopTypeStatus { get; set; }

            /// <summary>
            /// <para>The number of GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            [NameInMap("GpuMemory")]
            [Validation(Required=false)]
            public int? GpuMemory { get; set; }

            /// <summary>
            /// <para>The GPU memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16 GiB</para>
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <para>The family of the cloud desktop type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd.graphics</para>
            /// </summary>
            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: MiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23552</para>
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            [NameInMap("Scopes")]
            [Validation(Required=false)]
            public List<string> Scopes { get; set; }

            [NameInMap("StockState")]
            [Validation(Required=false)]
            public string StockState { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public string SystemDiskSize { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
