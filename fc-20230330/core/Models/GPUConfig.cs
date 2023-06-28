// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class GPUConfig : TeaModel {
        [NameInMap("gpuMemorySize")]
        [Validation(Required=false)]
        public int? GpuMemorySize { get; set; }

        [NameInMap("gpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

    }

}
