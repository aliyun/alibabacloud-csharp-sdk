// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateMcpResponseBody : TeaModel {
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
        public CreateMcpResponseBodyData Data { get; set; }
        public class CreateMcpResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of MCP service addresses. This parameter is required when Type is set to DIRECT_PROXY or HTTP_TO_MCP. Do not specify this parameter when Type is set to CODE_PACKAGE.</para>
            /// </summary>
            [NameInMap("addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            /// <summary>
            /// <para>The backend authentication configuration. enabled indicates whether it is enabled; directProxy specifies the custom authentication headers for the direct proxy; httpToMcp specifies the list of OpenAPI credentials for HTTP_TO_MCP.</para>
            /// </summary>
            [NameInMap("auth")]
            [Validation(Required=false)]
            public CreateMcpResponseBodyDataAuth Auth { get; set; }
            public class CreateMcpResponseBodyDataAuth : TeaModel {
                /// <summary>
                /// <para>The API Key authentication configuration for callers of the code deployment MCP.</para>
                /// </summary>
                [NameInMap("codePackage")]
                [Validation(Required=false)]
                public CreateMcpResponseBodyDataAuthCodePackage CodePackage { get; set; }
                public class CreateMcpResponseBodyDataAuthCodePackage : TeaModel {
                    /// <summary>
                    /// <para>The API Key used to verify MCP callers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-api-key</para>
                    /// </summary>
                    [NameInMap("apiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    /// <summary>
                    /// <para>The name of the request header that carries the API Key.</para>
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
                public CreateMcpResponseBodyDataAuthDirectProxy DirectProxy { get; set; }
                public class CreateMcpResponseBodyDataAuthDirectProxy : TeaModel {
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
                public List<CreateMcpResponseBodyDataAuthHttpToMcp> HttpToMcp { get; set; }
                public class CreateMcpResponseBodyDataAuthHttpToMcp : TeaModel {
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
                    /// <para>The authentication scheme ID.</para>
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
                    /// <para>The MCP type.</para>
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
            /// <para>The custom tags. Multiple tags are supported.</para>
            /// </summary>
            [NameInMap("customTags")]
            [Validation(Required=false)]
            public List<string> CustomTags { get; set; }

            /// <summary>
            /// <para>The deployment configuration for the code-deployed MCP.</para>
            /// </summary>
            [NameInMap("deploymentConfig")]
            [Validation(Required=false)]
            public CreateMcpResponseBodyDataDeploymentConfig DeploymentConfig { get; set; }
            public class CreateMcpResponseBodyDataDeploymentConfig : TeaModel {
                /// <summary>
                /// <para>The MCP entry access control.</para>
                /// </summary>
                [NameInMap("accessControl")]
                [Validation(Required=false)]
                public CreateMcpResponseBodyDataDeploymentConfigAccessControl AccessControl { get; set; }
                public class CreateMcpResponseBodyDataDeploymentConfigAccessControl : TeaModel {
                    /// <summary>
                    /// <para>The access credential ID. This parameter references an AgentCore credential when the mode is set to CREDENTIAL.</para>
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
                    /// <para>The access control mode. ANONYMOUS indicates anonymous access, and CREDENTIAL indicates that AgentCore access credentials are used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREDENTIAL</para>
                    /// </summary>
                    [NameInMap("mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                }

                /// <summary>
                /// <para>The agent identity configuration.</para>
                /// </summary>
                [NameInMap("agentIdentityConfiguration")]
                [Validation(Required=false)]
                public CreateMcpResponseBodyDataDeploymentConfigAgentIdentityConfiguration AgentIdentityConfiguration { get; set; }
                public class CreateMcpResponseBodyDataDeploymentConfigAgentIdentityConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable authorization.</para>
                    /// </summary>
                    [NameInMap("authorizationEnabled")]
                    [Validation(Required=false)]
                    public bool? AuthorizationEnabled { get; set; }

                    /// <summary>
                    /// <para>The credential provider ARN.</para>
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
                    /// <para>Specifies whether to enable agent identity.</para>
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
                public CreateMcpResponseBodyDataDeploymentConfigCodeConfiguration CodeConfiguration { get; set; }
                public class CreateMcpResponseBodyDataDeploymentConfigCodeConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The temporary code package token returned by GetMcpCodePackageUploadUrl. This token is used to create or update a code deployment after a presigned upload is completed.</para>
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
                    /// <para>The runtime environment for the code package.</para>
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
                public CreateMcpResponseBodyDataDeploymentConfigContainerConfiguration ContainerConfiguration { get; set; }
                public class CreateMcpResponseBodyDataDeploymentConfigContainerConfiguration : TeaModel {
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
                    /// <para>The container image URL.</para>
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
                    /// <para>The MCP runtime mode. Custom containers currently need to expose the standard MCP themselves. Set the value to SELF_HOSTED.</para>
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
                public CreateMcpResponseBodyDataDeploymentConfigHookConfiguration HookConfiguration { get; set; }
                public class CreateMcpResponseBodyDataDeploymentConfigHookConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The ordered list of hooks. Executes PRE_LIST_TOOLS, PRE_CALL_TOOL, POST_LIST_TOOLS, and POST_CALL_TOOL hooks in the order of the array.</para>
                    /// </summary>
                    [NameInMap("hooks")]
                    [Validation(Required=false)]
                    public List<CreateMcpResponseBodyDataDeploymentConfigHookConfigurationHooks> Hooks { get; set; }
                    public class CreateMcpResponseBodyDataDeploymentConfigHookConfigurationHooks : TeaModel {
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
                        /// <para>Log MCP tool invocation</para>
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
                public CreateMcpResponseBodyDataDeploymentConfigLogConfiguration LogConfiguration { get; set; }
                public class CreateMcpResponseBodyDataDeploymentConfigLogConfiguration : TeaModel {
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
                    /// <para>The start rule for splitting Function Compute logs.</para>
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
                public CreateMcpResponseBodyDataDeploymentConfigMcpConfiguration McpConfiguration { get; set; }
                public class CreateMcpResponseBodyDataDeploymentConfigMcpConfiguration : TeaModel {
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
                    /// <para>The session idle timeout period in seconds. Default value: 1800.</para>
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

                }

                /// <summary>
                /// <para>The NAS storage configuration.</para>
                /// </summary>
                [NameInMap("nasConfiguration")]
                [Validation(Required=false)]
                public CreateMcpResponseBodyDataDeploymentConfigNasConfiguration NasConfiguration { get; set; }
                public class CreateMcpResponseBodyDataDeploymentConfigNasConfiguration : TeaModel {
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
                    public List<CreateMcpResponseBodyDataDeploymentConfigNasConfigurationMountPoints> MountPoints { get; set; }
                    public class CreateMcpResponseBodyDataDeploymentConfigNasConfigurationMountPoints : TeaModel {
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
                public CreateMcpResponseBodyDataDeploymentConfigNetworkConfiguration NetworkConfiguration { get; set; }
                public class CreateMcpResponseBodyDataDeploymentConfigNetworkConfiguration : TeaModel {
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
                public CreateMcpResponseBodyDataDeploymentConfigOssMountConfiguration OssMountConfiguration { get; set; }
                public class CreateMcpResponseBodyDataDeploymentConfigOssMountConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The list of OSS mount points.</para>
                    /// </summary>
                    [NameInMap("mountPoints")]
                    [Validation(Required=false)]
                    public List<CreateMcpResponseBodyDataDeploymentConfigOssMountConfigurationMountPoints> MountPoints { get; set; }
                    public class CreateMcpResponseBodyDataDeploymentConfigOssMountConfigurationMountPoints : TeaModel {
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
                        /// <para>The path of the OSS bucket.</para>
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
                public CreateMcpResponseBodyDataDeploymentConfigParameterTransformConfiguration ParameterTransformConfiguration { get; set; }
                public class CreateMcpResponseBodyDataDeploymentConfigParameterTransformConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable parameter transformation and result enhancement.</para>
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
                    /// <para>The transformation rule version.</para>
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
                public CreateMcpResponseBodyDataDeploymentConfigProxyConfiguration ProxyConfiguration { get; set; }
                public class CreateMcpResponseBodyDataDeploymentConfigProxyConfiguration : TeaModel {
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
                public CreateMcpResponseBodyDataDeploymentConfigRuntimeConfiguration RuntimeConfiguration { get; set; }
                public class CreateMcpResponseBodyDataDeploymentConfigRuntimeConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The CPU specification in cores. Default value: 0.25.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.25</para>
                    /// </summary>
                    [NameInMap("cpu")]
                    [Validation(Required=false)]
                    public double? Cpu { get; set; }

                    /// <summary>
                    /// <para>The temporary disk size in MB. Valid values: 512 or 10240.</para>
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
                    /// <para>The memory specification in MB. Default value: 512.</para>
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
                    /// <para>The function timeout period in seconds. Default value: 300.</para>
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
            /// <para>A sample description that illustrates the purpose of the resource</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The MCP endpoint available for invocation by users or agents. This field is empty before deployment is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/mcp">https://example.com/mcp</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The name of the Function Compute function associated with the CODE_PACKAGE MCP. This field is empty before deployment is complete and for all other types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agentcore-mcp-example</para>
            /// </summary>
            [NameInMap("functionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The source marketplace template for the MCP.</para>
            /// </summary>
            [NameInMap("marketSource")]
            [Validation(Required=false)]
            public CreateMcpResponseBodyDataMarketSource MarketSource { get; set; }
            public class CreateMcpResponseBodyDataMarketSource : TeaModel {
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
            /// <para>The MCP server configuration.</para>
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
            /// <para>The official usage tag managed by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KNOWLEDGE_BASE</para>
            /// </summary>
            [NameInMap("officialTag")]
            [Validation(Required=false)]
            public string OfficialTag { get; set; }

            /// <summary>
            /// <para>The access permission mode. PUBLIC indicates public access. CONTROLLED indicates that access is controlled based on permission rules.</para>
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
            /// <para>The Swagger configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;object&quot;}</para>
            /// </summary>
            [NameInMap("swaggerConfig")]
            [Validation(Required=false)]
            public string SwaggerConfig { get; set; }

            /// <summary>
            /// <para>The template version and input schema bound to the MCP.</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public CreateMcpResponseBodyDataTemplate Template { get; set; }
            public class CreateMcpResponseBodyDataTemplate : TeaModel {
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
                /// <para>Specifies whether an updated template version is available.</para>
                /// </summary>
                [NameInMap("updateAvailable")]
                [Validation(Required=false)]
                public bool? UpdateAvailable { get; set; }

            }

            /// <summary>
            /// <para>The MCP type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Specifies whether the MCP is still subject to the usage constraints of the official template.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
