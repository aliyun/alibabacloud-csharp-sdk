// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetAutoScaleConfigResponseBody : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("EnableAutoGrow")]
        [Validation(Required=false)]
        public bool? EnableAutoGrow { get; set; }

        [NameInMap("EnableAutoShrink")]
        [Validation(Required=false)]
        public bool? EnableAutoShrink { get; set; }

        [NameInMap("ExcludeNodes")]
        [Validation(Required=false)]
        public string ExcludeNodes { get; set; }

        [NameInMap("ExtraNodesGrowRatio")]
        [Validation(Required=false)]
        public int? ExtraNodesGrowRatio { get; set; }

        [NameInMap("GrowIntervalInMinutes")]
        [Validation(Required=false)]
        public int? GrowIntervalInMinutes { get; set; }

        [NameInMap("GrowRatio")]
        [Validation(Required=false)]
        public int? GrowRatio { get; set; }

        [NameInMap("GrowTimeoutInMinutes")]
        [Validation(Required=false)]
        public int? GrowTimeoutInMinutes { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("MaxNodesInCluster")]
        [Validation(Required=false)]
        public int? MaxNodesInCluster { get; set; }

        [NameInMap("Queues")]
        [Validation(Required=false)]
        public GetAutoScaleConfigResponseBodyQueues Queues { get; set; }
        public class GetAutoScaleConfigResponseBodyQueues : TeaModel {
            [NameInMap("QueueInfo")]
            [Validation(Required=false)]
            public List<GetAutoScaleConfigResponseBodyQueuesQueueInfo> QueueInfo { get; set; }
            public class GetAutoScaleConfigResponseBodyQueuesQueueInfo : TeaModel {
                [NameInMap("DataDisks")]
                [Validation(Required=false)]
                public GetAutoScaleConfigResponseBodyQueuesQueueInfoDataDisks DataDisks { get; set; }
                public class GetAutoScaleConfigResponseBodyQueuesQueueInfoDataDisks : TeaModel {
                    [NameInMap("DataDisksInfo")]
                    [Validation(Required=false)]
                    public List<GetAutoScaleConfigResponseBodyQueuesQueueInfoDataDisksDataDisksInfo> DataDisksInfo { get; set; }
                    public class GetAutoScaleConfigResponseBodyQueuesQueueInfoDataDisksDataDisksInfo : TeaModel {
                        [NameInMap("DataDiskCategory")]
                        [Validation(Required=false)]
                        public string DataDiskCategory { get; set; }

                        [NameInMap("DataDiskDeleteWithInstance")]
                        [Validation(Required=false)]
                        public bool? DataDiskDeleteWithInstance { get; set; }

                        [NameInMap("DataDiskEncrypted")]
                        [Validation(Required=false)]
                        public bool? DataDiskEncrypted { get; set; }

                        [NameInMap("DataDiskKMSKeyId")]
                        [Validation(Required=false)]
                        public string DataDiskKMSKeyId { get; set; }

                        [NameInMap("DataDiskPerformanceLevel")]
                        [Validation(Required=false)]
                        public string DataDiskPerformanceLevel { get; set; }

                        [NameInMap("DataDiskSize")]
                        [Validation(Required=false)]
                        public int? DataDiskSize { get; set; }

                    }

                }

                [NameInMap("EnableAutoGrow")]
                [Validation(Required=false)]
                public bool? EnableAutoGrow { get; set; }

                [NameInMap("EnableAutoShrink")]
                [Validation(Required=false)]
                public bool? EnableAutoShrink { get; set; }

                [NameInMap("HostNamePrefix")]
                [Validation(Required=false)]
                public string HostNamePrefix { get; set; }

                [NameInMap("HostNameSuffix")]
                [Validation(Required=false)]
                public string HostNameSuffix { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("InstanceTypes")]
                [Validation(Required=false)]
                public GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypes InstanceTypes { get; set; }
                public class GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypes : TeaModel {
                    [NameInMap("InstanceTypeInfo")]
                    [Validation(Required=false)]
                    public List<GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypesInstanceTypeInfo> InstanceTypeInfo { get; set; }
                    public class GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypesInstanceTypeInfo : TeaModel {
                        [NameInMap("HostNamePrefix")]
                        [Validation(Required=false)]
                        public string HostNamePrefix { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("SpotDuration")]
                        [Validation(Required=false)]
                        public int? SpotDuration { get; set; }

                        [NameInMap("SpotInterruptionBehavior")]
                        [Validation(Required=false)]
                        public string SpotInterruptionBehavior { get; set; }

                        [NameInMap("SpotPriceLimit")]
                        [Validation(Required=false)]
                        public float? SpotPriceLimit { get; set; }

                        [NameInMap("SpotStrategy")]
                        [Validation(Required=false)]
                        public string SpotStrategy { get; set; }

                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                [NameInMap("MaxNodesInQueue")]
                [Validation(Required=false)]
                public int? MaxNodesInQueue { get; set; }

                [NameInMap("MaxNodesPerCycle")]
                [Validation(Required=false)]
                public long? MaxNodesPerCycle { get; set; }

                [NameInMap("MinNodesInQueue")]
                [Validation(Required=false)]
                public int? MinNodesInQueue { get; set; }

                [NameInMap("MinNodesPerCycle")]
                [Validation(Required=false)]
                public long? MinNodesPerCycle { get; set; }

                [NameInMap("QueueImageId")]
                [Validation(Required=false)]
                public string QueueImageId { get; set; }

                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                [NameInMap("SystemDiskCategory")]
                [Validation(Required=false)]
                public string SystemDiskCategory { get; set; }

                [NameInMap("SystemDiskLevel")]
                [Validation(Required=false)]
                public string SystemDiskLevel { get; set; }

                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ShrinkIdleTimes")]
        [Validation(Required=false)]
        public int? ShrinkIdleTimes { get; set; }

        [NameInMap("ShrinkIntervalInMinutes")]
        [Validation(Required=false)]
        public int? ShrinkIntervalInMinutes { get; set; }

        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
