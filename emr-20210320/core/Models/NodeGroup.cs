// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeGroup : TeaModel {
        /// <summary>
        /// <para>The additional security group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;sg-hp3abbae8lb6lmb1****&quot;]</para>
        /// </summary>
        [NameInMap("AdditionalSecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> AdditionalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>Applies only when <c>NodeResizeStrategy</c> is set to <c>COST_OPTIMIZED</c>. If set to <c>true</c>, the system creates Pay-As-You-Go instances to meet the target capacity if it fails to create enough spot instances due to price or inventory constraints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CompensateWithOnDemand")]
        [Validation(Required=false)]
        public bool? CompensateWithOnDemand { get; set; }

        /// <summary>
        /// <para>The configurations of the cost-optimized mode.</para>
        /// </summary>
        [NameInMap("CostOptimizedConfig")]
        [Validation(Required=false)]
        public CostOptimizedConfig CostOptimizedConfig { get; set; }

        /// <summary>
        /// <para>The data disks.</para>
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<DataDisk> DataDisks { get; set; }

        /// <summary>
        /// <para>The Deployment Set strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NONE: Does not use a Deployment Set.</para>
        /// </description></item>
        /// <item><description><para>CLUSTER: Uses a cluster-level Deployment Set.</para>
        /// </description></item>
        /// <item><description><para>NODE_GROUP: Uses a node group-level Deployment Set.</para>
        /// </description></item>
        /// </list>
        /// <para>Default: <c>NONE</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("DeploymentSetStrategy")]
        [Validation(Required=false)]
        public string DeploymentSetStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable graceful shutdown for components deployed in the node group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables graceful shutdown.</para>
        /// </description></item>
        /// <item><description><para>false: Disables graceful shutdown.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GracefulShutdown")]
        [Validation(Required=false)]
        public bool? GracefulShutdown { get; set; }

        /// <summary>
        /// <para>The instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ecs.g6.4xlarge&quot;]</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The node group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-869471354ecd****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The node group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>core-1</para>
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// <para>The state of the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RESIZING</para>
        /// </summary>
        [NameInMap("NodeGroupState")]
        [Validation(Required=false)]
        public string NodeGroupState { get; set; }

        /// <summary>
        /// <para>The type of the node group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MASTER: A master node.</para>
        /// </description></item>
        /// <item><description><para>CORE: A core node.</para>
        /// </description></item>
        /// <item><description><para>TASK: A task node.</para>
        /// </description></item>
        /// <item><description><para>GATEWAY: A gateway node. This value is not applicable to DATALAKE, OLAP, or DATASERVING clusters.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MASTER</para>
        /// </summary>
        [NameInMap("NodeGroupType")]
        [Validation(Required=false)]
        public string NodeGroupType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>COST_OPTIMIZED: The cost-optimized strategy.</para>
        /// </description></item>
        /// <item><description><para>PRIORITY: The priority-based strategy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIORITY</para>
        /// </summary>
        [NameInMap("NodeResizeStrategy")]
        [Validation(Required=false)]
        public string NodeResizeStrategy { get; set; }

        /// <summary>
        /// <para>The payment type. Valid values are <c>Subscription</c> for the subscription billing method and <c>PayAsYouGo</c> for the Pay-As-You-Go billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The private pool options.</para>
        /// </summary>
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public PrivatePoolOptions PrivatePoolOptions { get; set; }

        /// <summary>
        /// <para>The number of running nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RunningNodeCount")]
        [Validation(Required=false)]
        public int? RunningNodeCount { get; set; }

        /// <summary>
        /// <para>The bid prices for the spot instances. This parameter is effective only when <c>SpotStrategy</c> is set to <c>SpotWithPriceLimit</c>. The array can contain 0 to 100 elements.</para>
        /// </summary>
        [NameInMap("SpotBidPrices")]
        [Validation(Required=false)]
        public List<SpotBidPrice> SpotBidPrices { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable spot instance remedy. If enabled, the scaling group attempts to create a new instance to replace a spot instance that is about to be reclaimed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables spot instance remedy.</para>
        /// </description></item>
        /// <item><description><para>false: Disables spot instance remedy.</para>
        /// </description></item>
        /// </list>
        /// <para>Default: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        /// <summary>
        /// <para>The policy for using spot instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NoSpot: No spot instances are used.</para>
        /// </description></item>
        /// <item><description><para>SpotWithPriceLimit: Spot instances are created with a user-defined maximum bid price.</para>
        /// </description></item>
        /// <item><description><para>SpotAsPriceGo: The system automatically bids for spot instances. The bid price does not exceed the price of a Pay-As-You-Go instance.</para>
        /// </description></item>
        /// </list>
        /// <para>Default: <c>NoSpot</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The reason for the state change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>手动重启</para>
        /// </summary>
        [NameInMap("StateChangeReason")]
        [Validation(Required=false)]
        public NodeGroupStateChangeReason StateChangeReason { get; set; }

        /// <summary>
        /// <para>The node group state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The system disk.</para>
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public SystemDisk SystemDisk { get; set; }

        /// <summary>
        /// <para>The VSwitch IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vsw-hp35g7ya5ymw68mmg****&quot;]</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to assign a public IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithPublicIp")]
        [Validation(Required=false)]
        public bool? WithPublicIp { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
