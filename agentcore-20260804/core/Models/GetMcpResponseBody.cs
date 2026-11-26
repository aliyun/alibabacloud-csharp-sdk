// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetMcpResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMcpResponseBodyData Data { get; set; }
        public class GetMcpResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of MCP service addresses.</para>
            /// </summary>
            [NameInMap("addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            /// <summary>
            /// <para>The applied revision number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("appliedRevision")]
            [Validation(Required=false)]
            public long? AppliedRevision { get; set; }

            /// <summary>
            /// <para>The applied sources and tool selection.</para>
            /// </summary>
            [NameInMap("appliedVirtualConfig")]
            [Validation(Required=false)]
            public GetMcpResponseBodyDataAppliedVirtualConfig AppliedVirtualConfig { get; set; }
            public class GetMcpResponseBodyDataAppliedVirtualConfig : TeaModel {
                /// <summary>
                /// <para>Required for virtual MCPs. Specify 1 to 10 different source MCPs.</para>
                /// </summary>
                [NameInMap("sources")]
                [Validation(Required=false)]
                public List<GetMcpResponseBodyDataAppliedVirtualConfigSources> Sources { get; set; }
                public class GetMcpResponseBodyDataAppliedVirtualConfigSources : TeaModel {
                    /// <summary>
                    /// <para>Required for virtual MCPs. The ID of the source MCP in the current workspace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp-server-source-1</para>
                    /// </summary>
                    [NameInMap("mcpServerId")]
                    [Validation(Required=false)]
                    public string McpServerId { get; set; }

                    /// <summary>
                    /// <para>Required for virtual MCPs. The manually selected tools. Specify at least one tool for each source, up to 100 tools across all sources.</para>
                    /// </summary>
                    [NameInMap("tools")]
                    [Validation(Required=false)]
                    public List<GetMcpResponseBodyDataAppliedVirtualConfigSourcesTools> Tools { get; set; }
                    public class GetMcpResponseBodyDataAppliedVirtualConfigSourcesTools : TeaModel {
                        /// <summary>
                        /// <para>Required for virtual MCPs. The definition digest obtained from the ListMcpTools operation or the validation result of the source MCP. The client passes this value back as is without calculating it. This value is used only to manually update the validation baseline and does not freeze the runtime schema.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855</para>
                        /// </summary>
                        [NameInMap("expectedDigest")]
                        [Validation(Required=false)]
                        public string ExpectedDigest { get; set; }

                        /// <summary>
                        /// <para>Required for virtual MCPs. The name of the source tool.</para>
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

            /// <summary>
            /// <para>The backend authentication configuration. enabled specifies whether the configuration is enabled. directProxy specifies the custom authentication header for the direct proxy. httpToMcp specifies the list of OpenAPI credentials for HTTP_TO_MCP.</para>
            /// </summary>
            [NameInMap("auth")]
            [Validation(Required=false)]
            public GetMcpResponseBodyDataAuth Auth { get; set; }
            public class GetMcpResponseBodyDataAuth : TeaModel {
                /// <summary>
                /// <para>The caller API key authentication configuration for the code-deployed MCP.</para>
                /// </summary>
                [NameInMap("codePackage")]
                [Validation(Required=false)]
                public GetMcpResponseBodyDataAuthCodePackage CodePackage { get; set; }
                public class GetMcpResponseBodyDataAuthCodePackage : TeaModel {
                    /// <summary>
                    /// <para>The API key used to verify MCP callers.</para>
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
                public GetMcpResponseBodyDataAuthDirectProxy DirectProxy { get; set; }
                public class GetMcpResponseBodyDataAuthDirectProxy : TeaModel {
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
                /// <para>Specifies whether the configuration is enabled.</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The list of authentication configurations for HTTP_TO_MCP.</para>
                /// </summary>
                [NameInMap("httpToMcp")]
                [Validation(Required=false)]
                public List<GetMcpResponseBodyDataAuthHttpToMcp> HttpToMcp { get; set; }
                public class GetMcpResponseBodyDataAuthHttpToMcp : TeaModel {
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
                    /// <para>The location of the credential.</para>
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
            /// <para>The saved legacy or modern backend policy, which is separate from the transport indicated by the protocol and does not indicate verification. This field is not saved for newly created CODE_PACKAGE. For historical CODE_PACKAGE, the existing value does not control Function Compute session affinity or gateway protocol. For the actual protocol, refer to OriginProbe.LastResult.ActualConfiguration.BackendMcpProtocol. This field returns null for historically unspecified values and HTTP_TO_MCP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>modern</para>
            /// </summary>
            [NameInMap("backendMcpProtocol")]
            [Validation(Required=false)]
            public string BackendMcpProtocol { get; set; }

            /// <summary>
            /// <para>The time when the MCP was created, in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-23T00:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

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
            public GetMcpResponseBodyDataDeploymentConfig DeploymentConfig { get; set; }
            public class GetMcpResponseBodyDataDeploymentConfig : TeaModel {
                /// <summary>
                /// <para>The MCP entry access control.</para>
                /// </summary>
                [NameInMap("accessControl")]
                [Validation(Required=false)]
                public GetMcpResponseBodyDataDeploymentConfigAccessControl AccessControl { get; set; }
                public class GetMcpResponseBodyDataDeploymentConfigAccessControl : TeaModel {
                    /// <summary>
                    /// <para>The AgentCore credential referenced when the mode is set to CREDENTIAL.</para>
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
                    /// <para>The access control mode. ANONYMOUS indicates anonymous access, and CREDENTIAL indicates the use of AgentCore access credentials.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREDENTIAL</para>
                    /// </summary>
                    [NameInMap("mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                }

                /// <summary>
                /// <para>The Agent identity configuration.</para>
                /// </summary>
                [NameInMap("agentIdentityConfiguration")]
                [Validation(Required=false)]
                public GetMcpResponseBodyDataDeploymentConfigAgentIdentityConfiguration AgentIdentityConfiguration { get; set; }
                public class GetMcpResponseBodyDataDeploymentConfigAgentIdentityConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether authorization is enabled.</para>
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
                    /// <para>Specifies whether Agent identity is enabled.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

                /// <summary>
                /// <para>The artifact type. Code indicates a ZIP code package, and Container indicates a custom container.</para>
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
                public GetMcpResponseBodyDataDeploymentConfigCodeConfiguration CodeConfiguration { get; set; }
                public class GetMcpResponseBodyDataDeploymentConfigCodeConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The temporary code package token returned by GetMcpCodePackageUploadUrl. It is used to create or update a code deployment after a presigned upload is completed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>upload-token</para>
                    /// </summary>
                    [NameInMap("codePackageToken")]
                    [Validation(Required=false)]
                    public string CodePackageToken { get; set; }

                    /// <summary>
                    /// <para>The complete startup command, passed sequentially by parameter boundaries. For example, when using supergateway to start a stdio MCP, pass supergateway, --stdio, the complete subcommand, and the remaining parameters.</para>
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
                public GetMcpResponseBodyDataDeploymentConfigContainerConfiguration ContainerConfiguration { get; set; }
                public class GetMcpResponseBodyDataDeploymentConfigContainerConfiguration : TeaModel {
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
                    /// <para>The container entrypoint parameters.</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public List<string> Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The container image URI.</para>
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
                    /// <para>The MCP runtime mode. Custom containers must currently expose the standard MCP themselves. Set the value to SELF_HOSTED.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELF_HOSTED</para>
                    /// </summary>
                    [NameInMap("mcpRuntimeMode")]
                    [Validation(Required=false)]
                    public string McpRuntimeMode { get; set; }

                    /// <summary>
                    /// <para>The custom image registry configuration. This configuration takes effect only when ImageRegistryType is set to CUSTOM. It is used to configure image pull authentication, TLS certificate verification, and the private network for image pulling.</para>
                    /// </summary>
                    [NameInMap("registryConfig")]
                    [Validation(Required=false)]
                    public GetMcpResponseBodyDataDeploymentConfigContainerConfigurationRegistryConfig RegistryConfig { get; set; }
                    public class GetMcpResponseBodyDataDeploymentConfigContainerConfigurationRegistryConfig : TeaModel {
                        /// <summary>
                        /// <para>The image registry authentication configuration. Specify this field when the image registry requires username and password authentication.</para>
                        /// </summary>
                        [NameInMap("authConfig")]
                        [Validation(Required=false)]
                        public GetMcpResponseBodyDataDeploymentConfigContainerConfigurationRegistryConfigAuthConfig AuthConfig { get; set; }
                        public class GetMcpResponseBodyDataDeploymentConfigContainerConfigurationRegistryConfigAuthConfig : TeaModel {
                            /// <summary>
                            /// <para>The image registry password. The password is encrypted and stored on the server, and is not returned in query responses. Omit this field during updates to retain the existing password.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>example-password</para>
                            /// </summary>
                            [NameInMap("password")]
                            [Validation(Required=false)]
                            public string Password { get; set; }

                            /// <summary>
                            /// <para>The image registry username.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>puller</para>
                            /// </summary>
                            [NameInMap("userName")]
                            [Validation(Required=false)]
                            public string UserName { get; set; }

                        }

                        /// <summary>
                        /// <para>The TLS certificate verification configuration for the image registry.</para>
                        /// </summary>
                        [NameInMap("certConfig")]
                        [Validation(Required=false)]
                        public GetMcpResponseBodyDataDeploymentConfigContainerConfigurationRegistryConfigCertConfig CertConfig { get; set; }
                        public class GetMcpResponseBodyDataDeploymentConfigContainerConfigurationRegistryConfigCertConfig : TeaModel {
                            /// <summary>
                            /// <para>Specifies whether to skip the verification of the image registry TLS certificate. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>true: The verification is skipped.</description></item>
                            /// <item><description>false: The verification is not skipped.
                            /// Default value: false.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("insecure")]
                            [Validation(Required=false)]
                            public bool? Insecure { get; set; }

                            /// <summary>
                            /// <para>The Base64-encoded root CA certificate of the image registry, used to verify self-signed certificates.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>LS0tLS1CRUdJTi...</para>
                            /// </summary>
                            [NameInMap("rootCaCertBase64")]
                            [Validation(Required=false)]
                            public string RootCaCertBase64 { get; set; }

                        }

                        /// <summary>
                        /// <para>The network configuration for image pulling. Specify this field only when the image registry is accessible only within a VPC. Function Compute (FC) pulls images through this network.</para>
                        /// </summary>
                        [NameInMap("networkConfig")]
                        [Validation(Required=false)]
                        public GetMcpResponseBodyDataDeploymentConfigContainerConfigurationRegistryConfigNetworkConfig NetworkConfig { get; set; }
                        public class GetMcpResponseBodyDataDeploymentConfigContainerConfigurationRegistryConfigNetworkConfig : TeaModel {
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
                            /// <para>The ID of the VPC where the image registry is located.</para>
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
                public GetMcpResponseBodyDataDeploymentConfigHookConfiguration HookConfiguration { get; set; }
                public class GetMcpResponseBodyDataDeploymentConfigHookConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The ordered list of hooks. The system executes the PRE_LIST_TOOLS, PRE_CALL_TOOL, POST_LIST_TOOLS, and POST_CALL_TOOL hooks in the array order.</para>
                    /// </summary>
                    [NameInMap("hooks")]
                    [Validation(Required=false)]
                    public List<GetMcpResponseBodyDataDeploymentConfigHookConfigurationHooks> Hooks { get; set; }
                    public class GetMcpResponseBodyDataDeploymentConfigHookConfigurationHooks : TeaModel {
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
                        /// <para>Record MCP tool invoke</para>
                        /// </summary>
                        [NameInMap("description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>Specifies whether the hook is enabled.</para>
                        /// </summary>
                        [NameInMap("enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <para>The event that triggers the hook.</para>
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
                        /// <para>The timeout period of the hook, in milliseconds.</para>
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
                public GetMcpResponseBodyDataDeploymentConfigLogConfiguration LogConfiguration { get; set; }
                public class GetMcpResponseBodyDataDeploymentConfigLogConfiguration : TeaModel {
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
                    /// <para>The Function Compute log splitting start rule.</para>
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
                    /// <para>The name of the Log Service project.</para>
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
                public GetMcpResponseBodyDataDeploymentConfigMcpConfiguration McpConfiguration { get; set; }
                public class GetMcpResponseBodyDataDeploymentConfigMcpConfiguration : TeaModel {
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
                    /// <para>The number of concurrent sessions per instance. This value is currently fixed at 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sessionConcurrencyPerInstance")]
                    [Validation(Required=false)]
                    public int? SessionConcurrencyPerInstance { get; set; }

                    /// <summary>
                    /// <para>The session idle timeout in seconds. Default value: 1800.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1800</para>
                    /// </summary>
                    [NameInMap("sessionIdleTimeoutSeconds")]
                    [Validation(Required=false)]
                    public int? SessionIdleTimeoutSeconds { get; set; }

                    /// <summary>
                    /// <para>The maximum session lifetime in seconds. Default value: 21600.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>21600</para>
                    /// </summary>
                    [NameInMap("sessionMaxLifetimeSeconds")]
                    [Validation(Required=false)]
                    public int? SessionMaxLifetimeSeconds { get; set; }

                    /// <summary>
                    /// <para>Applies only to StreamableHTTP. The default value is STATEFUL upon creation. If omitted during an update, the original value is retained. STATELESS disables Function Compute session affinity, and the stdio gateway does not enable stateful mode. Native HTTP services must support stateless MCP.</para>
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
                public GetMcpResponseBodyDataDeploymentConfigNasConfiguration NasConfiguration { get; set; }
                public class GetMcpResponseBodyDataDeploymentConfigNasConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The user group ID.</para>
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
                    public List<GetMcpResponseBodyDataDeploymentConfigNasConfigurationMountPoints> MountPoints { get; set; }
                    public class GetMcpResponseBodyDataDeploymentConfigNasConfigurationMountPoints : TeaModel {
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
                        /// <para>The NAS service address.</para>
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
                public GetMcpResponseBodyDataDeploymentConfigNetworkConfiguration NetworkConfiguration { get; set; }
                public class GetMcpResponseBodyDataDeploymentConfigNetworkConfiguration : TeaModel {
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
                public GetMcpResponseBodyDataDeploymentConfigOssMountConfiguration OssMountConfiguration { get; set; }
                public class GetMcpResponseBodyDataDeploymentConfigOssMountConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The list of OSS mount points.</para>
                    /// </summary>
                    [NameInMap("mountPoints")]
                    [Validation(Required=false)]
                    public List<GetMcpResponseBodyDataDeploymentConfigOssMountConfigurationMountPoints> MountPoints { get; set; }
                    public class GetMcpResponseBodyDataDeploymentConfigOssMountConfigurationMountPoints : TeaModel {
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
                /// <para>The parameter transformation and result enhancement configuration.</para>
                /// </summary>
                [NameInMap("parameterTransformConfiguration")]
                [Validation(Required=false)]
                public GetMcpResponseBodyDataDeploymentConfigParameterTransformConfiguration ParameterTransformConfiguration { get; set; }
                public class GetMcpResponseBodyDataDeploymentConfigParameterTransformConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether parameter transformation and result enhancement are enabled.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The reserved reference to the parameter transformation and result enhancement rule set.</para>
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
                public GetMcpResponseBodyDataDeploymentConfigProxyConfiguration ProxyConfiguration { get; set; }
                public class GetMcpResponseBodyDataDeploymentConfigProxyConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether the MCP proxy is enabled.</para>
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
                public GetMcpResponseBodyDataDeploymentConfigRuntimeConfiguration RuntimeConfiguration { get; set; }
                public class GetMcpResponseBodyDataDeploymentConfigRuntimeConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The CPU specification, in cores. Default value: 0.25.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.25</para>
                    /// </summary>
                    [NameInMap("cpu")]
                    [Validation(Required=false)]
                    public double? Cpu { get; set; }

                    /// <summary>
                    /// <para>The temporary disk size, in MB. Valid values: 512 and 10240.</para>
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
                    /// <para>The memory specification, in MB. Default value: 512.</para>
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
                    /// <para>The function timeout period, in seconds. Default value: 300.</para>
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
            /// <para>A sample description used to illustrate the purpose of the resource</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The MCP endpoint that can be called by users or agents. It is empty before deployment is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/mcp">https://example.com/mcp</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The name of the Function Compute function corresponding to the CODE_PACKAGE MCP. This field is empty before the deployment is complete, and is also empty for other types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agentcore-mcp-example</para>
            /// </summary>
            [NameInMap("functionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The validation progress, end time, failure cause, and tool details for the current target assembly. For batch submissions, the items field contains only the results for the current MCP. After a new assembly is saved, the old validation details are no longer returned.</para>
            /// </summary>
            [NameInMap("lastValidation")]
            [Validation(Required=false)]
            public GetMcpResponseBodyDataLastValidation LastValidation { get; set; }
            public class GetMcpResponseBodyDataLastValidation : TeaModel {
                /// <summary>
                /// <para>The time when the validation was submitted, in UTC ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-11-25T10:00:00Z</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>Returned only when the status is FAILED. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Workspace.NotFound: The workspace no longer exists during execution.</description></item>
                /// <item><description>ValidationFailed: An exception occurred during task execution.
                /// Source MCP read failures are returned through items.sources.reasonCode, and the corresponding task status is PARTIAL_FAILED.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ValidationFailed</para>
                /// </summary>
                [NameInMap("failureCode")]
                [Validation(Required=false)]
                public string FailureCode { get; set; }

                /// <summary>
                /// <para>The secure reason description returned only when the status is FAILED. It does not contain internal exceptions, credentials, or upstream raw responses. When querying a failed task, the API itself still returns a success response. You must read data.status and this field to obtain the failure details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Failed to validate virtual MCP tools.</para>
                /// </summary>
                [NameInMap("failureMessage")]
                [Validation(Required=false)]
                public string FailureMessage { get; set; }

                /// <summary>
                /// <para>Returned only when the status is COMPLETED, PARTIAL_FAILED, FAILED, or CANCELED. The time is in UTC ISO 8601 format. This field is not returned when the status is PENDING, RUNNING, or PAUSED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-11-25T10:00:05Z</para>
                /// </summary>
                [NameInMap("finishedAt")]
                [Validation(Required=false)]
                public string FinishedAt { get; set; }

                /// <summary>
                /// <para>The itemized validation report for the selected tools. It does not automatically modify the selection or enumerate new unselected tools. New candidate tools are obtained through the ListMcpTools operation of the source MCP.</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<GetMcpResponseBodyDataLastValidationItems> Items { get; set; }
                public class GetMcpResponseBodyDataLastValidationItems : TeaModel {
                    /// <summary>
                    /// <para>The virtual MCP revision number read by the server when the validation is submitted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("checkedRevision")]
                    [Validation(Required=false)]
                    public long? CheckedRevision { get; set; }

                    /// <summary>
                    /// <para>The results returned by source.</para>
                    /// </summary>
                    [NameInMap("sources")]
                    [Validation(Required=false)]
                    public List<GetMcpResponseBodyDataLastValidationItemsSources> Sources { get; set; }
                    public class GetMcpResponseBodyDataLastValidationItemsSources : TeaModel {
                        /// <summary>
                        /// <para>The IDs of the virtual MCPs that reference this source. This field is for display purposes only.</para>
                        /// </summary>
                        [NameInMap("affectedVirtualMcps")]
                        [Validation(Required=false)]
                        public List<string> AffectedVirtualMcps { get; set; }

                        /// <summary>
                        /// <para>The time when the source was checked, in UTC ISO 8601 format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-11-25T10:00:03Z</para>
                        /// </summary>
                        [NameInMap("checkedAt")]
                        [Validation(Required=false)]
                        public string CheckedAt { get; set; }

                        /// <summary>
                        /// <para>The ID of the source MCP.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mcp-server-source-1</para>
                        /// </summary>
                        [NameInMap("mcpServerId")]
                        [Validation(Required=false)]
                        public string McpServerId { get; set; }

                        /// <summary>
                        /// <para>The reason code indicating why the source is unreadable. A read failure is not treated as a tool deletion.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SourceUnavailable</para>
                        /// </summary>
                        [NameInMap("reasonCode")]
                        [Validation(Required=false)]
                        public string ReasonCode { get; set; }

                        /// <summary>
                        /// <para>The read status of the source. Valid values: AVAILABLE and UNKNOWN.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AVAILABLE</para>
                        /// </summary>
                        [NameInMap("status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The validation results of the selected tools.</para>
                        /// </summary>
                        [NameInMap("tools")]
                        [Validation(Required=false)]
                        public List<GetMcpResponseBodyDataLastValidationItemsSourcesTools> Tools { get; set; }
                        public class GetMcpResponseBodyDataLastValidationItemsSourcesTools : TeaModel {
                            /// <summary>
                            /// <para>The current definition. This field is not returned if the read fails or the tool does not exist.</para>
                            /// </summary>
                            [NameInMap("currentDefinition")]
                            [Validation(Required=false)]
                            public GetMcpResponseBodyDataLastValidationItemsSourcesToolsCurrentDefinition CurrentDefinition { get; set; }
                            public class GetMcpResponseBodyDataLastValidationItemsSourcesToolsCurrentDefinition : TeaModel {
                                /// <summary>
                                /// <para>The JSON schema for input parameters.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{}}</para>
                                /// </summary>
                                [NameInMap("inputSchema")]
                                [Validation(Required=false)]
                                public string InputSchema { get; set; }

                                /// <summary>
                                /// <para>The JSON schema for output results.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;time&quot;:{&quot;type&quot;:&quot;string&quot;}}}</para>
                                /// </summary>
                                [NameInMap("outputSchema")]
                                [Validation(Required=false)]
                                public string OutputSchema { get; set; }

                                /// <summary>
                                /// <para>The description of the tool.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Get the current time</para>
                                /// </summary>
                                [NameInMap("toolDescription")]
                                [Validation(Required=false)]
                                public string ToolDescription { get; set; }

                                /// <summary>
                                /// <para>The name of the tool.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>get-current-time</para>
                                /// </summary>
                                [NameInMap("toolName")]
                                [Validation(Required=false)]
                                public string ToolName { get; set; }

                            }

                            /// <summary>
                            /// <para>The digest of the current definition.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855</para>
                            /// </summary>
                            [NameInMap("currentDigest")]
                            [Validation(Required=false)]
                            public string CurrentDigest { get; set; }

                            /// <summary>
                            /// <para>The name of the source tool.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>get-current-time</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The digest saved at the time of selection.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855</para>
                            /// </summary>
                            [NameInMap("savedDigest")]
                            [Validation(Required=false)]
                            public string SavedDigest { get; set; }

                            /// <summary>
                            /// <para>The status of the tool: UNCHANGED, CHANGED, REMOVED, or UNKNOWN. The status is compared with the digest baseline at the time of saving. CHANGED does not necessarily mean that the current schema of the gateway is out of sync. UNKNOWN indicates a read failure and must not be treated as a deletion.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>UNCHANGED</para>
                            /// </summary>
                            [NameInMap("status")]
                            [Validation(Required=false)]
                            public string Status { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The ID of the checked virtual MCP, used to associate with the mcpIds in the request.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp-server-virtual-1</para>
                    /// </summary>
                    [NameInMap("virtualMcpServerId")]
                    [Validation(Required=false)]
                    public string VirtualMcpServerId { get; set; }

                }

                /// <summary>
                /// <para>The status of the validation task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PENDING: Waiting to be executed.</description></item>
                /// <item><description>RUNNING: Executing, including waiting for retries.</description></item>
                /// <item><description>PAUSED: Paused and not yet finished.</description></item>
                /// <item><description>COMPLETED: The check is finished, but CHANGED or REMOVED items may still exist.</description></item>
                /// <item><description>PARTIAL_FAILED: UNKNOWN items exist, and all sources may be unreadable. Successful items are not guaranteed.</description></item>
                /// <item><description>FAILED: The task execution failed.</description></item>
                /// <item><description>CANCELED: The task is canceled.
                /// The terminal states are COMPLETED, PARTIAL_FAILED, FAILED, and CANCELED. The internal SUCCESS state is mapped to COMPLETED or PARTIAL_FAILED and is not directly returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLETED</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the validation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>val-1234567890</para>
                /// </summary>
                [NameInMap("validationId")]
                [Validation(Required=false)]
                public string ValidationId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the last tool validation for the current target assembly.</para>
            /// 
            /// <b>Example:</b>
            /// <para>val-1234567890</para>
            /// </summary>
            [NameInMap("lastValidationId")]
            [Validation(Required=false)]
            public string LastValidationId { get; set; }

            /// <summary>
            /// <para>The MCP source marketplace template.</para>
            /// </summary>
            [NameInMap("marketSource")]
            [Validation(Required=false)]
            public GetMcpResponseBodyDataMarketSource MarketSource { get; set; }
            public class GetMcpResponseBodyDataMarketSource : TeaModel {
                /// <summary>
                /// <para>The ID of the MCP marketplace template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>market-1</para>
                /// </summary>
                [NameInMap("marketItemId")]
                [Validation(Required=false)]
                public string MarketItemId { get; set; }

            }

            /// <summary>
            /// <para>The server-side configuration of the MCP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;object&quot;}</para>
            /// </summary>
            [NameInMap("mcpServerConfig")]
            [Validation(Required=false)]
            public string McpServerConfig { get; set; }

            /// <summary>
            /// <para>The MCP service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-1234567890abcdef</para>
            /// </summary>
            [NameInMap("mcpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

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
            /// <para>The official usage tag, which is managed by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KNOWLEDGE_BASE</para>
            /// </summary>
            [NameInMap("officialTag")]
            [Validation(Required=false)]
            public string OfficialTag { get; set; }

            /// <summary>
            /// <para>Reuses the read-only progress of existing release tasks. It does not change the primary status of the resource and is empty when there is no historical operation information.</para>
            /// </summary>
            [NameInMap("operation")]
            [Validation(Required=false)]
            public GetMcpResponseBodyDataOperation Operation { get; set; }
            public class GetMcpResponseBodyDataOperation : TeaModel {
                /// <summary>
                /// <para>The desensitized error of the current release operation. Gateway or formal link failures after the origin passes are expressed by this field.</para>
                /// </summary>
                [NameInMap("error")]
                [Validation(Required=false)]
                public GetMcpResponseBodyDataOperationError Error { get; set; }
                public class GetMcpResponseBodyDataOperationError : TeaModel {
                    /// <summary>
                    /// <para>Returns only bounded diagnostic codes and does not return the original error body from the origin.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PROBE_TIMEOUT</para>
                    /// </summary>
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The trimmed and desensitized necessary diagnostics, which do not include credentials or original responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The probe deadline was exceeded.</para>
                    /// </summary>
                    [NameInMap("message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>Indicates whether it is suitable to retry according to the restricted policy. It does not trigger automatic retries.</para>
                    /// </summary>
                    [NameInMap("retryable")]
                    [Validation(Required=false)]
                    public bool? Retryable { get; set; }

                    /// <summary>
                    /// <para>MAGIC, ROUTER, NETWORK, ORIGIN, or UNKNOWN. It is determined solely based on actual evidence.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UNKNOWN</para>
                    /// </summary>
                    [NameInMap("source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>The detection or release stage where the error occurred.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>INITIALIZE</para>
                    /// </summary>
                    [NameInMap("stage")]
                    [Validation(Required=false)]
                    public string Stage { get; set; }

                }

                /// <summary>
                /// <para>The identifier of the current or most recent release operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3541f1af-87cc-45d1-a28e-94ec5633b931</para>
                /// </summary>
                [NameInMap("operationId")]
                [Validation(Required=false)]
                public string OperationId { get; set; }

                /// <summary>
                /// <para>Compute deployment, origin verification, summary saving, gateway release, ingress credential synchronization, formal link verification, or deployment submission. Old tasks retain their original stage semantics.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VALIDATE_ORIGIN</para>
                /// </summary>
                [NameInMap("stage")]
                [Validation(Required=false)]
                public string Stage { get; set; }

                /// <summary>
                /// <para>PENDING, RUNNING, SUCCEEDED, or FAILED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Currently PUBLISH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLISH</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The time in ISO 8601 UTC format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-11-19T08:30:00Z</para>
                /// </summary>
                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

            /// <summary>
            /// <para>The ID of the most recent virtual MCP publishing task. You can use this ID to query and locate the results of the asynchronous publishing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-1234567890</para>
            /// </summary>
            [NameInMap("operationTaskId")]
            [Validation(Required=false)]
            public string OperationTaskId { get; set; }

            /// <summary>
            /// <para>Returns the minimal origin verification summary of the most recent task only for code deployment. It is empty for direct connection and HTTP to MCP. Queries do not trigger probing.</para>
            /// </summary>
            [NameInMap("originProbe")]
            [Validation(Required=false)]
            public GetMcpResponseBodyDataOriginProbe OriginProbe { get; set; }
            public class GetMcpResponseBodyDataOriginProbe : TeaModel {
                /// <summary>
                /// <para>Returned only for CODE_PACKAGE. It is cleared when a new task starts and is empty if no verification has been performed or if the old task did not perform verification. If a subsequent release fails, this summary is retained, which does not indicate real-time health or the active version status.</para>
                /// </summary>
                [NameInMap("lastResult")]
                [Validation(Required=false)]
                public GetMcpResponseBodyDataOriginProbeLastResult LastResult { get; set; }
                public class GetMcpResponseBodyDataOriginProbeLastResult : TeaModel {
                    /// <summary>
                    /// <para>The actual configuration confirmed by evidence in this verification. It is empty when no confirmed information is available and is not inferred from the expected configuration.</para>
                    /// </summary>
                    [NameInMap("actualConfiguration")]
                    [Validation(Required=false)]
                    public GetMcpResponseBodyDataOriginProbeLastResultActualConfiguration ActualConfiguration { get; set; }
                    public class GetMcpResponseBodyDataOriginProbeLastResultActualConfiguration : TeaModel {
                        /// <summary>
                        /// <para>The verified legacy or modern policy. It is empty when unconfirmed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>modern</para>
                        /// </summary>
                        [NameInMap("backendMcpProtocol")]
                        [Validation(Required=false)]
                        public string BackendMcpProtocol { get; set; }

                        /// <summary>
                        /// <para>The verified SSE or StreamableHTTP. It is empty when unconfirmed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>StreamableHTTP</para>
                        /// </summary>
                        [NameInMap("protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                        /// <summary>
                        /// <para>The actual negotiated or selected and verified date version. It is empty when unconfirmed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2025-03-26</para>
                        /// </summary>
                        [NameInMap("protocolVersion")]
                        [Validation(Required=false)]
                        public string ProtocolVersion { get; set; }

                        /// <summary>
                        /// <para>STATEFUL, STATELESS, or NOT_APPLICABLE. It is empty when unconfirmed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>STATELESS</para>
                        /// </summary>
                        [NameInMap("sessionMode")]
                        [Validation(Required=false)]
                        public string SessionMode { get; set; }

                    }

                    /// <summary>
                    /// <para>Empty upon success. It only saves the desensitized diagnostics required for this verification.</para>
                    /// </summary>
                    [NameInMap("error")]
                    [Validation(Required=false)]
                    public GetMcpResponseBodyDataOriginProbeLastResultError Error { get; set; }
                    public class GetMcpResponseBodyDataOriginProbeLastResultError : TeaModel {
                        /// <summary>
                        /// <para>Returns only bounded diagnostic codes and does not return the original error body from the origin.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PROBE_TIMEOUT</para>
                        /// </summary>
                        [NameInMap("code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>The trimmed and desensitized necessary diagnostics, which do not include credentials or original responses.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The probe deadline was exceeded.</para>
                        /// </summary>
                        [NameInMap("message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        /// <summary>
                        /// <para>Indicates whether it is suitable to retry according to the restricted policy. It does not trigger automatic retries.</para>
                        /// </summary>
                        [NameInMap("retryable")]
                        [Validation(Required=false)]
                        public bool? Retryable { get; set; }

                        /// <summary>
                        /// <para>MAGIC, ROUTER, NETWORK, ORIGIN, or UNKNOWN. It is determined solely based on actual evidence.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>UNKNOWN</para>
                        /// </summary>
                        [NameInMap("source")]
                        [Validation(Required=false)]
                        public string Source { get; set; }

                        /// <summary>
                        /// <para>The detection or release stage where the error occurred.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>INITIALIZE</para>
                        /// </summary>
                        [NameInMap("stage")]
                        [Validation(Required=false)]
                        public string Stage { get; set; }

                    }

                    /// <summary>
                    /// <para>The time of this origin verification, in ISO 8601 UTC format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-11-19T08:30:00Z</para>
                    /// </summary>
                    [NameInMap("probedAt")]
                    [Validation(Required=false)]
                    public string ProbedAt { get; set; }

                    /// <summary>
                    /// <para>CONNECT, DISCOVER, INITIALIZE, SESSION_CHECK, CLEANUP, or COMPLETE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>COMPLETE</para>
                    /// </summary>
                    [NameInMap("stage")]
                    [Validation(Required=false)]
                    public string Stage { get; set; }

                    /// <summary>
                    /// <para>SUCCESS or FAILED. The status is SUCCESS if the protocol and applicable session checks pass. Not declaring any capabilities does not affect the passing status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESS</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            /// <summary>
            /// <para>The optional saved metadata for the origin MCP protocol date display, in YYYY-MM-DD format. It can be specified during creation and modified during updates. If omitted during an update, the current value is retained. This field only saves and displays information. It is not a software version, does not restrict the external gateway protocol, does not control backend requests, and does not indicate that real-time verification has passed. It returns null if omitted during creation and not updated, if historically missing, or for HTTP_TO_MCP. There is no default value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-26</para>
            /// </summary>
            [NameInMap("originProtocolVersion")]
            [Validation(Required=false)]
            public string OriginProtocolVersion { get; set; }

            /// <summary>
            /// <para>PUBLIC indicates public access. CONTROLLED indicates that access is controlled based on permission rules.</para>
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
            /// <para>Read-only. Records the image URI and digest retrieved from Function Compute (FC) for the active deployment. The deployment still uses the tag specified in deploymentConfig.containerConfiguration.image. This field is not used as an input parameter for deployment. It is empty if the deployment is not yet active or the image digest has not been obtained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry.example.com/mcp@sha256:0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("resolvedImageUri")]
            [Validation(Required=false)]
            public string ResolvedImageUri { get; set; }

            /// <summary>
            /// <para>The target revision number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("revision")]
            [Validation(Required=false)]
            public long? Revision { get; set; }

            /// <summary>
            /// <para>The number of selected sources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("sourceCount")]
            [Validation(Required=false)]
            public int? SourceCount { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason for the status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resource processing completed</para>
            /// </summary>
            [NameInMap("statusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The security reason code for the virtual MCP publishing failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PublishFailed</para>
            /// </summary>
            [NameInMap("statusReasonCode")]
            [Validation(Required=false)]
            public string StatusReasonCode { get; set; }

            /// <summary>
            /// <para>The Swagger configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;object&quot;}</para>
            /// </summary>
            [NameInMap("swaggerConfig")]
            [Validation(Required=false)]
            public string SwaggerConfig { get; set; }

            /// <summary>
            /// <para>The template schema for the bound version of the usage MCP. This field is not returned for regular MCPs.</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public GetMcpResponseBodyDataTemplate Template { get; set; }
            public class GetMcpResponseBodyDataTemplate : TeaModel {
                /// <summary>
                /// <para>The template version currently applied to the MCP.</para>
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
                /// <para>The version of the template schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("schemaVersion")]
                [Validation(Required=false)]
                public string SchemaVersion { get; set; }

                /// <summary>
                /// <para>The input schema of the template, represented as a JSON Schema string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;addresses&quot;:{&quot;type&quot;:&quot;array&quot;,&quot;items&quot;:{&quot;type&quot;:&quot;string&quot;}}}}</para>
                /// </summary>
                [NameInMap("templateInputSchema")]
                [Validation(Required=false)]
                public string TemplateInputSchema { get; set; }

                /// <summary>
                /// <para>Specifies whether an updated template version is available.</para>
                /// </summary>
                [NameInMap("updateAvailable")]
                [Validation(Required=false)]
                public bool? UpdateAvailable { get; set; }

            }

            /// <summary>
            /// <para>The number of selected tools.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("toolCount")]
            [Validation(Required=false)]
            public int? ToolCount { get; set; }

            /// <summary>
            /// <para>The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The last update time of the MCP, in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-23T01:00:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The access address of the MCP service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/artifacts/example.zip">https://example.com/artifacts/example.zip</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>Specifies whether the MCP is still subject to the usage constraints of the official template.</para>
            /// </summary>
            [NameInMap("usageActive")]
            [Validation(Required=false)]
            public bool? UsageActive { get; set; }

            /// <summary>
            /// <para>The target sources and tool selection.</para>
            /// </summary>
            [NameInMap("virtualConfig")]
            [Validation(Required=false)]
            public GetMcpResponseBodyDataVirtualConfig VirtualConfig { get; set; }
            public class GetMcpResponseBodyDataVirtualConfig : TeaModel {
                /// <summary>
                /// <para>Required for virtual MCPs. Specify 1 to 10 different source MCPs.</para>
                /// </summary>
                [NameInMap("sources")]
                [Validation(Required=false)]
                public List<GetMcpResponseBodyDataVirtualConfigSources> Sources { get; set; }
                public class GetMcpResponseBodyDataVirtualConfigSources : TeaModel {
                    /// <summary>
                    /// <para>Required for virtual MCPs. The ID of the source MCP in the current workspace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp-server-source-1</para>
                    /// </summary>
                    [NameInMap("mcpServerId")]
                    [Validation(Required=false)]
                    public string McpServerId { get; set; }

                    /// <summary>
                    /// <para>Required for virtual MCPs. The manually selected tools. Specify at least one tool for each source, up to 100 tools across all sources.</para>
                    /// </summary>
                    [NameInMap("tools")]
                    [Validation(Required=false)]
                    public List<GetMcpResponseBodyDataVirtualConfigSourcesTools> Tools { get; set; }
                    public class GetMcpResponseBodyDataVirtualConfigSourcesTools : TeaModel {
                        /// <summary>
                        /// <para>Required for virtual MCPs. The definition digest obtained from the ListMcpTools operation or the validation result of the source MCP. The client passes this value back as is without calculating it. This value is used only to manually update the validation baseline and does not freeze the runtime schema.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855</para>
                        /// </summary>
                        [NameInMap("expectedDigest")]
                        [Validation(Required=false)]
                        public string ExpectedDigest { get; set; }

                        /// <summary>
                        /// <para>Required for virtual MCPs. The name of the source tool.</para>
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
        /// <para>Request processed successfully</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-47A8-90AB-CDEF12345678</para>
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
