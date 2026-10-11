// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateCustomAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The request result code. The value is SUCCESS when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The latest submitted configuration and status of the custom agent. A successful response indicates that the request is accepted, but the configuration may not have taken effect yet.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateCustomAgentResponseBodyData Data { get; set; }
        public class CreateCustomAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the custom agent. You can obtain this ID from the response of the CreateCustomAgent or ListCustomAgents operation.</para>
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
            public List<CreateCustomAgentResponseBodyDataAgenticFsMounts> AgenticFsMounts { get; set; }
            public class CreateCustomAgentResponseBodyDataAgenticFsMounts : TeaModel {
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
                /// <para>Specifies whether the mount is read-only. A value of true indicates that the mount is read-only. A value of false indicates that the mount is readable and writable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The domain name of the AgenticFS access point used for the mount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The latest submitted deployment artifact configuration, including the service listening port and the ACR container image. To check whether the configuration has taken effect, refer to the latestVersionStatus field.</para>
            /// </summary>
            [NameInMap("artifact")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataArtifact Artifact { get; set; }
            public class CreateCustomAgentResponseBodyDataArtifact : TeaModel {
                /// <summary>
                /// <para>The code package configuration field. Code package deployment is not supported.</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataArtifactCode Code { get; set; }
                public class CreateCustomAgentResponseBodyDataArtifactCode : TeaModel {
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
                public CreateCustomAgentResponseBodyDataArtifactContainer Container { get; set; }
                public class CreateCustomAgentResponseBodyDataArtifactContainer : TeaModel {
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
                    /// <para>The image source type. A value of acr indicates Alibaba Cloud Container Registry.</para>
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
                /// <para>The TCP port listened on by the agent service.</para>
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
            /// <para>The creation method of the agent. The value is CUSTOM for custom agents.</para>
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
            /// <para>The deployment method of the agent. Custom agents are deployed and managed by the platform. The value is MANAGED for custom agents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MANAGED</para>
            /// </summary>
            [NameInMap("deployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// <para>The description of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom agent that provides conversation services</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The environment variable configuration for the agent process.</para>
            /// </summary>
            [NameInMap("environment")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataEnvironment Environment { get; set; }
            public class CreateCustomAgentResponseBodyDataEnvironment : TeaModel {
                /// <summary>
                /// <para>The latest submitted list of environment variables.</para>
                /// </summary>
                [NameInMap("variables")]
                [Validation(Required=false)]
                public List<CreateCustomAgentResponseBodyDataEnvironmentVariables> Variables { get; set; }
                public class CreateCustomAgentResponseBodyDataEnvironmentVariables : TeaModel {
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
            /// <para>The HTTP health check configuration of the agent. This field is empty if no health check is configured.</para>
            /// </summary>
            [NameInMap("healthCheck")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataHealthCheck HealthCheck { get; set; }
            public class CreateCustomAgentResponseBodyDataHealthCheck : TeaModel {
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
                /// <para>The interval between two consecutive health checks, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("intervalSeconds")]
                [Validation(Required=false)]
                public int? IntervalSeconds { get; set; }

                /// <summary>
                /// <para>The HTTP Health Check Path.</para>
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
                /// <para>The number of consecutive health check failures required to mark the agent as unhealthy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("unhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>The waiting or execution error of the latest configuration version. This field is returned only when the version is waiting for a retry or fails to execute.</para>
            /// </summary>
            [NameInMap("latestExecutionError")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataLatestExecutionError LatestExecutionError { get; set; }
            public class CreateCustomAgentResponseBodyDataLatestExecutionError : TeaModel {
                /// <summary>
                /// <para>The reason code for the waiting or execution failure of the latest configuration. This code is used to determine the subsequent handling method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AgentExecutionFailed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The description of the reason why the latest configuration is waiting or has failed to execute. Refer to the code and retryable fields to determine what to do next.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The agent execution failed. Check the configuration and resubmit</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Specifies whether the operation is automatically retried. A value of true indicates that you can query again later. A value of false indicates that you must check and fix the configuration based on the reason, and then resubmit the request.</para>
                /// </summary>
                [NameInMap("retryable")]
                [Validation(Required=false)]
                public bool? Retryable { get; set; }

            }

            /// <summary>
            /// <para>The latest configuration version number. Updates with the same configuration may retain the original version number. This field does not indicate that the configuration has taken effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("latestSpecVersion")]
            [Validation(Required=false)]
            public long? LatestSpecVersion { get; set; }

            /// <summary>
            /// <para>The execution status corresponding to latestSpecVersion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pending: Waiting for execution.</description></item>
            /// <item><description>processing: Executing.</description></item>
            /// <item><description>waiting_retry: Waiting for a retry.</description></item>
            /// <item><description>succeeded: Execution succeeded.</description></item>
            /// <item><description>failed: Execution failed.</description></item>
            /// <item><description>superseded: Superseded by a subsequent version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>succeeded</para>
            /// </summary>
            [NameInMap("latestVersionStatus")]
            [Validation(Required=false)]
            public string LatestVersionStatus { get; set; }

            /// <summary>
            /// <para>The latest submitted log delivery configuration.</para>
            /// </summary>
            [NameInMap("logging")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataLogging Logging { get; set; }
            public class CreateCustomAgentResponseBodyDataLogging : TeaModel {
                /// <summary>
                /// <para>The Simple Log Service (SLS) log delivery destination.</para>
                /// </summary>
                [NameInMap("sls")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataLoggingSls Sls { get; set; }
                public class CreateCustomAgentResponseBodyDataLoggingSls : TeaModel {
                    /// <summary>
                    /// <para>The name of the Simple Log Service Logstore that receives agent logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agent-runtime</para>
                    /// </summary>
                    [NameInMap("logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    /// <summary>
                    /// <para>The name of the Simple Log Service project that receives agent logs.</para>
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
            /// <para>The name of the custom agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-custom-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network access configuration of the agent. The actual access scope is also restricted by the network configuration of the workspace.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataNetwork Network { get; set; }
            public class CreateCustomAgentResponseBodyDataNetwork : TeaModel {
                /// <summary>
                /// <para>The Internet access configuration of the agent. If this field is not configured, Internet access is allowed on the agent side, but it is still restricted by the workspace.</para>
                /// </summary>
                [NameInMap("accessInternet")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataNetworkAccessInternet AccessInternet { get; set; }
                public class CreateCustomAgentResponseBodyDataNetworkAccessInternet : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether Internet access is allowed on the agent side. The actual access is still restricted by the workspace.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

                /// <summary>
                /// <para>The user VPC access configuration of the agent. If this field is not configured, user VPC access is allowed on the agent side, but it is still restricted by the workspace.</para>
                /// </summary>
                [NameInMap("accessVpc")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataNetworkAccessVpc AccessVpc { get; set; }
                public class CreateCustomAgentResponseBodyDataNetworkAccessVpc : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether access to the user VPC configured for the workspace is allowed on the agent side. The actual access is still restricted by the workspace.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

            }

            /// <summary>
            /// <para>The latest submitted list of OSS directory mounts.</para>
            /// </summary>
            [NameInMap("ossMounts")]
            [Validation(Required=false)]
            public List<CreateCustomAgentResponseBodyDataOssMounts> OssMounts { get; set; }
            public class CreateCustomAgentResponseBodyDataOssMounts : TeaModel {
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
                /// <para>The prefix of the object directory in the mounted bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>datasets/train</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. A value of true indicates that the mount is read-only. A value of false indicates that the mount is readable and writable.</para>
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
            public List<CreateCustomAgentResponseBodyDataProtocol> Protocol { get; set; }
            public class CreateCustomAgentResponseBodyDataProtocol : TeaModel {
                /// <summary>
                /// <para>The request header configurations for the current protocol. The key is the header name and the value is a string.</para>
                /// </summary>
                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                /// <summary>
                /// <para>The list of API paths corresponding to the current protocol.</para>
                /// </summary>
                [NameInMap("paths")]
                [Validation(Required=false)]
                public List<CreateCustomAgentResponseBodyDataProtocolPaths> Paths { get; set; }
                public class CreateCustomAgentResponseBodyDataProtocolPaths : TeaModel {
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
                /// <para>The invocation protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>agui: AG-UI protocol.</description></item>
                /// <item><description>openai-chat-completion: OpenAI Chat Completions compatible protocol.</description></item>
                /// <item><description>custom: Custom protocol.</description></item>
                /// </list>
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
            /// <para>The runtime configurations of the latest commit, including compute specifications, session policy, and elastic policy.</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataRuntime Runtime { get; set; }
            public class CreateCustomAgentResponseBodyDataRuntime : TeaModel {
                /// <summary>
                /// <para>The compute resource configuration for the agent runtime instance.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("compute")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataRuntimeCompute Compute { get; set; }
                public class CreateCustomAgentResponseBodyDataRuntimeCompute : TeaModel {
                    /// <summary>
                    /// <para>The compute specification. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>INTERACTIVE: 1 vCPU and 2 GiB of memory.</description></item>
                    /// <item><description>STANDARD: 2 vCPUs and 4 GiB of memory.</description></item>
                    /// <item><description>HEAVY: 4 vCPUs and 8 GiB of memory.</description></item>
                    /// </list>
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
                /// <para>The elastic policy configurations for the agent.</para>
                /// </summary>
                [NameInMap("hpa")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataRuntimeHpa Hpa { get; set; }
                public class CreateCustomAgentResponseBodyDataRuntimeHpa : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether elastic scaling is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Enabled.</description></item>
                    /// <item><description>false: Disabled.</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent sessions configured for a single runtime instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("maxConcurrentSessionsPerSandbox")]
                    [Validation(Required=false)]
                    public int? MaxConcurrentSessionsPerSandbox { get; set; }

                    /// <summary>
                    /// <para>The maximum number of runtime instances configured.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxSandboxCount")]
                    [Validation(Required=false)]
                    public int? MaxSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The minimum number of runtime instances configured.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minSandboxCount")]
                    [Validation(Required=false)]
                    public int? MinSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The maximum idle time configured for a session, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>600</para>
                    /// </summary>
                    [NameInMap("sessionTtlSeconds")]
                    [Validation(Required=false)]
                    public int? SessionTtlSeconds { get; set; }

                }

                /// <summary>
                /// <para>The session policy configurations for the agent.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sessionPolicy")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataRuntimeSessionPolicy SessionPolicy { get; set; }
                public class CreateCustomAgentResponseBodyDataRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The name of the HTTP request header used by the session policy. This parameter applies to ISOLATED_HEADER_FIELD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>X-Session-Id</para>
                    /// </summary>
                    [NameInMap("headerName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>The session policy type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>AFFINITY: Session affinity.</description></item>
                    /// <item><description>ISOLATED_HEADER_FIELD: Associates sessions by using the request header specified by headerName.</description></item>
                    /// <item><description>ISOLATED_COOKIE: Not recommended.
                    /// Note: The compatibility value DISABLED in a request is returned as AFFINITY.</description></item>
                    /// </list>
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
            /// <para>The instance counts grouped by runtime instance phase. Keys include PENDING (creating or initializing), RUNNING (running), HIBERNATING (hibernating), HIBERNATED (hibernated), RESUMING (resuming), TERMINATING (terminating), and FAILED (failed). Only phases that actually occur are returned. Missing keys are treated as 0.</para>
            /// </summary>
            [NameInMap("sandboxPhaseCounts")]
            [Validation(Required=false)]
            public Dictionary<string, long?> SandboxPhaseCounts { get; set; }

            /// <summary>
            /// <para>The overall status of the agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: The agent is being created.</description></item>
            /// <item><description>Running: The agent is running.</description></item>
            /// <item><description>Failed: The agent failed.</description></item>
            /// <item><description>Updating: The agent is being updated.</description></item>
            /// <item><description>Deleting: The agent is being deleted.</description></item>
            /// <item><description>Deleted: The agent is deleted.
            /// To query the execution progress of the latest configuration, check latestVersionStatus.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the agent was last updated. The time is in ISO 8601 format. A trailing Z indicates the UTC time zone. Fractional seconds may be included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-10T06:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the custom agent belongs.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The description of the processing result for the request. A value of success indicates that the request was processed successfully.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can use this ID to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550E8400-E29B-41D4-A716-446655440000</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was processed successfully. A value of true indicates that the request was processed successfully. Note that a successful creation, update, or deletion does not mean that the background operation is complete.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
