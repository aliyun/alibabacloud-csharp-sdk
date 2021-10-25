// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetAutoScaleConfigResponseBody : TeaModel {
        [NameInMap("MaxNodesInCluster")]
        [Validation(Required=false)]
        public int? MaxNodesInCluster { get; set; }

        [NameInMap("GrowTimeoutInMinutes")]
        [Validation(Required=false)]
        public int? GrowTimeoutInMinutes { get; set; }

        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        [NameInMap("EnableAutoShrink")]
        [Validation(Required=false)]
        public bool? EnableAutoShrink { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EnableAutoGrow")]
        [Validation(Required=false)]
        public bool? EnableAutoGrow { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("ExcludeNodes")]
        [Validation(Required=false)]
        public string ExcludeNodes { get; set; }

        [NameInMap("ShrinkIntervalInMinutes")]
        [Validation(Required=false)]
        public int? ShrinkIntervalInMinutes { get; set; }

        [NameInMap("GrowIntervalInMinutes")]
        [Validation(Required=false)]
        public int? GrowIntervalInMinutes { get; set; }

        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        [NameInMap("ExtraNodesGrowRatio")]
        [Validation(Required=false)]
        public int? ExtraNodesGrowRatio { get; set; }

        [NameInMap("ShrinkIdleTimes")]
        [Validation(Required=false)]
        public int? ShrinkIdleTimes { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("GrowRatio")]
        [Validation(Required=false)]
        public int? GrowRatio { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        [NameInMap("Queues")]
        [Validation(Required=false)]
        public GetAutoScaleConfigResponseBodyQueues Queues { get; set; }
        public class GetAutoScaleConfigResponseBodyQueues : TeaModel {
            [NameInMap("QueueInfo")]
            [Validation(Required=false)]
            public List<GetAutoScaleConfigResponseBodyQueuesQueueInfo> QueueInfo { get; set; }
            public class GetAutoScaleConfigResponseBodyQueuesQueueInfo : TeaModel {
                public string QueueImageId { get; set; }
                public string SystemDiskCategory { get; set; }
                public string InstanceType { get; set; }
                public string HostNameSuffix { get; set; }
                public string SpotStrategy { get; set; }
                public int? MinNodesInQueue { get; set; }
                public string HostNamePrefix { get; set; }
                public int? SystemDiskSize { get; set; }
                public int? MaxNodesInQueue { get; set; }
                public bool? EnableAutoShrink { get; set; }
                public string QueueName { get; set; }
                public bool? EnableAutoGrow { get; set; }
                public string SystemDiskLevel { get; set; }
                public string ResourceGroupId { get; set; }
                public float? SpotPriceLimit { get; set; }
                public GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypes InstanceTypes { get; set; }
                public class GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypes : TeaModel {
                    [NameInMap("InstanceTypeInfo")]
                    [Validation(Required=false)]
                    public List<GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypesInstanceTypeInfo> InstanceTypeInfo { get; set; }
                    public class GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypesInstanceTypeInfo : TeaModel {
                        [NameInMap("HostNamePrefix")]
                        [Validation(Required=false)]
                        public string HostNamePrefix { get; set; }

                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                        [NameInMap("SpotPriceLimit")]
                        [Validation(Required=false)]
                        public float? SpotPriceLimit { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("SpotStrategy")]
                        [Validation(Required=false)]
                        public string SpotStrategy { get; set; }

                    }

                }
            }
        };

    }

}
