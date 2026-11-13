// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateExternalAgentResponseBody : TeaModel {
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
        /// <para>The information about the created managed agent.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateExternalAgentResponseBodyData Data { get; set; }
        public class CreateExternalAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the managed agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-1</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The explicitly configured skills.</para>
            /// </summary>
            [NameInMap("configuredSkills")]
            [Validation(Required=false)]
            public List<CreateExternalAgentResponseBodyDataConfiguredSkills> ConfiguredSkills { get; set; }
            public class CreateExternalAgentResponseBodyDataConfiguredSkills : TeaModel {
                /// <summary>
                /// <para>The name of the skill in the Workspace AI Registry.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>web-search</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The skill source type. REFERENCE references the AI Registry. STATIC is statically provided with the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REFERENCE</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The legacy compatibility field. For new requests, use sourceType and versionSelector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The skill reference version selector. Supports LABEL tags and VERSION specific versions. Defaults to LABEL/latest if omitted. Selectors are not provided for STATIC sources.</para>
                /// </summary>
                [NameInMap("versionSelector")]
                [Validation(Required=false)]
                public CreateExternalAgentResponseBodyDataConfiguredSkillsVersionSelector VersionSelector { get; set; }
                public class CreateExternalAgentResponseBodyDataConfiguredSkillsVersionSelector : TeaModel {
                    /// <summary>
                    /// <para>The version selector type. LABEL selects by tag. VERSION selects by specific version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LABEL</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The selector value. For LABEL, it is the tag name (such as latest). For VERSION, it is the specific version number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>latest</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

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
            /// <para>The description of the managed agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Code review agent running in the user environment</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The credential binding configuration.</para>
            /// </summary>
            [NameInMap("environment")]
            [Validation(Required=false)]
            public CreateExternalAgentResponseBodyDataEnvironment Environment { get; set; }
            public class CreateExternalAgentResponseBodyDataEnvironment : TeaModel {
                /// <summary>
                /// <para>This list must be explicitly provided and cannot be null when the environment object is passed. The list is replaced as a whole. If environment is not passed during an update, the original binding is retained. If an empty list is passed or environment is null, the binding is cleared. Only the credential ID is passed, not the actual secret key.</para>
                /// </summary>
                [NameInMap("credentialReferences")]
                [Validation(Required=false)]
                public List<CreateExternalAgentResponseBodyDataEnvironmentCredentialReferences> CredentialReferences { get; set; }
                public class CreateExternalAgentResponseBodyDataEnvironmentCredentialReferences : TeaModel {
                    /// <summary>
                    /// <para>Required when a credential reference item is passed. Validated by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cred-example</para>
                    /// </summary>
                    [NameInMap("credentialId")]
                    [Validation(Required=false)]
                    public string CredentialId { get; set; }

                }

            }

            /// <summary>
            /// <para>The runtime status information reported by the managed agent.</para>
            /// </summary>
            [NameInMap("externalAgentStatus")]
            [Validation(Required=false)]
            public CreateExternalAgentResponseBodyDataExternalAgentStatus ExternalAgentStatus { get; set; }
            public class CreateExternalAgentResponseBodyDataExternalAgentStatus : TeaModel {
                /// <summary>
                /// <para>The heartbeat status. ONLINE indicates that the latest heartbeat is within the configured timeout threshold. STALE indicates that the heartbeat has timed out. UNKNOWN indicates that the heartbeat is missing or the format is invalid. Valid values:</para>
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
                /// <para>The last active time of the managed agent, in RFC 3339 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("lastActiveAt")]
                [Validation(Required=false)]
                public string LastActiveAt { get; set; }

                /// <summary>
                /// <para>The time of the last heartbeat reported by the managed agent, in RFC 3339 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("lastHeartbeat")]
                [Validation(Required=false)]
                public string LastHeartbeat { get; set; }

                /// <summary>
                /// <para>The local IP address reported by the managed agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.42</para>
                /// </summary>
                [NameInMap("localIP")]
                [Validation(Required=false)]
                public string LocalIP { get; set; }

                /// <summary>
                /// <para>The runtime type reported by the managed agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwenpaw</para>
                /// </summary>
                [NameInMap("runtime")]
                [Validation(Required=false)]
                public string Runtime { get; set; }

            }

            /// <summary>
            /// <para>The agent instruction, used to guide the behavior of the agent.</para>
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
            /// <para>The processing status of the latest specification version. Valid values: pending (Pending), processing (Processing), waiting_retry (Waiting for retry), succeeded (Succeeded), failed (Failed), and superseded (Superseded by a new version).</para>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("latestVersionStatus")]
            [Validation(Required=false)]
            public string LatestVersionStatus { get; set; }

            /// <summary>
            /// <para>The model configuration. Available only when modelSource is PLATFORM.</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public CreateExternalAgentResponseBodyDataModel Model { get; set; }
            public class CreateExternalAgentResponseBodyDataModel : TeaModel {
                /// <summary>
                /// <para>The model connection ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mc-1</para>
                /// </summary>
                [NameInMap("modelConnectionId")]
                [Validation(Required=false)]
                public string ModelConnectionId { get; set; }

                /// <summary>
                /// <para>The upstream model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-max</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The model token quota configuration and the quota usage status for the current cycle. This parameter is empty if no quota is configured.</para>
                /// </summary>
                [NameInMap("quota")]
                [Validation(Required=false)]
                public CreateExternalAgentResponseBodyDataModelQuota Quota { get; set; }
                public class CreateExternalAgentResponseBodyDataModelQuota : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the quota is enabled. This parameter is not returned if no quota is configured.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The quota limit type. Currently, only token is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>token</para>
                    /// </summary>
                    [NameInMap("limitType")]
                    [Validation(Required=false)]
                    public string LimitType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the quota is exceeded in the current cycle. This parameter is read-only and returned by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("overLimit")]
                    [Validation(Required=false)]
                    public bool? OverLimit { get; set; }

                    /// <summary>
                    /// <para>The quota statistical period. A value of day indicates daily, and a value of month indicates monthly.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>day</para>
                    /// </summary>
                    [NameInMap("periodType")]
                    [Validation(Required=false)]
                    public string PeriodType { get; set; }

                    /// <summary>
                    /// <para>The gateway quota rule status. This parameter is read-only and returned by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACTIVE</para>
                    /// </summary>
                    [NameInMap("ruleStatus")]
                    [Validation(Required=false)]
                    public string RuleStatus { get; set; }

                    /// <summary>
                    /// <para>The maximum number of tokens allowed to be consumed in a single cycle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000000</para>
                    /// </summary>
                    [NameInMap("usageLimit")]
                    [Validation(Required=false)]
                    public long? UsageLimit { get; set; }

                    /// <summary>
                    /// <para>The number of tokens consumed in the current cycle. This parameter is read-only and returned by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("usedAmount")]
                    [Validation(Required=false)]
                    public long? UsedAmount { get; set; }

                }

            }

            /// <summary>
            /// <para>The source of the model configuration. PLATFORM indicates that the platform parses and delivers the model configuration. RUNTIME indicates that the external runtime manages the model itself, and the model parameter cannot be passed at the same time. Valid values: PLATFORM (platform model) and RUNTIME (runtime model).</para>
            /// 
            /// <b>Example:</b>
            /// <para>PLATFORM</para>
            /// </summary>
            [NameInMap("modelSource")]
            [Validation(Required=false)]
            public string ModelSource { get; set; }

            /// <summary>
            /// <para>The name of the managed agent.</para>
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
            /// <para>The runtime type reported by the managed agent.</para>
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
            public List<CreateExternalAgentResponseBodyDataSkills> Skills { get; set; }
            public class CreateExternalAgentResponseBodyDataSkills : TeaModel {
                /// <summary>
                /// <para>The effective runtime version. This field is read-only.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("appliedVersion")]
                [Validation(Required=false)]
                public string AppliedVersion { get; set; }

                /// <summary>
                /// <para>Specifies whether the skill is from a fixed template. This field is read-only. Template items cannot be removed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("fromTemplate")]
                [Validation(Required=false)]
                public bool? FromTemplate { get; set; }

                /// <summary>
                /// <para>The skill name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>code-analysis</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The current target version. This field is read-only.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("resolvedVersion")]
                [Validation(Required=false)]
                public string ResolvedVersion { get; set; }

                /// <summary>
                /// <para>The skill source type. REFERENCE references the AI Registry. STATIC is statically provided with the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REFERENCE</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The current target version compatible with legacy clients. New clients use resolvedVersion and determine the effective runtime version based on appliedVersion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The skill reference version selector. Supports LABEL tags and VERSION specific versions. Defaults to LABEL/latest if omitted. Selectors are not provided for STATIC sources.</para>
                /// </summary>
                [NameInMap("versionSelector")]
                [Validation(Required=false)]
                public CreateExternalAgentResponseBodyDataSkillsVersionSelector VersionSelector { get; set; }
                public class CreateExternalAgentResponseBodyDataSkillsVersionSelector : TeaModel {
                    /// <summary>
                    /// <para>The version selector type. LABEL selects by tag. VERSION selects by specific version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LABEL</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The selector value. For LABEL, it is the tag name (such as latest). For VERSION, it is the specific version number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>latest</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The status of the managed agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: The agent is being created.</description></item>
            /// <item><description>Running: The agent is running.</description></item>
            /// <item><description>Failed: The agent failed.</description></item>
            /// <item><description>Updating: The agent is being updated.</description></item>
            /// <item><description>Deleting: The agent is being deleted.</description></item>
            /// <item><description>Deleted: The agent is deleted.</description></item>
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
            public CreateExternalAgentResponseBodyDataTemplate Template { get; set; }
            public class CreateExternalAgentResponseBodyDataTemplate : TeaModel {
                /// <summary>
                /// <para>The AI Registry template configuration.</para>
                /// </summary>
                [NameInMap("aiRegistry")]
                [Validation(Required=false)]
                public CreateExternalAgentResponseBodyDataTemplateAiRegistry AiRegistry { get; set; }
                public class CreateExternalAgentResponseBodyDataTemplateAiRegistry : TeaModel {
                    /// <summary>
                    /// <para>The name of the template in the AI Registry.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>code-review-template</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The version of the template in the AI Registry.</para>
                    /// <para>This parameter is required.</para>
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
            public List<CreateExternalAgentResponseBodyDataTools> Tools { get; set; }
            public class CreateExternalAgentResponseBodyDataTools : TeaModel {
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
                /// <para>The tool type. Valid values: MCP (MCP tool).</para>
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
        /// <para>The request processing result message.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
