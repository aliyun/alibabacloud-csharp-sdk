// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListDashboardDetailsFlowsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListDashboardDetailsFlowsResponseBodyResult Result { get; set; }
        public class ListDashboardDetailsFlowsResponseBodyResult : TeaModel {
            [NameInMap("MetricData")]
            [Validation(Required=false)]
            public List<ListDashboardDetailsFlowsResponseBodyResultMetricData> MetricData { get; set; }
            public class ListDashboardDetailsFlowsResponseBodyResultMetricData : TeaModel {
                public Dictionary<string, string> MetricRes { get; set; }
                public string SceneId { get; set; }
                public string TraceId { get; set; }
            }
            [NameInMap("MetricType")]
            [Validation(Required=false)]
            public string MetricType { get; set; }
        };

    }

}
