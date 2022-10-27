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
                [NameInMap("ComputeInstanceType")]
                [Validation(Required=false)]
                public ListQueuesResponseBodyQueuesQueueInfoComputeInstanceType ComputeInstanceType { get; set; }
                public class ListQueuesResponseBodyQueuesQueueInfoComputeInstanceType : TeaModel {
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public List<string> InstanceType { get; set; }

                }

                [NameInMap("EnableAutoGrow")]
                [Validation(Required=false)]
                public bool? EnableAutoGrow { get; set; }

                [NameInMap("HostNamePrefix")]
                [Validation(Required=false)]
                public string HostNamePrefix { get; set; }

                [NameInMap("HostNameSuffix")]
                [Validation(Required=false)]
                public string HostNameSuffix { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SpotInstanceTypes")]
                [Validation(Required=false)]
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

                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
