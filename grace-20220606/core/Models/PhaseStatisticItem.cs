// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Grace20220606.Models
{
    public class PhaseStatisticItem : TeaModel {
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("durationAvg")]
        [Validation(Required=false)]
        public double? DurationAvg { get; set; }

        [NameInMap("durationMax")]
        [Validation(Required=false)]
        public double? DurationMax { get; set; }

        [NameInMap("durationTotal")]
        [Validation(Required=false)]
        public double? DurationTotal { get; set; }

        [NameInMap("intervalAvg")]
        [Validation(Required=false)]
        public double? IntervalAvg { get; set; }

        [NameInMap("intervalMin")]
        [Validation(Required=false)]
        public double? IntervalMin { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
