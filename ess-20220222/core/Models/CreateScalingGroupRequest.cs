// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateScalingGroupRequest : TeaModel {
        /// <summary>
        /// <para>The Application Load Balancer (ALB) server groups to associate with the scaling group.</para>
        /// </summary>
        [NameInMap("AlbServerGroups")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestAlbServerGroups> AlbServerGroups { get; set; }
        public class CreateScalingGroupRequestAlbServerGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the ALB server group.</para>
            /// <para>A scaling group can be associated with a limited number of ALB server groups. To view or request a quota increase, go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgp-ddwb0y0g6y9bjm****</para>
            /// </summary>
            [NameInMap("AlbServerGroupId")]
            [Validation(Required=false)]
            public string AlbServerGroupId { get; set; }

            /// <summary>
            /// <para>The port number used by an instance after it is added to the ALB server group. Valid values: 1 to 65535.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The weight of an instance as a backend server after the instance is added to the ALB server group. The higher the weight, the more access requests are distributed to the instance. If the weight is 0, no access requests are distributed to the instance. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The capacity allocation policy determines how the scaling group selects available instance types to meet capacity requirements. The policy applies to both on-demand and preemptible capacity (effective only when the <c>MultiAZPolicy</c> parameter is set to <c>COMPOSABLE</c>). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>priority: Creates instances in the order of the configured instance types.</para>
        /// </description></item>
        /// <item><description><para>lowestPrice: Create instances based on the price per vCPU of instance types, from lowest to highest.</para>
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
        /// <para>Specifies whether to enable automatic balancing for the scaling group. This setting takes effect only when BalancedOnly is enabled for a scaling group that is balanced across availability zones. Value range:</para>
        /// <list type="bullet">
        /// <item><description><para>false: Does not enable automatic balancing for the scaling group.</para>
        /// </description></item>
        /// <item><description><para>true: When automatic balancing for the scaling group is enabled, the scaling group automatically detects the capacity across availability zones. If the capacity is imbalanced, the scaling group proactively performs scaling across availability zones to rebalance the capacity.</para>
        /// </description></item>
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
        /// <para>Specifies whether to evenly distribute the capacity of the scaling group across multiple availability zones. This parameter is valid only when <c>MultiAZPolicy</c> is set to <c>COMPOSABLE</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The capacity of the scaling group is evenly distributed across multiple availability zones.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The capacity of the scaling group is not evenly distributed across multiple availability zones.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If <c>MultiAZPolicy</c> is set to <c>COMPOSABLE</c> and <c>AzBalance</c> is set to <c>true</c>, the effect is the same as setting <c>MultiAZPolicy</c> to <c>BALANCE</c>.</para>
        /// </remarks>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AzBalance")]
        [Validation(Required=false)]
        public bool? AzBalance { get; set; }

        /// <summary>
        /// <para>The zone balancing mode is effective only when enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>BalancedBestEffort: If a resource fails to be created in an availability zone, the system falls back to other availability zones to ensure best-effort delivery.</para>
        /// </description></item>
        /// <item><description><para>BalancedOnly:
        /// If resource creation fails in an availability zone, the system does not fall back to other availability zones. The scaling activity is partially successful, which prevents an excessive imbalance of resources across different availability zones.</para>
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
            /// <para>When <c>MultiAZPolicy</c> is set to <c>COST_OPTIMIZED</c>, this parameter specifies whether to automatically create on-demand instances to meet capacity requirements when spot instances are unavailable due to price or inventory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Yes.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: No.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CompensateWithOnDemand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// <para>The minimum number of on-demand instances required in the scaling group. When the number of on-demand instances in the scaling group is less than this value, the system preferentially creates on-demand instances. Valid values: 0 to 1,000.</para>
            /// <para>When <c>MultiAZPolicy</c> is set to <c>COMPOSABLE</c>, the default value is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("OnDemandBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of on-demand instances among the excess instances after the <c>OnDemandBaseCapacity</c> requirement is met. Valid values: 0 to 100.</para>
            /// <para>When <c>MultiAZPolicy</c> is set to <c>COMPOSABLE</c>, the default value is 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("OnDemandPercentageAboveBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The price comparison mode for the cost optimization strategy of the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PricePerUnit</c>: Compares prices based on per-unit capacity.</para>
            /// <para>The capacity of an instance in a scaling group is equal to the weight set for the instance type, with a default of 1, meaning one ECS instance equals one unit of capacity.</para>
            /// </description></item>
            /// <item><description><para><c>PricePerVCpu</c>: Compares prices based on per-vCPU price.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>PricePerUnit</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PricePerUnit</para>
            /// </summary>
            [NameInMap("PriceComparisonMode")]
            [Validation(Required=false)]
            public string PriceComparisonMode { get; set; }

            /// <summary>
            /// <para>After you enable <c>CompensateWithOnDemand</c>, if the on-demand percentage exceeds the <c>OnDemandPercentageAboveBaseCapacity</c> ratio, the system attempts to replace on-demand capacity with spot capacity. A common scenario is when <c>CompensateWithOnDemand</c> leads to on-demand instances being created due to spot inventory or price issues. To avoid the prolonged existence of these on-demand instances, the system attempts to replace the excess on-demand capacity with spot instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Allows replacement.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Does not allow replacement.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SpotAutoReplaceOnDemand")]
            [Validation(Required=false)]
            public bool? SpotAutoReplaceOnDemand { get; set; }

        }

        /// <summary>
        /// <para>A client-generated token to ensure the idempotence of the request.</para>
        /// <para>The token must be unique across requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is effective only when <c>MultiAZPolicy</c> is set to <c>COST_OPTIMIZED</c>. If <c>true</c>, Auto Scaling creates on-demand instances to meet capacity requirements when spot instances are unavailable due to price or inventory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Yes.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: No.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CompensateWithOnDemand")]
        [Validation(Required=false)]
        public bool? CompensateWithOnDemand { get; set; }

        /// <summary>
        /// <para>The ID of the ECI instance, also known as the container group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eci-uf6fonnghi50u374****</para>
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// <para>The ARN of the custom scale-in policy function. This parameter is valid only when the first removal policy in <c>RemovalPolicies</c> is <c>CustomPolicy</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-zhangjiakou:16145688****:services/ess_custom_terminate_policy.LATEST/functions/ess_custom_terminate_policy_name</para>
        /// </summary>
        [NameInMap("CustomPolicyARN")]
        [Validation(Required=false)]
        public string CustomPolicyARN { get; set; }

        /// <summary>
        /// <para>A JSON array of RDS instance IDs.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The number of RDS instances that you can associate with a single scaling group varies based on your Auto Scaling usage. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to view the quota for <b>Maximum number of RDS instances that can be associated with a single scaling group</b>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>The number of RDS instances that you can associate with a single scaling group varies based on your Auto Scaling usage. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to view the quota for <b>Maximum number of RDS instances that can be associated with a single scaling group</b>.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;</para>
        /// <para>The number of RDS instances that you can associate with a single scaling group varies based on your Auto Scaling usage. Go to Quota Center to view the quota for <b>Maximum number of RDS instances that can be associated with a single scaling group</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;rm-bp142f86de0t7****&quot;, &quot;rm-bp18l1z42ar4o****&quot;, &quot;rm-bp1lqr97h4aqk****&quot;]</para>
        /// </summary>
        [NameInMap("DBInstanceIds")]
        [Validation(Required=false)]
        public string DBInstanceIds { get; set; }

        /// <summary>
        /// <para>The databases that are associated with the scaling group.</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestDBInstances> DBInstances { get; set; }
        public class CreateScalingGroupRequestDBInstances : TeaModel {
            /// <summary>
            /// <para>The method that is used to associate the scaling group with the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>SecurityIp</c>: The IP address whitelist mode. This mode automatically adds the scaled-out instances to the IP address whitelist of the database. This mode is supported only by RDS databases.</para>
            /// </description></item>
            /// <item><description><para><c>SecurityGroup</c>: The security group mode. This mode adds the security group of the scaling configuration to the security group whitelist of the database. This allows instances in the security group to access the database.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SecurityIp</para>
            /// </summary>
            [NameInMap("AttachMode")]
            [Validation(Required=false)]
            public string AttachMode { get; set; }

            /// <summary>
            /// <para>The ID of the database instance.</para>
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
            /// <item><description><para>RDS</para>
            /// </description></item>
            /// <item><description><para>Redis</para>
            /// </description></item>
            /// <item><description><para>MongoDB</para>
            /// </description></item>
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
        /// <para>The cooldown period, in seconds, after a scaling activity completes. Valid values: 0 to 86400.</para>
        /// <para>During the cooldown period, the scaling group does not execute other scaling activities that are triggered by CloudMonitor alarm tasks.</para>
        /// <para>Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DefaultCooldown")]
        [Validation(Required=false)]
        public int? DefaultCooldown { get; set; }

        /// <summary>
        /// <para>The desired number of instances in the scaling group. Auto Scaling automatically maintains this number of instances. The value must be less than or equal to <c>MaxSize</c> and greater than or equal to <c>MinSize</c>.</para>
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
        /// <item><description><para><c>true</c>: Enables deletion protection. The scaling group cannot be deleted.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disables deletion protection.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
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
        /// <item><description><para><c>ECS</c>: The scaling group manages ECS instances.</para>
        /// </description></item>
        /// <item><description><para><c>ECI</c>: The scaling group manages ECI instances.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>ECS</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The health check method for the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NONE</c>: No health checks are performed.</para>
        /// </description></item>
        /// <item><description><para><c>ECS</c>: Health checks are performed on instances in the scaling group. This value enables health checks for scaling groups of both the ECS and ECI types.</para>
        /// </description></item>
        /// <item><description><para><c>LOAD_BALANCER</c>: The instance health status is based on health check results from the attached load balancer. This option does not support Classic Load Balancer (CLB) instances.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>ECS</c>.</para>
        /// <remarks>
        /// <para>To enable both instance health checks and load balancer health checks, use the <c>HealthCheckTypes</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// <para>The health check methods for the scaling group.</para>
        /// <remarks>
        /// <para>You can use this parameter to set multiple values and enable multiple health check options. If you set the <c>HealthCheckType</c> parameter, this parameter is ignored.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("HealthCheckTypes")]
        [Validation(Required=false)]
        public List<string> HealthCheckTypes { get; set; }

        /// <summary>
        /// <para>The ID of an existing instance to use as a template. Auto Scaling uses this instance to create a new scaling configuration for the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-28wt4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the launch template that provides the configuration for the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-m5e3ofjr1zn1aw7****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The instance type information for extending the launch template.</para>
        /// </summary>
        [NameInMap("LaunchTemplateOverrides")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
        public class CreateScalingGroupRequestLaunchTemplateOverrides : TeaModel {
            /// <summary>
            /// <para>To enable the scaling group to scale based on instance type capacity, you must specify both this parameter and <c>LaunchTemplateOverrides.WeightedCapacity</c>.</para>
            /// <para>This parameter specifies the instance type, which overrides the instance type specified in the launch template.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when the <c>LaunchTemplateId</c> parameter is specified.</para>
            /// </remarks>
            /// <para>Must be a valid ECS instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The maximum hourly price for the instance type specified in <c>LaunchTemplateOverride.InstanceType</c>.</para>
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
            /// <para>To enable the scaling group to scale based on instance type capacity, you must specify this parameter after you specify <c>LaunchTemplateOverrides.InstanceType</c>.</para>
            /// <para>This parameter specifies the weight of the instance type, which represents the capacity of a single instance of that type in the scaling group. A higher weight means that fewer instances of this type are needed to meet the desired capacity.</para>
            /// <para>Because instance types have different performance metrics, such as the number of vCPUs and memory size, you can assign different weights to different instance types based on your requirements.</para>
            /// <para>Example:</para>
            /// <list type="bullet">
            /// <item><description><para>Current capacity: 0.</para>
            /// </description></item>
            /// <item><description><para>Desired capacity: 6.</para>
            /// </description></item>
            /// <item><description><para>Capacity of ecs.c5.xlarge: 4.</para>
            /// </description></item>
            /// </list>
            /// <para>To meet the desired capacity, the scaling group will create two ecs.c5.xlarge instances.</para>
            /// <remarks>
            /// <para>During a scale-out activity, the capacity of the scaling group cannot exceed the sum of the maximum capacity (<c>MaxSize</c>) and the maximum weight of an instance type.</para>
            /// </remarks>
            /// <para>Valid values: 1 to 500.</para>
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
        /// <item><description><para>A specific version number of the template.</para>
        /// </description></item>
        /// <item><description><para><c>Default</c>: Uses the default version of the template.</para>
        /// </description></item>
        /// <item><description><para><c>Latest</c>: Uses the latest version of the template.</para>
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
        /// <para>The list of lifecycle hooks.</para>
        /// </summary>
        [NameInMap("LifecycleHooks")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestLifecycleHooks> LifecycleHooks { get; set; }
        public class CreateScalingGroupRequestLifecycleHooks : TeaModel {
            /// <summary>
            /// <para>The action to take after the wait state ends. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>CONTINUE</c>: Continues the scale-out or scale-in activity.</para>
            /// </description></item>
            /// <item><description><para><c>ABANDON</c>: Aborts the scale-out activity by releasing the created instances, or aborts the scale-in activity by keeping the instances in the scaling group.</para>
            /// </description></item>
            /// </list>
            /// <para>If a scale-in (SCALE_IN) activity triggers multiple lifecycle hooks, and the <c>DefaultResult</c> of one of the lifecycle hooks is <c>ABANDON</c>, the wait state of the other lifecycle hooks ends prematurely. In other cases, the action is determined by the last lifecycle hook to complete.</para>
            /// <para>Default value: <c>CONTINUE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONTINUE</para>
            /// </summary>
            [NameInMap("DefaultResult")]
            [Validation(Required=false)]
            public string DefaultResult { get; set; }

            /// <summary>
            /// <para>The wait time that is defined in the lifecycle hook for a scaling activity. After the wait time expires, the next action is performed. Valid values: 30 to 21600. Unit: seconds.</para>
            /// <para>After you create a lifecycle hook, you can call the <c>RecordLifecycleActionHeartbeat</c> operation to extend the wait time of an instance, or call the <c>CompleteLifecycleAction</c> operation to end the wait state of the scaling activity in advance.</para>
            /// <para>Default value: 600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("HeartbeatTimeout")]
            [Validation(Required=false)]
            public int? HeartbeatTimeout { get; set; }

            /// <summary>
            /// <para>The name of the lifecycle hook. The name cannot be modified after it is specified. If you do not specify a name, the ID of the lifecycle hook is used.</para>
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
            /// <item><description><para><c>SCALE_OUT</c>: A scale-out activity.</para>
            /// </description></item>
            /// <item><description><para><c>SCALE_IN</c>: A scale-in activity.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is required if you specify a lifecycle hook for the scaling group. Other related parameters are optional.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SCALE_OUT</para>
            /// </summary>
            [NameInMap("LifecycleTransition")]
            [Validation(Required=false)]
            public string LifecycleTransition { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the notification recipient for the lifecycle hook. Message Service (MNS) queues and topics are supported. The format is <c>acs:ess:{region}:{account-id}:{resource-relative-id}</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>region</c>: the region where the scaling group is located.</para>
            /// </description></item>
            /// <item><description><para><c>account-id</c>: the ID of your Alibaba Cloud account.</para>
            /// </description></item>
            /// </list>
            /// <para>Examples:</para>
            /// <list type="bullet">
            /// <item><description><para>MNS queue: <c>acs:ess:{region}:{account-id}:queue/{queuename}</c>.</para>
            /// </description></item>
            /// <item><description><para>MNS topic: <c>acs:ess:{region}:{account-id}:topic/{topicname}</c>.</para>
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
            /// <para>A fixed string of information for the wait state of a scaling activity. The value cannot exceed 4,096 characters in length. When Auto Scaling sends a message to the specified notification recipient, it includes the value of this parameter. This allows you to manage and categorize notifications. This parameter is valid only when you specify the <c>NotificationArn</c> parameter.</para>
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
            /// <para>lb-2zen1olhfg9yw3f4q****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The weight of an instance as a backend server after the instance is added to the SLB server group. The higher the weight, the more access requests are distributed to the instance. If the weight is 0, no access requests are distributed to the instance. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>A JSON array of Classic Load Balancer (CLB) instance IDs.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The number of CLB instances that you can associate with a single scaling group varies based on your Auto Scaling usage. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to view the quota for <b>Maximum number of load balancer instances that can be associated with a single scaling group</b>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>The number of CLB instances that you can associate with a single scaling group varies based on your Auto Scaling usage. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to view the quota for <b>Maximum number of load balancer instances that can be associated with a single scaling group</b>.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;</para>
        /// <para>The number of CLB instances that you can associate with a single scaling group varies based on your Auto Scaling usage. Go to Quota Center to view the quota for <b>Maximum number of load balancer instances that can be associated with a single scaling group</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;lb-bp1u7etiogg38yvwz****&quot;, &quot;lb-bp168cqrux9ai9l7f****&quot;, &quot;lb-bp1jv3m9zvj22ufxp****&quot;]</para>
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public string LoadBalancerIds { get; set; }

        /// <summary>
        /// <para>The maximum lifetime of an instance in the scaling group. Unit: seconds.</para>
        /// <para>Value range: [86400, Integer.maxValue].</para>
        /// <para>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("MaxInstanceLifetime")]
        [Validation(Required=false)]
        public int? MaxInstanceLifetime { get; set; }

        /// <summary>
        /// <para>The maximum number of instances in the scaling group. If the total number of instances exceeds this value, Auto Scaling removes instances to meet this maximum.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The value range of <c>MaxSize</c> depends on your Auto Scaling usage. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to view the quota for <b>Maximum number of instances per scaling group</b>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>The value range of <c>MaxSize</c> depends on your Auto Scaling usage. Go to <a href="https://quotas.console.aliyun.com/products/ess/quotas">Quota Center</a> to view the quota for <b>Maximum number of instances per scaling group</b>.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;</para>
        /// <para>The value range of <c>MaxSize</c> depends on your Auto Scaling usage. Go to Quota Center to view the quota for <b>Maximum number of instances per scaling group</b>.</para>
        /// <para>If the quota for <b>Maximum number of instances per scaling group</b> is 2,000, the value of <c>MaxSize</c> can range from 0 to 2,000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public int? MaxSize { get; set; }

        /// <summary>
        /// <para>The minimum number of instances in the scaling group. If the total number of instances falls below this value, Auto Scaling adds instances to meet this minimum.</para>
        /// <remarks>
        /// <para>The value of <c>MinSize</c> must be less than or equal to the value of <c>MaxSize</c>.</para>
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
        /// <para>The scaling policy for ECS instances in a multi-zone scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PRIORITY</c>: Auto Scaling prioritizes the vSwitches specified in <c>VSwitchIds</c>. If an operation fails in a higher-priority availability zone, Auto Scaling automatically attempts it in the next-highest-priority zone.</para>
        /// </description></item>
        /// <item><description><para><c>COST_OPTIMIZED</c>: During scale-out, creates instances from the instance types with the lowest vCPU unit price. During scale-in, removes instances from the instance types with the highest vCPU unit price. If the scaling configuration includes multiple spot instance types, spot instances are prioritized for creation. You can use the <c>CompensateWithOnDemand</c> parameter to specify whether to automatically create on-demand instances when spot instances cannot be created due to reasons such as insufficient inventory.</para>
        /// <remarks>
        /// <para>The <c>COST_OPTIMIZED</c> policy takes effect only when the scaling configuration specifies multiple instance types or includes spot instances.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><c>BALANCE</c>: Distributes ECS instances evenly across the specified availability zones in the scaling group. If the distribution of instances becomes uneven due to insufficient inventory, you can call the <a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstance</a> API operation to rebalance the instances.</para>
        /// <remarks>
        /// <para>If <c>MultiAZPolicy</c> is set to <c>BALANCE</c>, the effect is the same as setting <c>MultiAZPolicy</c> to <c>COMPOSABLE</c> and <c>AzBalance</c> to <c>true</c>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><c>COMPOSABLE</c>: A composite policy that allows you to combine the preceding policies for multi-zone scaling groups as needed. You can also specify additional parameters to gain finer control over the capacity of your scaling group.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>PRIORITY</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIORITY</para>
        /// </summary>
        [NameInMap("MultiAZPolicy")]
        [Validation(Required=false)]
        public string MultiAZPolicy { get; set; }

        /// <summary>
        /// <para>The minimum number of on-demand instances required in the scaling group. Valid values: 0 to 1,000. If the number of on-demand instances is less than this value, Auto Scaling preferentially creates on-demand instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("OnDemandBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// <para>The percentage of on-demand instances among the excess instances after the minimum number of on-demand instances (<c>OnDemandBaseCapacity</c>) is met. Valid values: 0 to 100.</para>
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
        /// <para>The ID of the region where the scaling group resides.</para>
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
        /// <item><description><para><c>OldestInstance</c>: Removes the ECS instance that was first added to the scaling group.</para>
        /// </description></item>
        /// <item><description><para><c>NewestInstance</c>: Removes the ECS instance that was most recently added to the scaling group.</para>
        /// </description></item>
        /// <item><description><para><c>OldestScalingConfiguration</c>: Removes the ECS instance that was created based on the earliest scaling configuration.</para>
        /// </description></item>
        /// <item><description><para><c>CustomPolicy</c>: Removes ECS instances based on a custom scale-in policy defined by a function.</para>
        /// </description></item>
        /// </list>
        /// <para>The term <c>scaling configuration</c> in <c>OldestScalingConfiguration</c> refers to the source of instance configuration information, which includes both scaling configurations and launch templates. <c>CustomPolicy</c> can only be set as the first removal policy. If you specify <c>CustomPolicy</c>, you must also specify the <c>CustomPolicyARN</c> parameter.</para>
        /// <remarks>
        /// <para>The removal of instances is also affected by the scaling group\&quot;s multi-AZ policy (<c>MultiAZPolicy</c>). For more information, see <a href="https://help.aliyun.com/document_detail/254822.html">Configure a combination of removal policies</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RemovalPolicies")]
        [Validation(Required=false)]
        public List<string> RemovalPolicies { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the new scaling group belongs.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the new scaling group is added to the default resource group.</para>
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
        /// <para>The name must be 2 to 64 characters in length. It must start with a letter, a digit, or a Chinese character and can contain digits, underscores (_), hyphens (-), and periods (.).</para>
        /// <para>If you do not specify this parameter, the value of <c>ScalingGroupId</c> is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scalinggroup****</para>
        /// </summary>
        [NameInMap("ScalingGroupName")]
        [Validation(Required=false)]
        public string ScalingGroupName { get; set; }

        /// <summary>
        /// <para>The reclamation mode of the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>recycle</c>: The reclamation mode is Economical Mode.</para>
        /// </description></item>
        /// <item><description><para><c>release</c>: The reclamation mode is Release Mode.</para>
        /// </description></item>
        /// <item><description><para><c>forcerelease</c>: The reclamation mode is Force Release Mode.</para>
        /// <remarks>
        /// <para>A forced release is equivalent to a power-off operation, which erases data in the memory and ephemeral storage of the instances. This data cannot be recovered. Use this option with caution.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><c>forcerecycle</c>: The reclamation mode is Force Economical Mode.</para>
        /// <remarks>
        /// <para>A forced stop is equivalent to a power-off operation, which erases data in the memory and ephemeral storage of the instances. This data cannot be recovered. Use this option with caution.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para><c>ScalingPolicy</c> specifies the reclamation mode of the scaling group. The specific action taken when an instance is removed from the scaling group is determined by the <c>RemovePolicy</c> parameter of the <c>RemoveInstances</c> operation. For more information, see <a href="https://help.aliyun.com/document_detail/25955.html">RemoveInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recycle</para>
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public string ScalingPolicy { get; set; }

        /// <summary>
        /// <para>The load balancer server groups.</para>
        /// <remarks>
        /// <para>You cannot specify the same server group in both <c>AlbServerGroups</c> and <c>ServerGroups</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ServerGroups")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestServerGroups> ServerGroups { get; set; }
        public class CreateScalingGroupRequestServerGroups : TeaModel {
            /// <summary>
            /// <para>The port number used by an instance after it is added to the server group. Valid values: 1 to 65535.</para>
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
            /// <item><description><para><c>ALB</c>: Application Load Balancer.</para>
            /// </description></item>
            /// <item><description><para><c>NLB</c>: Network Load Balancer.</para>
            /// </description></item>
            /// <item><description><para><c>GWLB</c>: Gateway Load Balancer.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The weight of an instance as a backend server after the instance is added to the server group. Valid values: 0 to 100.</para>
            /// <para>A higher weight indicates that more access requests are distributed to the instance. If the weight is 0, no access requests are distributed to the instance.</para>
            /// <remarks>
            /// <para>This parameter is required for ALB and NLB server groups. You cannot set this parameter for GWLB server groups.</para>
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
        /// <para>The distribution strategy for spot capacity. You can use this parameter to specify a separate strategy for spot capacity (effective only when the <c>MultiAZPolicy</c> parameter is set to <c>COMPOSABLE</c>). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>priority: Creates instances in the order of the configured instance types.</para>
        /// </description></item>
        /// <item><description><para>lowestPrice: Creates instances in ascending order of the price per vCPU of the instance types.</para>
        /// </description></item>
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
        /// <para>The number of instance types to use. The scaling group creates spot instances in a balanced manner across the specified number of lowest-cost instance types. Valid values: 1 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SpotInstancePools")]
        [Validation(Required=false)]
        public int? SpotInstancePools { get; set; }

        /// <summary>
        /// <para>If set to <c>true</c>, Auto Scaling attempts to create a new instance to replace a spot instance that is about to be reclaimed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        /// <summary>
        /// <para>The timeout period for the system to wait for an ECS instance to be stopped during a scale-in event. Unit: seconds.
        /// Valid values: 30 to 240.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only during scale-in events when <c>ScalingPolicy</c> is set to <c>release</c>.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is set, the system waits for the specified <c>StopInstanceTimeout</c> period for the instance to be stopped. If the instance is not stopped after the timeout period, the scale-in process continues regardless of the instance status.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not set, the system waits for an extended period for the instance to be stopped. The scale-in process continues only after the instance is stopped. If the instance fails to stop, the scale-in process is rolled back, and the scale-in event fails.</para>
        /// </description></item>
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
        /// <para>This parameter is not yet available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SyncAlarmRuleToCms")]
        [Validation(Required=false)]
        public bool? SyncAlarmRuleToCms { get; set; }

        /// <summary>
        /// <para>The tags to apply to the scaling group.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestTags> Tags { get; set; }
        public class CreateScalingGroupRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Department</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Specifies whether the tag can be propagated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The tag is propagated from the scaling group only to newly created instances, not to instances that are already running in the scaling group.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The tag is not propagated from the scaling group to any instances.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Propagate")]
            [Validation(Required=false)]
            public bool? Propagate { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finance</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vServer groups to associate with the scaling group.</para>
        /// </summary>
        [NameInMap("VServerGroups")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestVServerGroups> VServerGroups { get; set; }
        public class CreateScalingGroupRequestVServerGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the Classic Load Balancer (CLB) instance to which the vServer group belongs.</para>
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
                /// <para>The port number used by an instance after it is added to the vServer group. Valid values: 1 to 65535.</para>
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
                /// <para>The weight of an instance as a backend server after the instance is added to the vServer group. The higher the weight, the more access requests are distributed to the instance. If the weight is 0, no access requests are distributed to the instance. Valid values: 0 to 100.</para>
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
        /// <para>The ID of the vSwitch. If you specify this parameter, the network type of the scaling group is Virtual Private Cloud (VPC).</para>
        /// <remarks>
        /// <para>If you do not specify the <c>VSwitchId</c> or <c>VSwitchIds</c> parameter, the network type of the scaling group defaults to classic network.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp14zolna43z266bq****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The IDs of one or more vSwitches. If you specify this parameter, the <c>VSwitchId</c> parameter is ignored. If you specify this parameter, the network type of the scaling group is Virtual Private Cloud (VPC).</para>
        /// <para>If you specify multiple vSwitches:</para>
        /// <list type="bullet">
        /// <item><description><para>They must belong to the same VPC.</para>
        /// </description></item>
        /// <item><description><para>They can be in different availability zones.</para>
        /// </description></item>
        /// <item><description><para>The vSwitches are prioritized based on their order in the list, with the first vSwitch having the highest priority. If an instance cannot be created in the availability zone of a higher-priority vSwitch, Auto Scaling automatically attempts to create the instance in the availability zone of the next-highest-priority vSwitch.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify the <c>VSwitchId</c> or <c>VSwitchIds</c> parameter, the network type of the scaling group defaults to classic network.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
