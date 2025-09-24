// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The resource accessibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: All members in the workspace can access the workspace.</description></item>
        /// <item><description>PRIVATE: Only the creator can access the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The connection configuration.</para>
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
        /// <para>The connection name.</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The type of the connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DashScopeConnection: Alibaba Cloud Model Studio connection.</description></item>
        /// <item><description>OpenLLMConnection: Open source model connection.</description></item>
        /// <item><description>MilvusConnection: Milvus connection.</description></item>
        /// <item><description>OpenSearchConnection: OpenSearch connection.</description></item>
        /// <item><description>LindormConnection: Lindorm connection.</description></item>
        /// <item><description>ElasticsearchConnection: Elasticsearch connection.</description></item>
        /// <item><description>HologresConnection: Hologres connection.</description></item>
        /// <item><description>RDSConnection: RDS connection.</description></item>
        /// <item><description>CustomConnection: Custom connection.</description></item>
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
        /// <para>The connection description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the connection is created, in UTC. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-07T07:54:56Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the connection is modified, in UTC. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-07T07:54:56Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The models, which apply to model service connections.</para>
        /// </summary>
        [NameInMap("Models")]
        [Validation(Required=false)]
        public List<GetConnectionResponseBodyModels> Models { get; set; }
        public class GetConnectionResponseBodyModels : TeaModel {
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
            /// <para>Indicates whether a tool can be called by using ToolCall. Valid values:</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The instance resource information of the connection, which applies to database connections.</para>
        /// </summary>
        [NameInMap("ResourceMeta")]
        [Validation(Required=false)]
        public GetConnectionResponseBodyResourceMeta ResourceMeta { get; set; }
        public class GetConnectionResponseBodyResourceMeta : TeaModel {
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
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        /// <summary>
        /// <para>The encrypted configuration, in key-value pairs. Examples: the database logon password and the key of the model connection.</para>
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
