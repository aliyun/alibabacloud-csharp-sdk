// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ResetWorkflowNodeConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>当前用户是否可编辑此节点</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("canEdit")]
        [Validation(Required=false)]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// <para>公共业务状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>配置版本；更新或恢复时作为expectedVersion</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("configVersion")]
        [Validation(Required=false)]
        public long? ConfigVersion { get; set; }

        /// <summary>
        /// <para>模板默认执行主体</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;AGENT&quot;,&quot;id&quot;:&quot;agent_1001&quot;}</para>
        /// </summary>
        [NameInMap("defaultExecutor")]
        [Validation(Required=false)]
        public ResetWorkflowNodeConfigurationResponseBodyDefaultExecutor DefaultExecutor { get; set; }
        public class ResetWorkflowNodeConfigurationResponseBodyDefaultExecutor : TeaModel {
            /// <summary>
            /// <para>USER 为正整数平台用户ID字符串；AGENT 为空间数字员工技术名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent_1001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>USER 真人、AGENT 数字员工或历史 SYSTEM 系统执行人；SYSTEM仅用于响应</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>模板默认模型运行档</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("defaultModel")]
        [Validation(Required=false)]
        public string DefaultModel { get; set; }

        /// <summary>
        /// <para>模板默认负责人用户ID列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10001]</para>
        /// </summary>
        [NameInMap("defaultResponsibleUserIds")]
        [Validation(Required=false)]
        public List<string> DefaultResponsibleUserIds { get; set; }

        /// <summary>
        /// <para>当前生效的执行主体</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;AGENT&quot;,&quot;id&quot;:&quot;agent_1001&quot;}</para>
        /// </summary>
        [NameInMap("effectiveExecutor")]
        [Validation(Required=false)]
        public ResetWorkflowNodeConfigurationResponseBodyEffectiveExecutor EffectiveExecutor { get; set; }
        public class ResetWorkflowNodeConfigurationResponseBodyEffectiveExecutor : TeaModel {
            /// <summary>
            /// <para>USER 为正整数平台用户ID字符串；AGENT 为空间数字员工技术名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent_1001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>USER 真人、AGENT 数字员工或历史 SYSTEM 系统执行人；SYSTEM仅用于响应</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>当前生效的模型运行档</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max-plus</para>
        /// </summary>
        [NameInMap("effectiveModel")]
        [Validation(Required=false)]
        public string EffectiveModel { get; set; }

        /// <summary>
        /// <para>当前生效的负责人用户ID列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10001]</para>
        /// </summary>
        [NameInMap("effectiveResponsibleUserIds")]
        [Validation(Required=false)]
        public List<string> EffectiveResponsibleUserIds { get; set; }

        /// <summary>
        /// <para>当前物理计划ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>inst_2081</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>公共错误描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求的资源不存在</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>业务节点key</para>
        /// 
        /// <b>Example:</b>
        /// <para>node_7f3a2c</para>
        /// </summary>
        [NameInMap("nodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>实例覆盖值；字段为null时使用模板默认值</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;model&quot;:&quot;qwen-max-plus&quot;}</para>
        /// </summary>
        [NameInMap("overrides")]
        [Validation(Required=false)]
        public ResetWorkflowNodeConfigurationResponseBodyOverrides Overrides { get; set; }
        public class ResetWorkflowNodeConfigurationResponseBodyOverrides : TeaModel {
            /// <summary>
            /// <para>覆盖执行主体；null为默认</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;AGENT&quot;,&quot;id&quot;:&quot;agent_1001&quot;}</para>
            /// </summary>
            [NameInMap("executor")]
            [Validation(Required=false)]
            public ResetWorkflowNodeConfigurationResponseBodyOverridesExecutor Executor { get; set; }
            public class ResetWorkflowNodeConfigurationResponseBodyOverridesExecutor : TeaModel {
                /// <summary>
                /// <para>USER 为正整数平台用户ID字符串；AGENT 为空间数字员工技术名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent_1001</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>USER 真人、AGENT 数字员工或历史 SYSTEM 系统执行人；SYSTEM仅用于响应</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGENT</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>覆盖模型运行档；null为默认</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-max</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>覆盖负责人ID列表；null为默认</para>
            /// 
            /// <b>Example:</b>
            /// <para>[10001]</para>
            /// </summary>
            [NameInMap("responsibleUserIds")]
            [Validation(Required=false)]
            public List<long?> ResponsibleUserIds { get; set; }

        }

        /// <summary>
        /// <para>请求追踪ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>状态刷新游标，不能作为配置版本</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("stateVersion")]
        [Validation(Required=false)]
        public long? StateVersion { get; set; }

        /// <summary>
        /// <para>最后配置更新时间ISO8601；从未更新时为空</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T08:00:00Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>最后更新配置的平台用户ID；从未更新时为空</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public long? UpdatedBy { get; set; }

    }

}
