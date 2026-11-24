// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingGroupDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The output details of the ECI scaling group. Currently, only the Kubernetes Deployment YAML format is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: apps/v1
        /// kind: Deployment
        /// metadata:
        ///   name: nginx-deployment
        ///   labels:
        ///     app: nginx
        ///   spec:
        ///     replicas: 3
        ///     selector:
        ///        matchLabels:
        ///         app: nginx
        ///     template:
        ///       metadata:
        ///         labels:
        ///           app: nginx
        ///         annotations:
        ///           k8s.aliyun.com/eip-bandwidth: 10
        ///           k8s.aliyun.com/eci-with-eip: true
        ///         spec:
        ///           containers:
        ///           - name: nginx
        ///             image: nginx:1.14.2
        ///             ports:
        ///             - containerPort: 80</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

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
        /// <para>The Auto Scaling group.</para>
        /// </summary>
        [NameInMap("ScalingGroup")]
        [Validation(Required=false)]
        public DescribeScalingGroupDetailResponseBodyScalingGroup ScalingGroup { get; set; }
        public class DescribeScalingGroupDetailResponseBodyScalingGroup : TeaModel {
            /// <summary>
            /// <para>The number of ECS instances that have been added to the scaling group and are running properly.</para>
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
            /// <para>The information about the Application Load Balancer (ALB) server groups.</para>
            /// </summary>
            [NameInMap("AlbServerGroups")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupDetailResponseBodyScalingGroupAlbServerGroups> AlbServerGroups { get; set; }
            public class DescribeScalingGroupDetailResponseBodyScalingGroupAlbServerGroups : TeaModel {
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
                /// <para>The port number used by the instance after Auto Scaling adds the instance to the ALB server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The weight of the instance as a backend server after Auto Scaling adds the instance to the ALB server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The allocation strategy that determines how the scaling group selects available instance types to meet the capacity requirements. The capacity distribution strategy applies to both pay-as-you-go and spot capacities. This parameter takes effect only when MultiAZPolicy is set to COMPOSABLE. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>priority: Creates instances based on the order of the configured instance types.</description></item>
            /// <item><description>lowestPrice: Creates instances based on the unit price of vCPUs from low to high.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>priority</para>
            /// </summary>
            [NameInMap("AllocationStrategy")]
            [Validation(Required=false)]
            public string AllocationStrategy { get; set; }

            /// <summary>
            /// <para>Specifies whether the capacity of the scaling group is evenly distributed across multiple zones. This parameter takes effect only when MultiAZPolicy is set to COMPOSABLE. Valid values:</para>
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
            /// <para>Specifies whether to automatically create pay-as-you-go instances to meet the required number of ECS instances when the number of spot instances cannot be met due to insufficient inventory or price limits. This parameter takes effect only when MultiAZPolicy is set to COST_OPTIMIZED. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
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
            /// <para>This parameter is not available.</para>
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
            /// <para>null</para>
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
            /// <para>The cooldown time. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("DefaultCooldown")]
            [Validation(Required=false)]
            public int? DefaultCooldown { get; set; }

            /// <summary>
            /// <para>The expected number of instances in the scaling group. The scaling group automatically maintains the number of ECS instances at this expected value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DesiredCapacity")]
            [Validation(Required=false)]
            public int? DesiredCapacity { get; set; }

            /// <summary>
            /// <para>Indicates whether the expected number of instances feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The expected number of instances feature is enabled.</description></item>
            /// <item><description>false: The expected number of instances feature is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableDesiredCapacity")]
            [Validation(Required=false)]
            public bool? EnableDesiredCapacity { get; set; }

            /// <summary>
            /// <para>Specifies whether deletion protection is enabled for the scaling group. Valid values:</para>
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
            /// <para>The type of instances managed by the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ECS: The scaling group manages ECS instances.</description></item>
            /// <item><description>ECI: The scaling group manages ECI instances.</description></item>
            /// </list>
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
            /// <item><description>ECS: Health checks are performed on instances in the scaling group. This value applies to both ECS and Elastic Container Instance (ECI) scaling groups.</description></item>
            /// <item><description>LOAD_BALANCER: The health status of instances is determined based on the health check results of load balancing (the CLB load balancing type is currently not supported).</description></item>
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
            /// <item><description>LOAD_BALANCER: The health status of instances is determined based on the health check results of load balancing (CLB load balancing is currently not supported).</description></item>
            /// </list>
            /// </summary>
            [NameInMap("HealthCheckTypes")]
            [Validation(Required=false)]
            public List<string> HealthCheckTypes { get; set; }

            /// <summary>
            /// <para>The number of instances in the scaling group that are in the initialization state before scale-out.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InitCapacity")]
            [Validation(Required=false)]
            public int? InitCapacity { get; set; }

            /// <summary>
            /// <para>This parameter is not available.</para>
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
            /// <para>The instance type overrides for the launch template.</para>
            /// </summary>
            [NameInMap("LaunchTemplateOverrides")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupDetailResponseBodyScalingGroupLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
            public class DescribeScalingGroupDetailResponseBodyScalingGroupLaunchTemplateOverrides : TeaModel {
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
                /// <para>The maximum price for the spot instance type specified by LaunchTemplateOverride.InstanceType.</para>
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
                /// <para>The weight of the instance type, which indicates the capacity of a single instance of this instance type in the scaling group. A greater weight indicates that fewer instances of this instance type are required to meet the expected capacity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("WeightedCapacity")]
                [Validation(Required=false)]
                public int? WeightedCapacity { get; set; }

            }

            /// <summary>
            /// <para>The version of the launch template.</para>
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
            /// <item><description>Inactive: The scaling group is inactive. Inactive scaling groups do not accept any requests to execute scaling rules.</description></item>
            /// <item><description>Deleting: The scaling group is being deleted. Scaling groups in the Deleting state do not accept any requests to execute scaling rules, and their parameters cannot be modified.</description></item>
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
            public List<DescribeScalingGroupDetailResponseBodyScalingGroupLoadBalancerConfigs> LoadBalancerConfigs { get; set; }
            public class DescribeScalingGroupDetailResponseBodyScalingGroupLoadBalancerConfigs : TeaModel {
                /// <summary>
                /// <para>The ID of the load balancing CLB (formerly SLB) instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-2zein3ytoeq49cmkbyxr0</para>
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The weight of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The IDs of the load balancing instances associated with the scaling group.</para>
            /// </summary>
            [NameInMap("LoadBalancerIds")]
            [Validation(Required=false)]
            public List<string> LoadBalancerIds { get; set; }

            /// <summary>
            /// <para>The maximum lifetime of instances in the scaling group. Unit: seconds.
            /// Valid values: 0 or [86400, Integer.maxValue]. A value of 0 indicates that the MaxInstanceLifetime value is cleared, which means MaxInstanceLifetime is not configured.
            /// Default value: null.</para>
            /// <remarks>
            /// <para>This parameter is not supported for ECI scaling groups or scaling groups that have the economical mode enabled.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("MaxInstanceLifetime")]
            [Validation(Required=false)]
            public int? MaxInstanceLifetime { get; set; }

            /// <summary>
            /// <para>The maximum number of instances in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxSize")]
            [Validation(Required=false)]
            public int? MaxSize { get; set; }

            /// <summary>
            /// <para>The minimum number of instances in the scaling group.</para>
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
            /// <item><description>PRIORITY: Scales instances based on the defined vSwitches (VSwitchIds). If ECS instances cannot be created in the active zone of the vSwitch with the highest priority, the system automatically uses the vSwitch with the next highest priority to create ECS instances.</description></item>
            /// <item><description>COST_OPTIMIZED: Attempts to create instances based on the unit price of vCPUs from low to high. If the scaling configuration settings specify multiple instance types that use the spot billing method, the system preferentially creates spot instances. You can use the CompensateWithOnDemand parameter to specify whether to automatically create pay-as-you-go instances when spot instances cannot be created due to insufficient inventory.<remarks>
            /// <para>COST_OPTIMIZED is active only when the scaling configuration settings specify multiple instance types or use spot instances.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>BALANCE: Evenly allocates ECS instances across the active zones specified for the scaling group. If the distribution across active zones becomes unbalanced due to insufficient inventory, you can call the RebalanceInstance operation to balance the resources.</description></item>
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
            /// <para>The percentage of pay-as-you-go instances to create when the number of instances exceeds the base capacity specified by OnDemandBaseCapacity. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("OnDemandPercentageAboveBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>The number of ECS instances that are being added to the scaling group but have not completed the relevant configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PendingCapacity")]
            [Validation(Required=false)]
            public int? PendingCapacity { get; set; }

            /// <summary>
            /// <para>The number of ECS instances that are in the Pending Wait state in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The scale-in policies used to remove instances from the scaling group.</para>
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
            /// <para>The number of ECS instances that are in the Removing Wait state in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RemovingWaitCapacity")]
            [Validation(Required=false)]
            public int? RemovingWaitCapacity { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the new scaling group belongs.</para>
            /// <remarks>
            /// <para>Assigns the new scaling group to the specified resource group. If this parameter is not specified, the scaling group belongs to the default resource group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2epf32c4uyji</para>
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
            /// <para>The name of the scaling group. The name must be unique within a region. It must be 2 to 64 characters in length and start with a digit, a letter, or a Chinese character. It can contain digits, underscores (_), hyphens (-), and periods (.).</para>
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
            /// <item><description>recycle: The scaling group uses the shutdown reclaim mode.</description></item>
            /// <item><description>release: The scaling group uses the release mode.</description></item>
            /// <item><description>forcerelease: The scaling group uses the force release mode.</description></item>
            /// <item><description>forcerecycle: The scaling group uses the force shutdown reclaim mode.
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
            /// <para>The information about the load balancing server groups.</para>
            /// <remarks>
            /// <para>You can use this parameter to obtain information about the ALB service groups, NLB server groups, and GWLB service groups associated with the scaling group.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ServerGroups")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupDetailResponseBodyScalingGroupServerGroups> ServerGroups { get; set; }
            public class DescribeScalingGroupDetailResponseBodyScalingGroupServerGroups : TeaModel {
                /// <summary>
                /// <para>The port number used by the instance after Auto Scaling adds the instance to the server group.</para>
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
                /// <para>The type of the load balancing server group. Valid values:</para>
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
                /// <para>The weight of the instance as a backend server after Auto Scaling adds the instance to the server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The allocation strategy that determines how the scaling group selects available instance types to meet the capacity requirements. The capacity distribution strategy applies to both pay-as-you-go and spot capacities. This parameter takes effect only when MultiAZPolicy is set to COMPOSABLE. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>priority: Creates instances based on the order of the configured instance types.</description></item>
            /// <item><description>lowestPrice: Creates instances based on the unit price of vCPUs from low to high.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lowestPrice</para>
            /// </summary>
            [NameInMap("SpotAllocationStrategy")]
            [Validation(Required=false)]
            public string SpotAllocationStrategy { get; set; }

            /// <summary>
            /// <para>The number of available instance types. The scaling group creates spot instances of multiple instance types that have the lowest costs and distributes the instances evenly. Valid values: 0 to 10.</para>
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
            /// <para>The number of instances that are in the Standby state in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StandbyCapacity")]
            [Validation(Required=false)]
            public int? StandbyCapacity { get; set; }

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
            /// <para>Specifies whether Auto Scaling stops executing the scaling activity in the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Auto Scaling stops executing the scaling activity in the scaling group. This indicates that the scaling group has failed to execute scale-out and scale-in for more than 7 consecutive days. You must modify the scaling group or scaling configuration to recover the execution of the scaling activity.</para>
            /// </description></item>
            /// <item><description><para>false: Auto Scaling executes the scaling activity in the scaling group.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SystemSuspended")]
            [Validation(Required=false)]
            public bool? SystemSuspended { get; set; }

            /// <summary>
            /// <para>The collection of tags for the scaling group.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupDetailResponseBodyScalingGroupTags> Tags { get; set; }
            public class DescribeScalingGroupDetailResponseBodyScalingGroupTags : TeaModel {
                /// <summary>
                /// <para>Indicates whether the tag is propagated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Tags on the scaling group are propagated only to newly created instances, and not to instances that are already running in the scaling group.</description></item>
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
            /// <para>The total weighted capacity of all instances in the scaling group if instance type weights are configured. Otherwise, this parameter indicates the total number of instances in the scaling group.</para>
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
            public List<DescribeScalingGroupDetailResponseBodyScalingGroupVServerGroups> VServerGroups { get; set; }
            public class DescribeScalingGroupDetailResponseBodyScalingGroupVServerGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the traditional load balancing CLB (formerly SLB) instance to which the virtual server group (virtual service) belongs.</para>
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
                public List<DescribeScalingGroupDetailResponseBodyScalingGroupVServerGroupsVServerGroupAttributes> VServerGroupAttributes { get; set; }
                public class DescribeScalingGroupDetailResponseBodyScalingGroupVServerGroupsVServerGroupAttributes : TeaModel {
                    /// <summary>
                    /// <para>The Server Port of the backend server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The ID of the backend server group.</para>
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
            /// <para>The IDs of the vSwitches associated with the scaling group. If you specify the VSwitchIds parameter, the VSwitchId parameter is ignored.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz9fcq97y1vqkd8bijcq6</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The zone shift options.</para>
            /// </summary>
            [NameInMap("ZoneShiftOptions")]
            [Validation(Required=false)]
            public DescribeScalingGroupDetailResponseBodyScalingGroupZoneShiftOptions ZoneShiftOptions { get; set; }
            public class DescribeScalingGroupDetailResponseBodyScalingGroupZoneShiftOptions : TeaModel {
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
                public DescribeScalingGroupDetailResponseBodyScalingGroupZoneShiftOptionsZoneShiftPolicy ZoneShiftPolicy { get; set; }
                public class DescribeScalingGroupDetailResponseBodyScalingGroupZoneShiftOptionsZoneShiftPolicy : TeaModel {
                    /// <summary>
                    /// <para>The health check behavior in impaired zones. Valid values: </para>
                    /// <list type="bullet">
                    /// <item><description>ReplaceUnhealthy: Unhealthy instances in all zones are replaced as usual. </description></item>
                    /// <item><description>IgnoreUnhealthy: Unhealthy instances in impaired zones are not replaced, while healthy zones are not affected.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ReplaceUnhealthy</para>
                    /// </summary>
                    [NameInMap("ImpairedZoneHealthCheckBehavior")]
                    [Validation(Required=false)]
                    public string ImpairedZoneHealthCheckBehavior { get; set; }

                    /// <summary>
                    /// <para>Blocks scale-in activities triggered by specified types of scaling rules to prevent false scale-in caused by fake improvement of monitoring metrics due to unreachable instances in impaired zones. The blocking scope applies to all zones in the scaling group, not just impaired zones. Valid values: </para>
                    /// <list type="bullet">
                    /// <item><description>StepScalingRule: Blocks scale-in triggered by step scaling rules. </description></item>
                    /// <item><description>TargetTrackingScalingRule: Blocks scale-in triggered by target tracking scaling rules. </description></item>
                    /// <item><description>None: Does not block scale-in.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>StepScalingRule</para>
                    /// </summary>
                    [NameInMap("ScaleInBlockedRuleTypes")]
                    [Validation(Required=false)]
                    public List<string> ScaleInBlockedRuleTypes { get; set; }

                    /// <summary>
                    /// <para>Specifies whether scale-out creates instances only in healthy zones during the zone shift. Valid values: </para>
                    /// <list type="bullet">
                    /// <item><description>true: Scale-out creates instances only in healthy zones and skips impaired zones. </description></item>
                    /// <item><description>false: Scale-out can create instances in any zone under the scaling group without zone restrictions.</description></item>
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

    }

}
