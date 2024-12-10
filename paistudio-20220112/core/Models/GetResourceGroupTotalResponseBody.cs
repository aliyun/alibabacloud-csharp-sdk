// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetResourceGroupTotalResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCPU")]
        [Validation(Required=false)]
        public int? TotalCPU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("totalGPU")]
        [Validation(Required=false)]
        public int? TotalGPU { get; set; }

        [NameInMap("totalGPUInfos")]
        [Validation(Required=false)]
        public List<GPUInfo> TotalGPUInfos { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("totalMemory")]
        [Validation(Required=false)]
        public int? TotalMemory { get; set; }

    }

}
