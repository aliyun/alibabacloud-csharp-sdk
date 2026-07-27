// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Queries : TeaModel {
        [NameInMap("end")]
        [Validation(Required=false)]
        public long? End { get; set; }

        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<LabelFilters> LabelFilters { get; set; }

        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        [NameInMap("timeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

        [NameInMap("window")]
        [Validation(Required=false)]
        public long? Window { get; set; }

    }

}
