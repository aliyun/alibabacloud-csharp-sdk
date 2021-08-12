// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class DescribeScalingConfigurationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("ScalingConfigurations")]
        [Validation(Required=false)]
        public DescribeScalingConfigurationsResponseBodyScalingConfigurations ScalingConfigurations { get; set; }
        public class DescribeScalingConfigurationsResponseBodyScalingConfigurations : TeaModel {
            [NameInMap("ScalingConfiguration")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfiguration> ScalingConfiguration { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfiguration : TeaModel {
                public DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationPrivatePoolOptions PrivatePoolOptions { get; set; }
                public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationPrivatePoolOptions : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MatchCriteria")]
                    [Validation(Required=false)]
                    public string MatchCriteria { get; set; }

                }
                public string DeploymentSetId { get; set; }
                public string CreationTime { get; set; }
                public string ScalingConfigurationName { get; set; }
                public string SystemDiskDescription { get; set; }
                public string KeyPairName { get; set; }
                public string SecurityGroupId { get; set; }
                public string SystemDiskAutoSnapshotPolicyId { get; set; }
                public string SpotStrategy { get; set; }
                public string ScalingGroupId { get; set; }
                public string Affinity { get; set; }
                public string Tenancy { get; set; }
                public int? SystemDiskSize { get; set; }
                public int? Ipv6AddressCount { get; set; }
                public int? SpotDuration { get; set; }
                public string LifecycleState { get; set; }
                public string InstanceName { get; set; }
                public string SecurityEnhancementStrategy { get; set; }
                public string UserData { get; set; }
                public string DedicatedHostId { get; set; }
                public string InstanceGeneration { get; set; }
                public string HpcClusterId { get; set; }
                public bool? PasswordInherit { get; set; }
                public int? Memory { get; set; }
                public string ImageId { get; set; }
                public string ImageFamily { get; set; }
                public int? LoadBalancerWeight { get; set; }
                public string SystemDiskCategory { get; set; }
                public string HostName { get; set; }
                public string SystemDiskName { get; set; }
                public int? InternetMaxBandwidthOut { get; set; }
                public int? InternetMaxBandwidthIn { get; set; }
                public string InstanceType { get; set; }
                public string InstanceDescription { get; set; }
                public string IoOptimized { get; set; }
                public string RamRoleName { get; set; }
                public string SystemDiskPerformanceLevel { get; set; }
                public int? Cpu { get; set; }
                public string ResourceGroupId { get; set; }
                public string ZoneId { get; set; }
                public string InternetChargeType { get; set; }
                public string ImageName { get; set; }
                public string ScalingConfigurationId { get; set; }
                public string CreditSpecification { get; set; }
                public string SpotInterruptionBehavior { get; set; }
                public DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationDataDisks DataDisks { get; set; }
                public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationDataDisks : TeaModel {
                    [NameInMap("DataDisk")]
                    [Validation(Required=false)]
                    public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationDataDisksDataDisk> DataDisk { get; set; }
                    public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationDataDisksDataDisk : TeaModel {
                        [NameInMap("PerformanceLevel")]
                        [Validation(Required=false)]
                        public string PerformanceLevel { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("SnapshotId")]
                        [Validation(Required=false)]
                        public string SnapshotId { get; set; }

                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                        [NameInMap("DiskName")]
                        [Validation(Required=false)]
                        public string DiskName { get; set; }

                        [NameInMap("AutoSnapshotPolicyId")]
                        [Validation(Required=false)]
                        public string AutoSnapshotPolicyId { get; set; }

                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        [NameInMap("KMSKeyId")]
                        [Validation(Required=false)]
                        public string KMSKeyId { get; set; }

                        [NameInMap("DeleteWithInstance")]
                        [Validation(Required=false)]
                        public bool? DeleteWithInstance { get; set; }

                        [NameInMap("Encrypted")]
                        [Validation(Required=false)]
                        public string Encrypted { get; set; }

                        [NameInMap("Categories")]
                        [Validation(Required=false)]
                        public DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationDataDisksDataDiskCategories Categories { get; set; }
                        public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationDataDisksDataDiskCategories : TeaModel {
                            [NameInMap("Category")]
                            [Validation(Required=false)]
                            public List<string> Category { get; set; }
                        };

                    }

                }
                public DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationTags Tags { get; set; }
                public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationTagsTag> Tag { get; set; }
                    public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationSpotPriceLimit SpotPriceLimit { get; set; }
                public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationSpotPriceLimit : TeaModel {
                    [NameInMap("SpotPriceModel")]
                    [Validation(Required=false)]
                    public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationSpotPriceLimitSpotPriceModel> SpotPriceModel { get; set; }
                    public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationSpotPriceLimitSpotPriceModel : TeaModel {
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("PriceLimit")]
                        [Validation(Required=false)]
                        public float? PriceLimit { get; set; }

                    }

                }
                public DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationInstancePatternInfos InstancePatternInfos { get; set; }
                public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationInstancePatternInfos : TeaModel {
                    [NameInMap("InstancePatternInfo")]
                    [Validation(Required=false)]
                    public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationInstancePatternInfosInstancePatternInfo> InstancePatternInfo { get; set; }
                    public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationInstancePatternInfosInstancePatternInfo : TeaModel {
                        [NameInMap("MaxPrice")]
                        [Validation(Required=false)]
                        public float? MaxPrice { get; set; }

                        [NameInMap("Cores")]
                        [Validation(Required=false)]
                        public int? Cores { get; set; }

                        [NameInMap("Memory")]
                        [Validation(Required=false)]
                        public float? Memory { get; set; }

                        [NameInMap("InstanceFamilyLevel")]
                        [Validation(Required=false)]
                        public string InstanceFamilyLevel { get; set; }

                    }

                }
                public DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationSystemDiskCategories SystemDiskCategories { get; set; }
                public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationSystemDiskCategories : TeaModel {
                    [NameInMap("SystemDiskCategory")]
                    [Validation(Required=false)]
                    public List<string> SystemDiskCategory { get; set; }

                }
                public DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationWeightedCapacities WeightedCapacities { get; set; }
                public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationWeightedCapacities : TeaModel {
                    [NameInMap("WeightedCapacity")]
                    [Validation(Required=false)]
                    public List<string> WeightedCapacity { get; set; }

                }
                public DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationInstanceTypes InstanceTypes { get; set; }
                public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationInstanceTypes : TeaModel {
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public List<string> InstanceType { get; set; }

                }
                public DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationSecurityGroupIds SecurityGroupIds { get; set; }
                public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationSecurityGroupIds : TeaModel {
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupId { get; set; }

                }
                public DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationSchedulerOptions SchedulerOptions { get; set; }
                public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfigurationSchedulerOptions : TeaModel {
                    [NameInMap("ManagedPrivateSpaceId")]
                    [Validation(Required=false)]
                    public string ManagedPrivateSpaceId { get; set; }

                }
            }
        };

    }

}
