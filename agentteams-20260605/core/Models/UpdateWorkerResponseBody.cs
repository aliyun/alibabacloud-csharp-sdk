// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class UpdateWorkerResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateWorkerResponseBodyData Data { get; set; }
        public class UpdateWorkerResponseBodyData : TeaModel {
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
            /// <para>The list of channels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("Channels")]
            [Validation(Required=false)]
            public List<UpdateWorkerResponseBodyDataChannels> Channels { get; set; }
            public class UpdateWorkerResponseBodyDataChannels : TeaModel {
                /// <summary>
                /// <para>The channel configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public UpdateWorkerResponseBodyDataChannelsConfig Config { get; set; }
                public class UpdateWorkerResponseBodyDataChannelsConfig : TeaModel {
                    /// <summary>
                    /// <para>The card template ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tpl-demo</para>
                    /// </summary>
                    [NameInMap("CardTemplateId")]
                    [Validation(Required=false)]
                    public string CardTemplateId { get; set; }

                    /// <summary>
                    /// <para>The client ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cli-demo</para>
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// <para>The extension configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>extension-demo</para>
                    /// </summary>
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    /// <summary>
                    /// <para>The message type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>markdown</para>
                    /// </summary>
                    [NameInMap("MessageType")]
                    [Validation(Required=false)]
                    public string MessageType { get; set; }

                    /// <summary>
                    /// <para>The robot code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>robot-demo</para>
                    /// </summary>
                    [NameInMap("RobotCode")]
                    [Validation(Required=false)]
                    public string RobotCode { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the thinking process is displayed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ShowThinking")]
                    [Validation(Required=false)]
                    public bool? ShowThinking { get; set; }

                    /// <summary>
                    /// <para>Indicates whether tool invocations are displayed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ShowToolCalls")]
                    [Validation(Required=false)]
                    public bool? ShowToolCalls { get; set; }

                    /// <summary>
                    /// <para>Indicates whether streaming output is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("StreamingEnabled")]
                    [Validation(Required=false)]
                    public bool? StreamingEnabled { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the channel is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The secret status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("SecretStatus")]
                [Validation(Required=false)]
                public UpdateWorkerResponseBodyDataChannelsSecretStatus SecretStatus { get; set; }
                public class UpdateWorkerResponseBodyDataChannelsSecretStatus : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the client secret is set.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ClientSecret")]
                    [Validation(Required=false)]
                    public bool? ClientSecret { get; set; }

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
            /// <para>The list of credential bindings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("Credentials")]
            [Validation(Required=false)]
            public List<UpdateWorkerResponseBodyDataCredentials> Credentials { get; set; }
            public class UpdateWorkerResponseBodyDataCredentials : TeaModel {
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
            /// <para>Managed</para>
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
            public List<UpdateWorkerResponseBodyDataGroups> Groups { get; set; }
            public class UpdateWorkerResponseBodyDataGroups : TeaModel {
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
            public UpdateWorkerResponseBodyDataLimitConfig LimitConfig { get; set; }
            public class UpdateWorkerResponseBodyDataLimitConfig : TeaModel {
                /// <summary>
                /// <para>The limit type.</para>
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
            public List<UpdateWorkerResponseBodyDataMcpServers> McpServers { get; set; }
            public class UpdateWorkerResponseBodyDataMcpServers : TeaModel {
                /// <summary>
                /// <para>The MCP server name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mcp-server-demo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The MCP transport protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sse</para>
                /// </summary>
                [NameInMap("Transport")]
                [Validation(Required=false)]
                public string Transport { get; set; }

                /// <summary>
                /// <para>The MCP server URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://mcp-demo/mcp">https://mcp-demo/mcp</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The model configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public UpdateWorkerResponseBodyDataModel Model { get; set; }
            public class UpdateWorkerResponseBodyDataModel : TeaModel {
                /// <summary>
                /// <para>The model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-max</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The model provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dashscope</para>
                /// </summary>
                [NameInMap("ModelProvider")]
                [Validation(Required=false)]
                public string ModelProvider { get; set; }

            }

            /// <summary>
            /// <para>The Worker name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>worker-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The list of skills.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<UpdateWorkerResponseBodyDataSkills> Skills { get; set; }
            public class UpdateWorkerResponseBodyDataSkills : TeaModel {
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
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-13T10:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The Worker status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The template configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public UpdateWorkerResponseBodyDataTemplate Template { get; set; }
            public class UpdateWorkerResponseBodyDataTemplate : TeaModel {
                /// <summary>
                /// <para>The template label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default template.</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default-template</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The template version.</para>
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

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-XX-XX-XX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
