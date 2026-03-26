// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Connection : TeaModel {
        /// <summary>
        /// <para>The workspace accessibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE (default): accessible only to you and the administrator of the workspace.</description></item>
        /// <item><description>PUBLIC: accessible to all members in the workspace.</description></item>
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
        /// <para>The connection type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DashScopeConnection</description></item>
        /// <item><description>OpenLLMConnection</description></item>
        /// <item><description>MilvusConnection</description></item>
        /// <item><description>OpenSearchConnection</description></item>
        /// <item><description>LindormConnection</description></item>
        /// <item><description>ElasticsearchConnection</description></item>
        /// <item><description>HologresConnection</description></item>
        /// <item><description>RDSConnection</description></item>
        /// <item><description>CustomConnection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ElasticsearchConnection</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The connection creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20925961****557803</para>
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
        /// <para>The time when the connection was modified, in UTC. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-07T07:54:56Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the connection was modified, in UTC. The time follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-07T07:54:56Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The models.</para>
        /// </summary>
        [NameInMap("Models")]
        [Validation(Required=false)]
        public List<ConnectionModels> Models { get; set; }
        public class ConnectionModels : TeaModel {
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
            /// <para>Indicates whether tool calling was supported. Valid values:</para>
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
        /// <para>The connection resource. This parameter is used for the connection configuration of the database type.</para>
        /// </summary>
        [NameInMap("ResourceMeta")]
        [Validation(Required=false)]
        public ConnectionResourceMeta ResourceMeta { get; set; }
        public class ConnectionResourceMeta : TeaModel {
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
        /// <para>The key-value configuration to be encrypted, such as the database logon password and the key for model connection.</para>
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
