// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyAutoProvisioningGroupRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("LaunchTemplateConfig")]
        [Validation(Required=false)]
        public List<ModifyAutoProvisioningGroupRequestLaunchTemplateConfig> LaunchTemplateConfig { get; set; }
        public class ModifyAutoProvisioningGroupRequestLaunchTemplateConfig : TeaModel {
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public double? MaxPrice { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public double? WeightedCapacity { get; set; }

        }

        [NameInMap("AutoProvisioningGroupId")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupId { get; set; }

        [NameInMap("ExcessCapacityTerminationPolicy")]
        [Validation(Required=false)]
        public string ExcessCapacityTerminationPolicy { get; set; }

        [NameInMap("DefaultTargetCapacityType")]
        [Validation(Required=false)]
        public string DefaultTargetCapacityType { get; set; }

        [NameInMap("TerminateInstancesWithExpiration")]
        [Validation(Required=false)]
        public bool? TerminateInstancesWithExpiration { get; set; }

        [NameInMap("MaxSpotPrice")]
        [Validation(Required=false)]
        public float? MaxSpotPrice { get; set; }

        [NameInMap("TotalTargetCapacity")]
        [Validation(Required=false)]
        public string TotalTargetCapacity { get; set; }

        [NameInMap("PayAsYouGoTargetCapacity")]
        [Validation(Required=false)]
        public string PayAsYouGoTargetCapacity { get; set; }

        [NameInMap("SpotTargetCapacity")]
        [Validation(Required=false)]
        public string SpotTargetCapacity { get; set; }

        [NameInMap("AutoProvisioningGroupName")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupName { get; set; }

    }

}
