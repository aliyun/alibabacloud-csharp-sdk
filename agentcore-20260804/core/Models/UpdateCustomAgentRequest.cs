// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateCustomAgentRequest : TeaModel {
        /// <summary>
        /// <para>The update configuration of the custom code or image agent. You must provide at least one top-level field. Omitted top-level fields retain their original values. When submitting <c>artifact</c>, specify <c>port</c> and the required fields for the corresponding artifact source. When submitting <c>runtime</c>, specify <c>compute</c> and <c>sessionPolicy</c>, and include the complete <c>hpa</c> that needs to be retained. <c>environment.variables</c> and other arrays are replaced as complete lists.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateCustomAgentRequestBody Body { get; set; }
        public class UpdateCustomAgentRequestBody : TeaModel {
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
            /// <para>The NAS storage mount configuration. Currently, the AgenticFS type is supported and used to mount file directories in access points to agent runtime instances. The AgenticFS directory mount list and <c>ossMounts</c> can contain a maximum of 10 items in total. If omitted or set to <c>[]</c> during creation, it indicates no mounts. If omitted during an update, the original value is retained. If set to <c>[]</c>, the list is cleared. <c>null</c> is not accepted.</para>
            /// </summary>
            [NameInMap("agenticFsMounts")]
            [Validation(Required=false)]
            public List<UpdateCustomAgentRequestBodyAgenticFsMounts> AgenticFsMounts { get; set; }
            public class UpdateCustomAgentRequestBodyAgenticFsMounts : TeaModel {
                /// <summary>
                /// <para>The absolute mount path in the container, such as <c>/data/train</c>. Mount targets must not be duplicated or form parent-child directory overwrites, and must avoid platform reserved directories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs/data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The existing non-empty relative directory under the access point. This parameter is required for each mount item. Root directories, absolute paths, or parent directory jumps are not allowed.</para>
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
                /// <para>The domain name of the access point. This parameter is required for each mount item. The value is the DomainName in the response of the NAS ListAccessPoints operation. It does not include a protocol, port, or path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The update configuration for the deployment artifact. If the entire artifact object is omitted, the original configuration is retained. When submitting this object, specify the port and the required fields for the selected source. Only one source, either code or container, can be specified.</para>
            /// </summary>
            [NameInMap("artifact")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyArtifact Artifact { get; set; }
            public class UpdateCustomAgentRequestBodyArtifact : TeaModel {
                /// <summary>
                /// <para>The code package deployment configuration. This parameter is mutually exclusive with container. You must specify sourceUri, languageRuntime, and entrypoint, and set artifact.port. ZIP and TAR.GZ formats are supported. Dependencies must be provided by the caller within the package.</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyArtifactCode Code { get; set; }
                public class UpdateCustomAgentRequestBodyArtifactCode : TeaModel {
                    /// <summary>
                    /// <para>The startup command for the code package. This parameter is required in code package mode. The working directory is the root directory of the extracted code, which is /code. Example: python main.py. Quotes and escape characters are supported. Environment variables, pipes, and logical operations are not automatically expanded. For complex commands, use a script within the package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python main.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The identifier of the code runtime environment, such as python3.12. When creating or switching environments, use the identifier returned by ListAgentCodeRuntimes. The identifier is validated against the current version catalog and is not a fixed enumeration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python3.12</para>
                    /// </summary>
                    [NameInMap("languageRuntime")]
                    [Validation(Required=false)]
                    public string LanguageRuntime { get; set; }

                    /// <summary>
                    /// <para>The source URI of the code package. OSS URIs (oss://) or HTTPS object URLs of standard OSS public domain names, including OSS signed URLs, are supported. External sites, custom domain names, or additional authentication request headers are not supported. For local uploads, use the sourceUri returned by GetAgentCodePackageUploadUrl. The URI is re-validated and transferred during creation or update. After saving, a fixed oss:// URI provided by the platform is returned. This fixed URI can be reused for regular updates.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://my-agent-bucket/packages/main.zip</para>
                    /// </summary>
                    [NameInMap("sourceUri")]
                    [Validation(Required=false)]
                    public string SourceUri { get; set; }

                }

                /// <summary>
                /// <para>The container image deployment configuration. This parameter is mutually exclusive with code. For an ACR source, set type to acr and specify instanceId, namespace, repo, and tag. For a custom source, set type to custom and provide the complete customImage.</para>
                /// </summary>
                [NameInMap("container")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyArtifactContainer Container { get; set; }
                public class UpdateCustomAgentRequestBodyArtifactContainer : TeaModel {
                    /// <summary>
                    /// <para>The optional executable program and startup parameters. If specified, this parameter must be a non-empty string. If you submit the container configuration without specifying entrypoint, the default startup method of the image is used. Quotes and escape characters are supported. Variables, pipes, and logical operations are not automatically expanded.</para>
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
                    /// <para>The ACR image tag. This parameter is required when submitting the ACR container configuration and must be a non-empty string, such as v1.0.1. When updating the tag, you must also specify artifact.port and the type, instanceId, namespace, and repo parameters in the container configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1.0.0</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The type of the image source. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>acr: ACR image.</description></item>
                    /// <item><description>custom: Custom image source.
                    /// For the corresponding source configurations, refer to the descriptions of artifact.container and customImage.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acr</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The TCP port on which the agent service listens. Valid values: 1 to 65535. This parameter is required when submitting the artifact object. If the entire artifact object is omitted, the original artifact configuration is retained.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            /// <summary>
            /// <para>If omitted, the original source is retained. A complete submission indicates an active update of the custom image. If only the port and startup command change, you do not need to submit this parameter.</para>
            /// </summary>
            [NameInMap("customImage")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyCustomImage CustomImage { get; set; }
            public class UpdateCustomAgentRequestBodyCustomImage : TeaModel {
                /// <summary>
                /// <para>This parameter is required and verified by the backend when submitting <c>customImage</c>. The value is the complete <c>registry[:port]/repository:tag</c> or <c>registry[:port]/repository@sha256:digest</c>. Multi-level paths are supported. It does not include a protocol or user information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.example.com/team/agent:v1</para>
                /// </summary>
                [NameInMap("image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The password or token for the current repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-registry-token</para>
                /// </summary>
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>This parameter is required and verified by the backend when submitting <c>customImage</c>. It is the complete independent pull network configuration. For public networks, only pass <c>type=public</c>.</para>
                /// </summary>
                [NameInMap("pullNetwork")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyCustomImagePullNetwork PullNetwork { get; set; }
                public class UpdateCustomAgentRequestBodyCustomImagePullNetwork : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required when <c>type=vpc</c>. The vSwitch must belong to the selected VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-example</para>
                    /// </summary>
                    [NameInMap("securityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>This parameter is required and verified by the backend when submitting <c>pullNetwork</c>. The default value for new creations is public network, which is independent of the agent runtime network.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>public</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>This parameter is required when <c>type=vpc</c>. The vSwitch must belong to the selected VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-example</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>This parameter is required when <c>type=vpc</c>. The associated account and region are verified by the backend.</para>
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
                /// <para>The username for the current repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reader</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The description of the agent purpose. The maximum length is 1024 characters after leading and trailing spaces are removed. If omitted, the original value is retained. Pass <c>null</c> to clear the description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom agent that provides conversation services</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The user environment variable configuration for the agent process. If the entire environment object is omitted, the original values are retained. If variables is provided, the entire list is replaced, and any variables to be retained must be submitted together. Setting variables to an empty array, setting environment to null, or providing environment while omitting variables clears the user-configured environment variables.</para>
            /// </summary>
            [NameInMap("environment")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyEnvironment Environment { get; set; }
            public class UpdateCustomAgentRequestBodyEnvironment : TeaModel {
                /// <summary>
                /// <para>The complete list of user environment variables. A non-empty list replaces the original list entirely, while an empty array clears the list. The name of each item must be non-empty and unique within the list. The value must be a string, and empty strings are allowed.</para>
                /// </summary>
                [NameInMap("variables")]
                [Validation(Required=false)]
                public List<UpdateCustomAgentRequestBodyEnvironmentVariables> Variables { get; set; }
                public class UpdateCustomAgentRequestBodyEnvironmentVariables : TeaModel {
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
                    /// <para>The value of the environment variable. This parameter must be a string, and empty strings are allowed.</para>
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
            /// <para>The optional HTTP health check configuration. When this object is provided, port must be specified. Unspecified items use default values. Omitting this object during creation means no health check is configured. During an update, omitting this top-level field retains the original configuration, while passing null removes the health check.</para>
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
                /// <para>The interval between two health checks, in seconds. This parameter must be a positive integer. Default value: 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("intervalSeconds")]
                [Validation(Required=false)]
                public int? IntervalSeconds { get; set; }

                /// <summary>
                /// <para>The HTTP health check path. This parameter must start with a forward slash (/). Default value: /healthz.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/healthz</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The port accessed for health checks. This parameter is required when configuring a health check. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The timeout period for a single health check, in seconds. This parameter must be a positive integer and less than intervalSeconds. Default value: 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("timeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The number of consecutive health check failures required to mark the instance as unhealthy. This parameter must be a positive integer. Default value: 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("unhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>The log delivery configuration for the agent. You can specify the Simple Log Service project and Logstore. After a successful creation or update, verify whether the logs are delivered properly.</para>
            /// </summary>
            [NameInMap("logging")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyLogging Logging { get; set; }
            public class UpdateCustomAgentRequestBodyLogging : TeaModel {
                /// <summary>
                /// <para>The Simple Log Service log delivery destination. When updating this object, you must specify both project and logstore, and neither can be empty.</para>
                /// </summary>
                [NameInMap("sls")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyLoggingSls Sls { get; set; }
                public class UpdateCustomAgentRequestBodyLoggingSls : TeaModel {
                    /// <summary>
                    /// <para>The name of the Simple Log Service Logstore that receives the agent logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agent-runtime</para>
                    /// </summary>
                    [NameInMap("logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    /// <summary>
                    /// <para>The name of the Simple Log Service project that receives the agent logs.</para>
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
            /// <para>The name of the custom code or image agent. The length is 1 to 128 characters after leading and trailing spaces are removed. The name must be unique within the same workspace. If omitted, the original value is retained. It cannot be <c>null</c> or a blank name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-custom-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network access configuration for the agent. When this object is provided, omitted access items are treated as allowed. The actual accessible scope is still restricted by the workspace network configuration. To retain the original restrictions during an update, specify both accessInternet and accessVpc.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyNetwork Network { get; set; }
            public class UpdateCustomAgentRequestBodyNetwork : TeaModel {
                /// <summary>
                /// <para>The Internet access configuration. If this access item is omitted, the agent does not restrict Internet access. However, the workspace must still allow Internet access.</para>
                /// </summary>
                [NameInMap("accessInternet")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyNetworkAccessInternet AccessInternet { get; set; }
                public class UpdateCustomAgentRequestBodyNetworkAccessInternet : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow the agent to access the Internet. A Boolean value must be provided when configuring accessInternet. For this configuration to take effect, the workspace must also allow Internet access.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

                /// <summary>
                /// <para>The user VPC access configuration. If this access item is omitted, the agent does not restrict VPC access. However, the workspace must still be configured to allow access to the user VPC.</para>
                /// </summary>
                [NameInMap("accessVpc")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyNetworkAccessVpc AccessVpc { get; set; }
                public class UpdateCustomAgentRequestBodyNetworkAccessVpc : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow the agent to access the user VPC configured in the workspace. A Boolean value must be provided when configuring accessVpc. For this configuration to take effect, the workspace must also allow VPC access.</para>
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
            /// <para>The list of OSS directory mounts. A maximum of 10 items can be configured in total for OSS mounts and AgenticFS mounts. When you update this parameter, the entire list is replaced. Pass an empty array to clear the mounts.</para>
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
                /// <para>The absolute mount path in the container, such as <c>/data/train</c>. Mount targets must not be duplicated or form parent-child directory overwrites, and must avoid platform reserved directories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/oss/train</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The non-empty relative object directory prefix in the bucket. This parameter is required for each mount item.</para>
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
            /// <para>The list of invocation protocols supported by the agent. Each item includes the protocol type and optional paths and request headers. When you update this parameter, the entire list is replaced.</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public List<UpdateCustomAgentRequestBodyProtocol> Protocol { get; set; }
            public class UpdateCustomAgentRequestBodyProtocol : TeaModel {
                /// <summary>
                /// <para>The request header configurations for the current protocol. The key is a non-empty request header name, and the value must be a string.</para>
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
                /// <para>The invoke Protocol Type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>agui: AG-UI protocol.</description></item>
                /// <item><description>openai-chat-completion: OpenAI Chat Completions compatible protocol.</description></item>
                /// <item><description>custom: custom protocol.</description></item>
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
            /// <para>The ARN of the RAM role used by the agent to access user cloud resources. The role must have the permissions to access the cloud resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1234567890123456:role/agentcore-runtime-role</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The runtime configuration. If the entire object is omitted, the original configuration is retained. If provided, you must specify both compute and sessionPolicy. Omitted fields in hpa use default values.</para>
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
                /// <para>The elastic and session configuration. Omitted fields use default values. To retain the original policy during an update, submit the complete hpa object or omit the entire runtime object.</para>
                /// </summary>
                [NameInMap("hpa")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyRuntimeHpa Hpa { get; set; }
                public class UpdateCustomAgentRequestBodyRuntimeHpa : TeaModel {
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
                    /// <para>The maximum number of instances. Valid values: 0 to 100. Default value: 10. This value cannot be less than minSandboxCount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxSandboxCount")]
                    [Validation(Required=false)]
                    public int? MaxSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The minimum number of instances. Valid values: 0 to 100. Default value: 1. This value cannot be greater than maxSandboxCount.</para>
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
                /// <para>The session policy configuration, which is used to set the session affinity method for requests.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sessionPolicy")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyRuntimeSessionPolicy SessionPolicy { get; set; }
                public class UpdateCustomAgentRequestBodyRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The name of the request header used for session identification. This parameter is required when type is set to ISOLATED_HEADER_FIELD and must be a valid HTTP request header name. Do not specify this parameter for other policies.</para>
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

            /// <summary>
            /// <para>If this parameter is not passed during an update, the original value is retained. Explicit true or false settings do not automatically default to false. New contracts reject null and invalid types. Existing compatible portals are processed according to migration agreements. In the current phase, the custom source is normalized to false by the console and omitted by the frontend. Explicit true is rejected. Platform copies are still retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("useImageCache")]
            [Validation(Required=false)]
            public bool? UseImageCache { get; set; }

        }

        /// <summary>
        /// <para>The idempotency token passed as a query parameter. This parameter is required when you explicitly submit a customImage or set container.type to custom. It is optional when you submit an ACR image or a code package. The token must be 1 to 128 characters in length and can contain letters, digits, periods, underscores, colons, and hyphens. Reuse the same token for retries of the same submission. Requests with the same token but different parameters are rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-agent-request-20261010-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
