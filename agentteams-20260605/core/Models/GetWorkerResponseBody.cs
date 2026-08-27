// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetWorkerResponseBody : TeaModel {
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
        public GetWorkerResponseBodyData Data { get; set; }
        public class GetWorkerResponseBodyData : TeaModel {
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
            /// <para>The channel list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("Channels")]
            [Validation(Required=false)]
            public List<GetWorkerResponseBodyDataChannels> Channels { get; set; }
            public class GetWorkerResponseBodyDataChannels : TeaModel {
                /// <summary>
                /// <para>The channel configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public GetWorkerResponseBodyDataChannelsConfig Config { get; set; }
                public class GetWorkerResponseBodyDataChannelsConfig : TeaModel {
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
                public GetWorkerResponseBodyDataChannelsSecretStatus SecretStatus { get; set; }
                public class GetWorkerResponseBodyDataChannelsSecretStatus : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the client secret has been set.</para>
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
            /// <para>The credential binding list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("Credentials")]
            [Validation(Required=false)]
            public List<GetWorkerResponseBodyDataCredentials> Credentials { get; set; }
            public class GetWorkerResponseBodyDataCredentials : TeaModel {
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
            /// <para>The team group list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<GetWorkerResponseBodyDataGroups> Groups { get; set; }
            public class GetWorkerResponseBodyDataGroups : TeaModel {
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
            public GetWorkerResponseBodyDataLimitConfig LimitConfig { get; set; }
            public class GetWorkerResponseBodyDataLimitConfig : TeaModel {
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
                /// <para>Indicates whether the quota is exceeded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OverLimit")]
                [Validation(Required=false)]
                public bool? OverLimit { get; set; }

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
                /// <para>The quota rule status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("RuleStatus")]
                [Validation(Required=false)]
                public string RuleStatus { get; set; }

                /// <summary>
                /// <para>The quota upper limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000</para>
                /// </summary>
                [NameInMap("UsageLimit")]
                [Validation(Required=false)]
                public long? UsageLimit { get; set; }

                /// <summary>
                /// <para>The used amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50000</para>
                /// </summary>
                [NameInMap("UsedAmount")]
                [Validation(Required=false)]
                public long? UsedAmount { get; set; }

            }

            /// <summary>
            /// <para>The MCP server list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("McpServers")]
            [Validation(Required=false)]
            public List<GetWorkerResponseBodyDataMcpServers> McpServers { get; set; }
            public class GetWorkerResponseBodyDataMcpServers : TeaModel {
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
            public GetWorkerResponseBodyDataModel Model { get; set; }
            public class GetWorkerResponseBodyDataModel : TeaModel {
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
            /// <para>The skill list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<GetWorkerResponseBodyDataSkills> Skills { get; set; }
            public class GetWorkerResponseBodyDataSkills : TeaModel {
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
            /// <para>The sub-Agent list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("Subagents")]
            [Validation(Required=false)]
            public List<GetWorkerResponseBodyDataSubagents> Subagents { get; set; }
            public class GetWorkerResponseBodyDataSubagents : TeaModel {
                /// <summary>
                /// <para>The sub-Agent description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sub-Agent description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the sub-Agent contains an agents.md file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasAgentsMd")]
                [Validation(Required=false)]
                public bool? HasAgentsMd { get; set; }

                /// <summary>
                /// <para>The sub-Agent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sub-worker-demo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The skill list of the sub-Agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[...]</para>
                /// </summary>
                [NameInMap("Skills")]
                [Validation(Required=false)]
                public List<GetWorkerResponseBodyDataSubagentsSkills> Skills { get; set; }
                public class GetWorkerResponseBodyDataSubagentsSkills : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the skill contains a skill.md file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HasSkillMd")]
                    [Validation(Required=false)]
                    public bool? HasSkillMd { get; set; }

                    /// <summary>
                    /// <para>The skill name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>search</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The skill ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>skill-demo</para>
                    /// </summary>
                    [NameInMap("SkillId")]
                    [Validation(Required=false)]
                    public string SkillId { get; set; }

                }

                /// <summary>
                /// <para>The source path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/workspace/sub</para>
                /// </summary>
                [NameInMap("SourcePath")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

                /// <summary>
                /// <para>The sub-Agent ID.</para>
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
            public GetWorkerResponseBodyDataTemplate Template { get; set; }
            public class GetWorkerResponseBodyDataTemplate : TeaModel {
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
