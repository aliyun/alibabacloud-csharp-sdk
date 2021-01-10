// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryTerrorismPipelineListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PipelineList")]
        [Validation(Required=false)]
        public QueryTerrorismPipelineListResponseBodyPipelineList PipelineList { get; set; }
        public class QueryTerrorismPipelineListResponseBodyPipelineList : TeaModel {
            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public List<QueryTerrorismPipelineListResponseBodyPipelineListPipeline> Pipeline { get; set; }
            public class QueryTerrorismPipelineListResponseBodyPipelineListPipeline : TeaModel {
                public string State { get; set; }
                public QueryTerrorismPipelineListResponseBodyPipelineListPipelineNotifyConfig NotifyConfig { get; set; }
                public class QueryTerrorismPipelineListResponseBodyPipelineListPipelineNotifyConfig : TeaModel {
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    [NameInMap("Queue")]
                    [Validation(Required=false)]
                    public string Queue { get; set; }

                }
                public string Priority { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
            }
        };

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryTerrorismPipelineListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryTerrorismPipelineListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
