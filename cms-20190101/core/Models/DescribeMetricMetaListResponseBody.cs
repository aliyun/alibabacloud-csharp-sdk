// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricMetaListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeMetricMetaListResponseBodyResources Resources { get; set; }
        public class DescribeMetricMetaListResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeMetricMetaListResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeMetricMetaListResponseBodyResourcesResource : TeaModel {
                public string MetricName { get; set; }
                public string Description { get; set; }
                public string Labels { get; set; }
                public string Unit { get; set; }
                public string Dimensions { get; set; }
                public string Namespace { get; set; }
                public string Periods { get; set; }
                public string Statistics { get; set; }
            }
        };

    }

}
