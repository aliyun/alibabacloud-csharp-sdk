// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeGroupConfig : TeaModel {
        /// <summary>
        /// <para>The IDs of the additional security groups. In addition to the security group of the cluster, you can specify additional security groups for the node group. You can specify up to two security group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;sg-hp3abbae8lb6lmb1****&quot;]</para>
        /// </summary>
        [NameInMap("AdditionalSecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> AdditionalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The auto scaling policy.</para>
        /// </summary>
        [NameInMap("AutoScalingPolicy")]
        [Validation(Required=false)]
        public AutoScalingPolicy AutoScalingPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create pay-as-you-go instances to meet the required capacity when the number of preemptible instances is insufficient. This parameter is effective only when <c>nodeResizeStrategy</c> is set to <c>COST_OPTIMIZED</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CompensateWithOnDemand")]
        [Validation(Required=false)]
        public bool? CompensateWithOnDemand { get; set; }

        /// <summary>
        /// <para>A list of custom component tags.</para>
        /// </summary>
        [NameInMap("ComponentTags")]
        [Validation(Required=false)]
        public List<string> ComponentTags { get; set; }

        /// <summary>
        /// <para>The cost optimization settings.</para>
        /// </summary>
        [NameInMap("CostOptimizedConfig")]
        [Validation(Required=false)]
        public CostOptimizedConfig CostOptimizedConfig { get; set; }

        /// <summary>
        /// <para>The data disks. Currently, the array can contain only one data disk.</para>
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<DataDisk> DataDisks { get; set; }

        /// <summary>
        /// <para>The deployment set strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NONE</c>: No deployment sets are used.</para>
        /// </description></item>
        /// <item><description><para><c>CLUSTER</c>: The cluster-level deployment set is used.</para>
        /// </description></item>
        /// <item><description><para><c>NODE_GROUP</c>: The node group-level deployment set is used.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>NONE</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("DeploymentSetStrategy")]
        [Validation(Required=false)]
        public string DeploymentSetStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable graceful shutdown for the components in the node group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enables graceful shutdown.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disables graceful shutdown.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GracefulShutdown")]
        [Validation(Required=false)]
        public bool? GracefulShutdown { get; set; }

        /// <summary>
        /// <para>The instance types. You can specify 1 to 100 instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ecs.g6.xlarge&quot;]</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The number of nodes in the node group. Valid values: 1 to 1,000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// <para>The name of the node group. The name can be up to 128 characters in length and must be unique within the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>core-1</para>
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// <para>The type of the node group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>MASTER</c>: a master node group.</para>
        /// </description></item>
        /// <item><description><para><c>CORE</c>: a core node group.</para>
        /// </description></item>
        /// <item><description><para><c>TASK</c>: a task node group.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CORE</para>
        /// </summary>
        [NameInMap("NodeGroupType")]
        [Validation(Required=false)]
        public string NodeGroupType { get; set; }

        /// <summary>
        /// <para>The node scale-out strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>COST_OPTIMIZED</c>: The cost-optimized strategy.</para>
        /// </description></item>
        /// <item><description><para><c>PRIORITY</c>: The priority-based strategy.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>PRIORITY</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIORITY</para>
        /// </summary>
        [NameInMap("NodeResizeStrategy")]
        [Validation(Required=false)]
        public string NodeResizeStrategy { get; set; }

        /// <summary>
        /// <para>The billing method of the node group. If you do not specify this parameter, the billing method of the cluster is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PayAsYouGo</c>: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><c>Subscription</c>: subscription.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>PayAsYouGo</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The private pool options. This parameter is effective only when you create pay-as-you-go instances.</para>
        /// </summary>
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public PrivatePoolOptions PrivatePoolOptions { get; set; }

        /// <summary>
        /// <para>The bid prices for the preemptible instances. This parameter is effective only when <c>SpotStrategy</c> is set to <c>SpotWithPriceLimit</c>. You can specify up to 100 bid prices.</para>
        /// </summary>
        [NameInMap("SpotBidPrices")]
        [Validation(Required=false)]
        public List<SpotBidPrice> SpotBidPrices { get; set; }

        /// <summary>
        /// <para>If enabled, the auto scaling group attempts to create a new instance to replace a spot instance that is about to be reclaimed. This process is triggered when the auto scaling group receives a system message about the impending reclamation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The auto scaling group attempts to replace a spot instance that is about to be reclaimed.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The auto scaling group does not attempt to replace a spot instance that is about to be reclaimed.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        /// <summary>
        /// <para>The preemption strategy for preemptible instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NoSpot</c>: pay-as-you-go instances.</para>
        /// </description></item>
        /// <item><description><para><c>SpotWithPriceLimit</c>: preemptible instances with a user-defined maximum hourly price.</para>
        /// </description></item>
        /// <item><description><para><c>SpotAsPriceGo</c>: preemptible instances that are automatically bid at the pay-as-you-go price.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>NoSpot</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The subscription settings of the node group. If you do not specify this parameter, the subscription settings of the cluster are used.</para>
        /// </summary>
        [NameInMap("SubscriptionConfig")]
        [Validation(Required=false)]
        public SubscriptionConfig SubscriptionConfig { get; set; }

        /// <summary>
        /// <para>The system disk.</para>
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public SystemDisk SystemDisk { get; set; }

        /// <summary>
        /// <para>The vSwitch IDs. You can specify 1 to 20 vSwitch IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vsw-hp35g7ya5ymw68mmg****&quot;]</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to assign a public IP address to the instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Assigns a public IP address.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not assign a public IP address.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WithPublicIp")]
        [Validation(Required=false)]
        public bool? WithPublicIp { get; set; }

    }

}
