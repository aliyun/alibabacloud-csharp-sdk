// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceAutoScalerRequest : TeaModel {
        [NameInMap("max")]
        [Validation(Required=false)]
        public int? Max { get; set; }

        [NameInMap("min")]
        [Validation(Required=false)]
        public int? Min { get; set; }

        [NameInMap("strategies")]
        [Validation(Required=false)]
        public UpdateServiceAutoScalerRequestStrategies Strategies { get; set; }
        public class UpdateServiceAutoScalerRequestStrategies : TeaModel {
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }
            [NameInMap("qps")]
            [Validation(Required=false)]
            public float? Qps { get; set; }
        };

    }

}
