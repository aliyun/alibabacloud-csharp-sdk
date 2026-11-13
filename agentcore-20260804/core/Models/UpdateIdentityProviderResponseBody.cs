// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateIdentityProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The business result code. If the request fails, use this code in combination with the HTTP status code and the message for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business result. For the result structure, see the response parameters of this API operation. For asynchronous write operations, the response indicates that the request is accepted, but does not guarantee that the background task is completed.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateIdentityProviderResponseBodyData Data { get; set; }
        public class UpdateIdentityProviderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual upstream configuration. The actual SAML configuration is read on demand only when you call the GetIdentityProvider operation. SCIM queries and preparations return the actual receiving status and URL.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public UpdateIdentityProviderResponseBodyDataConfiguration Configuration { get; set; }
            public class UpdateIdentityProviderResponseBodyDataConfiguration : TeaModel {
                /// <summary>
                /// <para>HTTP-Redirect or HTTP-POST. Required for manual entry. The query returns the short name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>Required for manual entry. It must be non-empty and contain up to 2,048 characters. The existing configuration cannot be replaced. It is different from the local entity ID queried by the SP.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>Required for manual entry. It must be an absolute HTTPS URL and cannot contain user credentials or fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>The actual SSO logon status. The actual switch value is Enabled or Disabled, which is not equivalent to the expected loginEnabled value saved in AC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("ssoStatus")]
                [Validation(Required=false)]
                public string SsoStatus { get; set; }

            }

            /// <summary>
            /// <para>General CRUD operations support DingTalk, Lark, and CustomSSO. SP queries support only CustomSSO. The SCIM path uses the CustomSSO shared pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CustomSSO</para>
            /// </summary>
            [NameInMap("identityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>Do not pass true during CustomSSO initialization. A valid SAML configuration must be saved before enabling. Disabling does not delete the configuration. In case of asynchronous failure, this expected value does not mean that it has taken effect upstream.</para>
            /// </summary>
            [NameInMap("loginEnabled")]
            [Validation(Required=false)]
            public bool? LoginEnabled { get; set; }

            /// <summary>
            /// <para>期望配置的安全摘要；不包含凭据。原 SAML 字段与含义保留。</para>
            /// </summary>
            [NameInMap("oidc")]
            [Validation(Required=false)]
            public UpdateIdentityProviderResponseBodyDataOidc Oidc { get; set; }
            public class UpdateIdentityProviderResponseBodyDataOidc : TeaModel {
                /// <summary>
                /// <para>手填模式必填的绝对 HTTPS URL；Discovery 模式不填写。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/authorize">https://idp.example.com/authorize</a></para>
                /// </summary>
                [NameInMap("authorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>默认 client_secret_post；none 必须开启 PKCE。</para>
                /// 
                /// <b>Example:</b>
                /// <para>client_secret_post</para>
                /// </summary>
                [NameInMap("clientAuthMethod")]
                [Validation(Required=false)]
                public string ClientAuthMethod { get; set; }

                /// <summary>
                /// <para>外部 IdP 中注册的客户端标识，区别于 Matrix 客户端；配置后不支持原地更换。</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-client</para>
                /// </summary>
                [NameInMap("clientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>绝对 HTTPS Discovery 地址；与手填端点互斥。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/.well-known/openid-configuration">https://idp.example.com/.well-known/openid-configuration</a></para>
                /// </summary>
                [NameInMap("discoveryEndpoint")]
                [Validation(Required=false)]
                public string DiscoveryEndpoint { get; set; }

                /// <summary>
                /// <para>外部 IdP 的绝对 HTTPS Issuer；配置后不支持原地更换。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com">https://idp.example.com</a></para>
                /// </summary>
                [NameInMap("issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>手填模式必填的绝对 HTTPS URL；Discovery 模式不填写。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/jwks">https://idp.example.com/jwks</a></para>
                /// </summary>
                [NameInMap("jwksUri")]
                [Validation(Required=false)]
                public string JwksUri { get; set; }

                /// <summary>
                /// <para>默认 true；无客户端认证时必须为 true。</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("pkceRequired")]
                [Validation(Required=false)]
                public bool? PkceRequired { get; set; }

                /// <summary>
                /// <para>字符串数组，必须包含 openid；默认 openid、profile、email。</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;openid&quot;,&quot;profile&quot;,&quot;email&quot;]</para>
                /// </summary>
                [NameInMap("scopes")]
                [Validation(Required=false)]
                public List<string> Scopes { get; set; }

                /// <summary>
                /// <para>ID Token 中用于与 SCIM externalId 匹配的 Claim 名。首次省略默认 sub；更新省略保留已保存值。Azure 可填 oid。非空且不含空白字符。查询 oidc 为保存值，oidcConfiguration 为上游实际值，可能为空。</para>
                /// 
                /// <b>Example:</b>
                /// <para>oid</para>
                /// </summary>
                [NameInMap("ssoMappingClaim")]
                [Validation(Required=false)]
                public string SsoMappingClaim { get; set; }

                /// <summary>
                /// <para>手填模式必填的绝对 HTTPS URL；Discovery 模式不填写。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/token">https://idp.example.com/token</a></para>
                /// </summary>
                [NameInMap("tokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

                /// <summary>
                /// <para>手填模式可选的绝对 HTTPS URL；Discovery 模式不填写。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/userinfo">https://idp.example.com/userinfo</a></para>
                /// </summary>
                [NameInMap("userinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The logon protocol for CustomSSO. Only SAML is supported. You can pass SAML when saving the SAML configuration. You can omit this field if you only modify loginEnabled. DingTalk and Lark do not accept this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The SAML configuration for CustomSSO. Choose either metadataXml or the four manual entry fields: entityId, loginUrl, bindingType, and x509Certificates. If not submitted, the existing configuration is retained. DingTalk and Lark do not accept this field.</para>
            /// </summary>
            [NameInMap("saml")]
            [Validation(Required=false)]
            public UpdateIdentityProviderResponseBodyDataSaml Saml { get; set; }
            public class UpdateIdentityProviderResponseBodyDataSaml : TeaModel {
                /// <summary>
                /// <para>HTTP-Redirect or HTTP-POST. Required for manual entry. The query returns the short name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>Required for manual entry. It must be non-empty and contain up to 2,048 characters. The existing configuration cannot be replaced. It is different from the local entity ID queried by the SP.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>Required for manual entry. It must be an absolute HTTPS URL and cannot contain user credentials or fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>Required for manual entry. It must be a non-empty array using PEM X.509 certificate text. The current validity period is verified. Up to two certificates are allowed after deduplication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;-----BEGIN CERTIFICATE-----\\nMIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQEL\\nBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoX\\nDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjAN\\nBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8\\noGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYN\\nW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbY\\nEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Ok\\nkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0E\\nBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQAB\\nMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUW\\nld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImca\\nWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTq\\nP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjoc\\nJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdV\\njfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5\\n-----END CERTIFICATE-----&quot;]</para>
                /// </summary>
                [NameInMap("x509Certificates")]
                [Validation(Required=false)]
                public List<string> X509Certificates { get; set; }

            }

            /// <summary>
            /// <para>The status of the identity source resource and logon configuration. For CustomSSO, a shared pool status of READY does not mean that SAML is configured. For SCIM, query operationStatus independently for the operation result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Specifies whether synchronization is enabled. Do not pass true when initializing CustomSSO. You can update this parameter only by calling the UpdateIdentityProviderSCIM operation. Determine the result in combination with operationStatus.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

            /// <summary>
            /// <para>Follows the definition of the department-based synchronization scope. If omitted during creation, the default is AllAuthorized. The initial provider synchronization is determined by syncOnBind. If omitted or set to null during an update, the original value is retained. Updating and saving the scope does not automatically execute a full synchronization.</para>
            /// </summary>
            [NameInMap("syncScope")]
            [Validation(Required=false)]
            public UpdateIdentityProviderResponseBodyDataSyncScope SyncScope { get; set; }
            public class UpdateIdentityProviderResponseBodyDataSyncScope : TeaModel {
                /// <summary>
                /// <para>For SelectedDepartments, it must contain at least one non-empty department ID, which should be obtained from ListIdentityProviderDepartments. For AllAuthorized, pass an empty array or omit it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;10001&quot;]</para>
                /// </summary>
                [NameInMap("departmentIds")]
                [Validation(Required=false)]
                public List<string> DepartmentIds { get; set; }

                /// <summary>
                /// <para>AllAuthorized: All authorized scopes, subject to application directory authorization restrictions. SelectedDepartments: Selected departments and all sub-departments. When explicitly submitting syncScope, a valid mode must be provided and verified by the backend.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SelectedDepartments</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            /// <summary>
            /// <para>Required. The ID of the destination workspace. The region of the request must be the same as the region of the destination workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-example</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the current request. This status code indicates the processing status of the request and does not represent the final result of the background task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Task result message. It indicates whether the request is accepted or returns an error message. For asynchronous tasks, check task results by calling the corresponding query API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. Retain this ID for troubleshooting and to correlate with the current API call if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-example</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current request is successful. A value of true indicates that the request is processed successfully. For asynchronous write operations, you must continue to query the task result.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
