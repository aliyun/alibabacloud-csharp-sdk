// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticMetricSetsResponseBody : TeaModel {
        [NameInMap("MetricSets")]
        [Validation(Required=false)]
        public List<DescribeDiagnosticMetricSetsResponseBodyMetricSets> MetricSets { get; set; }
        public class DescribeDiagnosticMetricSetsResponseBodyMetricSets : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("MetricIds")]
            [Validation(Required=false)]
            public List<string> MetricIds { get; set; }

            [NameInMap("MetricSetId")]
            [Validation(Required=false)]
            public string MetricSetId { get; set; }

            [NameInMap("MetricSetName")]
            [Validation(Required=false)]
            public string MetricSetName { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
