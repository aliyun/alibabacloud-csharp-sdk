// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationSsoConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The SSO configuration of the application.</para>
        /// </summary>
        [NameInMap("ApplicationSsoConfig")]
        [Validation(Required=false)]
        public GetApplicationSsoConfigResponseBodyApplicationSsoConfig ApplicationSsoConfig { get; set; }
        public class GetApplicationSsoConfigResponseBodyApplicationSsoConfig : TeaModel {
            /// <summary>
            /// <para>The SSO initiation method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>only_app_init_sso: SSO is initiated only by the application. This is the default value for OIDC applications. If this method is used for a SAML application, you must specify InitLoginUrl.</para>
            /// </description></item>
            /// <item><description><para>idaas_or_app_init_sso: SSO can be initiated by the IDaaS console or the application. This is the default value for SAML applications. If this method is used for an OIDC application, you must specify InitLoginUrl.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>only_app_init_sso</para>
            /// </summary>
            [NameInMap("InitLoginType")]
            [Validation(Required=false)]
            public string InitLoginType { get; set; }

            /// <summary>
            /// <para>The URL that triggers SSO. This parameter is required when InitLoginType for an OIDC application is set to idaas_or_app_init_sso. This parameter is also required when InitLoginType for a SAML application is set to only_app_init_sso.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://127.0.0.1:8000/start_login?enterprise_code=ABCDEF">http://127.0.0.1:8000/start_login?enterprise_code=ABCDEF</a></para>
            /// </summary>
            [NameInMap("InitLoginUrl")]
            [Validation(Required=false)]
            public string InitLoginUrl { get; set; }

            /// <summary>
            /// <para>The SSO configuration parameters for the application that uses OpenID Connect (OIDC). This parameter is returned only when the application uses OIDC for SSO.</para>
            /// </summary>
            [NameInMap("OidcSsoConfig")]
            [Validation(Required=false)]
            public GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfig OidcSsoConfig { get; set; }
            public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfig : TeaModel {
                /// <summary>
                /// <para>The validity period of the access token. Unit: seconds. Default value: 1200 (20 minutes).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("AccessTokenEffectiveTime")]
                [Validation(Required=false)]
                public long? AccessTokenEffectiveTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the application is allowed to make requests to the IDaaS EIAM authorization server as a public client. This feature is supported only for the authorization code and device code grant types. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowedPublicClient")]
                [Validation(Required=false)]
                public string AllowedPublicClient { get; set; }

                /// <summary>
                /// <para>The validity period of the authorization code. Unit: seconds. Default value: 60 (1 minute).</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("CodeEffectiveTime")]
                [Validation(Required=false)]
                public long? CodeEffectiveTime { get; set; }

                /// <summary>
                /// <para>The custom claims that are returned in the ID token.</para>
                /// </summary>
                [NameInMap("CustomClaims")]
                [Validation(Required=false)]
                public List<GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfigCustomClaims> CustomClaims { get; set; }
                public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfigCustomClaims : TeaModel {
                    /// <summary>
                    /// <para>The name of the claim.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>userOuIds</para>
                    /// </summary>
                    [NameInMap("ClaimName")]
                    [Validation(Required=false)]
                    public string ClaimName { get; set; }

                    /// <summary>
                    /// <para>The expression used to generate the value of the claim.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ObjectToJsonString(user.organizationalUnits)</para>
                    /// </summary>
                    [NameInMap("ClaimValueExpression")]
                    [Validation(Required=false)]
                    public string ClaimValueExpression { get; set; }

                }

                /// <summary>
                /// <para>The OIDC-compliant scope parameter. This parameter specifies the scope of user attributes that can be returned by the userinfo endpoint or included in the ID token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>profile，email</para>
                /// </summary>
                [NameInMap("GrantScopes")]
                [Validation(Required=false)]
                public List<string> GrantScopes { get; set; }

                /// <summary>
                /// <para>The list of OIDC grant types that are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>authorization_code</para>
                /// </summary>
                [NameInMap("GrantTypes")]
                [Validation(Required=false)]
                public List<string> GrantTypes { get; set; }

                /// <summary>
                /// <para>The validity period of the ID token. Unit: seconds. Default value: 300 (5 minutes).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("IdTokenEffectiveTime")]
                [Validation(Required=false)]
                public long? IdTokenEffectiveTime { get; set; }

                /// <summary>
                /// <para>The ID of the authentication source for password-based logon. This parameter is valid only if GrantTypes for the OIDC application is set to password.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ia_password</para>
                /// </summary>
                [NameInMap("PasswordAuthenticationSourceId")]
                [Validation(Required=false)]
                public string PasswordAuthenticationSourceId { get; set; }

                /// <summary>
                /// <para>Indicates whether Time-based One-Time Password (TOTP) multi-factor authentication (MFA) is required for password-based logon. This parameter is valid only if GrantTypes for the OIDC application is set to password.</para>
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
                /// <para>S256</para>
                /// </summary>
                [NameInMap("PkceChallengeMethods")]
                [Validation(Required=false)]
                public List<string> PkceChallengeMethods { get; set; }

                /// <summary>
                /// <para>Indicates whether Proof Key for Code Exchange (PKCE) is required for the application SSO. For more information, see RFC 7636.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PkceRequired")]
                [Validation(Required=false)]
                public bool? PkceRequired { get; set; }

                /// <summary>
                /// <para>The list of post-logout redirect URIs.</para>
                /// </summary>
                [NameInMap("PostLogoutRedirectUris")]
                [Validation(Required=false)]
                public List<string> PostLogoutRedirectUris { get; set; }

                /// <summary>
                /// <para>The list of redirect URIs that the application supports.</para>
                /// </summary>
                [NameInMap("RedirectUris")]
                [Validation(Required=false)]
                public List<string> RedirectUris { get; set; }

                /// <summary>
                /// <para>The validity period of the refresh token. Unit: seconds. Default value: 86400 (1 day).</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("RefreshTokenEffective")]
                [Validation(Required=false)]
                public long? RefreshTokenEffective { get; set; }

                /// <summary>
                /// <para>The response type that the application supports. This parameter is returned only if OidcSsoConfig.GrantTypes is set to implicit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>token id_token</para>
                /// </summary>
                [NameInMap("ResponseTypes")]
                [Validation(Required=false)]
                public List<string> ResponseTypes { get; set; }

                /// <summary>
                /// <para>The expression used to generate the value of the sub claim in the ID token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.userid</para>
                /// </summary>
                [NameInMap("SubjectIdExpression")]
                [Validation(Required=false)]
                public string SubjectIdExpression { get; set; }

            }

            /// <summary>
            /// <para>The configuration of the metadata endpoint provided by the application.</para>
            /// </summary>
            [NameInMap("ProtocolEndpointDomain")]
            [Validation(Required=false)]
            public GetApplicationSsoConfigResponseBodyApplicationSsoConfigProtocolEndpointDomain ProtocolEndpointDomain { get; set; }
            public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigProtocolEndpointDomain : TeaModel {
                /// <summary>
                /// <para>The OAuth 2.0 authorization endpoint. This parameter is returned only when the application uses OIDC for SSO.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://l1seshcn.aliyunidaas.com/login/app/app_mltta64q65enci54slingvvsgq/oauth2/authorize">https://l1seshcn.aliyunidaas.com/login/app/app_mltta64q65enci54slingvvsgq/oauth2/authorize</a></para>
                /// </summary>
                [NameInMap("Oauth2AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string Oauth2AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The OAuth 2.0 device authorization endpoint. This parameter is returned only when the application uses OIDC for SSO.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/device/code">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/device/code</a></para>
                /// </summary>
                [NameInMap("Oauth2DeviceAuthorizationEndpoint")]
                [Validation(Required=false)]
                public string Oauth2DeviceAuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The OAuth 2.0 token revocation endpoint. This parameter is returned only when the application uses OIDC for SSO.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/revoke">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/revoke</a></para>
                /// </summary>
                [NameInMap("Oauth2RevokeEndpoint")]
                [Validation(Required=false)]
                public string Oauth2RevokeEndpoint { get; set; }

                /// <summary>
                /// <para>The OAuth 2.0 token endpoint. This parameter is returned only when the application uses OIDC for SSO.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/token">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/token</a></para>
                /// </summary>
                [NameInMap("Oauth2TokenEndpoint")]
                [Validation(Required=false)]
                public string Oauth2TokenEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC userinfo endpoint. This parameter is returned only when the application uses OIDC for SSO.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/userinfo">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/userinfo</a></para>
                /// </summary>
                [NameInMap("Oauth2UserinfoEndpoint")]
                [Validation(Required=false)]
                public string Oauth2UserinfoEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC issuer. This parameter is returned only when the application uses OIDC for SSO.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oidc">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oidc</a></para>
                /// </summary>
                [NameInMap("OidcIssuer")]
                [Validation(Required=false)]
                public string OidcIssuer { get; set; }

                /// <summary>
                /// <para>The JSON Web Key Set (JWKS) endpoint for OIDC. This parameter is returned only when the application uses OIDC for SSO.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oidc/jwks">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oidc/jwks</a></para>
                /// </summary>
                [NameInMap("OidcJwksEndpoint")]
                [Validation(Required=false)]
                public string OidcJwksEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC Relying Party (RP)-initiated logout endpoint. This parameter is returned only when the application uses OIDC for SSO.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://l1seshcn.aliyunidaas.com/login/app/app_mltta64q65enci54slingvvsgq/oauth2/logout">https://l1seshcn.aliyunidaas.com/login/app/app_mltta64q65enci54slingvvsgq/oauth2/logout</a></para>
                /// </summary>
                [NameInMap("OidcLogoutEndpoint")]
                [Validation(Required=false)]
                public string OidcLogoutEndpoint { get; set; }

                /// <summary>
                /// <para>The metadata endpoint for the SAML protocol. This parameter is returned only when the application uses SAML 2.0 for SSO.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://l1seshcn.aliyunidaas.com/api/v2/app_mltuxdwd4lq4eer6tmtlmaxm5e/saml2/meta">https://l1seshcn.aliyunidaas.com/api/v2/app_mltuxdwd4lq4eer6tmtlmaxm5e/saml2/meta</a></para>
                /// </summary>
                [NameInMap("SamlMetaEndpoint")]
                [Validation(Required=false)]
                public string SamlMetaEndpoint { get; set; }

                /// <summary>
                /// <para>The endpoint that receives AuthnRequest requests for the SAML protocol. This parameter is returned only when the application uses SAML 2.0 for SSO.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://l1seshcn.aliyunidaas.com/login/app/app_mltuxdwd4lq4eer6tmtlmaxm5e/saml2/sso">https://l1seshcn.aliyunidaas.com/login/app/app_mltuxdwd4lq4eer6tmtlmaxm5e/saml2/sso</a></para>
                /// </summary>
                [NameInMap("SamlSsoEndpoint")]
                [Validation(Required=false)]
                public string SamlSsoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The SSO configuration parameters for the application that uses Security Assertion Markup Language (SAML) 2.0. This parameter is returned only when the application uses SAML 2.0 for SSO.</para>
            /// </summary>
            [NameInMap("SamlSsoConfig")]
            [Validation(Required=false)]
            public GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfig SamlSsoConfig { get; set; }
            public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether the assertion needs to be signed. ResponseSigned and AssertionSigned cannot both be false.</para>
                /// <list type="bullet">
                /// <item><description><para>true: The assertion must be signed.</para>
                /// </description></item>
                /// <item><description><para>false: The assertion does not need to be signed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AssertionSigned")]
                [Validation(Required=false)]
                public bool? AssertionSigned { get; set; }

                /// <summary>
                /// <para>The configuration of additional user attributes in the SAML assertion.</para>
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
                    /// <para>The expression used to generate the value of the attribute in the SAML assertion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user.username</para>
                    /// </summary>
                    [NameInMap("AttributeValueExpression")]
                    [Validation(Required=false)]
                    public string AttributeValueExpression { get; set; }

                }

                /// <summary>
                /// <para>The default value of RelayState. If the SSO is initiated by EIAM, the RelayState in the SAML response is set to this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://home.console.aliyun.com">https://home.console.aliyun.com</a></para>
                /// </summary>
                [NameInMap("DefaultRelayState")]
                [Validation(Required=false)]
                public string DefaultRelayState { get; set; }

                /// <summary>
                /// <para>The EntityID of the identity provider (IdP) in the SAML protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/">https://example.com/</a></para>
                /// </summary>
                [NameInMap("IdPEntityId")]
                [Validation(Required=false)]
                public string IdPEntityId { get; set; }

                /// <summary>
                /// <para>The format of the NameID in the SAML protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified: Unspecified. The application determines how to parse the NameID.</para>
                /// </description></item>
                /// <item><description><para>urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress: Email address format.</para>
                /// </description></item>
                /// <item><description><para>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent: Persistent NameID.</para>
                /// </description></item>
                /// <item><description><para>urn:oasis:names:tc:SAML:2.0:nameid-format:transient: Transient NameID.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified</para>
                /// </summary>
                [NameInMap("NameIdFormat")]
                [Validation(Required=false)]
                public string NameIdFormat { get; set; }

                /// <summary>
                /// <para>The expression used to generate the value of the NameID in the SAML assertion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.username</para>
                /// </summary>
                [NameInMap("NameIdValueExpression")]
                [Validation(Required=false)]
                public string NameIdValueExpression { get; set; }

                /// <summary>
                /// <para>The optional RelayState values. The display names of multiple redirect URLs are shown on the application card in the application portal. After a user clicks a URL and completes the SSO, the user is redirected to the URL. You must specify a default redirect URL before you can specify optional RelayState values.</para>
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
                    /// <para>The optional RelayState value. The display names of multiple redirect URLs are shown on the application card in the application portal. After a user clicks a URL and completes the SSO, the user is redirected to the URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://home.console.aliyun.com">https://home.console.aliyun.com</a></para>
                    /// </summary>
                    [NameInMap("RelayState")]
                    [Validation(Required=false)]
                    public string RelayState { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the response needs to be signed. ResponseSigned and AssertionSigned cannot both be false.</para>
                /// <list type="bullet">
                /// <item><description><para>true: The response must be signed.</para>
                /// </description></item>
                /// <item><description><para>false: The response does not need to be signed.</para>
                /// </description></item>
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
                /// <para>The SAML EntityID of the application (service provider).</para>
                /// 
                /// <b>Example:</b>
                /// <para>urn:alibaba:cloudcomputing</para>
                /// </summary>
                [NameInMap("SpEntityId")]
                [Validation(Required=false)]
                public string SpEntityId { get; set; }

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
            /// <item><description><para>enabled: Enabled.</para>
            /// </description></item>
            /// <item><description><para>disabled: Disabled.</para>
            /// </description></item>
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
