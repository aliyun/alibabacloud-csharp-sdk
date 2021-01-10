// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryPipelineListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PipelineList")]
        [Validation(Required=false)]
        public QueryPipelineListResponseBodyPipelineList PipelineList { get; set; }
        public class QueryPipelineListResponseBodyPipelineList : TeaModel {
            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public List<QueryPipelineListResponseBodyPipelineListPipeline> Pipeline { get; set; }
            public class QueryPipelineListResponseBodyPipelineListPipeline : TeaModel {
                public string Speed { get; set; }
                public string State { get; set; }
                public long? SpeedLevel { get; set; }
                public QueryPipelineListResponseBodyPipelineListPipelineNotifyConfig NotifyConfig { get; set; }
                public class QueryPipelineListResponseBodyPipelineListPipelineNotifyConfig : TeaModel {
                    [NameInMap("MqTopic")]
                    [Validation(Required=false)]
                    public string MqTopic { get; set; }

                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    [NameInMap("MqTag")]
                    [Validation(Required=false)]
                    public string MqTag { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }
                public string Role { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
                public long? QuotaAllocate { get; set; }
            }
        };

        [NameInMap("NonExistPids")]
        [Validation(Required=false)]
        public QueryPipelineListResponseBodyNonExistPids NonExistPids { get; set; }
        public class QueryPipelineListResponseBodyNonExistPids : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
