// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListQueuesResponseBody : TeaModel {
        [NameInMap("Queues")]
        [Validation(Required=false)]
        public ListQueuesResponseBodyQueues Queues { get; set; }
        public class ListQueuesResponseBodyQueues : TeaModel {
            [NameInMap("QueueInfo")]
            [Validation(Required=false)]
            public List<ListQueuesResponseBodyQueuesQueueInfo> QueueInfo { get; set; }
            public class ListQueuesResponseBodyQueuesQueueInfo : TeaModel {
                public ListQueuesResponseBodyQueuesQueueInfoComputeInstanceType ComputeInstanceType { get; set; }
                public class ListQueuesResponseBodyQueuesQueueInfoComputeInstanceType : TeaModel {
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public List<string> InstanceType { get; set; }

                }
                public bool? EnableAutoGrow { get; set; }
                public string HostNamePrefix { get; set; }
                public string HostNameSuffix { get; set; }
                public string ImageId { get; set; }
                public string QueueName { get; set; }
                public string ResourceGroupId { get; set; }
                public ListQueuesResponseBodyQueuesQueueInfoSpotInstanceTypes SpotInstanceTypes { get; set; }
                public class ListQueuesResponseBodyQueuesQueueInfoSpotInstanceTypes : TeaModel {
                    [NameInMap("Instance")]
                    [Validation(Required=false)]
                    public List<ListQueuesResponseBodyQueuesQueueInfoSpotInstanceTypesInstance> Instance { get; set; }
                    public class ListQueuesResponseBodyQueuesQueueInfoSpotInstanceTypesInstance : TeaModel {
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("SpotPriceLimit")]
                        [Validation(Required=false)]
                        public float? SpotPriceLimit { get; set; }

                    }

                }
                public string SpotStrategy { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
