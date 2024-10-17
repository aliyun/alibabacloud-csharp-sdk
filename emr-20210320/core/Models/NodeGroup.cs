// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeGroup : TeaModel {
        /// <summary>
        /// <para>安全组ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;sg-hp3abbae8lb6lmb1****&quot;]</para>
        /// </summary>
        [NameInMap("AdditionalSecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> AdditionalSecurityGroupIds { get; set; }

        /// <summary>
        /// <para>成本优化模式配置。</para>
        /// </summary>
        [NameInMap("CostOptimizedConfig")]
        [Validation(Required=false)]
        public CostOptimizedConfig CostOptimizedConfig { get; set; }

        /// <summary>
        /// <para>数据盘列表。</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GracefulShutdown")]
        [Validation(Required=false)]
        public bool? GracefulShutdown { get; set; }

        /// <summary>
        /// <para>实例类型列表。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ecs.g6.4xlarge&quot;]</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>节点组ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-869471354ecd****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>节点组名称。最大长度128个字符。</para>
        /// 
        /// <b>Example:</b>
        /// <para>core-1</para>
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// <para>节点组状态。</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATED</para>
        /// </summary>
        [NameInMap("NodeGroupState")]
        [Validation(Required=false)]
        public string NodeGroupState { get; set; }

        /// <summary>
        /// <para>节点组类型。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>MASTER：管理类型节点组。</description></item>
        /// <item><description>CORE：存储类型节点组。</description></item>
        /// <item><description>TASK：计算类型节点组。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CORE</para>
        /// </summary>
        [NameInMap("NodeGroupType")]
        [Validation(Required=false)]
        public string NodeGroupType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>COST_OPTIMIZED：成本优化策略。</description></item>
        /// <item><description>PRIORITY：优先级策略。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIORITY</para>
        /// </summary>
        [NameInMap("NodeResizeStrategy")]
        [Validation(Required=false)]
        public string NodeResizeStrategy { get; set; }

        /// <summary>
        /// <para>节点组付费类型。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo：后付费，按量付费。</description></item>
        /// <item><description>Subscription：预付费，包年包月。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>存活节点数量。</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RunningNodeCount")]
        [Validation(Required=false)]
        public int? RunningNodeCount { get; set; }

        [NameInMap("SpotBidPrices")]
        [Validation(Required=false)]
        public List<SpotBidPrice> SpotBidPrices { get; set; }

        /// <summary>
        /// <para>开启补齐抢占式实例后，当收到抢占式实例将被回收的系统消息时，伸缩组将尝试创建新的实例，替换掉将被回收的抢占式实例。取值范围：</para>
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
        /// <para>是否支持竞价实例。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>状态变化原因。</para>
        /// </summary>
        [NameInMap("StateChangeReason")]
        [Validation(Required=false)]
        public NodeGroupStateChangeReason StateChangeReason { get; set; }

        /// <summary>
        /// <para>节点组状态，NodeGroupState别名。</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>系统盘信息。</para>
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public SystemDisk SystemDisk { get; set; }

        /// <summary>
        /// <para>虚拟机交换机ID列表。</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WithPublicIp")]
        [Validation(Required=false)]
        public bool? WithPublicIp { get; set; }

        /// <summary>
        /// <para>可用区ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
