// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateMcpTemplateConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateMcpTemplateConfigResponseBodyData Data { get; set; }
        public class UpdateMcpTemplateConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of remote MCP service addresses.</para>
            /// </summary>
            [NameInMap("addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            /// <summary>
            /// <para>The custom tags. Multiple tags are supported.</para>
            /// </summary>
            [NameInMap("customTags")]
            [Validation(Required=false)]
            public List<string> CustomTags { get; set; }

            /// <summary>
            /// <para>The deployment configuration for code-deployed MCP.</para>
            /// </summary>
            [NameInMap("deploymentConfig")]
            [Validation(Required=false)]
            public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfig DeploymentConfig { get; set; }
            public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfig : TeaModel {
                /// <summary>
                /// <para>The MCP ingress access control configuration.</para>
                /// </summary>
                [NameInMap("accessControl")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigAccessControl AccessControl { get; set; }
                public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigAccessControl : TeaModel {
                    /// <summary>
                    /// <para>The AgentCore Credential referenced when mode is set to CREDENTIAL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>credential-id</para>
                    /// </summary>
                    [NameInMap("credentialId")]
                    [Validation(Required=false)]
                    public string CredentialId { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable ingress access control.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The access control mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ANONYMOUS: anonymous access.</description></item>
                    /// <item><description>CREDENTIAL: uses AgentCore access credentials.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREDENTIAL</para>
                    /// </summary>
                    [NameInMap("mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                }

                /// <summary>
                /// <para>The Agent Identity configuration.</para>
                /// </summary>
                [NameInMap("agentIdentityConfiguration")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigAgentIdentityConfiguration AgentIdentityConfiguration { get; set; }
                public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigAgentIdentityConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable authorization.</para>
                    /// </summary>
                    [NameInMap("authorizationEnabled")]
                    [Validation(Required=false)]
                    public bool? AuthorizationEnabled { get; set; }

                    /// <summary>
                    /// <para>The Alibaba Cloud Resource Name (ARN) of the credential provider.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:agentidentity:cn-hangzhou:1234567890123456:provider/example</para>
                    /// </summary>
                    [NameInMap("credentialProviderArn")]
                    [Validation(Required=false)]
                    public string CredentialProviderArn { get; set; }

                    /// <summary>
                    /// <para>The credential provider type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oauth2</para>
                    /// </summary>
                    [NameInMap("credentialProviderType")]
                    [Validation(Required=false)]
                    public string CredentialProviderType { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable Agent Identity.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

                /// <summary>
                /// <para>Valid values: Code (ZIP code package) and Container (custom container).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Code</para>
                /// </summary>
                [NameInMap("artifactType")]
                [Validation(Required=false)]
                public string ArtifactType { get; set; }

                /// <summary>
                /// <para>The code package configuration.</para>
                /// </summary>
                [NameInMap("codeConfiguration")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigCodeConfiguration CodeConfiguration { get; set; }
                public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigCodeConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The temporary code package token returned by GetMcpCodePackageUploadUrl. Use this token to create or update a code deployment after completing the pre-signed upload.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>upload-token</para>
                    /// </summary>
                    [NameInMap("codePackageToken")]
                    [Validation(Required=false)]
                    public string CodePackageToken { get; set; }

                    /// <summary>
                    /// <para>The full startup command, with each argument passed in order by parameter boundary. For example, when using supergateway to start a stdio MCP, pass supergateway, --stdio, the full subcommand, and remaining arguments.</para>
                    /// </summary>
                    [NameInMap("command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                    /// <summary>
                    /// <para>The code package runtime. Valid values: python3.13, nodejs22, and java17.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python3.13</para>
                    /// </summary>
                    [NameInMap("language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                }

                /// <summary>
                /// <para>The custom container configuration.</para>
                /// </summary>
                [NameInMap("containerConfiguration")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigContainerConfiguration ContainerConfiguration { get; set; }
                public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigContainerConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The ACR instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cri-example</para>
                    /// </summary>
                    [NameInMap("acrInstanceId")]
                    [Validation(Required=false)]
                    public string AcrInstanceId { get; set; }

                    /// <summary>
                    /// <para>The startup command.</para>
                    /// </summary>
                    [NameInMap("command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                    /// <summary>
                    /// <para>The container entrypoint arguments.</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public List<string> Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The container image address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>registry.cn-hangzhou.aliyuncs.com/example/mcp:1.0.0</para>
                    /// </summary>
                    [NameInMap("image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// <para>The image registry type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACR</para>
                    /// </summary>
                    [NameInMap("imageRegistryType")]
                    [Validation(Required=false)]
                    public string ImageRegistryType { get; set; }

                    /// <summary>
                    /// <para>Custom containers must expose a standard MCP endpoint on their own. Set this parameter to SELF_HOSTED.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELF_HOSTED</para>
                    /// </summary>
                    [NameInMap("mcpRuntimeMode")]
                    [Validation(Required=false)]
                    public string McpRuntimeMode { get; set; }

                    /// <summary>
                    /// <para>Currently fixed to CONTAINER_IMAGE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONTAINER_IMAGE</para>
                    /// </summary>
                    [NameInMap("sourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                }

                /// <summary>
                /// <para>The hook configuration.</para>
                /// </summary>
                [NameInMap("hookConfiguration")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigHookConfiguration HookConfiguration { get; set; }
                public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigHookConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The PRE_LIST_TOOLS, PRE_CALL_TOOL, POST_LIST_TOOLS, and POST_CALL_TOOL hooks are executed in array order.</para>
                    /// </summary>
                    [NameInMap("hooks")]
                    [Validation(Required=false)]
                    public List<UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigHookConfigurationHooks> Hooks { get; set; }
                    public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigHookConfigurationHooks : TeaModel {
                        /// <summary>
                        /// <para>The hook API version.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.0</para>
                        /// </summary>
                        [NameInMap("apiVersion")]
                        [Validation(Required=false)]
                        public string ApiVersion { get; set; }

                        /// <summary>
                        /// <para>The hook description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Log MCP tool invocations</para>
                        /// </summary>
                        [NameInMap("description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to enable the hook.</para>
                        /// </summary>
                        [NameInMap("enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <para>The hook event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PRE_CALL_TOOL</para>
                        /// </summary>
                        [NameInMap("event")]
                        [Validation(Required=false)]
                        public string Event { get; set; }

                        /// <summary>
                        /// <para>The hook request headers.</para>
                        /// </summary>
                        [NameInMap("headers")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> Headers { get; set; }

                        /// <summary>
                        /// <para>The timeout period, in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3000</para>
                        /// </summary>
                        [NameInMap("timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                        /// <summary>
                        /// <para>The hook callback URL.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://example.com/mcp-hook">https://example.com/mcp-hook</a></para>
                        /// </summary>
                        [NameInMap("url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                }

                /// <summary>
                /// <para>The log configuration.</para>
                /// </summary>
                [NameInMap("logConfiguration")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigLogConfiguration LogConfiguration { get; set; }
                public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigLogConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to collect instance metrics.</para>
                    /// </summary>
                    [NameInMap("enableInstanceMetrics")]
                    [Validation(Required=false)]
                    public bool? EnableInstanceMetrics { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to collect request metrics.</para>
                    /// </summary>
                    [NameInMap("enableRequestMetrics")]
                    [Validation(Required=false)]
                    public bool? EnableRequestMetrics { get; set; }

                    /// <summary>
                    /// <para>The log splitting begin rule for Function Compute (FC).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DefaultRegex</para>
                    /// </summary>
                    [NameInMap("logBeginRule")]
                    [Validation(Required=false)]
                    public string LogBeginRule { get; set; }

                    /// <summary>
                    /// <para>The Logstore name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp-logs</para>
                    /// </summary>
                    [NameInMap("logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    /// <summary>
                    /// <para>The Simple Log Service project name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agentcore-mcp-logs</para>
                    /// </summary>
                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                }

                /// <summary>
                /// <para>The MCP session configuration.</para>
                /// </summary>
                [NameInMap("mcpConfiguration")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigMcpConfiguration McpConfiguration { get; set; }
                public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigMcpConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The MCP endpoint path, such as /mcp or /sse.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/mcp</para>
                    /// </summary>
                    [NameInMap("endpointPath")]
                    [Validation(Required=false)]
                    public string EndpointPath { get; set; }

                    /// <summary>
                    /// <para>The number of concurrent sessions per instance. Currently fixed to 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sessionConcurrencyPerInstance")]
                    [Validation(Required=false)]
                    public int? SessionConcurrencyPerInstance { get; set; }

                    /// <summary>
                    /// <para>The session idle timeout period. Unit: seconds. Default value: 1800.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1800</para>
                    /// </summary>
                    [NameInMap("sessionIdleTimeoutSeconds")]
                    [Validation(Required=false)]
                    public int? SessionIdleTimeoutSeconds { get; set; }

                    /// <summary>
                    /// <para>The maximum session lifetime. Unit: seconds. Default value: 21600.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>21600</para>
                    /// </summary>
                    [NameInMap("sessionMaxLifetimeSeconds")]
                    [Validation(Required=false)]
                    public int? SessionMaxLifetimeSeconds { get; set; }

                }

                /// <summary>
                /// <para>The NAS storage configuration.</para>
                /// </summary>
                [NameInMap("nasConfiguration")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigNasConfiguration NasConfiguration { get; set; }
                public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigNasConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The runtime user group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("groupId")]
                    [Validation(Required=false)]
                    public int? GroupId { get; set; }

                    /// <summary>
                    /// <para>The list of NAS mount points.</para>
                    /// </summary>
                    [NameInMap("mountPoints")]
                    [Validation(Required=false)]
                    public List<UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigNasConfigurationMountPoints> MountPoints { get; set; }
                    public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigNasConfigurationMountPoints : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to enable TLS.</para>
                        /// </summary>
                        [NameInMap("enableTls")]
                        [Validation(Required=false)]
                        public bool? EnableTls { get; set; }

                        /// <summary>
                        /// <para>The local mount directory.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/mnt/data</para>
                        /// </summary>
                        [NameInMap("mountDir")]
                        [Validation(Required=false)]
                        public string MountDir { get; set; }

                        /// <summary>
                        /// <para>The NAS server address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example.cn-hangzhou.nas.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("serverAddr")]
                        [Validation(Required=false)]
                        public string ServerAddr { get; set; }

                    }

                    /// <summary>
                    /// <para>The runtime user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public int? UserId { get; set; }

                }

                /// <summary>
                /// <para>The network configuration.</para>
                /// </summary>
                [NameInMap("networkConfiguration")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigNetworkConfiguration NetworkConfiguration { get; set; }
                public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigNetworkConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The network mode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PUBLIC</para>
                    /// </summary>
                    [NameInMap("networkMode")]
                    [Validation(Required=false)]
                    public string NetworkMode { get; set; }

                    /// <summary>
                    /// <para>The security group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-example</para>
                    /// </summary>
                    [NameInMap("securityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The list of vSwitch IDs.</para>
                    /// </summary>
                    [NameInMap("vSwitchIds")]
                    [Validation(Required=false)]
                    public List<string> VSwitchIds { get; set; }

                    /// <summary>
                    /// <para>The VPC ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-example</para>
                    /// </summary>
                    [NameInMap("vpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The OSS mount configuration.</para>
                /// </summary>
                [NameInMap("ossMountConfiguration")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigOssMountConfiguration OssMountConfiguration { get; set; }
                public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigOssMountConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The list of OSS mount points.</para>
                    /// </summary>
                    [NameInMap("mountPoints")]
                    [Validation(Required=false)]
                    public List<UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigOssMountConfigurationMountPoints> MountPoints { get; set; }
                    public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigOssMountConfigurationMountPoints : TeaModel {
                        /// <summary>
                        /// <para>The OSS bucket name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-bucket</para>
                        /// </summary>
                        [NameInMap("bucketName")]
                        [Validation(Required=false)]
                        public string BucketName { get; set; }

                        /// <summary>
                        /// <para>The OSS bucket path.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/data</para>
                        /// </summary>
                        [NameInMap("bucketPath")]
                        [Validation(Required=false)]
                        public string BucketPath { get; set; }

                        /// <summary>
                        /// <para>The OSS service endpoint.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://oss-cn-hangzhou.aliyuncs.com">https://oss-cn-hangzhou.aliyuncs.com</a></para>
                        /// </summary>
                        [NameInMap("endpoint")]
                        [Validation(Required=false)]
                        public string Endpoint { get; set; }

                        /// <summary>
                        /// <para>The local mount directory.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/mnt/data</para>
                        /// </summary>
                        [NameInMap("mountDir")]
                        [Validation(Required=false)]
                        public string MountDir { get; set; }

                        /// <summary>
                        /// <para>Specifies whether the mount point is read-only.</para>
                        /// </summary>
                        [NameInMap("readOnly")]
                        [Validation(Required=false)]
                        public bool? ReadOnly { get; set; }

                    }

                }

                /// <summary>
                /// <para>The parameter transform and result enhancement configuration.</para>
                /// </summary>
                [NameInMap("parameterTransformConfiguration")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigParameterTransformConfiguration ParameterTransformConfiguration { get; set; }
                public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigParameterTransformConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable parameter transform and result enhancement.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The reserved reference to the parameter transform and result enhancement rule set.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rules-1</para>
                    /// </summary>
                    [NameInMap("ruleSetId")]
                    [Validation(Required=false)]
                    public string RuleSetId { get; set; }

                    /// <summary>
                    /// <para>The transform rule version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The MCP proxy configuration.</para>
                /// </summary>
                [NameInMap("proxyConfiguration")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigProxyConfiguration ProxyConfiguration { get; set; }
                public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigProxyConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable the MCP proxy.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

                /// <summary>
                /// <para>The runtime and resource configuration.</para>
                /// </summary>
                [NameInMap("runtimeConfiguration")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigRuntimeConfiguration RuntimeConfiguration { get; set; }
                public class UpdateMcpTemplateConfigResponseBodyDataDeploymentConfigRuntimeConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The number of vCPUs. Default value: 0.25.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.25</para>
                    /// </summary>
                    [NameInMap("cpu")]
                    [Validation(Required=false)]
                    public double? Cpu { get; set; }

                    /// <summary>
                    /// <para>The ephemeral disk size. Unit: MB. Valid values: 512 and 10240.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>512</para>
                    /// </summary>
                    [NameInMap("diskSize")]
                    [Validation(Required=false)]
                    public int? DiskSize { get; set; }

                    /// <summary>
                    /// <para>The environment variables.</para>
                    /// </summary>
                    [NameInMap("environmentVariables")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> EnvironmentVariables { get; set; }

                    /// <summary>
                    /// <para>The ARN of the RAM role used by user code to access downstream Alibaba Cloud resources.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:ram::1234567890123456:role/agentcore-mcp-execution</para>
                    /// </summary>
                    [NameInMap("executionRoleArn")]
                    [Validation(Required=false)]
                    public string ExecutionRoleArn { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent requests per instance. Default value: 200.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("instanceConcurrency")]
                    [Validation(Required=false)]
                    public int? InstanceConcurrency { get; set; }

                    /// <summary>
                    /// <para>The memory size. Unit: MB. Default value: 512.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>512</para>
                    /// </summary>
                    [NameInMap("memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                    /// <summary>
                    /// <para>The service port. Default value: 9000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9000</para>
                    /// </summary>
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The function timeout period. Unit: seconds. Default value: 300.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                }

            }

            /// <summary>
            /// <para>The description of the MCP service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>An MCP service for querying the knowledge base</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The MCP service endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/mcp">https://example.com/mcp</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The Function Compute function name that corresponds to the code deployment MCP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agentcore-mcp-example</para>
            /// </summary>
            [NameInMap("functionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The marketplace template from which the MCP service originates.</para>
            /// </summary>
            [NameInMap("marketSource")]
            [Validation(Required=false)]
            public UpdateMcpTemplateConfigResponseBodyDataMarketSource MarketSource { get; set; }
            public class UpdateMcpTemplateConfigResponseBodyDataMarketSource : TeaModel {
                /// <summary>
                /// <para>The MCP marketplace template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>market-1</para>
                /// </summary>
                [NameInMap("marketItemId")]
                [Validation(Required=false)]
                public string MarketItemId { get; set; }

            }

            /// <summary>
            /// <para>The MCP server ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-server-id</para>
            /// </summary>
            [NameInMap("mcpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

            /// <summary>
            /// <para>The MCP service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-mcp-server</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The official usage tag, managed by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KNOWLEDGE_BASE</para>
            /// </summary>
            [NameInMap("officialTag")]
            [Validation(Required=false)]
            public string OfficialTag { get; set; }

            /// <summary>
            /// <para>The MCP protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StreamableHTTP</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The MCP service status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason why the MCP service is in the current status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Code package deployment failed</para>
            /// </summary>
            [NameInMap("statusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The template version and input schema bound to the MCP service.</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public UpdateMcpTemplateConfigResponseBodyDataTemplate Template { get; set; }
            public class UpdateMcpTemplateConfigResponseBodyDataTemplate : TeaModel {
                /// <summary>
                /// <para>The template version that is currently applied to the MCP service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("appliedTemplateVersion")]
                [Validation(Required=false)]
                public string AppliedTemplateVersion { get; set; }

                /// <summary>
                /// <para>The latest template version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.0</para>
                /// </summary>
                [NameInMap("latestTemplateVersion")]
                [Validation(Required=false)]
                public string LatestTemplateVersion { get; set; }

                /// <summary>
                /// <para>The template schema version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("schemaVersion")]
                [Validation(Required=false)]
                public string SchemaVersion { get; set; }

                /// <summary>
                /// <para>The template input schema, represented as a JSON Schema string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;addresses&quot;:{&quot;type&quot;:&quot;array&quot;,&quot;items&quot;:{&quot;type&quot;:&quot;string&quot;}}}}</para>
                /// </summary>
                [NameInMap("templateInputSchema")]
                [Validation(Required=false)]
                public string TemplateInputSchema { get; set; }

                /// <summary>
                /// <para>Indicates whether a template version update is available.</para>
                /// </summary>
                [NameInMap("updateAvailable")]
                [Validation(Required=false)]
                public bool? UpdateAvailable { get; set; }

            }

            /// <summary>
            /// <para>The MCP type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DIRECT_PROXY: direct proxy.</description></item>
            /// <item><description>HTTP_TO_MCP: HTTP-to-MCP conversion.</description></item>
            /// <item><description>CODE_PACKAGE: code deployment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CODE_PACKAGE</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Indicates whether the MCP service is still bound by the usage constraints of the official template.</para>
            /// </summary>
            [NameInMap("usageActive")]
            [Validation(Required=false)]
            public bool? UsageActive { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
