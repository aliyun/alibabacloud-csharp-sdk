// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Connection : TeaModel {
        /// <summary>
        /// <para>The workspace visibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PRIVATE (default): The connection is visible only to you and administrators in the workspace.</para>
        /// </description></item>
        /// <item><description><para>PUBLIC: The connection is visible to all users in the workspace.</para>
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
        /// <para>The connection configurations.</para>
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
        /// <para>lindorm-connection</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The connection type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DashScopeConnection: A service connection to Alibaba Cloud Model Studio.</para>
        /// </description></item>
        /// <item><description><para>OpenLLMConnection: An open source model connection.</para>
        /// </description></item>
        /// <item><description><para>MilvusConnection: A Milvus connection.</para>
        /// </description></item>
        /// <item><description><para>OpenSearchConnection: An OpenSearch connection.</para>
        /// </description></item>
        /// <item><description><para>LindormConnection: A Lindorm connection.</para>
        /// </description></item>
        /// <item><description><para>ElasticsearchConnection: An Elasticsearch connection.</para>
        /// </description></item>
        /// <item><description><para>HologresConnection: A Hologres connection.</para>
        /// </description></item>
        /// <item><description><para>RDSConnection: An RDS connection.</para>
        /// </description></item>
        /// <item><description><para>CustomConnection: A custom connection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ElasticsearchConnection</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The creator of the connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20925961****557803</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The connection description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description of a database connection.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the connection was created. The time is in UTC and follows the ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-07T07:54:56Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the connection was last modified. The time is in UTC and follows the ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-07T07:54:56Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The model list.</para>
        /// </summary>
        [NameInMap("Models")]
        [Validation(Required=false)]
        public List<ConnectionModels> Models { get; set; }
        public class ConnectionModels : TeaModel {
            /// <summary>
            /// <para>The model\&quot;s display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BGE model deploy.</para>
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
            /// <item><description><para>LLM (large language model)</para>
            /// </description></item>
            /// <item><description><para>Embedding (Embedding model)</para>
            /// </description></item>
            /// <item><description><para>ReRank (ReRank model)</para>
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
            /// <item><description><para>true: Supported</para>
            /// </description></item>
            /// <item><description><para>false: Not supported</para>
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
        /// <para>The resource information for the connection. This usually applies to database connection configurations.</para>
        /// </summary>
        [NameInMap("ResourceMeta")]
        [Validation(Required=false)]
        public ConnectionResourceMeta ResourceMeta { get; set; }
        public class ConnectionResourceMeta : TeaModel {
            /// <summary>
            /// <para>Extra configuration information.</para>
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
            /// <para>lindorm-xxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        /// <summary>
        /// <para>The key-value configurations to encrypt, such as database logon passwords and model connection keys.</para>
        /// </summary>
        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public Dictionary<string, string> Secrets { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>228**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
