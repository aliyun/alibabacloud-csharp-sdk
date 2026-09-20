// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateMcpTemplateConfigRequest : TeaModel {
        /// <summary>
        /// <para>The MCP configuration to update by the specified template version. The configuration must conform to the input schema of the template.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateMcpTemplateConfigRequestBody Body { get; set; }
        public class UpdateMcpTemplateConfigRequestBody : TeaModel {
            /// <summary>
            /// <para>The list of remote MCP service addresses.</para>
            /// </summary>
            [NameInMap("addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            /// <summary>
            /// <para>The MCP authentication configuration.</para>
            /// </summary>
            [NameInMap("auth")]
            [Validation(Required=false)]
            public UpdateMcpTemplateConfigRequestBodyAuth Auth { get; set; }
            public class UpdateMcpTemplateConfigRequestBodyAuth : TeaModel {
                /// <summary>
                /// <para>The backend authentication configuration for direct proxy.</para>
                /// </summary>
                [NameInMap("directProxy")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigRequestBodyAuthDirectProxy DirectProxy { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyAuthDirectProxy : TeaModel {
                    /// <summary>
                    /// <para>The name of the backend authentication request header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Authorization</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value of the backend authentication request header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-api-key</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether to enable this configuration.</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The list of backend authentication configurations for HTTP-to-MCP conversion.</para>
                /// </summary>
                [NameInMap("httpToMcp")]
                [Validation(Required=false)]
                public List<UpdateMcpTemplateConfigRequestBodyAuthHttpToMcp> HttpToMcp { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyAuthHttpToMcp : TeaModel {
                    /// <summary>
                    /// <para>The backend authentication credential.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-api-key</para>
                    /// </summary>
                    [NameInMap("credential")]
                    [Validation(Required=false)]
                    public string Credential { get; set; }

                    /// <summary>
                    /// <para>The backend authentication configuration ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>api-key-auth</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The API key parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>X-API-Key</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The position where the API key is passed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>header</para>
                    /// </summary>
                    [NameInMap("position")]
                    [Validation(Required=false)]
                    public string Position { get; set; }

                    /// <summary>
                    /// <para>The backend authentication type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>apiKey</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The deployment configuration for code-deployed MCP.</para>
            /// </summary>
            [NameInMap("deploymentConfig")]
            [Validation(Required=false)]
            public UpdateMcpTemplateConfigRequestBodyDeploymentConfig DeploymentConfig { get; set; }
            public class UpdateMcpTemplateConfigRequestBodyDeploymentConfig : TeaModel {
                /// <summary>
                /// <para>The MCP ingress access control settings.</para>
                /// </summary>
                [NameInMap("accessControl")]
                [Validation(Required=false)]
                public UpdateMcpTemplateConfigRequestBodyDeploymentConfigAccessControl AccessControl { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigAccessControl : TeaModel {
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
                    /// <item><description>CREDENTIAL: AgentCore credential-based access.</description></item>
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
                public UpdateMcpTemplateConfigRequestBodyDeploymentConfigAgentIdentityConfiguration AgentIdentityConfiguration { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigAgentIdentityConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable authorization.</para>
                    /// </summary>
                    [NameInMap("authorizationEnabled")]
                    [Validation(Required=false)]
                    public bool? AuthorizationEnabled { get; set; }

                    /// <summary>
                    /// <para>The ARN of the credential provider.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:agentidentity:cn-hangzhou:1234567890123456:provider/example</para>
                    /// </summary>
                    [NameInMap("credentialProviderArn")]
                    [Validation(Required=false)]
                    public string CredentialProviderArn { get; set; }

                    /// <summary>
                    /// <para>The type of the credential provider.</para>
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
                /// <para>The artifact type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Code: ZIP code package.</description></item>
                /// <item><description>Container: custom container.</description></item>
                /// </list>
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
                public UpdateMcpTemplateConfigRequestBodyDeploymentConfigCodeConfiguration CodeConfiguration { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigCodeConfiguration : TeaModel {
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
                    /// <para>The full startup command, with each argument passed in order by parameter boundary. For example, when using supergateway to start a stdio MCP, pass supergateway, --stdio, the full subcommand, and the remaining arguments.</para>
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
                public UpdateMcpTemplateConfigRequestBodyDeploymentConfigContainerConfiguration ContainerConfiguration { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigContainerConfiguration : TeaModel {
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
                    /// <para>The MCP runtime mode for the custom container. The custom container must expose a standard MCP endpoint on its own. Set this parameter to SELF_HOSTED.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELF_HOSTED</para>
                    /// </summary>
                    [NameInMap("mcpRuntimeMode")]
                    [Validation(Required=false)]
                    public string McpRuntimeMode { get; set; }

                    /// <summary>
                    /// <para>The container source type. Currently fixed to CONTAINER_IMAGE.</para>
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
                public UpdateMcpTemplateConfigRequestBodyDeploymentConfigHookConfiguration HookConfiguration { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigHookConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The hooks executed in array order: PRE_LIST_TOOLS, PRE_CALL_TOOL, POST_LIST_TOOLS, and POST_CALL_TOOL.</para>
                    /// </summary>
                    [NameInMap("hooks")]
                    [Validation(Required=false)]
                    public List<UpdateMcpTemplateConfigRequestBodyDeploymentConfigHookConfigurationHooks> Hooks { get; set; }
                    public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigHookConfigurationHooks : TeaModel {
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
                        /// <para>Log MCP tool calls</para>
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
                        /// <para>The timeout period. Unit: milliseconds.</para>
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
                public UpdateMcpTemplateConfigRequestBodyDeploymentConfigLogConfiguration LogConfiguration { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigLogConfiguration : TeaModel {
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
                    /// <para>The log segmentation start rule for Function Compute.</para>
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
                    /// <para>The Log Service project name.</para>
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
                public UpdateMcpTemplateConfigRequestBodyDeploymentConfigMcpConfiguration McpConfiguration { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigMcpConfiguration : TeaModel {
                    /// <summary>
                    /// <para>For example, /mcp or /sse.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/mcp</para>
                    /// </summary>
                    [NameInMap("endpointPath")]
                    [Validation(Required=false)]
                    public string EndpointPath { get; set; }

                    /// <summary>
                    /// <para>Currently fixed to 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sessionConcurrencyPerInstance")]
                    [Validation(Required=false)]
                    public int? SessionConcurrencyPerInstance { get; set; }

                    /// <summary>
                    /// <para>The session idle timeout. Unit: seconds. Default value: 1800.</para>
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
                public UpdateMcpTemplateConfigRequestBodyDeploymentConfigNasConfiguration NasConfiguration { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigNasConfiguration : TeaModel {
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
                    public List<UpdateMcpTemplateConfigRequestBodyDeploymentConfigNasConfigurationMountPoints> MountPoints { get; set; }
                    public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigNasConfigurationMountPoints : TeaModel {
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
                public UpdateMcpTemplateConfigRequestBodyDeploymentConfigNetworkConfiguration NetworkConfiguration { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigNetworkConfiguration : TeaModel {
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
                public UpdateMcpTemplateConfigRequestBodyDeploymentConfigOssMountConfiguration OssMountConfiguration { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigOssMountConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The list of OSS mount points.</para>
                    /// </summary>
                    [NameInMap("mountPoints")]
                    [Validation(Required=false)]
                    public List<UpdateMcpTemplateConfigRequestBodyDeploymentConfigOssMountConfigurationMountPoints> MountPoints { get; set; }
                    public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigOssMountConfigurationMountPoints : TeaModel {
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
                public UpdateMcpTemplateConfigRequestBodyDeploymentConfigParameterTransformConfiguration ParameterTransformConfiguration { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigParameterTransformConfiguration : TeaModel {
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
                public UpdateMcpTemplateConfigRequestBodyDeploymentConfigProxyConfiguration ProxyConfiguration { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigProxyConfiguration : TeaModel {
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
                public UpdateMcpTemplateConfigRequestBodyDeploymentConfigRuntimeConfiguration RuntimeConfiguration { get; set; }
                public class UpdateMcpTemplateConfigRequestBodyDeploymentConfigRuntimeConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The CPU specification. Unit: cores. Default value: 0.25.</para>
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
                    /// <para>Default value: 200.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("instanceConcurrency")]
                    [Validation(Required=false)]
                    public int? InstanceConcurrency { get; set; }

                    /// <summary>
                    /// <para>Unit: MB. Default value: 512.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>512</para>
                    /// </summary>
                    [NameInMap("memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                    /// <summary>
                    /// <para>Default value: 9000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9000</para>
                    /// </summary>
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>Unit: seconds. Default value: 300.</para>
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
            /// <para>The MCP service description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>An MCP service for querying knowledge bases</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The OpenAPI configuration for HTTP-to-MCP conversion, represented as a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;openapi&quot;:&quot;3.0.3&quot;,&quot;info&quot;:{&quot;title&quot;:&quot;Knowledge API&quot;,&quot;version&quot;:&quot;1.0.0&quot;},&quot;paths&quot;:{}}</para>
            /// </summary>
            [NameInMap("swaggerConfig")]
            [Validation(Required=false)]
            public string SwaggerConfig { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotency of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The template version used for this update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("templateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
