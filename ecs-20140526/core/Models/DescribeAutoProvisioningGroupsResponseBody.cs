// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoProvisioningGroupsResponseBody : TeaModel {
        [NameInMap("AutoProvisioningGroups")]
        [Validation(Required=false)]
        public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroups AutoProvisioningGroups { get; set; }
        public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroups : TeaModel {
            [NameInMap("AutoProvisioningGroup")]
            [Validation(Required=false)]
            public List<DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroup> AutoProvisioningGroup { get; set; }
            public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroup : TeaModel {
                [NameInMap("AutoProvisioningGroupId")]
                [Validation(Required=false)]
                public string AutoProvisioningGroupId { get; set; }

                [NameInMap("AutoProvisioningGroupName")]
                [Validation(Required=false)]
                public string AutoProvisioningGroupName { get; set; }

                [NameInMap("AutoProvisioningGroupType")]
                [Validation(Required=false)]
                public string AutoProvisioningGroupType { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("ExcessCapacityTerminationPolicy")]
                [Validation(Required=false)]
                public string ExcessCapacityTerminationPolicy { get; set; }

                [NameInMap("LaunchTemplateConfigs")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupLaunchTemplateConfigs LaunchTemplateConfigs { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupLaunchTemplateConfigs : TeaModel {
                    [NameInMap("LaunchTemplateConfig")]
                    [Validation(Required=false)]
                    public List<DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupLaunchTemplateConfigsLaunchTemplateConfig> LaunchTemplateConfig { get; set; }
                    public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupLaunchTemplateConfigsLaunchTemplateConfig : TeaModel {
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("MaxPrice")]
                        [Validation(Required=false)]
                        public float? MaxPrice { get; set; }

                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public float? Priority { get; set; }

                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        [NameInMap("WeightedCapacity")]
                        [Validation(Required=false)]
                        public float? WeightedCapacity { get; set; }

                    }

                }

                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                [NameInMap("LaunchTemplateVersion")]
                [Validation(Required=false)]
                public string LaunchTemplateVersion { get; set; }

                [NameInMap("MaxSpotPrice")]
                [Validation(Required=false)]
                public float? MaxSpotPrice { get; set; }

                [NameInMap("PayAsYouGoOptions")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupPayAsYouGoOptions PayAsYouGoOptions { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupPayAsYouGoOptions : TeaModel {
                    [NameInMap("AllocationStrategy")]
                    [Validation(Required=false)]
                    public string AllocationStrategy { get; set; }

                }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SpotOptions")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupSpotOptions SpotOptions { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupSpotOptions : TeaModel {
                    [NameInMap("AllocationStrategy")]
                    [Validation(Required=false)]
                    public string AllocationStrategy { get; set; }

                    [NameInMap("InstanceInterruptionBehavior")]
                    [Validation(Required=false)]
                    public string InstanceInterruptionBehavior { get; set; }

                    [NameInMap("InstancePoolsToUseCount")]
                    [Validation(Required=false)]
                    public int? InstancePoolsToUseCount { get; set; }

                }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TargetCapacitySpecification")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTargetCapacitySpecification TargetCapacitySpecification { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTargetCapacitySpecification : TeaModel {
                    [NameInMap("DefaultTargetCapacityType")]
                    [Validation(Required=false)]
                    public string DefaultTargetCapacityType { get; set; }

                    [NameInMap("PayAsYouGoTargetCapacity")]
                    [Validation(Required=false)]
                    public float? PayAsYouGoTargetCapacity { get; set; }

                    [NameInMap("SpotTargetCapacity")]
                    [Validation(Required=false)]
                    public float? SpotTargetCapacity { get; set; }

                    [NameInMap("TotalTargetCapacity")]
                    [Validation(Required=false)]
                    public float? TotalTargetCapacity { get; set; }

                }

                [NameInMap("TerminateInstances")]
                [Validation(Required=false)]
                public bool? TerminateInstances { get; set; }

                [NameInMap("TerminateInstancesWithExpiration")]
                [Validation(Required=false)]
                public bool? TerminateInstancesWithExpiration { get; set; }

                [NameInMap("ValidFrom")]
                [Validation(Required=false)]
                public string ValidFrom { get; set; }

                [NameInMap("ValidUntil")]
                [Validation(Required=false)]
                public string ValidUntil { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
