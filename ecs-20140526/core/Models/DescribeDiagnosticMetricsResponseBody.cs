// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticMetricsResponseBody : TeaModel {
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<DescribeDiagnosticMetricsResponseBodyMetrics> Metrics { get; set; }
        public class DescribeDiagnosticMetricsResponseBodyMetrics : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GuestMetric")]
            [Validation(Required=false)]
            public bool? GuestMetric { get; set; }

            [NameInMap("MetricCategory")]
            [Validation(Required=false)]
            public string MetricCategory { get; set; }

            [NameInMap("MetricId")]
            [Validation(Required=false)]
            public string MetricId { get; set; }

            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("SupportedOperatingSystem")]
            [Validation(Required=false)]
            public string SupportedOperatingSystem { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
