// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetManagedAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. The value is SUCCESS if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the managed Harness agent.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetManagedAgentResponseBodyData Data { get; set; }
        public class GetManagedAgentResponseBodyData : TeaModel {
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
            /// <para>The ID of the managed Harness agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-1</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The NAS storage mount configuration. Currently, only the AgenticFS type is supported, which is used to mount file directories in access points to agent runtime instances. The total number of NAS and OSS mounts cannot exceed 10.</para>
            /// </summary>
            [NameInMap("agenticFsMounts")]
            [Validation(Required=false)]
            public List<GetManagedAgentResponseBodyDataAgenticFsMounts> AgenticFsMounts { get; set; }
            public class GetManagedAgentResponseBodyDataAgenticFsMounts : TeaModel {
                /// <summary>
                /// <para>The absolute mount path in the container, such as /data/train. Mount targets must not be duplicated or form parent-child overrides, and must avoid platform-reserved directories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs/data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The existing non-empty relative directory under the access point. This field is required and validated by the backend for each mount item. Root directories, absolute paths, and parent directory segments are not allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspace/data</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. If omitted, the default value is false. This is not a read-only policy for a RAM role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The domain name of the access point. This field is required and validated by the backend for each mount item. It must not contain protocols, ports, or paths. Use the DomainName value from the NAS ListAccessPoints response.</para>
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
            public List<GetManagedAgentResponseBodyDataConfiguredSkills> ConfiguredSkills { get; set; }
            public class GetManagedAgentResponseBodyDataConfiguredSkills : TeaModel {
                /// <summary>
                /// <para>The name of the skill in the workspace AI registry.</para>
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
                /// <para>The legacy compatibility field. For new requests, use sourceType and versionSelector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The version selector for the skill reference. Supports LABEL for tags and VERSION for specific versions. If omitted, LABEL/latest is used. Selectors are not provided for STATIC sources.</para>
                /// </summary>
                [NameInMap("versionSelector")]
                [Validation(Required=false)]
                public GetManagedAgentResponseBodyDataConfiguredSkillsVersionSelector VersionSelector { get; set; }
                public class GetManagedAgentResponseBodyDataConfiguredSkillsVersionSelector : TeaModel {
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
                    /// <para>The value of the selector. For LABEL, it is the tag name, such as latest. For VERSION, it is the specific version number.</para>
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
            public GetManagedAgentResponseBodyDataEnvironment Environment { get; set; }
            public class GetManagedAgentResponseBodyDataEnvironment : TeaModel {
                /// <summary>
                /// <para>The list of credential references.</para>
                /// </summary>
                [NameInMap("credentialReferences")]
                [Validation(Required=false)]
                public List<GetManagedAgentResponseBodyDataEnvironmentCredentialReferences> CredentialReferences { get; set; }
                public class GetManagedAgentResponseBodyDataEnvironmentCredentialReferences : TeaModel {
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
                public List<GetManagedAgentResponseBodyDataEnvironmentVariables> Variables { get; set; }
                public class GetManagedAgentResponseBodyDataEnvironmentVariables : TeaModel {
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
            public GetManagedAgentResponseBodyDataHarness Harness { get; set; }
            public class GetManagedAgentResponseBodyDataHarness : TeaModel {
                /// <summary>
                /// <para>The runtime framework configuration.</para>
                /// </summary>
                [NameInMap("configuration")]
                [Validation(Required=false)]
                public GetManagedAgentResponseBodyDataHarnessConfiguration Configuration { get; set; }
                public class GetManagedAgentResponseBodyDataHarnessConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The ID of the connector account key record bound to qodercli. This is not the original service account key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key-xxxx</para>
                    /// </summary>
                    [NameInMap("connectorServiceAccountKey")]
                    [Validation(Required=false)]
                    public string ConnectorServiceAccountKey { get; set; }

                    /// <summary>
                    /// <para>The name of the connector account bound to qodercli.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-connector-key</para>
                    /// </summary>
                    [NameInMap("connectorServiceAccountName")]
                    [Validation(Required=false)]
                    public string ConnectorServiceAccountName { get; set; }

                }

                /// <summary>
                /// <para>仅查询返回。服务端按完整实例分布统计，不受实例列表分页和筛选影响。镜像 tag 缺失、分页不完整或无法确认时为空，不等同于 0。</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("outdatedInstanceCount")]
                [Validation(Required=false)]
                public long? OutdatedInstanceCount { get; set; }

                /// <summary>
                /// <para>The type of the runtime framework.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qodercli</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>仅查询返回。当前返回 Pool 目标镜像 tag；无法解析时为空，不能用 Agent 配置版本代替。</para>
                /// 
                /// <b>Example:</b>
                /// <para>202611031754</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The agent instructions used to guide the behavior of the agent.</para>
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
            public GetManagedAgentResponseBodyDataModel Model { get; set; }
            public class GetManagedAgentResponseBodyDataModel : TeaModel {
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
                /// <para>The name of the upstream model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-max</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The model token quota configuration and the quota usage status for the current cycle. This field is empty if no quota is configured.</para>
                /// </summary>
                [NameInMap("quota")]
                [Validation(Required=false)]
                public GetManagedAgentResponseBodyDataModelQuota Quota { get; set; }
                public class GetManagedAgentResponseBodyDataModelQuota : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether the quota is enabled. This field is not returned if no quota is configured.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The type of the quota limit. Currently, only token is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>token</para>
                    /// </summary>
                    [NameInMap("limitType")]
                    [Validation(Required=false)]
                    public string LimitType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the quota for the current cycle is exceeded. This field is read-only and returned by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("overLimit")]
                    [Validation(Required=false)]
                    public bool? OverLimit { get; set; }

                    /// <summary>
                    /// <para>The quota statistical epoch. Valid values: day: daily, month: monthly.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>day</para>
                    /// </summary>
                    [NameInMap("periodType")]
                    [Validation(Required=false)]
                    public string PeriodType { get; set; }

                    /// <summary>
                    /// <para>The status of the gateway quota rule. This field is read-only and returned by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACTIVE</para>
                    /// </summary>
                    [NameInMap("ruleStatus")]
                    [Validation(Required=false)]
                    public string RuleStatus { get; set; }

                    /// <summary>
                    /// <para>The maximum number of tokens that can be consumed in a single cycle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000000</para>
                    /// </summary>
                    [NameInMap("usageLimit")]
                    [Validation(Required=false)]
                    public long? UsageLimit { get; set; }

                    /// <summary>
                    /// <para>The number of tokens consumed in the current cycle. This field is read-only and returned by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("usedAmount")]
                    [Validation(Required=false)]
                    public long? UsedAmount { get; set; }

                }

                /// <summary>
                /// <para>未配置时表示 default，空字符串、null 或省略均按模型和 Harness 默认行为处理。可选值 off、low、medium、high、xhigh、max。创建未传或 null 时使用 default；更新提交模型配置时，思考强度未传或为 null 均恢复 default。除 off 转为 none 外原样传给运行框架，不校验模型支持情况、不自动降档；模型不支持时请调整强度。</para>
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
            public GetManagedAgentResponseBodyDataNetwork Network { get; set; }
            public class GetManagedAgentResponseBodyDataNetwork : TeaModel {
                /// <summary>
                /// <para>The public network access configuration.</para>
                /// </summary>
                [NameInMap("accessInternet")]
                [Validation(Required=false)]
                public GetManagedAgentResponseBodyDataNetworkAccessInternet AccessInternet { get; set; }
                public class GetManagedAgentResponseBodyDataNetworkAccessInternet : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether Internet access is allowed.</para>
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
                public GetManagedAgentResponseBodyDataNetworkAccessVpc AccessVpc { get; set; }
                public class GetManagedAgentResponseBodyDataNetworkAccessVpc : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether VPC access is allowed.</para>
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
            /// <para>The list of OSS mounts. A maximum of 10 items are allowed.</para>
            /// </summary>
            [NameInMap("ossMounts")]
            [Validation(Required=false)]
            public List<GetManagedAgentResponseBodyDataOssMounts> OssMounts { get; set; }
            public class GetManagedAgentResponseBodyDataOssMounts : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket. This field is required and validated by the backend for each mount item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bucket-001</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The absolute mount path in the container, such as /data/train. Mount targets must not be duplicated or form parent-child overrides, and must avoid platform-reserved directories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/oss/datasets</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The non-empty relative directory prefix in the currently configured bucket.</para>
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
            /// <para>The prompt variable declarations.</para>
            /// </summary>
            [NameInMap("promptVariables")]
            [Validation(Required=false)]
            public List<GetManagedAgentResponseBodyDataPromptVariables> PromptVariables { get; set; }
            public class GetManagedAgentResponseBodyDataPromptVariables : TeaModel {
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
            public GetManagedAgentResponseBodyDataRuntime Runtime { get; set; }
            public class GetManagedAgentResponseBodyDataRuntime : TeaModel {
                /// <summary>
                /// <para>The compute configuration.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("compute")]
                [Validation(Required=false)]
                public GetManagedAgentResponseBodyDataRuntimeCompute Compute { get; set; }
                public class GetManagedAgentResponseBodyDataRuntimeCompute : TeaModel {
                    /// <summary>
                    /// <para>The compute specifications.</para>
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
                public GetManagedAgentResponseBodyDataRuntimeHpa Hpa { get; set; }
                public class GetManagedAgentResponseBodyDataRuntimeHpa : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether elastic auto-scaling is enabled in the current configuration.</para>
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
                    /// <para>The maximum idle time for a session in the current configuration, in seconds.</para>
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
                public GetManagedAgentResponseBodyDataRuntimeSessionPolicy SessionPolicy { get; set; }
                public class GetManagedAgentResponseBodyDataRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The name of the HTTP header used for session affinity. This field takes effect when sessionPolicy.type is set to ISOLATED_HEADER_FIELD.</para>
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
            /// <para>The number of managed Harness agent instances by sandbox phase. Current keys: PENDING (creating or initializing), RUNNING (running), HIBERNATING (hibernating), HIBERNATED (hibernated), RESUMING (resuming), TERMINATING (terminating), and FAILED (failed during runtime). Only phases that actually occur are returned. Missing keys are treated as 0. This field is a dynamic map and new keys may be added in the future. The frontend can use FAILED &gt; 0 to determine whether abnormal instances exist.</para>
            /// </summary>
            [NameInMap("sandboxPhaseCounts")]
            [Validation(Required=false)]
            public Dictionary<string, long?> SandboxPhaseCounts { get; set; }

            /// <summary>
            /// <para>The list of skill configurations.</para>
            /// </summary>
            [NameInMap("skills")]
            [Validation(Required=false)]
            public List<GetManagedAgentResponseBodyDataSkills> Skills { get; set; }
            public class GetManagedAgentResponseBodyDataSkills : TeaModel {
                /// <summary>
                /// <para>The applied version in the runtime. This field is read-only.</para>
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
                /// <para>The source type of the skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REFERENCE</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The current target version compatible with legacy clients. New clients use resolvedVersion and determine the applied runtime version by using appliedVersion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The version selector for the skill reference. Supports LABEL for tags and VERSION for specific versions. If omitted, LABEL/latest is used. Selectors are not provided for STATIC sources.</para>
                /// </summary>
                [NameInMap("versionSelector")]
                [Validation(Required=false)]
                public GetManagedAgentResponseBodyDataSkillsVersionSelector VersionSelector { get; set; }
                public class GetManagedAgentResponseBodyDataSkillsVersionSelector : TeaModel {
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
                    /// <para>The value of the selector. For LABEL, it is the tag name, such as latest. For VERSION, it is the specific version number.</para>
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
            public List<GetManagedAgentResponseBodyDataSubAgents> SubAgents { get; set; }
            public class GetManagedAgentResponseBodyDataSubAgents : TeaModel {
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
                public List<GetManagedAgentResponseBodyDataSubAgentsSkills> Skills { get; set; }
                public class GetManagedAgentResponseBodyDataSubAgentsSkills : TeaModel {
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
            public GetManagedAgentResponseBodyDataTemplate Template { get; set; }
            public class GetManagedAgentResponseBodyDataTemplate : TeaModel {
                /// <summary>
                /// <para>The AI registry template configuration.</para>
                /// </summary>
                [NameInMap("aiRegistry")]
                [Validation(Required=false)]
                public GetManagedAgentResponseBodyDataTemplateAiRegistry AiRegistry { get; set; }
                public class GetManagedAgentResponseBodyDataTemplateAiRegistry : TeaModel {
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
            public List<GetManagedAgentResponseBodyDataTools> Tools { get; set; }
            public class GetManagedAgentResponseBodyDataTools : TeaModel {
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
        /// <para>The HTTP status code. The value is 200 if the request is successful.</para>
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
