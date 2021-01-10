// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SearchPipelineResponseBody : TeaModel {
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
        public SearchPipelineResponseBodyPipelineList PipelineList { get; set; }
        public class SearchPipelineResponseBodyPipelineList : TeaModel {
            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public List<SearchPipelineResponseBodyPipelineListPipeline> Pipeline { get; set; }
            public class SearchPipelineResponseBodyPipelineListPipeline : TeaModel {
                public string Speed { get; set; }
                public string State { get; set; }
                public long? SpeedLevel { get; set; }
                public SearchPipelineResponseBodyPipelineListPipelineNotifyConfig NotifyConfig { get; set; }
                public class SearchPipelineResponseBodyPipelineListPipelineNotifyConfig : TeaModel {
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

    }

}
