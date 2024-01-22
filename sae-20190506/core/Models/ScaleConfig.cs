// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ScaleConfig : TeaModel {
        [NameInMap("alwaysAllocateCPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateCPU { get; set; }

        [NameInMap("maximumInstanceCount")]
        [Validation(Required=false)]
        public long? MaximumInstanceCount { get; set; }

        [NameInMap("minimumInstanceCount")]
        [Validation(Required=false)]
        public long? MinimumInstanceCount { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
