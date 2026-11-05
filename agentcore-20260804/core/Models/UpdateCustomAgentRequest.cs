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
            /// <para>The NAS storage mount configuration. Currently, the AgenticFS type is supported, which is used to mount file directories in access points to agent runtime instances. The AgenticFS directory mount list can contain up to 10 items in total with <c>ossMounts</c>. If omitted or set to <c>[]</c> during creation, it indicates no mounts. If omitted during update, the original value is retained. If set to <c>[]</c>, the list is cleared. <c>null</c> is not accepted.</para>
            /// </summary>
            [NameInMap("agenticFsMounts")]
            [Validation(Required=false)]
            public List<UpdateCustomAgentRequestBodyAgenticFsMounts> AgenticFsMounts { get; set; }
            public class UpdateCustomAgentRequestBodyAgenticFsMounts : TeaModel {
                /// <summary>
                /// <para>The absolute mount path in the container, such as <c>/data/train</c>. Mount targets must not be duplicated or form parent-child overwrites, and must avoid platform reserved directories.</para>
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
                /// <para>Specifies whether the mount is read-only. <c>true</c> indicates read-only, and <c>false</c> indicates read and write. The default value is <c>false</c> if omitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The access point domain name. This parameter is required for each mount item. It takes the <c>DomainName</c> from the NAS ListAccessPoints response and does not contain a protocol, port, or path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The deployment artifact update configuration. If the entire <c>artifact</c> is omitted, the original configuration is retained. When submitting this object, specify <c>port</c> and the required fields for the selected source. Only one source can exist in <c>code</c> and <c>container</c>.</para>
            /// </summary>
            [NameInMap("artifact")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyArtifact Artifact { get; set; }
            public class UpdateCustomAgentRequestBodyArtifact : TeaModel {
                /// <summary>
                /// <para>The code package deployment configuration, which is mutually exclusive with <c>container</c>. You must provide <c>sourceUri</c>, <c>languageRuntime</c>, and <c>entrypoint</c> at the same time, and specify <c>artifact.port</c>. ZIP or TAR.GZ is supported, and dependencies are provided by the caller in the package.</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyArtifactCode Code { get; set; }
                public class UpdateCustomAgentRequestBodyArtifactCode : TeaModel {
                    /// <summary>
                    /// <para>The code package startup command. This parameter is required in code package mode. The working directory is the root directory of the extracted code <c>/code</c>, such as <c>python main.py</c>. Quotes and escapes are supported, but environment variables, pipes, or logical operations are not automatically expanded. Use scripts in the package for complex commands.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python main.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The code runtime environment identifier, such as <c>python3.12</c>. When creating or switching environments, use the identifier returned by ListAgentCodeRuntimes. It is verified by the current version catalog and is not a fixed enumeration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python3.12</para>
                    /// </summary>
                    [NameInMap("languageRuntime")]
                    [Validation(Required=false)]
                    public string LanguageRuntime { get; set; }

                    /// <summary>
                    /// <para>The code package source address. It supports <c>oss://</c> addresses or HTTPS object addresses of standard OSS public domain name, including OSS signed URLs. Arbitrary external sites, custom domain names, or additional authentication request headers are not supported. After local upload, use the <c>sourceUri</c> returned by GetAgentCodePackageUploadUrl. It is re-verified and transferred during creation or update, and a fixed <c>oss://</c> address on the platform is returned after saving. Common updates can reuse this fixed address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://my-agent-bucket/packages/main.zip</para>
                    /// </summary>
                    [NameInMap("sourceUri")]
                    [Validation(Required=false)]
                    public string SourceUri { get; set; }

                }

                /// <summary>
                /// <para>The container image deployment configuration, which is mutually exclusive with <c>code</c>. For ACR sources, specify <c>type=acr</c>, <c>instanceId</c>, <c>namespace</c>, <c>repo</c>, and <c>tag</c>. For custom sources, specify <c>type=custom</c> and submit the complete <c>customImage</c>.</para>
                /// </summary>
                [NameInMap("container")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyArtifactContainer Container { get; set; }
                public class UpdateCustomAgentRequestBodyArtifactContainer : TeaModel {
                    /// <summary>
                    /// <para>The optional executable program and startup parameters. It must be a non-empty string when specified. If <c>container</c> is submitted but <c>entrypoint</c> is not specified, the default startup method of the image is used. Quotes and escapes are supported, but variables, pipes, or logical operations are not automatically expanded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python app.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The ID of the ACR instance to which the image repository belongs. It cannot be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cri-a1b2c3d4e5f6</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The namespace to which the ACR image repository belongs. It cannot be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-agent</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The name of the image repository in the ACR namespace. It cannot be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chat-agent</para>
                    /// </summary>
                    [NameInMap("repo")]
                    [Validation(Required=false)]
                    public string Repo { get; set; }

                    /// <summary>
                    /// <para>The ACR image tag. This parameter is required when submitting the ACR container configuration and must be a non-empty string, such as <c>v1.0.1</c>. When updating the tag, also specify <c>artifact.port</c> and <c>type</c>, <c>instanceId</c>, <c>namespace</c>, and <c>repo</c> in the container configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1.0.0</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The image source type. <c>acr</c> indicates an ACR image, and <c>custom</c> indicates a custom image source. For the corresponding source configuration, see the descriptions of <c>artifact.container</c> and <c>customImage</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acr</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The TCP port listened by the agent service. Valid values: 1 to 65535. This parameter is required when submitting <c>artifact</c>. If the entire <c>artifact</c> is omitted, the original artifact configuration is retained.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            /// <summary>
            /// <para>Omission indicates retaining the source, and complete submission indicates actively updating the custom image. You do not need to submit it if only the port and startup command change.</para>
            /// </summary>
            [NameInMap("customImage")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyCustomImage CustomImage { get; set; }
            public class UpdateCustomAgentRequestBodyCustomImage : TeaModel {
                /// <summary>
                /// <para>This parameter is required when submitting <c>customImage</c> and is verified by the backend. It must be a complete <c>registry[:port]/repository:tag</c> or <c>registry[:port]/repository@sha256:digest</c> address. Multi-level paths are supported, and it does not contain a protocol or user information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.example.com/team/agent:v1</para>
                /// </summary>
                [NameInMap("image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The current repository password or token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-registry-token</para>
                /// </summary>
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>This parameter is required when submitting <c>customImage</c> and is verified by the backend. It is the complete independent pull network configuration. For the public network, only pass <c>type=public</c>.</para>
                /// </summary>
                [NameInMap("pullNetwork")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyCustomImagePullNetwork PullNetwork { get; set; }
                public class UpdateCustomAgentRequestBodyCustomImagePullNetwork : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required when <c>type=vpc</c> and must belong to the selected VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-example</para>
                    /// </summary>
                    [NameInMap("securityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>This parameter is required when submitting <c>pullNetwork</c> and is verified by the backend. The default for new creations is the public network, which is independent of the agent runtime network.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>public</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>This parameter is required when <c>type=vpc</c> and must belong to the selected VPC.</para>
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
                /// <para>The current repository username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reader</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The description of the agent. The maximum length is 1,024 characters after leading and trailing whitespaces are removed. If this parameter is omitted, the original value is retained. If null is passed, the description is cleared.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom agent that provides conversational services</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The user environment variable configuration for the agent process. If the entire environment object is omitted, the original value is retained. If variables is provided, the entire list is replaced, and any variables to be retained must be submitted together. Setting variables to an empty array, setting environment to null, or providing environment while omitting variables clears the user-configured environment variables.</para>
            /// </summary>
            [NameInMap("environment")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyEnvironment Environment { get; set; }
            public class UpdateCustomAgentRequestBodyEnvironment : TeaModel {
                /// <summary>
                /// <para>The complete list of user environment variables. A non-empty list replaces the original list entirely, and an empty array clears the list. The name of each item must be non-empty and unique within the list. The value must be a string, and empty strings are allowed.</para>
                /// </summary>
                [NameInMap("variables")]
                [Validation(Required=false)]
                public List<UpdateCustomAgentRequestBodyEnvironmentVariables> Variables { get; set; }
                public class UpdateCustomAgentRequestBodyEnvironmentVariables : TeaModel {
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
                    /// <para>The value of the environment variable. It must be a string, and empty strings are allowed.</para>
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
            /// <para>The optional HTTP health check configuration. If this object is provided, port is required, and unspecified items use default values. If omitted during creation, no health check is configured. If this top-level field is omitted during an update, the original configuration is retained. If null is passed, the health check is removed.</para>
            /// </summary>
            [NameInMap("healthCheck")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyHealthCheck HealthCheck { get; set; }
            public class UpdateCustomAgentRequestBodyHealthCheck : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>This parameter is currently invalid. Omit it.</para>
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
                /// <para>The port accessed for health checks. This parameter is required when configuring a health check. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The timeout period for a single health check, in seconds. It must be a positive integer and less than intervalSeconds. Default value: 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("timeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The number of consecutive health check failures before the instance is considered unhealthy. It must be a positive integer. Default value: 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("unhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>The log delivery configuration for the agent. You can specify the Simple Log Service project and Logstore. After a successful creation or update, verify that logs are delivered properly.</para>
            /// </summary>
            [NameInMap("logging")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyLogging Logging { get; set; }
            public class UpdateCustomAgentRequestBodyLogging : TeaModel {
                /// <summary>
                /// <para>The Simple Log Service log delivery destination. When updating this object, both project and logstore must be provided and cannot be empty.</para>
                /// </summary>
                [NameInMap("sls")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyLoggingSls Sls { get; set; }
                public class UpdateCustomAgentRequestBodyLoggingSls : TeaModel {
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
            /// <para>The name of the custom code or image agent. The length is 1 to 128 characters after leading and trailing whitespaces are removed. The name must be unique within the same workspace. If this parameter is omitted, the original value is retained. It cannot be null or an empty name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-custom-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network access configuration for the agent. If this object is provided, omitted access items are treated as allowed. The actual accessible range is still restricted by the workspace network configuration. To retain the original restrictions during an update, specify both accessInternet and accessVpc.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public UpdateCustomAgentRequestBodyNetwork Network { get; set; }
            public class UpdateCustomAgentRequestBodyNetwork : TeaModel {
                /// <summary>
                /// <para>The Internet access configuration. If this access item is omitted, Internet access is not restricted on the agent side. The workspace must still allow Internet access.</para>
                /// </summary>
                [NameInMap("accessInternet")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyNetworkAccessInternet AccessInternet { get; set; }
                public class UpdateCustomAgentRequestBodyNetworkAccessInternet : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow the agent to access the Internet. A Boolean value is required when configuring accessInternet. The workspace must also allow Internet access for this to take effect.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

                /// <summary>
                /// <para>The user VPC access configuration. If this access item is omitted, VPC access is not restricted on the agent side. The workspace must still be configured to allow access to the user VPC.</para>
                /// </summary>
                [NameInMap("accessVpc")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyNetworkAccessVpc AccessVpc { get; set; }
                public class UpdateCustomAgentRequestBodyNetworkAccessVpc : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow the agent to access the user VPC configured for the workspace. A Boolean value is required when configuring accessVpc. The workspace must also allow VPC access for this to take effect.</para>
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
            /// <para>The list of OSS directory mounts. The total number of items combined with agenticFsMounts cannot exceed 10. During an update, this list is replaced entirely. Pass an empty array to clear the mounts.</para>
            /// </summary>
            [NameInMap("ossMounts")]
            [Validation(Required=false)]
            public List<UpdateCustomAgentRequestBodyOssMounts> OssMounts { get; set; }
            public class UpdateCustomAgentRequestBodyOssMounts : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket. This parameter is required for each mount item. The length is 3 to 63 characters. It can contain only lowercase letters, digits, and hyphens, and cannot start or end with a hyphen.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-data</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The absolute mount path in the container, such as <c>/data/train</c>. Mount targets must not be duplicated or form parent-child overwrites, and must avoid platform reserved directories.</para>
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
                /// <para>Specifies whether the mount is read-only. <c>true</c> indicates read-only, and <c>false</c> indicates read and write. The default value is <c>false</c> if omitted.</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            /// <summary>
            /// <para>The list of invocation protocols supported by the agent. Each item includes the protocol type and optional paths and request headers. This list is replaced entirely during an update.</para>
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
                    /// <para>The description of the current API path.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1234567890123456:role/agentcore-runtime-role</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The runtime configuration. If the entire object is omitted, the original configuration is retained. If provided, both compute and sessionPolicy must be specified. Omitted items in hpa use default values.</para>
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
                    /// <para>The upper limit of instances. Valid values: 0 to 100. Default value: 10. This value cannot be less than minSandboxCount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxSandboxCount")]
                    [Validation(Required=false)]
                    public int? MaxSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The lower limit of instances. Valid values: 0 to 100. Default value: 1. This value cannot be greater than maxSandboxCount.</para>
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
                /// <para>The session policy configuration, which is used to set the session association method for requests.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sessionPolicy")]
                [Validation(Required=false)]
                public UpdateCustomAgentRequestBodyRuntimeSessionPolicy SessionPolicy { get; set; }
                public class UpdateCustomAgentRequestBodyRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The name of the request header for session identification. This parameter is required when type is set to ISOLATED_HEADER_FIELD and must be a valid HTTP request header name. Do not specify this parameter for other policies.</para>
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
                    /// <item><description>ISOLATED_COOKIE: Not recommended for use at this time.</description></item>
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
            /// <para>Retains the original value if omitted in an update. Explicitly set to true or false without automatically defaulting to false. The new contract rejects null and invalid types. Existing compatibility endpoints are handled according to migration conventions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("useImageCache")]
            [Validation(Required=false)]
            public bool? UseImageCache { get; set; }

        }

        /// <summary>
        /// <para>The idempotency token passed through query parameters. Required when explicitly submitting customImage or container.type=custom. Optional for ACR image and code package submissions. The length is 1 to 128 characters. Letters, digits, periods, underscores, colons, and hyphens are allowed. Reuse the same token for retries of the same submission. Using the same token for different parameters is rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-agent-request-20261010-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
