// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListABMetricsResponseBody : TeaModel {
        [NameInMap("ABMetrics")]
        [Validation(Required=false)]
        public List<ListABMetricsResponseBodyABMetrics> ABMetrics { get; set; }
        public class ListABMetricsResponseBodyABMetrics : TeaModel {
            [NameInMap("ABMetricId")]
            [Validation(Required=false)]
            public string ABMetricId { get; set; }

            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("LeftMetricId")]
            [Validation(Required=false)]
            public string LeftMetricId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Realtime")]
            [Validation(Required=false)]
            public string Realtime { get; set; }

            [NameInMap("ResultResourceId")]
            [Validation(Required=false)]
            public string ResultResourceId { get; set; }

            [NameInMap("ResultTableMetaId")]
            [Validation(Required=false)]
            public string ResultTableMetaId { get; set; }

            [NameInMap("RightMetricId")]
            [Validation(Required=false)]
            public string RightMetricId { get; set; }

            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("StatisticsCycle")]
            [Validation(Required=false)]
            public int? StatisticsCycle { get; set; }

            [NameInMap("TableMetaId")]
            [Validation(Required=false)]
            public string TableMetaId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
