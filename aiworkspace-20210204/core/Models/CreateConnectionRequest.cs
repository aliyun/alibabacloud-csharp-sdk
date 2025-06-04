// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The accessibility of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE: The workspace is accessible only to you and the administrator of the workspace. This is the default value.</description></item>
        /// <item><description>PUBLIC: The workspace is accessible to all users in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The connection configurations, in key-value pairs. The key varies based on the connection type. For more information, see the supplementary notes below the request parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Configs { get; set; }

        /// <summary>
        /// <para>The connection name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-connection</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The connection type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DashScopeConnection: Alibaba Cloud Model Studio connection</description></item>
        /// <item><description>OpenLLMConnection: open source model connection</description></item>
        /// <item><description>MilvusConnection: Milvus connection</description></item>
        /// <item><description>OpenSearchConnection: OpenSearch connection</description></item>
        /// <item><description>LindormConnection: Lindorm connection</description></item>
        /// <item><description>ElasticsearchConnection: Elasticsearch connection</description></item>
        /// <item><description>HologresConnection: Hologres connection</description></item>
        /// <item><description>RDSConnection: RDS connection</description></item>
        /// <item><description>CustomConnection: custom connection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DashScopeConnection</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The connection description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The models, which apply to model service connections.</para>
        /// </summary>
        [NameInMap("Models")]
        [Validation(Required=false)]
        public List<CreateConnectionRequestModels> Models { get; set; }
        public class CreateConnectionRequestModels : TeaModel {
            /// <summary>
            /// <para>The display name of the model.</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The model identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model_001</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The model type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LLM</description></item>
            /// <item><description>Embedding</description></item>
            /// <item><description>ReRank</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LLM</para>
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>Specifies whether a tool can be called by using ToolCall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ToolCall")]
            [Validation(Required=false)]
            public bool? ToolCall { get; set; }

        }

        /// <summary>
        /// <para>The instance resource information of the connection, which applies to database connections.</para>
        /// </summary>
        [NameInMap("ResourceMeta")]
        [Validation(Required=false)]
        public CreateConnectionRequestResourceMeta ResourceMeta { get; set; }
        public class CreateConnectionRequestResourceMeta : TeaModel {
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
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        /// <summary>
        /// <para>The configuration to be encrypted. Examples: the database logon account and password and the key of the model service.</para>
        /// </summary>
        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public Dictionary<string, string> Secrets { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123**45</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
