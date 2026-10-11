// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateCustomAgentRequest : TeaModel {
        /// <summary>
        /// <para>The JSON configuration of the custom agent. You must specify name, artifact, roleArn, and runtime.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateCustomAgentRequestBody Body { get; set; }
        public class CreateCustomAgentRequestBody : TeaModel {
            /// <summary>
            /// <para>The list of additional AgenticFS mounts. The total number of AgenticFS and OSS mounts cannot exceed 10. If you omit this parameter or pass an empty array [] during creation, no additional mounts are configured. If you omit this parameter during an update, the original value is retained. If you pass an empty array [], the list is cleared. You cannot pass null.</para>
            /// </summary>
            [NameInMap("agenticFsMounts")]
            [Validation(Required=false)]
            public List<CreateCustomAgentRequestBodyAgenticFsMounts> AgenticFsMounts { get; set; }
            public class CreateCustomAgentRequestBodyAgenticFsMounts : TeaModel {
                /// <summary>
                /// <para>The subdirectory under /mnt/agenticfs/ in the container. This parameter is required for each mount item. Mount targets must not be duplicated or overlap in a parent-child relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs/data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The existing non-empty relative directory under the access point. This parameter is required for each mount item. Root directories, absolute paths, and parent directory traversals are not allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspace/data</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. A value of true indicates read-only, and a value of false indicates read and write. If this parameter is omitted, the default value is false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The domain name of the access point. This parameter is required for each mount item. Use the DomainName value from the NAS ListAccessPoints response. Do not include the protocol, port, or path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The deployment artifact configuration. Currently, only ACR container images are supported. Specify container and the service listening port in port, and omit code.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("artifact")]
            [Validation(Required=false)]
            public CreateCustomAgentRequestBodyArtifact Artifact { get; set; }
            public class CreateCustomAgentRequestBodyArtifact : TeaModel {
                /// <summary>
                /// <para>The code package deployment configuration. This feature is currently not supported. Omit this parameter and use artifact.container.</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public CreateCustomAgentRequestBodyArtifactCode Code { get; set; }
                public class CreateCustomAgentRequestBodyArtifactCode : TeaModel {
                    /// <summary>
                    /// <para>The startup entry point of the code package. Code package deployment is currently not supported. Omit this parameter.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python app.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The language runtime identifier of the code package. Code package deployment is currently not supported. Omit this parameter.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python</para>
                    /// </summary>
                    [NameInMap("languageRuntime")]
                    [Validation(Required=false)]
                    public string LanguageRuntime { get; set; }

                    /// <summary>
                    /// <para>The source URI of the code package. Code package deployment is currently not supported. Omit this parameter.</para>
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
                /// <para>The ACR container image configuration. You must specify type, instanceId, namespace, repo, and tag. Do not configure code at the same time.</para>
                /// </summary>
                [NameInMap("container")]
                [Validation(Required=false)]
                public CreateCustomAgentRequestBodyArtifactContainer Container { get; set; }
                public class CreateCustomAgentRequestBodyArtifactContainer : TeaModel {
                    /// <summary>
                    /// <para>The optional image startup command. If specified, it must be a non-empty string. If omitted, the default startup method of the image is used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python app.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The ID of the ACR instance to which the image repository belongs. This parameter cannot be empty.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cri-a1b2c3d4e5f6</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The namespace to which the ACR image repository belongs. This parameter cannot be empty.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-agent</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The name of the image repository in the ACR namespace. This parameter cannot be empty.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chat-agent</para>
                    /// </summary>
                    [NameInMap("repo")]
                    [Validation(Required=false)]
                    public string Repo { get; set; }

                    /// <summary>
                    /// <para>The image tag used for deployment. This parameter cannot be empty. When updating the tag, you must also specify artifact.port and other required image fields.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1.0.0</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The source type of the image. Currently, only acr is supported, which indicates Alibaba Cloud Container Registry (ACR).</para>
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
                /// <para>The TCP port on which the agent service listens. Valid values: 1 to 65535.</para>
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
            /// <para>The description of the agent purpose. The maximum length is 1,024 characters after leading and trailing whitespace is removed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom agent that provides conversation services</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The environment variable configuration passed to the agent runtime process.</para>
            /// </summary>
            [NameInMap("environment")]
            [Validation(Required=false)]
            public CreateCustomAgentRequestBodyEnvironment Environment { get; set; }
            public class CreateCustomAgentRequestBodyEnvironment : TeaModel {
                /// <summary>
                /// <para>The list of environment variables. Each item includes a name and a value. The entire list is replaced during an update.</para>
                /// </summary>
                [NameInMap("variables")]
                [Validation(Required=false)]
                public List<CreateCustomAgentRequestBodyEnvironmentVariables> Variables { get; set; }
                public class CreateCustomAgentRequestBodyEnvironmentVariables : TeaModel {
                    /// <summary>
                    /// <para>The name of the environment variable. This parameter cannot be empty and must be unique within the current environment variable list.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LOG_LEVEL</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value of the environment variable. It must be a string. Empty strings are allowed.</para>
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
            /// <para>The optional HTTP health check configuration. If this object is provided, you must specify port. Unspecified items use default values. If omitted during creation, no health check is configured. If this top-level field is omitted during an update, the original configuration is retained. If null is passed, the health check is removed.</para>
            /// </summary>
            [NameInMap("healthCheck")]
            [Validation(Required=false)]
            public CreateCustomAgentRequestBodyHealthCheck HealthCheck { get; set; }
            public class CreateCustomAgentRequestBodyHealthCheck : TeaModel {
                /// <summary>
                /// <para>This parameter does not take effect. Omit this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("healthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The interval between two health checks, in seconds. It must be a positive integer. If omitted, the default value is 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("intervalSeconds")]
                [Validation(Required=false)]
                public int? IntervalSeconds { get; set; }

                /// <summary>
                /// <para>The HTTP health check path. It must start with a forward slash (/). If omitted, the default value is /healthz.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/healthz</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The port accessed for health checks. This parameter is required when configuring health checks. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The timeout period for a single health check, in seconds. It must be a positive integer and less than intervalSeconds. If omitted, the default value is 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("timeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The number of consecutive health check failures required to mark the target as unhealthy. It must be a positive integer. If omitted, the default value is 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("unhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>The agent log delivery configuration. You can specify the Simple Log Service project and Logstore. After a successful creation or update, verify that logs are delivered properly.</para>
            /// </summary>
            [NameInMap("logging")]
            [Validation(Required=false)]
            public CreateCustomAgentRequestBodyLogging Logging { get; set; }
            public class CreateCustomAgentRequestBodyLogging : TeaModel {
                /// <summary>
                /// <para>The Simple Log Service log delivery destination. When configuring this object, neither project nor logstore can be empty.</para>
                /// </summary>
                [NameInMap("sls")]
                [Validation(Required=false)]
                public CreateCustomAgentRequestBodyLoggingSls Sls { get; set; }
                public class CreateCustomAgentRequestBodyLoggingSls : TeaModel {
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
            /// <para>The name of the custom agent. The length must be 1 to 128 characters after leading and trailing whitespace is removed. The name must be unique within the same workspace.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-custom-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network access configuration of the agent. If this object is provided, omitted access items are treated as allowed. The actual accessible range is still limited by the workspace network configuration. To retain the original restrictions during an update, specify both accessInternet and accessVpc.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public CreateCustomAgentRequestBodyNetwork Network { get; set; }
            public class CreateCustomAgentRequestBodyNetwork : TeaModel {
                /// <summary>
                /// <para>The Internet access configuration. If this access item is omitted, Internet access is not restricted on the agent side. However, the workspace must still allow Internet access.</para>
                /// </summary>
                [NameInMap("accessInternet")]
                [Validation(Required=false)]
                public CreateCustomAgentRequestBodyNetworkAccessInternet AccessInternet { get; set; }
                public class CreateCustomAgentRequestBodyNetworkAccessInternet : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow the agent to access the Internet. A Boolean value must be provided when configuring accessInternet. For this setting to take effect, the workspace must also allow Internet access.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

                /// <summary>
                /// <para>The user VPC access configuration. If this access item is omitted, VPC access is not restricted on the agent side. However, the workspace must still be configured to allow access to the user VPC.</para>
                /// </summary>
                [NameInMap("accessVpc")]
                [Validation(Required=false)]
                public CreateCustomAgentRequestBodyNetworkAccessVpc AccessVpc { get; set; }
                public class CreateCustomAgentRequestBodyNetworkAccessVpc : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow the agent to access the user VPC configured for the workspace. A Boolean value must be provided when configuring accessVpc. For this setting to take effect, the workspace must also allow VPC access.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of OSS mounts. The total number of OSS and AgenticFS mounts cannot exceed 10. You must specify bucketName, path, and mountPath for each item. Mount targets must not be duplicated or overlap. The entire list is replaced during an update. Pass an empty array [] to clear the list.</para>
            /// </summary>
            [NameInMap("ossMounts")]
            [Validation(Required=false)]
            public List<CreateCustomAgentRequestBodyOssMounts> OssMounts { get; set; }
            public class CreateCustomAgentRequestBodyOssMounts : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket. This parameter is required for each mount item. The name must be 3 to 63 characters in length and can contain only lowercase letters, digits, and hyphens. It cannot start or end with a hyphen.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-data</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The subdirectory under /mnt/oss/ in the container. This parameter is required for each mount item. Mount targets must not be duplicated or overlap in a parent-child relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/oss/train</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The non-empty object directory prefix in the bucket, such as datasets/train. Leading and trailing forward slashes (/) are removed. Root directories are not supported. Do not use parent directory traversals.</para>
                /// 
                /// <b>Example:</b>
                /// <para>datasets/train</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. A value of true indicates read-only, and a value of false indicates read and write. If this parameter is omitted, the default value is false.</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            /// <summary>
            /// <para>The list of invocation protocols supported by the agent. Each item includes the protocol type and optional paths and request headers. The entire list is replaced during an update.</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public List<CreateCustomAgentRequestBodyProtocol> Protocol { get; set; }
            public class CreateCustomAgentRequestBodyProtocol : TeaModel {
                /// <summary>
                /// <para>The request header configuration for the current protocol. The key is a non-empty request header name, and the value must be a string.</para>
                /// </summary>
                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                /// <summary>
                /// <para>The list of API paths corresponding to the current protocol.</para>
                /// </summary>
                [NameInMap("paths")]
                [Validation(Required=false)]
                public List<CreateCustomAgentRequestBodyProtocolPaths> Paths { get; set; }
                public class CreateCustomAgentRequestBodyProtocolPaths : TeaModel {
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
                    /// <para>The non-empty API path corresponding to the current protocol.</para>
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
            /// <para>The ARN of the RAM role used when the agent accesses user cloud resources. The role must have permissions to access the cloud resources.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1234567890123456:role/agentcore-runtime-role</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The runtime configuration, including compute specifications, session policies, and an optional elastic policy. Both compute and sessionPolicy must be specified.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public CreateCustomAgentRequestBodyRuntime Runtime { get; set; }
            public class CreateCustomAgentRequestBodyRuntime : TeaModel {
                /// <summary>
                /// <para>The compute resource configuration for the agent runtime instance.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("compute")]
                [Validation(Required=false)]
                public CreateCustomAgentRequestBodyRuntimeCompute Compute { get; set; }
                public class CreateCustomAgentRequestBodyRuntimeCompute : TeaModel {
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
                /// <para>The optional elastic policy. When runtime is provided, if hpa or its fields are omitted, the default values are used: enabled is false, the minimum number of instances is 1, the maximum number of instances is 10, the maximum number of concurrent sessions per instance is 100, and the session idle timeout is 600 seconds. To retain the original policy during an update, provide the complete hpa configuration.</para>
                /// </summary>
                [NameInMap("hpa")]
                [Validation(Required=false)]
                public CreateCustomAgentRequestBodyRuntimeHpa Hpa { get; set; }
                public class CreateCustomAgentRequestBodyRuntimeHpa : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable elastic scaling. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Enabled.</description></item>
                    /// <item><description>false: Disabled.
                    /// Default value: false.</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent sessions for a single runtime instance. Valid values: 1 to 100. Default value: 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("maxConcurrentSessionsPerSandbox")]
                    [Validation(Required=false)]
                    public int? MaxConcurrentSessionsPerSandbox { get; set; }

                    /// <summary>
                    /// <para>The maximum number of runtime instances. Valid values: 1 to 100. The value cannot be less than minSandboxCount. Default value: 10.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxSandboxCount")]
                    [Validation(Required=false)]
                    public int? MaxSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The minimum number of runtime instances. Valid values: 1 to 100. The value cannot be greater than maxSandboxCount. Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minSandboxCount")]
                    [Validation(Required=false)]
                    public int? MinSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The session idle timeout in seconds. Valid values: 60 to 86400. Default value: 600.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>600</para>
                    /// </summary>
                    [NameInMap("sessionTtlSeconds")]
                    [Validation(Required=false)]
                    public int? SessionTtlSeconds { get; set; }

                }

                /// <summary>
                /// <para>The session policy configuration, which is used to set the session association method for requests.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sessionPolicy")]
                [Validation(Required=false)]
                public CreateCustomAgentRequestBodyRuntimeSessionPolicy SessionPolicy { get; set; }
                public class CreateCustomAgentRequestBodyRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The name of the HTTP request header used by the session policy. This parameter is required when type is set to ISOLATED_HEADER_FIELD and must be a valid HTTP request header name. Omit this parameter for other policies.</para>
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
                    /// <item><description>ISOLATED_COOKIE: Not recommended.</description></item>
                    /// <item><description>DISABLED: A compatibility option. The response returns AFFINITY.</description></item>
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

        }

        /// <summary>
        /// <para>Idempotency is not currently guaranteed. Do not rely on this parameter to prevent duplicate requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-agent-request-20261010-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
