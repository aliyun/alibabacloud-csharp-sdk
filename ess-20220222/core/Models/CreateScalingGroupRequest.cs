// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateScalingGroupRequest : TeaModel {
        /// <summary>
        /// The Application Load Balancer (ALB) server groups.
        /// </summary>
        [NameInMap("AlbServerGroups")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestAlbServerGroups> AlbServerGroups { get; set; }
        public class CreateScalingGroupRequestAlbServerGroups : TeaModel {
            /// <summary>
            /// The ID of the ALB server group.
            /// 
            /// You can attach only a limited number of ALB server groups to a scaling group. To view the predefined quota limit or manually request a quota increase, go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas).
            /// </summary>
            [NameInMap("AlbServerGroupId")]
            [Validation(Required=false)]
            public string AlbServerGroupId { get; set; }

            /// <summary>
            /// The port number used by each ECS instance as a backend server in the ALB server group. Valid values: 1 to 65535.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The weight of an ECS instance as a backend server in the ALB server group. If you increase the weight for an ECS instance, the number of requests that are forwarded to the ECS instance also increases. If you set the weight for an ECS instance to 0, no requests are forwarded to the ECS instance. Valid values: 0 to 100.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// The allocation policy of instances. Auto Scaling selects instance types based on the allocation policy to create the required number of instances. The policy can be applied to pay-as-you-go instances and preemptible instances. This parameter takes effect only when you set the `MultiAZPolicy` parameter to `COMPOSABLE`. Valid values:
        /// 
        /// *   priority: Auto Scaling selects instance types based on the specified order of the instance types to create the required number of instances.
        /// *   lowestPrice: Auto Scaling selects instance types that have the lowest unit price of vCPUs to create the required number of instances.
        /// 
        /// Default value: priority.
        /// </summary>
        [NameInMap("AllocationStrategy")]
        [Validation(Required=false)]
        public string AllocationStrategy { get; set; }

        /// <summary>
        /// Specifies whether to evenly distribute instances in the scaling group across multiple zones. This parameter takes effect only if you set `MultiAZPolicy` to `COMPOSABLE`. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// >  If you set `MultiAZPolicy` to `COMPOSABLE` and enable `AzBalance` to `true`, this setting has an equivalent effect to setting `MultiAZPolicy` to `BALANCE`.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("AzBalance")]
        [Validation(Required=false)]
        public bool? AzBalance { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [Ensure idempotence](https://help.aliyun.com/document_detail/25965.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to automatically create pay-as-you-go instances to meet the requirement on the number of ECS instances when the expected capacity of preemptible instances cannot be provided due to reasons such as cost-related issues and insufficient resources. This parameter is available only if you set the MultiAZPolicy parameter to COST_OPTIMIZED. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: true.
        /// </summary>
        [NameInMap("CompensateWithOnDemand")]
        [Validation(Required=false)]
        public bool? CompensateWithOnDemand { get; set; }

        /// <summary>
        /// The ID of the elastic container instance.
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the custom scale-in policy (Function). This parameter is available only if you specify CustomPolicy as the first step to remove instances.
        /// </summary>
        [NameInMap("CustomPolicyARN")]
        [Validation(Required=false)]
        public string CustomPolicyARN { get; set; }

        /// <summary>
        /// The IDs of the ApsaraDB RDS instances that you want to associate with the scaling group. The value can be a JSON array that contains multiple ApsaraDB RDS instance IDs. Separate multiple IDs with commas (,).
        /// 
        /// You can associate only a limited number of ApsaraDB RDS instances with a scaling group. Go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas) to check the maximum number of ApsaraDB RDS instances that you can associate with a scaling group.
        /// </summary>
        [NameInMap("DBInstanceIds")]
        [Validation(Required=false)]
        public string DBInstanceIds { get; set; }

        /// <summary>
        /// The databases that you want to attach to the scaling group.
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestDBInstances> DBInstances { get; set; }
        public class CreateScalingGroupRequestDBInstances : TeaModel {
            /// <summary>
            /// The mode in which you want to attach the database to the scaling group. Valid values:
            /// 
            /// *   SecurityIp: the mode in which Auto Scaling automatically adds the private IP addresses of ECS instances to the IP address whitelist of the database during scale-out events. You can set the value to SecurityIp only if you set Type to RDS.
            /// *   SecurityGroup: the mode in which Auto Scaling adds the security group of the applied scaling configuration to the security group whitelist of the database. This setting allows ECS instances created from the scaling configuration to access the database.
            /// </summary>
            [NameInMap("AttachMode")]
            [Validation(Required=false)]
            public string AttachMode { get; set; }

            /// <summary>
            /// The database ID.
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// The database type. Valid values:
            /// 
            /// *   RDS
            /// *   Redis
            /// *   MongoDB
            /// 
            /// Default value: RDS.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The cooldown period of the scaling group after a scaling activity is complete in the scaling group. Valid values: 0 to 86400. Unit: seconds.
        /// 
        /// During the cooldown period, Auto Scaling does not execute scaling activities that are triggered by CloudMonitor event-triggered tasks.
        /// 
        /// Default value: 300.
        /// </summary>
        [NameInMap("DefaultCooldown")]
        [Validation(Required=false)]
        public int? DefaultCooldown { get; set; }

        /// <summary>
        /// The expected number of ECS instances in the scaling group. Auto Scaling automatically maintains the specified expected number of ECS instances. The DesiredCapacity value cannot be greater than the MaxSize value or less than the MinSize value.
        /// </summary>
        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public int? DesiredCapacity { get; set; }

        /// <summary>
        /// Specifies whether to enable deletion protection for the scaling group. Valid values:
        /// 
        /// *   true: enables deletion protection for the scaling group. This way, the scaling group cannot be deleted.
        /// *   false: disables deletion protection for the scaling group.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("GroupDeletionProtection")]
        [Validation(Required=false)]
        public bool? GroupDeletionProtection { get; set; }

        /// <summary>
        /// The type of the instances that are managed by the scaling group. Valid values:
        /// 
        /// *   ECS: ECS instances.
        /// *   ECI: elastic container instances.
        /// 
        /// Default value: ECS.
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The health check mode of the scaling group. Valid values:
        /// 
        /// *   NONE: Auto Scaling does not check the health status of instances.
        /// *   ECS: Auto Scaling checks the health status of ECS instances in the scaling group.
        /// *   ECI: Auto Scaling checks the health status of elastic container instances in the scaling group.
        /// *   LOAD_BALANCER: Auto Scaling checks the health status of instances in the scaling group based on the health check results of load balancers. The health check results of CLB instances are not supported as the health check basis for instances in the scaling group.
        /// 
        /// Default value: ECS.
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// The health check modes of the scaling group. Valid values:
        /// 
        /// *   NONE: Auto Scaling does not check the health status of instances.
        /// *   ECS: Auto Scaling checks the health status of ECS instances in the scaling group.
        /// *   ECI: Auto Scaling checks the health status of elastic container instances in the scaling group.
        /// *   LOAD_BALANCER: Auto Scaling checks the health status of instances based on the health check results of load balancers. The health check results of CLB instances are not supported as the health check basis for instances in the scaling group.
        /// 
        /// >  HealthCheckTypes has the same effect as `HealthCheckType`. You can select one of them to specify based on your business requirements. If you specify `HealthCheckType`, `HealthCheckTypes` is ignored. HealthCheckTypes is optional.
        /// 
        /// Default value: ECS.
        /// </summary>
        [NameInMap("HealthCheckTypes")]
        [Validation(Required=false)]
        public List<string> HealthCheckTypes { get; set; }

        /// <summary>
        /// The ID of the ECS instance. When you create a scaling group, you can specify an existing ECS instance. Auto Scaling obtains the configurations of the ECS instance and automatically creates a scaling configuration from the obtained configurations.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the launch template that provides instance configurations for Auto Scaling to create instances.
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// Details of the instance types that you specify by using the Extended Configurations feature of the launch template.
        /// </summary>
        [NameInMap("LaunchTemplateOverrides")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestLaunchTemplateOverrides> LaunchTemplateOverrides { get; set; }
        public class CreateScalingGroupRequestLaunchTemplateOverrides : TeaModel {
            /// <summary>
            /// The instance type that you want to use to override the instance type that is specified in the launch template.
            /// 
            /// If you want to scale instances based on the weighted capacities of the instances, you must specify both the InstanceType and WeightedCapacity parameters.
            /// 
            /// > This parameter is available only if you specify the LaunchTemplateId parameter.
            /// 
            /// You can use the InstanceType parameter to specify only instance types that are available for purchase.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The maximum bid price of the instance type that is specified by the `InstanceType` parameter. You can specify 1 to 10 instance types by using the Extended Configurations feature of the launch template.
            /// 
            /// > This parameter is available only if you specify the `LaunchTemplateId` parameter.
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

            /// <summary>
            /// The weight of the instance type. The weight specifies the capacity of an instance of the specified instance type in the scaling group. If you want to scale instances based on the weighted capacities of the instances, you must specify the WeightedCapacity parameter after you specify the InstanceType parameter.
            /// 
            /// A higher weight specifies that a smaller number of instances of the specified instance type are required to meet the expected capacity requirement.
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
            /// > The capacity of the scaling group cannot exceed the sum of the maximum number of instances that is specified by the MaxSize parameter and the maximum weight of the instance types.
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
        /// *   Default: the default template version.
        /// *   Latest: the latest template version.
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public string LaunchTemplateVersion { get; set; }

        /// <summary>
        /// The lifecycle hooks.
        /// </summary>
        [NameInMap("LifecycleHooks")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestLifecycleHooks> LifecycleHooks { get; set; }
        public class CreateScalingGroupRequestLifecycleHooks : TeaModel {
            /// <summary>
            /// The action that Auto Scaling performs when the lifecycle hook times out. Valid values:
            /// 
            /// *   CONTINUE: Auto Scaling continues to respond to a scale-in or scale-out request.
            /// *   ABANDON: Auto Scaling releases ECS instances that are created during scale-out events, or removes ECS instances from the scaling group during scale-in events.
            /// 
            /// If multiple lifecycle hooks in the scaling group are triggered during scale-in events, and you set DefaultResult to ABANDON for one of the lifecycle hooks, Auto Scaling immediately performs the action after the lifecycle hook whose DefaultResult is set to ABANDON times out. In this case, other lifecycle hooks time out ahead of schedule. In other cases, Auto Scaling performs the action only after all lifecycle hooks time out. The action that Auto Scaling performs is determined by the value of DefaultResult that you specify for the lifecycle hook that most recently times out.
            /// 
            /// Default value: CONTINUE.
            /// </summary>
            [NameInMap("DefaultResult")]
            [Validation(Required=false)]
            public string DefaultResult { get; set; }

            /// <summary>
            /// The period of time before the lifecycle hook times out. When the lifecycle hook times out, Auto Scaling performs the action that is specified by DefaultResult. Valid values: 30 to 21600. Unit: seconds.
            /// 
            /// After you create a lifecycle hook, you can call the RecordLifecycleActionHeartbeat operation to extend the timeout period of the lifecycle hook. You can also call the CompleteLifecycleAction operation to end the timeout period of the lifecycle hook ahead of scheduled.
            /// 
            /// Default value: 600.
            /// </summary>
            [NameInMap("HeartbeatTimeout")]
            [Validation(Required=false)]
            public int? HeartbeatTimeout { get; set; }

            /// <summary>
            /// The name of the lifecycle hook. After you specify this parameter, you cannot change the name of the lifecycle hook. If you do not specify this parameter, the name of the lifecycle hook is the same as the ID of the lifecycle hook.
            /// </summary>
            [NameInMap("LifecycleHookName")]
            [Validation(Required=false)]
            public string LifecycleHookName { get; set; }

            /// <summary>
            /// The type of the scaling activity to which you want to apply the lifecycle hook. Valid values:
            /// 
            /// *   SCALE_OUT
            /// *   SCALE_IN
            /// 
            /// >  If you specify lifecycle hooks for the scaling group, you must specify LifecycleTransition. Other parameters are optional.
            /// </summary>
            [NameInMap("LifecycleTransition")]
            [Validation(Required=false)]
            public string LifecycleTransition { get; set; }

            /// <summary>
            /// The identifier of the notification recipient party when the lifecycle hook takes effect. You can specify a Message Service (MNS) topic or queue as the notification recipient party. Specify the value in the acs:ess:{region}:{account-id}:{resource-relative-id} format.
            /// 
            /// *   region: the region ID of the scaling group
            /// *   account-id: the ID of your Alibaba Cloud account.
            /// 
            /// Examples:
            /// 
            /// *   MNS queue: acs:ess:{region}:{account-id}:queue/{queuename}
            /// *   MNS topic: acs:ess:{region}:{account-id}:topic/{topicname}
            /// </summary>
            [NameInMap("NotificationArn")]
            [Validation(Required=false)]
            public string NotificationArn { get; set; }

            /// <summary>
            /// The fixed string that you want to include in a notification. When a lifecycle hook takes effect, Auto Scaling sends a notification. The fixed string can contain up to 4,096 characters in length. When Auto Scaling sends a notification to the recipient party, it includes predefined notification metadata into the notification. This helps in managing and labeling notifications of different categories. notificationmetadata takes effect only if you specify notificationarn.
            /// </summary>
            [NameInMap("NotificationMetadata")]
            [Validation(Required=false)]
            public string NotificationMetadata { get; set; }

        }

        /// <summary>
        /// The load balancer configurations.
        /// </summary>
        [NameInMap("LoadBalancerConfigs")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestLoadBalancerConfigs> LoadBalancerConfigs { get; set; }
        public class CreateScalingGroupRequestLoadBalancerConfigs : TeaModel {
            /// <summary>
            /// The ID of the CLB instance.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// The weight of each ECS instance as a backend server in the CLB backend server group. If you increase the weight for an ECS instance, the number of requests that are forwarded to the ECS instance also increases. If you set the weight for an ECS instance to 0, no requests are forwarded to the ECS instance. Valid values: 0 to 100.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// The IDs of the CLB instances that you want to associate with the scaling group. The value can be a JSON array that contains multiple CLB instance IDs. Separate multiple IDs with commas (,).
        /// 
        /// You can associate only a limited number of CLB instances with a scaling group. Go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas) to check the maximum number of CLB instances that you can associate with a scaling group.
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public string LoadBalancerIds { get; set; }

        /// <summary>
        /// The maximum life span of an instance in the scaling group. Unit: seconds.
        /// 
        /// Valid values: 86400 to the value of the Integer.maxValue parameter.
        /// 
        /// Default value: null.
        /// </summary>
        [NameInMap("MaxInstanceLifetime")]
        [Validation(Required=false)]
        public int? MaxInstanceLifetime { get; set; }

        /// <summary>
        /// The maximum number of instances that can be contained in the scaling group. When the total number of ECS instances in the scaling group exceeds the value of MaxSize, Auto Scaling automatically removes ECS instances from the scaling group until the total number equals the maximum number.
        /// 
        /// The value range of MaxSize is directly correlated with the degree of dependency your business has on Auto Scaling. You can go to [Quota Center](https://quotas.console.aliyun.com/products/ess/quotas) to check **the maximum number of instances that a single scaling group can contain.**
        /// 
        /// If **a single scaling group can contain up to 2,000 ECS instances**, the value range of MaxSize is 0 to 2,000.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public int? MaxSize { get; set; }

        /// <summary>
        /// The minimum number of instances that must be contained in the scaling group. When the total number of ECS instances in the scaling group is less than the value of MinSize, Auto Scaling automatically creates ECS instances in the scaling group until the total number reaches the minimum number.
        /// 
        /// >  The value of MinSize must be less than or equal to the value of MaxSize.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MinSize")]
        [Validation(Required=false)]
        public int? MinSize { get; set; }

        /// <summary>
        /// The scaling policy for ECS instances in the multi-zone scaling group. Valid values:
        /// 
        /// *   PRIORITY: scale ECS instances based on the priority of the vSwitches specified by VSwitchIds. Auto Scaling preferentially scales instances in the zone where the vSwitch of the highest priority resides. If the scaling fails, Auto Scaling scales instances in the zone where the vSwitch of the next highest priority resides.
        /// 
        /// *   COST_OPTIMIZED: create ECS instances that have the lowest unit price of vCPUs during scale-out events and removes ECS instances that have the highest unit price of vCPUs during scale-in events. If you specify preemptible instance types in your scaling configuration, Auto Scaling will preferentially create preemptible instances. You can also specify CompensateWithOnDemand to allow Auto Scaling to create pay-as-you-go instances in the case that preemptible instances cannot be created due to limited stock.
        /// 
        ///     **
        /// 
        ///     **Note** The COST_OPTIMIZED setting takes effect only when your scaling configuration contains multiple instance types or specifically contains preemptible instance types.
        /// 
        /// *   BALANCE: evenly distribute ECS instances across the zones that are specified for the scaling group. If ECS instances are unevenly distributed across the specified zones due to insufficient inventory, you can call the [RebalanceInstance](https://help.aliyun.com/document_detail/71516.html) operation to evenly distribute the instances across the zones.
        /// 
        ///     **
        /// 
        ///     **Note** When you set `MultiAZPolicy` to `BALANCE`, this setting has an equivalent effect to setting `MultiAZPolicy` to `COMPOSABLE` and enabling `AzBalance` to `true`.
        /// 
        /// *   COMPOSABLE: combine the preceding policies into a custom scaling policy based on your business requirements. Alternatively, you can specify custom parameters to finely control the capacity of the scaling group.
        /// 
        /// Default value: PRIORITY.
        /// </summary>
        [NameInMap("MultiAZPolicy")]
        [Validation(Required=false)]
        public string MultiAZPolicy { get; set; }

        /// <summary>
        /// The minimum number of pay-as-you-go instances that must be contained in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is less than the value of this parameter, Auto Scaling preferentially creates pay-as-you-go instances.
        /// </summary>
        [NameInMap("OnDemandBaseCapacity")]
        [Validation(Required=false)]
        public int? OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// The percentage of pay-as-you-go instances in the excess instances when the minimum number of pay-as-you-go instances reaches the requirement. Valid values: 0 to 100.
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
        /// The region ID of the scaling group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The instance removal policies. Valid values:
        /// 
        /// *   OldestInstance: removes ECS instances that are added at the earliest point in time to the scaling group.
        /// *   NewestInstance: removes ECS instances that are most recently added to the scaling group.
        /// *   OldestScalingConfiguration: removes ECS instances that are created based on the earliest scaling configuration.
        /// *   CustomPolicy: removes ECS instances based on the custom scale-in policy (Function).
        /// 
        /// The scaling configuration source specified by the OldestScalingConfiguration setting can be a scaling configuration or a launch template. The CustomPolicy setting takes effect only if you specify it as the first step to remove instances. If you specify CustomPolicy, you must also specify the CustomPolicyARN parameter.
        /// 
        /// > The removal of ECS instances from a scaling group is also affected by the value of the MultiAZPolicy parameter. For more information, see the [Configure a combination policy for removing instances](https://help.aliyun.com/document_detail/254822.html) topic.
        /// </summary>
        [NameInMap("RemovalPolicies")]
        [Validation(Required=false)]
        public List<string> RemovalPolicies { get; set; }

        /// <summary>
        /// The ID of the resource group to which you want to add the scaling group.
        /// 
        /// > If you specify this parameter, new scaling groups are added to the specified resource group. If you do not specify this parameter, new scaling groups are added to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The name of the scaling group. The name of each scaling group must be unique in a region.
        /// 
        /// The name must be 2 to 64 characters in length, and can contain letters, digits, underscores (_), hyphens (-), and periods (.). The name must start with a letter or a digit.
        /// 
        /// If you do not specify this parameter, the value of the ScalingGroupId parameter is used.
        /// </summary>
        [NameInMap("ScalingGroupName")]
        [Validation(Required=false)]
        public string ScalingGroupName { get; set; }

        /// <summary>
        /// The reclaim mode of the scaling group. Valid values:
        /// 
        /// *   recycle: the economical mode
        /// 
        /// *   release: the release mode
        /// 
        /// *   forcerelease: the forced release mode
        /// 
        ///     **
        /// 
        ///     **Note** If you set the value to forcerelease, Auto Scaling will forcibly release the ECS instances that are in the `Running` state during the scale-out events. Forced release equates to an immediate power-off, resulting in the irreversible deletion of all ephemeral data stored on the instance. Once executed, this action cannot be undone and the lost data cannot be recovered. Exercise caution when you select this option.
        /// 
        /// *   forcerecycle: the forced recycle mode
        /// 
        ///     **
        /// 
        ///     **Note** If you set the value to forcerecycle, Auto Scaling will forcibly shut down the ECS instances that are in the `Running` state during the scale-out events. Forced recycle equates to an immediate power-off, resulting in the irreversible deletion of all ephemeral data stored on the instance. Once executed, this action cannot be undone and the lost data cannot be recovered. Exercise caution when you select this option.
        /// 
        /// ScalingPolicy specifies the reclaim mode of the scaling group. RemovePolicy of the RemoveInstances operation specifies the specific instance removal action. For more information, see [RemoveInstances](https://help.aliyun.com/document_detail/25955.html).
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public string ScalingPolicy { get; set; }

        /// <summary>
        /// The server groups.
        /// 
        /// >  You cannot use AlbServerGroups and ServerGroups to specify the same server group.
        /// </summary>
        [NameInMap("ServerGroups")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestServerGroups> ServerGroups { get; set; }
        public class CreateScalingGroupRequestServerGroups : TeaModel {
            /// <summary>
            /// The port number used by each ECS instance as backend server in the vServer group. Valid values: 1 to 65535.
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
            /// The weight of each ECS instance as a backend server in the server group. Valid values: 0 to 100.
            /// 
            /// If you increase the weight for an ECS instance, the number of requests that are forwarded to the ECS instance also increases. If you set the weight for an ECS instance to 0, no requests are forwarded to the ECS instance.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// The allocation policy of preemptible instances. You can use this parameter to individually specify the allocation policy of preemptible instances. This parameter takes effect only if you set the `MultiAZPolicy` parameter to `COMPOSABLE`. Valid values:
        /// 
        /// *   priority: Auto Scaling selects instance types based on the specified order of the instance types to create the required number of preemptible instances.
        /// *   lowestPrice: Auto Scaling selects instance types that have the lowest unit price of vCPUs to create the required number of preemptible instances.
        /// 
        /// Default value: priority.
        /// </summary>
        [NameInMap("SpotAllocationStrategy")]
        [Validation(Required=false)]
        public string SpotAllocationStrategy { get; set; }

        /// <summary>
        /// The number of available instance types. Auto Scaling evenly creates preemptible instances of multiple instance types that are provided at the lowest cost in the scaling group. Valid values: 1 to 10.
        /// </summary>
        [NameInMap("SpotInstancePools")]
        [Validation(Required=false)]
        public int? SpotInstancePools { get; set; }

        /// <summary>
        /// Specifies whether to supplement preemptible instances. If you set this parameter to true, Auto Scaling creates an instance to replace a preemptible instance when Auto Scaling receives a system message which indicates that the preemptible instance is to be reclaimed.
        /// </summary>
        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        /// <summary>
        /// > This parameter is unavailable.
        /// </summary>
        [NameInMap("SyncAlarmRuleToCms")]
        [Validation(Required=false)]
        public bool? SyncAlarmRuleToCms { get; set; }

        /// <summary>
        /// The tags that you want to add to the scaling group.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestTags> Tags { get; set; }
        public class CreateScalingGroupRequestTags : TeaModel {
            /// <summary>
            /// The tag key that you want to add to the scaling group.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// Specifies whether to propagate the tag that you want to add to the scaling group. Valid values:
            /// 
            /// *   true: propagates the tag to only instances that are newly created.
            /// *   false: does not propagate the tag to any instances.
            /// 
            /// Default value: false.
            /// </summary>
            [NameInMap("Propagate")]
            [Validation(Required=false)]
            public bool? Propagate { get; set; }

            /// <summary>
            /// The tag value that you want to add to the scaling group.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The backend vServer group that you want to associate with the scaling group.
        /// </summary>
        [NameInMap("VServerGroups")]
        [Validation(Required=false)]
        public List<CreateScalingGroupRequestVServerGroups> VServerGroups { get; set; }
        public class CreateScalingGroupRequestVServerGroups : TeaModel {
            /// <summary>
            /// The ID of the CLB instance to which the backend vServer group belongs.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// The attributes of the backend vServer group.
            /// </summary>
            [NameInMap("VServerGroupAttributes")]
            [Validation(Required=false)]
            public List<CreateScalingGroupRequestVServerGroupsVServerGroupAttributes> VServerGroupAttributes { get; set; }
            public class CreateScalingGroupRequestVServerGroupsVServerGroupAttributes : TeaModel {
                /// <summary>
                /// The port number used by each ECS instance as a backend server in the vServer group. Valid values: 1 to 65535.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The ID of the vServer group.
                /// </summary>
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

                /// <summary>
                /// The weight of each ECS instance as a backend server in the vServer group. If you increase the weight for an ECS instance, the number of requests that are forwarded to the ECS instance also increases. If you set the weight for an ECS instance to 0, no requests are forwarded to the ECS instance. Valid values: 0 to 100.
                /// 
                /// Default value: 50.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// The ID of the vSwitch. If you specify the VSwitchId parameter, the network type of the scaling group is VPC.
        /// 
        /// > If you do not specify the VSwitchId or VSwitchIds parameter, the network type of the scaling group is classic network.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The IDs of the vSwitches. If you specify VSwitchIds, VSwitchId is ignored. If you specify VSwitchIds, the network type of the scaling group is VPC.
        /// 
        /// If you specify multiple vSwitches, take note of the following items:
        /// 
        /// *   The vSwitches must belong to the same VPC.
        /// *   The vSwitches can belong to different zones.
        /// *   vSwitches are sorted in ascending order based on their priorities. The first vSwitch has the highest priority. If Auto Scaling fails to create ECS instances in the zone where the vSwitch of the highest priority resides, Auto Scaling attempts to create ECS instances in the zone where the vSwitch of the next highest priority resides.
        /// 
        /// >  If you do not specify VSwitchId or VSwitchIds for your scaling group, the network type of the scaling group is classic network.
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
