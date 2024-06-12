// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingGroupDetailResponseBody : TeaModel {
        /// <summary>
        /// The output details of the scaling group of the Elastic Container Instance type. Currently, the output is displayed in a Kubernetes Deployment YAML file.
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the scaling groups.
        /// </summary>
        [NameInMap("ScalingGroup")]
        [Validation(Required=false)]
        public DescribeScalingGroupDetailResponseBodyScalingGroup ScalingGroup { get; set; }
        public class DescribeScalingGroupDetailResponseBodyScalingGroup : TeaModel {
            /// <summary>
            /// The number of ECS instances that are in the In Service state in the scaling group.
            /// </summary>
            [NameInMap("ActiveCapacity")]
            [Validation(Required=false)]
            public int? ActiveCapacity { get; set; }

            /// <summary>
            /// The ID of the active scaling configuration in the scaling group.
            /// </summary>
            [NameInMap("ActiveScalingConfigurationId")]
            [Validation(Required=false)]
            public string ActiveScalingConfigurationId { get; set; }

            /// <summary>
            /// The information about the Application Load Balancer (ALB) server groups.
            /// </summary>
            [NameInMap("AlbServerGroups")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupDetailResponseBodyScalingGroupAlbServerGroups> AlbServerGroups { get; set; }
            public class DescribeScalingGroupDetailResponseBodyScalingGroupAlbServerGroups : TeaModel {
                /// <summary>
                /// The ID of the Application Load Balancer (ALB) server group.
                /// </summary>
                [NameInMap("AlbServerGroupId")]
                [Validation(Required=false)]
                public string AlbServerGroupId { get; set; }

                /// <summary>
                /// The port number used by an ECS instance as a backend server in the ALB server group.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The weight of an ECS instance as a backend server in the ALB server group.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// The allocation policy of instances. Auto Scaling selects instance types based on the allocation policy to create the required number of instances. You can apply the policy to pay-as-you-go instances and preemptible instances. This parameter takes effect only if you set `MultiAZPolicy` to `COMPOSABLE`. Valid values:
            /// 
            /// *   priority: Auto Scaling selects instance types based on the specified order to create the required number of instances.
            /// *   lowestPrice: Auto Scaling selects instance types that have the lowest unit price of vCPUs to create the required number of instances.
            /// </summary>
            [NameInMap("AllocationStrategy")]
            [Validation(Required=false)]
            public string AllocationStrategy { get; set; }

            /// <summary>
            /// Indicates whether instances in the scaling group are evenly distributed across zones. This parameter takes effect only if you set `MultiAZPolicy` to `COMPOSABLE`. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("AzBalance")]
            [Validation(Required=false)]
            public bool? AzBalance { get; set; }

            /// <summary>
            /// Indicates whether pay-as-you-go ECS instances can be automatically created to reach the required number of ECS instances when preemptible ECS instances cannot be created due to high prices or insufficient inventory of resources. This parameter takes effect when you set `MultiAZPolicy` to `COST_OPTIMIZED`. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("CompensateWithOnDemand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// The time when the scaling group was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// >  This parameter is not available for use.
            /// </summary>
            [NameInMap("CurrentHostName")]
            [Validation(Required=false)]
            public string CurrentHostName { get; set; }

            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the function that is specified in the custom scale-in policy. This parameter takes effect only if you set the first value of RemovalPolicies to CustomPolicy.
            /// </summary>
            [NameInMap("CustomPolicyARN")]
            [Validation(Required=false)]
            public string CustomPolicyARN { get; set; }

            /// <summary>
            /// The IDs of the ApsaraDB RDS instances that are associated with the scaling group.
            /// </summary>
            [NameInMap("DBInstanceIds")]
            [Validation(Required=false)]
            public List<string> DBInstanceIds { get; set; }

            /// <summary>
            /// The cooldown period of the scaling group. Unit: seconds.
            /// </summary>
            [NameInMap("DefaultCooldown")]
            [Validation(Required=false)]
            public int? DefaultCooldown { get; set; }

            /// <summary>
            /// The expected number of ECS instances in the scaling group. Auto Scaling automatically maintains the expected number of ECS instances.
            /// </summary>
            [NameInMap("DesiredCapacity")]
            [Validation(Required=false)]
            public int? DesiredCapacity { get; set; }

            /// <summary>
            /// Indicates whether the Expected Number of Instances feature is enabled. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("EnableDesiredCapacity")]
            [Validation(Required=false)]
            public bool? EnableDesiredCapacity { get; set; }

            /// <summary>
            /// Indicates whether Deletion Protection is enabled for the scaling group. Valid values:
            /// 
            /// *   true: Deletion Protection is enabled for the scaling group. This way, the scaling group cannot be deleted.
            /// *   false: Deletion Protection is disabled for the scaling group.
            /// </summary>
            [NameInMap("GroupDeletionProtection")]
            [Validation(Required=false)]
            public bool? GroupDeletionProtection { get; set; }

            /// <summary>
            /// The type of the instances that are managed by the scaling group. Valid values:
            /// 
            /// *   ECS: ECS instances
            /// *   ECI: elastic container instances
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// The health check mode of the scaling group. Valid values:
            /// 
            /// *   NONE: Auto Scaling does not perform health checks in the scaling group.
            /// *   ECS: Auto Scaling performs health checks on ECS instances in the scaling group.
            /// </summary>
            [NameInMap("HealthCheckType")]
            [Validation(Required=false)]
            public string HealthCheckType { get; set; }

            /// <summary>
            /// The health check types.
            /// </summary>
            [NameInMap("HealthCheckTypes")]
            [Validation(Required=false)]
            public List<string> HealthCheckTypes { get; set; }

            /// <summary>
            /// The number of instances that are in the Initialized state and not added to the scaling group.
            /// </summary>
            [NameInMap("InitCapacity")]
            [Validation(Required=false)]
            public int? InitCapacity { get; set; }

            /// <summary>
            /// >  This parameter is not available for use.
            /// </summary>
            [NameInMap("IsElasticStrengthInAlarm")]
            [Validation(Required=false)]
            public bool? IsElasticStrengthInAlarm { get; set; }

            /// <summary>
            /// The ID of the launch template that is used by the scaling group.
            /// </summary>
            [NameInMap("LaunchTemplateId")]
            [Validation(Required=false)]
            public string LaunchTemplateId { get; set; }

            /// <summary>
            /// The information about the instance types that are extended in the launch template.
            /// </summary>
            [NameInMap("LaunchTemplateOverrides")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupDetailResponseBodyScalingGroupLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
            public class DescribeScalingGroupDetailResponseBodyScalingGroupLaunchTemplateOverrides : TeaModel {
                /// <summary>
                /// The instance type. The instance type that is specified by using this parameter overwrites the instance type of the launch template.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The maximum bid price of the instance type that is specified by `LaunchTemplateOverride.InstanceType`.
                /// 
                /// >  This parameter takes effect only if you specify `LaunchTemplateId`.
                /// </summary>
                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                /// <summary>
                /// The weight of the instance type. The value of this parameter indicates the capacity of an instance of the specified instance type in the scaling group. A higher weight indicates that a smaller number of instances of the specified instance type are required to meet the expected capacity requirement.
                /// </summary>
                [NameInMap("WeightedCapacity")]
                [Validation(Required=false)]
                public int? WeightedCapacity { get; set; }

            }

            /// <summary>
            /// The version number of the launch template.
            /// </summary>
            [NameInMap("LaunchTemplateVersion")]
            [Validation(Required=false)]
            public string LaunchTemplateVersion { get; set; }

            /// <summary>
            /// The status of the scaling group. Valid values:
            /// 
            /// *   Active: The scaling group is in the Enabled state. Enabled scaling groups can receive requests to execute scaling rules and trigger scaling activities.
            /// *   Inactive: The scaling group is in the Disabled state. Disabled scaling groups cannot receive requests to execute scaling rules.
            /// *   Deleting: The scaling group is being deleted. Scaling groups that are being deleted cannot receive requests to execute scaling rules, and the parameter settings of the scaling groups cannot be modified.
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// The CLB configurations.
            /// </summary>
            [NameInMap("LoadBalancerConfigs")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupDetailResponseBodyScalingGroupLoadBalancerConfigs> LoadBalancerConfigs { get; set; }
            public class DescribeScalingGroupDetailResponseBodyScalingGroupLoadBalancerConfigs : TeaModel {
                /// <summary>
                /// The ID of the CLB instance.
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// The weight of a backend server.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// The IDs of the SLB instances that are associated with the scaling group.
            /// </summary>
            [NameInMap("LoadBalancerIds")]
            [Validation(Required=false)]
            public List<string> LoadBalancerIds { get; set; }

            /// <summary>
            /// The maximum life span of an instance in the scaling group. Unit: seconds.
            /// 
            /// Valid values: 0 or from 86400 to `Integer.maxValue`. A value of 0 for MaxInstanceLifetime indicates that any previously set limit has been removed, which effectively disables the maximum instance lifetime constraint.
            /// 
            /// Default value: null.
            /// 
            /// >  This parameter is not supported by scaling groups of the Elastic Container Instance type and scaling groups whose ScalingPolicy is set to Recycle.
            /// </summary>
            [NameInMap("MaxInstanceLifetime")]
            [Validation(Required=false)]
            public int? MaxInstanceLifetime { get; set; }

            /// <summary>
            /// The maximum number of ECS instances that can be contained in the scaling group.
            /// </summary>
            [NameInMap("MaxSize")]
            [Validation(Required=false)]
            public int? MaxSize { get; set; }

            /// <summary>
            /// The minimum number of ECS instances that must be contained in the scaling group.
            /// </summary>
            [NameInMap("MinSize")]
            [Validation(Required=false)]
            public int? MinSize { get; set; }

            /// <summary>
            /// The time when the scaling group was modified.
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// The ID of the CloudMonitor application group that is associated with the scaling group.
            /// </summary>
            [NameInMap("MonitorGroupId")]
            [Validation(Required=false)]
            public string MonitorGroupId { get; set; }

            /// <summary>
            /// The scaling policy of the ECS instances in the multi-zone scaling group. Valid values:
            /// 
            /// *   PRIORITY: ECS instances are created based on the value of VSwitchIds. If Auto Scaling cannot create ECS instances in the zone where the vSwitch of the highest priority resides, Auto Scaling creates ECS instances in the zone where the vSwitch of the next highest priority resides.
            /// 
            /// *   COST_OPTIMIZED: ECS instances are created based on the unit prices of their vCPUs. Auto Scaling preferentially creates ECS instances that use the lowest-priced vCPUs. If preemptible instance types are specified in the scaling configuration, Auto Scaling preferentially creates preemptible instances. You can also specify CompensateWithOnDemand to allow Auto Scaling to create pay-as-you-go instances in the case that preemptible instances cannot be created due to insufficient inventory of preemptible instance types.
            /// 
            ///     **
            /// 
            ///     **Note** The COST_OPTIMIZED setting takes effect only if you specified multiple instance types or preemptible instance types in your scaling configuration.
            /// 
            /// *   BALANCE: ECS instances are evenly distributed across the zones of the scaling group. If ECS instance are unevenly distributed across the specified zones due to insufficient inventory of instance types, you can call the RebalanceInstance operation to rebalance the distribution of the ECS instances.
            /// </summary>
            [NameInMap("MultiAZPolicy")]
            [Validation(Required=false)]
            public string MultiAZPolicy { get; set; }

            /// <summary>
            /// The minimum number of pay-as-you-go instances that must be contained in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances in the scaling group is less than the value of this parameter, Auto Scaling preferentially creates pay-as-you-go instances.
            /// </summary>
            [NameInMap("OnDemandBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// The percentage of pay-as-you-go instances among the excess instances when the minimum number of pay-as-you-go instances reaches the requirement. Valid values: 0 to 100.
            /// </summary>
            [NameInMap("OnDemandPercentageAboveBaseCapacity")]
            [Validation(Required=false)]
            public int? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// The number of ECS instances that are being added to the scaling group and configured.
            /// </summary>
            [NameInMap("PendingCapacity")]
            [Validation(Required=false)]
            public int? PendingCapacity { get; set; }

            /// <summary>
            /// The number of ECS instances that are in the Pending Add state in the scaling group.
            /// </summary>
            [NameInMap("PendingWaitCapacity")]
            [Validation(Required=false)]
            public int? PendingWaitCapacity { get; set; }

            /// <summary>
            /// The number of ECS instances that are in the Protected state in the scaling group.
            /// </summary>
            [NameInMap("ProtectedCapacity")]
            [Validation(Required=false)]
            public int? ProtectedCapacity { get; set; }

            /// <summary>
            /// The region ID of the scaling group.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The instance removal policies.
            /// </summary>
            [NameInMap("RemovalPolicies")]
            [Validation(Required=false)]
            public List<string> RemovalPolicies { get; set; }

            /// <summary>
            /// The number of ECS instances that are being removed from the scaling group.
            /// </summary>
            [NameInMap("RemovingCapacity")]
            [Validation(Required=false)]
            public int? RemovingCapacity { get; set; }

            /// <summary>
            /// The number of ECS instances that are in the Pending Remove state in the scaling group.
            /// </summary>
            [NameInMap("RemovingWaitCapacity")]
            [Validation(Required=false)]
            public int? RemovingWaitCapacity { get; set; }

            /// <summary>
            /// The ID of the resource group to which the scaling group belongs.
            /// 
            /// >  If you specify this parameter, new scaling groups are added to the specified resource group. If you do not specify this parameter, new scaling groups are added to the default resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The ID of the scaling group.
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// The name of the scaling group. The name of each scaling group must be unique in a region.
            /// 
            /// The name must be 2 to 64 characters in length, and can contain letters, digits, underscores (_), hyphens (-), and periods (.). It must start with a letter or digit.
            /// </summary>
            [NameInMap("ScalingGroupName")]
            [Validation(Required=false)]
            public string ScalingGroupName { get; set; }

            /// <summary>
            /// The reclaim mode of the scaling group. Valid values:
            /// 
            /// *   recycle: economical mode
            /// *   release: release mode
            /// *   forcerelease: forced release mode
            /// *   forcerecycle: forced recycle mode
            /// 
            /// For more information, see [RemoveInstances](https://help.aliyun.com/document_detail/25955.html).
            /// </summary>
            [NameInMap("ScalingPolicy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            /// <summary>
            /// The information about the server groups.
            /// 
            /// >  You can use this parameter to obtain information about ALB server groups and Network Load Balancer (NLB) server groups attached to your scaling group.
            /// </summary>
            [NameInMap("ServerGroups")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupDetailResponseBodyScalingGroupServerGroups> ServerGroups { get; set; }
            public class DescribeScalingGroupDetailResponseBodyScalingGroupServerGroups : TeaModel {
                /// <summary>
                /// The port number used by an ECS instance as a backend server in the server group.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The ID of the server group.
                /// </summary>
                [NameInMap("ServerGroupId")]
                [Validation(Required=false)]
                public string ServerGroupId { get; set; }

                /// <summary>
                /// The type of the server group. Valid values:
                /// 
                /// *   ALB
                /// *   NLB
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The weight of an ECS instance as a backend server in the server group.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// The allocation policy of preemptible instances. Auto Scaling selects instance types based on the allocation policy to create the required number of preemptible instances. You can apply the policy to pay-as-you-go instances and preemptible instances. This parameter takes effect only if you set `MultiAZPolicy` to `COMPOSABLE`. Valid values:
            /// 
            /// *   priority: Auto Scaling selects instance types based on the specified order to create the required number of preemptible instances.
            /// *   lowestPrice: Auto Scaling selects instance types that have the lowest unit price of vCPUs to create the required number of preemptible instances.
            /// </summary>
            [NameInMap("SpotAllocationStrategy")]
            [Validation(Required=false)]
            public string SpotAllocationStrategy { get; set; }

            /// <summary>
            /// The number of instance types that are specified. Preemptible instances of multiple lowest-priced instance types are evenly distributed across the zones of the scaling group. Valid values: 0 to 10.
            /// </summary>
            [NameInMap("SpotInstancePools")]
            [Validation(Required=false)]
            public int? SpotInstancePools { get; set; }

            /// <summary>
            /// Indicates whether preemptible instances can be supplemented. If this parameter is set to true, Auto Scaling creates an instance to replace a preemptible instance when Auto Scaling receives the system message which indicates that the preemptible instance is to be reclaimed.
            /// </summary>
            [NameInMap("SpotInstanceRemedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// The number of ECS instances that are in the Standby state in the scaling group.
            /// </summary>
            [NameInMap("StandbyCapacity")]
            [Validation(Required=false)]
            public int? StandbyCapacity { get; set; }

            /// <summary>
            /// The number of instances that are stopped in Economical Mode in the scaling group.
            /// </summary>
            [NameInMap("StoppedCapacity")]
            [Validation(Required=false)]
            public int? StoppedCapacity { get; set; }

            /// <summary>
            /// The processes that are suspended. If no process is suspended, null is returned. Valid values:
            /// 
            /// *   ScaleIn: scale-in
            /// *   ScaleOut: scale-out
            /// *   HealthCheck: health check
            /// *   AlarmNotification: event-triggered task
            /// *   ScheduledAction: scheduled task
            /// </summary>
            [NameInMap("SuspendedProcesses")]
            [Validation(Required=false)]
            public List<string> SuspendedProcesses { get; set; }

            /// <summary>
            /// Indicates whether Auto Scaling stops executing scaling activities in the scaling group. Valid values:
            /// 
            /// *   true: Auto Scaling stops executing scaling activities in the scaling group if the scaling activities failed for more than seven consecutive days in the scaling group. You must modify the scaling group or scaling configuration to resume the execution of the scaling activities.
            /// *   false: Auto Scaling does not stop executing scaling activities in the scaling group.
            /// </summary>
            [NameInMap("SystemSuspended")]
            [Validation(Required=false)]
            public bool? SystemSuspended { get; set; }

            /// <summary>
            /// The tags of the scaling group.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupDetailResponseBodyScalingGroupTags> Tags { get; set; }
            public class DescribeScalingGroupDetailResponseBodyScalingGroupTags : TeaModel {
                /// <summary>
                /// Indicates whether the tags of the scaling group can be propagated to instances. Valid values:
                /// 
                /// *   true: The tags of the scaling group can be propagated to only instances that are newly created.
                /// *   false: The tags of the scaling group cannot be propagated to any instances.
                /// 
                /// Default value: false.
                /// </summary>
                [NameInMap("Propagate")]
                [Validation(Required=false)]
                public bool? Propagate { get; set; }

                /// <summary>
                /// The tag key of the scaling group.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value of the scaling group.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The total weighted capacity of all ECS instances in the scaling group if Weighted is specified. In other cases, the value of this parameter indicates the total number of ECS instances in the scaling group.
            /// </summary>
            [NameInMap("TotalCapacity")]
            [Validation(Required=false)]
            public int? TotalCapacity { get; set; }

            /// <summary>
            /// The total number of Elastic Compute Service (ECS) instances in the scaling group.
            /// </summary>
            [NameInMap("TotalInstanceCount")]
            [Validation(Required=false)]
            public int? TotalInstanceCount { get; set; }

            /// <summary>
            /// The backend vServer groups.
            /// </summary>
            [NameInMap("VServerGroups")]
            [Validation(Required=false)]
            public List<DescribeScalingGroupDetailResponseBodyScalingGroupVServerGroups> VServerGroups { get; set; }
            public class DescribeScalingGroupDetailResponseBodyScalingGroupVServerGroups : TeaModel {
                /// <summary>
                /// The ID of the Classic Load Balancer (CLB, formerly known as Server Load Balancer or SLB) instance to which the backend vServer group belongs.
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// The attributes of the backend vServer group.
                /// </summary>
                [NameInMap("VServerGroupAttributes")]
                [Validation(Required=false)]
                public List<DescribeScalingGroupDetailResponseBodyScalingGroupVServerGroupsVServerGroupAttributes> VServerGroupAttributes { get; set; }
                public class DescribeScalingGroupDetailResponseBodyScalingGroupVServerGroupsVServerGroupAttributes : TeaModel {
                    /// <summary>
                    /// The port number of a backend vServer.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The ID of the backend vServer group.
                    /// </summary>
                    [NameInMap("VServerGroupId")]
                    [Validation(Required=false)]
                    public string VServerGroupId { get; set; }

                    /// <summary>
                    /// The weight of the backend vServer group.
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

            }

            /// <summary>
            /// The vSwitch ID of the scaling group.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The IDs of the vSwitches that are associated with the scaling group. If you specify VSwitchIds, VSwitchId is ignored.
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// The virtual private cloud (VPC) ID of the scaling group.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
