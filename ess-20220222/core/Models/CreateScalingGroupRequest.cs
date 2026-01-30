// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateScalingGroupRequest : TeaModel {
        /// <summary>
        /// <para>The Application Load Balancer (ALB) server groups.</para>
        /// </summary>
        [NameInMap("AlbServerGroups")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestAlbServerGroups> AlbServerGroups { get; set; }
        public class CreateScalingGroupRequestAlbServerGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the ALB server group.</para>
            /// <para>You can attach only a limited number of ALB server groups to a scaling group. To view the predefined quota limit or manually request a quota increase, go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgp-ddwb0y0g6y9bjm****</para>
            /// </summary>
            [NameInMap("AlbServerGroupId")]
            [Validation(Required=false)]
            public string AlbServerGroupId { get; set; }

            /// <summary>
            /// <para>The port number used by each ECS instance as a backend server in the ALB server group. Valid values: 1 to 65535.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The weight of an ECS instance as a backend server in the ALB server group. If you increase the weight for an ECS instance, the number of requests that are forwarded to the ECS instance also increases. If you set the weight for an ECS instance to 0, no requests are forwarded to the ECS instance. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The allocation policy of instances. Auto Scaling selects instance types based on the allocation policy to create the required number of instances. The policy can be applied to pay-as-you-go instances and preemptible instances. This parameter takes effect only when you set the <c>MultiAZPolicy</c> parameter to <c>COMPOSABLE</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>priority: Auto Scaling selects instance types based on the specified order of the instance types to create the required number of instances.</description></item>
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
        /// <para>Whether to enable automatic rebalancing for the scaling group. This takes effect only when BalancedOnly is enabled for the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Auto rebalancing is disabled for the scaling group.</description></item>
        /// <item><description>true: If Auto rebalancing is enabled, the scaling group automatically detects the capacity of the zone. If the capacity of the zone is unbalanced, the scaling group actively scales out the zone and re-balances the capacity of the zone.</description></item>
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
        /// <para>Specifies whether to evenly distribute instances in the scaling group across multiple zones. This parameter takes effect only if you set <c>MultiAZPolicy</c> to <c>COMPOSABLE</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set <c>MultiAZPolicy</c> to <c>COMPOSABLE</c> and enable <c>AzBalance</c> to <c>true</c>, this setting has an equivalent effect to setting <c>MultiAZPolicy</c> to <c>BALANCE</c>.</para>
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
        /// <para>The zone balancing mode. This mode takes effect only when the zone balancing mode is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BalancedBestEffort: If a resource fails to be created in a zone, it is downgraded to another zone to ensure best-effort delivery of the resource.</description></item>
        /// <item><description>BalancedOnly: If a resource fails to be created in a zone, it is not downgraded to another zone. The scale-out activity is partially successful to avoid excessive imbalance of resources in different zones.</description></item>
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
            /// <para>Specifies whether to automatically create pay-as-you-go ECS instances to reach the required number of ECS instances when preemptible ECS instances cannot be created due to high prices or insufficient inventory of resources. This parameter takes effect when you set <c>MultiAZPolicy</c> to <c>COST_OPTIMIZED</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
            /// <para>The minimum number of pay-as-you-go instances required in the scaling group. When the number of pay-as-you-go instances drops below the value of this parameter, Auto Scaling preferentially creates pay-as-you-go instances. Valid values: 0 to 1000.</para>
            /// <para>If you set <c>MultiAZPolicy</c> to <c>COMPOSABLE</c>, the default value is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("OnDemandBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of pay-as-you-go instances in the excess instances when the minimum number of pay-as-you-go instances is reached. <c>OnDemandBaseCapacity</c> specifies the minimum number of pay-as-you-go instances that must be contained in the scaling group. Valid values: 0 to 100.</para>
            /// <para>If you set <c>MultiAZPolicy</c> to <c>COMPOSABLE</c>, the default value is 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("OnDemandPercentageAboveBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The cost comparison method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PricePerUnit: Prices are compared based on the price per instance capacity.</para>
            /// <para>Capacity is determined by the weights assigned to instance types in the scaling group. If no weight is specified, a default weight of 1 is used, meaning each instance is assigned a capacity of 1.</para>
            /// </description></item>
            /// <item><description><para>PricePerVCpu: Prices are compared based on the price per vCPU.</para>
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
            /// <para>Specifies whether to replace pay-as-you-go instances with preemptible instances. If you specify <c>CompensateWithOnDemand</c>, it may result in a higher percentage of pay-as-you-go instances compared to the value of <c>OnDemandPercentageAboveBaseCapacity</c>. In this scenario, Auto Scaling will try to deploy preemptible instances to replace the surplus pay-as-you-go instances. When <c>CompensateWithOnDemand</c> is specified, Auto Scaling creates pay-as-you-go instances if there are not enough preemptible instance types. To avoid keeping these pay-as-you-go ECS instances for long periods, Auto Scaling tries to replace them with preemptible instances as soon as enough of preemptible instance types become available. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create pay-as-you-go instances to meet the requirement on the number of ECS instances when the expected capacity of preemptible instances cannot be provided due to reasons such as cost-related issues and insufficient resources. This parameter is available only if you set the MultiAZPolicy parameter to COST_OPTIMIZED. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
        /// <para>The ID of the elastic container instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eci-uf6fonnghi50u374****</para>
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the custom scale-in policy (Function). This parameter is available only if you specify CustomPolicy as the first step to remove instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-zhangjiakou:16145688****:services/ess_custom_terminate_policy.LATEST/functions/ess_custom_terminate_policy_name</para>
        /// </summary>
        [NameInMap("CustomPolicyARN")]
        [Validation(Required=false)]
        public string CustomPolicyARN { get; set; }

        /// <summary>
        /// <para>The IDs of the ApsaraDB RDS instances that you want to associate with the scaling group. The value can be a JSON array that contains multiple ApsaraDB RDS instance IDs. Separate multiple IDs with commas (,).</para>
        /// <para>You can associate only a limited number of ApsaraDB RDS instances with a scaling group. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to check the maximum number of ApsaraDB RDS instances that you can associate with a scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;rm-bp142f86de0t7****&quot;, &quot;rm-bp18l1z42ar4o****&quot;, &quot;rm-bp1lqr97h4aqk****&quot;]</para>
        /// </summary>
        [NameInMap("DBInstanceIds")]
        [Validation(Required=false)]
        public string DBInstanceIds { get; set; }

        /// <summary>
        /// <para>The databases that you want to attach to the scaling group.</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestDBInstances> DBInstances { get; set; }
        public class CreateScalingGroupRequestDBInstances : TeaModel {
            /// <summary>
            /// <para>The mode in which you want to attach the database to the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SecurityIp: the mode in which Auto Scaling automatically adds the private IP addresses of ECS instances to the IP address whitelist of the database during scale-out events. You can set the value to SecurityIp only if you set Type to RDS.</description></item>
            /// <item><description>SecurityGroup: the mode in which Auto Scaling adds the security group of the applied scaling configuration to the security group whitelist of the database. This setting allows ECS instances created from the scaling configuration to access the database.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SecurityIp</para>
            /// </summary>
            [NameInMap("AttachMode")]
            [Validation(Required=false)]
            public string AttachMode { get; set; }

            /// <summary>
            /// <para>The database ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-m5eqju85s45mu0***</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The database type. Valid values:</para>
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
        /// <para>The cooldown period of the scaling group after a scaling activity is complete in the scaling group. Valid values: 0 to 86400. Unit: seconds.</para>
        /// <para>During the cooldown period, Auto Scaling does not execute scaling activities that are triggered by CloudMonitor event-triggered tasks.</para>
        /// <para>Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DefaultCooldown")]
        [Validation(Required=false)]
        public int? DefaultCooldown { get; set; }

        /// <summary>
        /// <para>The expected number of ECS instances in the scaling group. Auto Scaling automatically maintains the specified expected number of ECS instances. The DesiredCapacity value cannot be greater than the MaxSize value or less than the MinSize value.</para>
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
        /// <item><description>true: enables deletion protection for the scaling group. This way, the scaling group cannot be deleted.</description></item>
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
        /// <para>The type of the instances that are managed by the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ECS: ECS instances.</description></item>
        /// <item><description>ECI: elastic container instances.</description></item>
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
        /// <para>The health check mode of the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NONE: Auto Scaling does not check the health status of instances.</description></item>
        /// <item><description>ECS: Auto Scaling checks the health status of instances in the scaling group. If you want to enable instance health check, you can set the value to ECS, regardless of whether the scaling group is of ECS type or Elastic Container Instance type.</description></item>
        /// <item><description>LOAD_BALANCER: Auto Scaling checks the health status of instances in the scaling group based on the health check results of load balancers. The health check results of Classic Load Balancer (CLB) instances are not supported as the health check basis for instances in the scaling group.</description></item>
        /// </list>
        /// <para>Default value: ECS.</para>
        /// <remarks>
        /// <para> If you want to enable instance health check and load balancer health check at the same time, we recommend that you specify <c>HealthCheckTypes</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// <para>The health check mode of the scaling group.</para>
        /// <remarks>
        /// <para> You can specify multiple values for this parameter to enable multiple health check options at the same time. If you specify <c>HealthCheckType</c>, this parameter is ignored.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("HealthCheckTypes")]
        [Validation(Required=false)]
        public List<string> HealthCheckTypes { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance. When you create a scaling group, you can specify an existing ECS instance. Auto Scaling obtains the configurations of the ECS instance and automatically creates a scaling configuration from the obtained configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-28wt4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the launch template that provides instance configurations for Auto Scaling to create instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-m5e3ofjr1zn1aw7****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>Details of the instance types that you specify by using the Extended Configurations feature of the launch template.</para>
        /// </summary>
        [NameInMap("LaunchTemplateOverrides")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
        public class CreateScalingGroupRequestLaunchTemplateOverrides : TeaModel {
            /// <summary>
            /// <para>The instance type that you want to use to override the instance type that is specified in the launch template.</para>
            /// <para>If you want to scale instances based on the weighted capacities of the instances, you must specify both the InstanceType and WeightedCapacity parameters.</para>
            /// <remarks>
            /// <para>This parameter is available only if you specify the LaunchTemplateId parameter.</para>
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
            /// <para>The maximum bid price of the instance type that is specified by the <c>InstanceType</c> parameter. You can specify 1 to 10 instance types by using the Extended Configurations feature of the launch template.</para>
            /// <remarks>
            /// <para>This parameter is available only if you specify the <c>LaunchTemplateId</c> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0.025</para>
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

            /// <summary>
            /// <para>The weight of the instance type. The weight specifies the capacity of an instance of the specified instance type in the scaling group. If you want to scale instances based on the weighted capacities of the instances, you must specify the WeightedCapacity parameter after you specify the InstanceType parameter.</para>
            /// <para>A higher weight specifies that a smaller number of instances of the specified instance type are required to meet the expected capacity requirement.</para>
            /// <para>Performance metrics, such as the number of vCPUs and the memory size of each instance type, may vary. You can specify different weights for different instance types based on your business requirements.</para>
            /// <para>Example:</para>
            /// <list type="bullet">
            /// <item><description>Current capacity: 0</description></item>
            /// <item><description>Expected capacity: 6</description></item>
            /// <item><description>Capacity of ecs.c5.xlarge: 4</description></item>
            /// </list>
            /// <para>To meet the expected capacity requirement, Auto Scaling must create and add two ecs.c5.xlarge instances.</para>
            /// <remarks>
            /// <para>The capacity of the scaling group cannot exceed the sum of the maximum number of instances that is specified by the MaxSize parameter and the maximum weight of the instance types.</para>
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
        /// <item><description>Default: the default template version.</description></item>
        /// <item><description>Latest: the latest template version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The lifecycle hooks.</para>
        /// </summary>
        [NameInMap("LifecycleHooks")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestLifecycleHooks> LifecycleHooks { get; set; }
        public class CreateScalingGroupRequestLifecycleHooks : TeaModel {
            /// <summary>
            /// <para>The action that Auto Scaling performs when the lifecycle hook times out. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CONTINUE: Auto Scaling continues to respond to the scaling request.</description></item>
            /// <item><description>ABANDON: Auto Scaling releases ECS instances that are created during scale-out events, or removes ECS instances from the scaling group during scale-in events.</description></item>
            /// </list>
            /// <para>If multiple lifecycle hooks in the scaling group are triggered during scale-in events, and you set DefaultResult to ABANDON for one of the lifecycle hooks, Auto Scaling immediately performs the action after the lifecycle hook whose DefaultResult is set to ABANDON times out. In this case, other lifecycle hooks time out ahead of schedule. In other cases, Auto Scaling performs the action only after all lifecycle hooks time out. The action that Auto Scaling performs is determined by the value of DefaultResult that you specify for the lifecycle hook that most recently times out.</para>
            /// <para>Default value: CONTINUE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONTINUE</para>
            /// </summary>
            [NameInMap("DefaultResult")]
            [Validation(Required=false)]
            public string DefaultResult { get; set; }

            /// <summary>
            /// <para>The period of time before the lifecycle hook times out. When the lifecycle hook times out, Auto Scaling performs the action that is specified by DefaultResult. Valid values: 30 to 21600. Unit: seconds.</para>
            /// <para>After you create a lifecycle hook, you can call the RecordLifecycleActionHeartbeat operation to extend the timeout period of the lifecycle hook. You can also call the CompleteLifecycleAction operation to end the timeout period of the lifecycle hook ahead of schedule.</para>
            /// <para>Default value: 600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("HeartbeatTimeout")]
            [Validation(Required=false)]
            public int? HeartbeatTimeout { get; set; }

            /// <summary>
            /// <para>The name of the lifecycle hook. After you specify this parameter, you cannot change the name of the lifecycle hook. If you do not specify this parameter, the name of the lifecycle hook is the same as the ID of the lifecycle hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lifecyclehook****</para>
            /// </summary>
            [NameInMap("LifecycleHookName")]
            [Validation(Required=false)]
            public string LifecycleHookName { get; set; }

            /// <summary>
            /// <para>The type of the scaling activity to which you want to apply the lifecycle hook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SCALE_OUT</description></item>
            /// <item><description>SCALE_IN</description></item>
            /// </list>
            /// <remarks>
            /// <para> If you specify lifecycle hooks for the scaling group, you must specify LifecycleTransition. Other parameters are optional.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SCALE_OUT</para>
            /// </summary>
            [NameInMap("LifecycleTransition")]
            [Validation(Required=false)]
            public string LifecycleTransition { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the notification recipient party. You can specify a Simple Message Queue (SMQ, formerly MNS) topic or queue as the recipient party. The value is in the acs:ess:{region}:{account-id}:{resource-relative-id} format.</para>
            /// <list type="bullet">
            /// <item><description>region: the region ID of the scaling group</description></item>
            /// <item><description>account-id: the ID of your Alibaba Cloud account.</description></item>
            /// </list>
            /// <para>Examples:</para>
            /// <list type="bullet">
            /// <item><description>SMQ queue: acs:ess:{region}:{account-id}:queue/{queuename}</description></item>
            /// <item><description>SMQ topic: acs:ess:{region}:{account-id}:topic/{topicname}</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ess:cn-hangzhou:1111111111:queue/queue2</para>
            /// </summary>
            [NameInMap("NotificationArn")]
            [Validation(Required=false)]
            public string NotificationArn { get; set; }

            /// <summary>
            /// <para>The fixed string that you want to include in notifications. When a lifecycle hook takes effect, Auto Scaling sends a notification. The fixed string can contain up to 4,096 characters in length. When Auto Scaling sends a notification to the recipient party, it includes predefined notification metadata into the notification. This helps in managing and labeling notifications of different categories. NotificationMetadata takes effect only if you specify NotificationArn.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("NotificationMetadata")]
            [Validation(Required=false)]
            public string NotificationMetadata { get; set; }

        }

        /// <summary>
        /// <para>The load balancer configurations.</para>
        /// </summary>
        [NameInMap("LoadBalancerConfigs")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestLoadBalancerConfigs> LoadBalancerConfigs { get; set; }
        public class CreateScalingGroupRequestLoadBalancerConfigs : TeaModel {
            /// <summary>
            /// <para>The ID of the CLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-2zen1olhfg9yw3f4qgte4</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The weight of each ECS instance as a backend server in the CLB backend server group. If you increase the weight for an ECS instance, the number of requests that are forwarded to the ECS instance also increases. If you set the weight for an ECS instance to 0, no requests are forwarded to the ECS instance. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The IDs of the CLB instances that you want to associate with the scaling group. The value can be a JSON array that contains multiple CLB instance IDs. Separate multiple IDs with commas (,).</para>
        /// <para>You can associate only a limited number of CLB instances with a scaling group. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to check the maximum number of CLB instances that you can associate with a scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;lb-bp1u7etiogg38yvwz****&quot;, &quot;lb-bp168cqrux9ai9l7f****&quot;, &quot;lb-bp1jv3m9zvj22ufxp****&quot;]</para>
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public string LoadBalancerIds { get; set; }

        /// <summary>
        /// <para>The maximum life span of an instance in the scaling group. Unit: seconds.</para>
        /// <para>Valid values: 86400 to the value of the Integer.maxValue parameter.</para>
        /// <para>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("MaxInstanceLifetime")]
        [Validation(Required=false)]
        public int? MaxInstanceLifetime { get; set; }

        /// <summary>
        /// <para>The maximum number of instances that can be contained in the scaling group. When the total number of ECS instances in the scaling group exceeds the value of MaxSize, Auto Scaling automatically removes ECS instances from the scaling group until the total number equals the maximum number.</para>
        /// <para>The value range of MaxSize is directly correlated with the degree of dependency your business has on Auto Scaling. You can go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to check <b>the maximum number of instances that a single scaling group can contain.</b></para>
        /// <para>If <b>a single scaling group can contain up to 2,000 ECS instances</b>, the value range of MaxSize is 0 to 2,000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public int? MaxSize { get; set; }

        /// <summary>
        /// <para>The minimum number of instances that must be contained in the scaling group. When the total number of ECS instances in the scaling group is less than the value of MinSize, Auto Scaling automatically creates ECS instances in the scaling group until the total number reaches the minimum number.</para>
        /// <remarks>
        /// <para> The value of MinSize must be less than or equal to the value of MaxSize.</para>
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
        /// <para>The scaling policy for ECS instances in the multi-zone scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PRIORITY: scale ECS instances based on the priority of the vSwitches specified by VSwitchIds. Auto Scaling preferentially scales instances in the zone where the vSwitch of the highest priority resides. If the scaling fails, Auto Scaling scales instances in the zone where the vSwitch of the next highest priority resides.</para>
        /// </description></item>
        /// <item><description><para>COST_OPTIMIZED: create ECS instances that have the lowest unit price of vCPUs during scale-out events and removes ECS instances that have the highest unit price of vCPUs during scale-in events. If you specify preemptible instance types in your scaling configuration, Auto Scaling will preferentially create preemptible instances. You can also specify CompensateWithOnDemand to allow Auto Scaling to create pay-as-you-go instances in the case that preemptible instances cannot be created due to limited stock.</para>
        /// <para>**</para>
        /// <para><b>Note</b> The COST_OPTIMIZED setting takes effect only when your scaling configuration contains multiple instance types or specifically contains preemptible instance types.</para>
        /// </description></item>
        /// <item><description><para>BALANCE: evenly distribute ECS instances across the zones that are specified for the scaling group. If ECS instances are unevenly distributed across the specified zones due to insufficient inventory, you can call the <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstance</a> operation to evenly distribute the instances across the zones.</para>
        /// <para>**</para>
        /// <para><b>Note</b> When you set <c>MultiAZPolicy</c> to <c>BALANCE</c>, this setting has an equivalent effect to setting <c>MultiAZPolicy</c> to <c>COMPOSABLE</c> and enabling <c>AzBalance</c> to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>COMPOSABLE: combine the preceding policies into a custom scaling policy based on your business requirements. Alternatively, you can specify custom parameters to finely control the capacity of the scaling group.</para>
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
        /// <para>The minimum number of pay-as-you-go instances that must be contained in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is less than the value of this parameter, Auto Scaling preferentially creates pay-as-you-go instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("OnDemandBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// <para>The percentage of pay-as-you-go instances in the excess instances when the minimum number of pay-as-you-go instances reaches the requirement. Valid values: 0 to 100.</para>
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
        /// <para>The instance removal policies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OldestInstance: removes ECS instances that are added at the earliest point in time to the scaling group.</description></item>
        /// <item><description>NewestInstance: removes ECS instances that are most recently added to the scaling group.</description></item>
        /// <item><description>OldestScalingConfiguration: removes ECS instances that are created based on the earliest scaling configuration.</description></item>
        /// <item><description>CustomPolicy: removes ECS instances based on the custom scale-in policy (Function).</description></item>
        /// </list>
        /// <para>The scaling configuration source specified by the OldestScalingConfiguration setting can be a scaling configuration or a launch template. The CustomPolicy setting takes effect only if you specify it as the first step to remove instances. If you specify CustomPolicy, you must also specify the CustomPolicyARN parameter.</para>
        /// <remarks>
        /// <para>The removal of ECS instances from a scaling group is also affected by the value of the MultiAZPolicy parameter. For more information, see the <a href="https://help.aliyun.com/document_detail/254822.html">Configure a combination policy for removing instances</a> topic.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RemovalPolicies")]
        [Validation(Required=false)]
        public List<string> RemovalPolicies { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which you want to add the scaling group.</para>
        /// <remarks>
        /// <para>If you specify this parameter, new scaling groups are added to the specified resource group. If you do not specify this parameter, new scaling groups are added to the default resource group.</para>
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
        /// <para>The name of the scaling group. The name of each scaling group must be unique in a region.</para>
        /// <para>The name must be 2 to 64 characters in length, and can contain letters, digits, underscores (_), hyphens (-), and periods (.). The name must start with a letter or a digit.</para>
        /// <para>If you do not specify this parameter, the value of the ScalingGroupId parameter is used.</para>
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
        /// <item><description><para>recycle: the economical mode</para>
        /// </description></item>
        /// <item><description><para>release: the release mode</para>
        /// </description></item>
        /// <item><description><para>forcerelease: the forced release mode</para>
        /// <para>**</para>
        /// <para><b>Note</b> If you set the value to forcerelease, Auto Scaling will forcibly release the ECS instances that are in the <c>Running</c> state during the scale-out events. Forced release equates to an immediate power-off, resulting in the irreversible deletion of all ephemeral data stored on the instance. Once executed, this action cannot be undone and the lost data cannot be recovered. Exercise caution when you select this option.</para>
        /// </description></item>
        /// <item><description><para>forcerecycle: the forced recycle mode</para>
        /// <para>**</para>
        /// <para><b>Note</b> If you set the value to forcerecycle, Auto Scaling will forcibly shut down the ECS instances that are in the <c>Running</c> state during the scale-out events. Forced recycle equates to an immediate power-off, resulting in the irreversible deletion of all ephemeral data stored on the instance. Once executed, this action cannot be undone and the lost data cannot be recovered. Exercise caution when you select this option.</para>
        /// </description></item>
        /// </list>
        /// <para>ScalingPolicy specifies the reclaim mode of the scaling group. RemovePolicy of the RemoveInstances operation specifies the specific instance removal action. For more information, see <a href="https://help.aliyun.com/document_detail/25955.html">RemoveInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recycle</para>
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public string ScalingPolicy { get; set; }

        /// <summary>
        /// <para>The information about the server groups.</para>
        /// <remarks>
        /// <para>You cannot use AlbServerGroups and ServerGroups to specify the same server group.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ServerGroups")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestServerGroups> ServerGroups { get; set; }
        public class CreateScalingGroupRequestServerGroups : TeaModel {
            /// <summary>
            /// <para>The port number used by each ECS instance as backend server in the vServer group. Valid values: 1 to 65535.</para>
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
            /// <para>The type of server group N. Valid Values:</para>
            /// <list type="bullet">
            /// <item><description>ALB</description></item>
            /// <item><description>NLB</description></item>
            /// <item><description>GWLB</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The weight of each ECS instance as a backend server in the server group. Valid values: 0 to 100.</para>
            /// <para>The higher the weight, the more access requests the instance will be assigned. If the weight is 0, the instance will not receive any access requests.</para>
            /// <remarks>
            /// <para>For ALB and NLB types, this parameter is required. GWLB type cannot be set.</para>
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
        /// <para>The allocation policy of preemptible instances. You can use this parameter to individually specify the allocation policy of preemptible instances. This parameter takes effect only if you set the <c>MultiAZPolicy</c> parameter to <c>COMPOSABLE</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>priority: Auto Scaling selects instance types based on the specified order of the instance types to create the required number of preemptible instances.</description></item>
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
        /// <para>The number of available instance types. Auto Scaling evenly creates preemptible instances of multiple instance types that are provided at the lowest cost in the scaling group. Valid values: 1 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SpotInstancePools")]
        [Validation(Required=false)]
        public int? SpotInstancePools { get; set; }

        /// <summary>
        /// <para>Specifies whether to supplement preemptible instances. If you set this parameter to true, Auto Scaling creates an instance to replace a preemptible instance when Auto Scaling receives a system message which indicates that the preemptible instance is to be reclaimed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        /// <summary>
        /// <para>The period of time required by the ECS instance to enter the Stopped state. Unit: seconds. Valid values: 30 to 240.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only if you set ScalingPolicy to release.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the system will wait for the ECS instance to enter the Stopped state for the specified period of time before continuing with the scale-in operation, regardless of the status of the ECS instance.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the system will wait for the ECS instance to stop before continuing with the scale-in operation. If the ECS instance is not successfully stopped, the scale-in process will be rolled back and considered failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("StopInstanceTimeout")]
        [Validation(Required=false)]
        public int? StopInstanceTimeout { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is unavailable.</para>
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
            /// <para>Identifies whether the tag is a propagatable tag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: propagates the tag to only instances that are newly created.</description></item>
            /// <item><description>false: does not propagate the tag to any instances.</description></item>
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
        /// <para>The backend vServer group that you want to associate with the scaling group.</para>
        /// </summary>
        [NameInMap("VServerGroups")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestVServerGroups> VServerGroups { get; set; }
        public class CreateScalingGroupRequestVServerGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the CLB instance to which the backend vServer group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp1u7etiogg38yvwz****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The attributes of the backend vServer group.</para>
            /// </summary>
            [NameInMap("VServerGroupAttributes")]
            [Validation(Required=false)]
            public List<CreateScalingGroupRequestVServerGroupsVServerGroupAttributes> VServerGroupAttributes { get; set; }
            public class CreateScalingGroupRequestVServerGroupsVServerGroupAttributes : TeaModel {
                /// <summary>
                /// <para>The port number used by each ECS instance as a backend server in the vServer group. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The ID of the vServer group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rsp-bp1443g77****</para>
                /// </summary>
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

                /// <summary>
                /// <para>The weight of each ECS instance as a backend server in the vServer group. If you increase the weight for an ECS instance, the number of requests that are forwarded to the ECS instance also increases. If you set the weight for an ECS instance to 0, no requests are forwarded to the ECS instance. Valid values: 0 to 100.</para>
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
        /// <para>The ID of the vSwitch. If you specify the VSwitchId parameter, the network type of the scaling group is VPC.</para>
        /// <remarks>
        /// <para>If you do not specify the VSwitchId or VSwitchIds parameter, the network type of the scaling group is classic network.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp14zolna43z266bq****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The IDs of the vSwitches. If you specify VSwitchIds, VSwitchId is ignored. If you specify VSwitchIds, the network type of the scaling group is VPC.</para>
        /// <para>If you specify multiple vSwitches, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The vSwitches must belong to the same VPC.</description></item>
        /// <item><description>The vSwitches can belong to different zones.</description></item>
        /// <item><description>vSwitches are sorted in ascending order based on their priorities. The first vSwitch has the highest priority. If Auto Scaling fails to create ECS instances in the zone where the vSwitch of the highest priority resides, Auto Scaling attempts to create ECS instances in the zone where the vSwitch of the next highest priority resides.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify VSwitchId or VSwitchIds for your scaling group, the network type of the scaling group is classic network.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
