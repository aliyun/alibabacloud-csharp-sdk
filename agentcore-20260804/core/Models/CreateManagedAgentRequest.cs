// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateManagedAgentRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateManagedAgentRequestBody Body { get; set; }
        public class CreateManagedAgentRequestBody : TeaModel {
            /// <summary>
            /// <para>The inbound access mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API_KEY</para>
            /// </summary>
            [NameInMap("accessMode")]
            [Validation(Required=false)]
            public string AccessMode { get; set; }

            /// <summary>
            /// <para>The user access scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("accessScope")]
            [Validation(Required=false)]
            public string AccessScope { get; set; }

            /// <summary>
            /// <para>The NAS storage mount configurations. Currently, only the AgenticFS type is supported, which is used to mount file directories in access points to agent runtime instances. This is the list of AgenticFS directory mounts. The total number of AgenticFS mounts and OSS mounts cannot exceed 10. If you omit this parameter or set it to [] during creation, no mounts are configured. If you omit this parameter during an update, the existing mounts are retained. If you set it to [], the mounts are cleared. Null values are not accepted.</para>
            /// </summary>
            [NameInMap("agenticFsMounts")]
            [Validation(Required=false)]
            public List<CreateManagedAgentRequestBodyAgenticFsMounts> AgenticFsMounts { get; set; }
            public class CreateManagedAgentRequestBodyAgenticFsMounts : TeaModel {
                /// <summary>
                /// <para>The absolute mount path in the container, such as /data/train. Mount targets cannot be duplicated or form parent-child directory overwrites, and must avoid platform-reserved directories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs/data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The existing non-empty relative directory in the access point. This parameter is required and verified by the backend for each mount item. Root directories, absolute paths, and parent directory segments are not allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspace/data</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. If this parameter is omitted, the default value is false. This parameter does not represent a RAM role read-only policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The access point domain name. This parameter is required and verified by the backend for each mount item. The value cannot contain a protocol, port, or path. Set this parameter to the DomainName value in the NAS ListAccessPoints response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The description of the managed Harness agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agent for code review</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The environment configuration.</para>
            /// </summary>
            [NameInMap("environment")]
            [Validation(Required=false)]
            public CreateManagedAgentRequestBodyEnvironment Environment { get; set; }
            public class CreateManagedAgentRequestBodyEnvironment : TeaModel {
                /// <summary>
                /// <para>The list of credential references.</para>
                /// </summary>
                [NameInMap("credentialReferences")]
                [Validation(Required=false)]
                public List<CreateManagedAgentRequestBodyEnvironmentCredentialReferences> CredentialReferences { get; set; }
                public class CreateManagedAgentRequestBodyEnvironmentCredentialReferences : TeaModel {
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
                public List<CreateManagedAgentRequestBodyEnvironmentVariables> Variables { get; set; }
                public class CreateManagedAgentRequestBodyEnvironmentVariables : TeaModel {
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
            /// <para>The runtime framework object. If this parameter is omitted, qwenpaw is used by default. Valid values: qwenpaw and qodercli. The type cannot be changed after creation.</para>
            /// </summary>
            [NameInMap("harness")]
            [Validation(Required=false)]
            public CreateManagedAgentRequestBodyHarness Harness { get; set; }
            public class CreateManagedAgentRequestBodyHarness : TeaModel {
                /// <summary>
                /// <para>The runtime framework configurations.</para>
                /// </summary>
                [NameInMap("configuration")]
                [Validation(Required=false)]
                public CreateManagedAgentRequestBodyHarnessConfiguration Configuration { get; set; }
                public class CreateManagedAgentRequestBodyHarnessConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The account key record ID in the qodercli connector. You can query this ID by calling the ListConnectors operation. This parameter does not represent the original key. You can omit this parameter if only one record exists. You must specify this parameter if multiple records exist. Do not specify this parameter for qwenpaw.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key-example</para>
                    /// </summary>
                    [NameInMap("connectorServiceAccountKey")]
                    [Validation(Required=false)]
                    public string ConnectorServiceAccountKey { get; set; }

                    /// <summary>
                    /// <para>The connector account name bound to qodercli. Do not specify this parameter for qwenpaw.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-connector-key</para>
                    /// </summary>
                    [NameInMap("connectorServiceAccountName")]
                    [Validation(Required=false)]
                    public string ConnectorServiceAccountName { get; set; }

                }

                /// <summary>
                /// <para>The runtime framework type. This parameter is required when you provide the harness parameter. Valid values: qwenpaw and qodercli.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qodercli</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The agent instruction, which is used to guide the behavior of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>You are a code review assistant</para>
            /// </summary>
            [NameInMap("instruction")]
            [Validation(Required=false)]
            public string Instruction { get; set; }

            /// <summary>
            /// <para>The model configurations.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public CreateManagedAgentRequestBodyModel Model { get; set; }
            public class CreateManagedAgentRequestBodyModel : TeaModel {
                /// <summary>
                /// <para>For qwenpaw, set this parameter to the workspace model connection ID. For qodercli, set this parameter to the available model identifier returned by the ListConnectorModels operation.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mc-1</para>
                /// </summary>
                [NameInMap("modelConnectionId")]
                [Validation(Required=false)]
                public string ModelConnectionId { get; set; }

                /// <summary>
                /// <para>For qwenpaw, set this parameter to the name of the upstream model created under the model connection. This parameter is required. For qodercli, you can omit this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-max</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The model token quota configurations. If you do not pass this parameter, no quota is configured.</para>
                /// </summary>
                [NameInMap("quota")]
                [Validation(Required=false)]
                public CreateManagedAgentRequestBodyModelQuota Quota { get; set; }
                public class CreateManagedAgentRequestBodyModelQuota : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable the token quota. If you do not specify this parameter, the default value is true. If you set this parameter to false, the quota is disabled and existing quota rules are deleted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The quota limit type. This parameter is required and verified by the backend when the quota is enabled. Fixed value: token.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>token</para>
                    /// </summary>
                    [NameInMap("limitType")]
                    [Validation(Required=false)]
                    public string LimitType { get; set; }

                    /// <summary>
                    /// <para>The statistical period of the quota. This parameter is required and verified by the backend when the quota is enabled. Valid values: day and month.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>day</para>
                    /// </summary>
                    [NameInMap("periodType")]
                    [Validation(Required=false)]
                    public string PeriodType { get; set; }

                    /// <summary>
                    /// <para>The maximum number of tokens that can be consumed in a single period. This parameter is required and verified by the backend when the quota is enabled. The value must be greater than 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000000</para>
                    /// </summary>
                    [NameInMap("usageLimit")]
                    [Validation(Required=false)]
                    public long? UsageLimit { get; set; }

                }

                /// <summary>
                /// <para>Valid values: off, low, medium, high, xhigh, and max. If this parameter is not passed or is set to null during creation, the default value is used. When you update and submit model configurations, if the thinking level is not passed or is set to null, the default value is restored. Except for off, which is converted to none, the value is passed to the runtime framework as is. The system does not verify model support or automatically downgrade the level. If the model does not support the specified level, adjust the level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("thinkingLevel")]
                [Validation(Required=false)]
                public string ThinkingLevel { get; set; }

            }

            /// <summary>
            /// <para>The name of the managed Harness agent.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The runtime network configuration. If provided, both accessInternet.enabled and accessVpc.enabled must be included. Actual access is subject to workspace network restrictions.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public CreateManagedAgentRequestBodyNetwork Network { get; set; }
            public class CreateManagedAgentRequestBodyNetwork : TeaModel {
                /// <summary>
                /// <para>The public network access configuration.</para>
                /// </summary>
                [NameInMap("accessInternet")]
                [Validation(Required=false)]
                public CreateManagedAgentRequestBodyNetworkAccessInternet AccessInternet { get; set; }
                public class CreateManagedAgentRequestBodyNetworkAccessInternet : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow Internet access.</para>
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
                public CreateManagedAgentRequestBodyNetworkAccessVpc AccessVpc { get; set; }
                public class CreateManagedAgentRequestBodyNetworkAccessVpc : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow VPC access.</para>
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
            /// <para>The list of OSS directory mounts. The total number of OSS mounts and agenticFsMounts cannot exceed 10. During an update, this list is replaced entirely. Pass an empty array [] to clear the list.</para>
            /// </summary>
            [NameInMap("ossMounts")]
            [Validation(Required=false)]
            public List<CreateManagedAgentRequestBodyOssMounts> OssMounts { get; set; }
            public class CreateManagedAgentRequestBodyOssMounts : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket. Required for each mount item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bucket-001</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The absolute mount path in the container, such as /data/train. Mount targets cannot be duplicated or form parent-child directory overwrites, and must avoid platform-reserved directories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/oss/datasets</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The non-empty relative object directory prefix in the bucket. Required for each mount item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>datasets</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether to mount the directory as read-only. Default value: false.</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            /// <summary>
            /// <para>The prompt variable declarations.</para>
            /// </summary>
            [NameInMap("promptVariables")]
            [Validation(Required=false)]
            public List<CreateManagedAgentRequestBodyPromptVariables> PromptVariables { get; set; }
            public class CreateManagedAgentRequestBodyPromptVariables : TeaModel {
                /// <summary>
                /// <para>The default value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("defaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The variable description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>brand</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The runtime configuration. You must provide both compute and sessionPolicy. Omitted fields in hpa use default values.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public CreateManagedAgentRequestBodyRuntime Runtime { get; set; }
            public class CreateManagedAgentRequestBodyRuntime : TeaModel {
                /// <summary>
                /// <para>The compute configuration.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("compute")]
                [Validation(Required=false)]
                public CreateManagedAgentRequestBodyRuntimeCompute Compute { get; set; }
                public class CreateManagedAgentRequestBodyRuntimeCompute : TeaModel {
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
                /// <para>The elastic scaling and session configuration. Omitted fields use default values. To retain the original policy during an update, submit the complete hpa object or omit the entire runtime object.</para>
                /// </summary>
                [NameInMap("hpa")]
                [Validation(Required=false)]
                public CreateManagedAgentRequestBodyRuntimeHpa Hpa { get; set; }
                public class CreateManagedAgentRequestBodyRuntimeHpa : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable elastic scaling. Default value: false.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent sessions allowed per instance. Valid values: 1 to 20. Default value: 20.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("maxConcurrentSessionsPerSandbox")]
                    [Validation(Required=false)]
                    public int? MaxConcurrentSessionsPerSandbox { get; set; }

                    /// <summary>
                    /// <para>The maximum number of instances. Valid values: 0 to 100. Default value: 10. The value cannot be less than minSandboxCount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("maxSandboxCount")]
                    [Validation(Required=false)]
                    public int? MaxSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The minimum number of instances. Valid values: 0 to 100. Default value: 1. The value cannot be greater than maxSandboxCount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minSandboxCount")]
                    [Validation(Required=false)]
                    public int? MinSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The maximum idle time for a session, in seconds. Valid values: 60 to 86400. Default value: 600.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3600</para>
                    /// </summary>
                    [NameInMap("sessionTtlSeconds")]
                    [Validation(Required=false)]
                    public int? SessionTtlSeconds { get; set; }

                }

                /// <summary>
                /// <para>The session policy configuration.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sessionPolicy")]
                [Validation(Required=false)]
                public CreateManagedAgentRequestBodyRuntimeSessionPolicy SessionPolicy { get; set; }
                public class CreateManagedAgentRequestBodyRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The name of the request header for session identification. Required when type is ISOLATED_HEADER_FIELD, and must be a valid HTTP request header name. Do not specify this parameter for other policies.</para>
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
            public List<CreateManagedAgentRequestBodySkills> Skills { get; set; }
            public class CreateManagedAgentRequestBodySkills : TeaModel {
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
                /// <para>The skill source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REFERENCE</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The skill version field for backward compatibility with legacy requests. For new requests, use sourceType and versionSelector. Do not submit this field in combination with sourceType.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The version selector for skill references. Supports LABEL for tags and VERSION for specific versions. If omitted, LABEL/latest is used. Selectors are not provided for STATIC sources.</para>
                /// </summary>
                [NameInMap("versionSelector")]
                [Validation(Required=false)]
                public CreateManagedAgentRequestBodySkillsVersionSelector VersionSelector { get; set; }
                public class CreateManagedAgentRequestBodySkillsVersionSelector : TeaModel {
                    /// <summary>
                    /// <para>The version selector type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LABEL</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The selector value. For LABEL, this is the tag name, such as latest. For VERSION, this is the specific version number.</para>
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
            /// <para>The list of sub-agent configurations.</para>
            /// </summary>
            [NameInMap("subAgents")]
            [Validation(Required=false)]
            public List<CreateManagedAgentRequestBodySubAgents> SubAgents { get; set; }
            public class CreateManagedAgentRequestBodySubAgents : TeaModel {
                /// <summary>
                /// <para>The sub-agent instruction.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Review the code</para>
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

                /// <summary>
                /// <para>The list of sub-agent skills.</para>
                /// </summary>
                [NameInMap("skills")]
                [Validation(Required=false)]
                public List<CreateManagedAgentRequestBodySubAgentsSkills> Skills { get; set; }
                public class CreateManagedAgentRequestBodySubAgentsSkills : TeaModel {
                    /// <summary>
                    /// <para>The skill name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>web-search</para>
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

            }

            /// <summary>
            /// <para>The agent template configuration.</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public CreateManagedAgentRequestBodyTemplate Template { get; set; }
            public class CreateManagedAgentRequestBodyTemplate : TeaModel {
                /// <summary>
                /// <para>The AI Registry template configuration.</para>
                /// </summary>
                [NameInMap("aiRegistry")]
                [Validation(Required=false)]
                public CreateManagedAgentRequestBodyTemplateAiRegistry AiRegistry { get; set; }
                public class CreateManagedAgentRequestBodyTemplateAiRegistry : TeaModel {
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
            public List<CreateManagedAgentRequestBodyTools> Tools { get; set; }
            public class CreateManagedAgentRequestBodyTools : TeaModel {
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

        }

        /// <summary>
        /// <para>The reserved query parameter. Currently, the backend does not provide idempotency guarantees to deduplicate or recover the original acceptance result based on this identity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-1</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
