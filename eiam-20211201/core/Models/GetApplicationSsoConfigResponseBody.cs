// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationSsoConfigResponseBody : TeaModel {
        /// <summary>
        /// The SSO configuration information of the application.
        /// </summary>
        [NameInMap("ApplicationSsoConfig")]
        [Validation(Required=false)]
        public GetApplicationSsoConfigResponseBodyApplicationSsoConfig ApplicationSsoConfig { get; set; }
        public class GetApplicationSsoConfigResponseBodyApplicationSsoConfig : TeaModel {
            /// <summary>
            /// The initial SSO method. Valid values:
            /// 
            /// *   only_app_init_sso: Only application-initiated SSO is allowed. This method is selected by default when the SSO protocol of the application is an OIDC protocol. If this method is selected when the SSO protocol of the application is SAML, the InitLoginUrl parameter is required.
            /// *   idaas_or_app_init_sso: IDaaS-initiated SSO and application-initiated SSO are allowed. This method is selected by default when the SSO protocol of the application is SAML. If this method is selected when the SSO protocol of the application is an OIDC protocol, the InitLoginUrl parameter is required.
            /// </summary>
            [NameInMap("InitLoginType")]
            [Validation(Required=false)]
            public string InitLoginType { get; set; }

            /// <summary>
            /// The initial webhook URL of SSO. This parameter is required when the SSO protocol of the application is an OIDC protocol and the InitLoginType parameters is set to idaas_or_app_init_sso or when the SSO protocol of the application is SAML and the InitLoginType parameter is set to only_app_init_sso.
            /// </summary>
            [NameInMap("InitLoginUrl")]
            [Validation(Required=false)]
            public string InitLoginUrl { get; set; }

            /// <summary>
            /// The Open ID Connect (OIDC)-based SSO configuration attributes of the application. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.
            /// </summary>
            [NameInMap("OidcSsoConfig")]
            [Validation(Required=false)]
            public GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfig OidcSsoConfig { get; set; }
            public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfig : TeaModel {
                /// <summary>
                /// The validity period of the issued access token. Unit: seconds. Default value: 1200.
                /// </summary>
                [NameInMap("AccessTokenEffectiveTime")]
                [Validation(Required=false)]
                public long? AccessTokenEffectiveTime { get; set; }

                /// <summary>
                /// The validity period of the issued code. Unit: seconds. Default value: 60.
                /// </summary>
                [NameInMap("CodeEffectiveTime")]
                [Validation(Required=false)]
                public long? CodeEffectiveTime { get; set; }

                /// <summary>
                /// The custom claims that are returned for the ID token.
                /// </summary>
                [NameInMap("CustomClaims")]
                [Validation(Required=false)]
                public List<GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfigCustomClaims> CustomClaims { get; set; }
                public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigOidcSsoConfigCustomClaims : TeaModel {
                    /// <summary>
                    /// The claim name.
                    /// </summary>
                    [NameInMap("ClaimName")]
                    [Validation(Required=false)]
                    public string ClaimName { get; set; }

                    /// <summary>
                    /// The expression that is used to generate the value of the claim.
                    /// </summary>
                    [NameInMap("ClaimValueExpression")]
                    [Validation(Required=false)]
                    public string ClaimValueExpression { get; set; }

                }

                /// <summary>
                /// The scopes of user attributes that can be returned for the UserInfo endpoint or ID token.
                /// </summary>
                [NameInMap("GrantScopes")]
                [Validation(Required=false)]
                public List<string> GrantScopes { get; set; }

                /// <summary>
                /// The list of grant types that are supported for OIDC protocols.
                /// </summary>
                [NameInMap("GrantTypes")]
                [Validation(Required=false)]
                public List<string> GrantTypes { get; set; }

                /// <summary>
                /// The validity period of the issued ID token. Unit: seconds. Default value: 300.
                /// </summary>
                [NameInMap("IdTokenEffectiveTime")]
                [Validation(Required=false)]
                public long? IdTokenEffectiveTime { get; set; }

                /// <summary>
                /// The ID of the identity authentication source in password mode. This parameter is returned only when the value of the GrantTypes parameter includes the password mode.
                /// </summary>
                [NameInMap("PasswordAuthenticationSourceId")]
                [Validation(Required=false)]
                public string PasswordAuthenticationSourceId { get; set; }

                /// <summary>
                /// Indicates whether time-based one-time password (TOTP) authentication is required in password mode. This parameter is returned only when the value of the GrantTypes parameter includes the password mode.
                /// </summary>
                [NameInMap("PasswordTotpMfaRequired")]
                [Validation(Required=false)]
                public bool? PasswordTotpMfaRequired { get; set; }

                /// <summary>
                /// The algorithms that are used to calculate the code challenge for PKCE.
                /// </summary>
                [NameInMap("PkceChallengeMethods")]
                [Validation(Required=false)]
                public List<string> PkceChallengeMethods { get; set; }

                /// <summary>
                /// Indicates whether the SSO of the application requires Proof Key for Code Exchange (PKCE) (RFC 7636).
                /// </summary>
                [NameInMap("PkceRequired")]
                [Validation(Required=false)]
                public bool? PkceRequired { get; set; }

                /// <summary>
                /// The list of logout redirect URIs that are supported by the application.
                /// </summary>
                [NameInMap("PostLogoutRedirectUris")]
                [Validation(Required=false)]
                public List<string> PostLogoutRedirectUris { get; set; }

                /// <summary>
                /// The list of redirect URIs that are supported by the application.
                /// </summary>
                [NameInMap("RedirectUris")]
                [Validation(Required=false)]
                public List<string> RedirectUris { get; set; }

                /// <summary>
                /// The validity period of the issued refresh token. Unit: seconds. Default value: 86400.
                /// </summary>
                [NameInMap("RefreshTokenEffective")]
                [Validation(Required=false)]
                public long? RefreshTokenEffective { get; set; }

                /// <summary>
                /// The response types that are supported by the application. This parameter is returned when the value of the GrantTypes parameter includes the implicit mode.
                /// </summary>
                [NameInMap("ResponseTypes")]
                [Validation(Required=false)]
                public List<string> ResponseTypes { get; set; }

                /// <summary>
                /// The custom expression that is used to generate the subject ID returned for the ID token.
                /// </summary>
                [NameInMap("SubjectIdExpression")]
                [Validation(Required=false)]
                public string SubjectIdExpression { get; set; }

            }

            /// <summary>
            /// The configuration of the metadata endpoint provided by the application.
            /// </summary>
            [NameInMap("ProtocolEndpointDomain")]
            [Validation(Required=false)]
            public GetApplicationSsoConfigResponseBodyApplicationSsoConfigProtocolEndpointDomain ProtocolEndpointDomain { get; set; }
            public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigProtocolEndpointDomain : TeaModel {
                /// <summary>
                /// The OAuth2.0 authorization endpoint. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.
                /// </summary>
                [NameInMap("Oauth2AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string Oauth2AuthorizationEndpoint { get; set; }

                /// <summary>
                /// The OAuth2.0 device authorization endpoint. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.
                /// </summary>
                [NameInMap("Oauth2DeviceAuthorizationEndpoint")]
                [Validation(Required=false)]
                public string Oauth2DeviceAuthorizationEndpoint { get; set; }

                /// <summary>
                /// The OAuth2.0 token revocation endpoint. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.
                /// </summary>
                [NameInMap("Oauth2RevokeEndpoint")]
                [Validation(Required=false)]
                public string Oauth2RevokeEndpoint { get; set; }

                /// <summary>
                /// The OAuth2.0 token endpoint. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.
                /// </summary>
                [NameInMap("Oauth2TokenEndpoint")]
                [Validation(Required=false)]
                public string Oauth2TokenEndpoint { get; set; }

                /// <summary>
                /// The OIDC UserInfo endpoint. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.
                /// </summary>
                [NameInMap("Oauth2UserinfoEndpoint")]
                [Validation(Required=false)]
                public string Oauth2UserinfoEndpoint { get; set; }

                /// <summary>
                /// The information about the OIDC issuer. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.
                /// </summary>
                [NameInMap("OidcIssuer")]
                [Validation(Required=false)]
                public string OidcIssuer { get; set; }

                /// <summary>
                /// The JSON Web Key Set (JWKS) URL of the OIDC issuer. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.
                /// </summary>
                [NameInMap("OidcJwksEndpoint")]
                [Validation(Required=false)]
                public string OidcJwksEndpoint { get; set; }

                /// <summary>
                /// The OIDC relying party (RP)-initiated logout endpoint. This parameter is returned only when the SSO protocol of the application is an OIDC protocol.
                /// </summary>
                [NameInMap("OidcLogoutEndpoint")]
                [Validation(Required=false)]
                public string OidcLogoutEndpoint { get; set; }

                /// <summary>
                /// The metadata URL of the SAML protocol. This parameter is returned only when the SSO protocol of the application is SAML 2.0.
                /// </summary>
                [NameInMap("SamlMetaEndpoint")]
                [Validation(Required=false)]
                public string SamlMetaEndpoint { get; set; }

                /// <summary>
                /// The request receiving URL of the SAML protocol. This parameter is returned only when the SSO protocol of the application is SAML 2.0.
                /// </summary>
                [NameInMap("SamlSsoEndpoint")]
                [Validation(Required=false)]
                public string SamlSsoEndpoint { get; set; }

            }

            /// <summary>
            /// The Security Assertion Markup Language (SAML)-based SSO configuration attributes of the application. This parameter is returned only when the SSO protocol of the application is SAML 2.0.
            /// </summary>
            [NameInMap("SamlSsoConfig")]
            [Validation(Required=false)]
            public GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfig SamlSsoConfig { get; set; }
            public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfig : TeaModel {
                /// <summary>
                /// assertion是否签名
                /// </summary>
                [NameInMap("AssertionSigned")]
                [Validation(Required=false)]
                public bool? AssertionSigned { get; set; }

                /// <summary>
                /// The additional user attributes in the SAML assertion.
                /// </summary>
                [NameInMap("AttributeStatements")]
                [Validation(Required=false)]
                public List<GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfigAttributeStatements> AttributeStatements { get; set; }
                public class GetApplicationSsoConfigResponseBodyApplicationSsoConfigSamlSsoConfigAttributeStatements : TeaModel {
                    /// <summary>
                    /// The attribute name.
                    /// </summary>
                    [NameInMap("AttributeName")]
                    [Validation(Required=false)]
                    public string AttributeName { get; set; }

                    /// <summary>
                    /// The expression that is used to generate the value of the attribute.
                    /// </summary>
                    [NameInMap("AttributeValueExpression")]
                    [Validation(Required=false)]
                    public string AttributeValueExpression { get; set; }

                }

                /// <summary>
                /// The default value of the RelayState attribute. If the SSO request is initiated in EIAM, the RelayState attribute in the SAML response is set to this default value.
                /// </summary>
                [NameInMap("DefaultRelayState")]
                [Validation(Required=false)]
                public string DefaultRelayState { get; set; }

                /// <summary>
                /// The Format attribute of the NameID element in the SAML assertion. Valid values:
                /// 
                /// *   urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified: No format is specified. How to resolve the NameID element depends on the application.
                /// *   urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress: The NameID element must be an email address.
                /// *   urn:oasis:names:tc:SAML:2.0:nameid-format:persistent: The NameID element must be persistent.
                /// *   urn:oasis:names:tc:SAML:2.0:nameid-format:transient: The NameID element must be transient.
                /// </summary>
                [NameInMap("NameIdFormat")]
                [Validation(Required=false)]
                public string NameIdFormat { get; set; }

                /// <summary>
                /// The expression that is used to generate the value of NameID in the SAML assertion.
                /// </summary>
                [NameInMap("NameIdValueExpression")]
                [Validation(Required=false)]
                public string NameIdValueExpression { get; set; }

                /// <summary>
                /// response是否签名
                /// </summary>
                [NameInMap("ResponseSigned")]
                [Validation(Required=false)]
                public bool? ResponseSigned { get; set; }

                /// <summary>
                /// The algorithm that is used to calculate the signature for the SAML assertion.
                /// </summary>
                [NameInMap("SignatureAlgorithm")]
                [Validation(Required=false)]
                public string SignatureAlgorithm { get; set; }

                /// <summary>
                /// The entity ID of the application in SAML. The application assumes the role of service provider.
                /// </summary>
                [NameInMap("SpEntityId")]
                [Validation(Required=false)]
                public string SpEntityId { get; set; }

                /// <summary>
                /// The Assertion Consumer Service (ACS) URL of the application in SAML. The application assumes the role of service provider.
                /// </summary>
                [NameInMap("SpSsoAcsUrl")]
                [Validation(Required=false)]
                public string SpSsoAcsUrl { get; set; }

            }

            /// <summary>
            /// The SSO feature status of the application. Valid values:
            /// 
            /// *   enabled: The feature is enabled.
            /// *   disabled: The feature is disabled.
            /// </summary>
            [NameInMap("SsoStatus")]
            [Validation(Required=false)]
            public string SsoStatus { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
