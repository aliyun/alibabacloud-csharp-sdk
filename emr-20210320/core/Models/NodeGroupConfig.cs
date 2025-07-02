// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeGroupConfig : TeaModel {
        /// <summary>
        /// <para>附加安全组。除集群设置的安全组外，为节点组单独设置的附加安全组。数组元数个数N的取值范围：0~2。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;sg-hp3abbae8lb6lmb1****&quot;]</para>
        /// </summary>
        [NameInMap("AdditionalSecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> AdditionalSecurityGroupIds { get; set; }

        [NameInMap("AutoScalingPolicy")]
        [Validation(Required=false)]
        public AutoScalingPolicy AutoScalingPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CompensateWithOnDemand")]
        [Validation(Required=false)]
        public bool? CompensateWithOnDemand { get; set; }

        [NameInMap("ComponentTags")]
        [Validation(Required=false)]
        public List<string> ComponentTags { get; set; }

        /// <summary>
        /// <para>成本优化模式配置。</para>
        /// </summary>
        [NameInMap("CostOptimizedConfig")]
        [Validation(Required=false)]
        public CostOptimizedConfig CostOptimizedConfig { get; set; }

        /// <summary>
        /// <para>数据盘。当前数据盘只支持一种磁盘类型，即数组元数个数N的取值范围：1~1。</para>
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<DataDisk> DataDisks { get; set; }

        /// <summary>
        /// <para>部署集策略。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>NONE：不适用部署集。</description></item>
        /// <item><description>CLUSTER：使用集群级别部署集。</description></item>
        /// <item><description>NODE_GROUP：使用节点组级别部署集。</description></item>
        /// </list>
        /// <para>默认值：NONE。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("DeploymentSetStrategy")]
        [Validation(Required=false)]
        public string DeploymentSetStrategy { get; set; }

        /// <summary>
        /// <para>节点组上部署的组件是否开启优雅下线。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>true：开启优雅下线。</description></item>
        /// <item><description>false：不开启优雅下线。</description></item>
        /// </list>
        /// <para>默认值：false。</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GracefulShutdown")]
        [Validation(Required=false)]
        public bool? GracefulShutdown { get; set; }

        /// <summary>
        /// <para>节点实例类型列表。数组元数个数N的取值范围：1~100。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ecs.g6.xlarge&quot;]</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>节点数量。取值范围：1~1000。</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// <para>节点组名称。最大长度128个字符。集群内要求节点组名称唯一。</para>
        /// 
        /// <b>Example:</b>
        /// <para>core-1</para>
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// <para>节点组类型。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>MASTER：管理类型节点组。</description></item>
        /// <item><description>CORE：存储类型节点组。</description></item>
        /// <item><description>TASK：计算类型节点组。</description></item>
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
        /// <para>节点扩容策略。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>COST_OPTIMIZED：成本优化策略。</description></item>
        /// <item><description>PRIORITY：优先级策略。</description></item>
        /// </list>
        /// <para>默认值：PRIORITY。</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIORITY</para>
        /// </summary>
        [NameInMap("NodeResizeStrategy")]
        [Validation(Required=false)]
        public string NodeResizeStrategy { get; set; }

        /// <summary>
        /// <para>节点组付费类型。不传入时默认和集群付费类型一致。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo：后付费，按量付费。</description></item>
        /// <item><description>Subscription：预付费，包年包月。</description></item>
        /// </list>
        /// <para>默认值：PayAsYouGo。</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public PrivatePoolOptions PrivatePoolOptions { get; set; }

        /// <summary>
        /// <para>抢占式Spot实例出价价格。参数SpotStrategy取值为SpotWithPriceLimit时生效。数组元数个数N的取值范围：0~100。</para>
        /// </summary>
        [NameInMap("SpotBidPrices")]
        [Validation(Required=false)]
        public List<SpotBidPrice> SpotBidPrices { get; set; }

        /// <summary>
        /// <para>开启后，当收到抢占式实例将被回收的系统消息时，伸缩组将尝试创建新的实例，替换掉将被回收的抢占式实例。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>true：开启补齐抢占式实例。</description></item>
        /// <item><description>false：不开启补齐抢占式实例。</description></item>
        /// </list>
        /// <para>默认值：false。</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        /// <summary>
        /// <para>抢占式Spot实例策略。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>NoSpot：正常按量付费实例。</description></item>
        /// <item><description>SpotWithPriceLimit：设置最高出价的抢占式实例。</description></item>
        /// <item><description>SpotAsPriceGo：系统自动出价，最高按量付费价格的抢占式实例。</description></item>
        /// </list>
        /// <para>默认值：NoSpot。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>节点组预付费配置。不传入时默认和集群预付费配置一致。</para>
        /// </summary>
        [NameInMap("SubscriptionConfig")]
        [Validation(Required=false)]
        public SubscriptionConfig SubscriptionConfig { get; set; }

        /// <summary>
        /// <para>系统盘。</para>
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public SystemDisk SystemDisk { get; set; }

        /// <summary>
        /// <para>虚拟机交换机ID列表。数组元数个数N的取值范围：1~20。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vsw-hp35g7ya5ymw68mmg****&quot;]</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>是否开公网IP。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>true：开公网。</description></item>
        /// <item><description>false：不开公网。</description></item>
        /// </list>
        /// <para>默认值：false。</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WithPublicIp")]
        [Validation(Required=false)]
        public bool? WithPublicIp { get; set; }

    }

}
