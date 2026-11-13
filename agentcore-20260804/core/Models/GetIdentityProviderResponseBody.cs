// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetIdentityProviderResponseBody : TeaModel {
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
        /// <para>The binding details of the external identity provider.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetIdentityProviderResponseBodyData Data { get; set; }
        public class GetIdentityProviderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual SAML configuration is read back on demand only in GetIdentityProvider. SCIM queries and preparations return the actual received status and URLs.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyDataConfiguration Configuration { get; set; }
            public class GetIdentityProviderResponseBodyDataConfiguration : TeaModel {
                /// <summary>
                /// <para>The SAML binding type. Valid values: HTTP-Redirect and HTTP-POST. This parameter is required when manually filled in. Queries return short names.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>This parameter is required when manually filled in. It must be non-empty and contain a maximum of 2,048 characters. Existing configurations do not support replacement. It is different from the Entity ID queried by the service provider (SP).</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>This parameter is required when manually filled in. It must be an absolute HTTPS URL and cannot contain user credentials or fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>The actual switch value is Enabled or Disabled, which is not equivalent to the expected loginEnabled value saved in AC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("ssoStatus")]
                [Validation(Required=false)]
                public string SsoStatus { get; set; }

            }

            /// <summary>
            /// <para>The creation time in UTC format based on RFC 3339.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T03:04:05Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The event subscription callback URL. You must configure this URL in the application of the external identity provider to receive organization change events. An empty string is returned when the user pool is not yet activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://auth.cn-hangzhou.agentteams.aliyuncs.com/roa/dingtalk/event/up-123456">http://auth.cn-hangzhou.agentteams.aliyuncs.com/roa/dingtalk/event/up-123456</a></para>
            /// </summary>
            [NameInMap("eventSubscriptionCallbackUrl")]
            [Validation(Required=false)]
            public string EventSubscriptionCallbackUrl { get; set; }

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
            /// <para>The logon callback URL. You must configure this URL in the application of the external identity provider. An empty string is returned when the user pool is not yet activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://signin-cn-hangzhou.aliyunagentid.com/up-123456/dingtalk/callback">https://signin-cn-hangzhou.aliyunagentid.com/up-123456/dingtalk/callback</a></para>
            /// </summary>
            [NameInMap("loginCallbackUrl")]
            [Validation(Required=false)]
            public string LoginCallbackUrl { get; set; }

            /// <summary>
            /// <para>Indicates whether workspace users are allowed to log on through this external identity provider.</para>
            /// </summary>
            [NameInMap("loginEnabled")]
            [Validation(Required=false)]
            public bool? LoginEnabled { get; set; }

            /// <summary>
            /// <para>The application configuration of the external identity provider. Application secret configurations are not returned.</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyDataMetadata Metadata { get; set; }
            public class GetIdentityProviderResponseBodyDataMetadata : TeaModel {
                /// <summary>
                /// <para>The App ID of the Lark application. This parameter is required when the binding type is Feishu.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cli_exampleappid01</para>
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The AppKey of the DingTalk application. This parameter is required when the binding type is DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexampleappkey01</para>
                /// </summary>
                [NameInMap("appKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <para>The SAML Binding URI in the historical metadata snapshot. For CustomSSO updates, use saml.bindingType.</para>
                /// 
                /// <b>Example:</b>
                /// <para>urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect</para>
                /// </summary>
                [NameInMap("binding")]
                [Validation(Required=false)]
                public string Binding { get; set; }

                /// <summary>
                /// <para>The certificate string in the historical metadata snapshot. To edit the configuration, use saml.x509Certificates and do not submit the old metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQELBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoXDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8oGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYNW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbYEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Okkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0EBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQABMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUWld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImcaWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTqP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjocJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdVjfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5</para>
                /// </summary>
                [NameInMap("certificates")]
                [Validation(Required=false)]
                public string Certificates { get; set; }

                /// <summary>
                /// <para>The CorpId of the DingTalk enterprise. This parameter is required when the binding type is DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexamplecorpid01</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>This parameter is required when manually filled in. It must be non-empty and contain a maximum of 2,048 characters. Existing configurations do not support replacement. It is different from the Entity ID queried by the service provider (SP).</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>This parameter is required when manually filled in. It must be an absolute HTTPS URL and cannot contain user credentials or fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

            }

            /// <summary>
            /// <para>The security summary of the expected configuration. It does not contain credentials. The original SAML fields and meanings are retained.</para>
            /// </summary>
            [NameInMap("oidc")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyDataOidc Oidc { get; set; }
            public class GetIdentityProviderResponseBodyDataOidc : TeaModel {
                /// <summary>
                /// <para>The absolute HTTPS URL required in manual mode. Do not specify this parameter in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/authorize">https://idp.example.com/authorize</a></para>
                /// </summary>
                [NameInMap("authorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The default value is client_secret_post. If the value is none, PKCE must be enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>client_secret_post</para>
                /// </summary>
                [NameInMap("clientAuthMethod")]
                [Validation(Required=false)]
                public string ClientAuthMethod { get; set; }

                /// <summary>
                /// <para>The client identifier registered in the external IdP, which is different from the Matrix client. In-place replacement is not supported after configuration.</para>
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
                /// <para>The absolute HTTPS URL required in manual mode. Do not specify this parameter in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/jwks">https://idp.example.com/jwks</a></para>
                /// </summary>
                [NameInMap("jwksUri")]
                [Validation(Required=false)]
                public string JwksUri { get; set; }

                /// <summary>
                /// <para>Specifies whether PKCE is enabled. Default value: true. It must be set to true when no client authentication is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("pkceRequired")]
                [Validation(Required=false)]
                public bool? PkceRequired { get; set; }

                /// <summary>
                /// <para>An array of strings that must contain openid. The default values are openid, profile, and email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;openid&quot;,&quot;profile&quot;,&quot;email&quot;]</para>
                /// </summary>
                [NameInMap("scopes")]
                [Validation(Required=false)]
                public List<string> Scopes { get; set; }

                /// <summary>
                /// <para>The claim name in the ID token used to match the SCIM externalId. If omitted during initial creation, the default value sub is used. If omitted during an update, the saved value is retained. For Azure, you can enter oid. The value must be non-empty and cannot contain whitespace characters. When you query oidc, the saved value is returned. When you query oidcConfiguration, the actual upstream value is returned, which may be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oid</para>
                /// </summary>
                [NameInMap("ssoMappingClaim")]
                [Validation(Required=false)]
                public string SsoMappingClaim { get; set; }

                /// <summary>
                /// <para>The absolute HTTPS URL required in manual mode. Do not specify this parameter in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/token">https://idp.example.com/token</a></para>
                /// </summary>
                [NameInMap("tokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

                /// <summary>
                /// <para>The optional absolute HTTPS URL in manual mode. Do not specify this parameter in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/userinfo">https://idp.example.com/userinfo</a></para>
                /// </summary>
                [NameInMap("userinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The security summary queried in real time from AgentIdentity. It does not contain secrets, private keys, or JIT fields. It can be empty when it is not configured or during unbinding.</para>
            /// </summary>
            [NameInMap("oidcConfiguration")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyDataOidcConfiguration OidcConfiguration { get; set; }
            public class GetIdentityProviderResponseBodyDataOidcConfiguration : TeaModel {
                /// <summary>
                /// <para>The absolute HTTPS URL required in manual mode. Do not specify this parameter in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/authorize">https://idp.example.com/authorize</a></para>
                /// </summary>
                [NameInMap("authorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The default value is client_secret_post. If the value is none, PKCE must be enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>client_secret_post</para>
                /// </summary>
                [NameInMap("clientAuthMethod")]
                [Validation(Required=false)]
                public string ClientAuthMethod { get; set; }

                /// <summary>
                /// <para>The client identifier registered in the external IdP, which is different from the Matrix client. In-place replacement is not supported after configuration.</para>
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
                /// <para>Indicates whether the client secret is saved. Only the existence status is returned, not the plaintext.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("hasClientPrivateKey")]
                [Validation(Required=false)]
                public bool? HasClientPrivateKey { get; set; }

                /// <summary>
                /// <para>Indicates whether the client secret is saved. Only the existence status is returned, not the plaintext.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("hasClientSecret")]
                [Validation(Required=false)]
                public bool? HasClientSecret { get; set; }

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
                /// <para>The absolute HTTPS URL required in manual mode. Do not specify this parameter in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/jwks">https://idp.example.com/jwks</a></para>
                /// </summary>
                [NameInMap("jwksUri")]
                [Validation(Required=false)]
                public string JwksUri { get; set; }

                /// <summary>
                /// <para>Specifies whether PKCE is enabled. Default value: true. It must be set to true when no client authentication is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("pkceRequired")]
                [Validation(Required=false)]
                public bool? PkceRequired { get; set; }

                /// <summary>
                /// <para>An array of strings that must contain openid. The default values are openid, profile, and email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;openid&quot;,&quot;profile&quot;,&quot;email&quot;]</para>
                /// </summary>
                [NameInMap("scopes")]
                [Validation(Required=false)]
                public List<string> Scopes { get; set; }

                /// <summary>
                /// <para>The claim name in the ID token used to match the SCIM externalId. If omitted during initial creation, the default value sub is used. If omitted during an update, the saved value is retained. For Azure, you can enter oid. The value must be non-empty and cannot contain whitespace characters. When you query oidc, the saved value is returned. When you query oidcConfiguration, the actual upstream value is returned, which may be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oid</para>
                /// </summary>
                [NameInMap("ssoMappingClaim")]
                [Validation(Required=false)]
                public string SsoMappingClaim { get; set; }

                /// <summary>
                /// <para>The current upstream logon switch, which is Enabled or Disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Disabled</para>
                /// </summary>
                [NameInMap("ssoStatus")]
                [Validation(Required=false)]
                public string SsoStatus { get; set; }

                /// <summary>
                /// <para>The absolute HTTPS URL required in manual mode. Do not specify this parameter in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/token">https://idp.example.com/token</a></para>
                /// </summary>
                [NameInMap("tokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

                /// <summary>
                /// <para>The optional absolute HTTPS URL in manual mode. Do not specify this parameter in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/userinfo">https://idp.example.com/userinfo</a></para>
                /// </summary>
                [NameInMap("userinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>Currently, only SAML is supported. This parameter may not be returned when no valid configuration is saved. Placeholder initialization with OIDC is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The input supports either XML or complete manual entry. Queries return standardized configurations and do not echo the original XML. This parameter can be omitted when not configured.</para>
            /// </summary>
            [NameInMap("saml")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyDataSaml Saml { get; set; }
            public class GetIdentityProviderResponseBodyDataSaml : TeaModel {
                /// <summary>
                /// <para>The SAML binding type. Valid values: HTTP-Redirect and HTTP-POST. This parameter is required when manually filled in. Queries return short names.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>This parameter is required when manually filled in. It must be non-empty and contain a maximum of 2,048 characters. Existing configurations do not support replacement. It is different from the Entity ID queried by the service provider (SP).</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>This parameter is required when manually filled in. It must be an absolute HTTPS URL and cannot contain user credentials or fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>When manually filled in, a non-empty array is required, using PEM X.509 certificate text. The current validity period is verified, and a maximum of two certificates are allowed after deduplication.</para>
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
            /// <para>Indicates whether organization member synchronization is enabled. When enabled, organization members are synchronized as workspace users by this external identity provider.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

            /// <summary>
            /// <para>The synchronization scope defined by department. If omitted during creation, the default value is AllAuthorized, and the first vendor synchronization is determined by syncOnBind. If omitted or set to null during an update, the original value is retained. Updating and saving the scope does not automatically trigger a full synchronization.</para>
            /// </summary>
            [NameInMap("syncScope")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyDataSyncScope SyncScope { get; set; }
            public class GetIdentityProviderResponseBodyDataSyncScope : TeaModel {
                /// <summary>
                /// <para>When the mode is SelectedDepartments, this list must contain at least one non-empty department ID, which should be obtained from ListIdentityProviderDepartments. When the mode is AllAuthorized, pass an empty array or omit this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;10001&quot;]</para>
                /// </summary>
                [NameInMap("departmentIds")]
                [Validation(Required=false)]
                public List<string> DepartmentIds { get; set; }

                /// <summary>
                /// <para>The scope mode. Valid values: AllAuthorized (all authorized scopes, limited by application address book authorization) and SelectedDepartments (selected departments and all their sub-departments). A valid mode must be provided when explicitly submitting syncScope and is verified by the backend.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SelectedDepartments</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            /// <summary>
            /// <para>The time of the last modification in UTC format based on RFC 3339.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T03:04:05Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

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
