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
                /// *   request: one-time delivery.After the auto provisioning group is started, it attempts to deliver an instance cluster once. If the cluster fails to be delivered, the group does not retry the operation.
                /// *   maintain: continuous delivery.After the auto provisioning group is started, it continuously attempts to deliver an instance cluster. The auto provisioning group compares the real-time capacity and the target cluster capacity. If the cluster does not meet the target capacity, the group creates instances until the cluster meets the target capacity.
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
                /// Indicates whether to release the scaled-in instances when the real-time capacity exceeds the target capacity and the group is triggered to scale in. Valid values:
                /// 
                /// *   termination: releases the scaled-in instances.
                /// *   no-termination: removes the scaled-in instances from the auto provisioning group but not releases the instances.
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
                        /// The instance type specified in the extended configurations.
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// The maximum price of the instance type specified in the extended configurations.
                        /// </summary>
                        [NameInMap("MaxPrice")]
                        [Validation(Required=false)]
                        public float? MaxPrice { get; set; }

                        /// <summary>
                        /// The priority of the instance type specified in the extended configurations. A value of 0 indicates the highest priority.
                        /// </summary>
                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public float? Priority { get; set; }

                        /// <summary>
                        /// The ID of the vSwitch specified in the extended configurations.
                        /// </summary>
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        /// <summary>
                        /// The weight of the instance type specified in the extended configurations.
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
                /// The maximum price for preemptible instances in the auto provisioning group.
                /// 
                /// >  If both the MaxSpotPrice and LaunchTemplateConfig.N.MaxPrice parameters are specified, the maximum price is the lower value of the two parameters. The LaunchTemplateConfig.N.MaxPrice parameter is set when the auto provisioning group is created, and cannot be modified.
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
                    /// The provisioning policy for pay-as-you-go instances. Valid values:
                    /// 
                    /// - lowest-price: the cost optimization policy. This policy indicates that instance types of the lowest cost are used to create instances.
                    /// - prioritized: the priority-based policy. This policy indicates that instances are created based on the priority specified by the LaunchTemplateConfig.N.Priority parameter.
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
                /// The policy related to preemptible instances.
                /// </summary>
                [NameInMap("SpotOptions")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupSpotOptions SpotOptions { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupSpotOptions : TeaModel {
                    /// <summary>
                    /// The provisioning policy for preemptible instances. Valid values:
                    /// 
                    /// - lowest-price: the cost optimization policy. This policy indicates that instance types of the lowest cost are used to create instances.
                    /// - diversified: balanced distribution policy. This policy indicates that instances are created evenly across multiple zones specified in the extended configurations.
                    /// </summary>
                    [NameInMap("AllocationStrategy")]
                    [Validation(Required=false)]
                    public string AllocationStrategy { get; set; }

                    /// <summary>
                    /// The action to be performed after the extra preemptible instances are stopped. Valid values: 
                    /// 
                    /// - stop: retains the extra preemptible instances in the stopped state.
                    /// - terminate: releases the extra preemptible instances.
                    /// </summary>
                    [NameInMap("InstanceInterruptionBehavior")]
                    [Validation(Required=false)]
                    public string InstanceInterruptionBehavior { get; set; }

                    /// <summary>
                    /// The number of instances that the auto provisioning group used the instance type of the lowest cost to create. 
                    /// 
                    /// >  This parameter is set when the auto provisioning group is created, and cannot be modified.
                    /// </summary>
                    [NameInMap("InstancePoolsToUseCount")]
                    [Validation(Required=false)]
                    public int? InstancePoolsToUseCount { get; set; }

                }

                /// <summary>
                /// The overall status of instance scheduling of the auto provisioning group. Valid values:
                /// 
                /// - fulfilled: Scheduling is complete and the instance cluster is delivered.
                /// - pending-fulfillment: The instances are being created.
                /// - pending-termination: The instances are being removed.
                /// - error: An exception has occurred during scheduling and the instance cluster was not delivered.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The status of the auto provisioning group. Valid values:
                /// 
                /// - submitted: The auto provisioning group is created and has not started to execute scheduling tasks.
                /// - active: The auto provisioning group is executing scheduling tasks.
                /// - deleted: The auto provisioning group is deleted.
                /// - deleted-running: The auto provisioning group is being deleted.
                /// - modifying: The auto provisioning group is being modified.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The settings of the target capacity of the auto provisioning group.
                /// </summary>
                [NameInMap("TargetCapacitySpecification")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTargetCapacitySpecification TargetCapacitySpecification { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTargetCapacitySpecification : TeaModel {
                    /// <summary>
                    /// The billing method of supplemental instances. The target capacity of the auto provisioning group must be at least the sum of the pay-as-you-go instance capacity specified by the PayAsYouGoTargetCapacity parameter and the preemptible instance capacity specified by the SpotTargetCapacity parameter. Valid values: 
                    /// 
                    /// - PayAsYouGo: pay-as-you-go
                    /// - Spot: preemptible instance
                    /// </summary>
                    [NameInMap("DefaultTargetCapacityType")]
                    [Validation(Required=false)]
                    public string DefaultTargetCapacityType { get; set; }

                    /// <summary>
                    /// The target capacity of pay-as-you-go instances in the auto provisioning group.
                    /// </summary>
                    [NameInMap("PayAsYouGoTargetCapacity")]
                    [Validation(Required=false)]
                    public float? PayAsYouGoTargetCapacity { get; set; }

                    /// <summary>
                    /// The target capacity of preemptible instances in the auto provisioning group.
                    /// </summary>
                    [NameInMap("SpotTargetCapacity")]
                    [Validation(Required=false)]
                    public float? SpotTargetCapacity { get; set; }

                    /// <summary>
                    /// The target capacity of the auto provisioning group. The capacity consists of the following three parts: 
                    /// 
                    /// - PayAsYouGoTargetCapacity
                    /// - SpotTargetCapacity
                    /// - The supplemental capacity besides instance capacities specified by the PayAsYouGoTargetCapacity and SpotTargetCapacity parameters
                    /// </summary>
                    [NameInMap("TotalTargetCapacity")]
                    [Validation(Required=false)]
                    public float? TotalTargetCapacity { get; set; }

                }

                /// <summary>
                /// Indicates whether to release the instances in the auto provisioning group when the auto provisioning group is deleted. Valid values: 
                /// 
                /// - true: releases the instances.
                /// - false: retains the instances.
                /// </summary>
                [NameInMap("TerminateInstances")]
                [Validation(Required=false)]
                public bool? TerminateInstances { get; set; }

                /// <summary>
                /// Indicates whether to release instances in the auto provisioning group when the auto provisioning group expires. Valid values: 
                /// 
                /// - true: releases the instances.
                /// - false: removes the instances in the group from the auto provisioning group but not releases the instances.
                /// </summary>
                [NameInMap("TerminateInstancesWithExpiration")]
                [Validation(Required=false)]
                public bool? TerminateInstancesWithExpiration { get; set; }

                /// <summary>
                /// The time when the auto provisioning group was started. The period of time between this point in time and the point in time specified by the ValidUntil parameter is the effective time period of the auto provisioning group.
                /// </summary>
                [NameInMap("ValidFrom")]
                [Validation(Required=false)]
                public string ValidFrom { get; set; }

                /// <summary>
                /// The time when the auto provisioning group expires. The period of time between this point in time and the point in time specified by the ValidFrom parameter is the effective time period of the auto provisioning group.
                /// </summary>
                [NameInMap("ValidUntil")]
                [Validation(Required=false)]
                public string ValidUntil { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
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
