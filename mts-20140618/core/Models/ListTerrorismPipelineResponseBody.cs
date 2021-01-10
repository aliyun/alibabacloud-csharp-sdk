// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListTerrorismPipelineResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PipelineList")]
        [Validation(Required=false)]
        public ListTerrorismPipelineResponseBodyPipelineList PipelineList { get; set; }
        public class ListTerrorismPipelineResponseBodyPipelineList : TeaModel {
            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public List<ListTerrorismPipelineResponseBodyPipelineListPipeline> Pipeline { get; set; }
            public class ListTerrorismPipelineResponseBodyPipelineListPipeline : TeaModel {
                public string Id { get; set; }
                public string Name { get; set; }
                public string State { get; set; }
                public string Priority { get; set; }
                public ListTerrorismPipelineResponseBodyPipelineListPipelineNotifyConfig NotifyConfig { get; set; }
                public class ListTerrorismPipelineResponseBodyPipelineListPipelineNotifyConfig : TeaModel {
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    [NameInMap("Queue")]
                    [Validation(Required=false)]
                    public string Queue { get; set; }

                }
            }
        };

    }

}
