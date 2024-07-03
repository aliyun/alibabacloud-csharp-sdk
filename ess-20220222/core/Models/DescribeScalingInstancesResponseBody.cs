// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingInstancesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the ECS instances.
        /// </summary>
        [NameInMap("ScalingInstances")]
        [Validation(Required=false)]
        public List<DescribeScalingInstancesResponseBodyScalingInstances> ScalingInstances { get; set; }
        public class DescribeScalingInstancesResponseBodyScalingInstances : TeaModel {
            /// <summary>
            /// The time when the ECS instances were added to the scaling group. The value is accurate to seconds.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The time when the ECS instances were added to the scaling group. The value is accurate to the minute.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The instance creation method. Valid values:
            /// 
            /// *   AutoCreated: Auto Scaling created the ECS instances based on the instance configuration source.
            /// *   Attached: You manually added the ECS instances to the scaling group.
            /// </summary>
            [NameInMap("CreationType")]
            [Validation(Required=false)]
            public string CreationType { get; set; }

            /// <summary>
            /// Indicates whether the scaling group is allowed to manage the instance lifecycles when the ECS instances are added manually. If the scaling group is allowed to manage the instance lifecycles, Auto Scaling can release the ECS instances when they are automatically removed from the scaling group. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Entrusted")]
            [Validation(Required=false)]
            public bool? Entrusted { get; set; }

            /// <summary>
            /// The health status of the ECS instances in the scaling group. If an ECS instance is not in the Running state, it is deemed as unhealthy. Valid values:
            /// 
            /// *   Healthy
            /// *   Unhealthy
            /// 
            /// Auto Scaling automatically removes unhealthy ECS instances from the scaling group and then releases the automatically created instances among the unhealthy instances.
            /// 
            /// Unhealthy ECS instances that are manually added to the scaling group are released based on the management mode of their lifecycles. If the lifecycles of the ECS instances are not managed by the scaling group, Auto Scaling removes the instances from the scaling group but does not release the instances. If the lifecycles of the ECS instances are managed by the scaling group, Auto Scaling removes the instances from the scaling group and releases the instances.
            /// 
            /// >  Make sure that you have sufficient balance within your Alibaba Cloud account. If your account has an overdue payment, all pay-as-you-go ECS instances, including preemptible instances, may be stopped or even released. For information about how the status of ECS instances changes when you have an overdue payment in your Alibaba Cloud account, see [Overdue payments](https://help.aliyun.com/document_detail/170589.html).
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            /// <summary>
            /// The IDs of the ECS instances.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the launch template.
            /// </summary>
            [NameInMap("LaunchTemplateId")]
            [Validation(Required=false)]
            public string LaunchTemplateId { get; set; }

            /// <summary>
            /// The version number of the launch template.
            /// </summary>
            [NameInMap("LaunchTemplateVersion")]
            [Validation(Required=false)]
            public string LaunchTemplateVersion { get; set; }

            /// <summary>
            /// The lifecycle status of the ECS instances in the scaling group. Valid values:
            /// 
            /// *   InService: The ECS instances have been successfully added to the scaling group and are providing the intended services.
            /// *   Pending: The ECS instances are in the process of being added to the scaling group. When an ECS instance is being added to the scaling group, Auto Scaling also adds it to the backend server groups of the attached load balancers and adds its private IP address to the IP address whitelists of the attached ApsaraDB RDS instances.
            /// *   Pending:Wait: The ECS instances are awaiting addition to the scaling group. If a scale-out lifecycle hook is in effect, ECS instances will remain in the Pending:Wait state until the timeout period for the lifecycle hook expires.
            /// *   Protected: The ECS instances are being safeguarded. Protected ECS instances can continue to provide services as expected, but Auto Scaling does not manage their lifecycles. You must manually manage the lifecycles of the ECS instances.
            /// *   Standby: The ECS instances are on standby. Standby ECS instances do not provide services as expected, and their weights as backend servers are reset to zero. Auto Scaling does not manage their lifecycles. Therefore, you must manually manage the lifecycles of the ECS instances.
            /// *   Stopped: The ECS instances are stopped. Stopped ECS instances do not provide services anymore.
            /// *   Removing: The ECS instances are in the process of being removed from the scaling group. When an ECS instance is being removed from the scaling group, Auto Scaling also removes it from the backend server groups of the attached load balancers and removes its private IP address from the IP address whitelists of the attached ApsaraDB RDS instances.
            /// *   Removing:Wait: The ECS instances are awaiting removal from the scaling group. If a scale-in lifecycle hook is in effect, ECS instances will remain in the Removing:Wait state until the timeout period for the lifecycle hook expires.
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// The weight of each ECS instance as a backend server.
            /// </summary>
            [NameInMap("LoadBalancerWeight")]
            [Validation(Required=false)]
            public int? LoadBalancerWeight { get; set; }

            /// <summary>
            /// The private IP address of the ECS instance.
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// The ID of the scaling activity during which the ECS instances were added to the scaling group.
            /// </summary>
            [NameInMap("ScalingActivityId")]
            [Validation(Required=false)]
            public string ScalingActivityId { get; set; }

            /// <summary>
            /// The ID of the scaling configuration.
            /// </summary>
            [NameInMap("ScalingConfigurationId")]
            [Validation(Required=false)]
            public string ScalingConfigurationId { get; set; }

            /// <summary>
            /// The ID of the scaling group.
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// The ID of the ECS instance or elastic container instance.
            /// </summary>
            [NameInMap("ScalingInstanceId")]
            [Validation(Required=false)]
            public string ScalingInstanceId { get; set; }

            /// <summary>
            /// The bidding policy for the preemptible instances. Valid values:
            /// 
            /// *   SpotWithPriceLimit: The instances were created as preemptible instances with a user-defined maximum hourly price.
            /// *   SpotAsPriceGo: The instances were preemptible instances for which the market price at the time of purchase was automatically used as the bidding price.
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// The warm-up status of the ECS instances. Valid values:
            /// 
            /// *   NoNeedWarmup: The ECS instances do not need to go through a warm-up period.
            /// *   WaitingForInstanceWarmup: The ECS instances are undergoing the warm-up process.
            /// *   InstanceWarmupFinish: The warm-up process for the ECS instances is completed.
            /// </summary>
            [NameInMap("WarmupState")]
            [Validation(Required=false)]
            public string WarmupState { get; set; }

            /// <summary>
            /// The weight of the instance type. The weight indicates the capacity of a single instance of the specified instance type in the scaling group. A greater weight indicates that a smaller number of instances of the specified instance type are required to meet the expected capacity requirement.
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

            /// <summary>
            /// The zone ID of the ECS instances.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TotalSpotCount")]
        [Validation(Required=false)]
        public int? TotalSpotCount { get; set; }

    }

}
