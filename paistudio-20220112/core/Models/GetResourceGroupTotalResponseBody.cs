// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetResourceGroupTotalResponseBody : TeaModel {
        [NameInMap("totalCPU")]
        [Validation(Required=false)]
        public int? TotalCPU { get; set; }

        [NameInMap("totalGPU")]
        [Validation(Required=false)]
        public int? TotalGPU { get; set; }

        [NameInMap("totalGPUInfos")]
        [Validation(Required=false)]
        public List<GPUInfo> TotalGPUInfos { get; set; }

        [NameInMap("totalMemory")]
        [Validation(Required=false)]
        public int? TotalMemory { get; set; }

    }

}
