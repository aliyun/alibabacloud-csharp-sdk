// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the specifications.</para>
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
            /// <para>The size of the data disk, in GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The specification ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd.graphics.xlarge</para>
            /// </summary>
            [NameInMap("DesktopTypeId")]
            [Validation(Required=false)]
            public string DesktopTypeId { get; set; }

            /// <summary>
            /// <para>The availability of the specification. A value of <c>SUFFICIENT</c> indicates that the specification is in stock.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUFFICIENT</para>
            /// </summary>
            [NameInMap("DesktopTypeStatus")]
            [Validation(Required=false)]
            public string DesktopTypeStatus { get; set; }

            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The number of GPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            /// <summary>
            /// <para>The GPU memory size in MiB. This parameter is valid only for GPU-accelerated cloud desktops.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("GpuMemory")]
            [Validation(Required=false)]
            public int? GpuMemory { get; set; }

            /// <summary>
            /// <para>The GPU memory size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16 GiB</para>
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <para>The instance type family.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd.graphics</para>
            /// </summary>
            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent sessions that is supported by the cloud desktop specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MaxSessionCount")]
            [Validation(Required=false)]
            public int? MaxSessionCount { get; set; }

            /// <summary>
            /// <para>The memory size, in MiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23552</para>
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            /// <summary>
            /// <para>The purchase options for the specification.</para>
            /// </summary>
            [NameInMap("Scopes")]
            [Validation(Required=false)]
            public List<string> Scopes { get; set; }

            /// <summary>
            /// <para>The inventory status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sufficient</para>
            /// </summary>
            [NameInMap("StockState")]
            [Validation(Required=false)]
            public string StockState { get; set; }

            /// <summary>
            /// <para>The size of the system disk, in GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public string SystemDiskSize { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
