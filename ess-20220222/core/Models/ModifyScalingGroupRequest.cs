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
        /// <para>The capacity allocation policy, which determines how the scaling group selects available instance types to meet the capacity requirements. The capacity distribution policy applies to both pay-as-you-go and spot capacities. This parameter takes effect only when the MultiAZPolicy parameter is set to COMPOSABLE. Valid values:                              </para>
        /// <list type="bullet">
        /// <item><description><para>priority: creates instances in the order of the configured instance types.</para>
        /// </description></item>
        /// <item><description><para>lowestPrice: creates instances in ascending order of the vCPU unit price of the instance types.</para>
        /// </description></item>
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
        /// <para>Specifies whether to enable automatic balancing for the scaling group. This parameter takes effect only when BalancedOnly is enabled for a zone-balanced scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: disables automatic balancing for the scaling group.</description></item>
        /// <item><description>true: enables automatic balancing for the scaling group. The scaling group automatically detects the capacity across zones. If the capacity is unbalanced across zones, the scaling group proactively scales across zones to rebalance the capacity.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRebalance")]
        [Validation(Required=false)]
        public bool? AutoRebalance { get; set; }

        /// <summary>
        /// <para>Specifies whether the capacity of the scaling group is evenly distributed across multiple zones. This parameter takes effect only when the MultiAZPolicy parameter is set to COMPOSABLE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The capacity of the scaling group is evenly distributed across multiple zones.</description></item>
        /// <item><description>false: The capacity of the scaling group is not evenly distributed across multiple zones.</description></item>
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
        /// <para>The zone balancing mode. This parameter takes effect only when the zone balancing mode is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>BalancedBestEffort: If resource creation fails in a zone, the system degrades to other zones to ensure best-effort delivery of resources.</para>
        /// </description></item>
        /// <item><description><para>BalancedOnly: If resource creation fails in a zone, the system does not degrade to other zones. The scale-out activity partially succeeds to avoid excessive imbalance of resources across different zones.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: BalancedBestEffort.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BalancedBestEffort</para>
        /// </summary>
        [NameInMap("BalanceMode")]
        [Validation(Required=false)]
        public string BalanceMode { get; set; }

        /// <summary>
        /// <para>The capacity options.</para>
        /// </summary>
        [NameInMap("CapacityOptions")]
        [Validation(Required=false)]
        public ModifyScalingGroupRequestCapacityOptions CapacityOptions { get; set; }
        public class ModifyScalingGroupRequestCapacityOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically attempt to create pay-as-you-go instances to meet the required number of ECS instances if sufficient spot instances cannot be created due to price or inventory reasons when the MultiAZPolicy parameter of the CreateScalingGroup operation is set to COST_OPTIMIZED. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: allows the creation of pay-as-you-go instances.</description></item>
            /// <item><description>false: does not allow the creation of pay-as-you-go instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CompensateWithOnDemand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// <para>The minimum number of pay-as-you-go instances required in the scaling group. If the number of pay-as-you-go instances in the scaling group is less than this value, the system preferentially creates pay-as-you-go instances. Valid values: 0 to 1000.</para>
            /// <para>Default value: 0 when the MultiAZPolicy parameter is set to COMPOSABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("OnDemandBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of pay-as-you-go instances among the extra instances that exceed the minimum number of pay-as-you-go instances specified by OnDemandBaseCapacity. Valid values: 0 to 100.</para>
            /// <para>Default value: 100 when the MultiAZPolicy parameter is set to COMPOSABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("OnDemandPercentageAboveBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The price comparison mode for the cost optimization policy of the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PricePerUnit: compares prices based on the price per unit of capacity.</para>
            /// <para>The capacity of an instance in the scaling group equals the weight configured for the instance type. The default weight is 1, which means one ECS instance occupies a capacity of 1.</para>
            /// </description></item>
            /// <item><description><para>PricePerVCpu: compares prices based on the price per vCPU.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: PricePerUnit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PricePerUnit</para>
            /// </summary>
            [NameInMap("PriceComparisonMode")]
            [Validation(Required=false)]
            public string PriceComparisonMode { get; set; }

            /// <summary>
            /// <para>Specifies whether to attempt to use spot instances to replace pay-as-you-go capacity when the percentage of pay-as-you-go instances exceeds the OnDemandPercentageAboveBaseCapacity value after CompensateWithOnDemand is enabled. In common scenarios where CompensateWithOnDemand downgrades spot instances to pay-as-you-go instances due to spot inventory or price reasons, this feature attempts to use spot instances to replace the excess pay-as-you-go capacity to avoid long-term retention of pay-as-you-go instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: allows the replacement.</description></item>
            /// <item><description>false: does not allow the replacement.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SpotAutoReplaceOnDemand")]
            [Validation(Required=false)]
            public bool? SpotAutoReplaceOnDemand { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to automatically attempt to create pay-as-you-go instances to meet the required number of ECS instances if sufficient spot instances cannot be created due to price or inventory reasons when the MultiAZPolicy parameter of the CreateScalingGroup operation is set to COST_OPTIMIZED. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: allows the creation of pay-as-you-go instances.</para>
        /// </description></item>
        /// <item><description><para>false: does not allow the creation of pay-as-you-go instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CompensateWithOnDemand")]
        [Validation(Required=false)]
        public bool? CompensateWithOnDemand { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the Function Compute function for the custom scale-in policy. This parameter takes effect only when the first removal policy configured in RemovalPolicies is CustomPolicy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-zhangjiakou:16145688****:services/ess_custom_terminate_policy.LATEST/functions/ess_custom_terminate_policy_name</para>
        /// </summary>
        [NameInMap("CustomPolicyARN")]
        [Validation(Required=false)]
        public string CustomPolicyARN { get; set; }

        /// <summary>
        /// <para>The default cooldown time of the scaling group. This parameter applies only to simple scaling rules. Valid values: 0 to 86400. Unit: seconds.</para>
        /// <para>During the cooldown time, the scaling group does not execute any other scaling activities. This applies only to scaling activities triggered by CloudMonitor event-triggered tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("DefaultCooldown")]
        [Validation(Required=false)]
        public int? DefaultCooldown { get; set; }

        /// <summary>
        /// <para>The expected number of ECS instances or elastic container instances in the scaling group. The scaling group automatically maintains the number of ECS instances or elastic container instances at the expected number. Valid values: MinSize to MaxSize.</para>
        /// <remarks>
        /// <para>If the expected number of instances feature is disabled and then re-enabled, you must reset the DesiredCapacity value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public int? DesiredCapacity { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the expected number of instances feature for the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: enables the expected number of instances feature.</description></item>
        /// <item><description>true: disables the expected number of instances feature.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can change the Settings of this parameter to true (that is, shutdown the expected number of instances feature) only when no scaling activity is in progress in the scaling group. When you shutdown the expected number of instances feature, the current DesiredCapacity property of the scaling group is cleared, but the current number of instances in the scaling group remains unchanged.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableDesiredCapacity")]
        [Validation(Required=false)]
        public bool? DisableDesiredCapacity { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables deletion protection for the scaling group. In this case, the scaling group cannot be deleted.</description></item>
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
        /// <item><description>NONE: disables health checks.</description></item>
        /// <item><description>ECS: performs health checks on instances in the scaling group. This value applies to both ECS and elastic container instance scaling groups.</description></item>
        /// <item><description>LOAD_BALANCER: determines the health status of instances based on the health check results of load balancing. Classic Load Balancer (CLB) is not supported.
        /// Default value: ECS.</description></item>
        /// </list>
        /// <remarks>
        /// <para>To enable both instance health checks and load balancer health checks, use the HealthCheckTypes parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// <para>The health check modes of the scaling group.</para>
        /// <remarks>
        /// <para>You can use this parameter to specify multiple values to enable multiple health check options. If the HealthCheckType parameter is configured, this parameter is ignored.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("HealthCheckTypes")]
        [Validation(Required=false)]
        public List<string> HealthCheckTypes { get; set; }

        /// <summary>
        /// <para>The ID of the instance launch template, which is used to specify that the scaling group obtains launch configuration information from the instance launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-m5e3ofjr1zn1aw7****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The extended instance type information of the launch template.</para>
        /// </summary>
        [NameInMap("LaunchTemplateOverrides")]
        [Validation(Required=false)]
        public List<ModifyScalingGroupRequestLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
        public class ModifyScalingGroupRequestLaunchTemplateOverrides : TeaModel {
            /// <summary>
            /// <para>When you need the scaling group to scale based on the instance type capacity, specify both this parameter and LaunchTemplateOverrides.WeightedCapacity.</para>
            /// <para>This parameter is used to specify the instance type and overrides the instance type in the launch template.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when the LaunchTemplateId parameter is specified.</para>
            /// </remarks>
            /// <para>Valid values of InstanceType: available ECS instance types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>This parameter is used to specify the maximum hourly price for the instance type that overrides the launch template (that is, LaunchTemplateOverride.N.InstanceType). You can specify N values for this parameter to extend the launch template to support N instance types. Valid values of N: 1 to 20.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when the LaunchTemplateId parameter is specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0.025</para>
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

            /// <summary>
            /// <para>When you need the scaling group to scale based on the instance type capacity, specify this parameter after you specify LaunchTemplateOverrides.InstanceType. The two parameters correspond to each other.</para>
            /// <para>This parameter is used to specify the weight of the instance type, which indicates the capacity that a single instance of the instance type represents in the scaling group.</para>
            /// <para>A greater weight indicates that fewer instances of this instance type are required to meet the expected capacity.</para>
            /// <para>Because performance metrics such as the number of vCPUs and memory size vary with instance types, you can configure different weights for different instance types based on your needs.</para>
            /// <para>Example:</para>
            /// <list type="bullet">
            /// <item><description><para>Current capacity: 0.</para>
            /// </description></item>
            /// <item><description><para>Expected capacity: 6.</para>
            /// </description></item>
            /// <item><description><para>Capacity of the ecs.c5.xlarge instance type: 4.</para>
            /// </description></item>
            /// </list>
            /// <para>To meet the expected capacity, the scaling group scales out two ecs.c5.xlarge instances.</para>
            /// <remarks>
            /// <para>During scale-out, the capacity of the scaling group cannot exceed the sum of the maximum capacity (MaxSize) and the maximum weight of the instance type.</para>
            /// </remarks>
            /// <para>Valid values of WeightedCapacity: 1 to 500.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

        }

        /// <summary>
        /// <para>The version of the instance launch template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>A specific template version number.</description></item>
        /// <item><description>Default: always uses the default version of the template.</description></item>
        /// <item><description>Latest: always uses the latest version of the template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The maximum lifetime of an instance in the scaling group. Unit: seconds.</para>
        /// <para>Valid values: 0 or [86400, Integer.maxValue]. A value of 0 indicates that the configured value of MaxInstanceLifetime is cleared (that is, MaxInstanceLifetime is not configured).</para>
        /// <para>Default value: null.</para>
        /// <remarks>
        /// <para>This parameter cannot be configured for scaling groups of the elastic container instance type or scaling groups that have the no fees for stopped instances feature enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("MaxInstanceLifetime")]
        [Validation(Required=false)]
        public int? MaxInstanceLifetime { get; set; }

        /// <summary>
        /// <para>The maximum number of ECS instances or elastic container instances in the scaling group. If the number of ECS instances or elastic container instances in the scaling group exceeds the value of MaxSize, Auto Scaling automatically removes ECS instances or elastic container instances.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;The value range of MaxSize varies based on the usage of Auto Scaling. Go to the <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to view the quota value for the <b>maximum number of instances in a single scaling group</b>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;The value range of MaxSize varies based on the usage of Auto Scaling. Go to the <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to view the quota value for the <b>maximum number of instances in a single scaling group</b>.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;The value range of MaxSize varies based on the usage of Auto Scaling. Go to the Quota Center to view the quota value for the <b>maximum number of instances in a single scaling group</b>.</para>
        /// <para>For example, if the quota value for the <b>maximum number of instances in a single scaling group</b> is 2000, the value range of MaxSize is 0 to 2000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public int? MaxSize { get; set; }

        /// <summary>
        /// <para>The minimum number of ECS instances or elastic container instances in the scaling group. If the number of ECS instances or elastic container instances in the scaling group is less than the value of MinSize, Auto Scaling initiates the automatic creation of ECS instances or elastic container instances.</para>
        /// <remarks>
        /// <para>The value of MinSize must be less than or equal to the value of MaxSize.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinSize")]
        [Validation(Required=false)]
        public int? MinSize { get; set; }

        /// <summary>
        /// <para>The scaling policy for ECS instances in a multi-zone scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PRIORITY: scales the scaling group based on the priorities of vSwitches (VSwitchIds.N). Auto Scaling preferentially attempts to scale the scaling group in the zone where the vSwitch with the highest priority resides. If the scaling fails, Auto Scaling automatically attempts to scale the scaling group in the zone where the vSwitch with the next highest priority resides.</para>
        /// </description></item>
        /// <item><description><para>COST_OPTIMIZED: during scale-out, Auto Scaling attempts to create ECS instances in ascending order of vCPU unit price. During scale-in, Auto Scaling attempts to remove ECS instances in descending order of vCPU unit price. If the scaling configuration specifies multiple instance types that use the spot billing method, spot instances are preferentially created. You can use the CompensateWithOnDemand parameter to specify whether Auto Scaling automatically attempts to create pay-as-you-go instances when spot instances cannot be created.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>COST_OPTIMIZED takes effect only when the scaling configuration specifies multiple instance types or uses spot instances.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>BALANCE: evenly allocate ECS instances across the active zones specified for the scaling group. If the instances are unevenly distributed across zones due to insufficient inventory, you can call the RebalanceInstance operation to balance the resources.</para>
        /// </description></item>
        /// <item><description><para>COMPOSABLE: a composite policy that allows you to combine the preceding scaling policies for ECS instances in a multi-zone scaling group based on your needs.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIORITY</para>
        /// </summary>
        [NameInMap("MultiAZPolicy")]
        [Validation(Required=false)]
        public string MultiAZPolicy { get; set; }

        /// <summary>
        /// <para>The minimum number of pay-as-you-go instances required in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is less than this value, pay-as-you-go instances are preferentially created.</para>
        /// <para>Default value: 0 when the MultiAZPolicy parameter is set to COMPOSABLE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("OnDemandBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// <para>The percentage of pay-as-you-go instances among the extra instances that exceed the minimum number of pay-as-you-go instances specified by OnDemandBaseCapacity. Valid values: 0 to 100.</para>
        /// <para>Default value: 100 when the MultiAZPolicy parameter is set to COMPOSABLE.</para>
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
        /// <para>The scale-in policy of the scaling group, which specifies the ECS instances to be removed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OldestInstance: removes the ECS instances that were added to the scaling group at the earliest point in time.</para>
        /// </description></item>
        /// <item><description><para>NewestInstance: removes the ECS instances that were added to the scaling group at the latest point in time.</para>
        /// </description></item>
        /// <item><description><para>OldestScalingConfiguration: removes the ECS instances that were created by using the earliest scaling configuration.</para>
        /// </description></item>
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
        /// <para>The ID of the scaling group to be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1ffogfdauy0jw0****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The name of the scaling group. The name must be unique within a region. The name must be 2 to 64 characters in length and start with a letter, digit, or Chinese character. It can contain digits, underscores (_), hyphens (-), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>scalinggroup****</para>
        /// </summary>
        [NameInMap("ScalingGroupName")]
        [Validation(Required=false)]
        public string ScalingGroupName { get; set; }

        /// <summary>
        /// <para>The revoke pattern of the scaling group. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>recycle: The revoke pattern of the scaling group is shutdown and revoke pattern.  </para>
        /// </description></item>
        /// <item><description><para>release: The revoke pattern of the scaling group is release pattern.</para>
        /// </description></item>
        /// <item><description><para>forcerelease: The revoke pattern of the scaling group is forcible release pattern.</para>
        /// <remarks>
        /// <para>If you select forcerelease, the system forcibly releases instances in the Running state during scale-down activities. Forcibly releasing an instance is equivalent to a power-off operation, which erases temporary data in the memory and storage of the instance. The data cannot be recovered. Proceed with caution.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>forcerecycle: The revoke pattern of the scaling group is forcible shutdown and revoke pattern.</para>
        /// <remarks>
        /// <para>If you select forcerecycle, the system forcibly shuts down instances in the Running state during scale-down activities. Forcible shutdown is equivalent to a power-off operation, which erases temporary data in the memory and storage of the instance. The data cannot be recovered. Proceed with caution.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>The ScalingPolicy parameter specifies the revoke pattern of the scaling group. However, the specific action when an instance is removed from the scaling group is determined by the RemovePolicy parameter of the RemoveInstances operation. For more information, see <a href="https://help.aliyun.com/document_detail/25955.html">RemoveInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recycle</para>
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public string ScalingPolicy { get; set; }

        /// <summary>
        /// <para>The spot capacity distribution policy. You can use this parameter to separately specify the distribution policy for spot capacity. This parameter takes effect only when the MultiAZPolicy parameter is set to COMPOSABLE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>priority: creates instances in the order of the configured instance types.</description></item>
        /// <item><description>lowestPrice: creates instances in ascending order of the vCPU unit price of the instance types.</description></item>
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
        /// <para>The number of available instance types. The scaling group evenly creates spot instances across multiple instance types with the lowest cost. Valid values: 0 to 10.</para>
        /// <para>Default value: 2 when the MultiAZPolicy parameter is set to COMPOSABLE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SpotInstancePools")]
        [Validation(Required=false)]
        public int? SpotInstancePools { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the spot instance replenishment feature. After this feature is enabled, when the scaling group receives a system message indicating that a spot instance will be reclaimed, the scaling group attempts to create a new instance to replace the spot instance to be reclaimed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        /// <summary>
        /// <para>The timeout period for waiting for an ECS instance to be successfully stopped during the scale-in flow. Unit: seconds.
        /// Valid values: 30 to 240.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only in the scale-in flow when ScalingPolicy is set to the release pattern.  </description></item>
        /// <item><description>If the Settings of this parameter are configured, the system waits for a maximum of the StopInstanceTimeout period for the instance to be successfully stopped. After the timeout period elapses, the scale-in flow continues regardless of whether the instance is successfully stopped.  </description></item>
        /// <item><description>If the Settings of this parameter are not configured, the system waits for a long time for the instance to be successfully stopped. The scale-in flow continues only after the instance is successfully stopped. If the instance stop has failed, the scale-in flow will rollback and the scale-in has failed.</description></item>
        /// <item><description>A value of 0 indicates that the parameter settings of this parameter are canceled.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("StopInstanceTimeout")]
        [Validation(Required=false)]
        public int? StopInstanceTimeout { get; set; }

        /// <summary>
        /// <para>The IDs of one or more vSwitches.</para>
        /// <para>This parameter takes effect only when the network type of the scaling group is VPC. The VPC to which the specified vSwitches belong must be the same as the VPC to which the scaling group belongs.</para>
        /// <para>The vSwitches can reside in different zones. The priorities of vSwitches are sorted in ascending order of numbers. 1 indicates the highest priority. If ECS instances cannot be created in the zone where the vSwitch with a higher priority resides, the vSwitch with the next highest priority is automatically selected to create ECS instances.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>The behavior policy of the scaling group during zone shift.</para>
        /// </summary>
        [NameInMap("ZoneShiftPolicy")]
        [Validation(Required=false)]
        public ModifyScalingGroupRequestZoneShiftPolicy ZoneShiftPolicy { get; set; }
        public class ModifyScalingGroupRequestZoneShiftPolicy : TeaModel {
            /// <summary>
            /// <para>The health check behavior in impaired zones. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>ReplaceUnhealthy: normally replaces unhealthy instances in all zones. </description></item>
            /// <item><description>IgnoreUnhealthy: does not replace unhealthy instances in impaired zones. Healthy zones are not affected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ReplaceUnhealthy</para>
            /// </summary>
            [NameInMap("ImpairedZoneHealthCheckBehavior")]
            [Validation(Required=false)]
            public string ImpairedZoneHealthCheckBehavior { get; set; }

            /// <summary>
            /// <para>Blocks scale-in activities triggered by specified types of scaling rules. The blocking scope covers all zones under the scaling group, not just the impaired zones. This prevents false scale-in activities caused by fake improvements in monitoring metrics due to unreachable instances in impaired zones. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>StepScalingRule: blocks scale-in activities triggered by step scaling rules. </description></item>
            /// <item><description>TargetTrackingScalingRule: blocks scale-in activities triggered by target tracking scaling rules. </description></item>
            /// <item><description>None: does not block any scale-in activities.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>StepScalingRule</para>
            /// </summary>
            [NameInMap("ScaleInBlockedRuleTypes")]
            [Validation(Required=false)]
            public List<string> ScaleInBlockedRuleTypes { get; set; }

            /// <summary>
            /// <para>Specifies whether scale-out creates instances only in healthy zones during zone shift. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>true: creates instances only in healthy zones during scale-out and skips impaired zones. </description></item>
            /// <item><description>false: does not restrict zones, and scale-out can create instances in any zone under the scaling group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ScaleOutInHealthyZonesOnly")]
            [Validation(Required=false)]
            public bool? ScaleOutInHealthyZonesOnly { get; set; }

        }

    }

}
