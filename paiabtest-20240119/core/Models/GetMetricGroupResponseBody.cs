// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIABTest20240119.Models
{
    public class GetMetricGroupResponseBody : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("MetricGroupId")]
        [Validation(Required=false)]
        public string MetricGroupId { get; set; }

        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<GetMetricGroupResponseBodyMetrics> Metrics { get; set; }
        public class GetMetricGroupResponseBodyMetrics : TeaModel {
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("MetricId")]
            [Validation(Required=false)]
            public string MetricId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RelatedExperimentNumber")]
            [Validation(Required=false)]
            public long? RelatedExperimentNumber { get; set; }

            [NameInMap("SourceTableMetaId")]
            [Validation(Required=false)]
            public string SourceTableMetaId { get; set; }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
