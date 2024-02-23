// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetClusterCloneMetaResponseBody : TeaModel {
        [NameInMap("ClusterCloneMeta")]
        [Validation(Required=false)]
        public GetClusterCloneMetaResponseBodyClusterCloneMeta ClusterCloneMeta { get; set; }
        public class GetClusterCloneMetaResponseBodyClusterCloneMeta : TeaModel {
            /// <summary>
            /// 创建集群时的服务配置项。创建集群时需要记录用户传入的配置项参数key，返回集群最新的配置项值。
            /// </summary>
            [NameInMap("ApplicationConfigs")]
            [Validation(Required=false)]
            public List<ApplicationConfig> ApplicationConfigs { get; set; }

            /// <summary>
            /// 集群应用。
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<Application> Applications { get; set; }

            [NameInMap("BootstrapScripts")]
            [Validation(Required=false)]
            public List<Script> BootstrapScripts { get; set; }

            /// <summary>
            /// 集群ID。
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// 集群名称。
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// 集群状态。
            /// </summary>
            [NameInMap("ClusterState")]
            [Validation(Required=false)]
            public string ClusterState { get; set; }

            /// <summary>
            /// 集群类型。
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// 部署模式。
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// EMR服务角色。
            /// </summary>
            [NameInMap("EmrDefaultRole")]
            [Validation(Required=false)]
            public string EmrDefaultRole { get; set; }

            [NameInMap("ExistCloneConfig")]
            [Validation(Required=false)]
            public bool? ExistCloneConfig { get; set; }

            /// <summary>
            /// 元数据类型。
            /// </summary>
            [NameInMap("MetaStoreType")]
            [Validation(Required=false)]
            public string MetaStoreType { get; set; }

            /// <summary>
            /// 网络类型。
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// 节点属性。
            /// </summary>
            [NameInMap("NodeAttributes")]
            [Validation(Required=false)]
            public NodeAttributes NodeAttributes { get; set; }

            [NameInMap("NodeGroups")]
            [Validation(Required=false)]
            public List<NodeGroup> NodeGroups { get; set; }

            /// <summary>
            /// 付费类型。
            /// </summary>
            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// 地域ID。
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// EMR发行版。
            /// </summary>
            [NameInMap("ReleaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// 资源组ID。
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ScalingPolicyDTOS")]
            [Validation(Required=false)]
            public List<GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPolicyDTOS> ScalingPolicyDTOS { get; set; }
            public class GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPolicyDTOS : TeaModel {
                /// <summary>
                /// 集群ID。
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// 最大最小值约束
                /// </summary>
                [NameInMap("Constraints")]
                [Validation(Required=false)]
                public GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPolicyDTOSConstraints Constraints { get; set; }
                public class GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPolicyDTOSConstraints : TeaModel {
                    /// <summary>
                    /// 最大值
                    /// </summary>
                    [NameInMap("MaxCapacity")]
                    [Validation(Required=false)]
                    public int? MaxCapacity { get; set; }

                    /// <summary>
                    /// 最小值
                    /// </summary>
                    [NameInMap("MinCapacity")]
                    [Validation(Required=false)]
                    public int? MinCapacity { get; set; }

                }

                /// <summary>
                /// 节点组ID。
                /// </summary>
                [NameInMap("NodeGroupId")]
                [Validation(Required=false)]
                public string NodeGroupId { get; set; }

                /// <summary>
                /// 伸缩策略ID。
                /// </summary>
                [NameInMap("ScalingPolicyId")]
                [Validation(Required=false)]
                public string ScalingPolicyId { get; set; }

                /// <summary>
                /// 伸缩规则列表
                /// </summary>
                [NameInMap("ScalingRules")]
                [Validation(Required=false)]
                public List<GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPolicyDTOSScalingRules> ScalingRules { get; set; }
                public class GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPolicyDTOSScalingRules : TeaModel {
                    /// <summary>
                    /// 伸缩类型。取值范围：
                    /// - SCALE_OUT：扩容
                    /// - SCALE_IN：缩容
                    /// </summary>
                    [NameInMap("ActivityType")]
                    [Validation(Required=false)]
                    public string ActivityType { get; set; }

                    /// <summary>
                    /// 调整值。需要为正数，代表需要扩容或者缩容的实例数量。
                    /// </summary>
                    [NameInMap("AdjustmentValue")]
                    [Validation(Required=false)]
                    public int? AdjustmentValue { get; set; }

                    /// <summary>
                    /// 按照负载伸缩描述。
                    /// </summary>
                    [NameInMap("MetricsTrigger")]
                    [Validation(Required=false)]
                    public MetricsTrigger MetricsTrigger { get; set; }

                    /// <summary>
                    /// 弹性伸缩规则名称。
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// 按照时间伸缩描述。
                    /// </summary>
                    [NameInMap("TimeTrigger")]
                    [Validation(Required=false)]
                    public TimeTrigger TimeTrigger { get; set; }

                    /// <summary>
                    /// 伸缩规则类型。取值范围：
                    /// - TIME_TRIGGER: 按时间伸缩。
                    /// - METRICS_TRIGGER: 按负载伸缩。
                    /// </summary>
                    [NameInMap("TriggerType")]
                    [Validation(Required=false)]
                    public string TriggerType { get; set; }

                }

            }

            /// <summary>
            /// Kerberos安全模式。
            /// </summary>
            [NameInMap("SecurityMode")]
            [Validation(Required=false)]
            public string SecurityMode { get; set; }

            /// <summary>
            /// 预付费配置。
            /// </summary>
            [NameInMap("SubscriptionConfig")]
            [Validation(Required=false)]
            public SubscriptionConfig SubscriptionConfig { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
