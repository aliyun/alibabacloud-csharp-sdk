// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Optimization : TeaModel {
        [NameInMap("LearningRate")]
        [Validation(Required=false)]
        public float? LearningRate { get; set; }

        [NameInMap("Optimizer")]
        [Validation(Required=false)]
        public string Optimizer { get; set; }

    }

}
