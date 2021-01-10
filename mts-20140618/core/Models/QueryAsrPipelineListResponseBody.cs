// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryAsrPipelineListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PipelineList")]
        [Validation(Required=false)]
        public QueryAsrPipelineListResponseBodyPipelineList PipelineList { get; set; }
        public class QueryAsrPipelineListResponseBodyPipelineList : TeaModel {
            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public List<QueryAsrPipelineListResponseBodyPipelineListPipeline> Pipeline { get; set; }
            public class QueryAsrPipelineListResponseBodyPipelineListPipeline : TeaModel {
                public string State { get; set; }
                public QueryAsrPipelineListResponseBodyPipelineListPipelineNotifyConfig NotifyConfig { get; set; }
                public class QueryAsrPipelineListResponseBodyPipelineListPipelineNotifyConfig : TeaModel {
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }
                public string Priority { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
            }
        };

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryAsrPipelineListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryAsrPipelineListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
