// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryPipelineListResponseBody : TeaModel {
        [NameInMap("NonExistPids")]
        [Validation(Required=false)]
        public QueryPipelineListResponseBodyNonExistPids NonExistPids { get; set; }
        public class QueryPipelineListResponseBodyNonExistPids : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        [NameInMap("PipelineList")]
        [Validation(Required=false)]
        public QueryPipelineListResponseBodyPipelineList PipelineList { get; set; }
        public class QueryPipelineListResponseBodyPipelineList : TeaModel {
            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public List<QueryPipelineListResponseBodyPipelineListPipeline> Pipeline { get; set; }
            public class QueryPipelineListResponseBodyPipelineListPipeline : TeaModel {
                [NameInMap("ExtendConfig")]
                [Validation(Required=false)]
                public QueryPipelineListResponseBodyPipelineListPipelineExtendConfig ExtendConfig { get; set; }
                public class QueryPipelineListResponseBodyPipelineListPipelineExtendConfig : TeaModel {
                    [NameInMap("IsBoostNew")]
                    [Validation(Required=false)]
                    public bool? IsBoostNew { get; set; }

                    [NameInMap("MaxMultiSpeed")]
                    [Validation(Required=false)]
                    public int? MaxMultiSpeed { get; set; }

                    [NameInMap("MultiSpeedDowngradePolicy")]
                    [Validation(Required=false)]
                    public string MultiSpeedDowngradePolicy { get; set; }

                }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NotifyConfig")]
                [Validation(Required=false)]
                public QueryPipelineListResponseBodyPipelineListPipelineNotifyConfig NotifyConfig { get; set; }
                public class QueryPipelineListResponseBodyPipelineListPipelineNotifyConfig : TeaModel {
                    [NameInMap("MqTag")]
                    [Validation(Required=false)]
                    public string MqTag { get; set; }

                    [NameInMap("MqTopic")]
                    [Validation(Required=false)]
                    public string MqTopic { get; set; }

                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

                [NameInMap("QuotaAllocate")]
                [Validation(Required=false)]
                public long? QuotaAllocate { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("Speed")]
                [Validation(Required=false)]
                public string Speed { get; set; }

                [NameInMap("SpeedLevel")]
                [Validation(Required=false)]
                public long? SpeedLevel { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1C538EAA-ACAF-5AD8-B091-A72C63007149</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
