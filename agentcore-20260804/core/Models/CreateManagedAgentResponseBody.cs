// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateManagedAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. The value is SUCCESS when the operation succeeds.</para>
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
            /// <para>The AgenticFS additional mount list. The total number of items combined with ossMounts cannot exceed 10.</para>
            /// </summary>
            [NameInMap("agenticFsMounts")]
            [Validation(Required=false)]
            public List<CreateManagedAgentResponseBodyDataAgenticFsMounts> AgenticFsMounts { get; set; }
            public class CreateManagedAgentResponseBodyDataAgenticFsMounts : TeaModel {
                /// <summary>
                /// <para>The subdirectory under /mnt/agenticfs/ in the container. This field is validated as required by the backend for each mount entry. Mount targets must not be duplicated or have parent-child overlaps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs/data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>A non-empty relative directory that exists under the AccessPoint. This field is validated as required by the backend for each mount entry. Root directories, absolute paths, and parent directory segments are not allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspace/data</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether to mount in read-only mode. Default value: false. This is not a RAM role read-only policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The AccessPoint domain name. This field is validated as required by the backend for each mount entry. Do not include the protocol, port, or path. Use the DomainName value from the NAS ListAccessPoints response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>仅包含用户追加或覆盖的 Skill，不包含模板继承项。资源模型读取此字段以保留更新语义；创建和更新仍使用请求中的 skills。</para>
            /// </summary>
            [NameInMap("configuredSkills")]
            [Validation(Required=false)]
            public List<CreateManagedAgentResponseBodyDataConfiguredSkills> ConfiguredSkills { get; set; }
            public class CreateManagedAgentResponseBodyDataConfiguredSkills : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>web-search</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>REFERENCE</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("versionSelector")]
                [Validation(Required=false)]
                public CreateManagedAgentResponseBodyDataConfiguredSkillsVersionSelector VersionSelector { get; set; }
                public class CreateManagedAgentResponseBodyDataConfiguredSkillsVersionSelector : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>LABEL</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
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
            /// <para>The agent runtime harness.</para>
            /// </summary>
            [NameInMap("harness")]
            [Validation(Required=false)]
            public CreateManagedAgentResponseBodyDataHarness Harness { get; set; }
            public class CreateManagedAgentResponseBodyDataHarness : TeaModel {
                /// <summary>
                /// <para>The runtime harness configuration.</para>
                /// </summary>
                [NameInMap("configuration")]
                [Validation(Required=false)]
                public CreateManagedAgentResponseBodyDataHarnessConfiguration Configuration { get; set; }
                public class CreateManagedAgentResponseBodyDataHarnessConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The connector service account key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key-xxxx</para>
                    /// </summary>
                    [NameInMap("connectorServiceAccountKey")]
                    [Validation(Required=false)]
                    public string ConnectorServiceAccountKey { get; set; }

                    /// <summary>
                    /// <para>The connector service account name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-connector-key</para>
                    /// </summary>
                    [NameInMap("connectorServiceAccountName")]
                    [Validation(Required=false)]
                    public string ConnectorServiceAccountName { get; set; }

                }

                /// <summary>
                /// <para>The runtime harness type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qodercli</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

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
            /// <para>The latest version status.</para>
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
                /// <para>The model token quota configuration and quota usage status for the current period. This field is empty if no quota is configured.</para>
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
                    /// <para>Indicates whether the quota has been exceeded in the current period. This field is read-only and returned by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("overLimit")]
                    [Validation(Required=false)]
                    public bool? OverLimit { get; set; }

                    /// <summary>
                    /// <para>The quota statistical period. A value of day indicates daily and a value of month indicates monthly.</para>
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
                    /// <para>The maximum number of tokens that can be consumed within a single period.</para>
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
                    /// <para>Specifies whether to allow public network access.</para>
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
            /// <para>The OSS mount list. A maximum of 10 entries are allowed.</para>
            /// </summary>
            [NameInMap("ossMounts")]
            [Validation(Required=false)]
            public List<CreateManagedAgentResponseBodyDataOssMounts> OssMounts { get; set; }
            public class CreateManagedAgentResponseBodyDataOssMounts : TeaModel {
                /// <summary>
                /// <para>The OSS bucket name. This field is validated as required by the backend for each mount entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bucket-001</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The absolute mount path in the container. This field is validated as required by the backend for each mount entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/oss/datasets</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The relative object prefix within the bucket. If not specified, the entire bucket is mounted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>datasets</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether to mount in read-only mode. Default value: false.</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

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
                    /// <para>The compute class.</para>
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
                    /// <para>Specifies whether to enable auto-scaling. This field is validated as required by the backend when hpa is present.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The maximum number of active sessions per sandbox. This field is validated as required by the backend when hpa is present.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("maxConcurrentSessionsPerSandbox")]
                    [Validation(Required=false)]
                    public int? MaxConcurrentSessionsPerSandbox { get; set; }

                    /// <summary>
                    /// <para>The maximum number of sandboxes. Required when HPA is enabled. The value must be greater than or equal to the minimum value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("maxSandboxCount")]
                    [Validation(Required=false)]
                    public int? MaxSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The minimum number of sandboxes. Required when HPA is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minSandboxCount")]
                    [Validation(Required=false)]
                    public int? MinSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The time-to-live (TTL) for a session after inactivity, in seconds. This field is validated as required by the backend when hpa is present.</para>
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
                    /// <para>The name of the HTTP header used for session affinity. This parameter takes effect when sessionPolicy.type is set to ISOLATED_HEADER_FIELD.</para>
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
            /// <para>The instance counts of the managed agent grouped by sandbox phase. Current keys: PENDING (being created or initialized), RUNNING (running), HIBERNATING (entering hibernation), HIBERNATED (hibernated), RESUMING (resuming), TERMINATING (being terminated), FAILED (runtime failure). Only phases that actually occur are returned. Missing keys are treated as 0. This field is a dynamic mapping and new keys may be added in the future. The frontend can use FAILED &gt; 0 to determine whether abnormal instances exist.</para>
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
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("appliedVersion")]
                [Validation(Required=false)]
                public string AppliedVersion { get; set; }

                /// <summary>
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
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("resolvedVersion")]
                [Validation(Required=false)]
                public string ResolvedVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>REFERENCE</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The skill version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("versionSelector")]
                [Validation(Required=false)]
                public CreateManagedAgentResponseBodyDataSkillsVersionSelector VersionSelector { get; set; }
                public class CreateManagedAgentResponseBodyDataSkillsVersionSelector : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>LABEL</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>latest</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

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

            }

            /// <summary>
            /// <para>The template configuration.</para>
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
        /// <para>The HTTP status code. The value 200 indicates success.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
