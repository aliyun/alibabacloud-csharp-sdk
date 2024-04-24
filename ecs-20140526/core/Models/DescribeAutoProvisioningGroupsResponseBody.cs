// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoProvisioningGroupsResponseBody : TeaModel {
        /// <summary>
        /// Details about the auto provisioning groups.
        /// </summary>
        [NameInMap("AutoProvisioningGroups")]
        [Validation(Required=false)]
        public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroups AutoProvisioningGroups { get; set; }
        public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroups : TeaModel {
            [NameInMap("AutoProvisioningGroup")]
            [Validation(Required=false)]
            public List<DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroup> AutoProvisioningGroup { get; set; }
            public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroup : TeaModel {
                /// <summary>
                /// The ID of the auto provisioning group.
                /// </summary>
                [NameInMap("AutoProvisioningGroupId")]
                [Validation(Required=false)]
                public string AutoProvisioningGroupId { get; set; }

                /// <summary>
                /// The name of the auto provisioning group.
                /// </summary>
                [NameInMap("AutoProvisioningGroupName")]
                [Validation(Required=false)]
                public string AutoProvisioningGroupName { get; set; }

                /// <summary>
                /// The delivery type of the auto provisioning group. Valid values:
                /// 
                /// *   request: one-time delivery. When the auto provisioning group is started, it delivers instances only once. If the instances fail to be delivered, the auto provisioning group does not retry the delivery.
                /// *   maintain: continuous delivery. When the auto provisioning group is started, it attempts to deliver instances that meet the target capacity and monitors the real-time capacity. If the target capacity of the auto provisioning group is not reached, the auto provisioning group continues to create instances until the target capacity is reached.
                /// </summary>
                [NameInMap("AutoProvisioningGroupType")]
                [Validation(Required=false)]
                public string AutoProvisioningGroupType { get; set; }

                /// <summary>
                /// The time when the auto provisioning group was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// Indicates whether to release the scaled-in instances when the real-time capacity of the auto provisioning group exceeds the target capacity and the group is triggered to scale in. Valid values:
                /// 
                /// *   termination: releases the scaled-in instances.
                /// *   no-termination: only removes the scaled-in instances from the auto provisioning group but does not release the instances.
                /// </summary>
                [NameInMap("ExcessCapacityTerminationPolicy")]
                [Validation(Required=false)]
                public string ExcessCapacityTerminationPolicy { get; set; }

                /// <summary>
                /// Details about the extended configurations.
                /// </summary>
                [NameInMap("LaunchTemplateConfigs")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupLaunchTemplateConfigs LaunchTemplateConfigs { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupLaunchTemplateConfigs : TeaModel {
                    [NameInMap("LaunchTemplateConfig")]
                    [Validation(Required=false)]
                    public List<DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupLaunchTemplateConfigsLaunchTemplateConfig> LaunchTemplateConfig { get; set; }
                    public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupLaunchTemplateConfigsLaunchTemplateConfig : TeaModel {
                        /// <summary>
                        /// The instance type that is specified in the extended configuration.
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// The maximum price of the instance type specified in the extended configuration.
                        /// </summary>
                        [NameInMap("MaxPrice")]
                        [Validation(Required=false)]
                        public float? MaxPrice { get; set; }

                        /// <summary>
                        /// The priority of the instance type specified in the extended configuration. A value of 0 indicates the highest priority.
                        /// </summary>
                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public float? Priority { get; set; }

                        /// <summary>
                        /// The ID of the vSwitch specified in the extended configuration.
                        /// </summary>
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        /// <summary>
                        /// The weight of the instance type specified in the extended configuration.
                        /// </summary>
                        [NameInMap("WeightedCapacity")]
                        [Validation(Required=false)]
                        public float? WeightedCapacity { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the launch template associated with the auto provisioning group.
                /// </summary>
                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                /// <summary>
                /// The version of the launch template associated with the auto provisioning group.
                /// </summary>
                [NameInMap("LaunchTemplateVersion")]
                [Validation(Required=false)]
                public string LaunchTemplateVersion { get; set; }

                /// <summary>
                /// The maximum price of preemptible instances in the auto provisioning group.
                /// 
                /// >  When both the MaxSpotPrice and LaunchTemplateConfig.N.MaxPrice parameters are specified, the smaller one of the two parameter values is used.
                /// 
                /// The LaunchTemplateConfig.N.Priority parameter is set when the auto provisioning group is created, and cannot be modified.
                /// </summary>
                [NameInMap("MaxSpotPrice")]
                [Validation(Required=false)]
                public float? MaxSpotPrice { get; set; }

                /// <summary>
                /// The policies related to pay-as-you-go instances.
                /// </summary>
                [NameInMap("PayAsYouGoOptions")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupPayAsYouGoOptions PayAsYouGoOptions { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupPayAsYouGoOptions : TeaModel {
                    /// <summary>
                    /// The policy for creating pay-as-you-go instances. Valid values:
                    /// 
                    /// *   lowest-price: cost optimization policy. This policy indicates that lowest-cost instance types are used to create instances.
                    /// *   prioritized: priority-based policy. This policy indicates that instances are created based on the priority specified by the LaunchTemplateConfig.N.Priority parameter.
                    /// 
                    /// >  The LaunchTemplateConfig.N.Priority parameter is set when the auto provisioning group is created, and cannot be modified.
                    /// </summary>
                    [NameInMap("AllocationStrategy")]
                    [Validation(Required=false)]
                    public string AllocationStrategy { get; set; }

                }

                /// <summary>
                /// The region ID of the auto provisioning group.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the auto provisioning group belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The policy related to preemptible instances.
                /// </summary>
                [NameInMap("SpotOptions")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupSpotOptions SpotOptions { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupSpotOptions : TeaModel {
                    /// <summary>
                    /// The policy for creating preemptible instances. Valid values:
                    /// 
                    /// *   lowest-price: cost optimization policy. This policy indicates that the lowest-priced instance type is used to create instances.
                    /// *   diversified: balanced distribution policy. This policy indicates that instances are created evenly across multiple zones specified in the extended configuration.
                    /// </summary>
                    [NameInMap("AllocationStrategy")]
                    [Validation(Required=false)]
                    public string AllocationStrategy { get; set; }

                    /// <summary>
                    /// The action to be performed after the excess preemptible instances are stopped. Valid values:
                    /// 
                    /// *   stop: retains the excess preemptible instances in the stopped state.
                    /// *   terminate: releases the excess preemptible instances.
                    /// </summary>
                    [NameInMap("InstanceInterruptionBehavior")]
                    [Validation(Required=false)]
                    public string InstanceInterruptionBehavior { get; set; }

                    /// <summary>
                    /// The number of instances that the auto provisioning group creates by selecting the instance type of the lowest price.
                    /// 
                    /// >  This parameter is set when the auto provisioning group is created, and cannot be modified.
                    /// </summary>
                    [NameInMap("InstancePoolsToUseCount")]
                    [Validation(Required=false)]
                    public int? InstancePoolsToUseCount { get; set; }

                }

                /// <summary>
                /// The overall status of instance scheduling in the auto provisioning group. Valid values:
                /// 
                /// *   fulfilled: Scheduling was complete and the instances were delivered.
                /// *   pending-fulfillment: The instances were being created.
                /// *   pending-termination: The instances were being removed.
                /// *   error: An exception occurred during scheduling and the instances were not delivered.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The status of the auto provisioning group. Valid values:
                /// 
                /// *   submitted: The auto provisioning group was created but did not execute scheduling tasks.
                /// *   active: The auto provisioning group was executing scheduling tasks.
                /// *   deleted: The auto provisioning group was deleted.
                /// *   delete-running: The auto provisioning group was being deleted.
                /// *   modifying: The auto provisioning group was being modified.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags that are added to the auto provisioning group.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTags Tags { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTagsTag> Tag { get; set; }
                    public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTagsTag : TeaModel {
                        /// <summary>
                        /// The key of tag N that is added to the auto provisioning group.
                        /// 
                        /// Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The value of tag N that is added to the auto provisioning group.
                        /// 
                        /// Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The settings of the target capacity of the auto provisioning group.
                /// </summary>
                [NameInMap("TargetCapacitySpecification")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTargetCapacitySpecification TargetCapacitySpecification { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTargetCapacitySpecification : TeaModel {
                    /// <summary>
                    /// The type of supplemental instances. When the sum of the `PayAsYouGoTargetCapacity` and `SpotTargetCapacity` values is less than the `TotalTargetCapacity` value, the auto provisioning group creates instances of the specified billing method to meet the target capacity. Valid values:
                    /// 
                    /// *   PayAsYouGo: pay-as-you-go instances.
                    /// *   Spot: preemptible instances.
                    /// </summary>
                    [NameInMap("DefaultTargetCapacityType")]
                    [Validation(Required=false)]
                    public string DefaultTargetCapacityType { get; set; }

                    /// <summary>
                    /// The target capacity of pay-as-you-go instances that the auto provisioning group provisions.
                    /// </summary>
                    [NameInMap("PayAsYouGoTargetCapacity")]
                    [Validation(Required=false)]
                    public float? PayAsYouGoTargetCapacity { get; set; }

                    /// <summary>
                    /// The target capacity of preemptible instances that the auto provisioning group provisions.
                    /// </summary>
                    [NameInMap("SpotTargetCapacity")]
                    [Validation(Required=false)]
                    public float? SpotTargetCapacity { get; set; }

                    /// <summary>
                    /// The target capacity of the auto provisioning group. The capacity consists of the following parts:
                    /// 
                    /// *   PayAsYouGoTargetCapacity
                    /// *   SpotTargetCapacity
                    /// *   The supplemental capacity besides instance capacities specified by PayAsYouGoTargetCapacity and SpotTargetCapacity.
                    /// </summary>
                    [NameInMap("TotalTargetCapacity")]
                    [Validation(Required=false)]
                    public float? TotalTargetCapacity { get; set; }

                }

                /// <summary>
                /// Indicates whether to release instances in the auto provisioning group when the auto provisioning group is deleted. Valid values:
                /// 
                /// *   true: releases the instances.
                /// *   false: only removes the instances from the auto provisioning group but does not release the instances.
                /// </summary>
                [NameInMap("TerminateInstances")]
                [Validation(Required=false)]
                public bool? TerminateInstances { get; set; }

                /// <summary>
                /// Indicates whether to release instances in the auto provisioning group when the group expires. Valid values:
                /// 
                /// *   true: releases the instances.
                /// *   false: only removes the instances from the auto provisioning group but does not release the instances.
                /// </summary>
                [NameInMap("TerminateInstancesWithExpiration")]
                [Validation(Required=false)]
                public bool? TerminateInstancesWithExpiration { get; set; }

                /// <summary>
                /// The time at which the auto provisioning group is started. The provisioning group is effective until the point in time specified by `ValidUntil`.
                /// </summary>
                [NameInMap("ValidFrom")]
                [Validation(Required=false)]
                public string ValidFrom { get; set; }

                /// <summary>
                /// The time at which the auto provisioning group expires. The period of time between this point in time and the point in time specified by the `ValidFrom` parameter is the validity period of the auto provisioning group.
                /// </summary>
                [NameInMap("ValidUntil")]
                [Validation(Required=false)]
                public string ValidUntil { get; set; }

            }

        }

        /// <summary>
        /// The number of the page returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of queried auto provisioning groups.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
