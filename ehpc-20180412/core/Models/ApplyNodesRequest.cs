// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ApplyNodesRequest : TeaModel {
        [NameInMap("AllocatePublicAddress")]
        [Validation(Required=false)]
        public bool? AllocatePublicAddress { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ComputeSpotPriceLimit")]
        [Validation(Required=false)]
        public float? ComputeSpotPriceLimit { get; set; }

        [NameInMap("ComputeSpotStrategy")]
        [Validation(Required=false)]
        public string ComputeSpotStrategy { get; set; }

        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        [NameInMap("HostNamePrefix")]
        [Validation(Required=false)]
        public string HostNamePrefix { get; set; }

        [NameInMap("HostNameSuffix")]
        [Validation(Required=false)]
        public string HostNameSuffix { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        [NameInMap("InstanceTypeModel")]
        [Validation(Required=false)]
        public List<ApplyNodesRequestInstanceTypeModel> InstanceTypeModel { get; set; }
        public class ApplyNodesRequestInstanceTypeModel : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public float? MaxPrice { get; set; }

            [NameInMap("TargetImageId")]
            [Validation(Required=false)]
            public string TargetImageId { get; set; }

        }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("InternetMaxBandWidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthIn { get; set; }

        [NameInMap("InternetMaxBandWidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthOut { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("PriorityStrategy")]
        [Validation(Required=false)]
        public string PriorityStrategy { get; set; }

        [NameInMap("ResourceAmountType")]
        [Validation(Required=false)]
        public string ResourceAmountType { get; set; }

        [NameInMap("Round")]
        [Validation(Required=false)]
        public int? Round { get; set; }

        [NameInMap("StrictResourceProvision")]
        [Validation(Required=false)]
        public bool? StrictResourceProvision { get; set; }

        [NameInMap("StrictSatisfiedTargetCapacity")]
        [Validation(Required=false)]
        public bool? StrictSatisfiedTargetCapacity { get; set; }

        [NameInMap("SystemDiskLevel")]
        [Validation(Required=false)]
        public string SystemDiskLevel { get; set; }

        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        [NameInMap("SystemDiskType")]
        [Validation(Required=false)]
        public string SystemDiskType { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ApplyNodesRequestTag> Tag { get; set; }
        public class ApplyNodesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TargetCapacity")]
        [Validation(Required=false)]
        public int? TargetCapacity { get; set; }

        [NameInMap("ZoneInfos")]
        [Validation(Required=false)]
        public List<ApplyNodesRequestZoneInfos> ZoneInfos { get; set; }
        public class ApplyNodesRequestZoneInfos : TeaModel {
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
