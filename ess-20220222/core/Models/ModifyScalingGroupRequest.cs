// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyScalingGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the active scaling configuration in the scaling group.
        /// </summary>
        [NameInMap("ActiveScalingConfigurationId")]
        [Validation(Required=false)]
        public string ActiveScalingConfigurationId { get; set; }

        /// <summary>
        /// The allocation policy. Auto Scaling selects instance types based on the allocation policy to create the required number of instances. The policy can be applied to pay-as-you-go instances and preemptible instances at the same time. This parameter takes effect only when you set the MultiAZPolicy parameter to COMPOSABLE. Valid values:
        /// 
        /// *   priority: Auto Scaling selects instance types based on the specified order to create the required number of instances.
        /// *   lowestPrice: Auto Scaling selects instance types that have the lowest unit price of vCPUs to create the required number of instances.
        /// 
        /// Default value: priority.
        /// </summary>
        [NameInMap("AllocationStrategy")]
        [Validation(Required=false)]
        public string AllocationStrategy { get; set; }

        /// <summary>
        /// Specifies whether to evenly distribute instances in the scaling group across zones. This parameter takes effect only when you set the `MultiAZPolicy` parameter to `COMPOSABLE`. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("AzBalance")]
        [Validation(Required=false)]
        public bool? AzBalance { get; set; }

        /// <summary>
        /// Specifies whether to automatically create pay-as-you-go instances to meet the requirements on the number of ECS instances in the scaling group when the number of preemptible instances cannot be reached due to reasons such as cost-related issues and insufficient resources. This parameter takes effect only if you set `MultiAZPolicy` in the `CreateScalingGroup` operation to `COST_OPTIMIZED`. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("CompensateWithOnDemand")]
        [Validation(Required=false)]
        public bool? CompensateWithOnDemand { get; set; }

        /// <summary>
        /// The ARN of the custom scaling policy (Function). This parameter takes effect only when you specify CustomPolicy as the first step of the instance removal policy.
        /// </summary>
        [NameInMap("CustomPolicyARN")]
        [Validation(Required=false)]
        public string CustomPolicyARN { get; set; }

        /// <summary>
        /// The cooldown period of the scaling group. This parameter is available only if you set ScalingRuleType to SimpleScalingRule. Valid values: 0 to 86400. Unit: seconds.
        /// 
        /// During the cooldown period, Auto Scaling does not execute scaling activities that are triggered by CloudMonitor event-triggered tasks.
        /// </summary>
        [NameInMap("DefaultCooldown")]
        [Validation(Required=false)]
        public int? DefaultCooldown { get; set; }

        /// <summary>
        /// The expected number of ECS instances or elastic container instances in the scaling group. Auto Scaling maintains the expected number of ECS instances or elastic container instances in the scaling group. Make sure that you adhere to the following rule when specifying this parameter: Value of MaxSize ≥ Value of DesiredCapacity ≥ Value of MinSize
        /// 
        /// >  If you re-enable the Expected Number of Instances feature, you must specify a value for `DesiredCapacity` again.
        /// </summary>
        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public int? DesiredCapacity { get; set; }

        [NameInMap("DisableDesiredCapacity")]
        [Validation(Required=false)]
        public bool? DisableDesiredCapacity { get; set; }

        /// <summary>
        /// Specifies whether to enable deletion protection for the scaling group. Valid values:
        /// 
        /// *   true: enables deletion protection for the scaling group. This way, the scaling group cannot be deleted.
        /// *   false: disables deletion protection for the scaling group.
        /// </summary>
        [NameInMap("GroupDeletionProtection")]
        [Validation(Required=false)]
        public bool? GroupDeletionProtection { get; set; }

        /// <summary>
        /// The health check mode of the scaling group. Valid values:
        /// 
        /// *   NONE: Auto Scaling does not perform health checks.
        /// *   ECS: Auto Scaling checks the health status of ECS instances in the scaling group.
        /// *   ECI: Auto Scaling checks the health status of elastic container instances in the scaling group.
        /// *   LOAD_BALANCER: Auto Scaling checks the health status of instances in the scaling group based on the health check results of load balancers. The health check results of Classic Load Balancer (CLB) instances are not supported as the health check basis for instances in the scaling group.
        /// 
        /// >  HealthCheckType has the same effect as `HealthCheckTypes`. You can select one of them to specify based on your business requirements. If you specify `HealthCheckTypes`, `HealthCheckType` is ignored. HealthCheckType is optional.
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// The health check modes of the scaling group. Valid values:
        /// 
        /// *   NONE: Auto Scaling does not perform health checks.
        /// *   ECS: Auto Scaling checks the health status of ECS instances in the scaling group.
        /// *   ECI: Auto Scaling checks the health status of elastic container instances in the scaling group.
        /// *   LOAD_BALANCER: Auto Scaling checks the health status of instances in the scaling group based on the health check results of load balancers. The health check results of CLB instances are not supported as the health check basis for instances in the scaling group.
        /// </summary>
        [NameInMap("HealthCheckTypes")]
        [Validation(Required=false)]
        public List<string> HealthCheckTypes { get; set; }

        /// <summary>
        /// The ID of the launch template that is used by Auto Scaling to create instances.
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// Details of the instance types that are specified in the extended configurations of the launch template.
        /// </summary>
        [NameInMap("LaunchTemplateOverrides")]
        [Validation(Required=false)]
        public List<ModifyScalingGroupRequestLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
        public class ModifyScalingGroupRequestLaunchTemplateOverrides : TeaModel {
            /// <summary>
            /// The instance type. The instance type that you specify by using the InstanceType parameter overwrites the instance type that is specified in the launch template.
            /// 
            /// If you want Auto Scaling to scale instances in the scaling group based on the instance type weight, you must specify both the InstanceType and WeightedCapacity parameters.
            /// 
            /// > This parameter takes effect only after you specify the LaunchTemplateId parameter.
            /// 
            /// You can use the InstanceType parameter to specify only instance types that are available for purchase.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

            /// <summary>
            /// The weight of the instance type. The weight specifies the capacity of a single instance of the specified instance type in the scaling group. If you want Auto Scaling to scale instances in the scaling group based on the weighted capacity of instances, you must specify the WeightedCapacity parameter after you specify the InstanceType parameter.
            /// 
            /// A higher weight specifies that a smaller number of instances of the specified instance type are required to meet the expected capacity.
            /// 
            /// Performance metrics, such as the number of vCPUs and the memory size of each instance type, may vary. You can specify different weights for different instance types based on your business requirements.
            /// 
            /// Example:
            /// 
            /// *   Current capacity: 0
            /// *   Expected capacity: 6
            /// *   Capacity of ecs.c5.xlarge: 4
            /// 
            /// To meet the expected capacity requirement, Auto Scaling must create and add two ecs.c5.xlarge instances.
            /// 
            /// > The capacity of the scaling group cannot exceed the sum of the maximum number of instances that is specified by the MaxSize parameter and the maximum weight of the instance type.
            /// 
            /// Valid values of the WeightedCapacity parameter: 1 to 500.
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

        }

        /// <summary>
        /// The version number of the launch template. Valid values:
        /// 
        /// *   A fixed template version number.
        /// *   Default: The default template version is always used.
        /// *   Latest: The latest template version is always used.
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// The maximum life span of the instance in the scaling group. Unit: seconds.
        /// 
        /// Valid values: 86400 to Integer.maxValue. ``You can also set this parameter to 0. A value of 0 indicates that the instance has an unlimited life span in the scaling group.
        /// 
        /// Default value: null.
        /// 
        /// > You cannot specify this parameter for scaling groups that manage elastic container instances or scaling groups whose ScalingPolicy is set to recycle.
        /// </summary>
        [NameInMap("MaxInstanceLifetime")]
        [Validation(Required=false)]
        public int? MaxInstanceLifetime { get; set; }

        /// <summary>
        /// The maximum number of ECS instances or elastic container instances that can be contained in the scaling group. If the total number of instances in the scaling group is greater than the value of MaxSize, Auto Scaling proactively removes the surplus instances from the scaling group to restore the total number to match the maximum limit.
        /// 
        /// The value range of MaxSize is directly correlated with the degree of dependency your business has on Auto Scaling. You can go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas) to check **the maximum number of instances that a single scaling group can contain.**
        /// 
        /// For example, if a scaling group can contain up to **2,000** instances, the value range of MaxSize is 0 to 2000.
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public int? MaxSize { get; set; }

        /// <summary>
        /// The minimum number of ECS instances or elastic container instances that must be contained in the scaling group. If the total number of instances in the scaling group is less than the value of MinSize, Auto Scaling proactively adds instances to the scaling group to ensure that the total number aligns with the minimum threshold.
        /// 
        /// >  The value of MinSize must be less than or equal to the value of MaxSize.
        /// </summary>
        [NameInMap("MinSize")]
        [Validation(Required=false)]
        public int? MinSize { get; set; }

        /// <summary>
        /// The scaling policy for the multi-zone scaling group that contains ECS instances. Valid values:
        /// 
        /// *   PRIORITY: ECS instances are scaled based on the vSwitch priority. The first vSwitch specified by using the VSwitchIds parameter has the highest priority. Auto Scaling preferentially scales instances in the zone where the vSwitch that has the highest priority resides. If the scaling fails, Auto Scaling scales instances in the zone where the vSwitch that has the next highest priority resides.
        /// *   COST_OPTIMIZED: During a scale-out activity, Auto Scaling preferentially creates ECS instances of the instance type that has the lowest unit price of vCPU. During a scale-in activity, Auto Scaling preferentially removes ECS instances of the instance types that have the highest unit price of vCPU. Auto Scaling preferentially creates preemptible instances when preemptible instance types are specified in the scaling configuration. You can use the `CompensateWithOnDemand` parameter to specify whether to automatically create pay-as-you-go instances when Auto Scaling fails to create preemptible instances.
        /// 
        /// > The `COST_OPTIMIZED` setting takes effect only when multiple instance types are specified or at least one instance type is specified for preemptible instances.
        /// 
        /// *   BALANCE: ECS instances are evenly distributed across zones that are specified in the scaling group. If ECS instances are unevenly distributed among zones due to insufficient resources, you can call the RebalanceInstance operation to evenly distribute the instances among the zones.
        /// *   COMPOSABLE: You can flexibly combine the preceding policies based on your business requirements.
        /// </summary>
        [NameInMap("MultiAZPolicy")]
        [Validation(Required=false)]
        public string MultiAZPolicy { get; set; }

        /// <summary>
        /// The minimum number of pay-as-you-go instances that must be included in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is less than the value of this parameter, Auto Scaling preferentially creates pay-as-you-go instances.
        /// 
        /// If you set the `MultiAZPolicy` parameter to `COMPOSABLE` Policy, the default value is 0.
        /// </summary>
        [NameInMap("OnDemandBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// The expected percentage of pay-as-you-go instances in the excess instances when the minimum number of pay-as-you-go instances reaches the requirement. Valid values: 0 to 100.
        /// 
        /// If you set the `MultiAZPolicy` parameter to `COMPOSABLE` Policy, the default value is 100.
        /// </summary>
        [NameInMap("OnDemandPercentageAboveBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandPercentageAboveBaseCapacity { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The policy that is used to remove ECS instances from the scaling group. Valid values:
        /// 
        /// *   OldestInstance: removes ECS instances that are added at the earliest point in time to the scaling group.
        /// *   NewestInstance: removes ECS instances that are most recently added to the scaling group.
        /// *   OldestScalingConfiguration: removes ECS instances that are created based on the earliest scaling configuration.
        /// </summary>
        [NameInMap("RemovalPolicies")]
        [Validation(Required=false)]
        public List<string> RemovalPolicies { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the scaling group that you want to modify.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// The name of the scaling group. The name of each scaling group must be unique in a region. The name must be 2 to 64 characters in length and can contain letters, digits, underscores (_), hyphens (-), and periods (.). The name must start with a letter or a digit.
        /// </summary>
        [NameInMap("ScalingGroupName")]
        [Validation(Required=false)]
        public string ScalingGroupName { get; set; }

        /// <summary>
        /// The reclaim mode of the scaling group. Valid values:
        /// 
        /// *   recycle: economical mode
        /// 
        /// *   release: release mode
        /// 
        /// *   forcerelease: forced release mode
        /// 
        ///     **
        /// 
        ///     **Note** If you set the value to `forcerelease`, Auto Scaling forcibly releases instances that are in the `Running` state during scale-ins. Forced release is equivalent to power outage. If an instance is forcibly released, ephemeral data on the instance will be cleared and cannot be recovered. Exercise caution when you select this option.
        /// 
        /// *   forcerecycle: forced recycle mode
        /// 
        ///     **
        /// 
        ///     **Note** If you set the value to `forcerecycle`, Auto Scaling forcibly shuts down instances that are in the `Running` state during scale-ins. Forced shutdown is equivalent to power outage. If an instance is forcibly shut down, ephemeral data on the instance will be cleared and cannot be recovered. Exercise caution when you select this option.
        /// 
        /// ScalingPolicy specifies only the reclaim mode of the scaling group. RemovePolicy of the RemoveInstances operation specifies the manner how instances are removed from the scaling group. For more information, see [RemoveInstances](https://help.aliyun.com/document_detail/25955.html).
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public string ScalingPolicy { get; set; }

        /// <summary>
        /// The allocation policy of preemptible instances. You can use this parameter to individually specify the allocation policy of preemptible instances. This parameter takes effect only when you set the `MultiAZPolicy` parameter to `COMPOSABLE`. Valid values:
        /// 
        /// *   priority: Auto Scaling selects instance types based on the specified order to create the required number of preemptible instances.
        /// *   lowestPrice: Auto Scaling selects instance types that have the lowest unit price of vCPUs to create the required number of preemptible instances.
        /// 
        /// Default value: priority.
        /// </summary>
        [NameInMap("SpotAllocationStrategy")]
        [Validation(Required=false)]
        public string SpotAllocationStrategy { get; set; }

        /// <summary>
        /// The number of instance types that you specify. Auto Scaling creates preemptible instances of multiple instance types that are provided at the lowest price. Valid values: 0 to 10.
        /// 
        /// If you set the `MultiAZPolicy` parameter to `COMPOSABLE` Policy, the default value is 2.
        /// </summary>
        [NameInMap("SpotInstancePools")]
        [Validation(Required=false)]
        public int? SpotInstancePools { get; set; }

        /// <summary>
        /// Specifies whether to supplement preemptible instances. If this parameter is set to true, Auto Scaling creates an instance to replace a preemptible instance when Auto Scaling receives the system message that the preemptible instance is to be reclaimed.
        /// </summary>
        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        /// <summary>
        /// The IDs of vSwitches.
        /// 
        /// This parameter takes effect only when the network type of the scaling group is virtual private cloud (VPC). The specified vSwitches and the scaling group must reside in the same VPC.
        /// 
        /// The vSwitches can reside in different zones. The vSwitches are sorted in ascending order. The first vSwitch specified by using the VSwitchIds parameter has the highest priority. If Auto Scaling fails to create ECS instances in the zone where the vSwitch that has the highest priority resides, Auto Scaling creates ECS instances in the zone where the vSwitch that has the next highest priority resides.
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
