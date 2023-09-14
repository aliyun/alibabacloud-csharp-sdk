// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeGroup : TeaModel {
        /// <summary>
        /// 安全组ID。
        /// </summary>
        [NameInMap("AdditionalSecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> AdditionalSecurityGroupIds { get; set; }

        /// <summary>
        /// 成本优化模式配置。
        /// </summary>
        [NameInMap("CostOptimizedConfig")]
        [Validation(Required=false)]
        public CostOptimizedConfig CostOptimizedConfig { get; set; }

        /// <summary>
        /// 数据盘列表。
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<DataDisk> DataDisks { get; set; }

        /// <summary>
        /// 部署集策略。取值范围：
        /// - NONE：不适用部署集。
        /// - CLUSTER：使用集群级别部署集。
        /// - NODE_GROUP：使用节点组级别部署集。
        /// 
        /// 默认值：NONE。
        /// </summary>
        [NameInMap("DeploymentSetStrategy")]
        [Validation(Required=false)]
        public string DeploymentSetStrategy { get; set; }

        /// <summary>
        /// 节点组上部署的组件是否开启优雅下线。取值范围：
        /// - true：开启优雅下线。
        /// - false：不开启优雅下线。
        /// </summary>
        [NameInMap("GracefulShutdown")]
        [Validation(Required=false)]
        public bool? GracefulShutdown { get; set; }

        /// <summary>
        /// 实例类型列表。
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// 节点组ID。
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// 节点组名称。最大长度128个字符。
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// 节点组状态。
        /// </summary>
        [NameInMap("NodeGroupState")]
        [Validation(Required=false)]
        public string NodeGroupState { get; set; }

        /// <summary>
        /// 节点组类型。取值范围：
        /// - MASTER：管理类型节点组。
        /// - CORE：存储类型节点组。
        /// - TASK：计算类型节点组。
        /// </summary>
        [NameInMap("NodeGroupType")]
        [Validation(Required=false)]
        public string NodeGroupType { get; set; }

        /// <summary>
        /// - COST_OPTIMIZED：成本优化策略。
        /// - PRIORITY：优先级策略。
        /// </summary>
        [NameInMap("NodeResizeStrategy")]
        [Validation(Required=false)]
        public string NodeResizeStrategy { get; set; }

        /// <summary>
        /// 节点组付费类型。取值范围：
        /// - PayAsYouGo：后付费，按量付费。
        /// - Subscription：预付费，包年包月。
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// 存活节点数量。
        /// </summary>
        [NameInMap("RunningNodeCount")]
        [Validation(Required=false)]
        public int? RunningNodeCount { get; set; }

        [NameInMap("SpotBidPrices")]
        [Validation(Required=false)]
        public List<SpotBidPrice> SpotBidPrices { get; set; }

        /// <summary>
        /// 开启补齐抢占式实例后，当收到抢占式实例将被回收的系统消息时，伸缩组将尝试创建新的实例，替换掉将被回收的抢占式实例。取值范围：
        /// - true：开启补齐抢占式实例。
        /// - false：不开启补齐抢占式实例。
        /// 
        /// 默认值：false。
        /// </summary>
        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        /// <summary>
        /// 是否支持竞价实例。
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// 状态变化原因。
        /// </summary>
        [NameInMap("StateChangeReason")]
        [Validation(Required=false)]
        public NodeGroupStateChangeReason StateChangeReason { get; set; }

        /// <summary>
        /// 系统盘信息。
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public SystemDisk SystemDisk { get; set; }

        /// <summary>
        /// 虚拟机交换机ID列表。
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// 是否开公网IP。取值范围：
        /// - true：开公网。
        /// - false：不开公网。
        /// </summary>
        [NameInMap("WithPublicIp")]
        [Validation(Required=false)]
        public bool? WithPublicIp { get; set; }

        /// <summary>
        /// 可用区ID。
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
