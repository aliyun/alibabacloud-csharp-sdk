// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingInstancesResponseBody : TeaModel {
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
        /// <para>B13527BF-1FBD-4334-A512-20F5E9D3FB4D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ECS instances.</para>
        /// </summary>
        [NameInMap("ScalingInstances")]
        [Validation(Required=false)]
        public List<DescribeScalingInstancesResponseBodyScalingInstances> ScalingInstances { get; set; }
        public class DescribeScalingInstancesResponseBodyScalingInstances : TeaModel {
            /// <summary>
            /// <para>The time when the ECS instances were added to the scaling group. The value is accurate to the second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-18T03:11:39Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The time when the ECS instances were added to the scaling group. The value is accurate to the minute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-18T03:11Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The instance creation method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AutoCreated: The ECS instances are created by Auto Scaling based on the instance configuration source.</description></item>
            /// <item><description>Attached: The ECS instances are manually added to the scaling group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AutoCreated</para>
            /// </summary>
            [NameInMap("CreationType")]
            [Validation(Required=false)]
            public string CreationType { get; set; }

            /// <summary>
            /// <para>Indicates whether the scaling group is allowed to manage the instance lifecycles when ECS instances are manually added. If the scaling group is allowed to manage the instance lifecycles, Auto Scaling can release the ECS instances when the instances are automatically removed from the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Entrusted")]
            [Validation(Required=false)]
            public bool? Entrusted { get; set; }

            /// <summary>
            /// <para>The health status of the ECS instance in the scaling group. If an ECS instance is not in the Running state, the instance is considered unhealthy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Healthy</description></item>
            /// <item><description>Unhealthy</description></item>
            /// </list>
            /// <para>Auto Scaling automatically removes unhealthy ECS instances from the scaling group and then releases the automatically created instances among the unhealthy instances.</para>
            /// <para>Unhealthy ECS instances that are manually added to the scaling group are released based on the management mode of the lifecycles of the instances. If the lifecycles of the ECS instances are not managed by the scaling group, Auto Scaling removes the instances from the scaling group but does not release the instances. If the lifecycles of the ECS instances are managed by the scaling group, Auto Scaling removes the instances from the scaling group and releases the instances.</para>
            /// <remarks>
            /// <para> Make sure that you have sufficient balance within your Alibaba Cloud account. If your Alibaba Cloud account has an overdue payment, all pay-as-you-go ECS instances, including preemptible instances, may be stopped or even released. For information about how the status of ECS instances changes when you have an overdue payment in your Alibaba Cloud account, see <a href="https://help.aliyun.com/document_detail/170589.html">Overdue payments</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Healthy</para>
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp109k5j3dum1ce6****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lt-m5e3ofjr1zn1aw7****</para>
            /// </summary>
            [NameInMap("LaunchTemplateId")]
            [Validation(Required=false)]
            public string LaunchTemplateId { get; set; }

            /// <summary>
            /// <para>The version number of the launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LaunchTemplateVersion")]
            [Validation(Required=false)]
            public string LaunchTemplateVersion { get; set; }

            /// <summary>
            /// <para>The lifecycle status of the ECS instance in the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InService: The ECS instance is added to the scaling group and provides services as expected.</description></item>
            /// <item><description>Pending: The ECS instance is being added to the scaling group. When an ECS instance is being added to the scaling group, Auto Scaling also adds the instance to the backend server groups of the attached load balancers and adds the private IP address of the instance to the IP address whitelists of the attached ApsaraDB RDS instances.</description></item>
            /// <item><description>Pending:Wait: The ECS instance is waiting to be added to the scaling group. If a scale-out lifecycle hook is in effect, the ECS instance remains in the Pending:Wait state until the timeout period for the lifecycle hook expires.</description></item>
            /// <item><description>Protected: The ECS instance is protected. Protected ECS instances can continue to provide services as expected, but Auto Scaling does not manage the lifecycles of the ECS instances. You must manually manage the lifecycles of the ECS instances.</description></item>
            /// <item><description>Standby: The ECS instance is on standby. Standby ECS instances do not provide services as expected, and the weights of the ECS instances as backend servers are reset to zero. Auto Scaling does not manage the lifecycles of the ECS instances. Therefore, you must manually manage the lifecycles of the ECS instances.</description></item>
            /// <item><description>Stopped: The ECS instance is stopped. Stopped ECS instances no longer provide services.</description></item>
            /// <item><description>Removing: The ECS instance is being removed from the scaling group. When an ECS instance is being removed from the scaling group, Auto Scaling also removes the instance from the backend server groups of the attached load balancers and removes the private IP address of the instance from the IP address whitelists of the attached ApsaraDB RDS instances.</description></item>
            /// <item><description>Removing:Wait: The ECS instance is waiting to be removed from the scaling group. If a scale-in lifecycle hook is in effect, the ECS instance remains in the Removing:Wait state until the timeout period for the lifecycle hook expires.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InService</para>
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// <para>The weight of each ECS instance as a backend server.</para>
            /// <remarks>
            /// <para> This parameter is deprecated and is not recommended.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("LoadBalancerWeight")]
            [Validation(Required=false)]
            public int? LoadBalancerWeight { get; set; }

            /// <summary>
            /// <para>The private IP address of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**.2*.1**.2**</para>
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// <para>The ID of the scaling activity during which the ECS instances were added to the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asa-bp1c9djwrgxjyk31****</para>
            /// </summary>
            [NameInMap("ScalingActivityId")]
            [Validation(Required=false)]
            public string ScalingActivityId { get; set; }

            /// <summary>
            /// <para>The ID of the scaling configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asc-bp1i65jd06v04vdh****</para>
            /// </summary>
            [NameInMap("ScalingConfigurationId")]
            [Validation(Required=false)]
            public string ScalingConfigurationId { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp1igpak5ft1flyp****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance or elastic container instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asi-j6cj1gcte640ekhb****</para>
            /// </summary>
            [NameInMap("ScalingInstanceId")]
            [Validation(Required=false)]
            public string ScalingInstanceId { get; set; }

            /// <summary>
            /// <para>The bidding policy for the preemptible instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SpotWithPriceLimit: The instances are preemptible instances that have a user-defined maximum hourly price.</description></item>
            /// <item><description>SpotAsPriceGo: The instances are preemptible instances for which the market price at the time of purchase is automatically used as the bidding price.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SpotWithPriceLimit</para>
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>The warm-up status of the ECS instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoNeedWarmup: The ECS instances do not need to undergo a warm-up process.</description></item>
            /// <item><description>WaitingForInstanceWarmup: The ECS instances are undergoing the warm-up process.</description></item>
            /// <item><description>InstanceWarmupFinish: The warm-up process for the ECS instances is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoNeedWarmup</para>
            /// </summary>
            [NameInMap("WarmupState")]
            [Validation(Required=false)]
            public string WarmupState { get; set; }

            /// <summary>
            /// <para>The weight of the instance type. The weight indicates the capacity of a single instance of the specified instance type in the scaling group. A higher weight indicates that a smaller number of instances of the instance type are required to meet the expected capacity requirement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

            /// <summary>
            /// <para>The zone ID of the ECS instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The total number of ECS instances in the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of preemptible instances that run as expected in the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalSpotCount")]
        [Validation(Required=false)]
        public int? TotalSpotCount { get; set; }

    }

}
