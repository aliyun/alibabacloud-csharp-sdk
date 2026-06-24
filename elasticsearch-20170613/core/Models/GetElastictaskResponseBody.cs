// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetElastictaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetElastictaskResponseBodyResult Result { get; set; }
        public class GetElastictaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The elastic scale-out rule.</para>
            /// </summary>
            [NameInMap("elasticExpansionTask")]
            [Validation(Required=false)]
            public GetElastictaskResponseBodyResultElasticExpansionTask ElasticExpansionTask { get; set; }
            public class GetElastictaskResponseBodyResultElasticExpansionTask : TeaModel {
                /// <summary>
                /// <para>The trigger cycle, specified as a Quartz Cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 0 ? * MON</para>
                /// </summary>
                [NameInMap("cronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>The number of elastic data nodes during peak hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("elasticNodeCount")]
                [Validation(Required=false)]
                public int? ElasticNodeCount { get; set; }

                /// <summary>
                /// <para>The number of replicas for the target index.</para>
                /// 
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
                /// <para>The cause. Currently, only <b>crontab</b> is supported, which indicates scheduled triggering.</para>
                /// 
                /// <b>Example:</b>
                /// <para>crontab</para>
                /// </summary>
                [NameInMap("triggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

            }

            /// <summary>
            /// <para>The elastic scale-in rule.</para>
            /// </summary>
            [NameInMap("elasticShrinkTask")]
            [Validation(Required=false)]
            public GetElastictaskResponseBodyResultElasticShrinkTask ElasticShrinkTask { get; set; }
            public class GetElastictaskResponseBodyResultElasticShrinkTask : TeaModel {
                /// <summary>
                /// <para>The trigger cycle, specified as a Quartz Cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4 4 4 ? * WED</para>
                /// </summary>
                [NameInMap("cronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>The number of elastic data nodes during off-peak hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("elasticNodeCount")]
                [Validation(Required=false)]
                public int? ElasticNodeCount { get; set; }

                /// <summary>
                /// <para>The number of replicas for the target index.</para>
                /// 
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
                /// <para>The cause. Currently, only crontab is supported, which indicates scheduled triggering.</para>
                /// 
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
