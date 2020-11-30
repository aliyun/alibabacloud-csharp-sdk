// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateAutoProvisioningGroupRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("AutoProvisioningGroupName")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupName { get; set; }

        [NameInMap("AutoProvisioningGroupType")]
        [Validation(Required=false)]
        public string AutoProvisioningGroupType { get; set; }

        [NameInMap("SpotAllocationStrategy")]
        [Validation(Required=false)]
        public string SpotAllocationStrategy { get; set; }

        [NameInMap("SpotInstanceInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInstanceInterruptionBehavior { get; set; }

        [NameInMap("SpotInstancePoolsToUseCount")]
        [Validation(Required=false)]
        public int? SpotInstancePoolsToUseCount { get; set; }

        [NameInMap("PayAsYouGoAllocationStrategy")]
        [Validation(Required=false)]
        public string PayAsYouGoAllocationStrategy { get; set; }

        [NameInMap("ExcessCapacityTerminationPolicy")]
        [Validation(Required=false)]
        public string ExcessCapacityTerminationPolicy { get; set; }

        [NameInMap("ValidFrom")]
        [Validation(Required=false)]
        public string ValidFrom { get; set; }

        [NameInMap("ValidUntil")]
        [Validation(Required=false)]
        public string ValidUntil { get; set; }

        [NameInMap("TerminateInstancesWithExpiration")]
        [Validation(Required=false)]
        public bool? TerminateInstancesWithExpiration { get; set; }

        [NameInMap("TerminateInstances")]
        [Validation(Required=false)]
        public bool? TerminateInstances { get; set; }

        [NameInMap("MaxSpotPrice")]
        [Validation(Required=false)]
        public float? MaxSpotPrice { get; set; }

        [NameInMap("TotalTargetCapacity")]
        [Validation(Required=true)]
        public string TotalTargetCapacity { get; set; }

        [NameInMap("PayAsYouGoTargetCapacity")]
        [Validation(Required=false)]
        public string PayAsYouGoTargetCapacity { get; set; }

        [NameInMap("SpotTargetCapacity")]
        [Validation(Required=false)]
        public string SpotTargetCapacity { get; set; }

        [NameInMap("DefaultTargetCapacityType")]
        [Validation(Required=false)]
        public string DefaultTargetCapacityType { get; set; }

        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        [NameInMap("LaunchTemplateConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupRequestLaunchTemplateConfig> LaunchTemplateConfig { get; set; }
        public class CreateAutoProvisioningGroupRequestLaunchTemplateConfig : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public double? MaxPrice { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public double? WeightedCapacity { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("LaunchConfiguration")]
        [Validation(Required=false)]
        public CreateAutoProvisioningGroupRequestLaunchConfiguration LaunchConfiguration { get; set; }
        public class CreateAutoProvisioningGroupRequestLaunchConfiguration : TeaModel {
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }
            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public string IoOptimized { get; set; }
            [NameInMap("DataDisk")]
            [Validation(Required=false)]
            public List<string> DataDisk { get; set; }
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }
            [NameInMap("InternetMaxBandwidthIn")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthIn { get; set; }
            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthOut { get; set; }
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }
            [NameInMap("SecurityEnhancementStrategy")]
            [Validation(Required=false)]
            public string SecurityEnhancementStrategy { get; set; }
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<string> Tag { get; set; }
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }
            [NameInMap("SystemDiskName")]
            [Validation(Required=false)]
            public string SystemDiskName { get; set; }
            [NameInMap("SystemDiskDescription")]
            [Validation(Required=false)]
            public string SystemDiskDescription { get; set; }
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }
            [NameInMap("PasswordInherit")]
            [Validation(Required=false)]
            public bool? PasswordInherit { get; set; }
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }
            [NameInMap("CreditSpecification")]
            [Validation(Required=false)]
            public string CreditSpecification { get; set; }
        };

        [NameInMap("SystemDiskConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupRequestSystemDiskConfig> SystemDiskConfig { get; set; }
        public class CreateAutoProvisioningGroupRequestSystemDiskConfig : TeaModel {
            [NameInMap("DiskCategory")]
            [Validation(Required=false)]
            public string DiskCategory { get; set; }

        }

        [NameInMap("DataDiskConfig")]
        [Validation(Required=false)]
        public List<CreateAutoProvisioningGroupRequestDataDiskConfig> DataDiskConfig { get; set; }
        public class CreateAutoProvisioningGroupRequestDataDiskConfig : TeaModel {
            [NameInMap("DiskCategory")]
            [Validation(Required=false)]
            public string DiskCategory { get; set; }

        }

    }

}
