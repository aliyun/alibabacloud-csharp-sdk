// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Schedule : TeaModel {
        [NameInMap("Gamma")]
        [Validation(Required=false)]
        public float? Gamma { get; set; }

        [NameInMap("LRScheduler")]
        [Validation(Required=false)]
        public string LRScheduler { get; set; }

        [NameInMap("StepSize")]
        [Validation(Required=false)]
        public long? StepSize { get; set; }

    }

}
