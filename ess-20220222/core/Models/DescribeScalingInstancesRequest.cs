// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The instance creation method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AutoCreated: The ECS instances are created by Auto Scaling based on the instance configuration source.</description></item>
        /// <item><description>Attached: The ECS instances are manually added to the scaling group.</description></item>
        /// <item><description>Managed: The Alibaba Cloud-managed third-party instances are manually added to the scaling group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AutoCreated</para>
        /// </summary>
        [NameInMap("CreationType")]
        [Validation(Required=false)]
        public string CreationType { get; set; }

        /// <summary>
        /// <para>The instance creation methods. If you specify this parameter, you cannot specify CreationType.</para>
        /// </summary>
        [NameInMap("CreationTypes")]
        [Validation(Required=false)]
        public List<string> CreationTypes { get; set; }

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
        /// <para>The IDs of the ECS instances.</para>
        /// <para>The IDs of inactive instances are not displayed in the query result, and no errors are returned.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

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
        /// <para>The lifecycle status of the ECS instances in the scaling group. You can specify only one of LifecycleStates and LifecycleState at a time. We recommend that you specify this parameter.</para>
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
        /// <para>The page number. Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
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

    }

}
