// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateExternalAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of SUCCESS indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the updated external agent.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateExternalAgentResponseBodyData Data { get; set; }
        public class UpdateExternalAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The external agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-1</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The creation mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("createMode")]
            [Validation(Required=false)]
            public string CreateMode { get; set; }

            /// <summary>
            /// <para>The creation time in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The deployment type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELF_HOSTED</para>
            /// </summary>
            [NameInMap("deployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// <para>The description of the external agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A code review agent running in the user environment</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The runtime result corresponding to the currently effective specification.</para>
            /// </summary>
            [NameInMap("effectiveResult")]
            [Validation(Required=false)]
            public UpdateExternalAgentResponseBodyDataEffectiveResult EffectiveResult { get; set; }
            public class UpdateExternalAgentResponseBodyDataEffectiveResult : TeaModel {
                /// <summary>
                /// <para>The user ID of the agent in Matrix.</para>
                /// 
                /// <b>Example:</b>
                /// <para>@agent-1:matrix.example.com</para>
                /// </summary>
                [NameInMap("matrixUserId")]
                [Validation(Required=false)]
                public string MatrixUserId { get; set; }

                /// <summary>
                /// <para>The Matrix personal room ID of the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>!room:matrix.example.com</para>
                /// </summary>
                [NameInMap("personalRoomId")]
                [Validation(Required=false)]
                public string PersonalRoomId { get; set; }

                /// <summary>
                /// <para>The acceptance status of the runtime for the current request version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACCEPTED</para>
                /// </summary>
                [NameInMap("runtimeAcceptStatus")]
                [Validation(Required=false)]
                public string RuntimeAcceptStatus { get; set; }

                /// <summary>
                /// <para>The runtime instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>runtime-123</para>
                /// </summary>
                [NameInMap("runtimeId")]
                [Validation(Required=false)]
                public string RuntimeId { get; set; }

                /// <summary>
                /// <para>The runtime request version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("runtimeRequestVersion")]
                [Validation(Required=false)]
                public long? RuntimeRequestVersion { get; set; }

                /// <summary>
                /// <para>The storage prefix of the agent in the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agents/agent-1</para>
                /// </summary>
                [NameInMap("workspacePrefix")]
                [Validation(Required=false)]
                public string WorkspacePrefix { get; set; }

            }

            /// <summary>
            /// <para>The currently effective specification version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("effectiveSpecVersion")]
            [Validation(Required=false)]
            public long? EffectiveSpecVersion { get; set; }

            /// <summary>
            /// <para>The runtime status information reported by the external agent.</para>
            /// </summary>
            [NameInMap("externalAgentStatus")]
            [Validation(Required=false)]
            public UpdateExternalAgentResponseBodyDataExternalAgentStatus ExternalAgentStatus { get; set; }
            public class UpdateExternalAgentResponseBodyDataExternalAgentStatus : TeaModel {
                /// <summary>
                /// <para>The heartbeat status. ONLINE indicates that the most recent heartbeat has not exceeded the configured timeout threshold. STALE indicates that the heartbeat has timed out. UNKNOWN indicates that the heartbeat is missing or has an invalid format. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ONLINE: Online.</description></item>
                /// <item><description>STALE: Heartbeat expired.</description></item>
                /// <item><description>UNKNOWN: Unknown.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ONLINE</para>
                /// </summary>
                [NameInMap("heartbeatStatus")]
                [Validation(Required=false)]
                public string HeartbeatStatus { get; set; }

                /// <summary>
                /// <para>The time when the external agent was last active in RFC 3339 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("lastActiveAt")]
                [Validation(Required=false)]
                public string LastActiveAt { get; set; }

                /// <summary>
                /// <para>The time of the most recent heartbeat from the external agent in RFC 3339 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("lastHeartbeat")]
                [Validation(Required=false)]
                public string LastHeartbeat { get; set; }

                /// <summary>
                /// <para>The local IP address reported by the external agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.42</para>
                /// </summary>
                [NameInMap("localIP")]
                [Validation(Required=false)]
                public string LocalIP { get; set; }

                /// <summary>
                /// <para>The runtime type reported by the external agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwenpaw</para>
                /// </summary>
                [NameInMap("runtime")]
                [Validation(Required=false)]
                public string Runtime { get; set; }

            }

            /// <summary>
            /// <para>The agent instruction that guides the behavior of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>You are a code review assistant</para>
            /// </summary>
            [NameInMap("instruction")]
            [Validation(Required=false)]
            public string Instruction { get; set; }

            /// <summary>
            /// <para>The latest specification version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("latestSpecVersion")]
            [Validation(Required=false)]
            public long? LatestSpecVersion { get; set; }

            /// <summary>
            /// <para>The processing status of the latest specification version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pending: Pending processing.</description></item>
            /// <item><description>processing: Being processed.</description></item>
            /// <item><description>waiting_retry: Waiting for retry.</description></item>
            /// <item><description>succeeded: Succeeded.</description></item>
            /// <item><description>failed: Failed.</description></item>
            /// <item><description>superseded: Superseded by a newer version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("latestVersionStatus")]
            [Validation(Required=false)]
            public string LatestVersionStatus { get; set; }

            /// <summary>
            /// <para>The model configuration. This parameter is available only when modelSource is set to PLATFORM.</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public UpdateExternalAgentResponseBodyDataModel Model { get; set; }
            public class UpdateExternalAgentResponseBodyDataModel : TeaModel {
                /// <summary>
                /// <para>The model connection ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mc-1</para>
                /// </summary>
                [NameInMap("modelConnectionId")]
                [Validation(Required=false)]
                public string ModelConnectionId { get; set; }

                /// <summary>
                /// <para>The upstream model name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-max</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

            }

            /// <summary>
            /// <para>The source of the model configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PLATFORM: The model configuration is parsed and distributed by the platform. You can specify the model parameter.</description></item>
            /// <item><description>RUNTIME: The model is managed by the external runtime. You cannot specify the model parameter at the same time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PLATFORM</para>
            /// </summary>
            [NameInMap("modelSource")]
            [Validation(Required=false)]
            public string ModelSource { get; set; }

            /// <summary>
            /// <para>The name of the external agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-external-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The runtime type reported by the external agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwenpaw</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>The list of skill configurations.</para>
            /// </summary>
            [NameInMap("skills")]
            [Validation(Required=false)]
            public List<UpdateExternalAgentResponseBodyDataSkills> Skills { get; set; }
            public class UpdateExternalAgentResponseBodyDataSkills : TeaModel {
                /// <summary>
                /// <para>The skill name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>code-analysis</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The skill version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The status of the external agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: The agent is being created.</description></item>
            /// <item><description>Running: The agent is running.</description></item>
            /// <item><description>Failed: The agent has failed.</description></item>
            /// <item><description>Updating: The agent is being updated.</description></item>
            /// <item><description>Deleting: The agent is being deleted.</description></item>
            /// <item><description>Deleted: The agent has been deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The agent template configuration.</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public UpdateExternalAgentResponseBodyDataTemplate Template { get; set; }
            public class UpdateExternalAgentResponseBodyDataTemplate : TeaModel {
                /// <summary>
                /// <para>The AI Registry template configuration.</para>
                /// </summary>
                [NameInMap("aiRegistry")]
                [Validation(Required=false)]
                public UpdateExternalAgentResponseBodyDataTemplateAiRegistry AiRegistry { get; set; }
                public class UpdateExternalAgentResponseBodyDataTemplateAiRegistry : TeaModel {
                    /// <summary>
                    /// <para>The name of the template in AI Registry.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>code-review-template</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The version of the template in AI Registry.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0.0</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of tool configurations.</para>
            /// </summary>
            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<UpdateExternalAgentResponseBodyDataTools> Tools { get; set; }
            public class UpdateExternalAgentResponseBodyDataTools : TeaModel {
                /// <summary>
                /// <para>The tool name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>code-reviewer</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The tool type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MCP: MCP tool.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MCP</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The update time in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-1</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message that indicates the result of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a2b3c4d-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
