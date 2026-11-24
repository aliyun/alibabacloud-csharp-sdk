// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
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
            /// <para>The number of ECS instances that have been added to the scaling group and are running normally.</para>
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
            /// <para>The collection of information about Application Load Balancer (ALB) server groups.</para>
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
                /// <para>The port number used by the ECS instance after Auto Scaling adds the ECS instance to the ALB server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The weight of the ECS instance as a backend server after Auto Scaling adds the ECS instance to the ALB server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The capacity allocation strategy, which determines how the scaling group selects available instance types to meet the capacity requirements. The capacity distribution strategy applies to both pay-as-you-go and spot capacity. This parameter takes effect only when the MultiAZPolicy parameter is set to COMPOSABLE. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>priority: Creates instances based on the order of the configured instance types.</description></item>
            /// <item><description>lowestPrice: Creates instances based on the unit vCPU price of the instance types in ascending order.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>priority</para>
            /// </summary>
            [NameInMap("AllocationStrategy")]
            [Validation(Required=false)]
            public string AllocationStrategy { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic balancing for the scaling group. This parameter takes effect only when BalancedOnly is enabled for the zone balance scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false: Automatic balancing for the scaling group is disabled.</description></item>
            /// <item><description>true: Automatic balancing for the scaling group is enabled. The scaling group automatically detects the capacity across zones. If the capacity is unbalanced, the scaling group proactively scales in or out to rebalance the capacity across zones.</description></item>
            /// </list>
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
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AzBalance")]
            [Validation(Required=false)]
            public bool? AzBalance { get; set; }

            /// <summary>
            /// <para>The zone balance mode. This parameter takes effect only when the zone balance mode is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>BalancedBestEffort: If resource creation fails in a zone, the system falls back to other zones to ensure best-effort delivery of resources.</para>
            /// </description></item>
            /// <item><description><para>BalancedOnly: If resource creation fails in a zone, the system does not fall back to other zones. The scale-out activity partially succeeds to avoid excessive imbalance of resources across different zones.</para>
            /// </description></item>
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
                /// <para>Specifies whether to automatically create pay-as-you-go instances to meet the required number of ECS instances when the MultiAZPolicy parameter is set to COST_OPTIMIZED and sufficient spot instances cannot be created due to price or inventory reasons. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Allowed.</description></item>
                /// <item><description>false: Not allowed.</description></item>
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
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OnDemandBaseCapacity")]
                [Validation(Required=false)]
                public int? OnDemandBaseCapacity { get; set; }

                /// <summary>
                /// <para>The percentage of pay-as-you-go instances among the excess instances after the scaling group meets the minimum number of pay-as-you-go instances specified by OnDemandBaseCapacity. Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OnDemandPercentageAboveBaseCapacity")]
                [Validation(Required=false)]
                public int? OnDemandPercentageAboveBaseCapacity { get; set; }

                /// <summary>
                /// <para>The price comparison mode of the cost optimization strategy for the scaling group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>PricePerUnit: Compares prices based on the price per unit of capacity.</para>
                /// <para>The capacity of an instance in the scaling group is equal to the weight set for the instance type. The default weight is 1, which means one ECS instance occupies one unit of capacity.</para>
                /// </description></item>
                /// <item><description><para>PricePerVCpu: Compares prices based on the price per vCPU.</para>
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
                /// <para>Specifies whether to use spot instances to replace pay-as-you-go capacity when CompensateWithOnDemand is enabled and the percentage of pay-as-you-go instances exceeds the value of OnDemandPercentageAboveBaseCapacity. In common scenarios where CompensateWithOnDemand downgrades spot instances to pay-as-you-go instances due to spot inventory or price reasons, this feature attempts to use spot instances to replace the excess pay-as-you-go capacity to avoid long-term retention of pay-as-you-go instances. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Allowed.</description></item>
                /// <item><description>false: Not allowed.</description></item>
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
            /// <para>Specifies whether to automatically create pay-as-you-go instances to meet the requirement for the number of ECS instances when the MultiAZPolicy parameter is set to COST_OPTIMIZED and spot instances cannot be created due to price or inventory issues. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Allowed.</description></item>
            /// <item><description>false: Not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CompensateWithOnDemand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// <para>The time when the scaling group was created. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mmZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-08-14T10:58Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hostname</para>
            /// </summary>
            [NameInMap("CurrentHostName")]
            [Validation(Required=false)]
            public string CurrentHostName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the Function Compute function for the custom scale-in policy. This parameter takes effect only when the first removal policy in RemovalPolicies is set to CustomPolicy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:fc:cn-zhangjiakou:16145688****:services/ess_custom_terminate_policy.LATEST/functions/ess_custom_terminate_policy_name</para>
            /// </summary>
            [NameInMap("CustomPolicyARN")]
            [Validation(Required=false)]
            public string CustomPolicyARN { get; set; }

            /// <summary>
            /// <para>The IDs of the ApsaraDB RDS instances associated with the scaling group.</para>
            /// </summary>
            [NameInMap("DBInstanceIds")]
            [Validation(Required=false)]
            public List<string> DBInstanceIds { get; set; }

            /// <summary>
            /// <para>The list of databases associated with the scaling group.</para>
            /// </summary>
            [NameInMap("DBInstances")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupsResponseBodyScalingGroupsDBInstances> DBInstances { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsDBInstances : TeaModel {
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
                /// <para>The list of security group whitelists added to the database by the scaling group.</para>
                /// </summary>
                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public List<string> SecurityGroupIds { get; set; }

                /// <summary>
                /// <para>The type of the database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RDS</description></item>
                /// <item><description>Redis</description></item>
                /// <item><description>MongoDB</description></item>
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
            /// <para>The default cooldown time of the scaling group. During the cooldown time, the scaling group does not execute any other scaling activity. This parameter takes effect only for a scaling activity triggered by <a href="https://help.aliyun.com/document_detail/35170.html">CloudMonitor</a> event-triggered tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("DefaultCooldown")]
            [Validation(Required=false)]
            public int? DefaultCooldown { get; set; }

            /// <summary>
            /// <para>The expected number of ECS instances in the scaling group. The scaling group automatically maintains the number of ECS instances at the expected number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DesiredCapacity")]
            [Validation(Required=false)]
            public int? DesiredCapacity { get; set; }

            /// <summary>
            /// <para>Specifies whether the expected number of instances feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The expected number of instances feature is enabled.</description></item>
            /// <item><description>false: The expected number of instances feature is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableDesiredCapacity")]
            [Validation(Required=false)]
            public bool? EnableDesiredCapacity { get; set; }

            /// <summary>
            /// <para>Indicates whether deletion protection is enabled for the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Deletion protection is enabled. The scaling group cannot be deleted.</description></item>
            /// <item><description>false: Deletion protection is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("GroupDeletionProtection")]
            [Validation(Required=false)]
            public bool? GroupDeletionProtection { get; set; }

            /// <summary>
            /// <para>The type of instances managed by the scaling group.</para>
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
            /// <item><description>NONE: No health check is performed.</description></item>
            /// <item><description>ECS: Health checks are performed on instances in the scaling group. This value is used to enable instance health checks for both ECS and ECI scaling groups.</description></item>
            /// <item><description>LOAD_BALANCER: The health status of instances is determined based on the health check results of load balancing (CLB load balancing is not supported).</description></item>
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
            /// <item><description>NONE: No health check is performed.</description></item>
            /// <item><description>ECS: Health checks are performed on instances in the scaling group. This value is used to enable instance health checks for both ECS and ECI scaling groups.</description></item>
            /// <item><description>LOAD_BALANCER: The health status of instances is determined based on the load balancing health check results (the CLB load balancing type is not currently supported).</description></item>
            /// </list>
            /// </summary>
            [NameInMap("HealthCheckTypes")]
            [Validation(Required=false)]
            public List<string> HealthCheckTypes { get; set; }

            /// <summary>
            /// <para>The number of instances in the initialization state before scale-out in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InitCapacity")]
            [Validation(Required=false)]
            public int? InitCapacity { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsElasticStrengthInAlarm")]
            [Validation(Required=false)]
            public bool? IsElasticStrengthInAlarm { get; set; }

            /// <summary>
            /// <para>The ID of the launch template used by the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lt-m5e3ofjr1zn1aw7****</para>
            /// </summary>
            [NameInMap("LaunchTemplateId")]
            [Validation(Required=false)]
            public string LaunchTemplateId { get; set; }

            /// <summary>
            /// <para>The instance type information that extends the launch template.</para>
            /// </summary>
            [NameInMap("LaunchTemplateOverrides")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupsResponseBodyScalingGroupsLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsLaunchTemplateOverrides : TeaModel {
                /// <summary>
                /// <para>The specified instance type, which overrides the instance type in the launch template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c5.xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The maximum hourly price for the instance type specified in the launch template override (namely LaunchTemplateOverride.InstanceType).</para>
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
                /// <para>The weight of the specified instance type, which indicates the capacity of a single instance of this type in the scaling group. A higher weight indicates that fewer instances of this type are required to meet the expected capacity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("WeightedCapacity")]
                [Validation(Required=false)]
                public int? WeightedCapacity { get; set; }

            }

            /// <summary>
            /// <para>The version of the launch template used by the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("LaunchTemplateVersion")]
            [Validation(Required=false)]
            public string LaunchTemplateVersion { get; set; }

            /// <summary>
            /// <para>The lifecycle state of the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active: The scaling group is active. Only active scaling groups can accept requests to execute scaling rules and trigger a scaling activity.</description></item>
            /// <item><description>Inactive: The scaling group is inactive. Inactive scaling groups do not receive any requests to execute scaling rules.</description></item>
            /// <item><description>Deleting: The scaling group is being deleted. Scaling groups in the deleting state do not receive any requests to execute scaling rules, and their parameters cannot be modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// <para>The list of load balancing configurations.</para>
            /// </summary>
            [NameInMap("LoadBalancerConfigs")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupsResponseBodyScalingGroupsLoadBalancerConfigs> LoadBalancerConfigs { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsLoadBalancerConfigs : TeaModel {
                /// <summary>
                /// <para>The ID of the Classic Load Balancer (CLB) instance for load balancing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-2zep8alpq5zq1a2xwyxxx</para>
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The weight of the ECS instance as a backend server after Auto Scaling adds the ECS instance to the SLB server group. A higher weight indicates that more access requests are distributed to the ECS instance. If the weight is 0, the ECS instance does not receive access requests. Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The list of IDs of the load balancing instances associated with the scaling group.</para>
            /// </summary>
            [NameInMap("LoadBalancerIds")]
            [Validation(Required=false)]
            public List<string> LoadBalancerIds { get; set; }

            /// <summary>
            /// <para>The maximum lifetime of an instance in the scaling group. Unit: seconds.</para>
            /// <para>Valid values: 0 or [86400, Integer.maxValue]. A value of 0 indicates that the configured value of MaxInstanceLifetime is cleared, which means MaxInstanceLifetime is not configured.</para>
            /// <para>Default value: null.</para>
            /// <remarks>
            /// <para>This parameter is not supported for scaling groups of the Elastic Container Instance (ECI) type or scaling groups that have the No Fees for Stopped Instances feature enabled.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("MaxInstanceLifetime")]
            [Validation(Required=false)]
            public int? MaxInstanceLifetime { get; set; }

            /// <summary>
            /// <para>The maximum number of ECS instances in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxSize")]
            [Validation(Required=false)]
            public int? MaxSize { get; set; }

            /// <summary>
            /// <para>The minimum number of ECS instances in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinSize")]
            [Validation(Required=false)]
            public int? MinSize { get; set; }

            /// <summary>
            /// <para>The time when the scaling group was modified. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mmZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-08-14T10:58Z</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <para>The ID of the CloudMonitor application group associated with the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1497****</para>
            /// </summary>
            [NameInMap("MonitorGroupId")]
            [Validation(Required=false)]
            public string MonitorGroupId { get; set; }

            /// <summary>
            /// <para>The scale-out and scale-in policy for ECS instances in a multi-zone scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PRIORITY: Scales out and scales in instances based on the vSwitches defined in VSwitchIds. If ECS instances cannot be created in the active zone of the vSwitch with the highest priority, the system automatically uses the vSwitch with the next highest priority to create ECS instances.</description></item>
            /// <item><description>COST_OPTIMIZED: Attempts to create instances based on the unit price of vCPUs from low to high. When the scaling configuration specifies multiple instance types with the spot billing method, the system preferentially creates spot instances. You can use the CompensateWithOnDemand parameter to specify whether to automatically attempt to create pay-as-you-go instances when spot instances cannot be created due to inventory issues.<remarks>
            /// <para>COST_OPTIMIZED takes effect only when the scaling configuration specifies multiple instance types or uses spot instances.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>BALANCE: Evenly allocates ECS instances across the active zones specified for the scaling group. If the distribution becomes unbalanced due to insufficient inventory, you can call the RebalanceInstance operation to balance the resources.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PRIORITY</para>
            /// </summary>
            [NameInMap("MultiAZPolicy")]
            [Validation(Required=false)]
            public string MultiAZPolicy { get; set; }

            /// <summary>
            /// <para>The minimum number of pay-as-you-go instances required in the scaling group. Valid values: 0 to 1000. When the number of pay-as-you-go instances in the scaling group is less than this value, the system preferentially creates pay-as-you-go instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("OnDemandBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>The percentage of pay-as-you-go instances to be created when the scaling group exceeds the minimum number of pay-as-you-go instances specified by OnDemandBaseCapacity. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("OnDemandPercentageAboveBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The number of ECS instances that are being added to the scaling group but have not completed the related configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PendingCapacity")]
            [Validation(Required=false)]
            public int? PendingCapacity { get; set; }

            /// <summary>
            /// <para>The number of ECS instances that are in the pending wait state in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PendingWaitCapacity")]
            [Validation(Required=false)]
            public int? PendingWaitCapacity { get; set; }

            /// <summary>
            /// <para>The number of ECS instances that are in the protected state in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProtectedCapacity")]
            [Validation(Required=false)]
            public int? ProtectedCapacity { get; set; }

            /// <summary>
            /// <para>The ID of the region to which the scaling group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The collection of policies for removing ECS instances from the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OldestInstance: Removes the ECS instance that was created earliest.</description></item>
            /// <item><description>NewestInstance: Removes the ECS instance that was created latest.</description></item>
            /// <item><description>OldestScalingConfiguration: Removes the ECS instance that was created earliest based on the scaling configuration.</description></item>
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
            /// <para>The number of ECS instances that are in the removing wait state in the scaling group.</para>
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
            /// <para>The reclaim mode of the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>recycle: The scaling group uses the shutdown and reclaim mode.</description></item>
            /// <item><description>release: The scaling group uses the release mode.</description></item>
            /// <item><description>forcerelease: The scaling group uses the force release mode.
            /// For more information about the actions on removed instances, see <a href="https://help.aliyun.com/document_detail/25955.html">RemoveInstances</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>recycle</para>
            /// </summary>
            [NameInMap("ScalingPolicy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            /// <summary>
            /// <para>The collection of information about load balancing server groups.</para>
            /// <remarks>
            /// <para>You can use this parameter to obtain the collection of information about ALB service groups, NLB server groups, and GWLB service groups associated with the scaling group.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ServerGroups")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupsResponseBodyScalingGroupsServerGroups> ServerGroups { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsServerGroups : TeaModel {
                /// <summary>
                /// <para>The port number used by the ECS instance after Auto Scaling adds the ECS instance to the server group.</para>
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
                /// <para>The weight of the ECS instance as a backend server after Auto Scaling adds the ECS instance to the server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The spot capacity distribution strategy. You can use this parameter to separately specify the distribution strategy for spot capacity. This parameter takes effect only when the MultiAZPolicy parameter is set to COMPOSABLE. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>priority: Creates instances based on the order of the configured instance types.</description></item>
            /// <item><description>lowestPrice: Creates instances based on the unit vCPU price of the instance types in ascending order.</description></item>
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
            /// <para>The number of spot instances in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SpotCapacity")]
            [Validation(Required=false)]
            public int? SpotCapacity { get; set; }

            /// <summary>
            /// <para>The number of available instance types specified. The scaling group evenly creates spot instances based on the most cost-effective instance types. Valid values: 0 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SpotInstancePools")]
            [Validation(Required=false)]
            public int? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>Indicates whether the spot instance replacement feature is enabled. After this feature is enabled, when the scaling group receives a system message indicating that a spot instance will be reclaimed, the scaling group attempts to create a new instance to replace the spot instance to be reclaimed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SpotInstanceRemedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// <para>The number of instances that are in the standby state in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StandbyCapacity")]
            [Validation(Required=false)]
            public int? StandbyCapacity { get; set; }

            /// <summary>
            /// <para>The timeout period for waiting for an ECS instance to be stopped during the scale-in process. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("StopInstanceTimeout")]
            [Validation(Required=false)]
            public int? StopInstanceTimeout { get; set; }

            /// <summary>
            /// <para>The number of instances in the scaling group that are in the economical mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StoppedCapacity")]
            [Validation(Required=false)]
            public int? StoppedCapacity { get; set; }

            /// <summary>
            /// <para>The suspended processes. If no process is suspended, an empty value is returned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ScaleIn: The scale-in process.</description></item>
            /// <item><description>ScaleOut: The scale-out process.</description></item>
            /// <item><description>HealthCheck: The health check process.</description></item>
            /// <item><description>AlarmNotification: The event-triggered task process.</description></item>
            /// <item><description>ScheduledAction: The scheduled task process.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SuspendedProcesses")]
            [Validation(Required=false)]
            public List<string> SuspendedProcesses { get; set; }

            /// <summary>
            /// <para>Indicates whether Auto Scaling stops executing any scaling activity in the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Auto Scaling stops executing any scaling activity in the scaling group. This indicates that the scaling group has failed to execute scale-out or scale-in for more than seven consecutive days. You must modify the scaling group or scaling configuration to resume the execution of the scaling activity.</description></item>
            /// <item><description>false: Auto Scaling executes the scaling activity in the scaling group.</description></item>
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
                /// <para>Specifies whether the tag is propagated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Tags on the scaling group are propagated only to newly created instances, but not to existing instances in the scaling group.</description></item>
                /// <item><description>false: Tags on the scaling group are not propagated to instances.</description></item>
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
            /// <para>The total weighted capacity of all ECS instances in the scaling group if instance type weights are configured. Otherwise, this parameter indicates the total number of ECS instances in the scaling group.</para>
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
            /// <para>The list of backend server groups.</para>
            /// </summary>
            [NameInMap("VServerGroups")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupsResponseBodyScalingGroupsVServerGroups> VServerGroups { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsVServerGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the load balancing instance to which the backend server group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>147b46d767c-cn-qingdao-cm5****</para>
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The attributes of the backend server group.</para>
                /// </summary>
                [NameInMap("VServerGroupAttributes")]
                [Validation(Required=false)]
                public List<DescribeScalingGroupsResponseBodyScalingGroupsVServerGroupsVServerGroupAttributes> VServerGroupAttributes { get; set; }
                public class DescribeScalingGroupsResponseBodyScalingGroupsVServerGroupsVServerGroupAttributes : TeaModel {
                    /// <summary>
                    /// <para>The port number used by the load balancing instance to provide services.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>22</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The attributes of the backend server group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rsp-bp12bjrny****</para>
                    /// </summary>
                    [NameInMap("VServerGroupId")]
                    [Validation(Required=false)]
                    public string VServerGroupId { get; set; }

                    /// <summary>
                    /// <para>The weight of the backend server group.</para>
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
            /// <para>The ID of the vSwitch associated with the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1whw2u46cn8zubm****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The collection of IDs of the vSwitches associated with the scaling group. If you use the VSwitchIds parameter, the VSwitchId parameter is ignored.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the scaling group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1vwnn14rqpyiczj****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The number of instances in the warm pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("WarmPoolCapacity")]
            [Validation(Required=false)]
            public int? WarmPoolCapacity { get; set; }

            /// <summary>
            /// <para>The current warm pool configuration of the scaling group.</para>
            /// </summary>
            [NameInMap("WarmPoolConfiguration")]
            [Validation(Required=false)]
            public DescribeScalingGroupsResponseBodyScalingGroupsWarmPoolConfiguration WarmPoolConfiguration { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsWarmPoolConfiguration : TeaModel {
                /// <summary>
                /// <para>The capacity configuration of the warm pool.</para>
                /// </summary>
                [NameInMap("CapacityOptions")]
                [Validation(Required=false)]
                public DescribeScalingGroupsResponseBodyScalingGroupsWarmPoolConfigurationCapacityOptions CapacityOptions { get; set; }
                public class DescribeScalingGroupsResponseBodyScalingGroupsWarmPoolConfigurationCapacityOptions : TeaModel {
                    /// <summary>
                    /// <para>The expected number of pre-warmed instances to cover. The system maintains the sum of the current number of instances in the scaling group and the number of instances in the warm pool at this value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("DesiredGroupPreparedCapacity")]
                    [Validation(Required=false)]
                    public int? DesiredGroupPreparedCapacity { get; set; }

                    /// <summary>
                    /// <para>The minimum number of instances in the warm pool. The system always retains no less than this number of pre-warmed instances in the warm pool to ensure rapid scale-out from the warm pool at any time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MinCapacity")]
                    [Validation(Required=false)]
                    public int? MinCapacity { get; set; }

                }

                /// <summary>
                /// <para>The instance reuse policy.</para>
                /// </summary>
                [NameInMap("InstanceReusePolicy")]
                [Validation(Required=false)]
                public DescribeScalingGroupsResponseBodyScalingGroupsWarmPoolConfigurationInstanceReusePolicy InstanceReusePolicy { get; set; }
                public class DescribeScalingGroupsResponseBodyScalingGroupsWarmPoolConfigurationInstanceReusePolicy : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether instances are returned to the warm pool when the scaling group scales in.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ReuseOnScaleIn")]
                    [Validation(Required=false)]
                    public bool? ReuseOnScaleIn { get; set; }

                }

                /// <summary>
                /// <para>The state of instances in the warm pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Running: The instances are in the running state. Scale-out is faster, but you are charged for the full cost of the instances.</para>
                /// </description></item>
                /// <item><description><para>Stopped: The instances are in the economical mode. You are charged only for resources such as cloud disks, elastic IP addresses (EIPs), and snapshots of the instances. However, instance startup may fail during scale-out due to insufficient inventory.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("PoolState")]
                [Validation(Required=false)]
                public string PoolState { get; set; }

                /// <summary>
                /// <para>The status of the warm pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Active: Active.</para>
                /// </description></item>
                /// <item><description><para>Deleting: Deleting.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The zone shift options.</para>
            /// </summary>
            [NameInMap("ZoneShiftOptions")]
            [Validation(Required=false)]
            public DescribeScalingGroupsResponseBodyScalingGroupsZoneShiftOptions ZoneShiftOptions { get; set; }
            public class DescribeScalingGroupsResponseBodyScalingGroupsZoneShiftOptions : TeaModel {
                /// <summary>
                /// <para>The expiration time of the zone shift. After the expiration time, the system automatically ends the shift and restores the related zones. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDThh:mmZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T12:05Z</para>
                /// </summary>
                [NameInMap("ExpiryTime")]
                [Validation(Required=false)]
                public string ExpiryTime { get; set; }

                /// <summary>
                /// <para>The list of impaired zone IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
                [NameInMap("ImpairedZoneIds")]
                [Validation(Required=false)]
                public List<string> ImpairedZoneIds { get; set; }

                /// <summary>
                /// <para>The behavior policy of the scaling group during the zone shift.</para>
                /// </summary>
                [NameInMap("ZoneShiftPolicy")]
                [Validation(Required=false)]
                public DescribeScalingGroupsResponseBodyScalingGroupsZoneShiftOptionsZoneShiftPolicy ZoneShiftPolicy { get; set; }
                public class DescribeScalingGroupsResponseBodyScalingGroupsZoneShiftOptionsZoneShiftPolicy : TeaModel {
                    /// <summary>
                    /// <para>The health check behavior in impaired zones. Valid values: </para>
                    /// <list type="bullet">
                    /// <item><description>ReplaceUnhealthy: Unhealthy instances in all zones are replaced normally.</description></item>
                    /// <item><description>IgnoreUnhealthy: Unhealthy instances in impaired zones are not replaced. Healthy zones are not affected.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ReplaceUnhealthy</para>
                    /// </summary>
                    [NameInMap("ImpairedZoneHealthCheckBehavior")]
                    [Validation(Required=false)]
                    public string ImpairedZoneHealthCheckBehavior { get; set; }

                    /// <summary>
                    /// <para>Blocks scale-in triggered by specified types of scaling rules. The blocking scope covers all zones under the scaling group, not just the impaired zones. This prevents false scale-in caused by seemingly improved monitoring metrics due to unreachable instances in impaired zones. Valid values: </para>
                    /// <list type="bullet">
                    /// <item><description>StepScalingRule: Blocks scale-in triggered by step scaling rules. </description></item>
                    /// <item><description>TargetTrackingScalingRule: Blocks scale-in triggered by target tracking scaling rules. </description></item>
                    /// <item><description>None: No blocking.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>StepScalingRule</para>
                    /// </summary>
                    [NameInMap("ScaleInBlockedRuleTypes")]
                    [Validation(Required=false)]
                    public List<string> ScaleInBlockedRuleTypes { get; set; }

                    /// <summary>
                    /// <para>Specifies whether scale-out creates instances only in healthy zones during the shift. Valid values: </para>
                    /// <list type="bullet">
                    /// <item><description>true: Scale-out creates instances only in healthy zones and skips impaired zones. </description></item>
                    /// <item><description>false: Scale-out is not restricted by zone and can create instances in any zone under the scaling group.</description></item>
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

        /// <summary>
        /// <para>The total number of scaling groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
