// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class CreateWorkerRequest : TeaModel {
        /// <summary>
        /// <para>The Agent runtime type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwenpaw</para>
        /// </summary>
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

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
        public List<CreateWorkerRequestChannels> Channels { get; set; }
        public class CreateWorkerRequestChannels : TeaModel {
            /// <summary>
            /// <para>The channel configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public CreateWorkerRequestChannelsConfig Config { get; set; }
            public class CreateWorkerRequestChannelsConfig : TeaModel {
                /// <summary>
                /// <para>The returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tpl-demo</para>
                /// </summary>
                [NameInMap("CardTemplateId")]
                [Validation(Required=false)]
                public string CardTemplateId { get; set; }

                /// <summary>
                /// <para>The returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cli-demo</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>extension-demo</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>The returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>markdown</para>
                /// </summary>
                [NameInMap("MessageType")]
                [Validation(Required=false)]
                public string MessageType { get; set; }

                /// <summary>
                /// <para>The returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>robot-demo</para>
                /// </summary>
                [NameInMap("RobotCode")]
                [Validation(Required=false)]
                public string RobotCode { get; set; }

                /// <summary>
                /// <para>The returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ShowThinking")]
                [Validation(Required=false)]
                public bool? ShowThinking { get; set; }

                /// <summary>
                /// <para>The returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ShowToolCalls")]
                [Validation(Required=false)]
                public bool? ShowToolCalls { get; set; }

                /// <summary>
                /// <para>The returned data.</para>
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
            public CreateWorkerRequestChannelsSecrets Secrets { get; set; }
            public class CreateWorkerRequestChannelsSecrets : TeaModel {
                /// <summary>
                /// <para>The returned data.</para>
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
        public List<CreateWorkerRequestCredentials> Credentials { get; set; }
        public class CreateWorkerRequestCredentials : TeaModel {
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
        /// <para>The deployment type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SelfHosted</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// <para>The list of team groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<CreateWorkerRequestGroups> Groups { get; set; }
        public class CreateWorkerRequestGroups : TeaModel {
            /// <summary>
            /// <para>The group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The group role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>member</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The group type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
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
        public CreateWorkerRequestLimitConfig LimitConfig { get; set; }
        public class CreateWorkerRequestLimitConfig : TeaModel {
            /// <summary>
            /// <para>The quota type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>token</para>
            /// </summary>
            [NameInMap("LimitType")]
            [Validation(Required=false)]
            public string LimitType { get; set; }

            /// <summary>
            /// <para>The period type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("PeriodType")]
            [Validation(Required=false)]
            public string PeriodType { get; set; }

            /// <summary>
            /// <para>The quota limit.</para>
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
        public List<CreateWorkerRequestMcpServers> McpServers { get; set; }
        public class CreateWorkerRequestMcpServers : TeaModel {
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
        public CreateWorkerRequestModel Model { get; set; }
        public class CreateWorkerRequestModel : TeaModel {
            /// <summary>
            /// <para>The returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-max</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("ModelProvider")]
            [Validation(Required=false)]
            public string ModelProvider { get; set; }

        }

        /// <summary>
        /// <para>The name.</para>
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
        public List<CreateWorkerRequestSkills> Skills { get; set; }
        public class CreateWorkerRequestSkills : TeaModel {
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
        /// <para>The list of sub-agents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Subagents")]
        [Validation(Required=false)]
        public List<CreateWorkerRequestSubagents> Subagents { get; set; }
        public class CreateWorkerRequestSubagents : TeaModel {
            /// <summary>
            /// <para>The sub-agent configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agents-demo</para>
            /// </summary>
            [NameInMap("Agents")]
            [Validation(Required=false)]
            public string Agents { get; set; }

            /// <summary>
            /// <para>The list of sub-agent skills.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<CreateWorkerRequestSubagentsSkills> Skills { get; set; }
            public class CreateWorkerRequestSubagentsSkills : TeaModel {
                /// <summary>
                /// <para>The returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Label.</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>worker-demo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The sub-agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sub-demo</para>
            /// </summary>
            [NameInMap("SubagentId")]
            [Validation(Required=false)]
            public string SubagentId { get; set; }

        }

        /// <summary>
        /// <para>The template configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public CreateWorkerRequestTemplate Template { get; set; }
        public class CreateWorkerRequestTemplate : TeaModel {
            /// <summary>
            /// <para>The returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Label.</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>worker-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
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
