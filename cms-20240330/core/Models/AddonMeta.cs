// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AddonMeta : TeaModel {
        /// <summary>
        /// <para>组件别名，显示名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS 监控</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>组件分类信息</para>
        /// </summary>
        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// <para>组件示意图列表</para>
        /// </summary>
        [NameInMap("dashboards")]
        [Validation(Required=false)]
        public List<AddonMetaDashboards> Dashboards { get; set; }
        public class AddonMetaDashboards : TeaModel {
            /// <summary>
            /// <para>描述信息</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述信息</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>示意图名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS 监控概览大盘</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>示意图 URL</para>
            /// 
            /// <b>Example:</b>
            /// <para>assets/dashboards/ecs.png</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>描述信息。</para>
        /// 
        /// <b>Example:</b>
        /// <para>The out-of-the-box and comprehensive ECS observe dashboards and alarm rules. Based on AliYun CloudMonitor agentless metrics, exporter agent metrics, host audit logs, host events and other data.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>支持的环境类型列表</para>
        /// </summary>
        [NameInMap("environments")]
        [Validation(Required=false)]
        public List<AddonMetaEnvironments> Environments { get; set; }
        public class AddonMetaEnvironments : TeaModel {
            /// <summary>
            /// <para>绑定的CommonSchema 列表</para>
            /// </summary>
            [NameInMap("commonSchemaRefs")]
            [Validation(Required=false)]
            public List<AddonMetaEnvironmentsCommonSchemaRefs> CommonSchemaRefs { get; set; }
            public class AddonMetaEnvironmentsCommonSchemaRefs : TeaModel {
                /// <summary>
                /// <para>CommonSchema 的分组名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs-ecs</para>
                /// </summary>
                [NameInMap("group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// <para>CommonSchema 的分组版本</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>依赖描述信息</para>
            /// </summary>
            [NameInMap("dependencies")]
            [Validation(Required=false)]
            public AddonMetaEnvironmentsDependencies Dependencies { get; set; }
            public class AddonMetaEnvironmentsDependencies : TeaModel {
                /// <summary>
                /// <para>支持的集群类型</para>
                /// </summary>
                [NameInMap("clusterTypes")]
                [Validation(Required=false)]
                public List<string> ClusterTypes { get; set; }

                /// <summary>
                /// <para>探针依赖描述，组件名称。新版已由 collectors 字段替换</para>
                /// </summary>
                [NameInMap("features")]
                [Validation(Required=false)]
                public Dictionary<string, bool?> Features { get; set; }

                /// <summary>
                /// <para>依赖的服务列表</para>
                /// </summary>
                [NameInMap("services")]
                [Validation(Required=false)]
                public List<string> Services { get; set; }

            }

            /// <summary>
            /// <para>环境类型的描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>支持容器集群的工作覆盖监控</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>是否启用</para>
            /// 
            /// <b>Example:</b>
            /// <para>true/false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>环境类型显示名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>容器环境</para>
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>环境类型名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS/ECS/Cloud/Client</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>组件的控制策略组合信息</para>
            /// </summary>
            [NameInMap("policies")]
            [Validation(Required=false)]
            public AddonMetaEnvironmentsPolicies Policies { get; set; }
            public class AddonMetaEnvironmentsPolicies : TeaModel {
                /// <summary>
                /// <para>告警规则默认安装后是否启用</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("alertDefaultStatus")]
                [Validation(Required=false)]
                public string AlertDefaultStatus { get; set; }

                /// <summary>
                /// <para>默认模式，即无需绑定实体的接入模式。</para>
                /// 
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("bindDefaultPolicy")]
                [Validation(Required=false)]
                public bool? BindDefaultPolicy { get; set; }

                /// <summary>
                /// <para>绑定的目标实体信息</para>
                /// </summary>
                [NameInMap("bindEntity")]
                [Validation(Required=false)]
                public AddonMetaEnvironmentsPoliciesBindEntity BindEntity { get; set; }
                public class AddonMetaEnvironmentsPoliciesBindEntity : TeaModel {
                    /// <summary>
                    /// <para>是否是组模式</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true/false</para>
                    /// </summary>
                    [NameInMap("entityGroupMode")]
                    [Validation(Required=false)]
                    public bool? EntityGroupMode { get; set; }

                    /// <summary>
                    /// <para>实体类型</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs.ecs.instance</para>
                    /// </summary>
                    [NameInMap("entityType")]
                    [Validation(Required=false)]
                    public string EntityType { get; set; }

                    /// <summary>
                    /// <para>是否是单实体模式</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true/false</para>
                    /// </summary>
                    [NameInMap("singleEntityMode")]
                    [Validation(Required=false)]
                    public bool? SingleEntityMode { get; set; }

                    /// <summary>
                    /// <para>实体中提取VPC ID 信息的字段</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpcId</para>
                    /// </summary>
                    [NameInMap("vpcIdFieldKey")]
                    [Validation(Required=false)]
                    public string VpcIdFieldKey { get; set; }

                }

                /// <summary>
                /// <para>是否默认安装</para>
                /// 
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("defaultInstall")]
                [Validation(Required=false)]
                public bool? DefaultInstall { get; set; }

                /// <summary>
                /// <para>是否启用内部授权Token分配</para>
                /// 
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("enableServiceAccount")]
                [Validation(Required=false)]
                public bool? EnableServiceAccount { get; set; }

                /// <summary>
                /// <para>组件接入后的数据检查规则</para>
                /// </summary>
                [NameInMap("metricCheckRule")]
                [Validation(Required=false)]
                public AddonMetaEnvironmentsPoliciesMetricCheckRule MetricCheckRule { get; set; }
                public class AddonMetaEnvironmentsPoliciesMetricCheckRule : TeaModel {
                    /// <summary>
                    /// <para>检测规则 PromQL</para>
                    /// </summary>
                    [NameInMap("promQL")]
                    [Validation(Required=false)]
                    public List<string> PromQL { get; set; }

                }

                /// <summary>
                /// <para>是否需要在接入后提示重启工作负载</para>
                /// 
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("needRestartAfterIntegration")]
                [Validation(Required=false)]
                public bool? NeedRestartAfterIntegration { get; set; }

                /// <summary>
                /// <para>支持的客户端协议信息列表</para>
                /// </summary>
                [NameInMap("protocols")]
                [Validation(Required=false)]
                public List<AddonMetaEnvironmentsPoliciesProtocols> Protocols { get; set; }
                public class AddonMetaEnvironmentsPoliciesProtocols : TeaModel {
                    /// <summary>
                    /// <para>协议描述</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>使用 Prometheus 协议写入指标数据</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>协议显示icon</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>assets/logos/ecs.svg</para>
                    /// </summary>
                    [NameInMap("icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    /// <summary>
                    /// <para>协议显示名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Prometheus 协议</para>
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>协议名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Prometheus</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>跳转的目标组件名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud-acs-ecs</para>
                /// </summary>
                [NameInMap("targetAddonName")]
                [Validation(Required=false)]
                public string TargetAddonName { get; set; }

            }

            /// <summary>
            /// <para>策略类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>组件图标。</para>
        /// 
        /// <b>Example:</b>
        /// <para>assets/logos/ecs.svg</para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <para>关键词列表</para>
        /// </summary>
        [NameInMap("keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// <para>语言，取值：</para>
        /// <list type="bullet">
        /// <item><description>zh：中文（默认值）</description></item>
        /// <item><description>en：英文</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>该组件上一次接入时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-25 09:12:12</para>
        /// </summary>
        [NameInMap("latestReleaseCreateTime")]
        [Validation(Required=false)]
        public string LatestReleaseCreateTime { get; set; }

        /// <summary>
        /// <para>组件名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud-acs-ecs</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Policy 下是否只能安装一次</para>
        /// 
        /// <b>Example:</b>
        /// <para>true/false</para>
        /// </summary>
        [NameInMap("once")]
        [Validation(Required=false)]
        public bool? Once { get; set; }

        /// <summary>
        /// <para>场景</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>版本号</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>组件排序权重</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
