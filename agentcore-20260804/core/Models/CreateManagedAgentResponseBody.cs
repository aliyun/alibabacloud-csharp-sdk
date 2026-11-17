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
        /// <para>The information about the managed Harness agent after creation.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateManagedAgentResponseBodyData Data { get; set; }
        public class CreateManagedAgentResponseBodyData : TeaModel {
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
            /// <para>The managed Harness agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-1</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The NAS storage mount configuration. Currently, the AgenticFS type is supported, which is used to mount file directories in the access point to the agent runtime instance. For NAS mounts, a maximum of 10 items are allowed in total including ossMounts.</para>
            /// </summary>
            [NameInMap("agenticFsMounts")]
            [Validation(Required=false)]
            public List<CreateManagedAgentResponseBodyDataAgenticFsMounts> AgenticFsMounts { get; set; }
            public class CreateManagedAgentResponseBodyDataAgenticFsMounts : TeaModel {
                /// <summary>
                /// <para>The absolute mount path in the container, such as <c>/data/train</c>. Mount targets cannot be duplicated or form parent-child overwrites, and must avoid platform-reserved directories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs/data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The existing non-empty relative directory under the access point. This is a required field validated by the backend for each mount item. Root directories, absolute paths, or parent directory segments are not allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspace/data</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. If omitted, the default value is false. This is not the read-only policy of a RAM role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The access point domain name. This is a required field validated by the backend for each mount item. It does not contain a protocol, port, or path. Use the <c>DomainName</c> from the NAS <c>ListAccessPoints</c> response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The explicitly configured skills.</para>
            /// </summary>
            [NameInMap("configuredSkills")]
            [Validation(Required=false)]
            public List<CreateManagedAgentResponseBodyDataConfiguredSkills> ConfiguredSkills { get; set; }
            public class CreateManagedAgentResponseBodyDataConfiguredSkills : TeaModel {
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
                /// <para>The source type of the skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REFERENCE</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The legacy compatibility field. New requests use sourceType and versionSelector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The version selector for the skill reference. Supports LABEL for tags and VERSION for specific versions. Defaults to LABEL/latest when omitted. Not applicable for STATIC sources.</para>
                /// </summary>
                [NameInMap("versionSelector")]
                [Validation(Required=false)]
                public CreateManagedAgentResponseBodyDataConfiguredSkillsVersionSelector VersionSelector { get; set; }
                public class CreateManagedAgentResponseBodyDataConfiguredSkillsVersionSelector : TeaModel {
                    /// <summary>
                    /// <para>The type of the version selector.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LABEL</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the selector. For LABEL, specify the tag name, such as latest. For VERSION, specify the exact version number.</para>
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
            /// <para>The target configuration accepted by the managed agent, which does not mean it has taken effect at runtime. This field is used in the detail responses of CreateManagedAgent, UpdateManagedAgent, and GetManagedAgent. In the configuration of a fixed version, it represents the configuration snapshot saved for that version. A returned object with enabled:false indicates that the configuration is disabled. The absence of the entire object indicates that the response does not provide the configuration.</para>
            /// </summary>
            [NameInMap("contextConfiguration")]
            [Validation(Required=false)]
            public CreateManagedAgentResponseBodyDataContextConfiguration ContextConfiguration { get; set; }
            public class CreateManagedAgentResponseBodyDataContextConfiguration : TeaModel {
                /// <summary>
                /// <para>Read-only resource references. This field may be omitted when no selection is made. A disabled configuration can still retain non-empty selections. You cannot determine whether the configuration is enabled solely based on whether the array is empty.</para>
                /// </summary>
                [NameInMap("bindings")]
                [Validation(Required=false)]
                public List<CreateManagedAgentResponseBodyDataContextConfigurationBindings> Bindings { get; set; }
                public class CreateManagedAgentResponseBodyDataContextConfigurationBindings : TeaModel {
                    /// <summary>
                    /// <para>The context resource ID in the current workspace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kb-example</para>
                    /// </summary>
                    [NameInMap("resourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>Read-only string. Currently known types are KNOWLEDGE_BASE (knowledge base) and DATA_CONNECTOR (data connector). The response may be extended with new types. The client should retain unknown values and should not fail to parse the entire response due to unknown types. New request types are subject to the actual support scope of the server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KNOWLEDGE_BASE</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Read-only. When the configuration object is returned, this field indicates the enabling status of the configuration. A value of false indicates that the configuration is disabled. The absence of the entire configuration object indicates that the response does not provide the configuration, which cannot be treated as false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

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
            /// <para>The description of the managed Harness agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agent for code review</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Read-only. This field is provided only by GetManagedAgent when an effective version exists, and corresponds to the configuration snapshot of effectiveSpecVersion. When a new version is being prepared or fails to be published, it remains the original effective configuration. It is not returned before the first time it takes effect, or in CreateManagedAgent, UpdateManagedAgent, and the configuration of a fixed version. Omission does not mean it is disabled, and the client cannot automatically fill it with enabled:false.</para>
            /// </summary>
            [NameInMap("effectiveContextConfiguration")]
            [Validation(Required=false)]
            public CreateManagedAgentResponseBodyDataEffectiveContextConfiguration EffectiveContextConfiguration { get; set; }
            public class CreateManagedAgentResponseBodyDataEffectiveContextConfiguration : TeaModel {
                /// <summary>
                /// <para>Read-only resource references. This field may be omitted when no selection is made. A disabled configuration can still retain non-empty selections. You cannot determine whether the configuration is enabled solely based on whether the array is empty.</para>
                /// </summary>
                [NameInMap("bindings")]
                [Validation(Required=false)]
                public List<CreateManagedAgentResponseBodyDataEffectiveContextConfigurationBindings> Bindings { get; set; }
                public class CreateManagedAgentResponseBodyDataEffectiveContextConfigurationBindings : TeaModel {
                    /// <summary>
                    /// <para>The context resource ID in the current workspace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kb-example</para>
                    /// </summary>
                    [NameInMap("resourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>Read-only string. Currently known types are KNOWLEDGE_BASE (knowledge base) and DATA_CONNECTOR (data connector). The response may be extended with new types. The client should retain unknown values and should not fail to parse the entire response due to unknown types. New request types are subject to the actual support scope of the server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KNOWLEDGE_BASE</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Read-only. When the configuration object is returned, this field indicates the enabling status of the configuration. A value of false indicates that the configuration is disabled. The absence of the entire configuration object indicates that the response does not provide the configuration, which cannot be treated as false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

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
                    /// <para>The ID of the credential.</para>
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
                    /// <para>The name of the environment variable.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>API_KEY</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value of the environment variable.</para>
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
            /// <para>The agent runtime framework.</para>
            /// </summary>
            [NameInMap("harness")]
            [Validation(Required=false)]
            public CreateManagedAgentResponseBodyDataHarness Harness { get; set; }
            public class CreateManagedAgentResponseBodyDataHarness : TeaModel {
                /// <summary>
                /// <para>The runtime framework configuration.</para>
                /// </summary>
                [NameInMap("configuration")]
                [Validation(Required=false)]
                public CreateManagedAgentResponseBodyDataHarnessConfiguration Configuration { get; set; }
                public class CreateManagedAgentResponseBodyDataHarnessConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The connector account key record ID bound to qodercli, which is not the original service account key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key-xxxx</para>
                    /// </summary>
                    [NameInMap("connectorServiceAccountKey")]
                    [Validation(Required=false)]
                    public string ConnectorServiceAccountKey { get; set; }

                    /// <summary>
                    /// <para>The connector account name bound to qodercli.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-connector-key</para>
                    /// </summary>
                    [NameInMap("connectorServiceAccountName")]
                    [Validation(Required=false)]
                    public string ConnectorServiceAccountName { get; set; }

                }

                /// <summary>
                /// <para>Returned only in queries. The server calculates this based on the complete instance distribution, which is not affected by the pagination and filtering of the instance list. It is empty when the image tag is missing, pagination is incomplete, or it cannot be confirmed, which is not equivalent to 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("outdatedInstanceCount")]
                [Validation(Required=false)]
                public long? OutdatedInstanceCount { get; set; }

                /// <summary>
                /// <para>The runtime framework type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qodercli</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Returned only in queries. Currently returns the pool target image tag. It is empty when it cannot be parsed, and cannot be replaced by the agent configuration version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202611031754</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

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
                /// <para>The model token quota configuration and usage status for the current period. This field is empty if no quota is configured.</para>
                /// </summary>
                [NameInMap("quota")]
                [Validation(Required=false)]
                public CreateManagedAgentResponseBodyDataModelQuota Quota { get; set; }
                public class CreateManagedAgentResponseBodyDataModelQuota : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the quota is enabled. This field is not returned if no quota is configured.</para>
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
                    /// <para>Indicates whether the quota is exceeded in the current period. This field is read-only and returned by the backend.</para>
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
                    /// <para>The gateway quota rule status. This field is read-only and returned by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACTIVE</para>
                    /// </summary>
                    [NameInMap("ruleStatus")]
                    [Validation(Required=false)]
                    public string RuleStatus { get; set; }

                    /// <summary>
                    /// <para>The maximum number of tokens allowed to be consumed in a single period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000000</para>
                    /// </summary>
                    [NameInMap("usageLimit")]
                    [Validation(Required=false)]
                    public long? UsageLimit { get; set; }

                    /// <summary>
                    /// <para>The number of tokens consumed in the current period. This field is read-only and returned by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("usedAmount")]
                    [Validation(Required=false)]
                    public long? UsedAmount { get; set; }

                }

                /// <summary>
                /// <para>The thinking level. If not configured, the value defaults to default. Empty strings, null values, or omitted fields are handled according to the default behavior of the model and Harness. Valid values: off, low, medium, high, xhigh, and max. If this parameter is not passed or is null during creation, default is used. When updating and submitting the model configuration, if the thinking level is not passed or is null, it reverts to default. Except for off, which is converted to none, the value is passed to the runtime framework as-is without validating model support or automatically downgrading. If the model does not support the specified level, adjust the level accordingly.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("thinkingLevel")]
                [Validation(Required=false)]
                public string ThinkingLevel { get; set; }

            }

            /// <summary>
            /// <para>The name of the managed Harness agent.</para>
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
                public CreateManagedAgentResponseBodyDataNetworkAccessVpc AccessVpc { get; set; }
                public class CreateManagedAgentResponseBodyDataNetworkAccessVpc : TeaModel {
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
            /// <para>The list of OSS mounts. A maximum of 10 items are supported.</para>
            /// </summary>
            [NameInMap("ossMounts")]
            [Validation(Required=false)]
            public List<CreateManagedAgentResponseBodyDataOssMounts> OssMounts { get; set; }
            public class CreateManagedAgentResponseBodyDataOssMounts : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket. This field is required for each mount item and is validated by the backend.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bucket-001</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The absolute mount path in the container, such as <c>/data/train</c>. Mount targets cannot be duplicated or form parent-child overwrites, and must avoid platform-reserved directories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/oss/datasets</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The non-empty relative directory prefix in the configured bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>datasets</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. Default value: false.</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            /// <summary>
            /// <para>The prompt variable declaration.</para>
            /// </summary>
            [NameInMap("promptVariables")]
            [Validation(Required=false)]
            public List<CreateManagedAgentResponseBodyDataPromptVariables> PromptVariables { get; set; }
            public class CreateManagedAgentResponseBodyDataPromptVariables : TeaModel {
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
                /// <para>The sandbox auto-scaling and session configuration.</para>
                /// </summary>
                [NameInMap("hpa")]
                [Validation(Required=false)]
                public CreateManagedAgentResponseBodyDataRuntimeHpa Hpa { get; set; }
                public class CreateManagedAgentResponseBodyDataRuntimeHpa : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether elastic auto-scaling is enabled in the current configuration.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent sessions per instance in the current configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("maxConcurrentSessionsPerSandbox")]
                    [Validation(Required=false)]
                    public int? MaxConcurrentSessionsPerSandbox { get; set; }

                    /// <summary>
                    /// <para>The maximum number of instances in the current configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("maxSandboxCount")]
                    [Validation(Required=false)]
                    public int? MaxSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The minimum number of instances in the current configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minSandboxCount")]
                    [Validation(Required=false)]
                    public int? MinSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The maximum session idle time in the current configuration, in seconds.</para>
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
                public CreateManagedAgentResponseBodyDataRuntimeSessionPolicy SessionPolicy { get; set; }
                public class CreateManagedAgentResponseBodyDataRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The HTTP header name used for session affinity. This field takes effect when sessionPolicy.type is set to ISOLATED_HEADER_FIELD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>X-Session-Id</para>
                    /// </summary>
                    [NameInMap("headerName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>The type of the session policy.</para>
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
            /// <para>The instance counts of managed Harness agents by sandbox phase. Current keys: PENDING (creating or initializing), RUNNING (running), HIBERNATING (hibernating), HIBERNATED (hibernated), RESUMING (resuming), TERMINATING (terminating), and FAILED (failed at runtime). Only phases that actually occur are returned, and missing keys are treated as 0. This field is a dynamic map and new keys may be added in the future. The frontend can use FAILED &gt; 0 to determine whether abnormal instances exist.</para>
            /// </summary>
            [NameInMap("sandboxPhaseCounts")]
            [Validation(Required=false)]
            public Dictionary<string, long?> SandboxPhaseCounts { get; set; }

            /// <summary>
            /// <para>The list of skill configurations.</para>
            /// </summary>
            [NameInMap("skills")]
            [Validation(Required=false)]
            public List<CreateManagedAgentResponseBodyDataSkills> Skills { get; set; }
            public class CreateManagedAgentResponseBodyDataSkills : TeaModel {
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
                /// <para>Indicates whether the skill is from a fixed template. This field is read-only. Template items cannot be removed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("fromTemplate")]
                [Validation(Required=false)]
                public bool? FromTemplate { get; set; }

                /// <summary>
                /// <para>The name of the skill.</para>
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
                /// <para>The source type of the skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REFERENCE</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The current target version for legacy client compatibility. New clients use resolvedVersion and determine the effective runtime version based on appliedVersion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The version selector for the skill reference. Supports LABEL for tags and VERSION for specific versions. Defaults to LABEL/latest when omitted. Not applicable for STATIC sources.</para>
                /// </summary>
                [NameInMap("versionSelector")]
                [Validation(Required=false)]
                public CreateManagedAgentResponseBodyDataSkillsVersionSelector VersionSelector { get; set; }
                public class CreateManagedAgentResponseBodyDataSkillsVersionSelector : TeaModel {
                    /// <summary>
                    /// <para>The type of the version selector.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LABEL</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the selector. For LABEL, specify the tag name, such as latest. For VERSION, specify the exact version number.</para>
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
            /// <para>The status of the managed Harness agent.</para>
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
                /// <para>The instruction for the sub-agent.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Review the code</para>
                /// </summary>
                [NameInMap("instruction")]
                [Validation(Required=false)]
                public string Instruction { get; set; }

                /// <summary>
                /// <para>The name of the sub-agent.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reviewer-agent</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of skills for the sub-agent.</para>
                /// </summary>
                [NameInMap("skills")]
                [Validation(Required=false)]
                public List<CreateManagedAgentResponseBodyDataSubAgentsSkills> Skills { get; set; }
                public class CreateManagedAgentResponseBodyDataSubAgentsSkills : TeaModel {
                    /// <summary>
                    /// <para>The name of the skill.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>web-search</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The version of the skill.</para>
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
                /// <para>The name of the tool.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>code-reviewer</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the tool.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
