// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class ModifyScalingConfigurationShrinkRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public ModifyScalingConfigurationShrinkRequestSystemDisk SystemDisk { get; set; }
        public class ModifyScalingConfigurationShrinkRequestSystemDisk : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }
        };

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public ModifyScalingConfigurationShrinkRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ModifyScalingConfigurationShrinkRequestPrivatePoolOptions : TeaModel {
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("ScalingConfigurationId")]
        [Validation(Required=false)]
        public string ScalingConfigurationId { get; set; }

        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        [NameInMap("ScalingConfigurationName")]
        [Validation(Required=false)]
        public string ScalingConfigurationName { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        [NameInMap("LoadBalancerWeight")]
        [Validation(Required=false)]
        public int? LoadBalancerWeight { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("Override")]
        [Validation(Required=false)]
        public bool? Override { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("HpcClusterId")]
        [Validation(Required=false)]
        public string HpcClusterId { get; set; }

        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        [NameInMap("Affinity")]
        [Validation(Required=false)]
        public string Affinity { get; set; }

        [NameInMap("Tenancy")]
        [Validation(Required=false)]
        public string Tenancy { get; set; }

        [NameInMap("SchedulerOptions")]
        [Validation(Required=false)]
        public string SchedulerOptionsShrink { get; set; }

        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        [NameInMap("SpotInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInterruptionBehavior { get; set; }

        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestDataDisk> DataDisk { get; set; }
        public class ModifyScalingConfigurationShrinkRequestDataDisk : TeaModel {
            [NameInMap("Categorys")]
            [Validation(Required=false)]
            public List<string> Categorys { get; set; }

            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

        }

        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestSpotPriceLimit> SpotPriceLimit { get; set; }
        public class ModifyScalingConfigurationShrinkRequestSpotPriceLimit : TeaModel {
            [NameInMap("PriceLimit")]
            [Validation(Required=false)]
            public float? PriceLimit { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        [NameInMap("InstanceTypeOverride")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestInstanceTypeOverride> InstanceTypeOverride { get; set; }
        public class ModifyScalingConfigurationShrinkRequestInstanceTypeOverride : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

        }

        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        [NameInMap("InstancePatternInfo")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestInstancePatternInfo> InstancePatternInfo { get; set; }
        public class ModifyScalingConfigurationShrinkRequestInstancePatternInfo : TeaModel {
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public int? Cores { get; set; }

            [NameInMap("InstanceFamilyLevel")]
            [Validation(Required=false)]
            public string InstanceFamilyLevel { get; set; }

            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public float? MaxPrice { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

        }

        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public List<string> SystemDiskCategory { get; set; }

    }

}
