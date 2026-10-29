// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateCustomAgentRequest : TeaModel {
        /// <summary>
        /// <para>The update configuration for the custom agent. Specify at least one top-level field. Omitted top-level fields retain their original values. When you provide a configuration object, you must specify its required subfields and include any optional configurations that you want to retain. Arrays are replaced as a whole.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateCustomAgentRequestBody Body { get; set; }
        public class UpdateCustomAgentRequestBody : TeaModel {
            /// <summary>
            /// <para>The list of additional AgenticFS mounts. The total number of AgenticFS mounts and OSS mounts cannot exceed 10. If you omit this field or pass an empty array [] during creation, no additional mounts are configured. During an update, omitting this field retains the original value, and passing an empty array [] clears the list. You cannot pass null.</para>
            /// </summary>
            [NameInMap("agenticFsMounts")]
            [Validation(Required=false)]
            public List<UpdateCustomAgentRequestBodyAgenticFsMounts> AgenticFsMounts { get; set; }
            public class UpdateCustomAgentRequestBodyAgenticFsMounts : TeaModel {
                /// <summary>
                /// <para>The subdirectory under /mnt/agenticfs/ in the container. This field is required for each mount item and is validated by the backend. Mount targets cannot be duplicated or overlap in a parent-child relationship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs/data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The existing non-empty relative directory under the access point. This field is required for each mount item and is validated by the backend. Root directories, absolute paths, and parent directory traversals are not allowed.</para>
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
                /// <para>The domain name of the access point. This field is required for each mount item and is validated by the backend. Use the DomainName value from the ListAccessPoints response of NAS. Do not include the protocol, port, or path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The deployment artifact configuration. You must specify the service listening port and choose either code or container as the deployment method. During an update, you must provide the required fields for the selected method.</para>
            /// </summary>
            [NameInMap("artifact")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyArtifact Artifact { get; set; }
            public class UpdateCustomAgentRequestBodyArtifact : TeaModel {
                /// <summary>
                /// <para>The code package deployment configuration. This field is mutually exclusive with the container field. Code packages use the ZIP or TAR.GZ format. Dependencies must be packaged by the user. The platform does not install dependencies or perform online builds.</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyArtifactCode Code { get; set; }
                public class UpdateCustomAgentRequestBodyArtifactCode : TeaModel {
                    /// <summary>
                    /// <para>The startup command for the code package. This field is required in code package mode. The working directory is the extracted code root directory /code, such as python main.py. Quotes and escapes are supported. Environment variables, pipes, and logical operations are not automatically expanded. Use scripts within the package for complex commands.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python main.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The code runtime environment identifier, such as python3.12. When you create or switch environments, use the identifier returned by ListAgentCodeRuntimes. The identifier is validated by the current version catalog and is not a fixed enumeration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python3.12</para>
                    /// </summary>
                    [NameInMap("languageRuntime")]
                    [Validation(Required=false)]
                    public string LanguageRuntime { get; set; }

                    /// <summary>
                    /// <para>The source address of the code package. This field supports oss:// addresses or HTTPS object addresses of standard OSS public domain names, including OSS signed URLs. External sites, custom domain names, and additional authentication request headers are not supported. For local uploads, use the sourceUri returned by GetAgentCodePackageUploadUrl. The address is revalidated and transferred during creation or update. After the address is saved, a fixed oss:// address of the platform is returned. You can reuse this fixed address for regular updates.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://my-agent-bucket/packages/main.zip</para>
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
                    /// <para>The optional executable program and startup parameters. If specified, this field must be a non-empty string. When you update the artifact, omitting this field uses the default startup method of the image. To retain the original custom startup command, you must provide this field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python app.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The ID of the ACR instance to which the image repository belongs. This field cannot be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cri-a1b2c3d4e5f6</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The namespace to which the ACR image repository belongs. This field cannot be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-agent</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The name of the image repository in the ACR namespace. This field cannot be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chat-agent</para>
                    /// </summary>
                    [NameInMap("repo")]
                    [Validation(Required=false)]
                    public string Repo { get; set; }

                    /// <summary>
                    /// <para>The image tag used for deployment. This field cannot be empty. When you update the tag, you must also provide artifact.port and other required image fields.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1.0.0</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The image source type. Only acr is supported, which indicates Container Registry.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            /// <summary>
            /// <para>The custom image configuration. Omitting this field retains the original source. Submitting the complete configuration indicates an active update of the custom image. You do not need to submit this field if only the port and startup command change.</para>
            /// </summary>
            [NameInMap("customImage")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyCustomImage CustomImage { get; set; }
            public class UpdateCustomAgentRequestBodyCustomImage : TeaModel {
                /// <summary>
                /// <para>The custom image address. This field is required when you submit customImage and is validated by the backend. Specify the full registry[:port]/repository:tag or registry[:port]/repository@sha256:digest format. Multi-level paths are supported. Do not include the protocol or user information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.example.com/team/agent:v1</para>
                /// </summary>
                [NameInMap("image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The repository password or token for the current task. Submit a non-empty value in pairs with the username field. The value is not trimmed and cannot be null, an empty string, or a masked value. This field is used only for the current task and is not permanently saved or returned. To use anonymous access, omit both fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-registry-token</para>
                /// </summary>
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The independent network configuration for pulling images. This field is required when you submit customImage and is validated by the backend. For public networks, only pass type=public.</para>
                /// </summary>
                [NameInMap("pullNetwork")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyCustomImagePullNetwork PullNetwork { get; set; }
                public class UpdateCustomAgentRequestBodyCustomImagePullNetwork : TeaModel {
                    /// <summary>
                    /// <para>The ID of the security group. This field is required when type is set to vpc and must belong to the selected VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-example</para>
                    /// </summary>
                    [NameInMap("securityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The type of the pull network. This field is required when you submit pullNetwork and is validated by the backend. The default value for a new configuration is public network, which is independent of the agent runtime network.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>public</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The ID of the security group. This field is required when type is set to vpc and must belong to the selected VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-example</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The ID of the VPC. This field is required when type is set to vpc. The associated account and region are validated by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-example</para>
                    /// </summary>
                    [NameInMap("vpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether to skip HTTPS certificate verification. If omitted, the default value is false. This field does not accept null. HTTP fallback semantics are still under discussion and do not affect the current field definition. The image address does not include a protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("skipTlsVerify")]
                [Validation(Required=false)]
                public bool? SkipTlsVerify { get; set; }

                /// <summary>
                /// <para>The repository username for the current task. When you create or explicitly update a private source, resubmit this field in pairs with the password field. Existing copies also require verification. To use anonymous access, omit both fields. A read-only username is not automatically used as the input for the current task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reader</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The description of the agent purpose. The description can be up to 1,024 characters in length after leading and trailing spaces are removed. If omitted, the original value is retained. Pass null to clear the description.</para>
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
                    /// <para>The name of the environment variable. This field cannot be empty and must be unique in the current environment variable list.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LOG_LEVEL</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value of the environment variable. This field must be a string and can be an empty string.</para>
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
            /// <para>The optional HTTP health check configuration. When this object is provided, the port field is required, and other unspecified fields use default values. Omitting this object during creation means no health check is configured. During an update, omitting this top-level field retains the original configuration, and passing null removes the health check.</para>
            /// </summary>
            [NameInMap("healthCheck")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyHealthCheck HealthCheck { get; set; }
            public class UpdateCustomAgentRequestBodyHealthCheck : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>This parameter does not take effect. Omit this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("healthyThreshold")]
                [Validation(Required=false)]
                [Obsolete]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The interval between two consecutive health checks, in seconds. The value must be a positive integer. Default value: 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("intervalSeconds")]
                [Validation(Required=false)]
                public int? IntervalSeconds { get; set; }

                /// <summary>
                /// <para>The HTTP health check path. The path must start with a forward slash (/). Default value: /healthz.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/healthz</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The port used for health checks. This field is required when you configure a health check. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The timeout period for a single health check, in seconds. The value must be a positive integer and less than the value of intervalSeconds. Default value: 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("timeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The number of consecutive health check failures required to mark the target as unhealthy. The value must be a positive integer. Default value: 3.</para>
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
            public UpdateCustomAgentRequestBodyLogging Logging { get; set; }
            public class UpdateCustomAgentRequestBodyLogging : TeaModel {
                /// <summary>
                /// <para>The SLS log delivery destination. When you update this object, you must provide both the project and logstore fields, and they cannot be empty.</para>
                /// </summary>
                [NameInMap("sls")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyLoggingSls Sls { get; set; }
                public class UpdateCustomAgentRequestBodyLoggingSls : TeaModel {
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
            /// <para>The custom name of the agent. The name must be 1 to 128 characters in length after leading and trailing spaces are removed, and must be unique within the same workspace. Omitting this field retains the original value. You cannot pass null or an empty name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-custom-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network access configuration for the agent. When this object is provided, omitted access items are treated as allowed. The actual accessible scope is still restricted by the network configuration of the workspace. To retain the original restrictions during an update, specify both accessInternet and accessVpc.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyNetwork Network { get; set; }
            public class UpdateCustomAgentRequestBodyNetwork : TeaModel {
                /// <summary>
                /// <para>The Internet access configuration. If this access item is omitted, the agent does not restrict Internet access. However, Internet access must still be allowed by the workspace.</para>
                /// </summary>
                [NameInMap("accessInternet")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyNetworkAccessInternet AccessInternet { get; set; }
                public class UpdateCustomAgentRequestBodyNetworkAccessInternet : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow the agent to access the Internet. A Boolean value is required when you configure accessInternet. For this setting to take effect, Internet access must also be allowed by the workspace.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

                /// <summary>
                /// <para>The user VPC access configuration. If this access item is omitted, the agent does not restrict VPC access. However, the workspace must be configured to allow access to the user VPC.</para>
                /// </summary>
                [NameInMap("accessVpc")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyNetworkAccessVpc AccessVpc { get; set; }
                public class UpdateCustomAgentRequestBodyNetworkAccessVpc : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow the agent to access the user VPC configured for the workspace. A Boolean value is required when you configure accessVpc. For this setting to take effect, VPC access must also be allowed by the workspace.</para>
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
            public UpdateCustomAgentRequestBodyObservability Observability { get; set; }
            public class UpdateCustomAgentRequestBodyObservability : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable agent observability.</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>The list of Object Storage Service (OSS) mounts. The total number of OSS mounts and agenticFsMounts cannot exceed 10. For each item, you must specify bucketName, path, and mountPath. Mount targets cannot be duplicated or overlap with each other. During an update, this list is replaced entirely. Pass an empty array to clear all mounts.</para>
            /// </summary>
            [NameInMap("ossMounts")]
            [Validation(Required=false)]
            public List<UpdateCustomAgentRequestBodyOssMounts> OssMounts { get; set; }
            public class UpdateCustomAgentRequestBodyOssMounts : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket. This field is required for each mount item. The name must be 3 to 63 characters in length and can contain only lowercase letters, digits, and hyphens (-). It cannot start or end with a hyphen.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-data</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The subdirectory under /mnt/oss/ in the container. This field is required for each mount item. Mount targets cannot be duplicated or form parent-child overlaps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/oss/train</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The non-empty object directory prefix in the bucket, such as datasets/train. Leading and trailing forward slashes (/) are removed. The root directory is not supported. Do not use parent directory navigation.</para>
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
                /// <para>The list of API paths corresponding to the current protocol.</para>
                /// </summary>
                [NameInMap("paths")]
                [Validation(Required=false)]
                public List<UpdateCustomAgentRequestBodyProtocolPaths> Paths { get; set; }
                public class UpdateCustomAgentRequestBodyProtocolPaths : TeaModel {
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
            /// <para>The Alibaba Cloud Resource Name (ARN) of the Resource Access Management (RAM) role used by the agent to access user cloud resources. The role must have the required permissions for the accessed cloud resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1234567890123456:role/agentcore-runtime-role</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The runtime configuration. When this object is provided, both compute and sessionPolicy must be present. To retain the original elastic policy, provide the complete hpa configuration. Omitting the top-level runtime field retains the original configuration.</para>
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
                    /// <para>The computing specification. Valid values:</para>
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
                /// <para>The optional elastic policy. When runtime is provided, omitting hpa or its fields uses the following default values: enabled is false, the minimum number of instances is 1, the maximum number of instances is 10, the maximum number of concurrent sessions per instance is 100, and the session idle timeout is 600 seconds. To retain the original policy during an update, provide the complete hpa configuration.</para>
                /// </summary>
                [NameInMap("hpa")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyRuntimeHpa Hpa { get; set; }
                public class UpdateCustomAgentRequestBodyRuntimeHpa : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable elastic scaling. A value of true indicates that elastic scaling is enabled. A value of false indicates that elastic scaling is disabled. When runtime is provided, omitting this field defaults to false.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent sessions for a single runtime instance. Valid values: 1 to 100. When runtime is provided, omitting this field uses the default value of 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("maxConcurrentSessionsPerSandbox")]
                    [Validation(Required=false)]
                    public int? MaxConcurrentSessionsPerSandbox { get; set; }

                    /// <summary>
                    /// <para>The maximum number of runtime instances. Valid values: 1 to 100. The value cannot be less than the value of minSandboxCount. When runtime is provided, omitting this field uses the default value of 10.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxSandboxCount")]
                    [Validation(Required=false)]
                    public int? MaxSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The minimum number of runtime instances. Valid values: 1 to 100. The value cannot be greater than the value of maxSandboxCount. When runtime is provided, omitting this field uses the default value of 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minSandboxCount")]
                    [Validation(Required=false)]
                    public int? MinSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The session idle timeout limit, in seconds. Valid values: 60 to 86400. When runtime is provided, omitting this field uses the default value of 600.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>600</para>
                    /// </summary>
                    [NameInMap("sessionTtlSeconds")]
                    [Validation(Required=false)]
                    public int? SessionTtlSeconds { get; set; }

                }

                /// <summary>
                /// <para>The session policy configuration used to set the session affinity method for requests.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sessionPolicy")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyRuntimeSessionPolicy SessionPolicy { get; set; }
                public class UpdateCustomAgentRequestBodyRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The name of the HTTP request header used by the session policy. This field is required when type is set to ISOLATED_HEADER_FIELD and must be a valid HTTP request header name. Omit this field for other policies.</para>
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

            /// <summary>
            /// <para>If this field is not passed during an update, the original value is retained. Explicitly set this field to true or false. The system does not automatically append false. The new contract rejects null and invalid types. Existing compatibility endpoints are processed according to migration agreements.</para>
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
