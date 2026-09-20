// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListMcpsResponseBody : TeaModel {
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list data.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListMcpsResponseBodyItems> Items { get; set; }
        public class ListMcpsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The list of MCP service addresses.</para>
            /// </summary>
            [NameInMap("addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            /// <summary>
            /// <para>The backend authentication configuration. enabled indicates whether it is enabled. directProxy specifies custom authentication headers for direct proxy. httpToMcp specifies the OpenAPI credential list for HTTP_TO_MCP.</para>
            /// </summary>
            [NameInMap("auth")]
            [Validation(Required=false)]
            public ListMcpsResponseBodyItemsAuth Auth { get; set; }
            public class ListMcpsResponseBodyItemsAuth : TeaModel {
                /// <summary>
                /// <para>The caller API Key authentication configuration for code-deployed MCP.</para>
                /// </summary>
                [NameInMap("codePackage")]
                [Validation(Required=false)]
                public ListMcpsResponseBodyItemsAuthCodePackage CodePackage { get; set; }
                public class ListMcpsResponseBodyItemsAuthCodePackage : TeaModel {
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
                /// <para>The authentication configuration for direct proxy.</para>
                /// </summary>
                [NameInMap("directProxy")]
                [Validation(Required=false)]
                public ListMcpsResponseBodyItemsAuthDirectProxy DirectProxy { get; set; }
                public class ListMcpsResponseBodyItemsAuthDirectProxy : TeaModel {
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
                    /// <para>The authentication parameter value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-credential</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the configuration is enabled.</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The list of HTTP_TO_MCP authentication configurations.</para>
                /// </summary>
                [NameInMap("httpToMcp")]
                [Validation(Required=false)]
                public List<ListMcpsResponseBodyItemsAuthHttpToMcp> HttpToMcp { get; set; }
                public class ListMcpsResponseBodyItemsAuthHttpToMcp : TeaModel {
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
            /// <para>The MCP creation time in ISO 8601 UTC format.</para>
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
            public ListMcpsResponseBodyItemsDeploymentConfig DeploymentConfig { get; set; }
            public class ListMcpsResponseBodyItemsDeploymentConfig : TeaModel {
                /// <summary>
                /// <para>The MCP ingress access control.</para>
                /// </summary>
                [NameInMap("accessControl")]
                [Validation(Required=false)]
                public ListMcpsResponseBodyItemsDeploymentConfigAccessControl AccessControl { get; set; }
                public class ListMcpsResponseBodyItemsDeploymentConfigAccessControl : TeaModel {
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
                    /// <para>Indicates whether ingress access control is enabled.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>ANONYMOUS indicates anonymous access. CREDENTIAL indicates using AgentCore access credentials.</para>
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
                public ListMcpsResponseBodyItemsDeploymentConfigAgentIdentityConfiguration AgentIdentityConfiguration { get; set; }
                public class ListMcpsResponseBodyItemsDeploymentConfigAgentIdentityConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether authorization is enabled.</para>
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
                    /// <para>Indicates whether Agent Identity is enabled.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

                /// <summary>
                /// <para>Code indicates a ZIP code package. Container indicates a custom container.</para>
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
                public ListMcpsResponseBodyItemsDeploymentConfigCodeConfiguration CodeConfiguration { get; set; }
                public class ListMcpsResponseBodyItemsDeploymentConfigCodeConfiguration : TeaModel {
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
                    /// <para>The full startup command, with arguments passed in order by parameter boundary. For example, when using supergateway to start a stdio MCP, pass in supergateway, --stdio, the full subcommand, and the remaining arguments.</para>
                    /// </summary>
                    [NameInMap("command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                    /// <summary>
                    /// <para>The code package runtime: python3.13, nodejs22, or java17.</para>
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
                public ListMcpsResponseBodyItemsDeploymentConfigContainerConfiguration ContainerConfiguration { get; set; }
                public class ListMcpsResponseBodyItemsDeploymentConfigContainerConfiguration : TeaModel {
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
                    /// <para>The custom container must expose a standard MCP endpoint on its own. The value is SELF_HOSTED.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELF_HOSTED</para>
                    /// </summary>
                    [NameInMap("mcpRuntimeMode")]
                    [Validation(Required=false)]
                    public string McpRuntimeMode { get; set; }

                    /// <summary>
                    /// <para>The value is fixed to CONTAINER_IMAGE.</para>
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
                public ListMcpsResponseBodyItemsDeploymentConfigHookConfiguration HookConfiguration { get; set; }
                public class ListMcpsResponseBodyItemsDeploymentConfigHookConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The PRE_LIST_TOOLS, PRE_CALL_TOOL, POST_LIST_TOOLS, and POST_CALL_TOOL hooks are executed in array order.</para>
                    /// </summary>
                    [NameInMap("hooks")]
                    [Validation(Required=false)]
                    public List<ListMcpsResponseBodyItemsDeploymentConfigHookConfigurationHooks> Hooks { get; set; }
                    public class ListMcpsResponseBodyItemsDeploymentConfigHookConfigurationHooks : TeaModel {
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
                        /// <para>Record MCP tool calling invokes</para>
                        /// </summary>
                        [NameInMap("description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the hook is enabled.</para>
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
                public ListMcpsResponseBodyItemsDeploymentConfigLogConfiguration LogConfiguration { get; set; }
                public class ListMcpsResponseBodyItemsDeploymentConfigLogConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether instance metrics collection is enabled.</para>
                    /// </summary>
                    [NameInMap("enableInstanceMetrics")]
                    [Validation(Required=false)]
                    public bool? EnableInstanceMetrics { get; set; }

                    /// <summary>
                    /// <para>Indicates whether request metrics collection is enabled.</para>
                    /// </summary>
                    [NameInMap("enableRequestMetrics")]
                    [Validation(Required=false)]
                    public bool? EnableRequestMetrics { get; set; }

                    /// <summary>
                    /// <para>The log segmentation begin rule for Function Compute (FC).</para>
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
                public ListMcpsResponseBodyItemsDeploymentConfigMcpConfiguration McpConfiguration { get; set; }
                public class ListMcpsResponseBodyItemsDeploymentConfigMcpConfiguration : TeaModel {
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
                    /// <para>The value is fixed to 1.</para>
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
                public ListMcpsResponseBodyItemsDeploymentConfigNasConfiguration NasConfiguration { get; set; }
                public class ListMcpsResponseBodyItemsDeploymentConfigNasConfiguration : TeaModel {
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
                    public List<ListMcpsResponseBodyItemsDeploymentConfigNasConfigurationMountPoints> MountPoints { get; set; }
                    public class ListMcpsResponseBodyItemsDeploymentConfigNasConfigurationMountPoints : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether TLS is enabled.</para>
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
                public ListMcpsResponseBodyItemsDeploymentConfigNetworkConfiguration NetworkConfiguration { get; set; }
                public class ListMcpsResponseBodyItemsDeploymentConfigNetworkConfiguration : TeaModel {
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
                    /// <para>The virtual private cloud (VPC) ID.</para>
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
                public ListMcpsResponseBodyItemsDeploymentConfigOssMountConfiguration OssMountConfiguration { get; set; }
                public class ListMcpsResponseBodyItemsDeploymentConfigOssMountConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The list of OSS mount points.</para>
                    /// </summary>
                    [NameInMap("mountPoints")]
                    [Validation(Required=false)]
                    public List<ListMcpsResponseBodyItemsDeploymentConfigOssMountConfigurationMountPoints> MountPoints { get; set; }
                    public class ListMcpsResponseBodyItemsDeploymentConfigOssMountConfigurationMountPoints : TeaModel {
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
                        /// <para>Indicates whether the mount point is read-only.</para>
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
                public ListMcpsResponseBodyItemsDeploymentConfigParameterTransformConfiguration ParameterTransformConfiguration { get; set; }
                public class ListMcpsResponseBodyItemsDeploymentConfigParameterTransformConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether parameter transformation and result enhancement is enabled.</para>
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
                public ListMcpsResponseBodyItemsDeploymentConfigProxyConfiguration ProxyConfiguration { get; set; }
                public class ListMcpsResponseBodyItemsDeploymentConfigProxyConfiguration : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the MCP proxy is enabled.</para>
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
                public ListMcpsResponseBodyItemsDeploymentConfigRuntimeConfiguration RuntimeConfiguration { get; set; }
                public class ListMcpsResponseBodyItemsDeploymentConfigRuntimeConfiguration : TeaModel {
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
                    /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role used by user code to access downstream Alibaba Cloud resources.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:ram::1234567890123456:role/agentcore-mcp-execution</para>
                    /// </summary>
                    [NameInMap("executionRoleArn")]
                    [Validation(Required=false)]
                    public string ExecutionRoleArn { get; set; }

                    /// <summary>
                    /// <para>The number of concurrent requests per instance. Default value: 200.</para>
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
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A sample description that explains the purpose of the resource</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The MCP endpoint available for users or agents to call. This value is empty before deployment is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/mcp">https://example.com/mcp</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The Function Compute function name corresponding to the CODE_PACKAGE MCP. This value is empty before deployment is complete or for other types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agentcore-mcp-example</para>
            /// </summary>
            [NameInMap("functionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The MCP marketplace source template.</para>
            /// </summary>
            [NameInMap("marketSource")]
            [Validation(Required=false)]
            public ListMcpsResponseBodyItemsMarketSource MarketSource { get; set; }
            public class ListMcpsResponseBodyItemsMarketSource : TeaModel {
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
            /// <para>The official tag managed by the server.</para>
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
            /// <para>The status reason.</para>
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
            /// <para>The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the MCP was last updated, in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-23T01:00:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>Indicates whether the MCP is still subject to the usage constraints of the official template.</para>
            /// </summary>
            [NameInMap("usageActive")]
            [Validation(Required=false)]
            public bool? UsageActive { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Request processing succeeded</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-page-token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
