// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GPUDetail : TeaModel {
        [NameInMap("GPU")]
        [Validation(Required=false)]
        public string GPU { get; set; }

        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        [NameInMap("GPUTypeFullName")]
        [Validation(Required=false)]
        public string GPUTypeFullName { get; set; }

    }

}
