// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class UpdateWorkerRequest : TeaModel {
        /// <summary>
        /// <para>The Agents configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agents-demo</para>
        /// </summary>
        [NameInMap("Agents")]
        [Validation(Required=false)]
        public string Agents { get; set; }

        /// <summary>
        /// <para>The list of channel configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public List<UpdateWorkerRequestChannels> Channels { get; set; }
        public class UpdateWorkerRequestChannels : TeaModel {
            /// <summary>
            /// <para>The channel configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public UpdateWorkerRequestChannelsConfig Config { get; set; }
            public class UpdateWorkerRequestChannelsConfig : TeaModel {
                /// <summary>
                /// <para>The response data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tpl-demo</para>
                /// </summary>
                [NameInMap("CardTemplateId")]
                [Validation(Required=false)]
                public string CardTemplateId { get; set; }

                /// <summary>
                /// <para>The response data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cli-demo</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The response data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>extension-demo</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>The response data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>markdown</para>
                /// </summary>
                [NameInMap("MessageType")]
                [Validation(Required=false)]
                public string MessageType { get; set; }

                /// <summary>
                /// <para>The response data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>robot-demo</para>
                /// </summary>
                [NameInMap("RobotCode")]
                [Validation(Required=false)]
                public string RobotCode { get; set; }

                /// <summary>
                /// <para>The response data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ShowThinking")]
                [Validation(Required=false)]
                public bool? ShowThinking { get; set; }

                /// <summary>
                /// <para>The response data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ShowToolCalls")]
                [Validation(Required=false)]
                public bool? ShowToolCalls { get; set; }

                /// <summary>
                /// <para>The response data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("StreamingEnabled")]
                [Validation(Required=false)]
                public bool? StreamingEnabled { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the channel is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The channel secrets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Secrets")]
            [Validation(Required=false)]
            public UpdateWorkerRequestChannelsSecrets Secrets { get; set; }
            public class UpdateWorkerRequestChannelsSecrets : TeaModel {
                /// <summary>
                /// <para>The response data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>secret-demo</para>
                /// </summary>
                [NameInMap("ClientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

            }

            /// <summary>
            /// <para>The channel type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingtalk</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The idempotency token that ensures the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-demo</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of credential bindings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public List<UpdateWorkerRequestCredentials> Credentials { get; set; }
        public class UpdateWorkerRequestCredentials : TeaModel {
            /// <summary>
            /// <para>The credential name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cred-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inst-demo</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The quota configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("LimitConfig")]
        [Validation(Required=false)]
        public UpdateWorkerRequestLimitConfig LimitConfig { get; set; }
        public class UpdateWorkerRequestLimitConfig : TeaModel {
            /// <summary>
            /// <para>The response data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>token</para>
            /// </summary>
            [NameInMap("LimitType")]
            [Validation(Required=false)]
            public string LimitType { get; set; }

            /// <summary>
            /// <para>The response data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("PeriodType")]
            [Validation(Required=false)]
            public string PeriodType { get; set; }

            /// <summary>
            /// <para>The usage limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("UsageLimit")]
            [Validation(Required=false)]
            public long? UsageLimit { get; set; }

        }

        /// <summary>
        /// <para>The list of MCP servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("McpServers")]
        [Validation(Required=false)]
        public List<UpdateWorkerRequestMcpServers> McpServers { get; set; }
        public class UpdateWorkerRequestMcpServers : TeaModel {
            /// <summary>
            /// <para>The MCP server name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-server-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The model configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public UpdateWorkerRequestModel Model { get; set; }
        public class UpdateWorkerRequestModel : TeaModel {
            /// <summary>
            /// <para>The response data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-max</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The response data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dashscope</para>
            /// </summary>
            [NameInMap("ModelProvider")]
            [Validation(Required=false)]
            public string ModelProvider { get; set; }

        }

        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>worker-demo</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of skills.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public List<UpdateWorkerRequestSkills> Skills { get; set; }
        public class UpdateWorkerRequestSkills : TeaModel {
            /// <summary>
            /// <para>The skill label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Code Review.</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>code-review</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The Soul configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>soul-demo</para>
        /// </summary>
        [NameInMap("Soul")]
        [Validation(Required=false)]
        public string Soul { get; set; }

        /// <summary>
        /// <para>The template configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public UpdateWorkerRequestTemplate Template { get; set; }
        public class UpdateWorkerRequestTemplate : TeaModel {
            /// <summary>
            /// <para>The response data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Label.</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The response data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>worker-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The response data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The Worker version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.0.0</para>
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}
