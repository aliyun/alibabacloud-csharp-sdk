// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingInstancesResponseBody : TeaModel {
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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B13527BF-1FBD-4334-A512-20F5E9D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The collection of ECS instance information.</para>
        /// </summary>
        [NameInMap("ScalingInstances")]
        [Validation(Required=false)]
        public List<DescribeScalingInstancesResponseBodyScalingInstances> ScalingInstances { get; set; }
        public class DescribeScalingInstancesResponseBodyScalingInstances : TeaModel {
            /// <summary>
            /// <para>The time when the ECS instance was added to the scaling group. The time is accurate to seconds and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-18T03:11:39Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The time when the ECS instance was added to the scaling group. The time is accurate to minutes and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mmZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-18T03:11Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The creation type of the ECS instance. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>AutoCreated: The ECS instance is created by Auto Scaling through automatic creation based on the instance configuration source. </description></item>
            /// <item><description>Attached: The ECS instance is not created by Auto Scaling, but is manually added to the scaling group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AutoCreated</para>
            /// </summary>
            [NameInMap("CreationType")]
            [Validation(Required=false)]
            public string CreationType { get; set; }

            /// <summary>
            /// <para>Specifies whether the instance is managed by the scaling group when it is manually added to the scaling group. A manually added instance in the managed state is released when it is removed from the scaling group, excluding manual removal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The instance is managed by the scaling group.</description></item>
            /// <item><description>false: The instance is not managed by the scaling group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Entrusted")]
            [Validation(Required=false)]
            public bool? Entrusted { get; set; }

            /// <summary>
            /// <para>The health status of the ECS instance in the scaling group. ECS instances that are not in the Running state are considered unhealthy. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>Healthy: The ECS instance is healthy. </description></item>
            /// <item><description>Unhealthy: The ECS instance is unhealthy.</description></item>
            /// </list>
            /// <para>Auto Scaling automatically removes unhealthy ECS instances from the scaling group and releases ECS instances created through automatic creation.</para>
            /// <para>Whether to release manually added ECS instances depends on their managed state. If the instance lifecycle is not managed by the scaling group, the instance is only removed but not released. If the instance lifecycle is managed by the scaling group, the instance is removed and released.</para>
            /// <remarks>
            /// <para>Make sure that your account has sufficient active balance. If your account has overdue payments, all pay-as-you-go ECS instances, including pay-as-you-go instances and spot instances, are stopped or even released. For more information about the instance status changes of ECS instances in a scaling group after overdue payments, see <a href="https://help.aliyun.com/document_detail/170589.html">Overdue payments</a>.</para>
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
            /// <para>The ID of the instance launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lt-m5e3ofjr1zn1aw7****</para>
            /// </summary>
            [NameInMap("LaunchTemplateId")]
            [Validation(Required=false)]
            public string LaunchTemplateId { get; set; }

            /// <summary>
            /// <para>The version of the instance launch template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LaunchTemplateVersion")]
            [Validation(Required=false)]
            public string LaunchTemplateVersion { get; set; }

            /// <summary>
            /// <para>The lifecycle state of the ECS instance in the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InService: The ECS instance is added to the scaling group and provides services normally. </description></item>
            /// <item><description>Pending: The ECS instance is being added to the scaling group. The procedure of adding an ECS instance to a scaling group includes adding the instance to the backend server group of a load balancing instance and adding the IP address of the instance to the access whitelist of an ApsaraDB RDS instance.</description></item>
            /// <item><description>Pending:Wait: The addition of the ECS instance to the scaling group is suspended. If a lifecycle hook applicable to scale-out activities is created in the scaling group, the ECS instance is suspended when it is added to the scaling group and waits for the hook timeout to end.</description></item>
            /// <item><description>Protected: The ECS instance provides services normally, but Auto Scaling does not manage the lifecycle of the ECS instance. You must manually manage the lifecycle.</description></item>
            /// <item><description>Standby: The ECS instance does not provide services, the weight of SLB backend server is set to zero, and Auto Scaling does not manage the lifecycle of the ECS instance. You must manually manage the lifecycle.</description></item>
            /// <item><description>Stopped: The ECS instance is stopped and does not provide services.</description></item>
            /// <item><description>Removing: The ECS instance is being removed from the scaling group. The procedure of removing an ECS instance from a scaling group includes removing the instance from the backend server group of a load balancing instance and removing the IP address of the instance from the access whitelist of an ApsaraDB RDS instance. </description></item>
            /// <item><description>Removing:Wait: The removal of the ECS instance from the scaling group is suspended. If a lifecycle hook applicable to scale-down activities is created in the scaling group, the ECS instance is suspended when it is removed from the scaling group and waits for the hook timeout to end.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InService</para>
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// <para>The weight of the SLB backend server.</para>
            /// <remarks>
            /// <para><b>[Deprecated]</b> This parameter is deprecated. Do not use it.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("LoadBalancerWeight")]
            [Validation(Required=false)]
            public int? LoadBalancerWeight { get; set; }

            /// <summary>
            /// <para>The internal IP address of the instance in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**.2*.1**.2**</para>
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// <para>The instance replacement process that the instance is in. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal: The instance is not in any replacement process.</description></item>
            /// <item><description>ReBalance: The instance is in the rebalancing replacement process of the scaling group.</description></item>
            /// <item><description>SpotRemedy: The instance is in the spot instance remedy replacement process.</description></item>
            /// <item><description>MaxInstanceLifetimeExpire: The instance is in the replacement process due to the expiration of the maximum instance lifetime.</description></item>
            /// <item><description>InstanceRefresh: The instance is in the instance refresh replacement process.</description></item>
            /// <item><description>SpotReplaceOnDemand: The instance is in the process of replacing a spot instance with a pay-as-you-go instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ReBalance</para>
            /// </summary>
            [NameInMap("ReplaceStatus")]
            [Validation(Required=false)]
            public string ReplaceStatus { get; set; }

            /// <summary>
            /// <para>The ID of the scaling activity when the ECS instance was added to the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asa-bp1c9djwrgxjyk31****</para>
            /// </summary>
            [NameInMap("ScalingActivityId")]
            [Validation(Required=false)]
            public string ScalingActivityId { get; set; }

            /// <summary>
            /// <para>The ID of the associated scaling configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asc-bp1i65jd06v04vdh****</para>
            /// </summary>
            [NameInMap("ScalingConfigurationId")]
            [Validation(Required=false)]
            public string ScalingConfigurationId { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp1igpak5ft1flyp****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The instance identity in the scaling group, which corresponds one-to-one with the ID of the ECS instance or elastic container instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asi-j6cj1gcte640ekhb****</para>
            /// </summary>
            [NameInMap("ScalingInstanceId")]
            [Validation(Required=false)]
            public string ScalingInstanceId { get; set; }

            /// <summary>
            /// <para>The bidding policy for the spot instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SpotWithPriceLimit: The spot instance with a maximum price.</description></item>
            /// <item><description>SpotAsPriceGo: The system automatically bids based on the current market price.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SpotWithPriceLimit</para>
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>The warmup status of the ECS instance. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>NoNeedWarmup: No warmup is required.</description></item>
            /// <item><description>WaitingForInstanceWarmup: The instance is waiting for the warmup to complete.</description></item>
            /// <item><description>InstanceWarmupFinish: The warmup is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoNeedWarmup</para>
            /// </summary>
            [NameInMap("WarmupState")]
            [Validation(Required=false)]
            public string WarmupState { get; set; }

            /// <summary>
            /// <para>The weight of the instance type, which indicates the capacity of a single instance of the instance type in the scaling group. A greater weight indicates that fewer instances of the instance type are required to meet the expected capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

            /// <summary>
            /// <para>The ID of the zone to which the ECS instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The total number of ECS instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of running spot instances in the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalSpotCount")]
        [Validation(Required=false)]
        public int? TotalSpotCount { get; set; }

    }

}
