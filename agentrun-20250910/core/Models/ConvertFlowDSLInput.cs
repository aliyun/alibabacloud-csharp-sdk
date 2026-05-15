// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ConvertFlowDSLInput : TeaModel {
        /// <summary>
        /// <para>工作流DSL的来源配置，支持inline和base64两种格式</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dslSource")]
        [Validation(Required=false)]
        public ConvertFlowDSLInputDslSource DslSource { get; set; }
        public class ConvertFlowDSLInputDslSource : TeaModel {
            /// <summary>
            /// <para>DSL内容，可以是原始JSON字符串，或根据encoding字段指定的编码格式</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;app&quot;:{&quot;name&quot;:&quot;My Flow&quot;}}</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>DSL内容的编码方式。不填表示内容为原始字符串；base64表示内容经过Base64编码；base64+gzip表示内容经过gzip压缩后再Base64编码</para>
            /// 
            /// <b>Example:</b>
            /// <para>base64</para>
            /// </summary>
            [NameInMap("encoding")]
            [Validation(Required=false)]
            public string Encoding { get; set; }

            /// <summary>
            /// <para>源DSL的提供商类型，如：dify、n8n、zapier等</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dify</para>
            /// </summary>
            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

        }

        /// <summary>
        /// <para>DSL转换的可选配置参数</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public ConvertFlowDSLInputOptions Options { get; set; }
        public class ConvertFlowDSLInputOptions : TeaModel {
            /// <summary>
            /// <para>是否执行兼容性检查，默认为true</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("compatibilityCheck")]
            [Validation(Required=false)]
            public bool? CompatibilityCheck { get; set; }

            /// <summary>
            /// <para>调用方指定的 AgentRun 凭证资源名称。转换后会替换模型相关节点访问凭证</para>
            /// </summary>
            [NameInMap("credentialName")]
            [Validation(Required=false)]
            public string CredentialName { get; set; }

            [NameInMap("flowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

            /// <summary>
            /// <para>全局VPC端点名称，对所有节点统一生效。如果指定了vpcEndpoints映射，则映射中的节点优先使用映射值</para>
            /// </summary>
            [NameInMap("vpcEndpointName")]
            [Validation(Required=false)]
            public string VpcEndpointName { get; set; }

            /// <summary>
            /// <para>按节点名称指定VPC端点，key为节点名称(stateName)，value为该节点使用的VPC端点名称。优先级高于vpcEndpointName</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;LLM节点&quot;:&quot;vpc-endpoint-1&quot;,&quot;Agent节点&quot;:&quot;vpc-endpoint-2&quot;}</para>
            /// </summary>
            [NameInMap("vpcEndpoints")]
            [Validation(Required=false)]
            public Dictionary<string, string> VpcEndpoints { get; set; }

        }

    }

}
