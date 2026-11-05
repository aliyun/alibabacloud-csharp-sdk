// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateCustomAgentRequest : TeaModel {
        /// <summary>
        /// <para>The JSON configuration of the custom code or image agent. You must specify name, artifact, roleArn, and runtime.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateCustomAgentRequestBody Body { get; set; }
        public class CreateCustomAgentRequestBody : TeaModel {
            /// <summary>
            /// <para>The inbound access method.</para>
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
            /// <para>The NAS storage mount configuration. Currently, only the AgenticFS type is supported, which is used to mount file directories in access points to agent runtime instances. This is a list of AgenticFS directory mounts. The total number of items in this list and ossMounts cannot exceed 10. If omitted or set to [] during creation, no mounts are configured. If omitted during an update, the existing configuration is retained. If set to [], the mounts are cleared. Null is not accepted.</para>
            /// </summary>
            [NameInMap("agenticFsMounts")]
            [Validation(Required=false)]
            public List<CreateCustomAgentRequestBodyAgenticFsMounts> AgenticFsMounts { get; set; }
            public class CreateCustomAgentRequestBodyAgenticFsMounts : TeaModel {
                /// <summary>
                /// <para>The absolute mount path in the container, such as /data/train. Mount targets cannot be duplicated or form parent-child overrides, and must avoid platform reserved directories.</para>
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
                /// <para>Specifies whether the mount is read-only. A value of true indicates read-only, and a value of false indicates read and write. If omitted, the default value is false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The access point domain name. This parameter is required for each mount item. Use the DomainName from the NAS ListAccessPoints response. Do not include protocols, ports, or paths.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The deployment artifact configuration. You must specify the service listening port in port and select either code or container as the deployment method.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("artifact")]
            [Validation(Required=false)]
            public CreateCustomAgentRequestBodyArtifact Artifact { get; set; }
            public class CreateCustomAgentRequestBodyArtifact : TeaModel {
                /// <summary>
                /// <para>The code package deployment configuration. This parameter is mutually exclusive with container. You must specify sourceUri, languageRuntime, and entrypoint, and set artifact.port. ZIP and TAR.GZ formats are supported. Dependencies must be provided by the caller in the package.</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public CreateCustomAgentRequestBodyArtifactCode Code { get; set; }
                public class CreateCustomAgentRequestBodyArtifactCode : TeaModel {
                    /// <summary>
                    /// <para>The startup command for the code package. This parameter is required in code package mode. The working directory is the root directory of the decompressed code, /code, such as python main.py. Quotes and escapes are supported. Environment variables, pipelines, and logical operations are not automatically expanded. For complex commands, use a script in the package.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python main.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The code runtime environment identifier, such as python3.12. When creating or switching environments, use the identifier returned by ListAgentCodeRuntimes. The identifier is verified by the current version catalog and is not a fixed enumeration.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python3.12</para>
                    /// </summary>
                    [NameInMap("languageRuntime")]
                    [Validation(Required=false)]
                    public string LanguageRuntime { get; set; }

                    /// <summary>
                    /// <para>The source URL of the code package. Supports oss:// URLs or HTTPS object URLs of standard OSS public domain names, including OSS signed URLs. Arbitrary external sites, custom domain names, or additional authentication request headers are not supported. After a local upload, use the sourceUri returned by GetAgentCodePackageUploadUrl. The URL is re-verified and transferred during creation or update. After being saved, a fixed oss:// URL of the platform is returned. You can reuse this fixed URL for regular updates.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://my-agent-bucket/packages/main.zip</para>
                    /// </summary>
                    [NameInMap("sourceUri")]
                    [Validation(Required=false)]
                    public string SourceUri { get; set; }

                }

                /// <summary>
                /// <para>The container image deployment configuration. This parameter is mutually exclusive with code. For ACR sources, specify type=acr, instanceId, namespace, repo, and tag. For custom sources, specify type=custom and submit the complete customImage.</para>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>cri-a1b2c3d4e5f6</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The namespace to which the ACR image repository belongs. This parameter cannot be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-agent</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The name of the image repository in the ACR namespace. This parameter cannot be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chat-agent</para>
                    /// </summary>
                    [NameInMap("repo")]
                    [Validation(Required=false)]
                    public string Repo { get; set; }

                    /// <summary>
                    /// <para>The image tag used for deployment. This parameter cannot be empty. When updating the tag, you must also specify artifact.port and other required image fields.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1.0.0</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The image source type. A value of acr indicates an ACR image, and a value of custom indicates a custom image source. For the corresponding source configurations, refer to the descriptions of artifact.container and customImage.</para>
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
            /// <para>The custom image source. This parameter is required when artifact.container.type is set to custom, and omitted for other sources.</para>
            /// </summary>
            [NameInMap("customImage")]
            [Validation(Required=false)]
            public CreateCustomAgentRequestBodyCustomImage CustomImage { get; set; }
            public class CreateCustomAgentRequestBodyCustomImage : TeaModel {
                /// <summary>
                /// <para>The custom image address. This parameter is required and verified by the backend when customImage is submitted. Specify the complete registry[:port]/repository:tag or registry[:port]/repository@sha256:digest. Multi-level paths are supported. Do not include protocols or user information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.example.com/team/agent:v1</para>
                /// </summary>
                [NameInMap("image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The repository password or token for this submission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-registry-token</para>
                /// </summary>
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The independent pull network configuration. This parameter is required and verified by the backend when customImage is submitted. For Internet access, only pass type=public.</para>
                /// </summary>
                [NameInMap("pullNetwork")]
                [Validation(Required=false)]
                public CreateCustomAgentRequestBodyCustomImagePullNetwork PullNetwork { get; set; }
                public class CreateCustomAgentRequestBodyCustomImagePullNetwork : TeaModel {
                    /// <summary>
                    /// <para>The security group ID. This parameter is required when type is set to vpc, and must belong to the selected VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-example</para>
                    /// </summary>
                    [NameInMap("securityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The pull network type. This parameter is required and verified by the backend when pullNetwork is submitted. The default value for new creations is public, which is independent of the agent runtime network.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>public</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The security group ID. This parameter is required when type is set to vpc, and must belong to the selected VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-example</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The VPC ID. This parameter is required when type is set to vpc. The associated account and region are verified by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-example</para>
                    /// </summary>
                    [NameInMap("vpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether to skip HTTPS certificate verification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("skipTlsVerify")]
                [Validation(Required=false)]
                public bool? SkipTlsVerify { get; set; }

                /// <summary>
                /// <para>The repository username for this submission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reader</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The description of the agent purpose. The maximum length is 1024 characters after leading and trailing whitespaces are removed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom agent that provides conversation services</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The environment variable configurations passed to the agent runtime process.</para>
            /// </summary>
            [NameInMap("environment")]
            [Validation(Required=false)]
            public CreateCustomAgentRequestBodyEnvironment Environment { get; set; }
            public class CreateCustomAgentRequestBodyEnvironment : TeaModel {
                /// <summary>
                /// <para>The list of environment variables. Each item contains a name and a value. The entire list is replaced during an update.</para>
                /// </summary>
                [NameInMap("variables")]
                [Validation(Required=false)]
                public List<CreateCustomAgentRequestBodyEnvironmentVariables> Variables { get; set; }
                public class CreateCustomAgentRequestBodyEnvironmentVariables : TeaModel {
                    /// <summary>
                    /// <para>The name of the environment variable. It cannot be empty and must be unique within the current list of environment variables.</para>
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
            /// <para>The optional HTTP health check configuration. If this object is provided, the port field is required. Unspecified fields use default values. If omitted during creation, no health check is configured. If this top-level field is omitted during an update, the original configuration is retained. Pass null to remove the health check.</para>
            /// </summary>
            [NameInMap("healthCheck")]
            [Validation(Required=false)]
            public CreateCustomAgentRequestBodyHealthCheck HealthCheck { get; set; }
            public class CreateCustomAgentRequestBodyHealthCheck : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>This parameter is currently invalid. Omit this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("healthyThreshold")]
                [Validation(Required=false)]
                [Obsolete]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The interval between two health checks, in seconds. It must be a positive integer. Default value: 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("intervalSeconds")]
                [Validation(Required=false)]
                public int? IntervalSeconds { get; set; }

                /// <summary>
                /// <para>The HTTP health check path. It must start with a forward slash (/). Default value: /healthz.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/healthz</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The port accessed by the health check. This field is required when you configure a health check. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The timeout period for a single health check, in seconds. It must be a positive integer and less than the value of intervalSeconds. Default value: 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("timeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The number of consecutive health check failures required to mark the instance as unhealthy. It must be a positive integer. Default value: 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("unhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>The log delivery configuration for the agent. You can specify the Simple Log Service (SLS) project and Logstore. After a successful creation or update, verify that logs are delivered as expected.</para>
            /// </summary>
            [NameInMap("logging")]
            [Validation(Required=false)]
            public CreateCustomAgentRequestBodyLogging Logging { get; set; }
            public class CreateCustomAgentRequestBodyLogging : TeaModel {
                /// <summary>
                /// <para>The SLS log delivery destination. When you configure this object, neither the project nor the logstore field can be empty.</para>
                /// </summary>
                [NameInMap("sls")]
                [Validation(Required=false)]
                public CreateCustomAgentRequestBodyLoggingSls Sls { get; set; }
                public class CreateCustomAgentRequestBodyLoggingSls : TeaModel {
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
            /// <para>The name of the custom code or image agent. The length must be 1 to 128 characters after leading and trailing whitespaces are removed. The name must be unique within the same workspace.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-custom-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network access configuration for the agent. If this object is provided, omitted access items are treated as allowed. The actual accessible scope is still restricted by the workspace network configuration. To retain the original restrictions during an update, specify both accessInternet and accessVpc.</para>
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
                    /// <para>Specifies whether to allow the agent to access the Internet. A Boolean value is required when you configure accessInternet. For this setting to take effect, the workspace must also allow Internet access.</para>
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
                    /// <para>Specifies whether to allow the agent to access the user VPC configured for the workspace. A Boolean value is required when you configure accessVpc. For this setting to take effect, the workspace must also allow VPC access.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

            }

            /// <summary>
            /// <para>The observability configuration for the high-code agent.</para>
            /// </summary>
            [NameInMap("observability")]
            [Validation(Required=false)]
            public CreateCustomAgentRequestBodyObservability Observability { get; set; }
            public class CreateCustomAgentRequestBodyObservability : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable agent observability.</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>The list of OSS directory mounts. The total number of items in this list and agenticFsMounts cannot exceed 10. The entire list is replaced during an update. Pass an empty array [] to clear the list.</para>
            /// </summary>
            [NameInMap("ossMounts")]
            [Validation(Required=false)]
            public List<CreateCustomAgentRequestBodyOssMounts> OssMounts { get; set; }
            public class CreateCustomAgentRequestBodyOssMounts : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket. This field is required for each mount item. The length must be 3 to 63 characters. It can contain only lowercase letters, digits, and hyphens, and cannot start or end with a hyphen.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-data</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The absolute mount path in the container, such as /data/train. Mount targets cannot be duplicated or form parent-child overrides, and must avoid platform reserved directories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/oss/train</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The non-empty relative object directory prefix in the bucket. This field is required for each mount item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>datasets/train</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. A value of true indicates read-only, and a value of false indicates read and write. If omitted, the default value is false.</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            /// <summary>
            /// <para>The list of invocation protocols supported by the agent. Each item contains the protocol type and optional paths and request headers. The entire list is replaced during an update.</para>
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
                    /// <para>The purpose description of the current API path.</para>
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
            /// <para>The ARN of the RAM role used by the agent to access user cloud resources. The role must have permissions to access the cloud resources.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1234567890123456:role/agentcore-runtime-role</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The runtime configuration. Both compute and sessionPolicy must be provided. Omitted fields in hpa use default values.</para>
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
                /// <para>The elastic and session configuration. Omitted fields use default values. To retain the original policy during an update, submit the complete hpa object or omit the entire runtime object.</para>
                /// </summary>
                [NameInMap("hpa")]
                [Validation(Required=false)]
                public CreateCustomAgentRequestBodyRuntimeHpa Hpa { get; set; }
                public class CreateCustomAgentRequestBodyRuntimeHpa : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable elastic scaling. Default value: false.</para>
                    /// <para>This parameter is required.</para>
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
                    /// <para>The upper limit of instances. Valid values: 0 to 100. Default value: 10. The value cannot be less than the value of minSandboxCount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxSandboxCount")]
                    [Validation(Required=false)]
                    public int? MaxSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The lower limit of instances. Valid values: 0 to 100. Default value: 1. The value cannot be greater than the value of maxSandboxCount.</para>
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
                    /// <para>600</para>
                    /// </summary>
                    [NameInMap("sessionTtlSeconds")]
                    [Validation(Required=false)]
                    public int? SessionTtlSeconds { get; set; }

                }

                /// <summary>
                /// <para>The session policy configuration. It is used to set the session association method for requests.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sessionPolicy")]
                [Validation(Required=false)]
                public CreateCustomAgentRequestBodyRuntimeSessionPolicy SessionPolicy { get; set; }
                public class CreateCustomAgentRequestBodyRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The name of the request header for session identification. This field is required when type is set to ISOLATED_HEADER_FIELD and must be a valid HTTP request header name. Do not specify this field for other policies.</para>
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
                    /// <item><description>ISOLATED_COOKIE: Not recommended for use.</description></item>
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

            /// <summary>
            /// <para>Specifies whether to use the image cache. If omitted during creation, the default value is false. You can explicitly set this parameter to true or false. The new contract rejects null and invalid types. Existing compatibility endpoints are processed according to migration agreements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("useImageCache")]
            [Validation(Required=false)]
            public bool? UseImageCache { get; set; }

        }

        /// <summary>
        /// <para>The idempotency token passed as a query parameter. This parameter is required when explicitly submitting a customImage or setting container.type to custom, and is optional for ACR image and code package submissions. The token must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), colons (:), and hyphens (-). Reuse the same token for retries of the same submission. If the same token is used with different parameters, the request is rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-agent-request-20261010-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
