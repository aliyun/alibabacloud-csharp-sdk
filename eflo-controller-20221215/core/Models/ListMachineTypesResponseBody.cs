// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListMachineTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance types.</para>
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
            /// <para>The disk information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2x 480GB SATA SSD</para>
            /// </summary>
            [NameInMap("DiskInfo")]
            [Validation(Required=false)]
            public string DiskInfo { get; set; }

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
            /// <para>The storage information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32x 64GB DDR4 3200 Memory</para>
            /// </summary>
            [NameInMap("MemoryInfo")]
            [Validation(Required=false)]
            public string MemoryInfo { get; set; }

            /// <summary>
            /// <para>The name of the instance type.</para>
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
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>48</para>
            /// </summary>
            [NameInMap("TotalCpuCore")]
            [Validation(Required=false)]
            public int? TotalCpuCore { get; set; }

            /// <summary>
            /// <para>The access type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a3f2224a5ec7224116c4f5246120abe4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F16BA4D8-FF50-53B6-A026-F443FE31006C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
