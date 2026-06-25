// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The visibility of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PUBLIC: All members in the current workspace can access the resource.</para>
        /// </description></item>
        /// <item><description><para>PRIVATE: Only the creator can access the resource.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The configuration information of the connection.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Configs { get; set; }

        /// <summary>
        /// <para>The connection ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conn-pai9m***mi47</para>
        /// </summary>
        [NameInMap("ConnectionId")]
        [Validation(Required=false)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// <para>The name of the connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Database connection</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The type of the connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DashScopeConnection: A connection to a Model Studio service.</para>
        /// </description></item>
        /// <item><description><para>OpenLLMConnection: A connection to an open-source model.</para>
        /// </description></item>
        /// <item><description><para>MilvusConnection: A connection to Milvus.</para>
        /// </description></item>
        /// <item><description><para>OpenSearchConnection: A connection to OpenSearch.</para>
        /// </description></item>
        /// <item><description><para>LindormConnection: A connection to Lindorm.</para>
        /// </description></item>
        /// <item><description><para>ElasticsearchConnection: A connection to Elasticsearch.</para>
        /// </description></item>
        /// <item><description><para>HologresConnection: A connection to Hologres.</para>
        /// </description></item>
        /// <item><description><para>RDSConnection: A connection to RDS.</para>
        /// </description></item>
        /// <item><description><para>CustomConnection: A custom connection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OpenSearchConnection</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The creator of the connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28632***898231</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The description of the connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用于数据集检索。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The UTC time when the connection was created. The time is in the ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-07T07:54:56Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The UTC time when the connection was last modified. The time is in the ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-07T07:54:56Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The list of models. This parameter is applicable to connections of the model service type.</para>
        /// </summary>
        [NameInMap("Models")]
        [Validation(Required=false)]
        public List<GetConnectionResponseBodyModels> Models { get; set; }
        public class GetConnectionResponseBodyModels : TeaModel {
            /// <summary>
            /// <para>The display name of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试语言模型。</para>
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
            /// <item><description><para>LLM: A large language model (LLM).</para>
            /// </description></item>
            /// <item><description><para>Embedding: An embedding model.</para>
            /// </description></item>
            /// <item><description><para>ReRank: A reranking model.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LLM</para>
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>Indicates whether tool calling is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Tool calling is supported.</para>
            /// </description></item>
            /// <item><description><para>false: Tool calling is not supported.</para>
            /// </description></item>
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
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The instance resource information of the connection. This parameter is typically used for database connections.</para>
        /// </summary>
        [NameInMap("ResourceMeta")]
        [Validation(Required=false)]
        public GetConnectionResponseBodyResourceMeta ResourceMeta { get; set; }
        public class GetConnectionResponseBodyResourceMeta : TeaModel {
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
            /// <para>ld-2vc1***v1zaqgzol</para>
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
        /// <para>The key-value pairs that need to be encrypted. Examples include the logon password for a database and the key for a model connection.</para>
        /// </summary>
        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public Dictionary<string, string> Secrets { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11**43</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
