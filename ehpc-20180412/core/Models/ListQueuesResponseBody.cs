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
                /// <summary>
                /// The instance type of the compute nodes.
                /// </summary>
                [NameInMap("ComputeInstanceType")]
                [Validation(Required=false)]
                public ListQueuesResponseBodyQueuesQueueInfoComputeInstanceType ComputeInstanceType { get; set; }
                public class ListQueuesResponseBodyQueuesQueueInfoComputeInstanceType : TeaModel {
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public List<string> InstanceType { get; set; }

                }

                /// <summary>
                /// Indicates whether the queue enabled auto scale-out. Valid values:
                /// 
                /// true: The queue enabled auto scale-out.
                /// 
                /// false: The queue disabled auto scale-out.
                /// </summary>
                [NameInMap("EnableAutoGrow")]
                [Validation(Required=false)]
                public bool? EnableAutoGrow { get; set; }

                /// <summary>
                /// The prefix of the host name.
                /// </summary>
                [NameInMap("HostNamePrefix")]
                [Validation(Required=false)]
                public string HostNamePrefix { get; set; }

                /// <summary>
                /// The suffix of the host name.
                /// </summary>
                [NameInMap("HostNameSuffix")]
                [Validation(Required=false)]
                public string HostNameSuffix { get; set; }

                /// <summary>
                /// The ID of the image.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The name of the queue.
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// The ID of the resource group to which the queue belongs.
                /// </summary>
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
                        /// <summary>
                        /// The specifications of the ECS instance.
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// The maximum hourly price of the preemptible instance. The value can be accurate to three decimal places. The parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit.
                        /// </summary>
                        [NameInMap("SpotPriceLimit")]
                        [Validation(Required=false)]
                        public float? SpotPriceLimit { get; set; }

                    }

                }

                /// <summary>
                /// The preemption policy of the compute nodes. Valid values:
                /// 
                /// NoSpot: The instances of the compute node are pay-as-you-go instances.
                /// 
                /// SpotWithPriceLimit: The instances of the compute node are preemptible instances. These types of instances have a specified maximum hourly price.
                /// 
                /// SpotAsPriceGo: The instances of the compute node are preemptible instances. The price of these instances is based on the current market price.
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// The type of the queue. Valid values:
                /// 
                /// Execution: Queues in which jobs can be executed.
                /// 
                /// Router: Queues in which jobs cannot be executed but are forwarded to the bounded Execution queue for processing.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
