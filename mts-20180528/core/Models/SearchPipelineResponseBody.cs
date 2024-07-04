// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class SearchPipelineResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PipelineList")]
        [Validation(Required=false)]
        public SearchPipelineResponseBodyPipelineList PipelineList { get; set; }
        public class SearchPipelineResponseBodyPipelineList : TeaModel {
            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public List<SearchPipelineResponseBodyPipelineListPipeline> Pipeline { get; set; }
            public class SearchPipelineResponseBodyPipelineListPipeline : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NotifyConfig")]
                [Validation(Required=false)]
                public SearchPipelineResponseBodyPipelineListPipelineNotifyConfig NotifyConfig { get; set; }
                public class SearchPipelineResponseBodyPipelineListPipelineNotifyConfig : TeaModel {
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

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
