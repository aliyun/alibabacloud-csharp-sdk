// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class MetricsTrigger : TeaModel {
        [NameInMap("ComparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        [NameInMap("CoolDownInterval")]
        [Validation(Required=false)]
        public int? CoolDownInterval { get; set; }

        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

        [NameInMap("TimeWindow")]
        [Validation(Required=false)]
        public int? TimeWindow { get; set; }

    }

}
