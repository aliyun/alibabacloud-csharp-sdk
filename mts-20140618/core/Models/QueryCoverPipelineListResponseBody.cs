// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryCoverPipelineListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PipelineList")]
        [Validation(Required=false)]
        public QueryCoverPipelineListResponseBodyPipelineList PipelineList { get; set; }
        public class QueryCoverPipelineListResponseBodyPipelineList : TeaModel {
            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public List<QueryCoverPipelineListResponseBodyPipelineListPipeline> Pipeline { get; set; }
            public class QueryCoverPipelineListResponseBodyPipelineListPipeline : TeaModel {
                public string State { get; set; }
                public QueryCoverPipelineListResponseBodyPipelineListPipelineNotifyConfig NotifyConfig { get; set; }
                public class QueryCoverPipelineListResponseBodyPipelineListPipelineNotifyConfig : TeaModel {
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    [NameInMap("Queue")]
                    [Validation(Required=false)]
                    public string Queue { get; set; }

                }
                public string Priority { get; set; }
                public string Role { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
            }
        };

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryCoverPipelineListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryCoverPipelineListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
