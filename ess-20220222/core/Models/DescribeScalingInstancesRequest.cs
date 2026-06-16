// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The method used to create the instance in the scaling group. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>AutoCreated: The ECS instance is created by automatic creation based on the instance configuration source in Auto Scaling. </description></item>
        /// <item><description>Attached: The ECS instance is not created by Auto Scaling but manually added to the scaling group.</description></item>
        /// <item><description>Managed: The managed instance is not created by Auto Scaling but manually added to the scaling group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AutoCreated</para>
        /// </summary>
        [NameInMap("CreationType")]
        [Validation(Required=false)]
        public string CreationType { get; set; }

        /// <summary>
        /// <para>The methods used to create instances in the scaling group. You can specify only one of this parameter and CreationType.</para>
        /// </summary>
        [NameInMap("CreationTypes")]
        [Validation(Required=false)]
        public List<string> CreationTypes { get; set; }

        /// <summary>
        /// <para>The health check status of the ECS instance in the scaling group. ECS instances that are not in the Running state are considered unhealthy. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Healthy: The ECS instance is healthy. </description></item>
        /// <item><description>Unhealthy: The ECS instance is unhealthy.</description></item>
        /// </list>
        /// <para>Auto Scaling automatically removes unhealthy ECS instances from the scaling group and releases the ECS instances created by automatic creation.</para>
        /// <para>Whether a manually added ECS instance is released depends on its managed state. If the instance lifecycle is not managed by the scaling group, the instance is only removed but not released. If the instance lifecycle is managed by the scaling group, the instance is removed and released.</para>
        /// <remarks>
        /// <para>Make sure that your account has a sufficient available quota. If your account has an overdue payment, all pay-as-you-go ECS instances (including pay-as-you-go instances and spot instances) are stopped or even released. For information about how the status of ECS instances in a scaling group changes after an overdue payment occurs, see <a href="https://help.aliyun.com/document_detail/170589.html">Overdue payments</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Healthy</para>
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// <para>The IDs of the ECS instances.</para>
        /// <para>Invalid InstanceId values are ignored in the query results, and no error is returned.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The lifecycle state of the ECS instance in the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InService: The ECS instance is added to the scaling group and provides services in the Normal state. </description></item>
        /// <item><description>Pending: The ECS instance is being added to the scaling group. During this procedure, the ECS instance is added to the backend server group of the associated load balancing instance and to the access whitelist of the associated ApsaraDB RDS instance.</description></item>
        /// <item><description>Pending:Wait: The ECS instance is waiting to be added to the scaling group. If a lifecycle hook that applies to scale-out activities is created for the scaling group, the ECS instance is suspended and waits for the lifecycle hook timeout to end.</description></item>
        /// <item><description>Protected: The ECS instance is protected. The ECS instance provides services as expected, but Auto Scaling does not manage the lifecycle of the ECS instance. You must manually manage the lifecycle.</description></item>
        /// <item><description>Standby: The ECS instance is in the standby state. The ECS instance does not provide services, the weight of SLB backend server is set to zero, and Auto Scaling does not manage the lifecycle of the ECS instance. You must manually manage the lifecycle.</description></item>
        /// <item><description>Stopped: The ECS instance is stopped and does not provide services.</description></item>
        /// <item><description>Removing: The ECS instance is being removed from the scaling group. During this procedure, the ECS instance is removed from the backend server group of the associated load balancing instance and from the access whitelist of the associated ApsaraDB RDS instance. </description></item>
        /// <item><description>Removing:Wait: The ECS instance is waiting to be removed from the scaling group. If a lifecycle hook that applies to scale-down activities is created for the scaling group, the ECS instance is suspended and waits for the lifecycle hook timeout to end.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InService</para>
        /// </summary>
        [NameInMap("LifecycleState")]
        [Validation(Required=false)]
        public string LifecycleState { get; set; }

        /// <summary>
        /// <para>The lifecycle states of ECS instances in the scaling group. You can specify only one of this parameter and LifecycleState. We recommend that you use this parameter.</para>
        /// </summary>
        [NameInMap("LifecycleStates")]
        [Validation(Required=false)]
        public List<string> LifecycleStates { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the ECS instance list. Minimum value: 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Settings: Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the scaling activity.</para>
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
        /// <para>The ID of the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1igpak5ft1flyp****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
