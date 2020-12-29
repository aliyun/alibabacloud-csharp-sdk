// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoProvisioningGroupsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("AutoProvisioningGroups")]
        [Validation(Required=false)]
        public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroups AutoProvisioningGroups { get; set; }
        public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroups : TeaModel {
            [NameInMap("AutoProvisioningGroup")]
            [Validation(Required=false)]
            public List<DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroup> AutoProvisioningGroup { get; set; }
            public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroup : TeaModel {
                public string Status { get; set; }
                public string AutoProvisioningGroupName { get; set; }
                public string CreationTime { get; set; }
                public float? MaxSpotPrice { get; set; }
                public bool? TerminateInstances { get; set; }
                public string LaunchTemplateId { get; set; }
                public string State { get; set; }
                public string ValidFrom { get; set; }
                public string LaunchTemplateVersion { get; set; }
                public string ValidUntil { get; set; }
                public string RegionId { get; set; }
                public bool? TerminateInstancesWithExpiration { get; set; }
                public string AutoProvisioningGroupType { get; set; }
                public string AutoProvisioningGroupId { get; set; }
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupPayAsYouGoOptions PayAsYouGoOptions { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupPayAsYouGoOptions : TeaModel {
                    [NameInMap("AllocationStrategy")]
                    [Validation(Required=false)]
                    public string AllocationStrategy { get; set; }

                }
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTargetCapacitySpecification TargetCapacitySpecification { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTargetCapacitySpecification : TeaModel {
                    [NameInMap("SpotTargetCapacity")]
                    [Validation(Required=false)]
                    public float? SpotTargetCapacity { get; set; }

                    [NameInMap("DefaultTargetCapacityType")]
                    [Validation(Required=false)]
                    public string DefaultTargetCapacityType { get; set; }

                    [NameInMap("TotalTargetCapacity")]
                    [Validation(Required=false)]
                    public float? TotalTargetCapacity { get; set; }

                    [NameInMap("PayAsYouGoTargetCapacity")]
                    [Validation(Required=false)]
                    public float? PayAsYouGoTargetCapacity { get; set; }

                }
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupSpotOptions SpotOptions { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupSpotOptions : TeaModel {
                    [NameInMap("InstancePoolsToUseCount")]
                    [Validation(Required=false)]
                    public int? InstancePoolsToUseCount { get; set; }

                    [NameInMap("InstanceInterruptionBehavior")]
                    [Validation(Required=false)]
                    public string InstanceInterruptionBehavior { get; set; }

                    [NameInMap("AllocationStrategy")]
                    [Validation(Required=false)]
                    public string AllocationStrategy { get; set; }

                }
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupLaunchTemplateConfigs LaunchTemplateConfigs { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupLaunchTemplateConfigs : TeaModel {
                    [NameInMap("LaunchTemplateConfig")]
                    [Validation(Required=false)]
                    public List<DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupLaunchTemplateConfigsLaunchTemplateConfig> LaunchTemplateConfig { get; set; }
                    public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupLaunchTemplateConfigsLaunchTemplateConfig : TeaModel {
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        [NameInMap("MaxPrice")]
                        [Validation(Required=false)]
                        public float? MaxPrice { get; set; }

                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public float? Priority { get; set; }

                        [NameInMap("WeightedCapacity")]
                        [Validation(Required=false)]
                        public float? WeightedCapacity { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                    }

                }
                public string ExcessCapacityTerminationPolicy { get; set; }
            }
        };

    }

}
