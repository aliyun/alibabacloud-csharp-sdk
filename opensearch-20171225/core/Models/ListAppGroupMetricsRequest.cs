// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListAppGroupMetricsRequest : TeaModel {
        [NameInMap("metricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        [NameInMap("indexes")]
        [Validation(Required=false)]
        public string Indexes { get; set; }

    }

}
