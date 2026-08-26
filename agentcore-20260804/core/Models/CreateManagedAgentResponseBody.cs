// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateManagedAgentResponseBody : TeaModel {
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
        /// <para>The information about the managed agent after creation.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateManagedAgentResponseBodyData Data { get; set; }
        public class CreateManagedAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The managed agent ID.</para>
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
            /// <para>Managed</para>
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
            /// <para>Managed</para>
            /// </summary>
            [NameInMap("deployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// <para>The description of the managed agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>An agent for code review</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The environment configuration information.</para>
            /// </summary>
            [NameInMap("environment")]
            [Validation(Required=false)]
            public CreateManagedAgentResponseBodyDataEnvironment Environment { get; set; }
            public class CreateManagedAgentResponseBodyDataEnvironment : TeaModel {
                /// <summary>
                /// <para>The list of credential references.</para>
                /// </summary>
                [NameInMap("credentialReferences")]
                [Validation(Required=false)]
                public List<CreateManagedAgentResponseBodyDataEnvironmentCredentialReferences> CredentialReferences { get; set; }
                public class CreateManagedAgentResponseBodyDataEnvironmentCredentialReferences : TeaModel {
                    /// <summary>
                    /// <para>The credential ID.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cred-1</para>
                    /// </summary>
                    [NameInMap("credentialId")]
                    [Validation(Required=false)]
                    public string CredentialId { get; set; }

                }

                /// <summary>
                /// <para>The list of environment variables.</para>
                /// </summary>
                [NameInMap("variables")]
                [Validation(Required=false)]
                public List<CreateManagedAgentResponseBodyDataEnvironmentVariables> Variables { get; set; }
                public class CreateManagedAgentResponseBodyDataEnvironmentVariables : TeaModel {
                    /// <summary>
                    /// <para>The environment variable name.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>API_KEY</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The environment variable value.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sk-xxxx</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

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
            /// <para>The status of the latest version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>succeeded</para>
            /// </summary>
            [NameInMap("latestVersionStatus")]
            [Validation(Required=false)]
            public string LatestVersionStatus { get; set; }

            /// <summary>
            /// <para>The model configuration information.</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public CreateManagedAgentResponseBodyDataModel Model { get; set; }
            public class CreateManagedAgentResponseBodyDataModel : TeaModel {
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
            /// <para>The name of the managed agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network configuration information.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public CreateManagedAgentResponseBodyDataNetwork Network { get; set; }
            public class CreateManagedAgentResponseBodyDataNetwork : TeaModel {
                /// <summary>
                /// <para>The public network access configuration.</para>
                /// </summary>
                [NameInMap("accessInternet")]
                [Validation(Required=false)]
                public CreateManagedAgentResponseBodyDataNetworkAccessInternet AccessInternet { get; set; }
                public class CreateManagedAgentResponseBodyDataNetworkAccessInternet : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow access to the Internet.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

                /// <summary>
                /// <para>The VPC access configuration.</para>
                /// </summary>
                [NameInMap("accessVpc")]
                [Validation(Required=false)]
                public CreateManagedAgentResponseBodyDataNetworkAccessVpc AccessVpc { get; set; }
                public class CreateManagedAgentResponseBodyDataNetworkAccessVpc : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow access to the VPC.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

            }

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
            /// <para>The runtime configuration information.</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public CreateManagedAgentResponseBodyDataRuntime Runtime { get; set; }
            public class CreateManagedAgentResponseBodyDataRuntime : TeaModel {
                /// <summary>
                /// <para>The compute configuration.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("compute")]
                [Validation(Required=false)]
                public CreateManagedAgentResponseBodyDataRuntimeCompute Compute { get; set; }
                public class CreateManagedAgentResponseBodyDataRuntimeCompute : TeaModel {
                    /// <summary>
                    /// <para>The compute specification.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STANDARD</para>
                    /// </summary>
                    [NameInMap("computeClass")]
                    [Validation(Required=false)]
                    public string ComputeClass { get; set; }

                }

                /// <summary>
                /// <para>The session policy configuration.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sessionPolicy")]
                [Validation(Required=false)]
                public CreateManagedAgentResponseBodyDataRuntimeSessionPolicy SessionPolicy { get; set; }
                public class CreateManagedAgentResponseBodyDataRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The HTTP header name used for session affinity. This parameter takes effect only when sessionPolicy.type is set to ISOLATED_HEADER_FIELD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>X-Session-Id</para>
                    /// </summary>
                    [NameInMap("headerName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>The session policy type.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DISABLED</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of skill configurations.</para>
            /// </summary>
            [NameInMap("skills")]
            [Validation(Required=false)]
            public List<CreateManagedAgentResponseBodyDataSkills> Skills { get; set; }
            public class CreateManagedAgentResponseBodyDataSkills : TeaModel {
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
            /// <para>The status of the managed agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of sub-agent configurations.</para>
            /// </summary>
            [NameInMap("subAgents")]
            [Validation(Required=false)]
            public List<CreateManagedAgentResponseBodyDataSubAgents> SubAgents { get; set; }
            public class CreateManagedAgentResponseBodyDataSubAgents : TeaModel {
                /// <summary>
                /// <para>The sub-agent instruction.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Please review the code</para>
                /// </summary>
                [NameInMap("instruction")]
                [Validation(Required=false)]
                public string Instruction { get; set; }

                /// <summary>
                /// <para>The sub-agent name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reviewer-agent</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The template configuration information.</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public CreateManagedAgentResponseBodyDataTemplate Template { get; set; }
            public class CreateManagedAgentResponseBodyDataTemplate : TeaModel {
                /// <summary>
                /// <para>The AI registry template configuration.</para>
                /// </summary>
                [NameInMap("aiRegistry")]
                [Validation(Required=false)]
                public CreateManagedAgentResponseBodyDataTemplateAiRegistry AiRegistry { get; set; }
                public class CreateManagedAgentResponseBodyDataTemplateAiRegistry : TeaModel {
                    /// <summary>
                    /// <para>The name of the template in the AI registry.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>code-review-template</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The version of the template in the AI registry.</para>
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
            public List<CreateManagedAgentResponseBodyDataTools> Tools { get; set; }
            public class CreateManagedAgentResponseBodyDataTools : TeaModel {
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
                /// <para>The tool type.</para>
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
        /// <para>The result message of the request.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
