// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateMcpRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateMcpRequestBody Body { get; set; }
        public class CreateMcpRequestBody : TeaModel {
            /// <summary>
            /// <para>The list of MCP service addresses.</para>
            /// </summary>
            [NameInMap("addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            /// <summary>
            /// <para>The backend authentication configuration. When enabled is set to true: for DIRECT_PROXY, specify directProxy (name and value); for HTTP_TO_MCP, specify the httpToMcp array (each item includes id, type, and credential; apiKey also requires position and name). Multiple authentication objects are supported, and the first one is the default upstream credential. HTTP_TO_MCP credentials are merged into the securitySchemes of the Swagger document.</para>
            /// </summary>
            [NameInMap("auth")]
            [Validation(Required=false)]
            public CreateMcpRequestBodyAuth Auth { get; set; }
            public class CreateMcpRequestBodyAuth : TeaModel {
                /// <summary>
                /// <para>The caller API key authentication configuration for the code package MCP.</para>
                /// </summary>
                [NameInMap("codePackage")]
                [Validation(Required=false)]
                public CreateMcpRequestBodyAuthCodePackage CodePackage { get; set; }
                public class CreateMcpRequestBodyAuthCodePackage : TeaModel {
                    /// <summary>
                    /// <para>The API key used to validate the MCP caller.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-api-key</para>
                    /// </summary>
                    [NameInMap("apiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    /// <summary>
                    /// <para>The name of the request header that carries the API key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>X-API-Key</para>
                    /// </summary>
                    [NameInMap("headerName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                }

                /// <summary>
                /// <para>The authentication configuration for the direct proxy.</para>
                /// </summary>
                [NameInMap("directProxy")]
                [Validation(Required=false)]
                public CreateMcpRequestBodyAuthDirectProxy DirectProxy { get; set; }
                public class CreateMcpRequestBodyAuthDirectProxy : TeaModel {
                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp-example</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value of the authentication parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-credential</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether to enable the configuration.</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The list of authentication configurations for HTTP_TO_MCP.</para>
                /// </summary>
                [NameInMap("httpToMcp")]
                [Validation(Required=false)]
                public List<CreateMcpRequestBodyAuthHttpToMcp> HttpToMcp { get; set; }
                public class CreateMcpRequestBodyAuthHttpToMcp : TeaModel {
                    /// <summary>
                    /// <para>The authentication credential.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-credential</para>
                    /// </summary>
                    [NameInMap("credential")]
                    [Validation(Required=false)]
                    public string Credential { get; set; }

                    /// <summary>
                    /// <para>The ID of the authentication scheme.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp-1234567890abcdef</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp-example</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The position of the credential.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>header</para>
                    /// </summary>
                    [NameInMap("position")]
                    [Validation(Required=false)]
                    public string Position { get; set; }

                    /// <summary>
                    /// <para>The type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>basic</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>Optional. Valid values: legacy and modern. This parameter is used only for DIRECT_PROXY. If omitted for direct proxy, the existing default behavior is maintained and no automatic upgrade is performed. The modern value does not support Server-Sent Events (SSE). You can use the backendMcpProtocol and protocol recommended by ProbeMcpOrigin to configure backend access, which does not limit the external protocol conversion compatibility of the gateway. This parameter is not required for CODE_PACKAGE. Valid inputs are ignored and not saved. Function Compute (FC) session affinity is configured only based on protocol and DeploymentConfig.McpConfiguration.SessionMode, and the gateway protocol is determined by the successful probing result after FC deployment. Valid values for HTTP_TO_MCP are ignored and not saved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>modern</para>
            /// </summary>
            [NameInMap("backendMcpProtocol")]
            [Validation(Required=false)]
            public string BackendMcpProtocol { get; set; }

            /// <summary>
            /// <para>The custom tags. Multiple tags are supported.</para>
            /// </summary>
            [NameInMap("customTags")]
            [Validation(Required=false)]
            public List<string> CustomTags { get; set; }

            /// <summary>
            /// <para>The code deployment configuration. Required when Type is set to CODE_PACKAGE. When creating a code artifact, you must specify either CodeConfiguration.CodePackageToken or CodePackageUrl, but not both. CodePackageUrl only supports public Alibaba Cloud OSS HTTP(S) URLs.</para>
            /// </summary>
            [NameInMap("deploymentConfig")]
            [Validation(Required=false)]
            public CreateMcpRequestBodyDeploymentConfig DeploymentConfig { get; set; }
            public class CreateMcpRequestBodyDeploymentConfig : TeaModel {
                /// <summary>
                /// <para>The MCP entry access control configuration.</para>
                /// </summary>
                [NameInMap("accessControl")]
                [Validation(Required=false)]
                public CreateMcpRequestBodyDeploymentConfigAccessControl AccessControl { get; set; }
                public class CreateMcpRequestBodyDeploymentConfigAccessControl : TeaModel {
                    /// <summary>
                    /// <para>The AgentCore Credential referenced when the mode is CREDENTIAL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>credential-id</para>
                    /// </summary>
                    [NameInMap("credentialId")]
                    [Validation(Required=false)]
                    public string CredentialId { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable entry access control.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>ANONYMOUS indicates anonymous access. CREDENTIAL indicates the use of AgentCore access credentials.</para>
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
                public CreateMcpRequestBodyDeploymentConfigAgentIdentityConfiguration AgentIdentityConfiguration { get; set; }
                public class CreateMcpRequestBodyDeploymentConfigAgentIdentityConfiguration : TeaModel {
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
                /// <para>The artifact type. A value of Code indicates a ZIP code package, and a value of Container indicates a custom container.</para>
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
                public CreateMcpRequestBodyDeploymentConfigCodeConfiguration CodeConfiguration { get; set; }
                public class CreateMcpRequestBodyDeploymentConfigCodeConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The temporary code package token returned by GetMcpCodePackageUploadUrl. It is used to create a code deployment after a presigned upload is completed. You must specify either this parameter or CodePackageUrl.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>upload-token</para>
                    /// </summary>
                    [NameInMap("codePackageToken")]
                    [Validation(Required=false)]
                    public string CodePackageToken { get; set; }

                    /// <summary>
                    /// <para>The public Alibaba Cloud OSS HTTP(S) URL that can be directly passed when creating a code deployment. You must specify either this parameter or CodePackageToken. This parameter is only supported by CreateMcp, and is not supported for update and query operations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example-bucket.oss-cn-hangzhou.aliyuncs.com/server.zip">https://example-bucket.oss-cn-hangzhou.aliyuncs.com/server.zip</a></para>
                    /// </summary>
                    [NameInMap("codePackageUrl")]
                    [Validation(Required=false)]
                    public string CodePackageUrl { get; set; }

                    /// <summary>
                    /// <para>The complete startup command, passed sequentially by parameter boundaries. For example, when using supergateway to start a stdio MCP, pass supergateway, --stdio, the complete subcommand, and the remaining parameters.</para>
                    /// </summary>
                    [NameInMap("command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                    /// <summary>
                    /// <para>The runtime of the code package. Valid values: python3.13, nodejs22, and java17.</para>
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
                public CreateMcpRequestBodyDeploymentConfigContainerConfiguration ContainerConfiguration { get; set; }
                public class CreateMcpRequestBodyDeploymentConfigContainerConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The ID of the ACR instance.</para>
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
                    /// <para>The entrypoint parameters of the container.</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public List<string> Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The URL of the container image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>registry.cn-hangzhou.aliyuncs.com/example/mcp:1.0.0</para>
                    /// </summary>
                    [NameInMap("image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// <para>The type of the image registry.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACR</para>
                    /// </summary>
                    [NameInMap("imageRegistryType")]
                    [Validation(Required=false)]
                    public string ImageRegistryType { get; set; }

                    /// <summary>
                    /// <para>The MCP runtime mode. Custom containers must expose the standard MCP by themselves. Set the value to SELF_HOSTED.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELF_HOSTED</para>
                    /// </summary>
                    [NameInMap("mcpRuntimeMode")]
                    [Validation(Required=false)]
                    public string McpRuntimeMode { get; set; }

                    /// <summary>
                    /// <para>The custom image registry configuration. This parameter takes effect only when ImageRegistryType is set to CUSTOM. It is used to configure image pull authentication, TLS certificate verification, and the private network for image pulling.</para>
                    /// </summary>
                    [NameInMap("registryConfig")]
                    [Validation(Required=false)]
                    public CreateMcpRequestBodyDeploymentConfigContainerConfigurationRegistryConfig RegistryConfig { get; set; }
                    public class CreateMcpRequestBodyDeploymentConfigContainerConfigurationRegistryConfig : TeaModel {
                        /// <summary>
                        /// <para>The authentication configuration of the image registry. Specify this parameter when the image registry requires username and password authentication.</para>
                        /// </summary>
                        [NameInMap("authConfig")]
                        [Validation(Required=false)]
                        public CreateMcpRequestBodyDeploymentConfigContainerConfigurationRegistryConfigAuthConfig AuthConfig { get; set; }
                        public class CreateMcpRequestBodyDeploymentConfigContainerConfigurationRegistryConfigAuthConfig : TeaModel {
                            /// <summary>
                            /// <para>The password for the image registry. The password is encrypted and stored on the server, and is not returned in query responses. If you omit this parameter during an update, the existing password is retained.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>example-password</para>
                            /// </summary>
                            [NameInMap("password")]
                            [Validation(Required=false)]
                            public string Password { get; set; }

                            /// <summary>
                            /// <para>The username for the image registry.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>puller</para>
                            /// </summary>
                            [NameInMap("userName")]
                            [Validation(Required=false)]
                            public string UserName { get; set; }

                        }

                        /// <summary>
                        /// <para>The TLS certificate verification configuration of the image registry.</para>
                        /// </summary>
                        [NameInMap("certConfig")]
                        [Validation(Required=false)]
                        public CreateMcpRequestBodyDeploymentConfigContainerConfigurationRegistryConfigCertConfig CertConfig { get; set; }
                        public class CreateMcpRequestBodyDeploymentConfigContainerConfigurationRegistryConfigCertConfig : TeaModel {
                            /// <summary>
                            /// <para>Specifies whether to skip the verification of the TLS certificate of the image registry. A value of true indicates that the verification is skipped. Default value: false.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("insecure")]
                            [Validation(Required=false)]
                            public bool? Insecure { get; set; }

                            /// <summary>
                            /// <para>The Base64-encoded root CA certificate of the image registry, which is used to verify self-signed certificates.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>LS0tLS1CRUdJTi...</para>
                            /// </summary>
                            [NameInMap("rootCaCertBase64")]
                            [Validation(Required=false)]
                            public string RootCaCertBase64 { get; set; }

                        }

                        /// <summary>
                        /// <para>The network configuration for image pulling. Specify this parameter when the image registry is accessible only within a VPC. Function Compute pulls images through this network.</para>
                        /// </summary>
                        [NameInMap("networkConfig")]
                        [Validation(Required=false)]
                        public CreateMcpRequestBodyDeploymentConfigContainerConfigurationRegistryConfigNetworkConfig NetworkConfig { get; set; }
                        public class CreateMcpRequestBodyDeploymentConfigContainerConfigurationRegistryConfigNetworkConfig : TeaModel {
                            /// <summary>
                            /// <para>The ID of the security group used to pull images.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>sg-example</para>
                            /// </summary>
                            [NameInMap("securityGroupId")]
                            [Validation(Required=false)]
                            public string SecurityGroupId { get; set; }

                            /// <summary>
                            /// <para>The ID of the vSwitch used to pull images.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>vsw-example</para>
                            /// </summary>
                            [NameInMap("vSwitchId")]
                            [Validation(Required=false)]
                            public string VSwitchId { get; set; }

                            /// <summary>
                            /// <para>The ID of the VPC where the image registry resides.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>vpc-example</para>
                            /// </summary>
                            [NameInMap("vpcId")]
                            [Validation(Required=false)]
                            public string VpcId { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The source type of the container. This parameter is fixed to CONTAINER_IMAGE.</para>
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
                public CreateMcpRequestBodyDeploymentConfigHookConfiguration HookConfiguration { get; set; }
                public class CreateMcpRequestBodyDeploymentConfigHookConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The list of hooks executed in array order, including PRE_LIST_TOOLS, PRE_CALL_TOOL, POST_LIST_TOOLS, and POST_CALL_TOOL hooks.</para>
                    /// </summary>
                    [NameInMap("hooks")]
                    [Validation(Required=false)]
                    public List<CreateMcpRequestBodyDeploymentConfigHookConfigurationHooks> Hooks { get; set; }
                    public class CreateMcpRequestBodyDeploymentConfigHookConfigurationHooks : TeaModel {
                        /// <summary>
                        /// <para>The API version of the hook.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.0</para>
                        /// </summary>
                        [NameInMap("apiVersion")]
                        [Validation(Required=false)]
                        public string ApiVersion { get; set; }

                        /// <summary>
                        /// <para>The description of the hook.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Record MCP tool invocation</para>
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
                        /// <para>The request headers of the hook.</para>
                        /// </summary>
                        [NameInMap("headers")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> Headers { get; set; }

                        /// <summary>
                        /// <para>The timeout period in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3000</para>
                        /// </summary>
                        [NameInMap("timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                        /// <summary>
                        /// <para>The callback URL of the hook.</para>
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
                public CreateMcpRequestBodyDeploymentConfigLogConfiguration LogConfiguration { get; set; }
                public class CreateMcpRequestBodyDeploymentConfigLogConfiguration : TeaModel {
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
                    /// <para>The start rule for Function Compute log segmentation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DefaultRegex</para>
                    /// </summary>
                    [NameInMap("logBeginRule")]
                    [Validation(Required=false)]
                    public string LogBeginRule { get; set; }

                    /// <summary>
                    /// <para>The name of the Logstore.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp-logs</para>
                    /// </summary>
                    [NameInMap("logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    /// <summary>
                    /// <para>The name of the Simple Log Service project.</para>
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
                public CreateMcpRequestBodyDeploymentConfigMcpConfiguration McpConfiguration { get; set; }
                public class CreateMcpRequestBodyDeploymentConfigMcpConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Example: /mcp or /sse.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/mcp</para>
                    /// </summary>
                    [NameInMap("endpointPath")]
                    [Validation(Required=false)]
                    public string EndpointPath { get; set; }

                    /// <summary>
                    /// <para>Currently fixed at 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sessionConcurrencyPerInstance")]
                    [Validation(Required=false)]
                    public int? SessionConcurrencyPerInstance { get; set; }

                    /// <summary>
                    /// <para>Unit: seconds. Default value: 1800.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1800</para>
                    /// </summary>
                    [NameInMap("sessionIdleTimeoutSeconds")]
                    [Validation(Required=false)]
                    public int? SessionIdleTimeoutSeconds { get; set; }

                    /// <summary>
                    /// <para>Unit: seconds. Default value: 21600.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>21600</para>
                    /// </summary>
                    [NameInMap("sessionMaxLifetimeSeconds")]
                    [Validation(Required=false)]
                    public int? SessionMaxLifetimeSeconds { get; set; }

                    /// <summary>
                    /// <para>Applicable only to StreamableHTTP. The default value is STATEFUL when created. If omitted during an update, the original value is retained. STATELESS disables Function Compute session affinity, and the stdio gateway does not enable stateful mode. Native HTTP services must support stateless MCP themselves.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STATEFUL</para>
                    /// </summary>
                    [NameInMap("sessionMode")]
                    [Validation(Required=false)]
                    public string SessionMode { get; set; }

                }

                /// <summary>
                /// <para>The NAS storage configuration.</para>
                /// </summary>
                [NameInMap("nasConfiguration")]
                [Validation(Required=false)]
                public CreateMcpRequestBodyDeploymentConfigNasConfiguration NasConfiguration { get; set; }
                public class CreateMcpRequestBodyDeploymentConfigNasConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("groupId")]
                    [Validation(Required=false)]
                    public int? GroupId { get; set; }

                    /// <summary>
                    /// <para>The list of NAS mount targets.</para>
                    /// </summary>
                    [NameInMap("mountPoints")]
                    [Validation(Required=false)]
                    public List<CreateMcpRequestBodyDeploymentConfigNasConfigurationMountPoints> MountPoints { get; set; }
                    public class CreateMcpRequestBodyDeploymentConfigNasConfigurationMountPoints : TeaModel {
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
                        /// <para>The service address of the NAS file system.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example.cn-hangzhou.nas.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("serverAddr")]
                        [Validation(Required=false)]
                        public string ServerAddr { get; set; }

                    }

                    /// <summary>
                    /// <para>The user ID.</para>
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
                public CreateMcpRequestBodyDeploymentConfigNetworkConfiguration NetworkConfiguration { get; set; }
                public class CreateMcpRequestBodyDeploymentConfigNetworkConfiguration : TeaModel {
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
                    /// <para>The ID of the security group.</para>
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
                    /// <para>The ID of the virtual private cloud (VPC).</para>
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
                public CreateMcpRequestBodyDeploymentConfigOssMountConfiguration OssMountConfiguration { get; set; }
                public class CreateMcpRequestBodyDeploymentConfigOssMountConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The list of OSS mount targets.</para>
                    /// </summary>
                    [NameInMap("mountPoints")]
                    [Validation(Required=false)]
                    public List<CreateMcpRequestBodyDeploymentConfigOssMountConfigurationMountPoints> MountPoints { get; set; }
                    public class CreateMcpRequestBodyDeploymentConfigOssMountConfigurationMountPoints : TeaModel {
                        /// <summary>
                        /// <para>The name of the OSS bucket.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-bucket</para>
                        /// </summary>
                        [NameInMap("bucketName")]
                        [Validation(Required=false)]
                        public string BucketName { get; set; }

                        /// <summary>
                        /// <para>The path in the OSS bucket.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/data</para>
                        /// </summary>
                        [NameInMap("bucketPath")]
                        [Validation(Required=false)]
                        public string BucketPath { get; set; }

                        /// <summary>
                        /// <para>The endpoint of the OSS service.</para>
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
                        /// <para>Specifies whether the mount target is read-only.</para>
                        /// </summary>
                        [NameInMap("readOnly")]
                        [Validation(Required=false)]
                        public bool? ReadOnly { get; set; }

                    }

                }

                /// <summary>
                /// <para>The configuration for parameter transformation and result augmentation.</para>
                /// </summary>
                [NameInMap("parameterTransformConfiguration")]
                [Validation(Required=false)]
                public CreateMcpRequestBodyDeploymentConfigParameterTransformConfiguration ParameterTransformConfiguration { get; set; }
                public class CreateMcpRequestBodyDeploymentConfigParameterTransformConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable parameter transformation and result augmentation.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The reference to the reserved parameter transformation and result augmentation rule set.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rules-1</para>
                    /// </summary>
                    [NameInMap("ruleSetId")]
                    [Validation(Required=false)]
                    public string RuleSetId { get; set; }

                    /// <summary>
                    /// <para>The version of the transformation rule.</para>
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
                public CreateMcpRequestBodyDeploymentConfigProxyConfiguration ProxyConfiguration { get; set; }
                public class CreateMcpRequestBodyDeploymentConfigProxyConfiguration : TeaModel {
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
                public CreateMcpRequestBodyDeploymentConfigRuntimeConfiguration RuntimeConfiguration { get; set; }
                public class CreateMcpRequestBodyDeploymentConfigRuntimeConfiguration : TeaModel {
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
                    /// <para>The size of the ephemeral disk. Unit: MB. Valid values: 512 and 10240.</para>
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
                    /// <para>The ARN of the RAM role used when user code accesses downstream Alibaba Cloud resources.</para>
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
                    /// <para>The memory specification. Unit: MB. Default value: 512.</para>
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
                    /// <para>The timeout period of the function. Unit: seconds. Default value: 300.</para>
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
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A sample description to illustrate the purpose of the resource</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the MCP service.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-mcp-server</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Optional. The format is YYYY-MM-DD. You can use the originProtocolVersion recommended by ProbeMcpOrigin. You can specify this parameter during creation and modify it during updates. If omitted during an update, the current value is retained. This parameter only saves and displays the origin protocol date metadata. It is not a software version, does not limit the external protocol of the gateway, and does not control backend requests. If omitted during creation, the value is null, no default value is set, and the date is not restricted by legacy or modern. Valid dates for HTTP_TO_MCP are ignored and not saved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-26</para>
            /// </summary>
            [NameInMap("originProtocolVersion")]
            [Validation(Required=false)]
            public string OriginProtocolVersion { get; set; }

            /// <summary>
            /// <para>The access permission mode. PUBLIC indicates public access, and CONTROLLED indicates that access is controlled based on permission rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONTROLLED</para>
            /// </summary>
            [NameInMap("permissionMode")]
            [Validation(Required=false)]
            public string PermissionMode { get; set; }

            /// <summary>
            /// <para>The MCP protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SSE</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>Specify this field if the type is HTTP_TO_MCP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;object&quot;}</para>
            /// </summary>
            [NameInMap("swaggerConfig")]
            [Validation(Required=false)]
            public string SwaggerConfig { get; set; }

            /// <summary>
            /// <para>The type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DIRECT_PROXY</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The source and tool selection for a virtual MCP. This is used only when the type is VIRTUAL. The tool list can only be updated manually.</para>
            /// </summary>
            [NameInMap("virtualConfig")]
            [Validation(Required=false)]
            public CreateMcpRequestBodyVirtualConfig VirtualConfig { get; set; }
            public class CreateMcpRequestBodyVirtualConfig : TeaModel {
                /// <summary>
                /// <para>Required for virtual MCP. Specify 1 to 10 different source MCPs.</para>
                /// </summary>
                [NameInMap("sources")]
                [Validation(Required=false)]
                public List<CreateMcpRequestBodyVirtualConfigSources> Sources { get; set; }
                public class CreateMcpRequestBodyVirtualConfigSources : TeaModel {
                    /// <summary>
                    /// <para>Required for virtual MCP. The ID of the source MCP in the current workspace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp-server-source-1</para>
                    /// </summary>
                    [NameInMap("mcpServerId")]
                    [Validation(Required=false)]
                    public string McpServerId { get; set; }

                    /// <summary>
                    /// <para>Required for virtual MCP. The manually selected tools. Specify at least one tool for each source, and up to 100 tools in total across all sources.</para>
                    /// </summary>
                    [NameInMap("tools")]
                    [Validation(Required=false)]
                    public List<CreateMcpRequestBodyVirtualConfigSourcesTools> Tools { get; set; }
                    public class CreateMcpRequestBodyVirtualConfigSourcesTools : TeaModel {
                        /// <summary>
                        /// <para>Required for virtual MCP. The definition digest obtained from the ListMcpTools operation or validation result of the source MCP. The client passes this value back as-is without calculating it. This value is used only as a baseline for manual update validation and does not freeze the runtime schema.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855</para>
                        /// </summary>
                        [NameInMap("expectedDigest")]
                        [Validation(Required=false)]
                        public string ExpectedDigest { get; set; }

                        /// <summary>
                        /// <para>Required for virtual MCP. The name of the source tool.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>get-current-time</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The reserved query request identifier. The current console backend does not read this parameter and does not provide idempotency guarantees for deduplication or restoring the original processing result based on this identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426614174000</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
