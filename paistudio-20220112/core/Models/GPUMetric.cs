// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GPUMetric : TeaModel {
        [NameInMap("Index")]
        [Validation(Required=false)]
        public long? Index { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        [NameInMap("UsageRate")]
        [Validation(Required=false)]
        public float? UsageRate { get; set; }

    }

}
