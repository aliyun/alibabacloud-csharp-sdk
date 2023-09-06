// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListQueuesResponseBody : TeaModel {
        /// <summary>
        /// The details of the queue.
        /// </summary>
        [NameInMap("Queues")]
        [Validation(Required=false)]
        public ListQueuesResponseBodyQueues Queues { get; set; }
        public class ListQueuesResponseBodyQueues : TeaModel {
            [NameInMap("QueueInfo")]
            [Validation(Required=false)]
            public List<ListQueuesResponseBodyQueuesQueueInfo> QueueInfo { get; set; }
            public class ListQueuesResponseBodyQueuesQueueInfo : TeaModel {
                /// <summary>
                /// The instance type of compute node.
                /// </summary>
                [NameInMap("ComputeInstanceType")]
                [Validation(Required=false)]
                public ListQueuesResponseBodyQueuesQueueInfoComputeInstanceType ComputeInstanceType { get; set; }
                public class ListQueuesResponseBodyQueuesQueueInfoComputeInstanceType : TeaModel {
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public List<string> InstanceType { get; set; }

                }

                [NameInMap("DeploymentSetId")]
                [Validation(Required=false)]
                public string DeploymentSetId { get; set; }

                /// <summary>
                /// Indicates whether the queue enabled the auto scale-out. Valid values:
                /// 
                /// *   true: The queue enabled auto scale-out.
                /// *   false: The queue disabled auto scale-out.
                /// </summary>
                [NameInMap("EnableAutoGrow")]
                [Validation(Required=false)]
                public bool? EnableAutoGrow { get; set; }

                /// <summary>
                /// The prefix of the hostname.
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
                /// The ID of the custom image.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("NetworkInterfaceTrafficMode")]
                [Validation(Required=false)]
                public string NetworkInterfaceTrafficMode { get; set; }

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

                /// <summary>
                /// The information about the preemptible instance.
                /// </summary>
                [NameInMap("SpotInstanceTypes")]
                [Validation(Required=false)]
                public ListQueuesResponseBodyQueuesQueueInfoSpotInstanceTypes SpotInstanceTypes { get; set; }
                public class ListQueuesResponseBodyQueuesQueueInfoSpotInstanceTypes : TeaModel {
                    [NameInMap("Instance")]
                    [Validation(Required=false)]
                    public List<ListQueuesResponseBodyQueuesQueueInfoSpotInstanceTypesInstance> Instance { get; set; }
                    public class ListQueuesResponseBodyQueuesQueueInfoSpotInstanceTypesInstance : TeaModel {
                        /// <summary>
                        /// The instance type of the preemptible instance.
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// The maximum hourly price of the preemptible instance. The value can be accurate to three decimal places. The parameter only takes effect when SpotStrategy is set to SpotWithPriceLimit.
                        /// </summary>
                        [NameInMap("SpotPriceLimit")]
                        [Validation(Required=false)]
                        public float? SpotPriceLimit { get; set; }

                    }

                }

                /// <summary>
                /// The preemption policy of the compute nodes. Valid values:
                /// 
                /// *   NoSpot: The instances of the compute node are pay-as-you-go instances.
                /// *   SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.
                /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// The type of queue. Valid values:
                /// 
                /// *   Execution: Queues in which jobs can be executed.
                /// *   Router: Queues in which jobs cannot be executed but are forwarded to the bounded Execution queue for processing.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UseESS")]
                [Validation(Required=false)]
                public bool? UseESS { get; set; }

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
