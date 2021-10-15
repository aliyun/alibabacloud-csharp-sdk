// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetElastictaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetElastictaskResponseBodyResult Result { get; set; }
        public class GetElastictaskResponseBodyResult : TeaModel {
            [NameInMap("elasticExpansionTask")]
            [Validation(Required=false)]
            public GetElastictaskResponseBodyResultElasticExpansionTask ElasticExpansionTask { get; set; }
            public class GetElastictaskResponseBodyResultElasticExpansionTask : TeaModel {
                [NameInMap("triggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

                [NameInMap("replicaCount")]
                [Validation(Required=false)]
                public int? ReplicaCount { get; set; }

                [NameInMap("elasticNodeCount")]
                [Validation(Required=false)]
                public int? ElasticNodeCount { get; set; }

                [NameInMap("cronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                [NameInMap("targetIndices")]
                [Validation(Required=false)]
                public List<string> TargetIndices { get; set; }

            }
            [NameInMap("elasticShrinkTask")]
            [Validation(Required=false)]
            public GetElastictaskResponseBodyResultElasticShrinkTask ElasticShrinkTask { get; set; }
            public class GetElastictaskResponseBodyResultElasticShrinkTask : TeaModel {
                [NameInMap("triggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

                [NameInMap("replicaCount")]
                [Validation(Required=false)]
                public int? ReplicaCount { get; set; }

                [NameInMap("elasticNodeCount")]
                [Validation(Required=false)]
                public int? ElasticNodeCount { get; set; }

                [NameInMap("cronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                [NameInMap("targetIndices")]
                [Validation(Required=false)]
                public List<string> TargetIndices { get; set; }

            }
        };

    }

}
