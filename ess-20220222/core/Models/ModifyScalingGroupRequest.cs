// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyScalingGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the active scaling configuration in the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc-bp17pelvl720x5ub****</para>
        /// </summary>
        [NameInMap("ActiveScalingConfigurationId")]
        [Validation(Required=false)]
        public string ActiveScalingConfigurationId { get; set; }

        /// <summary>
        /// <para>The allocation policy. Auto Scaling selects instance types based on the allocation policy to create the required number of instances. The policy can be applied to pay-as-you-go instances and preemptible instances at the same time. This parameter takes effect only when you set the MultiAZPolicy parameter to COMPOSABLE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>priority: Auto Scaling selects instance types based on the specified order to create the required number of instances.</description></item>
        /// <item><description>lowestPrice: Auto Scaling selects instance types that have the lowest unit price of vCPUs to create the required number of instances.</description></item>
        /// </list>
        /// <para>Default value: priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>priority</para>
        /// </summary>
        [NameInMap("AllocationStrategy")]
        [Validation(Required=false)]
        public string AllocationStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to evenly distribute instances in the scaling group across zones. This parameter takes effect only when you set the <c>MultiAZPolicy</c> parameter to <c>COMPOSABLE</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AzBalance")]
        [Validation(Required=false)]
        public bool? AzBalance { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create pay-as-you-go instances to meet the requirements on the number of ECS instances in the scaling group when the number of preemptible instances cannot be reached due to reasons such as cost-related issues and insufficient resources. This parameter takes effect only if you set <c>MultiAZPolicy</c> in the <c>CreateScalingGroup</c> operation to <c>COST_OPTIMIZED</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CompensateWithOnDemand")]
        [Validation(Required=false)]
        public bool? CompensateWithOnDemand { get; set; }

        /// <summary>
        /// <para>The ARN of the custom scaling policy (Function). This parameter takes effect only when you specify CustomPolicy as the first step of the instance removal policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-zhangjiakou:16145688****:services/ess_custom_terminate_policy.LATEST/functions/ess_custom_terminate_policy_name</para>
        /// </summary>
        [NameInMap("CustomPolicyARN")]
        [Validation(Required=false)]
        public string CustomPolicyARN { get; set; }

        /// <summary>
        /// <para>The cooldown period of the scaling group. This parameter is available only if you set ScalingRuleType to SimpleScalingRule. Valid values: 0 to 86400. Unit: seconds.</para>
        /// <para>During the cooldown period, Auto Scaling does not execute scaling activities that are triggered by CloudMonitor event-triggered tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("DefaultCooldown")]
        [Validation(Required=false)]
        public int? DefaultCooldown { get; set; }

        /// <summary>
        /// <para>The expected number of ECS instances or elastic container instances in the scaling group. Auto Scaling maintains the expected number of ECS instances or elastic container instances in the scaling group. Make sure that you adhere to the following rule when specifying this parameter: Value of MaxSize ≥ Value of DesiredCapacity ≥ Value of MinSize</para>
        /// <remarks>
        /// <para> If you re-enable the Expected Number of Instances feature, you must specify a value for <c>DesiredCapacity</c> again.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public int? DesiredCapacity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableDesiredCapacity")]
        [Validation(Required=false)]
        public bool? DisableDesiredCapacity { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables deletion protection for the scaling group. This way, the scaling group cannot be deleted.</description></item>
        /// <item><description>false: disables deletion protection for the scaling group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GroupDeletionProtection")]
        [Validation(Required=false)]
        public bool? GroupDeletionProtection { get; set; }

        /// <summary>
        /// <para>The health check mode of the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NONE: Auto Scaling does not perform health checks.</description></item>
        /// <item><description>ECS: Auto Scaling checks the health status of ECS instances in the scaling group.</description></item>
        /// <item><description>ECI: Auto Scaling checks the health status of elastic container instances in the scaling group.</description></item>
        /// <item><description>LOAD_BALANCER: Auto Scaling checks the health status of instances in the scaling group based on the health check results of load balancers. The health check results of Classic Load Balancer (CLB) instances are not supported as the health check basis for instances in the scaling group.</description></item>
        /// </list>
        /// <remarks>
        /// <para> HealthCheckType has the same effect as <c>HealthCheckTypes</c>. You can select one of them to specify based on your business requirements. If you specify <c>HealthCheckTypes</c>, <c>HealthCheckType</c> is ignored. HealthCheckType is optional.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// <para>The health check modes of the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NONE: Auto Scaling does not perform health checks.</description></item>
        /// <item><description>ECS: Auto Scaling checks the health status of ECS instances in the scaling group.</description></item>
        /// <item><description>ECI: Auto Scaling checks the health status of elastic container instances in the scaling group.</description></item>
        /// <item><description>LOAD_BALANCER: Auto Scaling checks the health status of instances in the scaling group based on the health check results of load balancers. The health check results of CLB instances are not supported as the health check basis for instances in the scaling group.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("HealthCheckTypes")]
        [Validation(Required=false)]
        public List<string> HealthCheckTypes { get; set; }

        /// <summary>
        /// <para>The ID of the launch template that is used by Auto Scaling to create instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-m5e3ofjr1zn1aw7****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>Details of the instance types that are specified in the extended configurations of the launch template.</para>
        /// </summary>
        [NameInMap("LaunchTemplateOverrides")]
        [Validation(Required=false)]
        public List<ModifyScalingGroupRequestLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
        public class ModifyScalingGroupRequestLaunchTemplateOverrides : TeaModel {
            /// <summary>
            /// <para>The instance type. The instance type that you specify by using the InstanceType parameter overwrites the instance type that is specified in the launch template.</para>
            /// <para>If you want Auto Scaling to scale instances in the scaling group based on the instance type weight, you must specify both the InstanceType and WeightedCapacity parameters.</para>
            /// <remarks>
            /// <para>This parameter takes effect only after you specify the LaunchTemplateId parameter.</para>
            /// </remarks>
            /// <para>You can use the InstanceType parameter to specify only instance types that are available for purchase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.025</para>
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

            /// <summary>
            /// <para>The weight of the instance type. The weight specifies the capacity of a single instance of the specified instance type in the scaling group. If you want Auto Scaling to scale instances in the scaling group based on the weighted capacity of instances, you must specify the WeightedCapacity parameter after you specify the InstanceType parameter.</para>
            /// <para>A higher weight specifies that a smaller number of instances of the specified instance type are required to meet the expected capacity.</para>
            /// <para>Performance metrics, such as the number of vCPUs and the memory size of each instance type, may vary. You can specify different weights for different instance types based on your business requirements.</para>
            /// <para>Example:</para>
            /// <list type="bullet">
            /// <item><description>Current capacity: 0</description></item>
            /// <item><description>Expected capacity: 6</description></item>
            /// <item><description>Capacity of ecs.c5.xlarge: 4</description></item>
            /// </list>
            /// <para>To meet the expected capacity requirement, Auto Scaling must create and add two ecs.c5.xlarge instances.</para>
            /// <remarks>
            /// <para>The capacity of the scaling group cannot exceed the sum of the maximum number of instances that is specified by the MaxSize parameter and the maximum weight of the instance type.</para>
            /// </remarks>
            /// <para>Valid values of the WeightedCapacity parameter: 1 to 500.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

        }

        /// <summary>
        /// <para>The version number of the launch template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>A fixed template version number.</description></item>
        /// <item><description>Default: The default template version is always used.</description></item>
        /// <item><description>Latest: The latest template version is always used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The maximum life span of the instance in the scaling group. Unit: seconds.</para>
        /// <para>Valid values: 86400 to Integer.maxValue. ``You can also set this parameter to 0. A value of 0 indicates that the instance has an unlimited life span in the scaling group.</para>
        /// <para>Default value: null.</para>
        /// <remarks>
        /// <para>You cannot specify this parameter for scaling groups that manage elastic container instances or scaling groups whose ScalingPolicy is set to recycle.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("MaxInstanceLifetime")]
        [Validation(Required=false)]
        public int? MaxInstanceLifetime { get; set; }

        /// <summary>
        /// <para>The maximum number of ECS instances or elastic container instances that can be contained in the scaling group. If the total number of instances in the scaling group is greater than the value of MaxSize, Auto Scaling proactively removes the surplus instances from the scaling group to restore the total number to match the maximum limit.</para>
        /// <para>The value range of MaxSize is directly correlated with the degree of dependency your business has on Auto Scaling. You can go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to check <b>the maximum number of instances that a single scaling group can contain.</b></para>
        /// <para>For example, if a scaling group can contain up to <b>2,000</b> instances, the value range of MaxSize is 0 to 2000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public int? MaxSize { get; set; }

        /// <summary>
        /// <para>The minimum number of ECS instances or elastic container instances that must be contained in the scaling group. If the total number of instances in the scaling group is less than the value of MinSize, Auto Scaling proactively adds instances to the scaling group to ensure that the total number aligns with the minimum threshold.</para>
        /// <remarks>
        /// <para> The value of MinSize must be less than or equal to the value of MaxSize.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinSize")]
        [Validation(Required=false)]
        public int? MinSize { get; set; }

        /// <summary>
        /// <para>The scaling policy for the multi-zone scaling group that contains ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIORITY: ECS instances are scaled based on the vSwitch priority. The first vSwitch specified by using the VSwitchIds parameter has the highest priority. Auto Scaling preferentially scales instances in the zone where the vSwitch that has the highest priority resides. If the scaling fails, Auto Scaling scales instances in the zone where the vSwitch that has the next highest priority resides.</description></item>
        /// <item><description>COST_OPTIMIZED: During a scale-out activity, Auto Scaling preferentially creates ECS instances of the instance type that has the lowest unit price of vCPU. During a scale-in activity, Auto Scaling preferentially removes ECS instances of the instance types that have the highest unit price of vCPU. Auto Scaling preferentially creates preemptible instances when preemptible instance types are specified in the scaling configuration. You can use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically create pay-as-you-go instances when Auto Scaling fails to create preemptible instances.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The <c>COST_OPTIMIZED</c> setting takes effect only when multiple instance types are specified or at least one instance type is specified for preemptible instances.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>BALANCE: ECS instances are evenly distributed across zones that are specified in the scaling group. If ECS instances are unevenly distributed among zones due to insufficient resources, you can call the RebalanceInstance operation to evenly distribute the instances among the zones.</description></item>
        /// <item><description>COMPOSABLE: You can flexibly combine the preceding policies based on your business requirements.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIORITY</para>
        /// </summary>
        [NameInMap("MultiAZPolicy")]
        [Validation(Required=false)]
        public string MultiAZPolicy { get; set; }

        /// <summary>
        /// <para>The minimum number of pay-as-you-go instances that must be included in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is less than the value of this parameter, Auto Scaling preferentially creates pay-as-you-go instances.</para>
        /// <para>If you set the <c>MultiAZPolicy</c> parameter to <c>COMPOSABLE</c> Policy, the default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("OnDemandBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// <para>The expected percentage of pay-as-you-go instances in the excess instances when the minimum number of pay-as-you-go instances reaches the requirement. Valid values: 0 to 100.</para>
        /// <para>If you set the <c>MultiAZPolicy</c> parameter to <c>COMPOSABLE</c> Policy, the default value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
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
        /// <para>The policy that is used to remove ECS instances from the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OldestInstance: removes ECS instances that are added at the earliest point in time to the scaling group.</description></item>
        /// <item><description>NewestInstance: removes ECS instances that are most recently added to the scaling group.</description></item>
        /// <item><description>OldestScalingConfiguration: removes ECS instances that are created based on the earliest scaling configuration.</description></item>
        /// </list>
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
        /// <para>The ID of the scaling group that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1ffogfdauy0jw0****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The name of the scaling group. The name of each scaling group must be unique in a region. The name must be 2 to 64 characters in length and can contain letters, digits, underscores (_), hyphens (-), and periods (.). The name must start with a letter or a digit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scalinggroup****</para>
        /// </summary>
        [NameInMap("ScalingGroupName")]
        [Validation(Required=false)]
        public string ScalingGroupName { get; set; }

        /// <summary>
        /// <para>The reclaim mode of the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>recycle: economical mode</para>
        /// </description></item>
        /// <item><description><para>release: release mode</para>
        /// </description></item>
        /// <item><description><para>forcerelease: forced release mode</para>
        /// <para>**</para>
        /// <para><b>Note</b> If you set the value to <c>forcerelease</c>, Auto Scaling forcibly releases instances that are in the <c>Running</c> state during scale-ins. Forced release is equivalent to power outage. If an instance is forcibly released, ephemeral data on the instance will be cleared and cannot be recovered. Exercise caution when you select this option.</para>
        /// </description></item>
        /// <item><description><para>forcerecycle: forced recycle mode</para>
        /// <para>**</para>
        /// <para><b>Note</b> If you set the value to <c>forcerecycle</c>, Auto Scaling forcibly shuts down instances that are in the <c>Running</c> state during scale-ins. Forced shutdown is equivalent to power outage. If an instance is forcibly shut down, ephemeral data on the instance will be cleared and cannot be recovered. Exercise caution when you select this option.</para>
        /// </description></item>
        /// </list>
        /// <para>ScalingPolicy specifies only the reclaim mode of the scaling group. RemovePolicy of the RemoveInstances operation specifies the manner how instances are removed from the scaling group. For more information, see <a href="https://help.aliyun.com/document_detail/25955.html">RemoveInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recycle</para>
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public string ScalingPolicy { get; set; }

        /// <summary>
        /// <para>The allocation policy of preemptible instances. You can use this parameter to individually specify the allocation policy of preemptible instances. This parameter takes effect only when you set the <c>MultiAZPolicy</c> parameter to <c>COMPOSABLE</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>priority: Auto Scaling selects instance types based on the specified order to create the required number of preemptible instances.</description></item>
        /// <item><description>lowestPrice: Auto Scaling selects instance types that have the lowest unit price of vCPUs to create the required number of preemptible instances.</description></item>
        /// </list>
        /// <para>Default value: priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lowestPrice</para>
        /// </summary>
        [NameInMap("SpotAllocationStrategy")]
        [Validation(Required=false)]
        public string SpotAllocationStrategy { get; set; }

        /// <summary>
        /// <para>The number of instance types that you specify. Auto Scaling creates preemptible instances of multiple instance types that are provided at the lowest price. Valid values: 0 to 10.</para>
        /// <para>If you set the <c>MultiAZPolicy</c> parameter to <c>COMPOSABLE</c> Policy, the default value is 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SpotInstancePools")]
        [Validation(Required=false)]
        public int? SpotInstancePools { get; set; }

        /// <summary>
        /// <para>Specifies whether to supplement preemptible instances. If this parameter is set to true, Auto Scaling creates an instance to replace a preemptible instance when Auto Scaling receives the system message that the preemptible instance is to be reclaimed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        /// <summary>
        /// <para>The IDs of vSwitches.</para>
        /// <para>This parameter takes effect only when the network type of the scaling group is virtual private cloud (VPC). The specified vSwitches and the scaling group must reside in the same VPC.</para>
        /// <para>The vSwitches can reside in different zones. The vSwitches are sorted in ascending order. The first vSwitch specified by using the VSwitchIds parameter has the highest priority. If Auto Scaling fails to create ECS instances in the zone where the vSwitch that has the highest priority resides, Auto Scaling creates ECS instances in the zone where the vSwitch that has the next highest priority resides.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
