// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListDashboardDetailsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDashboardDetailsResponseBodyResult> Result { get; set; }
        public class ListDashboardDetailsResponseBodyResult : TeaModel {
            [NameInMap("MetricRes")]
            [Validation(Required=false)]
            public ListDashboardDetailsResponseBodyResultMetricRes MetricRes { get; set; }
            public class ListDashboardDetailsResponseBodyResultMetricRes : TeaModel {
                [NameInMap("Total")]
                [Validation(Required=false)]
                public Dictionary<string, string> Total { get; set; }
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public Dictionary<string, string> Detail { get; set; }
            };

            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

    }

}
