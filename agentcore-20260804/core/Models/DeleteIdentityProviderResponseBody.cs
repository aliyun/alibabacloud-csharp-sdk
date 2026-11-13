// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class DeleteIdentityProviderResponseBody : TeaModel {
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
        /// <para>The external identity provider binding information after the unbind operation is accepted.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public DeleteIdentityProviderResponseBodyData Data { get; set; }
        public class DeleteIdentityProviderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual SAML configuration is read back on demand only in GetIdentityProvider. SCIM queries and preparations return the actual receiving status and URL.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public DeleteIdentityProviderResponseBodyDataConfiguration Configuration { get; set; }
            public class DeleteIdentityProviderResponseBodyDataConfiguration : TeaModel {
                /// <summary>
                /// <para>HTTP-Redirect or HTTP-POST. Required for manual entry. Queries return the short name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>Required for manual entry. It must be non-empty and contain a maximum of 2,048 characters. Existing configurations cannot be replaced. This is different from the local entity ID queried by the service provider (SP).</para>
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
                /// <para>The actual switch value is Enabled or Disabled, which differs from the expected loginEnabled value saved in the AC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("ssoStatus")]
                [Validation(Required=false)]
                public string SsoStatus { get; set; }

            }

            /// <summary>
            /// <para>The type of the external identity provider. Valid values: DingTalk and Feishu.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("identityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>The security summary of the expected configuration. It does not contain credentials. The original SAML fields and meanings are retained.</para>
            /// </summary>
            [NameInMap("oidc")]
            [Validation(Required=false)]
            public DeleteIdentityProviderResponseBodyDataOidc Oidc { get; set; }
            public class DeleteIdentityProviderResponseBodyDataOidc : TeaModel {
                /// <summary>
                /// <para>The absolute HTTPS URL required in manual entry mode. Do not enter this in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/authorize">https://idp.example.com/authorize</a></para>
                /// </summary>
                [NameInMap("authorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The default value is client_secret_post. If none is selected, PKCE must be enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>client_secret_post</para>
                /// </summary>
                [NameInMap("clientAuthMethod")]
                [Validation(Required=false)]
                public string ClientAuthMethod { get; set; }

                /// <summary>
                /// <para>The client ID registered in the external IdP, which is different from the Matrix client. In-place replacement is not supported after configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-client</para>
                /// </summary>
                [NameInMap("clientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The absolute HTTPS discovery endpoint. It is mutually exclusive with manually entered endpoints.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/.well-known/openid-configuration">https://idp.example.com/.well-known/openid-configuration</a></para>
                /// </summary>
                [NameInMap("discoveryEndpoint")]
                [Validation(Required=false)]
                public string DiscoveryEndpoint { get; set; }

                /// <summary>
                /// <para>The absolute HTTPS issuer of the external IdP. In-place replacement is not supported after configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com">https://idp.example.com</a></para>
                /// </summary>
                [NameInMap("issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The absolute HTTPS URL required in manual entry mode. Do not enter this in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/jwks">https://idp.example.com/jwks</a></para>
                /// </summary>
                [NameInMap("jwksUri")]
                [Validation(Required=false)]
                public string JwksUri { get; set; }

                /// <summary>
                /// <para>Specifies whether PKCE is enabled. Default value: true. It must be true when client authentication is not used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("pkceRequired")]
                [Validation(Required=false)]
                public bool? PkceRequired { get; set; }

                /// <summary>
                /// <para>The string array. It must contain openid. The default values are openid, profile, and email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;openid&quot;,&quot;profile&quot;,&quot;email&quot;]</para>
                /// </summary>
                [NameInMap("scopes")]
                [Validation(Required=false)]
                public List<string> Scopes { get; set; }

                /// <summary>
                /// <para>The claim name in the ID token used to match the SCIM externalId. If omitted during the first creation, the default value sub is used. If omitted during an update, the saved value is retained. For Azure, you can enter oid. It must be non-empty and contain no whitespace characters. When queried, oidc returns the saved value, and oidcConfiguration returns the actual upstream value, which may be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oid</para>
                /// </summary>
                [NameInMap("ssoMappingClaim")]
                [Validation(Required=false)]
                public string SsoMappingClaim { get; set; }

                /// <summary>
                /// <para>The absolute HTTPS URL required in manual entry mode. Do not enter this in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/token">https://idp.example.com/token</a></para>
                /// </summary>
                [NameInMap("tokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

                /// <summary>
                /// <para>The optional absolute HTTPS URL in manual entry mode. Do not enter this in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/userinfo">https://idp.example.com/userinfo</a></para>
                /// </summary>
                [NameInMap("userinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>Currently, only SAML is supported. This field is not returned when no valid configuration is saved. Initialization with an OIDC placeholder is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The input supports either XML or complete manual entry. Queries return the standardized configuration and do not echo the original XML. This field can be omitted when not configured.</para>
            /// </summary>
            [NameInMap("saml")]
            [Validation(Required=false)]
            public DeleteIdentityProviderResponseBodyDataSaml Saml { get; set; }
            public class DeleteIdentityProviderResponseBodyDataSaml : TeaModel {
                /// <summary>
                /// <para>HTTP-Redirect or HTTP-POST. Required for manual entry. Queries return the short name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>Required for manual entry. It must be non-empty and contain a maximum of 2,048 characters. Existing configurations cannot be replaced. This is different from the local entity ID queried by the service provider (SP).</para>
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
                /// <para>Required for manual entry as a non-empty array. Use PEM X.509 certificate text. The current validity period is verified. A maximum of two certificates are allowed after deduplication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;-----BEGIN CERTIFICATE-----\\nMIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQEL\\nBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoX\\nDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjAN\\nBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8\\noGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYN\\nW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbY\\nEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Ok\\nkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0E\\nBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQAB\\nMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUW\\nld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImca\\nWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTq\\nP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjoc\\nJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdV\\njfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5\\n-----END CERTIFICATE-----&quot;]</para>
                /// </summary>
                [NameInMap("x509Certificates")]
                [Validation(Required=false)]
                public List<string> X509Certificates { get; set; }

            }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CONFIGURED: The configuration is accepted and waiting for the user pool to be activated.</description></item>
            /// <item><description>SYNCING: Organization members are being synchronized.</description></item>
            /// <item><description>SYNCED: The synchronization of organization members is complete.</description></item>
            /// <item><description>READY: The binding is in effect.</description></item>
            /// <item><description>SYNC_FAILED: The synchronization of organization members failed.</description></item>
            /// <item><description>UPDATING: The configuration is being updated.</description></item>
            /// <item><description>UPDATE_FAILED: The configuration update failed.</description></item>
            /// <item><description>DISCONNECTING: The binding is being disconnected.</description></item>
            /// <item><description>DISCONNECT_FAILED: The disconnection failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-123456</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

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
        /// <para>The response message. Returns an error description when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-123456</para>
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
