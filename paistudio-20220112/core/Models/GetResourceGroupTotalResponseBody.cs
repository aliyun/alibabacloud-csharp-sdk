// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetResourceGroupTotalResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCPU")]
        [Validation(Required=false)]
        public int? TotalCPU { get; set; }

        /// <summary>
        /// <para>The total number of GPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("totalGPU")]
        [Validation(Required=false)]
        public int? TotalGPU { get; set; }

        /// <summary>
        /// <para>The resources counted by GPU card type.</para>
        /// </summary>
        [NameInMap("totalGPUInfos")]
        [Validation(Required=false)]
        public List<GPUInfo> TotalGPUInfos { get; set; }

        /// <summary>
        /// <para>The total memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("totalMemory")]
        [Validation(Required=false)]
        public int? TotalMemory { get; set; }

    }

}
