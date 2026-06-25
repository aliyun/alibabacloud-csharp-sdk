// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class Nodepool : TeaModel {
        /// <summary>
        /// <para>The auto scaling configuration of the node pool.</para>
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public NodepoolAutoScaling AutoScaling { get; set; }
        public class NodepoolAutoScaling : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>【该字段已废弃】</para>
            /// <para>EIP带宽峰值。单位：Mbps。</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("eip_bandwidth")]
            [Validation(Required=false)]
            [Obsolete]
            public long? EipBandwidth { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>【该字段已废弃】</para>
            /// <para>EIP计费类型，取值：</para>
            /// <list type="bullet">
            /// <item><description><c>PayByBandwidth</c>：按固定带宽计费。</description></item>
            /// <item><description><c>PayByTraffic</c>：按使用流量计费。</description></item>
            /// </list>
            /// <para>默认值：PayByBandwidth。</para>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            [Obsolete]
            public string EipInternetChargeType { get; set; }

            /// <summary>
            /// <para>是否启用自动伸缩。</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>：开启节点池自动伸缩功能。</description></item>
            /// <item><description><c>false</c>：不开启自动伸缩，当取值为false时，<c>auto_scaling</c>内的其他配置参数将不生效。</description></item>
            /// </list>
            /// <para>默认值：<c>false</c>。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>【该字段已废弃】</para>
            /// <para>是否绑定EIP，取值：</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>：绑定EIP。</description></item>
            /// <item><description><c>false</c>：不绑定EIP。</description></item>
            /// </list>
            /// <para>默认值：<c>false</c>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? IsBondEip { get; set; }

            /// <summary>
            /// <para>自动伸缩组最大实例数。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// <para>自动伸缩组最小实例数。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <summary>
            /// <para>自动伸缩类型，按照自动伸缩实例类型划分。取值：</para>
            /// <list type="bullet">
            /// <item><description><c>cpu</c>：普通实例型。</description></item>
            /// <item><description><c>gpu</c>：GPU实例型。</description></item>
            /// <item><description><c>gpushare</c>：GPU共享型。</description></item>
            /// <item><description><c>spot</c>：抢占式实例型。</description></item>
            /// </list>
            /// <para>默认值：<c>cpu</c>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use desired_size instead.</para>
        /// <para>The number of nodes in the node pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        [Obsolete]
        public long? Count { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// <para>The edge node pool configuration.</para>
        /// </summary>
        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        [Obsolete]
        public NodepoolInterconnectConfig InterconnectConfig { get; set; }
        public class NodepoolInterconnectConfig : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>【该字段已废弃】</para>
            /// <para>边缘增强型节点池的网络带宽，单位：Mbps。</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            [Obsolete]
            public long? Bandwidth { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>【该字段已废弃】</para>
            /// <para>边缘增强型节点池绑定的云连接网实例ID(CCNID)。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccn-qm5i0i0q9yi*******</para>
            /// </summary>
            [NameInMap("ccn_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string CcnId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>【该字段已废弃】</para>
            /// <para>边缘增强型节点池绑定的云连接网实例所属的地域。</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("ccn_region_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string CcnRegionId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>【该字段已废弃】</para>
            /// <para>边缘增强型节点池绑定的云企业网实例ID(CENID)。</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-ey9k9nfhz0f*******</para>
            /// </summary>
            [NameInMap("cen_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string CenId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>【该字段已废弃】</para>
            /// <para>边缘增强型节点池的购买时长，单位：月。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("improved_period")]
            [Validation(Required=false)]
            [Obsolete]
            public string ImprovedPeriod { get; set; }

        }

        /// <summary>
        /// <para>The network type of the edge node pool. This parameter is valid only for node pools whose <c>type</c> is <c>edge</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>basic</c>: basic.</description></item>
        /// <item><description><c>private</c>: dedicated. Supported in version 1.22 and later.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("interconnect_mode")]
        [Validation(Required=false)]
        public string InterconnectMode { get; set; }

        /// <summary>
        /// <para>The cluster-related configuration.</para>
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public NodepoolKubernetesConfig KubernetesConfig { get; set; }
        public class NodepoolKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>是否在ECS节点上安装云监控，安装后可以在云监控控制台查看所创建ECS实例的监控信息，推荐开启。取值：</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>：在ECS节点上安装云监控。</description></item>
            /// <item><description><c>false</c>：不在ECS节点上安装云监控。</description></item>
            /// </list>
            /// <para>默认值：<c>false</c>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cms_enabled")]
            [Validation(Required=false)]
            public bool? CmsEnabled { get; set; }

            /// <summary>
            /// <para>节点CPU管理策略。当集群版本在1.12.6及以上时支持以下两种策略：</para>
            /// <list type="bullet">
            /// <item><description><c>static</c>：允许为节点上具有某些资源特征Pod增强其CPU亲和性和独占性。</description></item>
            /// <item><description><c>none</c>：表示启用现有的默认CPU亲和性方案。</description></item>
            /// </list>
            /// <para>默认值：<c>none</c>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("cpu_policy")]
            [Validation(Required=false)]
            public string CpuPolicy { get; set; }

            /// <summary>
            /// <para>节点标签，为Kubernetes集群节点添加标签。</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// <para>节点名称由三部分组成：前缀 + 节点 IP + 后缀：</para>
            /// <list type="bullet">
            /// <item><description>前缀和后缀均可由“.”分隔的一个或多个部分构成，每个部分可以使用小写字母、数字和“-”，节点名称首尾必须为小写字母和数字；</description></item>
            /// <item><description>节点 IP为完整的节点私网 IP 地址；</description></item>
            /// </list>
            /// <para>传参包含四个部分，由逗号分隔，例如：参数传入&quot;customized,aliyun,ip,com&quot;字符串（其中“customized”和&quot;ip&quot;为固定的字符串，aliyun为前缀，com为后缀），则节点的名称为：aliyun.192.168.xxx.xxx.com。</para>
            /// 
            /// <b>Example:</b>
            /// <para>customized,aliyun,ip,com</para>
            /// </summary>
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            /// <summary>
            /// <para>容器运行时。取值：</para>
            /// <list type="bullet">
            /// <item><description><c>containerd</c>：推荐使用，支持所有集群版本。</description></item>
            /// <item><description><c>Sandboxed-Container.runv</c>：安全沙箱容器，提供更高的隔离性，支持1.24版本及以下集群。</description></item>
            /// <item><description><c>docker</c>：支持1.22版本及以下集群。</description></item>
            /// </list>
            /// <para>默认值：<c>containerd</c></para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>容器运行时版本。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.6.20</para>
            /// </summary>
            [NameInMap("runtime_version")]
            [Validation(Required=false)]
            public string RuntimeVersion { get; set; }

            /// <summary>
            /// <para>污点配置。</para>
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// <para>节点自定义数据。</para>
            /// 
            /// <b>Example:</b>
            /// <para>MXM=</para>
            /// </summary>
            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The managed node pool configuration.</para>
        /// </summary>
        [NameInMap("management")]
        [Validation(Required=false)]
        public NodepoolManagement Management { get; set; }
        public class NodepoolManagement : TeaModel {
            [NameInMap("auto_fault_diagnosis")]
            [Validation(Required=false)]
            public bool? AutoFaultDiagnosis { get; set; }

            /// <summary>
            /// <para>自动修复，仅当<c>enable=true</c>时生效。</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>：自动修复。</description></item>
            /// <item><description><c>false</c>：不自动修复。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("auto_repair")]
            [Validation(Required=false)]
            public bool? AutoRepair { get; set; }

            /// <summary>
            /// <para>自动修复节点策略。</para>
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public NodepoolManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class NodepoolManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// <para>是否允许重启节点。</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

            }

            /// <summary>
            /// <para>是否自动升级。</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_upgrade")]
            [Validation(Required=false)]
            public bool? AutoUpgrade { get; set; }

            /// <summary>
            /// <para>自动升级策略。</para>
            /// </summary>
            [NameInMap("auto_upgrade_policy")]
            [Validation(Required=false)]
            public NodepoolManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class NodepoolManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// <para>是否允许自动升级kubelet。</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("auto_upgrade_kubelet")]
                [Validation(Required=false)]
                public bool? AutoUpgradeKubelet { get; set; }

            }

            /// <summary>
            /// <para>是否自动修复CVE。</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("auto_vul_fix")]
            [Validation(Required=false)]
            public bool? AutoVulFix { get; set; }

            /// <summary>
            /// <para>自动修复CVE策略。</para>
            /// </summary>
            [NameInMap("auto_vul_fix_policy")]
            [Validation(Required=false)]
            public NodepoolManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class NodepoolManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// <para>是否允许重启节点。</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// <para>允许自动修复的漏洞级别，以逗号分隔。</para>
                /// 
                /// <b>Example:</b>
                /// <para>asap,nntf</para>
                /// </summary>
                [NameInMap("vul_level")]
                [Validation(Required=false)]
                public string VulLevel { get; set; }

            }

            /// <summary>
            /// <para>是否开启托管版节点池，取值：</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>：开启托管节点池。</description></item>
            /// <item><description><c>false</c>：不开启托管节点池，只有当<c>enable=true</c>时，其他相关配置才生效。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>自动升级配置，仅当<c>enable=true</c>时生效。</para>
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public NodepoolManagementUpgradeConfig UpgradeConfig { get; set; }
            public class NodepoolManagementUpgradeConfig : TeaModel {
                /// <summary>
                /// <para>是否启用自动升级，取值：</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>：启用自动升级。</description></item>
                /// <item><description><c>false</c>：不启用自动升级。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// <para>最大不可用节点数量，取值范围：[1,1000\]。</para>
                /// <para>默认值：1。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                /// <summary>
                /// <para>额外节点数量。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// <para>额外节点比例，和<c>surge</c>二选一。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("surge_percentage")]
                [Validation(Required=false)]
                public long? SurgePercentage { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of nodes allowed in the edge node pool. This parameter must be greater than or equal to 0. A value of 0 indicates no additional limit. The node pool is limited only by the maximum number of nodes that the cluster can contain. Edge node pools typically have a value greater than 0. ESS-type node pools and default edge-type node pools have a value of 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("max_nodes")]
        [Validation(Required=false)]
        public long? MaxNodes { get; set; }

        /// <summary>
        /// <para>The list of node components.</para>
        /// </summary>
        [NameInMap("node_components")]
        [Validation(Required=false)]
        public List<NodepoolNodeComponents> NodeComponents { get; set; }
        public class NodepoolNodeComponents : TeaModel {
            /// <summary>
            /// <para>节点组件配置。</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public NodepoolNodeComponentsConfig Config { get; set; }
            public class NodepoolNodeComponentsConfig : TeaModel {
                /// <summary>
                /// <para>节点组件自定义配置。</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cpuManagerPolicy&quot;:&quot;static&quot;}</para>
                /// </summary>
                [NameInMap("custom_config")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomConfig { get; set; }

            }

            /// <summary>
            /// <para>节点组件名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubelet</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>节点组件版本</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.33.3-aliyun.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The node configuration.</para>
        /// </summary>
        [NameInMap("node_config")]
        [Validation(Required=false)]
        public NodepoolNodeConfig NodeConfig { get; set; }
        public class NodepoolNodeConfig : TeaModel {
            /// <summary>
            /// <para>Kubelet参数配置。</para>
            /// </summary>
            [NameInMap("kubelet_configuration")]
            [Validation(Required=false)]
            public KubeletConfig KubeletConfiguration { get; set; }

        }

        /// <summary>
        /// <para>The node pool configuration.</para>
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public NodepoolNodepoolInfo NodepoolInfo { get; set; }
        public class NodepoolNodepoolInfo : TeaModel {
            /// <summary>
            /// <para>节点池名称。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>节点池所在资源ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjm****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>节点池类型，取值范围：</para>
            /// <list type="bullet">
            /// <item><description><c>ess</c>：节点池。</description></item>
            /// <item><description><c>edge</c>：边缘节点池。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ess</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The scaling group configuration of the node pool.</para>
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public NodepoolScalingGroup ScalingGroup { get; set; }
        public class NodepoolScalingGroup : TeaModel {
            /// <summary>
            /// <para>节点池是否开启自动续费，当<c>instance_charge_type</c>取值为<c>PrePaid</c>时才生效，取值：</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>：自动续费。</description></item>
            /// <item><description><c>false</c>：不自动续费。</description></item>
            /// </list>
            /// <para>默认值：<c>true</c>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>节点池自动续费周期。当<c>instance_charge_type</c>取值为<c>PrePaid</c>时才生效，且为必选值。</para>
            /// <para>当<c>PeriodUnit=Month</c>时，取值范围：{1, 2, 3, 6, 12}。</para>
            /// <para>默认值：1。</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>当<c>multi_az_policy</c>取值为<c>COST_OPTIMIZED</c>时，如果因价格、库存等原因无法创建足够的抢占式实例，是否允许自动尝试创建按量实例满足ECS实例数量要求。取值：</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>：允许自动尝试创建按量实例满足ECS实例数量要求。</description></item>
            /// <item><description><c>false</c>：不允许自动尝试创建按量实例满足ECS实例数量要求。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("compensate_with_on_demand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// <para>节点池节点数据盘配置。</para>
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// <para>部署集ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp1d19mmbsv3jf6xxxxx</para>
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// <para>节点池期望节点数量。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("desired_size")]
            [Validation(Required=false)]
            public long? DesiredSize { get; set; }

            /// <summary>
            /// <para>块设备初始化配置。</para>
            /// </summary>
            [NameInMap("disk_init")]
            [Validation(Required=false)]
            public List<DiskInit> DiskInit { get; set; }

            /// <summary>
            /// <para>自定义镜像ID，默认使用系统提供的镜像。</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_2_1903_x64_20G_alibase_20200904.vhd</para>
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>操作系统镜像类型，和platform参数二选一，取值范围：</para>
            /// <list type="bullet">
            /// <item><description><c>AliyunLinux</c>：Alinux2镜像。</description></item>
            /// <item><description><c>AliyunLinux3</c>：Alinux3镜像。</description></item>
            /// <item><description><c>AliyunLinux3Arm64</c>：Alinux3镜像ARM版。</description></item>
            /// <item><description><c>AliyunLinuxUEFI</c>：Alinux2镜像UEFI版。</description></item>
            /// <item><description><c>CentOS</c>：CentOS镜像。</description></item>
            /// <item><description><c>Windows</c>：Windows镜像。</description></item>
            /// <item><description><c>WindowsCore</c>：WindowsCore镜像。</description></item>
            /// <item><description><c>ContainerOS</c>：容器优化镜像。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunLinux</para>
            /// </summary>
            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>节点池节点付费类型，取值：</para>
            /// <list type="bullet">
            /// <item><description><c>PrePaid</c>：预付费。</description></item>
            /// <item><description><c>PostPaid</c>：按量付费。</description></item>
            /// </list>
            /// <para>默认值：<c>PostPaid</c>。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>ECS 实例的元数据访问配置。
            /// 目前仅白名单开放，需提交工单申请。</para>
            /// </summary>
            [NameInMap("instance_metadata_options")]
            [Validation(Required=false)]
            public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

            /// <summary>
            /// <para>实例规格。</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>公网IP收费类型。取值：</para>
            /// <list type="bullet">
            /// <item><description><c>PayByBandwidth</c>：按固定带宽计费。</description></item>
            /// <item><description><c>PayByTraffic</c>：按使用流量计费。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>节点公网IP出带宽最大值，单位为Mbps（Mega bit per second），取值范围：[1,100]</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>密钥对名称，和<c>login_password</c>二选一。</para>
            /// <remarks>
            /// <para>如果创建托管节点池，则只支持<c>key_pair</c>。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>np-key</para>
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// <para>弹出的ECS实例是否使用以非root用户登录。</para>
            /// </summary>
            [NameInMap("login_as_non_root")]
            [Validation(Required=false)]
            public bool? LoginAsNonRoot { get; set; }

            /// <summary>
            /// <para>SSH登录密码，和<c>key_pair</c>二选一。密码规则为8~30个字符，且至少同时包含三项（大小写字母、数字和特殊符号）。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello1234</para>
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>多可用区伸缩组ECS实例扩缩容策略。取值：</para>
            /// <list type="bullet">
            /// <item><description><para><c>PRIORITY</c>：根据您定义的虚拟交换机（VSwitchIds.N）扩缩容。当优先级较高的虚拟交换机所在可用区无法创建ECS实例时，自动使用下一优先级的虚拟交换机创建ECS实例。</para>
            /// </description></item>
            /// <item><description><para><c>COST_OPTIMIZED</c>：按vCPU单价从低到高进行尝试创建。当伸缩配置设置了抢占式计费方式的多实例规格时，优先创建对应抢占式实例。您可以继续通过<c>CompensateWithOnDemand</c>参数指定当抢占式实例由于库存等原因无法创建时，是否自动尝试以按量付费的方式创建。</para>
            /// <remarks>
            /// <para><c>COST_OPTIMIZED</c>仅在伸缩配置设置了多实例规格或者选用了抢占式实例的情况下生效。</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><c>BALANCE</c>：在伸缩组指定的多可用区之间均匀分配ECS实例。如果由于库存不足等原因可用区之间变得不平衡，您可以通过API RebalanceInstances平衡资源。更多信息，请参见<a href="https://help.aliyun.com/document_detail/71516.html">RebalanceInstances</a>。</para>
            /// </description></item>
            /// </list>
            /// <para>默认值：<c>PRIORITY</c>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>COST_OPTIMIZED</para>
            /// </summary>
            [NameInMap("multi_az_policy")]
            [Validation(Required=false)]
            public string MultiAzPolicy { get; set; }

            /// <summary>
            /// <para>伸缩组所需要按量实例个数的最小值，取值范围：[0,1000]。当按量实例个数少于该值时，将优先创建按量实例。</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// <para>伸缩组满足最小按量实例数（<c>on_demand_base_capacity</c>）要求后，超出的实例中按量实例应占的比例。取值范围：[0,100]。</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// <para>节点池节点包年包月时长，当<c>instance_charge_type</c>取值为<c>PrePaid</c>时才生效且为必选值，取值范围：<c>period_unit</c>取值为Month时，<c>period</c>取值范围：{ 1, 2, 3, 6, 12}。</para>
            /// <para>默认值：1。</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>节点池节点付费周期，当<c>instance_charge_type</c>取值为<c>PrePaid</c>时需要指定周期。</para>
            /// <para><c>Month</c>：目前只支持以月为单位。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>操作系统发行版。取值：</para>
            /// <list type="bullet">
            /// <item><description><c>CentOS</c></description></item>
            /// <item><description><c>AliyunLinux</c></description></item>
            /// <item><description><c>Windows</c></description></item>
            /// <item><description><c>WindowsCore</c></description></item>
            /// </list>
            /// <para>默认值：<c>AliyunLinux</c>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunLinux</para>
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            [Obsolete]
            public string Platform { get; set; }

            /// <summary>
            /// <para>私有节点池配置。</para>
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public NodepoolScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class NodepoolScalingGroupPrivatePoolOptions : TeaModel {
                /// <summary>
                /// <para>私有节点池ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>eap-bp67acfmxazb4****</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>私有节点池类型，实例启动的私有池容量选项。弹性保障服务或容量预定服务在生效后会生成私有池容量，供实例启动时选择。取值：</para>
                /// <list type="bullet">
                /// <item><description><para><c>Open</c>：开放模式。将自动匹配开放类型的私有池容量。如果没有符合条件的私有池容量，则使用公共池资源启动。</para>
                /// </description></item>
                /// <item><description><para><c>Target</c>：指定模式。使用指定的私有池容量启动实例，如果该私有池容量不可用，则实例会启动失败。</para>
                /// </description></item>
                /// <item><description><para><c>None</c>：不使用模式。实例启动将不使用私有池容量。</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Open</para>
                /// </summary>
                [NameInMap("match_criteria")]
                [Validation(Required=false)]
                public string MatchCriteria { get; set; }

            }

            /// <summary>
            /// <para>Worker RAM角色名称。</para>
            /// <remarks>
            /// <para>Notice: 仅1.22及以上版本的ACK托管集群支持在创建节点池时配置该参数</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>example-role</para>
            /// </summary>
            [NameInMap("ram_role_name")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>RDS实例列表。</para>
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// <para>创建实例时使用的资源池及资源池策略。当您设置该参数后，需要注意：
            /// 该参数只在创建按量付费实例时生效。
            /// 该参数不能与private_pool_options.match_criteria、private_pool_options.id同时设置。</para>
            /// </summary>
            [NameInMap("resource_pool_options")]
            [Validation(Required=false)]
            public NodepoolScalingGroupResourcePoolOptions ResourcePoolOptions { get; set; }
            public class NodepoolScalingGroupResourcePoolOptions : TeaModel {
                /// <summary>
                /// <para>私有池 ID列表。即弹性保障服务 ID 或容量预定服务 ID。该参数只能传入 Target 模式私有池 ID。N 的取值范围：1~20。</para>
                /// </summary>
                [NameInMap("private_pool_ids")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <para>创建实例时使用的资源池策略。资源池包括弹性保障服务或容量预定服务生效后生成的私有池以及公共池，供实例启动时选择。取值范围：
                /// PrivatePoolFirst：私有池优先。选择此种策略时， 当指定了 resource_pool_options.private_pool_ids，优先使用指定的私有池。如果未指定私有池或指定的私有池容量不足，将自动匹配开放类型的私有池。如果没有符合条件的私有池，则使用公共池创建实例。
                /// PrivatePoolOnly：仅限私有池。选择此种策略时，必须指定 resource_pool_options.private_pool_ids。如果指定的私有池容量不足，则实例会启动失败。
                /// None：不使用资源池策略。
                /// 默认值：None。</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrivatePoolFirst</para>
                /// </summary>
                [NameInMap("strategy")]
                [Validation(Required=false)]
                public string Strategy { get; set; }

            }

            /// <summary>
            /// <para>伸缩组模式，取值：</para>
            /// <list type="bullet">
            /// <item><description><c>release</c>：标准模式，根据申请资源值的使用量，通过创建、释放ECS的方式进行伸缩。</description></item>
            /// <item><description><c>recycle</c>：极速模式，通过创建、停机、启动的方式进行伸缩，提高再次伸缩的速度（停机时计算资源不收费，只收取存储费用，本地盘机型除外）。</description></item>
            /// </list>
            /// <para>默认值：<c>release</c>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>release</para>
            /// </summary>
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            /// <summary>
            /// <para>节点池安全组ID，与<c>security_group_ids</c>二选一，推荐使用<c>security_group_ids</c>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2zeihch86ooz9io4****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>安全组ID列表，与<c>security_group_id</c>二选一，推荐使用<c>security_group_ids</c>，当同时指定<c>security_group_id</c>和<c>security_group_ids</c>将优先使用<c>security_group_ids</c>。</para>
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>指定可用实例规格的个数，伸缩组将按成本最低的多个规格均衡创建抢占式实例。取值范围：[1,10]。</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// <para>是否开启补齐抢占式实例。开启后，当收到抢占式实例将被回收的系统消息时，伸缩组将尝试创建新的实例，替换掉将被回收的抢占式实例。取值：</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>：开启补齐抢占式实例。</description></item>
            /// <item><description><c>false</c>：不开启补齐抢占式实例。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// <para>当前单台抢占式实例规格市场价格区间配置。</para>
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<NodepoolScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class NodepoolScalingGroupSpotPriceLimit : TeaModel {
                /// <summary>
                /// <para>抢占式实例规格。</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c6.large</para>
                /// </summary>
                [NameInMap("instance_type")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>单台实例上限价格。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.39</para>
                /// </summary>
                [NameInMap("price_limit")]
                [Validation(Required=false)]
                public string PriceLimit { get; set; }

            }

            /// <summary>
            /// <para>抢占式实例类型，取值：</para>
            /// <list type="bullet">
            /// <item><description>NoSpot：非抢占式实例。</description></item>
            /// <item><description>SpotWithPriceLimit：设置抢占实例价格上限。</description></item>
            /// <item><description>SpotAsPriceGo：系统自动出价，跟随当前市场实际价格。</description></item>
            /// </list>
            /// <para>更多信息，请参见<a href="https://help.aliyun.com/document_detail/157759.html">抢占式实例</a>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>节点系统盘是否开启Burst（性能突发）。 取值：</para>
            /// <list type="bullet">
            /// <item><description>true：是。</description></item>
            /// <item><description>false：否。</description></item>
            /// </list>
            /// <para>当<c>SystemDiskCategory</c>取值为<c>cloud_auto</c>时才支持设置该参数。更多信息，请参见<a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL云盘</a>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>系统盘的多磁盘类型。当无法使用高优先级的磁盘类型时，自动尝试下一优先级的磁盘类型创建系统盘。取值范围：</para>
            /// <list type="bullet">
            /// <item><description>cloud：普通云盘。</description></item>
            /// <item><description>cloud_efficiency：高效云盘。</description></item>
            /// <item><description>cloud_ssd：SSD云盘。</description></item>
            /// <item><description>cloud_essd：ESSD云盘。</description></item>
            /// </list>
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>节点系统盘类型，取值：</para>
            /// <list type="bullet">
            /// <item><description><c>cloud_efficiency</c>：高效云盘。</description></item>
            /// <item><description><c>cloud_ssd</c>：SSD云盘。</description></item>
            /// <item><description><c>cloud_essd</c>：ESSD云盘。</description></item>
            /// <item><description><c>cloud_auto</c>：ESSD AutoPL云盘。</description></item>
            /// <item><description><c>cloud_essd_entry</c>：ESSD Entry云盘。</description></item>
            /// </list>
            /// <para>默认值：<c>cloud_efficiency</c>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>节点系统盘采用的加密算法。取值范围：aes-256。</para>
            /// 
            /// <b>Example:</b>
            /// <para>aes-256</para>
            /// </summary>
            [NameInMap("system_disk_encrypt_algorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>是否加密系统盘。取值范围：true：加密。false：不加密。</para>
            /// </summary>
            [NameInMap("system_disk_encrypted")]
            [Validation(Required=false)]
            public bool? SystemDiskEncrypted { get; set; }

            /// <summary>
            /// <para>节点系统盘使用的KMS密钥ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("system_disk_kms_key_id")]
            [Validation(Required=false)]
            public string SystemDiskKmsKeyId { get; set; }

            /// <summary>
            /// <para>节点系统盘磁盘性能，只对ESSD磁盘生效。</para>
            /// <list type="bullet">
            /// <item><description>PL0：并发极限I/O性能中等，读写时延较为稳定。</description></item>
            /// <item><description>PL1：并发极限I/O性能中等，读写时延较为稳定。</description></item>
            /// <item><description>PL2：并发极限I/O性能较高，读写时延稳定。</description></item>
            /// <item><description>PL3：并发极限I/O性能极高，读写时延极稳定。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>节点系统盘预配置的读写IOPS。可能值：0~min{50,000, 1000\*容量-基准性能}。 基准性能=min{1,800+50\*容量, 50000}。</para>
            /// <para>当<c>SystemDiskCategory</c>为<c>cloud_auto</c>时才支持设置该参数。更多信息，请参见<a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL云盘</a>。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>节点系统盘大小，单位：GiB。</para>
            /// <para>取值范围：[40,500]。</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>仅为ECS实例添加标签。</para>
            /// <para>标签键不可以重复，最大长度为128个字符；标签键和标签值都不能以“aliyun”、“acs:”开头，或包含“https://”、“http://”。</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<NodepoolScalingGroupTags> Tags { get; set; }
            public class NodepoolScalingGroupTags : TeaModel {
                /// <summary>
                /// <para>标签的名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>标签值。</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>虚拟交换机ID。</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The confidential computing configuration of the node pool.</para>
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public NodepoolTeeConfig TeeConfig { get; set; }
        public class NodepoolTeeConfig : TeaModel {
            /// <summary>
            /// <para>是否为加密计算节点池。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("tee_enable")]
            [Validation(Required=false)]
            public bool? TeeEnable { get; set; }

        }

    }

}
