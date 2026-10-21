// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetCustomAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The request result code. The value is SUCCESS if the request is successful.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The latest submitted configuration and status of the custom agent. To determine whether the configuration has taken effect, refer to latestVersionStatus.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetCustomAgentResponseBodyData Data { get; set; }
        public class GetCustomAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the custom agent. You can obtain this identifier from the response of CreateCustomAgent or ListCustomAgents.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-550e8400e29b41d4a716446655440000</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The latest submitted list of additional AgenticFS mounts.</para>
            /// </summary>
            [NameInMap("agenticFsMounts")]
            [Validation(Required=false)]
            public List<GetCustomAgentResponseBodyDataAgenticFsMounts> AgenticFsMounts { get; set; }
            public class GetCustomAgentResponseBodyDataAgenticFsMounts : TeaModel {
                /// <summary>
                /// <para>The AgenticFS mount directory in the container, located under /mnt/agenticfs/.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs/data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The relative directory within the mounted access point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspace/data</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. A value of true indicates read-only, and false indicates read and write.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The AgenticFS access point domain name used for the mount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The latest submitted deployment artifact configuration, including the service listening port and ACR container image. To determine whether the configuration has taken effect, refer to latestVersionStatus.</para>
            /// </summary>
            [NameInMap("artifact")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataArtifact Artifact { get; set; }
            public class GetCustomAgentResponseBodyDataArtifact : TeaModel {
                /// <summary>
                /// <para>The code package configuration field. Code package deployment is not supported.</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataArtifactCode Code { get; set; }
                public class GetCustomAgentResponseBodyDataArtifactCode : TeaModel {
                    /// <summary>
                    /// <para>The startup entry point of the code package. Code package deployment is not supported.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python app.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The language runtime identifier of the code package. Code package deployment is not supported.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python</para>
                    /// </summary>
                    [NameInMap("languageRuntime")]
                    [Validation(Required=false)]
                    public string LanguageRuntime { get; set; }

                    /// <summary>
                    /// <para>The source URI of the code package. Code package deployment is not supported.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://my-agent-bucket/packages/agent.zip</para>
                    /// </summary>
                    [NameInMap("sourceUri")]
                    [Validation(Required=false)]
                    public string SourceUri { get; set; }

                }

                /// <summary>
                /// <para>The latest submitted ACR container image configuration.</para>
                /// </summary>
                [NameInMap("container")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataArtifactContainer Container { get; set; }
                public class GetCustomAgentResponseBodyDataArtifactContainer : TeaModel {
                    /// <summary>
                    /// <para>The custom executable program and startup parameters. If not configured, the default startup method of the image is used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python app.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The ID of the ACR instance to which the image repository belongs.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cri-a1b2c3d4e5f6</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The namespace to which the ACR image repository belongs.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-agent</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The name of the image repository in the ACR namespace.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chat-agent</para>
                    /// </summary>
                    [NameInMap("repo")]
                    [Validation(Required=false)]
                    public string Repo { get; set; }

                    /// <summary>
                    /// <para>The latest submitted image tag.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1.0.0</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The image source type. A value of acr indicates Alibaba Cloud Container Registry (ACR).</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acr</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The TCP port listened by the agent service.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            /// <summary>
            /// <para>The creation method of the agent. CUSTOM is returned for custom agents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("createMode")]
            [Validation(Required=false)]
            public string CreateMode { get; set; }

            /// <summary>
            /// <para>The creation time of the agent. The time is in ISO 8601 format. The trailing Z indicates the UTC time zone. Fractional seconds may be included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-10T06:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The deployment method of the agent. MANAGED is returned for custom agents because they are deployed and managed by the platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MANAGED</para>
            /// </summary>
            [NameInMap("deployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// <para>The description of the agent\&quot;s purpose.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom agent that provides conversational services</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The value is null if no effective version exists. Do not use latestSpecVersion as a substitute. This field cannot be used to release the occupation protection of old cached instances.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("effectiveSpecVersion")]
            [Validation(Required=false)]
            public long? EffectiveSpecVersion { get; set; }

            /// <summary>
            /// <para>The environment variable configuration for the agent process.</para>
            /// </summary>
            [NameInMap("environment")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataEnvironment Environment { get; set; }
            public class GetCustomAgentResponseBodyDataEnvironment : TeaModel {
                /// <summary>
                /// <para>The latest submitted list of environment variables.</para>
                /// </summary>
                [NameInMap("variables")]
                [Validation(Required=false)]
                public List<GetCustomAgentResponseBodyDataEnvironmentVariables> Variables { get; set; }
                public class GetCustomAgentResponseBodyDataEnvironmentVariables : TeaModel {
                    /// <summary>
                    /// <para>The name of the environment variable.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LOG_LEVEL</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The string value of the environment variable. Empty strings are allowed.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>info</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The HTTP health check configuration of the agent. The value is empty if not configured.</para>
            /// </summary>
            [NameInMap("healthCheck")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataHealthCheck HealthCheck { get; set; }
            public class GetCustomAgentResponseBodyDataHealthCheck : TeaModel {
                /// <summary>
                /// <para>This parameter does not take effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("healthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The interval between two health checks, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("intervalSeconds")]
                [Validation(Required=false)]
                public int? IntervalSeconds { get; set; }

                /// <summary>
                /// <para>The HTTP health check path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/healthz</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The port accessed for the HTTP health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The timeout period for a single health check, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("timeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The number of consecutive health check failures required to mark the instance as unhealthy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("unhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>This field is always returned. If useImageCache is true, the value is the non-empty logical ID of the current workspace. If useImageCache is false, the value is null. The occupation of old instances after disabling is independently protected by the backend and is not backfilled as the current configuration association.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>img-example</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("imageCacheId")]
            [Validation(Required=false)]
            public string ImageCacheId { get; set; }

            /// <summary>
            /// <para>The wait or execution error of the latest configuration version. This field is returned only when the version is waiting for a retry or fails to execute.</para>
            /// </summary>
            [NameInMap("latestExecutionError")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataLatestExecutionError LatestExecutionError { get; set; }
            public class GetCustomAgentResponseBodyDataLatestExecutionError : TeaModel {
                /// <summary>
                /// <para>The reason code for the wait or execution failure of the latest configuration. This code is used to determine the subsequent handling method.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AgentExecutionFailed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The description of the reason why the latest configuration is waiting or failed to execute. Refer to code and retryable to determine what to do next.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Agent execution failed. Check the configuration and resubmit</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Specifies whether automatic retries are performed. If the value is true, you can query again later. If the value is false, check and fix the configuration based on the reason, and then resubmit.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("retryable")]
                [Validation(Required=false)]
                public bool? Retryable { get; set; }

            }

            /// <summary>
            /// <para>The current latest configuration version number. Updates with the same configuration may retain the original version number. This field does not indicate that the configuration has taken effect.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("latestSpecVersion")]
            [Validation(Required=false)]
            public long? LatestSpecVersion { get; set; }

            /// <summary>
            /// <para>The execution status corresponding to latestSpecVersion. Valid values: pending (waiting for execution), processing (executing), waiting_retry (waiting for a retry), succeeded (execution successful), failed (execution failed), and superseded (replaced by a subsequent version).</para>
            /// 
            /// <b>Example:</b>
            /// <para>succeeded</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("latestVersionStatus")]
            [Validation(Required=false)]
            public string LatestVersionStatus { get; set; }

            /// <summary>
            /// <para>The latest submitted log delivery configuration.</para>
            /// </summary>
            [NameInMap("logging")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataLogging Logging { get; set; }
            public class GetCustomAgentResponseBodyDataLogging : TeaModel {
                /// <summary>
                /// <para>The Simple Log Service (SLS) log delivery destination.</para>
                /// </summary>
                [NameInMap("sls")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataLoggingSls Sls { get; set; }
                public class GetCustomAgentResponseBodyDataLoggingSls : TeaModel {
                    /// <summary>
                    /// <para>The name of the SLS Logstore that receives agent logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agent-runtime</para>
                    /// </summary>
                    [NameInMap("logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    /// <summary>
                    /// <para>The name of the SLS project that receives agent logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-agent-logs</para>
                    /// </summary>
                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                }

            }

            /// <summary>
            /// <para>The custom agent name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-custom-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network access configuration of the agent. The actual access scope is also restricted by the workspace network configuration.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataNetwork Network { get; set; }
            public class GetCustomAgentResponseBodyDataNetwork : TeaModel {
                /// <summary>
                /// <para>The Internet access configuration of the agent. If this parameter is not configured, Internet access is allowed on the agent side but remains restricted by the workspace.</para>
                /// </summary>
                [NameInMap("accessInternet")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataNetworkAccessInternet AccessInternet { get; set; }
                public class GetCustomAgentResponseBodyDataNetworkAccessInternet : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether Internet access is allowed on the agent side. The actual access remains restricted by the workspace.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

                /// <summary>
                /// <para>The user VPC access configuration of the agent. If this parameter is not configured, user VPC access is allowed on the agent side but remains restricted by the workspace.</para>
                /// </summary>
                [NameInMap("accessVpc")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataNetworkAccessVpc AccessVpc { get; set; }
                public class GetCustomAgentResponseBodyDataNetworkAccessVpc : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether access to the user VPC configured for the workspace is allowed on the agent side. The actual access remains restricted by the workspace.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

            }

            /// <summary>
            /// <para>The high-code agent observability configuration.</para>
            /// </summary>
            [NameInMap("observability")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataObservability Observability { get; set; }
            public class GetCustomAgentResponseBodyDataObservability : TeaModel {
                /// <summary>
                /// <para>Default value: true. If set to false, the platform Python probe is not loaded at runtime, and you must collect observability data yourself.</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>The list of recently submitted OSS directory mounts.</para>
            /// </summary>
            [NameInMap("ossMounts")]
            [Validation(Required=false)]
            public List<GetCustomAgentResponseBodyDataOssMounts> OssMounts { get; set; }
            public class GetCustomAgentResponseBodyDataOssMounts : TeaModel {
                /// <summary>
                /// <para>The name of the mounted OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-data</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The OSS mount directory in the container, located under /mnt/oss/.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/oss/train</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The object directory prefix in the mounted bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>datasets/train</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. A value of true indicates read-only, and false indicates read and write.</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            /// <summary>
            /// <para>The list of invocation protocol configurations for the agent.</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public List<GetCustomAgentResponseBodyDataProtocol> Protocol { get; set; }
            public class GetCustomAgentResponseBodyDataProtocol : TeaModel {
                /// <summary>
                /// <para>The request header configuration for the current protocol. The key is the name and the value is a string.</para>
                /// </summary>
                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                /// <summary>
                /// <para>The list of API paths corresponding to the current protocol.</para>
                /// </summary>
                [NameInMap("paths")]
                [Validation(Required=false)]
                public List<GetCustomAgentResponseBodyDataProtocolPaths> Paths { get; set; }
                public class GetCustomAgentResponseBodyDataProtocolPaths : TeaModel {
                    /// <summary>
                    /// <para>The usage description of the current API path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AG-UI conversation API</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The API path corresponding to the current protocol.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/agui</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The invocation protocol type. Valid values: agui: AG-UI protocol; openai-chat-completion: OpenAI Chat Completions compatible protocol; custom: custom protocol.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agui</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The region ID of the workspace to which the agent belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ARN of the RAM role used by the agent to access user cloud resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1234567890123456:role/agentcore-runtime-role</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The latest committed runtime configuration, including compute specifications, session policy, and elastic policy.</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataRuntime Runtime { get; set; }
            public class GetCustomAgentResponseBodyDataRuntime : TeaModel {
                /// <summary>
                /// <para>The compute resource configuration of the agent runtime instance.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("compute")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataRuntimeCompute Compute { get; set; }
                public class GetCustomAgentResponseBodyDataRuntimeCompute : TeaModel {
                    /// <summary>
                    /// <para>The compute specification. Valid values: INTERACTIVE: 1 vCPU and 2 GiB of memory; STANDARD: 2 vCPUs and 4 GiB of memory; HEAVY: 4 vCPUs and 8 GiB of memory.</para>
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
                /// <para>The elastic policy configuration of the agent.</para>
                /// </summary>
                [NameInMap("hpa")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataRuntimeHpa Hpa { get; set; }
                public class GetCustomAgentResponseBodyDataRuntimeHpa : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable elastic scaling. A value of true indicates that elastic scaling is enabled. A value of false indicates that elastic scaling is disabled.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The configured maximum number of concurrent sessions for a single runtime instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("maxConcurrentSessionsPerSandbox")]
                    [Validation(Required=false)]
                    public int? MaxConcurrentSessionsPerSandbox { get; set; }

                    /// <summary>
                    /// <para>The configured maximum number of runtime instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxSandboxCount")]
                    [Validation(Required=false)]
                    public int? MaxSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The configured minimum number of runtime instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minSandboxCount")]
                    [Validation(Required=false)]
                    public int? MinSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The configured session idle timeout limit, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>600</para>
                    /// </summary>
                    [NameInMap("sessionTtlSeconds")]
                    [Validation(Required=false)]
                    public int? SessionTtlSeconds { get; set; }

                }

                /// <summary>
                /// <para>The session policy configuration of the agent.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sessionPolicy")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataRuntimeSessionPolicy SessionPolicy { get; set; }
                public class GetCustomAgentResponseBodyDataRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The name of the HTTP request header used by the session policy. This parameter is applicable to ISOLATED_HEADER_FIELD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>X-Session-Id</para>
                    /// </summary>
                    [NameInMap("headerName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>The session policy type. Valid values: AFFINITY: session affinity; ISOLATED_HEADER_FIELD: uses the request header specified by headerName to associate sessions. ISOLATED_COOKIE is not recommended. The compatible value DISABLED in requests is returned as AFFINITY.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AFFINITY</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of instances by runtime instance phase. Keys include PENDING (creating or initializing), RUNNING (running), HIBERNATING (hibernating), HIBERNATED (hibernated), RESUMING (resuming), TERMINATING (terminating), and FAILED (failed). Only phases that actually occur are returned. Missing keys are treated as 0.</para>
            /// </summary>
            [NameInMap("sandboxPhaseCounts")]
            [Validation(Required=false)]
            public Dictionary<string, long?> SandboxPhaseCounts { get; set; }

            /// <summary>
            /// <para>The overall status of the agent. Valid values: Creating: creating; Running: running; Failed: failed; Updating: updating; Deleting: deleting; Deleted: deleted. To query the execution progress of the latest configuration, check latestVersionStatus.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the agent was last updated. The time is in ISO 8601 format. The trailing Z indicates the UTC time zone. Fractional seconds may be included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-10T06:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>Required. Reflects the accepted final configuration. If this field is missing in historical data, false is returned. Do not infer based on the cache status.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("useImageCache")]
            [Validation(Required=false)]
            public bool? UseImageCache { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the custom agent belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-a1b2c3d4e5f6</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the request. A value of 200 indicates success.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The processing result description of the request. A value of success indicates success.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which is used to locate and troubleshoot issues.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550E8400-E29B-41D4-A716-446655440000</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of true indicates that the request was successful. A successful creation, update, or deletion does not mean that the background operation is complete.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
