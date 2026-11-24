// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateScalingGroupRequest : TeaModel {
        /// <summary>
        /// <para>The collection of information about the ALB server groups.</para>
        /// </summary>
        [NameInMap("AlbServerGroups")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestAlbServerGroups> AlbServerGroups { get; set; }
        public class CreateScalingGroupRequestAlbServerGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the ALB server group.</para>
            /// <para>A scaling group supports a limited number of associated ALB server groups. To view or manually apply for a quota increase, go to the <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgp-ddwb0y0g6y9bjm****</para>
            /// </summary>
            [NameInMap("AlbServerGroupId")]
            [Validation(Required=false)]
            public string AlbServerGroupId { get; set; }

            /// <summary>
            /// <para>The port number used by the instance after Auto Scaling adds the instance to the ALB server group. Valid values: 1 to 65535.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The weight of the instance as a backend server after Auto Scaling adds the instance to the ALB server group. A higher weight specifies that more requests are distributed to the instance. If the weight is 0, the instance does not receive requests. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The capacity allocation policy, which determines how the scaling group selects available instance types to meet the capacity requirements. The capacity distribution policy applies to both pay-as-you-go and spot capacities. This parameter takes effect only when the MultiAZPolicy parameter is set to COMPOSABLE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>priority: Creates instances based on the order of the configured instance types.</description></item>
        /// <item><description>lowestPrice: Creates instances based on the unit price per vCPU of the instance types in ascending order.</description></item>
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
        /// <para>Specifies whether to enable automatic balancing for the scaling group. This parameter takes effect only when BalancedOnly is enabled for the zone-balanced scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Does not enable automatic balancing for the scaling group.</description></item>
        /// <item><description>true: Enables automatic balancing for the scaling group. The scaling group automatically detects the capacity across zones. When the capacity is unbalanced across zones, the scaling group proactively scales out or in to rebalance the capacity across zones.</description></item>
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
        /// <remarks>
        /// <para>If the MultiAZPolicy parameter is set to COMPOSABLE and the AzBalance parameter is set to true, the effect is the same as when the MultiAZPolicy parameter is set to BALANCE.</para>
        /// </remarks>
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
        /// <item><description><para>BalancedBestEffort: When resource creation fails in a zone, the system falls back to other zones to ensure best-effort delivery of resources.</para>
        /// </description></item>
        /// <item><description><para>BalancedOnly: When resource creation fails in a zone, the system does not fall back to other zones. The scale-out activity partially succeeds to avoid excessive imbalance of resources across different zones.</para>
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
        public CreateScalingGroupRequestCapacityOptions CapacityOptions { get; set; }
        public class CreateScalingGroupRequestCapacityOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to allow the system to automatically attempt to create pay-as-you-go instances to meet the required number of ECS instances when the MultiAZPolicy parameter is set to COST_OPTIMIZED and sufficient spot instances cannot be created due to price or inventory reasons. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Allowed.</description></item>
            /// <item><description>false: Not allowed.</description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CompensateWithOnDemand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// <para>The minimum number of pay-as-you-go instances required in the scaling group. When the number of pay-as-you-go instances in the scaling group is less than this value, the system preferentially creates pay-as-you-go instances. Valid values: 0 to 1000.</para>
            /// <para>When the MultiAZPolicy parameter is set to COMPOSABLE, the default value is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("OnDemandBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of pay-as-you-go instances in the excess instances after the scaling group meets the minimum number of pay-as-you-go instances specified by OnDemandBaseCapacity. Valid values: 0 to 100.</para>
            /// <para>When the MultiAZPolicy parameter is set to COMPOSABLE, the default value is 100.</para>
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
            /// <item><description><para>PricePerUnit: Compares prices based on the price per unit of capacity.</para>
            /// <para>The capacity of an instance in the scaling group is equal to the weight set for the instance type. The default weight is 1, which means one ECS instance occupies a capacity of 1.</para>
            /// </description></item>
            /// <item><description><para>PricePerVCpu: Compares prices based on the price per vCPU.</para>
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
            /// <para>Specifies whether to attempt to use spot instances to replace pay-as-you-go capacity when CompensateWithOnDemand is enabled and the proportion of pay-as-you-go instances exceeds the OnDemandPercentageAboveBaseCapacity value. In common scenarios where CompensateWithOnDemand downgrades spot instances to pay-as-you-go instances due to spot inventory or price reasons, this parameter attempts to use spot instances to replace the excess pay-as-you-go capacity to avoid long-term existence of pay-as-you-go instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Allowed.</description></item>
            /// <item><description>false: Not allowed.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SpotAutoReplaceOnDemand")]
            [Validation(Required=false)]
            public bool? SpotAutoReplaceOnDemand { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically attempt to create pay-as-you-go instances to meet the required number of ECS instances when the MultiAZPolicy parameter is set to COST_OPTIMIZED and sufficient spot instances cannot be created due to price or inventory reasons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: allows the creation.</description></item>
        /// <item><description>false: does not allow the creation.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CompensateWithOnDemand")]
        [Validation(Required=false)]
        public bool? CompensateWithOnDemand { get; set; }

        /// <summary>
        /// <para>The ECI instance ID, which is the container group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eci-uf6fonnghi50u374****</para>
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// <para>The ARN of the Function Compute function for the custom scale-in policy. This parameter takes effect only when the first removal policy configured in RemovalPolicies is CustomPolicy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-zhangjiakou:16145688****:services/ess_custom_terminate_policy.LATEST/functions/ess_custom_terminate_policy_name</para>
        /// </summary>
        [NameInMap("CustomPolicyARN")]
        [Validation(Required=false)]
        public string CustomPolicyARN { get; set; }

        /// <summary>
        /// <para>The IDs of the ApsaraDB RDS instances. The value can be a JSON array that contains multiple ApsaraDB RDS instance IDs. Separate multiple IDs with commas (,). </para>
        /// <para>&lt;props=&quot;china&quot;&gt;The maximum number of ApsaraDB RDS instances that can be associated with a scaling group depends on your Auto Scaling usage. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to check the quota for the <b>maximum number of ApsaraDB RDS instances that can be associated with a scaling group</b>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;The maximum number of ApsaraDB RDS instances that can be associated with a scaling group depends on your Auto Scaling usage. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to check the quota for the <b>maximum number of ApsaraDB RDS instances that can be associated with a scaling group</b>.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;The maximum number of ApsaraDB RDS instances that can be associated with a scaling group depends on your Auto Scaling usage. Go to Quota Center to check the quota for the <b>maximum number of ApsaraDB RDS instances that can be associated with a scaling group</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;rm-bp142f86de0t7****&quot;, &quot;rm-bp18l1z42ar4o****&quot;, &quot;rm-bp1lqr97h4aqk****&quot;]</para>
        /// </summary>
        [NameInMap("DBInstanceIds")]
        [Validation(Required=false)]
        public string DBInstanceIds { get; set; }

        /// <summary>
        /// <para>The list of databases associated with the scaling group.</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestDBInstances> DBInstances { get; set; }
        public class CreateScalingGroupRequestDBInstances : TeaModel {
            /// <summary>
            /// <para>The association mode between the scaling group and the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SecurityIp: Modifies the IP whitelist mode by automatically adding scaled-out instances to the IP whitelist of the database. Only ApsaraDB RDS databases are supported.</description></item>
            /// <item><description>SecurityGroup: Uses the security group mode by adding the security group of the scaling configuration to the security group whitelist of the database to allow instances in the security group to access the database.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SecurityIp</para>
            /// </summary>
            [NameInMap("AttachMode")]
            [Validation(Required=false)]
            public string AttachMode { get; set; }

            /// <summary>
            /// <para>The database instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-m5eqju85s45mu0***</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The type of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RDS</description></item>
            /// <item><description>Redis</description></item>
            /// <item><description>MongoDB</description></item>
            /// </list>
            /// <para>Default value: RDS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The cooldown time after a scaling activity (adding or removing instances) is completed. Valid values: 0 to 86400. Unit: seconds.</para>
        /// <para>During the cooldown time, the scaling group does not execute other scaling activities. This parameter takes effect only for scaling activities triggered by CloudMonitor event-triggered tasks.  </para>
        /// <para>Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DefaultCooldown")]
        [Validation(Required=false)]
        public int? DefaultCooldown { get; set; }

        /// <summary>
        /// <para>The expected number of instances in the scaling group. The scaling group automatically maintains the number of instances at the expected number. The value cannot be greater than MaxSize or less than MinSize.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public int? DesiredCapacity { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables deletion protection for the scaling group. In this case, the scaling group cannot be deleted.</description></item>
        /// <item><description>false: disables deletion protection for the scaling group.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GroupDeletionProtection")]
        [Validation(Required=false)]
        public bool? GroupDeletionProtection { get; set; }

        /// <summary>
        /// <para>The type of instances managed by the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ECS: the scaling group manages ECS instances.</para>
        /// </description></item>
        /// <item><description><para>ECI: the scaling group manages ECI instances.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: ECS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The health check type of the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NONE: disables health checks.</description></item>
        /// <item><description>ECS: performs health checks on instances in the scaling group. This value is used to enable instance health checks for both ECS and ECI scaling groups.</description></item>
        /// <item><description>LOAD_BALANCER: determines the health status of instances based on the health check results of the load balancer. CLB is not supported.</description></item>
        /// </list>
        /// <para>Default value: ECS.</para>
        /// <remarks>
        /// <para>If you want to enable both instance health checks and load balancer health checks, use the <c>HealthCheckTypes</c> parameter.</para>
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
        /// <para>You can set multiple values for this parameter to enable multiple health check options. If the HealthCheckType parameter is specified, this parameter is ignored.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("HealthCheckTypes")]
        [Validation(Required=false)]
        public List<string> HealthCheckTypes { get; set; }

        /// <summary>
        /// <para>The ID of the instance. When you create a scaling group, Auto Scaling obtains the required configuration information from the specified instance and automatically creates a scaling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-28wt4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the launch template. This parameter is used to specify the launch template from which the scaling group obtains launch configurations.</para>
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
        public List<CreateScalingGroupRequestLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
        public class CreateScalingGroupRequestLaunchTemplateOverrides : TeaModel {
            /// <summary>
            /// <para>If you want the scaling group to scale based on the capacity of the instance type, specify both this parameter and LaunchTemplateOverrides.WeightedCapacity.</para>
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
            /// <para>This parameter is used to specify the maximum price for the overridden instance type (namely, <c>LaunchTemplateOverride.InstanceType</c>) in the launch template.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when the <c>LaunchTemplateId</c> parameter is specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0.025</para>
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

            /// <summary>
            /// <para>If you want the scaling group to scale based on the capacity of the instance type, specify this parameter after you specify LaunchTemplateOverrides.InstanceType.</para>
            /// <para>This parameter is used to specify the weight of the instance type, which indicates the capacity represented by a single instance of the instance type in the scaling group. A larger weight indicates that fewer instances of this instance type are required to meet the expected capacity.</para>
            /// <para>Because performance metrics such as the number of vCPUs and memory size vary among instance types, you can configure different weights for different instance types based on your needs.</para>
            /// <para>Example:</para>
            /// <list type="bullet">
            /// <item><description><para>Current capacity: 0.</para>
            /// </description></item>
            /// <item><description><para>Expected capacity: 6.</para>
            /// </description></item>
            /// <item><description><para>Capacity of the ecs.c5.xlarge instance type: 4.</para>
            /// </description></item>
            /// </list>
            /// <para>To meet the expected capacity, the scaling group scales out two ecs.c5.xlarge instances for you.</para>
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
        /// <para>The version of the launch template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>A specific version number.</para>
        /// </description></item>
        /// <item><description><para>Default: always uses the default version of the launch template.</para>
        /// </description></item>
        /// <item><description><para>Latest: always uses the latest version of the launch template.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The list of lifecycle hook information.</para>
        /// </summary>
        [NameInMap("LifecycleHooks")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestLifecycleHooks> LifecycleHooks { get; set; }
        public class CreateScalingGroupRequestLifecycleHooks : TeaModel {
            /// <summary>
            /// <para>The action to be performed after the wait state ends. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CONTINUE: continues the response to the scale-out activity or continues the response to the scale-down activity.</para>
            /// </description></item>
            /// <item><description><para>ABANDON: directly releases the instances created by the scale-out activity or directly removes the instances in the scale-down activity from the scaling group.</para>
            /// </description></item>
            /// </list>
            /// <para>When a scale-down activity (SCALE_IN) occurs in the scaling group and triggers multiple lifecycle hooks, if the wait state triggered by a lifecycle hook whose DefaultResult is ABANDON ends, the other corresponding wait states end in advance. In other cases, the next action is subject to the next action of the last wait state that ends.</para>
            /// <para>Default value: CONTINUE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONTINUE</para>
            /// </summary>
            [NameInMap("DefaultResult")]
            [Validation(Required=false)]
            public string DefaultResult { get; set; }

            /// <summary>
            /// <para>The wait time set by the lifecycle hook for the scaling group activity. After the wait state times out, the next action is performed. Valid values: 30 to 21600. Unit: seconds.</para>
            /// <para>After you create a lifecycle hook, you can call RecordLifecycleActionHeartbeat to extend the wait time of the instance, or call CompleteLifecycleAction to end the wait state of the scaling activity in advance.</para>
            /// <para>Default value: 600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("HeartbeatTimeout")]
            [Validation(Required=false)]
            public int? HeartbeatTimeout { get; set; }

            /// <summary>
            /// <para>The name of the lifecycle hook. The name cannot be modified after it is specified. If you do not specify this parameter, the default value is the same as the lifecycle hook ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lifecyclehook****</para>
            /// </summary>
            [NameInMap("LifecycleHookName")]
            [Validation(Required=false)]
            public string LifecycleHookName { get; set; }

            /// <summary>
            /// <para>The type of scaling activity to which the lifecycle hook applies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SCALE_OUT: scale-out activities of the scaling group.</para>
            /// </description></item>
            /// <item><description><para>SCALE_IN: scale-down activities of the scaling group.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If you specify a lifecycle hook for the scaling group, this parameter is required, and other related parameters are optional.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SCALE_OUT</para>
            /// </summary>
            [NameInMap("LifecycleTransition")]
            [Validation(Required=false)]
            public string LifecycleTransition { get; set; }

            /// <summary>
            /// <para>The identifier of the notification recipient for the lifecycle hook. Simple Message Queue (formerly MNS) queues or topics are supported. The parameter value format is acs:ess:{region}:{account-id}:{resource-relative-id}.</para>
            /// <list type="bullet">
            /// <item><description><para>region: the region where the scaling group resides.</para>
            /// </description></item>
            /// <item><description><para>account-id: the Alibaba Cloud account ID.</para>
            /// </description></item>
            /// </list>
            /// <para>Examples:</para>
            /// <list type="bullet">
            /// <item><description><para>Simple Message Queue (formerly MNS) queue: acs:ess:{region}:{account-id}:queue/{queuename}.</para>
            /// </description></item>
            /// <item><description><para>Simple Message Queue (formerly MNS) topic: acs:ess:{region}:{account-id}:topic/{topicname}.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ess:cn-hangzhou:1111111111:queue/queue2</para>
            /// </summary>
            [NameInMap("NotificationArn")]
            [Validation(Required=false)]
            public string NotificationArn { get; set; }

            /// <summary>
            /// <para>The fixed string information for the wait state of the scaling activity. The value cannot exceed 4,096 characters in length. Each time Auto Scaling pushes a message to the notification recipient, it also sends the predefined value of the NotificationMetadata parameter to help you manage and mark different types of notification information. The NotificationMetadata parameter takes effect only when you also specify the NotificationArn parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("NotificationMetadata")]
            [Validation(Required=false)]
            public string NotificationMetadata { get; set; }

        }

        /// <summary>
        /// <para>The list of load balancing configurations.</para>
        /// </summary>
        [NameInMap("LoadBalancerConfigs")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestLoadBalancerConfigs> LoadBalancerConfigs { get; set; }
        public class CreateScalingGroupRequestLoadBalancerConfigs : TeaModel {
            /// <summary>
            /// <para>The ID of the CLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-2zen1olhfg9yw3f4q****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The weight of the instance as a backend server after Auto Scaling adds the instance to the CLB server group. A higher weight specifies that more requests are distributed to the instance. If the weight is 0, the instance does not receive requests. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The IDs of the Classic Load Balancer (CLB) instances. The value can be a JSON array that contains multiple CLB instance IDs. Separate multiple IDs with commas (,).</para>
        /// <para>&lt;props=&quot;china&quot;&gt;The maximum number of CLB instances that can be associated with a scaling group depends on your Auto Scaling usage. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to check the quota for the <b>maximum number of load balancing instances that can be associated with a scaling group</b>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;The maximum number of CLB instances that can be associated with a scaling group depends on your Auto Scaling usage. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to check the quota for the <b>maximum number of load balancing instances that can be associated with a scaling group</b>.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;The maximum number of CLB instances that can be associated with a scaling group depends on your Auto Scaling usage. Go to Quota Center to check the quota for the <b>maximum number of load balancing instances that can be associated with a scaling group</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;lb-bp1u7etiogg38yvwz****&quot;, &quot;lb-bp168cqrux9ai9l7f****&quot;, &quot;lb-bp1jv3m9zvj22ufxp****&quot;]</para>
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public string LoadBalancerIds { get; set; }

        /// <summary>
        /// <para>The maximum lifetime of an instance in the scaling group. Unit: seconds.</para>
        /// <para>Valid values: [86400, Integer.maxValue].</para>
        /// <para>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("MaxInstanceLifetime")]
        [Validation(Required=false)]
        public int? MaxInstanceLifetime { get; set; }

        /// <summary>
        /// <para>The maximum number of instances in the scaling group. If the number of instances in the scaling group is greater than the value of MaxSize, Auto Scaling automatically removes instances. </para>
        /// <para>&lt;props=&quot;china&quot;&gt;The value range of MaxSize depends on your Auto Scaling usage. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to check the quota for the <b>maximum number of instances in a scaling group</b>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;The value range of MaxSize depends on your Auto Scaling usage. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to check the quota for the <b>maximum number of instances in a scaling group</b>.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;The value range of MaxSize depends on your Auto Scaling usage. Go to Quota Center to check the quota for the <b>maximum number of instances in a scaling group</b>.</para>
        /// <para>If the quota for the <b>maximum number of instances in a scaling group</b> is 2000, the value range of MaxSize is 0 to 2000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public int? MaxSize { get; set; }

        /// <summary>
        /// <para>The minimum number of instances in the scaling group. If the number of instances in the scaling group is less than the value of MinSize, Auto Scaling automatically creates instances. </para>
        /// <remarks>
        /// <para>The value of MinSize must be less than or equal to the value of MaxSize.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinSize")]
        [Validation(Required=false)]
        public int? MinSize { get; set; }

        /// <summary>
        /// <para>The multi-zone scaling policy for ECS instances in the scaling group. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>PRIORITY: the vSwitches specified by VSwitchIds are prioritized. Auto Scaling preferentially attempts to scale ECS instances in the zone where the highest-priority vSwitch resides. If the scaling fails, Auto Scaling automatically attempts to scale instances in the zone of the next highest-priority vSwitch.  </para>
        /// </description></item>
        /// <item><description><para>COST_OPTIMIZED: during scale-out, Auto Scaling attempts to create ECS instances in ascending order of vCPU unit price. During scale-in, Auto Scaling attempts to remove ECS instances in descending order of vCPU unit price. If the scaling configuration settings specify multiple instance types that use the preemptible billing method, spot instances are preferentially created. You can use the CompensateWithOnDemand parameter to specify whether to automatically attempt to create pay-as-you-go instances when spot instances cannot be created due to insufficient inventory or other reasons. </para>
        /// <remarks>
        /// <para>COST_OPTIMIZED takes effect only when the scaling configuration settings specify multiple instance types or use spot instances. </para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>BALANCE: evenly distributes ECS instances across the zones specified for the scaling group. If the instances are unevenly allocated across zones due to insufficient inventory or other reasons, you can invoke the <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstance</a> operation to balance the resources.</para>
        /// <remarks>
        /// <para>If the <c>MultiAZPolicy</c> parameter is set to <c>BALANCE</c>, the effect is the same as when the <c>MultiAZPolicy</c> parameter is set to <c>COMPOSABLE</c> and the <c>AzBalance</c> parameter is set to <c>true</c>. </para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>COMPOSABLE: a combined policy that allows you to combine the preceding multi-zone scaling policies for ECS instances based on your needs. You can also specify additional parameters to control the capacity of the scaling group in a more fine-grained manner.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: PRIORITY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIORITY</para>
        /// </summary>
        [NameInMap("MultiAZPolicy")]
        [Validation(Required=false)]
        public string MultiAZPolicy { get; set; }

        /// <summary>
        /// <para>The minimum number of pay-as-you-go instances required in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is less than this value, pay-as-you-go instances are preferentially created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("OnDemandBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// <para>The percentage of pay-as-you-go instances in the excess instances after the scaling group meets the minimum number of pay-as-you-go instances (OnDemandBaseCapacity). Valid values: 0 to 100.</para>
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
        /// <para>The region ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The filtering policy for the instance removal policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OldestInstance: removes the ECS instances that were added to the scaling group at the earliest point in time.</description></item>
        /// <item><description>NewestInstance: removes the ECS instances that were added to the scaling group at the latest point in time.</description></item>
        /// <item><description>OldestScalingConfiguration: removes the ECS instances that were created based on the earliest scaling configuration.</description></item>
        /// <item><description>CustomPolicy: removes ECS instances based on a custom scale-in policy function.</description></item>
        /// </list>
        /// <para>The scaling configuration mentioned in OldestScalingConfiguration refers to the instance configuration source in the scaling group, including scaling configurations and launch templates. CustomPolicy can only be set as the first removal policy. If you specify CustomPolicy, you must also specify the CustomPolicyARN parameter.</para>
        /// <remarks>
        /// <para>The removal of ECS instances from a scaling group is also affected by the multi-zone scaling policy (MultiAZPolicy) of the scaling group. For more information, see <a href="https://help.aliyun.com/document_detail/254822.html">Configure a combined policy for removing instances</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RemovalPolicies")]
        [Validation(Required=false)]
        public List<string> RemovalPolicies { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the newly created scaling group belongs.</para>
        /// <remarks>
        /// <para>Assigns the newly created scaling group to the specified resource group. If you do not specify this parameter, the scaling group belongs to the default resource group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-123******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The name of the scaling group. The name must be unique within a region.</para>
        /// <para>It must be 2 to 64 characters in length. It must start with a digit, a letter, or a Chinese character, and can contain digits, underscores (_), hyphens (-), and periods (.).</para>
        /// <para>Default value: the value of ScalingGroupId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scalinggroup****</para>
        /// </summary>
        [NameInMap("ScalingGroupName")]
        [Validation(Required=false)]
        public string ScalingGroupName { get; set; }

        /// <summary>
        /// <para>The reclaim mode of the scaling group. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>recycle: sets the reclaim mode of the scaling group to shutdown and reclaim mode.  </description></item>
        /// <item><description>release: sets the reclaim mode of the scaling group to release mode.</description></item>
        /// <item><description>forcerelease: sets the reclaim mode of the scaling group to force release mode.<remarks>
        /// <para>If you select forcerelease, the system forcibly releases instances in the <c>Running</c> state during scale-down activities. Forcibly releasing an instance is equivalent to a power-off operation, which erases temporary data in the memory and storage of the instance. The data cannot be recovered. Proceed with caution.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>forcerecycle: sets the reclaim mode of the scaling group to force shutdown and reclaim mode.<remarks>
        /// <para>If you select forcerecycle, the system forcibly shuts down instances in the <c>Running</c> state during scale-down activities. Forcibly shutting down an instance is equivalent to a power-off operation, which erases temporary data in the memory and storage of the instance. The data cannot be recovered. Proceed with caution.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>The ScalingPolicy parameter specifies the reclaim mode of the scaling group, but the specific action taken when an instance is removed from the scaling group is determined by the RemovePolicy parameter of RemoveInstances. For more information, see <a href="https://help.aliyun.com/document_detail/25955.html">RemoveInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recycle</para>
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public string ScalingPolicy { get; set; }

        /// <summary>
        /// <para>The collection of information about the server groups.</para>
        /// <remarks>
        /// <para>You cannot configure the same server group settings in both AlbServerGroups and ServerGroups at the same time.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ServerGroups")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestServerGroups> ServerGroups { get; set; }
        public class CreateScalingGroupRequestServerGroups : TeaModel {
            /// <summary>
            /// <para>The port number used by the instance after Auto Scaling adds the instance to the server group. Valid values: 1 to 65535.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The ID of the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgp-5yc3bd9lfyh*****</para>
            /// </summary>
            [NameInMap("ServerGroupId")]
            [Validation(Required=false)]
            public string ServerGroupId { get; set; }

            /// <summary>
            /// <para>The type of the server group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALB: Application Load Balancer (ALB).</description></item>
            /// <item><description>NLB: Network Load Balancer (NLB).</description></item>
            /// <item><description>GWLB: Gateway Load Balancer (GWLB).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The weight of the instance as a backend server after Auto Scaling adds the instance to the server group. Valid values: 0 to 100.</para>
            /// <para>A higher weight specifies that more access requests are allocated to the instance. If the weight is 0, the instance does not receive access requests.</para>
            /// <remarks>
            /// <para>This parameter is required for ALB and NLB. You cannot configure this parameter for GWLB.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The spot capacity distribution policy. You can use this parameter to separately specify the distribution policy for spot capacity. This parameter takes effect only when the MultiAZPolicy parameter is set to COMPOSABLE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>priority: Creates instances based on the order of the configured instance types.</description></item>
        /// <item><description>lowestPrice: Creates instances based on the unit price per vCPU of the instance types in ascending order.</description></item>
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
        /// <para>The number of available instance types. The scaling group evenly creates spot instances across multiple instance types with the lowest cost. Valid values: 1 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SpotInstancePools")]
        [Validation(Required=false)]
        public int? SpotInstancePools { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Auto Scaling policy to supplement spot instances. After this feature is enabled, when a system message indicating that a spot instance is to be reclaimed is received, the scaling group attempts to create a new instance to replace the spot instance to be reclaimed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        /// <summary>
        /// <para>The timeout period for waiting for an ECS instance to be stopped during the scale-in process. Unit: seconds.
        /// Valid values: 30 to 240.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only in the scale-in process when ScalingPolicy is set to release.  </description></item>
        /// <item><description>If this parameter is specified, the system waits for a maximum of the StopInstanceTimeout period for the instance to be stopped. After the timeout period elapses, the scale-in process continues regardless of whether the instance is stopped.  </description></item>
        /// <item><description>If this parameter is not specified, the system waits for a long time for the instance to be stopped. The scale-in process continues only after the instance is stopped. If the instance fails to be stopped, the scale-in process is rolled back and the scale-in fails.</description></item>
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
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SyncAlarmRuleToCms")]
        [Validation(Required=false)]
        public bool? SyncAlarmRuleToCms { get; set; }

        /// <summary>
        /// <para>The collection of tag information for the scaling group.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestTags> Tags { get; set; }
        public class CreateScalingGroupRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Department</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Specifies whether the tag is a propagatable tag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: tags on the scaling group are propagated only to newly created instances, not to existing instances in the scaling group.</description></item>
            /// <item><description>false: tags on the scaling group are not propagated to instances.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Propagate")]
            [Validation(Required=false)]
            public bool? Propagate { get; set; }

            /// <summary>
            /// <para>The tag value of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finance</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The collection of information about the virtual server groups associated with the scaling group.</para>
        /// </summary>
        [NameInMap("VServerGroups")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestVServerGroups> VServerGroups { get; set; }
        public class CreateScalingGroupRequestVServerGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the Classic Load Balancer (CLB) instance to which the virtual server group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp1u7etiogg38yvwz****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The attributes of the backend server group.</para>
            /// </summary>
            [NameInMap("VServerGroupAttributes")]
            [Validation(Required=false)]
            public List<CreateScalingGroupRequestVServerGroupsVServerGroupAttributes> VServerGroupAttributes { get; set; }
            public class CreateScalingGroupRequestVServerGroupsVServerGroupAttributes : TeaModel {
                /// <summary>
                /// <para>The port number used by the instance after Auto Scaling adds the instance to the virtual server group. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The ID of the virtual server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rsp-bp1443g77****</para>
                /// </summary>
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

                /// <summary>
                /// <para>The weight of the instance as a backend server after Auto Scaling adds the instance to the virtual server group. A higher weight indicates that more access requests are allocated to the instance. If the weight is 0, the instance does not receive access requests. Valid values: 0 to 100.</para>
                /// <para>Default value: 50.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the vSwitch. After this parameter is specified, the network type of the scaling group is VPC.</para>
        /// <remarks>
        /// <para>If neither VSwitchId nor VSwitchIds is specified for the scaling group, the network type of the scaling group is classic network by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp14zolna43z266bq****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The IDs of one or more vSwitches. If you use the VSwitchIds parameter, the VSwitchId parameter is ignored. After this parameter is specified, the network type of the scaling group is VPC.</para>
        /// <para>When you specify multiple vSwitches:</para>
        /// <list type="bullet">
        /// <item><description><para>The vSwitches must belong to the same VPC.</para>
        /// </description></item>
        /// <item><description><para>The vSwitches can belong to different zones.</para>
        /// </description></item>
        /// <item><description><para>The vSwitches are prioritized in ascending order of numbers. 1 indicates the highest priority. If instances cannot be created in the zone of a higher-priority vSwitch, the system automatically selects the next highest-priority vSwitch to create instances.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If neither VSwitchId nor VSwitchIds is specified for the scaling group, the network type of the scaling group is classic network by default.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>The behavior policy of the scaling group during zone shift.</para>
        /// </summary>
        [NameInMap("ZoneShiftPolicy")]
        [Validation(Required=false)]
        public CreateScalingGroupRequestZoneShiftPolicy ZoneShiftPolicy { get; set; }
        public class CreateScalingGroupRequestZoneShiftPolicy : TeaModel {
            /// <summary>
            /// <para>The health check behavior in impaired zones. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>ReplaceUnhealthy: Replaces unhealthy instances in all zones normally. </description></item>
            /// <item><description>IgnoreUnhealthy: Does not replace unhealthy instances in impaired zones. Healthy zones are not affected.</description></item>
            /// </list>
            /// <para>Default value: ReplaceUnhealthy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ReplaceUnhealthy</para>
            /// </summary>
            [NameInMap("ImpairedZoneHealthCheckBehavior")]
            [Validation(Required=false)]
            public string ImpairedZoneHealthCheckBehavior { get; set; }

            /// <summary>
            /// <para>Blocks scale-in triggered by specified types of scaling rules. The blocking scope applies to all zones under the scaling group, not just the impaired zones. This prevents false scale-in caused by fake improvements in monitoring metrics due to unreachable instances in impaired zones. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>StepScalingRule: Blocks scale-in triggered by step scaling rules. </description></item>
            /// <item><description>TargetTrackingScalingRule: Blocks scale-in triggered by target tracking scaling rules. </description></item>
            /// <item><description>None: Does not block.</description></item>
            /// </list>
            /// <para>Default value: None.</para>
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
            /// <item><description>true: Scale-out creates instances only in healthy zones and skips impaired zones. </description></item>
            /// <item><description>false: Scale-out is not restricted by zone and can create instances in any zone of the scaling group.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
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
