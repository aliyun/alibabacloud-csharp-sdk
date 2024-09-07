// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListQueuesResponseBody : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Queues")]
        [Validation(Required=false)]
        public List<ListQueuesResponseBodyQueues> Queues { get; set; }
        public class ListQueuesResponseBodyQueues : TeaModel {
            [NameInMap("ComputeNodes")]
            [Validation(Required=false)]
            public List<NodeTemplate> ComputeNodes { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EnableScaleIn")]
            [Validation(Required=false)]
            public bool? EnableScaleIn { get; set; }

            [NameInMap("EnableScaleOut")]
            [Validation(Required=false)]
            public bool? EnableScaleOut { get; set; }

            [NameInMap("MaxCount")]
            [Validation(Required=false)]
            public int? MaxCount { get; set; }

            [NameInMap("MaxCountPerCycle")]
            [Validation(Required=false)]
            public int? MaxCountPerCycle { get; set; }

            [NameInMap("MinCount")]
            [Validation(Required=false)]
            public int? MinCount { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public ListQueuesResponseBodyQueuesNodes Nodes { get; set; }
            public class ListQueuesResponseBodyQueuesNodes : TeaModel {
                [NameInMap("CreatingCounts")]
                [Validation(Required=false)]
                public int? CreatingCounts { get; set; }

                [NameInMap("ExceptionCounts")]
                [Validation(Required=false)]
                public int? ExceptionCounts { get; set; }

                [NameInMap("RunningCounts")]
                [Validation(Required=false)]
                public int? RunningCounts { get; set; }

            }

            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            [NameInMap("TotalCores")]
            [Validation(Required=false)]
            public int? TotalCores { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
