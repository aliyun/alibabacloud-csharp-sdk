// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetQueueResponseBody : TeaModel {
        [NameInMap("Queue")]
        [Validation(Required=false)]
        public GetQueueResponseBodyQueue Queue { get; set; }
        public class GetQueueResponseBodyQueue : TeaModel {
            [NameInMap("AllocationStrategy")]
            [Validation(Required=false)]
            public string AllocationStrategy { get; set; }

            [NameInMap("ComputeNodes")]
            [Validation(Required=false)]
            public List<NodeTemplate> ComputeNodes { get; set; }

            [NameInMap("EnableScaleIn")]
            [Validation(Required=false)]
            public bool? EnableScaleIn { get; set; }

            [NameInMap("EnableScaleOut")]
            [Validation(Required=false)]
            public bool? EnableScaleOut { get; set; }

            [NameInMap("HostnamePrefix")]
            [Validation(Required=false)]
            public string HostnamePrefix { get; set; }

            [NameInMap("HostnameSuffix")]
            [Validation(Required=false)]
            public string HostnameSuffix { get; set; }

            [NameInMap("InitialCount")]
            [Validation(Required=false)]
            public int? InitialCount { get; set; }

            [NameInMap("InterConnect")]
            [Validation(Required=false)]
            public string InterConnect { get; set; }

            [NameInMap("KeepAliveNodes")]
            [Validation(Required=false)]
            public List<string> KeepAliveNodes { get; set; }

            [NameInMap("MaxCount")]
            [Validation(Required=false)]
            public int? MaxCount { get; set; }

            [NameInMap("MaxCountPerCycle")]
            [Validation(Required=false)]
            public long? MaxCountPerCycle { get; set; }

            [NameInMap("MinCount")]
            [Validation(Required=false)]
            public int? MinCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            [NameInMap("RamRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
