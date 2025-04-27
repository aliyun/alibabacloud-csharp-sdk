// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ModifyElastictaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D****</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>0 0 0 ? * MON</para>
                /// </summary>
                [NameInMap("cronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("elasticNodeCount")]
                [Validation(Required=false)]
                public int? ElasticNodeCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("replicaCount")]
                [Validation(Required=false)]
                public int? ReplicaCount { get; set; }

                [NameInMap("targetIndices")]
                [Validation(Required=false)]
                public List<string> TargetIndices { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>crontab</para>
                /// </summary>
                [NameInMap("triggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

            }

            [NameInMap("elasticShrinkTask")]
            [Validation(Required=false)]
            public ModifyElastictaskResponseBodyResultElasticShrinkTask ElasticShrinkTask { get; set; }
            public class ModifyElastictaskResponseBodyResultElasticShrinkTask : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>4 4 4 ? * WED</para>
                /// </summary>
                [NameInMap("cronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("elasticNodeCount")]
                [Validation(Required=false)]
                public int? ElasticNodeCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("replicaCount")]
                [Validation(Required=false)]
                public int? ReplicaCount { get; set; }

                [NameInMap("targetIndices")]
                [Validation(Required=false)]
                public List<string> TargetIndices { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>crontab</para>
                /// </summary>
                [NameInMap("triggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

            }

        }

    }

}
