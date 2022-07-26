// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ResourceConfig : TeaModel {
        [NameInMap("CPU")]
        [Validation(Required=false)]
        public string CPU { get; set; }

        [NameInMap("GPU")]
        [Validation(Required=false)]
        public string GPU { get; set; }

        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        [NameInMap("SharedMemory")]
        [Validation(Required=false)]
        public string SharedMemory { get; set; }

    }

}
