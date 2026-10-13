// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListMachineTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the machine types.</para>
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public List<ListMachineTypesResponseBodyMachineTypes> MachineTypes { get; set; }
        public class ListMachineTypesResponseBodyMachineTypes : TeaModel {
            /// <summary>
            /// <para>The number of bonds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("BondNum")]
            [Validation(Required=false)]
            public int? BondNum { get; set; }

            /// <summary>
            /// <para>The CPU information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2x Intel Icelake 8369B 32C CPU</para>
            /// </summary>
            [NameInMap("CpuInfo")]
            [Validation(Required=false)]
            public string CpuInfo { get; set; }

            /// <summary>
            /// <para>The structured CPU specifications.</para>
            /// </summary>
            [NameInMap("CpuInfoDetail")]
            [Validation(Required=false)]
            public ListMachineTypesResponseBodyMachineTypesCpuInfoDetail CpuInfoDetail { get; set; }
            public class ListMachineTypesResponseBodyMachineTypesCpuInfoDetail : TeaModel {
                /// <summary>
                /// <para>The CPU architecture.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x86_64</para>
                /// </summary>
                [NameInMap("CpuArch")]
                [Validation(Required=false)]
                public string CpuArch { get; set; }

                /// <summary>
                /// <para>The number of CPU sockets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CpuSockets")]
                [Validation(Required=false)]
                public int? CpuSockets { get; set; }

                /// <summary>
                /// <para>The number of vCPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192</para>
                /// </summary>
                [NameInMap("VCpuCores")]
                [Validation(Required=false)]
                public int? VCpuCores { get; set; }

            }

            /// <summary>
            /// <para>The disk information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2x 480GB SATA SSD</para>
            /// </summary>
            [NameInMap("DiskInfo")]
            [Validation(Required=false)]
            public string DiskInfo { get; set; }

            /// <summary>
            /// <para>The disk information.</para>
            /// </summary>
            [NameInMap("DiskInfoDetail")]
            [Validation(Required=false)]
            public ListMachineTypesResponseBodyMachineTypesDiskInfoDetail DiskInfoDetail { get; set; }
            public class ListMachineTypesResponseBodyMachineTypesDiskInfoDetail : TeaModel {
                /// <summary>
                /// <para>The number of disks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("LocalDiskCount")]
                [Validation(Required=false)]
                public int? LocalDiskCount { get; set; }

                /// <summary>
                /// <para>The capacity per disk, in TB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.84</para>
                /// </summary>
                [NameInMap("LocalDiskSizeInTB")]
                [Validation(Required=false)]
                public float? LocalDiskSizeInTB { get; set; }

                /// <summary>
                /// <para>The disk type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NVMe SSD</para>
                /// </summary>
                [NameInMap("LocalDiskType")]
                [Validation(Required=false)]
                public string LocalDiskType { get; set; }

            }

            /// <summary>
            /// <para>The frontend network information.</para>
            /// </summary>
            [NameInMap("FrontendNetworkDetail")]
            [Validation(Required=false)]
            public ListMachineTypesResponseBodyMachineTypesFrontendNetworkDetail FrontendNetworkDetail { get; set; }
            public class ListMachineTypesResponseBodyMachineTypesFrontendNetworkDetail : TeaModel {
                /// <summary>
                /// <para>The frontend network type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("FrontendNetworkType")]
                [Validation(Required=false)]
                public string FrontendNetworkType { get; set; }

                /// <summary>
                /// <para>Indicates whether jumbo frames are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("JumboFrameSupported")]
                [Validation(Required=false)]
                public bool? JumboFrameSupported { get; set; }

            }

            /// <summary>
            /// <para>The GPU information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8x NVIDIA SXM4 80GB A100 GPU</para>
            /// </summary>
            [NameInMap("GpuInfo")]
            [Validation(Required=false)]
            public string GpuInfo { get; set; }

            /// <summary>
            /// <para>The GPU information.</para>
            /// </summary>
            [NameInMap("GpuInfoDetail")]
            [Validation(Required=false)]
            public ListMachineTypesResponseBodyMachineTypesGpuInfoDetail GpuInfoDetail { get; set; }
            public class ListMachineTypesResponseBodyMachineTypesGpuInfoDetail : TeaModel {
                /// <summary>
                /// <para>The number of GPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("GpuCount")]
                [Validation(Required=false)]
                public int? GpuCount { get; set; }

                /// <summary>
                /// <para>The GPU memory per card, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>144</para>
                /// </summary>
                [NameInMap("GpuMemoryInGB")]
                [Validation(Required=false)]
                public int? GpuMemoryInGB { get; set; }

                /// <summary>
                /// <para>The GPU name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>M890P-144G</para>
                /// </summary>
                [NameInMap("GpuName")]
                [Validation(Required=false)]
                public string GpuName { get; set; }

                /// <summary>
                /// <para>The GPU vendor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T-HEAD</para>
                /// </summary>
                [NameInMap("GpuVendor")]
                [Validation(Required=false)]
                public string GpuVendor { get; set; }

                /// <summary>
                /// <para>The total GPU memory, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9216</para>
                /// </summary>
                [NameInMap("TotalGpuMemoryInGB")]
                [Validation(Required=false)]
                public int? TotalGpuMemoryInGB { get; set; }

            }

            /// <summary>
            /// <para>The memory information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32x 64GB DDR4 3200 Memory</para>
            /// </summary>
            [NameInMap("MemoryInfo")]
            [Validation(Required=false)]
            public string MemoryInfo { get; set; }

            /// <summary>
            /// <para>The memory information.</para>
            /// </summary>
            [NameInMap("MemoryInfoDetail")]
            [Validation(Required=false)]
            public ListMachineTypesResponseBodyMachineTypesMemoryInfoDetail MemoryInfoDetail { get; set; }
            public class ListMachineTypesResponseBodyMachineTypesMemoryInfoDetail : TeaModel {
                /// <summary>
                /// <para>The memory size, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("MemorySizeInGB")]
                [Validation(Required=false)]
                public int? MemorySizeInGB { get; set; }

            }

            /// <summary>
            /// <para>The name of the machine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>efg1.nvga1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2x 100Gbps DP NIC</para>
            /// </summary>
            [NameInMap("NetworkInfo")]
            [Validation(Required=false)]
            public string NetworkInfo { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public string NodeCount { get; set; }

            /// <summary>
            /// <para>The RDMA information.</para>
            /// </summary>
            [NameInMap("RdmaInfoDetail")]
            [Validation(Required=false)]
            public ListMachineTypesResponseBodyMachineTypesRdmaInfoDetail RdmaInfoDetail { get; set; }
            public class ListMachineTypesResponseBodyMachineTypesRdmaInfoDetail : TeaModel {
                /// <summary>
                /// <para>The bandwidth per backend RDMA NIC, in Gbps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("BackendRdmaNicBwInGbps")]
                [Validation(Required=false)]
                public int? BackendRdmaNicBwInGbps { get; set; }

                /// <summary>
                /// <para>The number of backend RDMA NICs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("BackendRdmaNicCount")]
                [Validation(Required=false)]
                public int? BackendRdmaNicCount { get; set; }

                /// <summary>
                /// <para>Indicates whether backend RDMA is supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The current machine type supports backend RDMA.</description></item>
                /// <item><description>false: The current machine type does not support backend RDMA.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BackendRdmaSupported")]
                [Validation(Required=false)]
                public bool? BackendRdmaSupported { get; set; }

            }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>48</para>
            /// </summary>
            [NameInMap("TotalCpuCore")]
            [Validation(Required=false)]
            public int? TotalCpuCore { get; set; }

            /// <summary>
            /// <para>The machine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The next token for pagination. Include this value in the request to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a3f2224a5ec7224116c4f5246120abe4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F16BA4D8-FF50-53B6-A026-F443FE31006C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
