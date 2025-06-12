// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoProvisioningGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the auto provisioning groups.</para>
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
                /// <para>The ID of the auto provisioning group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>apg-sn54avj8htgvtyh8****</para>
                /// </summary>
                [NameInMap("AutoProvisioningGroupId")]
                [Validation(Required=false)]
                public string AutoProvisioningGroupId { get; set; }

                /// <summary>
                /// <para>The name of the auto provisioning group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EcsDocTest</para>
                /// </summary>
                [NameInMap("AutoProvisioningGroupName")]
                [Validation(Required=false)]
                public string AutoProvisioningGroupName { get; set; }

                /// <summary>
                /// <para>The delivery type of the auto provisioning group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>request: one-time delivery. When the auto provisioning group is started, it delivers instances only once. If the instances fail to be delivered, the auto provisioning group does not retry the delivery.</description></item>
                /// <item><description>maintain: continuous delivery. When the auto provisioning group is started, it attempts to deliver instances that meet the target capacity and monitors the real-time capacity. If the target capacity of the auto provisioning group is not reached, the auto provisioning group continues to create instances until the target capacity is reached.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>maintain</para>
                /// </summary>
                [NameInMap("AutoProvisioningGroupType")]
                [Validation(Required=false)]
                public string AutoProvisioningGroupType { get; set; }

                /// <summary>
                /// <para>The time when the auto provisioning group was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-04-01T15:10:20Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>Indicates whether to release the scaled-in instances when the real-time capacity of the auto provisioning group exceeds the target capacity and the group is triggered to scale in. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>termination: releases the scaled-in instances.</description></item>
                /// <item><description>no-termination: only removes the scaled-in instances from the auto provisioning group but does not release the instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>termination</para>
                /// </summary>
                [NameInMap("ExcessCapacityTerminationPolicy")]
                [Validation(Required=false)]
                public string ExcessCapacityTerminationPolicy { get; set; }

                /// <summary>
                /// <para>Details about the extended configurations.</para>
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
                        /// <para>The instance type that is specified in the extended configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ecs.g5.large</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The maximum price of the instance type specified in the extended configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("MaxPrice")]
                        [Validation(Required=false)]
                        public float? MaxPrice { get; set; }

                        /// <summary>
                        /// <para>The priority of the instance type specified in the extended configuration. A value of 0 indicates the highest priority.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public float? Priority { get; set; }

                        /// <summary>
                        /// <para>The ID of the vSwitch specified in the extended configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-sn5bsitu4lfzgc5o7****</para>
                        /// </summary>
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        /// <summary>
                        /// <para>The weight of the instance type specified in the extended configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("WeightedCapacity")]
                        [Validation(Required=false)]
                        public float? WeightedCapacity { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the launch template associated with the auto provisioning group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lt-bp1fgzds4bdogu03****</para>
                /// </summary>
                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                /// <summary>
                /// <para>The version of the launch template associated with the auto provisioning group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LaunchTemplateVersion")]
                [Validation(Required=false)]
                public string LaunchTemplateVersion { get; set; }

                /// <summary>
                /// <para>The maximum price of spot  instances in the auto provisioning group.</para>
                /// <remarks>
                /// <para> When both the MaxSpotPrice and LaunchTemplateConfig.N.MaxPrice parameters are specified, the smaller one of the two parameter values is used.</para>
                /// </remarks>
                /// <para>The LaunchTemplateConfig.N.Priority parameter is set when the auto provisioning group is created, and cannot be modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxSpotPrice")]
                [Validation(Required=false)]
                public float? MaxSpotPrice { get; set; }

                /// <summary>
                /// <para>The policies related to pay-as-you-go instances.</para>
                /// </summary>
                [NameInMap("PayAsYouGoOptions")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupPayAsYouGoOptions PayAsYouGoOptions { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupPayAsYouGoOptions : TeaModel {
                    /// <summary>
                    /// <para>The policy for creating pay-as-you-go instances. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>lowest-price: cost optimization policy. This policy indicates that lowest-cost instance types are used to create instances.</description></item>
                    /// <item><description>prioritized: priority-based policy. This policy indicates that instances are created based on the priority specified by the LaunchTemplateConfig.N.Priority parameter.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> The LaunchTemplateConfig.N.Priority parameter is set when the auto provisioning group is created, and cannot be modified.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>prioritized</para>
                    /// </summary>
                    [NameInMap("AllocationStrategy")]
                    [Validation(Required=false)]
                    public string AllocationStrategy { get; set; }

                }

                /// <summary>
                /// <para>The region ID of the auto provisioning group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the auto provisioning group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The policy related to spot instances.</para>
                /// </summary>
                [NameInMap("SpotOptions")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupSpotOptions SpotOptions { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupSpotOptions : TeaModel {
                    /// <summary>
                    /// <para>The policy for creating spot instances. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>lowest-price: cost optimization policy. This policy indicates that the lowest-priced instance type is used to create instances.</description></item>
                    /// <item><description>diversified: balanced distribution policy. This policy indicates that instances are created evenly across multiple zones specified in the extended configuration.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>diversified</para>
                    /// </summary>
                    [NameInMap("AllocationStrategy")]
                    [Validation(Required=false)]
                    public string AllocationStrategy { get; set; }

                    /// <summary>
                    /// <para>The action to be performed after the excess spot instances are stopped. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>stop: retains the excess spot instances in the stopped state.</description></item>
                    /// <item><description>terminate: releases the excess spot instances.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>stop</para>
                    /// </summary>
                    [NameInMap("InstanceInterruptionBehavior")]
                    [Validation(Required=false)]
                    public string InstanceInterruptionBehavior { get; set; }

                    /// <summary>
                    /// <para>The number of instances that the auto provisioning group creates by selecting the instance type of the lowest price.</para>
                    /// <remarks>
                    /// <para> This parameter is set when the auto provisioning group is created, and cannot be modified.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("InstancePoolsToUseCount")]
                    [Validation(Required=false)]
                    public int? InstancePoolsToUseCount { get; set; }

                }

                /// <summary>
                /// <para>The overall status of instance scheduling in the auto provisioning group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>fulfilled: Scheduling was complete and the instances were delivered.</description></item>
                /// <item><description>pending-fulfillment: The instances were being created.</description></item>
                /// <item><description>pending-termination: The instances were being removed.</description></item>
                /// <item><description>error: An exception occurred during scheduling and the instances were not delivered.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>fulfilled</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The status of the auto provisioning group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>submitted: The auto provisioning group was created but did not execute scheduling tasks.</description></item>
                /// <item><description>active: The auto provisioning group was executing scheduling tasks.</description></item>
                /// <item><description>deleted: The auto provisioning group was deleted.</description></item>
                /// <item><description>delete-running: The auto provisioning group was being deleted.</description></item>
                /// <item><description>modifying: The auto provisioning group was being modified.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>submitted</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags that are added to the auto provisioning group.</para>
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
                        /// <para>The key of tag N that is added to the auto provisioning group.</para>
                        /// <para>Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The value of tag N that is added to the auto provisioning group.</para>
                        /// <para>Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The settings of the target capacity of the auto provisioning group.</para>
                /// </summary>
                [NameInMap("TargetCapacitySpecification")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTargetCapacitySpecification TargetCapacitySpecification { get; set; }
                public class DescribeAutoProvisioningGroupsResponseBodyAutoProvisioningGroupsAutoProvisioningGroupTargetCapacitySpecification : TeaModel {
                    /// <summary>
                    /// <para>The type of supplemental instances. When the sum of the <c>PayAsYouGoTargetCapacity</c> and <c>SpotTargetCapacity</c> values is less than the <c>TotalTargetCapacity</c> value, the auto provisioning group creates instances of the specified billing method to meet the target capacity. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PayAsYouGo: pay-as-you-go instances.</description></item>
                    /// <item><description>Spot: spot instances.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Spot</para>
                    /// </summary>
                    [NameInMap("DefaultTargetCapacityType")]
                    [Validation(Required=false)]
                    public string DefaultTargetCapacityType { get; set; }

                    /// <summary>
                    /// <para>The target capacity of pay-as-you-go instances that the auto provisioning group provisions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("PayAsYouGoTargetCapacity")]
                    [Validation(Required=false)]
                    public float? PayAsYouGoTargetCapacity { get; set; }

                    /// <summary>
                    /// <para>The target capacity of spot instances that the auto provisioning group provisions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("SpotTargetCapacity")]
                    [Validation(Required=false)]
                    public float? SpotTargetCapacity { get; set; }

                    /// <summary>
                    /// <para>The target capacity of the auto provisioning group. The capacity consists of the following parts:</para>
                    /// <list type="bullet">
                    /// <item><description>PayAsYouGoTargetCapacity</description></item>
                    /// <item><description>SpotTargetCapacity</description></item>
                    /// <item><description>The supplemental capacity besides instance capacities specified by PayAsYouGoTargetCapacity and SpotTargetCapacity.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("TotalTargetCapacity")]
                    [Validation(Required=false)]
                    public float? TotalTargetCapacity { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether to release instances in the auto provisioning group when the auto provisioning group is deleted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: releases the instances.</description></item>
                /// <item><description>false: only removes the instances from the auto provisioning group but does not release the instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("TerminateInstances")]
                [Validation(Required=false)]
                public bool? TerminateInstances { get; set; }

                /// <summary>
                /// <para>Indicates whether to release instances in the auto provisioning group when the group expires. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: releases the instances.</description></item>
                /// <item><description>false: only removes the instances from the auto provisioning group but does not release the instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TerminateInstancesWithExpiration")]
                [Validation(Required=false)]
                public bool? TerminateInstancesWithExpiration { get; set; }

                /// <summary>
                /// <para>The time at which the auto provisioning group is started. The provisioning group is effective until the point in time specified by <c>ValidUntil</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-04-01T15:10:20Z</para>
                /// </summary>
                [NameInMap("ValidFrom")]
                [Validation(Required=false)]
                public string ValidFrom { get; set; }

                /// <summary>
                /// <para>The time at which the auto provisioning group expires. The period of time between this point in time and the point in time specified by the <c>ValidFrom</c> parameter is the validity period of the auto provisioning group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-01T15:10:20Z</para>
                /// </summary>
                [NameInMap("ValidUntil")]
                [Validation(Required=false)]
                public string ValidUntil { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of the page returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>745CEC9F-0DD7-4451-9FE7-8B752F39****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of queried auto provisioning groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
