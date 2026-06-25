// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the workspace. The default value is <c>PRIVATE</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>Configuration properties for the connection, provided as key-value pairs. The required keys depend on the connection type. For details, see the supplementary parameter information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Configs { get; set; }

        /// <summary>
        /// <para>The name of the connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-connection</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The type of the connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DashScopeConnection</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The description of the connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open-source LLM service connection.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A list of models. This parameter applies to model service connections.</para>
        /// </summary>
        [NameInMap("Models")]
        [Validation(Required=false)]
        public List<CreateConnectionRequestModels> Models { get; set; }
        public class CreateConnectionRequestModels : TeaModel {
            /// <summary>
            /// <para>The display name of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Language model</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The context length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("MaxModelLength")]
            [Validation(Required=false)]
            public long? MaxModelLength { get; set; }

            /// <summary>
            /// <para>The model identifier. This value corresponds to the <c>model</c> parameter in an OpenAI API request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model_001</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The model type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LLM</para>
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>Specifies whether the model supports deep reasoning and can output the reasoning process as <c>reasoning_content</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportReasoning")]
            [Validation(Required=false)]
            public bool? SupportReasoning { get; set; }

            /// <summary>
            /// <para>Specifies whether the model supports structured output in the OpenAI API\&quot;s JSON Schema format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportResponseSchema")]
            [Validation(Required=false)]
            public bool? SupportResponseSchema { get; set; }

            /// <summary>
            /// <para>Specifies whether the model supports visual understanding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportVision")]
            [Validation(Required=false)]
            public bool? SupportVision { get; set; }

            /// <summary>
            /// <para>Specifies whether the model supports tool calling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ToolCall")]
            [Validation(Required=false)]
            public bool? ToolCall { get; set; }

        }

        /// <summary>
        /// <para>Resource metadata for the connection. This parameter is typically used for database connection types.</para>
        /// </summary>
        [NameInMap("ResourceMeta")]
        [Validation(Required=false)]
        public CreateConnectionRequestResourceMeta ResourceMeta { get; set; }
        public class CreateConnectionRequestResourceMeta : TeaModel {
            /// <summary>
            /// <para>Additional configuration information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;vpcId&quot;:&quot;vpc-xxxx&quot;}</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ld-uf69****9nqjjes</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test instance.</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        /// <summary>
        /// <para>Sensitive connection properties that require encryption, such as database credentials or an API key for a model service.</para>
        /// </summary>
        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public Dictionary<string, string> Secrets { get; set; }

        /// <summary>
        /// <para>The ID of the workspace. To get this ID, call the <a href="https://help.aliyun.com/document_detail/449124.html"><c>ListWorkspaces</c></a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123**45</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
