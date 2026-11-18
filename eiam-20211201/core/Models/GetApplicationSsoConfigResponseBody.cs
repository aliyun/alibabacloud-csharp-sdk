// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationSsoConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The application single sign-on (SSO) configuration information.</para>
        /// </summary>
        [NameInMap("ApplicationSsoConfig")]
        [Validation(Required=false)]
        public GetApplicationSsoConfigResponseBodyApplicationSsoConfig ApplicationSsoConfig { get; set; }
        public class GetApplicationSsoConfigResponseBodyApplicationSsoConfig : TeaModel {
            /// <summary>
            /// <para>The initial single sign-on (SSO) logon method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>only_app_init_sso: SSO is initiated only by the application. This is the default value for applications using the OIDC protocol. If this value is specified for a SAML application, InitLoginUrl must be specified.</description></item>
            /// <item><description>idaas_or_app_init_sso: SSO can be initiated by the IDaaS portal or the application. This is the default value for applications using the SAML protocol. If this value is specified for an application using the OIDC protocol, InitLoginUrl must be specified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>only_app_init_sso</para>
            /// </summary>
            [NameInMap("InitLoginType")]
            [Validation(Required=false)]
            public string InitLoginType { get; set; }

            /// <summary>
            /// <para>The trigger URL for the initial single sign-on (SSO) logon. This parameter is required when the InitLoginType of an application using the OIDC protocol is set to idaas_or_app_init_sso, or when the InitLoginType of an application using the SAML protocol is set to only_app_init_sso.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://127.0.0.1:8000/start_login?enterprise_code=ABCDEF">http://127.0.0.1:8000/start_login?enterprise_code=ABCDEF</a></para>
            /// </summary>
            [NameInMap("InitLoginUrl")]
            [Validation(Required=false)]
            public string InitLoginUrl { get; set; }

            /// <summary>
            /// <para>The SSO attribute configuration parameters for the OIDC protocol. Returned only when the application SSO protocol is OIDC.</para>
            /// </summary>
            [NameInMap("OidcSsoConfig")]
            [Validation(Required=false)]
            public GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfig OidcSsoConfig { get; set; }
            public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfig : TeaModel {
                /// <summary>
                /// <para>The validity period of the issued access token, in seconds. Default value: 1200 (20 minutes).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("AccessTokenEffectiveTime")]
                [Validation(Required=false)]
                public long? AccessTokenEffectiveTime { get; set; }

                /// <summary>
                /// <para>Specifies whether the application is allowed to act as a public client when requesting the IDaaS EIAM authorization server. This is supported only when the authorization code mode and device authorization mode are enabled. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowedPublicClient")]
                [Validation(Required=false)]
                public string AllowedPublicClient { get; set; }

                /// <summary>
                /// <para>The validity period of the issued code, in seconds. Default value: 60 (1 minute).</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("CodeEffectiveTime")]
                [Validation(Required=false)]
                public long? CodeEffectiveTime { get; set; }

                /// <summary>
                /// <para>The custom user information included in the returned ID token.</para>
                /// </summary>
                [NameInMap("CustomClaims")]
                [Validation(Required=false)]
                public List<GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfigCustomClaims> CustomClaims { get; set; }
                public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfigCustomClaims : TeaModel {
                    /// <summary>
                    /// <para>The name of the returned claim.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>userOuIds</para>
                    /// </summary>
                    [NameInMap("ClaimName")]
                    [Validation(Required=false)]
                    public string ClaimName { get; set; }

                    /// <summary>
                    /// <para>The value expression of the returned claim.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ObjectToJsonString(user.organizationalUnits)</para>
                    /// </summary>
                    [NameInMap("ClaimValueExpression")]
                    [Validation(Required=false)]
                    public string ClaimValueExpression { get; set; }

                }

                /// <summary>
                /// <para>The standard OIDC scope parameter. It specifies the range of user attributes that the userinfo endpoint or ID token can return.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;profile&quot;,&quot;email&quot;]</para>
                /// </summary>
                [NameInMap("GrantScopes")]
                [Validation(Required=false)]
                public List<string> GrantScopes { get; set; }

                /// <summary>
                /// <para>The list of supported OIDC grant types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;authorization_code&quot;]</para>
                /// </summary>
                [NameInMap("GrantTypes")]
                [Validation(Required=false)]
                public List<string> GrantTypes { get; set; }

                /// <summary>
                /// <para>The validity period of the issued ID token, in seconds. Default value: 300 (5 minutes).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("IdTokenEffectiveTime")]
                [Validation(Required=false)]
                public long? IdTokenEffectiveTime { get; set; }

                /// <summary>
                /// <para>The ID of the authentication source used for the password mode. This parameter takes effect only when the GrantTypes specified for the OIDC application includes the password mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ia_password</para>
                /// </summary>
                [NameInMap("PasswordAuthenticationSourceId")]
                [Validation(Required=false)]
                public string PasswordAuthenticationSourceId { get; set; }

                /// <summary>
                /// <para>Specifies whether time-based one-time password (TOTP) multi-factor authentication (MFA) is mandatory for the password mode. This parameter takes effect only when the GrantTypes specified for the OIDC application includes the password mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PasswordTotpMfaRequired")]
                [Validation(Required=false)]
                public bool? PasswordTotpMfaRequired { get; set; }

                /// <summary>
                /// <para>The algorithm used to calculate the code challenge in PKCE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;S256&quot;]</para>
                /// </summary>
                [NameInMap("PkceChallengeMethods")]
                [Validation(Required=false)]
                public List<string> PkceChallengeMethods { get; set; }

                /// <summary>
                /// <para>Specifies whether Proof Key for Code Exchange (PKCE) (RFC 7636) is mandatory for the application SSO.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PkceRequired")]
                [Validation(Required=false)]
                public bool? PkceRequired { get; set; }

                /// <summary>
                /// <para>The list of logout callback URLs supported by the application.</para>
                /// </summary>
                [NameInMap("PostLogoutRedirectUris")]
                [Validation(Required=false)]
                public List<string> PostLogoutRedirectUris { get; set; }

                /// <summary>
                /// <para>The list of redirect URIs supported by the application.</para>
                /// </summary>
                [NameInMap("RedirectUris")]
                [Validation(Required=false)]
                public List<string> RedirectUris { get; set; }

                /// <summary>
                /// <para>The validity period of the issued refresh token, in seconds. Default value: 86400 (1 day).</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("RefreshTokenEffective")]
                [Validation(Required=false)]
                public long? RefreshTokenEffective { get; set; }

                /// <summary>
                /// <para>The response types supported by the application when OidcSsoConfig.GrantTypes includes the implicit mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;token id_token&quot;]</para>
                /// </summary>
                [NameInMap("ResponseTypes")]
                [Validation(Required=false)]
                public List<string> ResponseTypes { get; set; }

                /// <summary>
                /// <para>The custom expression for the sub claim value returned in the ID token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.userid</para>
                /// </summary>
                [NameInMap("SubjectIdExpression")]
                [Validation(Required=false)]
                public string SubjectIdExpression { get; set; }

            }

            /// <summary>
            /// <para>The metadata endpoint configuration provided by the application.</para>
            /// </summary>
            [NameInMap("ProtocolEndpointDomain")]
            [Validation(Required=false)]
            public GetApplicationSsoConfigResponseBodyApplicationSsoConfigProtocolEndpointDomain ProtocolEndpointDomain { get; set; }
            public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigProtocolEndpointDomain : TeaModel {
                /// <summary>
                /// <para>The OAuth 2.0 authorization endpoint. This parameter is returned only when the SSO protocol of the application is OIDC.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://l1seshcn.aliyunidaas.com/login/app/app_mltta64q65enci54slingvvsgq/oauth2/authorize">https://l1seshcn.aliyunidaas.com/login/app/app_mltta64q65enci54slingvvsgq/oauth2/authorize</a></para>
                /// </summary>
                [NameInMap("Oauth2AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string Oauth2AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The OAuth 2.0 device authorization endpoint. This parameter is returned only when the SSO protocol of the application is OIDC.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/device/code">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/device/code</a></para>
                /// </summary>
                [NameInMap("Oauth2DeviceAuthorizationEndpoint")]
                [Validation(Required=false)]
                public string Oauth2DeviceAuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The OAuth 2.0 token revocation endpoint. This parameter is returned only when the SSO protocol of the application is OIDC.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/revoke">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/revoke</a></para>
                /// </summary>
                [NameInMap("Oauth2RevokeEndpoint")]
                [Validation(Required=false)]
                public string Oauth2RevokeEndpoint { get; set; }

                /// <summary>
                /// <para>The OAuth 2.0 token endpoint. This parameter is returned only when the SSO protocol of the application is OIDC.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/token">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/token</a></para>
                /// </summary>
                [NameInMap("Oauth2TokenEndpoint")]
                [Validation(Required=false)]
                public string Oauth2TokenEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC userinfo endpoint. This parameter is returned only when the SSO protocol of the application is OIDC.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/userinfo">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/userinfo</a></para>
                /// </summary>
                [NameInMap("Oauth2UserinfoEndpoint")]
                [Validation(Required=false)]
                public string Oauth2UserinfoEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC issuer information. This parameter is returned only when the SSO protocol of the application is OIDC.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oidc">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oidc</a></para>
                /// </summary>
                [NameInMap("OidcIssuer")]
                [Validation(Required=false)]
                public string OidcIssuer { get; set; }

                /// <summary>
                /// <para>The OIDC JSON Web Key Set (JWKS) URL. This parameter is returned only when the SSO protocol of the application is OIDC.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oidc/jwks">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oidc/jwks</a></para>
                /// </summary>
                [NameInMap("OidcJwksEndpoint")]
                [Validation(Required=false)]
                public string OidcJwksEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC RP-initiated logout endpoint. This parameter is returned only when the SSO protocol of the application is OIDC.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://l1seshcn.aliyunidaas.com/login/app/app_mltta64q65enci54slingvvsgq/oauth2/logout">https://l1seshcn.aliyunidaas.com/login/app/app_mltta64q65enci54slingvvsgq/oauth2/logout</a></para>
                /// </summary>
                [NameInMap("OidcLogoutEndpoint")]
                [Validation(Required=false)]
                public string OidcLogoutEndpoint { get; set; }

                /// <summary>
                /// <para>The metadata URL for the SAML protocol. This parameter is returned only when the SSO protocol of the application is SAML 2.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://l1seshcn.aliyunidaas.com/api/v2/app_mltuxdwd4lq4eer6tmtlmaxm5e/saml2/meta">https://l1seshcn.aliyunidaas.com/api/v2/app_mltuxdwd4lq4eer6tmtlmaxm5e/saml2/meta</a></para>
                /// </summary>
                [NameInMap("SamlMetaEndpoint")]
                [Validation(Required=false)]
                public string SamlMetaEndpoint { get; set; }

                /// <summary>
                /// <para>The SAML single logout (SLO) URL on the IdP side. The service provider (SP) redirects users to this URL to initiate single logout.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/saml/slo">https://example.com/saml/slo</a></para>
                /// </summary>
                [NameInMap("SamlSloEndpoint")]
                [Validation(Required=false)]
                public string SamlSloEndpoint { get; set; }

                /// <summary>
                /// <para>The endpoint that receives SAML AuthnRequest requests. This parameter is returned only when the SSO protocol of the application is SAML 2.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://l1seshcn.aliyunidaas.com/login/app/app_mltuxdwd4lq4eer6tmtlmaxm5e/saml2/sso">https://l1seshcn.aliyunidaas.com/login/app/app_mltuxdwd4lq4eer6tmtlmaxm5e/saml2/sso</a></para>
                /// </summary>
                [NameInMap("SamlSsoEndpoint")]
                [Validation(Required=false)]
                public string SamlSsoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The SSO attribute configuration parameters for the SAML protocol. Returned only when the application SSO protocol is SAML 2.0.</para>
            /// </summary>
            [NameInMap("SamlSsoConfig")]
            [Validation(Required=false)]
            public GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfig SamlSsoConfig { get; set; }
            public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether the assertion requires a signature. ResponseSigned and AssertionSigned cannot both be false. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: A signature is required.</description></item>
                /// <item><description>false: No signature is required.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AssertionSigned")]
                [Validation(Required=false)]
                public bool? AssertionSigned { get; set; }

                /// <summary>
                /// <para>The additional user attribute configurations included in the SAML assertion.</para>
                /// </summary>
                [NameInMap("AttributeStatements")]
                [Validation(Required=false)]
                public List<GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfigAttributeStatements> AttributeStatements { get; set; }
                public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfigAttributeStatements : TeaModel {
                    /// <summary>
                    /// <para>The name of the attribute in the SAML assertion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://www.aliyun.com/SAML-Role/Attributes/RoleSessionName">https://www.aliyun.com/SAML-Role/Attributes/RoleSessionName</a></para>
                    /// </summary>
                    [NameInMap("AttributeName")]
                    [Validation(Required=false)]
                    public string AttributeName { get; set; }

                    /// <summary>
                    /// <para>The value expression of the attribute in the SAML assertion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user.username</para>
                    /// </summary>
                    [NameInMap("AttributeValueExpression")]
                    [Validation(Required=false)]
                    public string AttributeValueExpression { get; set; }

                }

                /// <summary>
                /// <para>The default RelayState value. When a user\&quot;s single sign-on logon request is initiated by EIAM, the SAML response provided by EIAM specifies the RelayState as this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://home.console.aliyun.com">https://home.console.aliyun.com</a></para>
                /// </summary>
                [NameInMap("DefaultRelayState")]
                [Validation(Required=false)]
                public string DefaultRelayState { get; set; }

                /// <summary>
                /// <para>The entity ID that represents the identity provider (IdP) in the SAML protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/">https://example.com/</a></para>
                /// </summary>
                [NameInMap("IdPEntityId")]
                [Validation(Required=false)]
                public string IdPEntityId { get; set; }

                /// <summary>
                /// <para>The standard NameID format for the SAML protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified: Unspecified. The application determines how to parse the NameID.</description></item>
                /// <item><description>urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress: Email address format.</description></item>
                /// <item><description>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent: Persistent NameID.</description></item>
                /// <item><description>urn:oasis:names:tc:SAML:2.0:nameid-format:transient: Transient NameID.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified</para>
                /// </summary>
                [NameInMap("NameIdFormat")]
                [Validation(Required=false)]
                public string NameIdFormat { get; set; }

                /// <summary>
                /// <para>The expression used to generate the actual value of the NameID for the SAML protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.username</para>
                /// </summary>
                [NameInMap("NameIdValueExpression")]
                [Validation(Required=false)]
                public string NameIdValueExpression { get; set; }

                /// <summary>
                /// <para>The optional RelayState values. On the application card in the application portal, display names for multiple optional redirect URLs are shown. After the user clicks and completes SSO, they are automatically redirected to the corresponding URL. You must specify a default redirect URL before specifying optional ones.</para>
                /// </summary>
                [NameInMap("OptionalRelayStates")]
                [Validation(Required=false)]
                public List<GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfigOptionalRelayStates> OptionalRelayStates { get; set; }
                public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfigOptionalRelayStates : TeaModel {
                    /// <summary>
                    /// <para>The display name of the RelayState.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ram Account SSO</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The optional RelayState value. On the application card in the application portal, display names for multiple optional redirect URLs are shown. After the user clicks and completes SSO, they are automatically redirected to the corresponding URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://home.console.aliyun.com">https://home.console.aliyun.com</a></para>
                    /// </summary>
                    [NameInMap("RelayState")]
                    [Validation(Required=false)]
                    public string RelayState { get; set; }

                }

                /// <summary>
                /// <para>The current status of the SSO signature verification switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RequireAuthnRequestSigned")]
                [Validation(Required=false)]
                public bool? RequireAuthnRequestSigned { get; set; }

                /// <summary>
                /// <para>Specifies whether the response requires a signature. ResponseSigned and AssertionSigned cannot both be false. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: A signature is required.</description></item>
                /// <item><description>false: No signature is required.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ResponseSigned")]
                [Validation(Required=false)]
                public bool? ResponseSigned { get; set; }

                /// <summary>
                /// <para>The signature algorithm for the SAML assertion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RSA-SHA256</para>
                /// </summary>
                [NameInMap("SignatureAlgorithm")]
                [Validation(Required=false)]
                public string SignatureAlgorithm { get; set; }

                /// <summary>
                /// <para>The SAML entity ID of the application (service provider).</para>
                /// 
                /// <b>Example:</b>
                /// <para>urn:alibaba:cloudcomputing</para>
                /// </summary>
                [NameInMap("SpEntityId")]
                [Validation(Required=false)]
                public string SpEntityId { get; set; }

                /// <summary>
                /// <para>The array of configured SP signature verification certificates in PEM format. A maximum of two certificates can be returned for the console or API caller to read and display.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;-----BEGIN CERTIFICATE----- MIIC0jCCAbqgAwIBAgIQXXXXX -----END CERTIFICATE-----&quot;]</para>
                /// </summary>
                [NameInMap("SpSigningCertificates")]
                [Validation(Required=false)]
                public List<string> SpSigningCertificates { get; set; }

                /// <summary>
                /// <para>The configured single logout (SLO) response URL for the service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/api/slo/response">https://example.com/api/slo/response</a></para>
                /// </summary>
                [NameInMap("SpSloResponseUrl")]
                [Validation(Required=false)]
                public string SpSloResponseUrl { get; set; }

                /// <summary>
                /// <para>The SAML assertion consumer service (ACS) URL of the application (service provider).</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://signin.aliyun.com/saml-role/sso">https://signin.aliyun.com/saml-role/sso</a></para>
                /// </summary>
                [NameInMap("SpSsoAcsUrl")]
                [Validation(Required=false)]
                public string SpSsoAcsUrl { get; set; }

            }

            /// <summary>
            /// <para>The status of the SSO feature for the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: The feature is enabled.</description></item>
            /// <item><description>disabled: The feature is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("SsoStatus")]
            [Validation(Required=false)]
            public string SsoStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
