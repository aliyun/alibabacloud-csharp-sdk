// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListAsrPipelineResponseBody : TeaModel {
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
        public ListAsrPipelineResponseBodyPipelineList PipelineList { get; set; }
        public class ListAsrPipelineResponseBodyPipelineList : TeaModel {
            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public List<ListAsrPipelineResponseBodyPipelineListPipeline> Pipeline { get; set; }
            public class ListAsrPipelineResponseBodyPipelineListPipeline : TeaModel {
                public string State { get; set; }
                public ListAsrPipelineResponseBodyPipelineListPipelineNotifyConfig NotifyConfig { get; set; }
                public class ListAsrPipelineResponseBodyPipelineListPipelineNotifyConfig : TeaModel {
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

    }

}
