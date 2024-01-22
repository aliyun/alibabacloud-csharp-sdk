// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class MetricInfo : TeaModel {
        [NameInMap("Average")]
        [Validation(Required=false)]
        public float? Average { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public float? Count { get; set; }

        [NameInMap("Maximum")]
        [Validation(Required=false)]
        public float? Maximum { get; set; }

        [NameInMap("Minimum")]
        [Validation(Required=false)]
        public float? Minimum { get; set; }

        [NameInMap("Sum")]
        [Validation(Required=false)]
        public float? Sum { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

    }

}
