// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
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
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
