// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateCustomAgentRequest : TeaModel {
        /// <summary>
        /// <para>The update configuration for the custom agent. Specify at least one top-level field. Omitted top-level fields retain their original values. When providing a configuration object, specify its required subfields and include any optional configurations that you want to retain. Arrays are replaced as a whole.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateCustomAgentRequestBody Body { get; set; }
        public class UpdateCustomAgentRequestBody : TeaModel {
            /// <summary>
            /// <para>The list of additional AgenticFS mounts. The total number of AgenticFS and OSS mounts cannot exceed 10. During creation, omitting this field or passing an empty array [] indicates no additional mounts. During an update, omitting this field retains the original value, and passing an empty array [] clears the list. You cannot pass null.</para>
            /// </summary>
            [NameInMap("agenticFsMounts")]
            [Validation(Required=false)]
            public List<UpdateCustomAgentRequestBodyAgenticFsMounts> AgenticFsMounts { get; set; }
            public class UpdateCustomAgentRequestBodyAgenticFsMounts : TeaModel {
                /// <summary>
                /// <para>The subdirectory under /mnt/agenticfs/ in the container. This field is required for each mount item. Mount targets must not be duplicated or form parent-child overrides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs/data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The existing non-empty relative directory under the access point. This field is required for each mount item. Root directories, absolute paths, and parent directory traversals are not allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspace/data</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. A value of true indicates read-only, and false indicates read and write. If omitted, the default value is false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The domain name of the access point. This field is required for each mount item. Use the DomainName value from the response of the NAS ListAccessPoints operation. Do not include the protocol, port, or path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The deployment artifact configuration. Currently, only ACR container images are supported. Specify the container field and the service listening port field. Omit the code field. During an update, you must specify the port field and all required fields of the container object.</para>
            /// </summary>
            [NameInMap("artifact")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyArtifact Artifact { get; set; }
            public class UpdateCustomAgentRequestBodyArtifact : TeaModel {
                /// <summary>
                /// <para>The code package deployment configuration. This is currently not supported. Omit this field and use artifact.container instead.</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyArtifactCode Code { get; set; }
                public class UpdateCustomAgentRequestBodyArtifactCode : TeaModel {
                    /// <summary>
                    /// <para>The startup entry point for the code package. Code package deployment is currently not supported. Omit this field.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python app.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The language runtime identifier for the code package. Code package deployment is currently not supported. Omit this field.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python</para>
                    /// </summary>
                    [NameInMap("languageRuntime")]
                    [Validation(Required=false)]
                    public string LanguageRuntime { get; set; }

                    /// <summary>
                    /// <para>The source URI of the code package. Code package deployment is currently not supported. Omit this field.</para>
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
                /// <para>The ACR container image configuration. You must specify the type, instanceId, namespace, repo, and tag fields. Do not configure the code field at the same time.</para>
                /// </summary>
                [NameInMap("container")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyArtifactContainer Container { get; set; }
                public class UpdateCustomAgentRequestBodyArtifactContainer : TeaModel {
                    /// <summary>
                    /// <para>The optional executable program and startup parameters. If specified, this must be a non-empty string. When updating the artifact, omitting this field uses the default startup method of the image. To retain the original custom startup command, provide this field as well.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python app.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The ID of the ACR instance to which the image repository belongs. This field cannot be empty.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cri-a1b2c3d4e5f6</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The namespace to which the ACR image repository belongs. This field cannot be empty.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-agent</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The name of the image repository in the ACR namespace. This field cannot be empty.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chat-agent</para>
                    /// </summary>
                    [NameInMap("repo")]
                    [Validation(Required=false)]
                    public string Repo { get; set; }

                    /// <summary>
                    /// <para>The image tag used for deployment. This field cannot be empty. When updating the tag, you must also provide artifact.port and other required image fields.</para>
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
                /// <para>The TCP port listened by the agent service. Valid values: 1 to 65535.</para>
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
            /// <para>The description of the agent purpose. The maximum length is 1,024 characters after leading and trailing whitespaces are removed. If omitted, the original value is retained. Pass null to clear the description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom agent that provides conversation services</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The environment variable configuration for the agent process. Omitting this top-level field retains the original value. Providing this object but omitting the variables field clears the custom environment variables. To retain the variables, provide the complete list.</para>
            /// </summary>
            [NameInMap("environment")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyEnvironment Environment { get; set; }
            public class UpdateCustomAgentRequestBodyEnvironment : TeaModel {
                /// <summary>
                /// <para>The list of environment variables. Each item includes a name and a value. This list is replaced as a whole during an update.</para>
                /// </summary>
                [NameInMap("variables")]
                [Validation(Required=false)]
                public List<UpdateCustomAgentRequestBodyEnvironmentVariables> Variables { get; set; }
                public class UpdateCustomAgentRequestBodyEnvironmentVariables : TeaModel {
                    /// <summary>
                    /// <para>The name of the environment variable. This field cannot be empty and must be unique within the current environment variable list.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LOG_LEVEL</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value of the environment variable. This must be a string. Empty strings are allowed.</para>
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
            /// <para>The optional HTTP health check configuration. When providing this object, you must specify the port field. Other unspecified items use default values. Omitting this field during creation indicates no configuration. During an update, omitting this top-level field retains the original configuration, and passing null removes the health check.</para>
            /// </summary>
            [NameInMap("healthCheck")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyHealthCheck HealthCheck { get; set; }
            public class UpdateCustomAgentRequestBodyHealthCheck : TeaModel {
                /// <summary>
                /// <para>This parameter currently does not take effect. Omit this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("healthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The interval between two health checks, in seconds. This must be a positive integer. If omitted, the default value is 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("intervalSeconds")]
                [Validation(Required=false)]
                public int? IntervalSeconds { get; set; }

                /// <summary>
                /// <para>The HTTP health check path. This must start with a forward slash (/). If omitted, the default value is /healthz.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/healthz</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The port accessed for health checks. This field is required when configuring a health check. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The timeout period for a single health check, in seconds. This must be a positive integer and less than intervalSeconds. If omitted, the default value is 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("timeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The number of consecutive health check failures before the instance is considered unhealthy. This must be a positive integer. If omitted, the default value is 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("unhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>The log delivery configuration for the agent. You can specify the Simple Log Service project and logstore. After a successful creation or update, verify whether logs are delivered properly.</para>
            /// </summary>
            [NameInMap("logging")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyLogging Logging { get; set; }
            public class UpdateCustomAgentRequestBodyLogging : TeaModel {
                /// <summary>
                /// <para>The Simple Log Service log delivery destination. When updating this object, you must provide both project and logstore, and neither can be empty.</para>
                /// </summary>
                [NameInMap("sls")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyLoggingSls Sls { get; set; }
                public class UpdateCustomAgentRequestBodyLoggingSls : TeaModel {
                    /// <summary>
                    /// <para>The name of the Simple Log Service logstore that receives agent logs.</para>
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
            /// <para>The name of the custom agent. The length is 1 to 128 characters after leading and trailing whitespaces are removed. The name must be unique within the same workspace. If omitted, the original value is retained. You cannot pass null or an empty name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-custom-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network access configuration for the agent. When providing this object, omitted access items are treated as allowed. The actual accessible scope is still subject to the workspace network configuration. To retain the original restrictions during an update, specify both accessInternet and accessVpc.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyNetwork Network { get; set; }
            public class UpdateCustomAgentRequestBodyNetwork : TeaModel {
                /// <summary>
                /// <para>The Internet access configuration. If this access item is omitted, Internet access is not restricted on the agent side. However, the workspace must still allow Internet access.</para>
                /// </summary>
                [NameInMap("accessInternet")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyNetworkAccessInternet AccessInternet { get; set; }
                public class UpdateCustomAgentRequestBodyNetworkAccessInternet : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow the agent to access the Internet. A Boolean value is required when configuring accessInternet. For this to take effect, the workspace must also allow Internet access.</para>
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
                public UpdateCustomAgentRequestBodyNetworkAccessVpc AccessVpc { get; set; }
                public class UpdateCustomAgentRequestBodyNetworkAccessVpc : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow the agent to access the user VPC configured for the workspace. A Boolean value is required when configuring accessVpc. For this to take effect, the workspace must also allow VPC access.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

            }

            /// <summary>
            /// <para>The observability configuration for high-code agents.</para>
            /// </summary>
            [NameInMap("observability")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyObservability Observability { get; set; }
            public class UpdateCustomAgentRequestBodyObservability : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable agent observability. Default value: true. If set to false, the platform Python probe is not loaded at runtime, and you must collect observability data yourself.</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>The OSS mount list. A maximum of 10 items in total with agenticFsMounts. Each item must include bucketName, path, and mountPath. Mount targets must not be duplicated or overlap. During an update, this list is replaced entirely. Pass an empty array to clear all mounts.</para>
            /// </summary>
            [NameInMap("ossMounts")]
            [Validation(Required=false)]
            public List<UpdateCustomAgentRequestBodyOssMounts> OssMounts { get; set; }
            public class UpdateCustomAgentRequestBodyOssMounts : TeaModel {
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
                /// <para>The subdirectory under /mnt/oss/ in the container. This parameter is required for each mount item. Mount targets must not be duplicated or form parent-child overlaps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/oss/train</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The non-empty object directory prefix in the bucket, such as datasets/train. Leading and trailing slashes are removed. The root directory is not supported. Do not use parent directory traversal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>datasets/train</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. A value of true indicates read-only, and false indicates read and write. If omitted, the default value is false.</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            /// <summary>
            /// <para>The list of invocation protocols supported by the agent. Each item includes the protocol type and optional paths and request headers. During an update, this list is replaced entirely.</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public List<UpdateCustomAgentRequestBodyProtocol> Protocol { get; set; }
            public class UpdateCustomAgentRequestBodyProtocol : TeaModel {
                /// <summary>
                /// <para>The request header configuration for the current protocol. The key is a non-empty request header name, and the value must be a string.</para>
                /// </summary>
                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                /// <summary>
                /// <para>The list of API paths for the current protocol.</para>
                /// </summary>
                [NameInMap("paths")]
                [Validation(Required=false)]
                public List<UpdateCustomAgentRequestBodyProtocolPaths> Paths { get; set; }
                public class UpdateCustomAgentRequestBodyProtocolPaths : TeaModel {
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
                    /// <para>The non-empty API path for the current protocol.</para>
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
            /// <para>The ARN of the RAM role used by the agent to access user cloud resources. The role must have permissions to access the cloud resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1234567890123456:role/agentcore-runtime-role</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The runtime configuration. When this object is provided, compute and sessionPolicy must be provided together. To retain the original elastic policy, provide the complete hpa configuration. Omitting the top-level runtime field retains the original configuration.</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyRuntime Runtime { get; set; }
            public class UpdateCustomAgentRequestBodyRuntime : TeaModel {
                /// <summary>
                /// <para>The compute resource configuration for the agent runtime instance.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("compute")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyRuntimeCompute Compute { get; set; }
                public class UpdateCustomAgentRequestBodyRuntimeCompute : TeaModel {
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
                /// <para>The optional elastic policy. When runtime is provided, if hpa or its fields are omitted, default values are used: enabled is false, the minimum number of instances is 1, the maximum number of instances is 10, the maximum number of concurrent sessions per instance is 100, and the session idle timeout is 600 seconds. To retain the original policy during an update, provide the complete hpa configuration.</para>
                /// </summary>
                [NameInMap("hpa")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyRuntimeHpa Hpa { get; set; }
                public class UpdateCustomAgentRequestBodyRuntimeHpa : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable elastic scaling. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Enabled.</description></item>
                    /// <item><description>false: Disabled.
                    /// When runtime is provided, if this field is omitted, the default value is false.</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent sessions for a single runtime instance. Valid values: 1 to 100. When runtime is provided, if this field is omitted, the default value is 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("maxConcurrentSessionsPerSandbox")]
                    [Validation(Required=false)]
                    public int? MaxConcurrentSessionsPerSandbox { get; set; }

                    /// <summary>
                    /// <para>The maximum number of runtime instances. Valid values: 1 to 100. The value cannot be less than minSandboxCount. When runtime is provided, if this field is omitted, the default value is 10.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxSandboxCount")]
                    [Validation(Required=false)]
                    public int? MaxSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The minimum number of runtime instances. Valid values: 1 to 100. The value cannot be greater than maxSandboxCount. When runtime is provided, if this field is omitted, the default value is 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minSandboxCount")]
                    [Validation(Required=false)]
                    public int? MinSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The session idle timeout in seconds. Valid values: 60 to 86400. When runtime is provided, if this field is omitted, the default value is 600.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>600</para>
                    /// </summary>
                    [NameInMap("sessionTtlSeconds")]
                    [Validation(Required=false)]
                    public int? SessionTtlSeconds { get; set; }

                }

                /// <summary>
                /// <para>The session policy configuration used to set the session association method for requests.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sessionPolicy")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyRuntimeSessionPolicy SessionPolicy { get; set; }
                public class UpdateCustomAgentRequestBodyRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The name of the HTTP request header used by the session policy. This parameter is required when type is ISOLATED_HEADER_FIELD and must be a valid HTTP request header name. Omit this parameter for other policies.</para>
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
                    /// <item><description>ISOLATED_HEADER_FIELD: Associates sessions by using the request header specified in headerName.</description></item>
                    /// <item><description>ISOLATED_COOKIE: Cookie-based session option. Not recommended.</description></item>
                    /// <item><description>DISABLED: Compatibility option. The response returns AFFINITY.</description></item>
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
            /// <para>If not specified during an update, the original value is retained. Explicitly set to true or false. The system does not automatically default to false. New API contracts reject null and invalid types. Existing compatibility endpoints are processed according to migration conventions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("useImageCache")]
            [Validation(Required=false)]
            public bool? UseImageCache { get; set; }

        }

        /// <summary>
        /// <para>Idempotence is not currently guaranteed. Do not rely on this parameter to prevent duplicate requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-agent-request-20261010-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
