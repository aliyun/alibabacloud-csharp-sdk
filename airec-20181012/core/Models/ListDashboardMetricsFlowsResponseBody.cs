// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListDashboardMetricsFlowsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDashboardMetricsFlowsResponseBodyResult> Result { get; set; }
        public class ListDashboardMetricsFlowsResponseBodyResult : TeaModel {
            [NameInMap("MetricData")]
            [Validation(Required=false)]
            public Dictionary<string, object> MetricData { get; set; }

            [NameInMap("MetricType")]
            [Validation(Required=false)]
            public string MetricType { get; set; }

        }

    }

}
