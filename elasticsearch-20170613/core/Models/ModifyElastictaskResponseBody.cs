// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ModifyElastictaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ModifyElastictaskResponseBodyResult Result { get; set; }
        public class ModifyElastictaskResponseBodyResult : TeaModel {
            [NameInMap("elasticExpansionTask")]
            [Validation(Required=false)]
            public ModifyElastictaskResponseBodyResultElasticExpansionTask ElasticExpansionTask { get; set; }
            public class ModifyElastictaskResponseBodyResultElasticExpansionTask : TeaModel {
                [NameInMap("cronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                [NameInMap("elasticNodeCount")]
                [Validation(Required=false)]
                public int? ElasticNodeCount { get; set; }

                [NameInMap("replicaCount")]
                [Validation(Required=false)]
                public int? ReplicaCount { get; set; }

                [NameInMap("targetIndices")]
                [Validation(Required=false)]
                public List<string> TargetIndices { get; set; }

                [NameInMap("triggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

            }

            [NameInMap("elasticShrinkTask")]
            [Validation(Required=false)]
            public ModifyElastictaskResponseBodyResultElasticShrinkTask ElasticShrinkTask { get; set; }
            public class ModifyElastictaskResponseBodyResultElasticShrinkTask : TeaModel {
                [NameInMap("cronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                [NameInMap("elasticNodeCount")]
                [Validation(Required=false)]
                public int? ElasticNodeCount { get; set; }

                [NameInMap("replicaCount")]
                [Validation(Required=false)]
                public int? ReplicaCount { get; set; }

                [NameInMap("targetIndices")]
                [Validation(Required=false)]
                public List<string> TargetIndices { get; set; }

                [NameInMap("triggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

            }

        }

    }

}
