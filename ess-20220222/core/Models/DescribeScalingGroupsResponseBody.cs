// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scaling groups.</para>
        /// </summary>
        [NameInMap("ScalingGroups")]
        [Validation(Required=false)]
        public List<DescribeScalingGroupsResponseBodyScalingGroups> ScalingGroups { get; set; }
        public class DescribeScalingGroupsResponseBodyScalingGroups : TeaModel {
            /// <summary>
            /// <para>The number of ECS instances that are in the In Service state in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ActiveCapacity")]
            [Validation(Required=false)]
            public int? ActiveCapacity { get; set; }

            /// <summary>
            /// <para>The ID of the active scaling configuration in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asc-bp1et2qekq3ojr33****</para>
            /// </summary>
            [NameInMap("ActiveScalingConfigurationId")]
            [Validation(Required=false)]
            public string ActiveScalingConfigurationId { get; set; }

            /// <summary>
            /// <para>The Application Load Balancer (ALB) server groups.</para>
            /// </summary>
            [NameInMap("AlbServerGroups")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupsResponseBodyScalingGroupsAlbServerGroups> AlbServerGroups { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsAlbServerGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the ALB server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sgp-ddwb0y0g6y9bjm****</para>
                /// </summary>
                [NameInMap("AlbServerGroupId")]
                [Validation(Required=false)]
                public string AlbServerGroupId { get; set; }

                /// <summary>
                /// <para>The port number used by an ECS instance as a backend server in the ALB server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The weight of an ECS instance as a backend server in the ALB server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The instance allocation policy. Auto Scaling selects instance types based on the allocation policy to create the required number of preemptible instances. The policy is suitable for pay-as-you-go instances and preemptible instances. This parameter takes effect only if you set <c>MultiAZPolicy</c> to <c>COMPOSABLE</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>priority: Auto Scaling adopts the predefined instance type sequence to create the required number of preemptible instances.</description></item>
            /// <item><description>lowestPrice: Auto Scaling selects instance types that have the most economical vCPU pricing to create the required number of instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>priority</para>
            /// </summary>
            [NameInMap("AllocationStrategy")]
            [Validation(Required=false)]
            public string AllocationStrategy { get; set; }

            /// <summary>
            /// <para>Whether to enable automatic rebalancing for the scaling group. This takes effect only when BalancedOnly is enabled for the scaling group. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>false: Auto rebalancing is disabled for the scaling group.</description></item>
            /// <item><description>true: If Auto rebalancing is enabled, the scaling group automatically detects the capacity of the zone. If the capacity of the zone is unbalanced, the scaling group actively scales out the zone and re-balances the capacity of the zone.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoRebalance")]
            [Validation(Required=false)]
            public bool? AutoRebalance { get; set; }

            /// <summary>
            /// <para>Indicates whether instances in the scaling group are evenly distributed across the specified zones. This parameter takes effect only if you set <c>MultiAZPolicy</c> to <c>COMPOSABLE</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AzBalance")]
            [Validation(Required=false)]
            public bool? AzBalance { get; set; }

            /// <summary>
            /// <para>The zone balancing mode. This mode takes effect only when the zone balancing mode is enabled. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Default value: BalancedBestEffort. If a resource fails to be created in a zone, the resource is downgraded to another zone. This ensures best-effort delivery of the resource.</description></item>
            /// <item><description>BalancedOnly: If a resource fails to be created in a zone, the resource is not downgraded to another zone. The scale-out activity is partially successful to avoid excessive imbalance of resources in different zones.</description></item>
            /// </list>
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
            public DescribeScalingGroupsResponseBodyScalingGroupsCapacityOptions CapacityOptions { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsCapacityOptions : TeaModel {
                /// <summary>
                /// <para>Indicates whether pay-as-you-go ECS instances can be automatically created to reach the required number of ECS instances when preemptible ECS instances cannot be created due to high prices or insufficient inventory of resources. This parameter takes effect when you set <c>MultiAZPolicy</c> to <c>COST_OPTIMIZED</c>. Valid values:</para>
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
                /// <para>The minimum number of pay-as-you-go instances required in the scaling group. When the actual number of pay-as-you-go instances drops below the minimum threshold, Auto Scaling preferentially creates pay-as-you-go instances. Valid values: 0 to 1000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OnDemandBaseCapacity")]
                [Validation(Required=false)]
                public int? OnDemandBaseCapacity { get; set; }

                /// <summary>
                /// <para>The percentage of pay-as-you-go instances in the excess instances when the minimum number of pay-as-you-go instances is reached. <c>OnDemandBaseCapacity</c> specifies the minimum number of pay-as-you-go instances required in the scaling group. Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OnDemandPercentageAboveBaseCapacity")]
                [Validation(Required=false)]
                public int? OnDemandPercentageAboveBaseCapacity { get; set; }

                /// <summary>
                /// <para>Indicates how prices are compared. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>PricePerUnit: Prices are compared based on the price per instance capacity.</para>
                /// <para>Capacity is determined by the weights assigned to instance types in the scaling group. If no weight is specified, a default weight of 1 is used, meaning each instance is assigned a capacity of 1.</para>
                /// </description></item>
                /// <item><description><para>PricePerVCpu: Prices are compared based on the price per vCPU.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PricePerUnit</para>
                /// </summary>
                [NameInMap("PriceComparisonMode")]
                [Validation(Required=false)]
                public string PriceComparisonMode { get; set; }

                /// <summary>
                /// <para>Specifies whether to replace pay-as-you-go ECS instances with preemptible ECS instances. If you specify <c>CompensateWithOnDemand</c>, it may result in a higher percentage of pay-as-you-go instances compared to the value of <c>OnDemandPercentageAboveBaseCapacity</c>. In this scenario, Auto Scaling will try to deploy preemptible ECS instances to replace the surplus pay-as-you-go ECS instances. When <c>CompensateWithOnDemand</c> is specified, Auto Scaling creates pay-as-you-go ECS instances if there are not enough preemptible instance types available. To avoid keeping these pay-as-you-go ECS instances for long periods, Auto Scaling tries to replace them with preemptible instances as soon as enough of preemptible instance types become available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SpotAutoReplaceOnDemand")]
                [Validation(Required=false)]
                public bool? SpotAutoReplaceOnDemand { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether Auto Scaling can create pay-as-you-go instances to supplement preemptible instances if preemptible instances cannot be created due to price-related factors or insufficient inventory when MultiAZPolicy is set to COST_OPTIMIZED. Valid values:</para>
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
            /// <para>The time when the scaling group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-08-14T10:58Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is unavailable.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hostname</para>
            /// </summary>
            [NameInMap("CurrentHostName")]
            [Validation(Required=false)]
            public string CurrentHostName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the function that is specified in the custom scale-in policy. This parameter takes effect only if you set the first value of RemovalPolicies to CustomPolicy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:fc:cn-zhangjiakou:16145688****:services/ess_custom_terminate_policy.LATEST/functions/ess_custom_terminate_policy_name</para>
            /// </summary>
            [NameInMap("CustomPolicyARN")]
            [Validation(Required=false)]
            public string CustomPolicyARN { get; set; }

            /// <summary>
            /// <para>The IDs of the ApsaraDB RDS instances that are attached to the scaling group.</para>
            /// </summary>
            [NameInMap("DBInstanceIds")]
            [Validation(Required=false)]
            public List<string> DBInstanceIds { get; set; }

            /// <summary>
            /// <para>The databases that are attached to the scaling group.</para>
            /// </summary>
            [NameInMap("DBInstances")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupsResponseBodyScalingGroupsDBInstances> DBInstances { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsDBInstances : TeaModel {
                /// <summary>
                /// <para>The ID of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-m5eqju85s45mu0***</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The IDs of the security groups that are added to the security group whitelist of the attached database.</para>
                /// </summary>
                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public List<string> SecurityGroupIds { get; set; }

                /// <summary>
                /// <para>The type of the database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RDS.</description></item>
                /// <item><description>Redis.</description></item>
                /// <item><description>MongoDB.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RDS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The cooldown period of the scaling group. During the cooldown period, Auto Scaling does not execute the scaling activities that are triggered by <a href="https://help.aliyun.com/document_detail/35170.html">CloudMonitor</a> event-triggered tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("DefaultCooldown")]
            [Validation(Required=false)]
            public int? DefaultCooldown { get; set; }

            /// <summary>
            /// <para>The expected number of ECS instances in the scaling group. Auto Scaling automatically maintains the expected number of ECS instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DesiredCapacity")]
            [Validation(Required=false)]
            public int? DesiredCapacity { get; set; }

            /// <summary>
            /// <para>Indicates whether the Expected Number of Instances feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableDesiredCapacity")]
            [Validation(Required=false)]
            public bool? EnableDesiredCapacity { get; set; }

            /// <summary>
            /// <para>Indicates whether the Deletion Protection feature is enabled for the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The Deletion Protection feature is enabled for the scaling group. The scaling group cannot be deleted.</description></item>
            /// <item><description>false: The Deletion Protection feature is disabled for the scaling group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GroupDeletionProtection")]
            [Validation(Required=false)]
            public bool? GroupDeletionProtection { get; set; }

            /// <summary>
            /// <para>The type of instances that are managed by the scaling group.</para>
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
            /// <item><description>NONE: Auto Scaling does not perform health checks.</description></item>
            /// <item><description>ECS: Auto Scaling checks the health status of instances in the scaling group. If you want to enable instance health check, you can set the value to ECS, regardless of whether the scaling group is of ECS type or Elastic Container Instance type.</description></item>
            /// <item><description>LOAD_BALANCER: Auto Scaling checks the health status of instances in the scaling group based on the health check results of load balancers. The health check results of Classic Load Balancer (CLB) instances are not supported as the health check basis for instances in the scaling group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("HealthCheckType")]
            [Validation(Required=false)]
            public string HealthCheckType { get; set; }

            /// <summary>
            /// <para>The health check mode of the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NONE: Auto Scaling does not perform health checks.</description></item>
            /// <item><description>ECS: Auto Scaling checks the health status of instances in the scaling group. If you want to enable instance health check, you can set the value to ECS, regardless of whether the scaling group is of ECS type or Elastic Container Instance type.</description></item>
            /// <item><description>LOAD_BALANCER: Auto Scaling checks the health status of instances in the scaling group based on the health check results of load balancers. The health check results of CLB instances are not supported as the health check basis for instances in the scaling group.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("HealthCheckTypes")]
            [Validation(Required=false)]
            public List<string> HealthCheckTypes { get; set; }

            /// <summary>
            /// <para>The number of instances that are initialized before they are added into the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InitCapacity")]
            [Validation(Required=false)]
            public int? InitCapacity { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not available for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsElasticStrengthInAlarm")]
            [Validation(Required=false)]
            public bool? IsElasticStrengthInAlarm { get; set; }

            /// <summary>
            /// <para>The ID of the launch template that is used by the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lt-m5e3ofjr1zn1aw7****</para>
            /// </summary>
            [NameInMap("LaunchTemplateId")]
            [Validation(Required=false)]
            public string LaunchTemplateId { get; set; }

            /// <summary>
            /// <para>The instance types that are extended in the launch template.</para>
            /// </summary>
            [NameInMap("LaunchTemplateOverrides")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupsResponseBodyScalingGroupsLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsLaunchTemplateOverrides : TeaModel {
                /// <summary>
                /// <para>The instance type. The instance type that is specified by this parameter overrides the instance type that is specified in the launch template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c5.xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The maximum bid price of the instance type that is specified by <c>LaunchTemplateOverride.InstanceType</c>.</para>
                /// <remarks>
                /// <para> This parameter takes effect only if you use <c>LaunchTemplateId</c> to specify a launch template.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.025</para>
                /// </summary>
                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                /// <summary>
                /// <para>The weight of the instance type. The value of this parameter indicates the capacity of a single instance of the specified instance type in the scaling group. A higher weight indicates that a smaller number of instances of the specified instance type are required to meet the expected capacity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("WeightedCapacity")]
                [Validation(Required=false)]
                public int? WeightedCapacity { get; set; }

            }

            /// <summary>
            /// <para>The version of the launch template that is used by the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("LaunchTemplateVersion")]
            [Validation(Required=false)]
            public string LaunchTemplateVersion { get; set; }

            /// <summary>
            /// <para>The status of the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active: The scaling group is active. Active scaling groups can receive requests to execute scaling rules and trigger scaling activities.</description></item>
            /// <item><description>Inactive: The scaling group is in the Disabled state. Disabled scaling groups cannot receive requests to execute scaling rules.</description></item>
            /// <item><description>Deleting: The scaling group is being deleted. Scaling groups that are being deleted cannot receive requests to execute scaling rules, and the parameter settings of the scaling groups cannot be modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// <para>The load balancer configurations.</para>
            /// </summary>
            [NameInMap("LoadBalancerConfigs")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupsResponseBodyScalingGroupsLoadBalancerConfigs> LoadBalancerConfigs { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsLoadBalancerConfigs : TeaModel {
                /// <summary>
                /// <para>The ID of the CLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-2zep8alpq5zq1a2xwyxxx</para>
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The weight of an ECS instance as a backend server in the CLB server group. An increase in the weight of an ECS instance indicates an increase in the number of access requests that are forwarded to the ECS instance. If you set the weight of an ECS instance to 0, no access requests are forwarded to the ECS instance. Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The IDs of the load balancers that are attached to the scaling group.</para>
            /// </summary>
            [NameInMap("LoadBalancerIds")]
            [Validation(Required=false)]
            public List<string> LoadBalancerIds { get; set; }

            /// <summary>
            /// <para>The maximum life span of each ECS instance in the scaling group. Unit: seconds.</para>
            /// <para>Valid values: 0 or <c>[86400, Integer.maxValue]</c>. A value of 0 for MaxInstanceLifetime indicates that a previously set limit has been removed. This effectively disables the maximum instance lifetime constraint.</para>
            /// <para>Default value: null.</para>
            /// <remarks>
            /// <para> This parameter is not supported by scaling groups of the Elastic Container Instance type and scaling groups whose ScalingPolicy is set to Recycle.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("MaxInstanceLifetime")]
            [Validation(Required=false)]
            public int? MaxInstanceLifetime { get; set; }

            /// <summary>
            /// <para>The maximum number of ECS instances that can be contained in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxSize")]
            [Validation(Required=false)]
            public int? MaxSize { get; set; }

            /// <summary>
            /// <para>The minimum number of ECS instances that must be contained in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinSize")]
            [Validation(Required=false)]
            public int? MinSize { get; set; }

            /// <summary>
            /// <para>The time when the scaling group was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-08-14T10:58Z</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <para>The ID of the CloudMonitor application group that is associated with the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1497****</para>
            /// </summary>
            [NameInMap("MonitorGroupId")]
            [Validation(Required=false)]
            public string MonitorGroupId { get; set; }

            /// <summary>
            /// <para>The scaling policy of the ECS instances in the multi-zone scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PRIORITY: ECS instances are created based on the value of VSwitchIds. If Auto Scaling cannot create ECS instances in the zone where the vSwitch of the highest priority resides, Auto Scaling creates ECS instances in the zone where the vSwitch of the next highest priority resides.</para>
            /// </description></item>
            /// <item><description><para>COST_OPTIMIZED: ECS instances are created based on the unit prices of their vCPUs. Auto Scaling preferentially creates ECS instances whose vCPUs are provided at the lowest price. If preemptible instance types are specified in the scaling configuration, Auto Scaling preferentially creates preemptible instances. You can also specify CompensateWithOnDemand to allow Auto Scaling to create pay-as-you-go instances if preemptible instances cannot be created due to limited stock.</para>
            /// <para>**</para>
            /// <para><b>Note</b> The COST_OPTIMIZED setting takes effect only if your scaling configuration contains multiple instance types or contains preemptible instance types.</para>
            /// </description></item>
            /// <item><description><para>BALANCE: ECS instances are evenly distributed across the zones that are specified for the scaling group. If ECS instances become unevenly distributed across the specified zones due to limited instance type availability, you can call the RebalanceInstance operation to balance the distribution of the ECS instances.</para>
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
            /// <para>The minimum number of pay-as-you-go instances that must be contained in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is less than the value of this parameter, Auto Scaling preferentially creates pay-as-you-go instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("OnDemandBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of pay-as-you-go instances in excess when the minimum number of pay-as-you-go instances reaches the threshold. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("OnDemandPercentageAboveBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The number of ECS instances that are being added to the scaling group and configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PendingCapacity")]
            [Validation(Required=false)]
            public int? PendingCapacity { get; set; }

            /// <summary>
            /// <para>The number of ECS instances that are in the Pending Add state in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PendingWaitCapacity")]
            [Validation(Required=false)]
            public int? PendingWaitCapacity { get; set; }

            /// <summary>
            /// <para>The number of ECS instances that are in the Protected state in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProtectedCapacity")]
            [Validation(Required=false)]
            public int? ProtectedCapacity { get; set; }

            /// <summary>
            /// <para>The region ID of the scaling group.</para>
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
            /// <item><description>OldestInstance: Auto Scaling removes ECS instances that are added at the earliest point in time to the scaling group.</description></item>
            /// <item><description>NewestInstance: Auto Scaling removes ECS instances that are most recently added to the scaling group.</description></item>
            /// <item><description>OldestScalingConfiguration: Auto Scaling removes ECS instances that are created from the earliest scaling configuration.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("RemovalPolicies")]
            [Validation(Required=false)]
            public List<string> RemovalPolicies { get; set; }

            /// <summary>
            /// <para>The number of ECS instances that are being removed from the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RemovingCapacity")]
            [Validation(Required=false)]
            public int? RemovingCapacity { get; set; }

            /// <summary>
            /// <para>The number of ECS instances that are in the Pending Remove state in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RemovingWaitCapacity")]
            [Validation(Required=false)]
            public int? RemovingWaitCapacity { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the scaling group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-123****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp14wlu85wrpchm0****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The name of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dyrSuvBOtO1dEdIlIbp****</para>
            /// </summary>
            [NameInMap("ScalingGroupName")]
            [Validation(Required=false)]
            public string ScalingGroupName { get; set; }

            /// <summary>
            /// <para>The instance reclaim mode of the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>recycle: economical mode.</description></item>
            /// <item><description>release: release mode.</description></item>
            /// <item><description>forcerelease: forced release mode.</description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/25955.html">RemoveInstances</a>.</para>
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
            /// <para> You can use this parameter to obtain the information about the ALB, NLB, and GWLB server groups associated with a scaling group.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ServerGroups")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupsResponseBodyScalingGroupsServerGroups> ServerGroups { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsServerGroups : TeaModel {
                /// <summary>
                /// <para>The port number used by each ECS instance in the server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The ID of the server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sgp-i9ouakeaerr*****</para>
                /// </summary>
                [NameInMap("ServerGroupId")]
                [Validation(Required=false)]
                public string ServerGroupId { get; set; }

                /// <summary>
                /// <para>The type of the server group. Valid values:</para>
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
                /// <para>The weight of an ECS instance as a backend server in the server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The allocation policy of preemptible instances. This parameter indicates the manner in which Auto Scaling selects instance types to create the required number of preemptible instances. This parameter takes effect only if you set <c>MultiAZPolicy</c> to <c>COMPOSABLE</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>priority: Auto Scaling adopts the predefined instance type sequence to create the required number of preemptible instances.</description></item>
            /// <item><description>lowestPrice: Auto Scaling selects instance types that have the most economical vCPU pricing to create the required number of preemptible instances.</description></item>
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
            /// <para>The number of preemptible instances in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SpotCapacity")]
            [Validation(Required=false)]
            public int? SpotCapacity { get; set; }

            /// <summary>
            /// <para>The number of instance types in the scaling group. Auto Scaling evenly creates preemptible instances of multiple instance types that are provided at the lowest price across the zones of the scaling group. Valid values: 0 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SpotInstancePools")]
            [Validation(Required=false)]
            public int? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Indicates whether preemptible instances can be supplemented. If this parameter is set to true, Auto Scaling proactively creates instances to replace the preemptible instances for reclamation when Auto Scaling receives a system notification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SpotInstanceRemedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// <para>The number of ECS instances that are in the Standby state in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StandbyCapacity")]
            [Validation(Required=false)]
            public int? StandbyCapacity { get; set; }

            /// <summary>
            /// <para>The period of time that is required by the Elastic Compute Service (ECS) instance to enter the Stopped state during the scale-in process. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("StopInstanceTimeout")]
            [Validation(Required=false)]
            public int? StopInstanceTimeout { get; set; }

            /// <summary>
            /// <para>The number of instances that was stopped in Economical Mode in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StoppedCapacity")]
            [Validation(Required=false)]
            public int? StoppedCapacity { get; set; }

            /// <summary>
            /// <para>The processes that are suspended. If no process is suspended, null is returned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ScaleIn: scale-in processes.</description></item>
            /// <item><description>ScaleOut: scale-out processes.</description></item>
            /// <item><description>HealthCheck: health check processes.</description></item>
            /// <item><description>AlarmNotification: event-triggered task processes.</description></item>
            /// <item><description>ScheduledAction: scheduled task processes.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SuspendedProcesses")]
            [Validation(Required=false)]
            public List<string> SuspendedProcesses { get; set; }

            /// <summary>
            /// <para>Indicates whether Auto Scaling stops executing scaling activities in the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Auto Scaling stops executing scaling activities in the scaling group if the scaling activities failed for more than seven consecutive days in the scaling group. In this case, you must modify the scaling group or scaling configuration to resume the scaling activities.</description></item>
            /// <item><description>false: Auto Scaling does not stop executing scaling activities in the scaling group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SystemSuspended")]
            [Validation(Required=false)]
            public bool? SystemSuspended { get; set; }

            /// <summary>
            /// <para>The tags of the scaling group.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupsResponseBodyScalingGroupsTags> Tags { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsTags : TeaModel {
                /// <summary>
                /// <para>Indicates whether the tags of the scaling group can be propagated to instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The tags of the scaling group can be propagated only to new instances.</description></item>
                /// <item><description>false: The tags of the scaling group cannot be propagated to instances.</description></item>
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
                /// <para>The tag key of the scaling group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Department</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value of the scaling group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Finance</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The total weighted capacity of all ECS instances in the scaling group if Weighted is specified. In other cases, this parameter specifies the total number of ECS instances in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCapacity")]
            [Validation(Required=false)]
            public int? TotalCapacity { get; set; }

            /// <summary>
            /// <para>The total number of ECS instances in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalInstanceCount")]
            [Validation(Required=false)]
            public int? TotalInstanceCount { get; set; }

            /// <summary>
            /// <para>The backend vServer groups.</para>
            /// </summary>
            [NameInMap("VServerGroups")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupsResponseBodyScalingGroupsVServerGroups> VServerGroups { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsVServerGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the load balancer to which the backend vServer group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>147b46d767c-cn-qingdao-cm5****</para>
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The attributes of the backend vServer groups.</para>
                /// </summary>
                [NameInMap("VServerGroupAttributes")]
                [Validation(Required=false)]
                public List<DescribeScalingGroupsResponseBodyScalingGroupsVServerGroupsVServerGroupAttributes> VServerGroupAttributes { get; set; }
                public class DescribeScalingGroupsResponseBodyScalingGroupsVServerGroupsVServerGroupAttributes : TeaModel {
                    /// <summary>
                    /// <para>The port number that is used by the load balancer to provide external services.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>22</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The ID of the backend vServer group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rsp-bp12bjrny****</para>
                    /// </summary>
                    [NameInMap("VServerGroupId")]
                    [Validation(Required=false)]
                    public string VServerGroupId { get; set; }

                    /// <summary>
                    /// <para>The weight of the backend vServer group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

            }

            /// <summary>
            /// <para>The vSwitch ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1whw2u46cn8zubm****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The IDs of the vSwitches that are associated with the scaling group. If you specify VSwitchIds, VSwitchId is ignored.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) in which the scaling group resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1vwnn14rqpyiczj****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
