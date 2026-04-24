// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ConvertFlowDSLData : TeaModel {
        /// <summary>
        /// <para>DSL兼容性分析和转换计划</para>
        /// </summary>
        [NameInMap("conversionPlan")]
        [Validation(Required=false)]
        public ConvertFlowDSLDataConversionPlan ConversionPlan { get; set; }
        public class ConvertFlowDSLDataConversionPlan : TeaModel {
            /// <summary>
            /// <para>节点兼容性问题详情</para>
            /// </summary>
            [NameInMap("issues")]
            [Validation(Required=false)]
            public List<ConvertFlowDSLDataConversionPlanIssues> Issues { get; set; }
            public class ConvertFlowDSLDataConversionPlanIssues : TeaModel {
                /// <summary>
                /// <para>问题描述</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tool node requires Toolset installation</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>问题的详细信息（JSON对象）</para>
                /// </summary>
                [NameInMap("details")]
                [Validation(Required=false)]
                public Dictionary<string, object> Details { get; set; }

                /// <summary>
                /// <para>问题类型：needs_config, needs_conversion, unsupported</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>needs_config</para>
                /// </summary>
                [NameInMap("issueType")]
                [Validation(Required=false)]
                public string IssueType { get; set; }

                /// <summary>
                /// <para>问题严重程度：info, warning, error</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>warning</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>Dify DSL中的节点标识符</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1760514991682</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>节点显示名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>Google Search</para>
                /// </summary>
                [NameInMap("nodeTitle")]
                [Validation(Required=false)]
                public string NodeTitle { get; set; }

                /// <summary>
                /// <para>节点类型</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tool</para>
                /// </summary>
                [NameInMap("nodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>解决建议</para>
                /// 
                /// <b>Example:</b>
                /// <para>Install Toolset &quot;google&quot; before using this flow</para>
                /// </summary>
                [NameInMap("suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            /// <summary>
            /// <para>节点兼容性统计摘要</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public ConvertFlowDSLDataConversionPlanSummary Summary { get; set; }
            public class ConvertFlowDSLDataConversionPlanSummary : TeaModel {
                /// <summary>
                /// <para>完全兼容的节点数</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("compatibleNodes")]
                [Validation(Required=false)]
                public int? CompatibleNodes { get; set; }

                /// <summary>
                /// <para>需要手动配置的节点数</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("nodesNeedConfig")]
                [Validation(Required=false)]
                public int? NodesNeedConfig { get; set; }

                /// <summary>
                /// <para>需要特殊转换处理的节点数</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("nodesNeedConversion")]
                [Validation(Required=false)]
                public int? NodesNeedConversion { get; set; }

                /// <summary>
                /// <para>Dify DSL中的总节点数</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("totalNodes")]
                [Validation(Required=false)]
                public int? TotalNodes { get; set; }

                /// <summary>
                /// <para>不支持的节点数</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("unsupportedNodes")]
                [Validation(Required=false)]
                public int? UnsupportedNodes { get; set; }

            }

        }

        /// <summary>
        /// <para>转换后的AgentRun Flow配置信息</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("flow")]
        [Validation(Required=false)]
        public ConvertFlowDSLDataFlow Flow { get; set; }
        public class ConvertFlowDSLDataFlow : TeaModel {
            /// <summary>
            /// <para>工作流的FnF State Machine定义（YAML格式）</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            /// <summary>
            /// <para>工作流的描述信息</para>
            /// 
            /// <b>Example:</b>
            /// <para>Converted from external workflow</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>工作流的环境变量配置</para>
            /// </summary>
            [NameInMap("environmentConfiguration")]
            [Validation(Required=false)]
            public EnvironmentConfiguration EnvironmentConfiguration { get; set; }

            /// <summary>
            /// <para>转换后的工作流名称</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dify-flow</para>
            /// </summary>
            [NameInMap("flowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

        }

        /// <summary>
        /// <para>插件识别或转换过程中的错误信息</para>
        /// </summary>
        [NameInMap("pluginErrors")]
        [Validation(Required=false)]
        public List<ConvertFlowDSLDataPluginErrors> PluginErrors { get; set; }
        public class ConvertFlowDSLDataPluginErrors : TeaModel {
            /// <summary>
            /// <para>相关节点的标识符</para>
            /// 
            /// <b>Example:</b>
            /// <para>1760514996015</para>
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>插件提供商名称</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>langgenius</para>
            /// </summary>
            [NameInMap("providerName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

            /// <summary>
            /// <para>错误原因描述</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Plugin not found in marketplace</para>
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>工具名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>google_search</para>
            /// </summary>
            [NameInMap("toolName")]
            [Validation(Required=false)]
            public string ToolName { get; set; }

        }

        /// <summary>
        /// <para>需要安装的Toolset配置列表</para>
        /// </summary>
        [NameInMap("toolsetInstallations")]
        [Validation(Required=false)]
        public List<ConvertFlowDSLDataToolsetInstallations> ToolsetInstallations { get; set; }
        public class ConvertFlowDSLDataToolsetInstallations : TeaModel {
            /// <summary>
            /// <para>Toolset描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>Google Search Plugin</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Toolset名称</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>google</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Toolset规格配置（JSON对象）</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("spec")]
            [Validation(Required=false)]
            public Dictionary<string, object> Spec { get; set; }

        }

    }

}
