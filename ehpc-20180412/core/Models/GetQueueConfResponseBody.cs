// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetQueueConfResponseBody : TeaModel {
        [NameInMap("QueuesConf")]
        [Validation(Required=false)]
        public List<GetQueueConfResponseBodyQueuesConf> QueuesConf { get; set; }
        public class GetQueueConfResponseBodyQueuesConf : TeaModel {
            [NameInMap("DataDisks")]
            [Validation(Required=false)]
            public List<GetQueueConfResponseBodyQueuesConfDataDisks> DataDisks { get; set; }
            public class GetQueueConfResponseBodyQueuesConfDataDisks : TeaModel {
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
                public long? DataDiskSize { get; set; }

            }

            [NameInMap("EnableAutoGrow")]
            [Validation(Required=false)]
            public bool? EnableAutoGrow { get; set; }

            [NameInMap("EnableAutoShrink")]
            [Validation(Required=false)]
            public bool? EnableAutoShrink { get; set; }

            [NameInMap("GrowIntervallnMinutes")]
            [Validation(Required=false)]
            public long? GrowIntervallnMinutes { get; set; }

            [NameInMap("GrowTimeoutInMinutes")]
            [Validation(Required=false)]
            public long? GrowTimeoutInMinutes { get; set; }

            [NameInMap("HostNamePrefix")]
            [Validation(Required=false)]
            public string HostNamePrefix { get; set; }

            [NameInMap("HostNameSuffix")]
            [Validation(Required=false)]
            public string HostNameSuffix { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<GetQueueConfResponseBodyQueuesConfInstanceTypes> InstanceTypes { get; set; }
            public class GetQueueConfResponseBodyQueuesConfInstanceTypes : TeaModel {
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

            }

            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            [NameInMap("MaxNodes")]
            [Validation(Required=false)]
            public long? MaxNodes { get; set; }

            [NameInMap("MinNodes")]
            [Validation(Required=false)]
            public long? MinNodes { get; set; }

            [NameInMap("OsTag")]
            [Validation(Required=false)]
            public string OsTag { get; set; }

            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("ShrinkIntervallnMinutes")]
            [Validation(Required=false)]
            public long? ShrinkIntervallnMinutes { get; set; }

            [NameInMap("ShrinkidleTimes")]
            [Validation(Required=false)]
            public long? ShrinkidleTimes { get; set; }

            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<GetQueueConfResponseBodyQueuesConfZones> Zones { get; set; }
            public class GetQueueConfResponseBodyQueuesConfZones : TeaModel {
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
