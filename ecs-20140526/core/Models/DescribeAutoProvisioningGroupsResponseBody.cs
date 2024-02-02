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
                /// *   request: the one-time delivery. When the auto provisioning group is started, the system delivers clusters only once. If the clusters fail to be delivered, the system does not retry the delivery.
                /// *   maintain: continuous delivery. When the auto provisioning group is started, the system delivers clusters until the target capacity is reached. The system also monitors the capacity in real time. If the target capacity of the auto provisioning group is not reached, the system continues creating ECS instances until the target capacity is reached.
                /// </summary>
                [NameInMap("AutoProvisioningGroupType")]
                [Validation(Required=false)]
                public string AutoProvisioningGroupType { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// Specifies whether to release the removed instances when the capacity of the auto provisioning group exceeds the target capacity and a scale-in event is triggered. Valid values:
                /// 
                /// *   termination: releases the removed instances.
                /// *   no-termination: removes the instances from the auto provisioning group but does not release them.
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
                        /// The instance type that is specified in the extended configurations.
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
                /// > If both the MaxSpotPrice and LaunchTemplateConfig.N.MaxPrice parameters are specified, the smaller one of the two parameter values is used.
                /// 
                /// The LaunchTemplateConfig.N.MaxPrice parameter is set when the auto provisioning group is created, and cannot be modified.
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
                    /// *   lowest-price: the cost optimization policy. The auto provisioning group selects the instance type of the lowest price to create pay-as-you-go instances.
                    /// *   prioritized: the priority-based policy. This policy indicates that instances are created based on the priority specified by the LaunchTemplateConfig.N.Priority parameter.
                    /// 
                    /// > The LaunchTemplateConfig.N.Priority parameter is set when the auto provisioning group is created, and cannot be modified.
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
                    /// *   lowest-price: the cost optimization policy. The auto provisioning group selects the instance type of the lowest price to create preemptible instances.
                    /// *   diversified: the balanced distribution policy. The auto provisioning group creates the instances in the zones that are specified in extended configurations and evenly distributes the instances across the zones.
                    /// </summary>
                    [NameInMap("AllocationStrategy")]
                    [Validation(Required=false)]
                    public string AllocationStrategy { get; set; }

                    /// <summary>
                    /// The action to be performed after the extra preemptible instances are stopped. Valid values:
                    /// 
                    /// *   stop: retains the extra preemptible instances in the stopped state.
                    /// *   terminate: releases the excess preemptible instances.
                    /// </summary>
                    [NameInMap("InstanceInterruptionBehavior")]
                    [Validation(Required=false)]
                    public string InstanceInterruptionBehavior { get; set; }

                    /// <summary>
                    /// The number of instances that the auto provisioning group creates by selecting the instance type of the lowest price.
                    /// 
                    /// > This parameter is set when the auto provisioning group is created, and cannot be modified.
                    /// </summary>
                    [NameInMap("InstancePoolsToUseCount")]
                    [Validation(Required=false)]
                    public int? InstancePoolsToUseCount { get; set; }

                }

                /// <summary>
                /// The overall status of instance scheduling of the auto provisioning group. Valid values:
                /// 
                /// *   fulfilled: Scheduling is complete and the instance cluster is delivered.
                /// *   pending-fulfillment: The instances are being created.
                /// *   pending-termination: The instances are being removed.
                /// *   error: An exception occurred during scheduling and the instance cluster is not delivered.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The status of the auto provisioning group. Valid values:
                /// 
                /// *   submitted: The auto provisioning group is created but has not started to execute scheduling tasks.
                /// *   active: The auto provisioning group is executing scheduling tasks.
                /// *   deleted: The auto provisioning group is deleted.
                /// *   deleted-running: The auto provisioning group is being deleted.
                /// *   modifying: The auto provisioning group is being modified.
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
                    /// *   PayAsYouGo: pay-as-you-go instances
                    /// *   Spot: preemptible instances
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
                    /// The target capacity of the auto provisioning group. The capacity consists of the following parts:
                    /// 
                    /// *   PayAsYouGoTargetCapacity
                    /// *   SpotTargetCapacity
                    /// *   The supplemental capacity besides instance capacities specified by the PayAsYouGoTargetCapacity and SpotTargetCapacity parameters
                    /// </summary>
                    [NameInMap("TotalTargetCapacity")]
                    [Validation(Required=false)]
                    public float? TotalTargetCapacity { get; set; }

                }

                /// <summary>
                /// Indicates whether the instances in the auto provisioning group are released when the auto provisioning group is deleted. Valid values:
                /// 
                /// *   true: releases instances in the auto provisioning group.
                /// *   false: retains instances in the auto provisioning group.
                /// </summary>
                [NameInMap("TerminateInstances")]
                [Validation(Required=false)]
                public bool? TerminateInstances { get; set; }

                /// <summary>
                /// Indicates whether the instances in the auto provisioning group are released when the auto provisioning group expires. Valid values:
                /// 
                /// *   true: releases instances in the auto provisioning group.
                /// *   false: removes instances from the auto provisioning group but does not release them.
                /// </summary>
                [NameInMap("TerminateInstancesWithExpiration")]
                [Validation(Required=false)]
                public bool? TerminateInstancesWithExpiration { get; set; }

                /// <summary>
                /// The time at which the auto provisioning group is started. The provisioning group is effective to the point in time specified by the `ValidUntil` parameter.
                /// </summary>
                [NameInMap("ValidFrom")]
                [Validation(Required=false)]
                public string ValidFrom { get; set; }

                /// <summary>
                /// The time at which the auto provisioning group expires. The provisioning group is started from the point in time specified by the `ValidFrom` parameter.
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
