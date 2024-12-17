// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationSsoConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The single sign-on (SSO) configuration information of the application.</para>
        /// </summary>
        [NameInMap("ApplicationSsoConfig")]
        [Validation(Required=false)]
        public GetApplicationSsoConfigResponseBodyApplicationSsoConfig ApplicationSsoConfig { get; set; }
        public class GetApplicationSsoConfigResponseBodyApplicationSsoConfig : TeaModel {
            /// <summary>
            /// <para>The initial SSO method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>only_app_init_sso: Only application-initiated SSO is allowed. This method is selected by default when the SSO protocol of the application is an OIDC protocol. If this method is selected when the SSO protocol of the application is SAML, the InitLoginUrl parameter is required.</description></item>
            /// <item><description>idaas_or_app_init_sso: IDaaS-initiated SSO and application-initiated SSO are allowed. This method is selected by default when the SSO protocol of the application is SAML. If this method is selected when the SSO protocol of the application is an OIDC protocol, the InitLoginUrl parameter is required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>only_app_init_sso</para>
            /// </summary>
            [NameInMap("InitLoginType")]
            [Validation(Required=false)]
            public string InitLoginType { get; set; }

            /// <summary>
            /// <para>The initial webhook URL of SSO. This parameter is required when the SSO protocol of the application is an OIDC protocol and the InitLoginType parameters is set to idaas_or_app_init_sso or when the SSO protocol of the application is SAML and the InitLoginType parameter is set to only_app_init_sso.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://127.0.0.1:8000/start_login?enterprise_code=ABCDEF">http://127.0.0.1:8000/start_login?enterprise_code=ABCDEF</a></para>
            /// </summary>
            [NameInMap("InitLoginUrl")]
            [Validation(Required=false)]
            public string InitLoginUrl { get; set; }

            /// <summary>
            /// <para>The Open ID Connect (OIDC)-based SSO configuration attributes of the application. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.</para>
            /// </summary>
            [NameInMap("OidcSsoConfig")]
            [Validation(Required=false)]
            public GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfig OidcSsoConfig { get; set; }
            public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfig : TeaModel {
                /// <summary>
                /// <para>The validity period of the issued access token. Unit: seconds. Default value: 1200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("AccessTokenEffectiveTime")]
                [Validation(Required=false)]
                public long? AccessTokenEffectiveTime { get; set; }

                /// <summary>
                /// <para>The validity period of the issued code. Unit: seconds. Default value: 60.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("CodeEffectiveTime")]
                [Validation(Required=false)]
                public long? CodeEffectiveTime { get; set; }

                /// <summary>
                /// <para>The custom claims that are returned for the ID token.</para>
                /// </summary>
                [NameInMap("CustomClaims")]
                [Validation(Required=false)]
                public List<GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfigCustomClaims> CustomClaims { get; set; }
                public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfigCustomClaims : TeaModel {
                    /// <summary>
                    /// <para>The claim name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>userOuIds</para>
                    /// </summary>
                    [NameInMap("ClaimName")]
                    [Validation(Required=false)]
                    public string ClaimName { get; set; }

                    /// <summary>
                    /// <para>The expression that is used to generate the value of the claim.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ObjectToJsonString(user.organizationalUnits)</para>
                    /// </summary>
                    [NameInMap("ClaimValueExpression")]
                    [Validation(Required=false)]
                    public string ClaimValueExpression { get; set; }

                }

                /// <summary>
                /// <para>The scopes of user attributes that can be returned for the UserInfo endpoint or ID token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>profile，email</para>
                /// </summary>
                [NameInMap("GrantScopes")]
                [Validation(Required=false)]
                public List<string> GrantScopes { get; set; }

                /// <summary>
                /// <para>The list of grant types that are supported for OIDC protocols.</para>
                /// 
                /// <b>Example:</b>
                /// <para>authorization_code</para>
                /// </summary>
                [NameInMap("GrantTypes")]
                [Validation(Required=false)]
                public List<string> GrantTypes { get; set; }

                /// <summary>
                /// <para>The validity period of the issued ID token. Unit: seconds. Default value: 300.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("IdTokenEffectiveTime")]
                [Validation(Required=false)]
                public long? IdTokenEffectiveTime { get; set; }

                /// <summary>
                /// <para>The ID of the identity authentication source in password mode. This parameter is returned only when the value of the GrantTypes parameter includes the password mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ia_password</para>
                /// </summary>
                [NameInMap("PasswordAuthenticationSourceId")]
                [Validation(Required=false)]
                public string PasswordAuthenticationSourceId { get; set; }

                /// <summary>
                /// <para>Indicates whether time-based one-time password (TOTP) authentication is required in password mode. This parameter is returned only when the value of the GrantTypes parameter includes the password mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PasswordTotpMfaRequired")]
                [Validation(Required=false)]
                public bool? PasswordTotpMfaRequired { get; set; }

                /// <summary>
                /// <para>The algorithms that are used to calculate the code challenge for PKCE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S256</para>
                /// </summary>
                [NameInMap("PkceChallengeMethods")]
                [Validation(Required=false)]
                public List<string> PkceChallengeMethods { get; set; }

                /// <summary>
                /// <para>Indicates whether the SSO of the application requires Proof Key for Code Exchange (PKCE) (RFC 7636).</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PkceRequired")]
                [Validation(Required=false)]
                public bool? PkceRequired { get; set; }

                /// <summary>
                /// <para>The list of logout redirect URIs that are supported by the application.</para>
                /// </summary>
                [NameInMap("PostLogoutRedirectUris")]
                [Validation(Required=false)]
                public List<string> PostLogoutRedirectUris { get; set; }

                /// <summary>
                /// <para>The list of redirect URIs that are supported by the application.</para>
                /// </summary>
                [NameInMap("RedirectUris")]
                [Validation(Required=false)]
                public List<string> RedirectUris { get; set; }

                /// <summary>
                /// <para>The validity period of the issued refresh token. Unit: seconds. Default value: 86400.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("RefreshTokenEffective")]
                [Validation(Required=false)]
                public long? RefreshTokenEffective { get; set; }

                /// <summary>
                /// <para>The response types that are supported by the application. This parameter is returned when the value of the GrantTypes parameter includes the implicit mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>token id_token</para>
                /// </summary>
                [NameInMap("ResponseTypes")]
                [Validation(Required=false)]
                public List<string> ResponseTypes { get; set; }

                /// <summary>
                /// <para>The custom expression that is used to generate the subject ID returned for the ID token.</para>
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
                /// <para>The OAuth2.0 authorization endpoint. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://l1seshcn.aliyunidaas.com/login/app/app_mltta64q65enci54slingvvsgq/oauth2/authorize">https://l1seshcn.aliyunidaas.com/login/app/app_mltta64q65enci54slingvvsgq/oauth2/authorize</a></para>
                /// </summary>
                [NameInMap("Oauth2AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string Oauth2AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The OAuth2.0 device authorization endpoint. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/device/code">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/device/code</a></para>
                /// </summary>
                [NameInMap("Oauth2DeviceAuthorizationEndpoint")]
                [Validation(Required=false)]
                public string Oauth2DeviceAuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The OAuth2.0 token revocation endpoint. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/revoke">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/revoke</a></para>
                /// </summary>
                [NameInMap("Oauth2RevokeEndpoint")]
                [Validation(Required=false)]
                public string Oauth2RevokeEndpoint { get; set; }

                /// <summary>
                /// <para>The OAuth2.0 token endpoint. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/token">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/token</a></para>
                /// </summary>
                [NameInMap("Oauth2TokenEndpoint")]
                [Validation(Required=false)]
                public string Oauth2TokenEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC UserInfo endpoint. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/userinfo">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oauth2/userinfo</a></para>
                /// </summary>
                [NameInMap("Oauth2UserinfoEndpoint")]
                [Validation(Required=false)]
                public string Oauth2UserinfoEndpoint { get; set; }

                /// <summary>
                /// <para>The information about the OIDC issuer. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oidc">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oidc</a></para>
                /// </summary>
                [NameInMap("OidcIssuer")]
                [Validation(Required=false)]
                public string OidcIssuer { get; set; }

                /// <summary>
                /// <para>The JSON Web Key Set (JWKS) URL of the OIDC issuer. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oidc/jwks">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk2676rypm/app_mltta64q65enci54slingvvsgq/oidc/jwks</a></para>
                /// </summary>
                [NameInMap("OidcJwksEndpoint")]
                [Validation(Required=false)]
                public string OidcJwksEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC relying party (RP)-initiated logout endpoint. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://l1seshcn.aliyunidaas.com/login/app/app_mltta64q65enci54slingvvsgq/oauth2/logout">https://l1seshcn.aliyunidaas.com/login/app/app_mltta64q65enci54slingvvsgq/oauth2/logout</a></para>
                /// </summary>
                [NameInMap("OidcLogoutEndpoint")]
                [Validation(Required=false)]
                public string OidcLogoutEndpoint { get; set; }

                /// <summary>
                /// <para>The metadata URL of the SAML protocol. This parameter is returned only when the SSO protocol of the application is SAML 2.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://l1seshcn.aliyunidaas.com/api/v2/app_mltuxdwd4lq4eer6tmtlmaxm5e/saml2/meta">https://l1seshcn.aliyunidaas.com/api/v2/app_mltuxdwd4lq4eer6tmtlmaxm5e/saml2/meta</a></para>
                /// </summary>
                [NameInMap("SamlMetaEndpoint")]
                [Validation(Required=false)]
                public string SamlMetaEndpoint { get; set; }

                /// <summary>
                /// <para>The request receiving URL of the SAML protocol. This parameter is returned only when the SSO protocol of the application is SAML 2.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://l1seshcn.aliyunidaas.com/login/app/app_mltuxdwd4lq4eer6tmtlmaxm5e/saml2/sso">https://l1seshcn.aliyunidaas.com/login/app/app_mltuxdwd4lq4eer6tmtlmaxm5e/saml2/sso</a></para>
                /// </summary>
                [NameInMap("SamlSsoEndpoint")]
                [Validation(Required=false)]
                public string SamlSsoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The Security Assertion Markup Language (SAML)-based SSO configuration attributes of the application. This parameter is returned only if the SSO protocol of the application is SAML 2.0.</para>
            /// </summary>
            [NameInMap("SamlSsoConfig")]
            [Validation(Required=false)]
            public GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfig SamlSsoConfig { get; set; }
            public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfig : TeaModel {
                /// <summary>
                /// <para>Whether the Assertion needs a signature. ResponseSigned and AssertionSigned cannot be false at the same time.</para>
                /// <para>true: signature is required.
                /// false: signature is not required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AssertionSigned")]
                [Validation(Required=false)]
                public bool? AssertionSigned { get; set; }

                /// <summary>
                /// <para>The additional user attributes in the SAML assertion.</para>
                /// </summary>
                [NameInMap("AttributeStatements")]
                [Validation(Required=false)]
                public List<GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfigAttributeStatements> AttributeStatements { get; set; }
                public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfigAttributeStatements : TeaModel {
                    /// <summary>
                    /// <para>The attribute name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://www.aliyun.com/SAML-Role/Attributes/RoleSessionName">https://www.aliyun.com/SAML-Role/Attributes/RoleSessionName</a></para>
                    /// </summary>
                    [NameInMap("AttributeName")]
                    [Validation(Required=false)]
                    public string AttributeName { get; set; }

                    /// <summary>
                    /// <para>The expression that is used to generate the value of the attribute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user.username</para>
                    /// </summary>
                    [NameInMap("AttributeValueExpression")]
                    [Validation(Required=false)]
                    public string AttributeValueExpression { get; set; }

                }

                /// <summary>
                /// <para>The default value of the RelayState attribute. If the SSO request is initiated in EIAM, the RelayState attribute in the SAML response is set to this default value.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://home.console.aliyun.com">https://home.console.aliyun.com</a></para>
                /// </summary>
                [NameInMap("DefaultRelayState")]
                [Validation(Required=false)]
                public string DefaultRelayState { get; set; }

                /// <summary>
                /// <para>The custom issuer ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/">https://example.com/</a></para>
                /// </summary>
                [NameInMap("IdPEntityId")]
                [Validation(Required=false)]
                public string IdPEntityId { get; set; }

                /// <summary>
                /// <para>The Format attribute of the NameID element in the SAML assertion. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified: No format is specified. How to resolve the NameID element depends on the application.</description></item>
                /// <item><description>urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress: The NameID element must be an email address.</description></item>
                /// <item><description>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent: The NameID element must be persistent.</description></item>
                /// <item><description>urn:oasis:names:tc:SAML:2.0:nameid-format:transient: The NameID element must be transient.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified</para>
                /// </summary>
                [NameInMap("NameIdFormat")]
                [Validation(Required=false)]
                public string NameIdFormat { get; set; }

                /// <summary>
                /// <para>The expression that is used to generate the value of NameID in the SAML assertion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.username</para>
                /// </summary>
                [NameInMap("NameIdValueExpression")]
                [Validation(Required=false)]
                public string NameIdValueExpression { get; set; }

                /// <summary>
                /// <para>Optional RelayState. The user will see the display names of multiple optional redirect addresses in the application card of the application portal. After the user clicks and completes SSO, they will automatically jump to the corresponding address. This field can only be filled in after the default redirect address is filled in.</para>
                /// </summary>
                [NameInMap("OptionalRelayStates")]
                [Validation(Required=false)]
                public List<GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfigOptionalRelayStates> OptionalRelayStates { get; set; }
                public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfigOptionalRelayStates : TeaModel {
                    /// <summary>
                    /// <para>The display name of the RelayState</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ram Account SSO</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>RelayState.The user will see the display names of multiple optional redirect addresses in the application card of the application portal. After the user clicks and completes SSO, they will automatically jump to the corresponding address. This field can only be filled in after the default redirect address is filled in.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://home.console.aliyun.com">https://home.console.aliyun.com</a></para>
                    /// </summary>
                    [NameInMap("RelayState")]
                    [Validation(Required=false)]
                    public string RelayState { get; set; }

                }

                /// <summary>
                /// <para>Whether the response needs to be signed. ResponseSigned and AssertionSigned cannot be false at the same time.</para>
                /// <para>true: signature is required.
                /// false: signature is not required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ResponseSigned")]
                [Validation(Required=false)]
                public bool? ResponseSigned { get; set; }

                /// <summary>
                /// <para>The algorithm that is used to calculate the signature for the SAML assertion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RSA-SHA256</para>
                /// </summary>
                [NameInMap("SignatureAlgorithm")]
                [Validation(Required=false)]
                public string SignatureAlgorithm { get; set; }

                /// <summary>
                /// <para>The entity ID of the application in SAML. The application assumes the role of service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>urn:alibaba:cloudcomputing</para>
                /// </summary>
                [NameInMap("SpEntityId")]
                [Validation(Required=false)]
                public string SpEntityId { get; set; }

                /// <summary>
                /// <para>The Assertion Consumer Service (ACS) URL of the application in SAML. The application assumes the role of service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://signin.aliyun.com/saml-role/sso">https://signin.aliyun.com/saml-role/sso</a></para>
                /// </summary>
                [NameInMap("SpSsoAcsUrl")]
                [Validation(Required=false)]
                public string SpSsoAcsUrl { get; set; }

            }

            /// <summary>
            /// <para>The SSO feature status of the application. Valid values:</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
