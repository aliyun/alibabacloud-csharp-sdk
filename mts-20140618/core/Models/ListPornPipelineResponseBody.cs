// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListPornPipelineResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PipelineList")]
        [Validation(Required=false)]
        public ListPornPipelineResponseBodyPipelineList PipelineList { get; set; }
        public class ListPornPipelineResponseBodyPipelineList : TeaModel {
            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public List<ListPornPipelineResponseBodyPipelineListPipeline> Pipeline { get; set; }
            public class ListPornPipelineResponseBodyPipelineListPipeline : TeaModel {
                public string State { get; set; }
                public ListPornPipelineResponseBodyPipelineListPipelineNotifyConfig NotifyConfig { get; set; }
                public class ListPornPipelineResponseBodyPipelineListPipelineNotifyConfig : TeaModel {
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

    }

}
