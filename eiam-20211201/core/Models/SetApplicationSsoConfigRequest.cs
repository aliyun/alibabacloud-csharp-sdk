// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetApplicationSsoConfigRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>Ensures the idempotence of the request. You can generate a parameter value on your client to ensure that the parameter value is unique across different requests. The value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see How to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-examplexxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The initial single sign-on (SSO) method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>only_app_init_sso: SSO is initiated only by the application. This is the default value for OIDC applications. If this method is specified for a SAML application, InitLoginUrl must be specified.</description></item>
        /// <item><description>idaas_or_app_init_sso: SSO can be initiated by the IDaaS portal or the application. This is the default value for SAML applications. If this method is specified for an OIDC application, InitLoginUrl must be specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>only_app_init_sso</para>
        /// </summary>
        [NameInMap("InitLoginType")]
        [Validation(Required=false)]
        public string InitLoginType { get; set; }

        /// <summary>
        /// <para>The trigger URL for the initialization of single sign-on (SSO) logon.
        /// This parameter is required when the InitLoginType Settings for an OIDC protocol (Protocol Type) application are set to idaas_or_app_init_sso.
        /// This parameter is required when the InitLoginType Settings for a SAML protocol (Protocol Type) application are set to only_app_init_sso.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://127.0.0.1:8000/start_login?enterprise_code=ABCDEF">http://127.0.0.1:8000/start_login?enterprise_code=ABCDEF</a></para>
        /// </summary>
        [NameInMap("InitLoginUrl")]
        [Validation(Required=false)]
        public string InitLoginUrl { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The SSO attribute configuration parameters for the OIDC protocol.</para>
        /// </summary>
        [NameInMap("OidcSsoConfig")]
        [Validation(Required=false)]
        public SetApplicationSsoConfigRequestOidcSsoConfig OidcSsoConfig { get; set; }
        public class SetApplicationSsoConfigRequestOidcSsoConfig : TeaModel {
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
            /// <para>Specifies whether the application is allowed to request the IDaaS EIAM authorization server as a public client. This feature can be enabled only for the authorization code mode and device mode. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowedPublicClient")]
            [Validation(Required=false)]
            public bool? AllowedPublicClient { get; set; }

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
            public List<SetApplicationSsoConfigRequestOidcSsoConfigCustomClaims> CustomClaims { get; set; }
            public class SetApplicationSsoConfigRequestOidcSsoConfigCustomClaims : TeaModel {
                /// <summary>
                /// <para>The name of the returned claim.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Role&quot;</para>
                /// </summary>
                [NameInMap("ClaimName")]
                [Validation(Required=false)]
                public string ClaimName { get; set; }

                /// <summary>
                /// <para>The value expression of the returned claim.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.dict.applicationRole</para>
                /// </summary>
                [NameInMap("ClaimValueExpression")]
                [Validation(Required=false)]
                public string ClaimValueExpression { get; set; }

            }

            /// <summary>
            /// <para>The standard OIDC scope parameter, which specifies the range of user attributes that can be returned by the userinfo endpoint or the ID token.</para>
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
            /// <para>The validity period of the issued ID token, in seconds. Default value: 300 seconds (5 minutes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
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
            /// <para>Specifies whether Proof Key for Code Exchange (PKCE) (RFC 7636) is mandatory for application SSO.</para>
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
            /// <para>The validity period of the issued refresh token, in seconds. Default value: 86400 seconds (1 day).</para>
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
            /// <para>The custom value expression for the sub claim returned in the ID token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user.userid</para>
            /// </summary>
            [NameInMap("SubjectIdExpression")]
            [Validation(Required=false)]
            public string SubjectIdExpression { get; set; }

        }

        /// <summary>
        /// <para>The SSO attribute configuration parameters for the SAML protocol.</para>
        /// </summary>
        [NameInMap("SamlSsoConfig")]
        [Validation(Required=false)]
        public SetApplicationSsoConfigRequestSamlSsoConfig SamlSsoConfig { get; set; }
        public class SetApplicationSsoConfigRequestSamlSsoConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether the assertion must be signed. ResponseSigned and AssertionSigned cannot both be set to false. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The assertion must be signed.</description></item>
            /// <item><description>false: The assertion does not need to be signed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AssertionSigned")]
            [Validation(Required=false)]
            public bool? AssertionSigned { get; set; }

            /// <summary>
            /// <para>The configuration of additional user attributes included in the SAML assertion.</para>
            /// </summary>
            [NameInMap("AttributeStatements")]
            [Validation(Required=false)]
            public List<SetApplicationSsoConfigRequestSamlSsoConfigAttributeStatements> AttributeStatements { get; set; }
            public class SetApplicationSsoConfigRequestSamlSsoConfigAttributeStatements : TeaModel {
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
            /// <para>The default RelayState value. When a user\&quot;s single sign-on (SSO) logon request is initiated by EIAM, the SAML response provided by EIAM specifies the RelayState as this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://home.console.aliyun.com">https://home.console.aliyun.com</a></para>
            /// </summary>
            [NameInMap("DefaultRelayState")]
            [Validation(Required=false)]
            public string DefaultRelayState { get; set; }

            /// <summary>
            /// <para>The entity ID that represents the identity provider (IdP) in the SAML protocol. Both URL and URN formats are supported.</para>
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
            /// <para>user.email</para>
            /// </summary>
            [NameInMap("NameIdValueExpression")]
            [Validation(Required=false)]
            public string NameIdValueExpression { get; set; }

            /// <summary>
            /// <para>The optional RelayState configurations.</para>
            /// </summary>
            [NameInMap("OptionalRelayStates")]
            [Validation(Required=false)]
            public List<SetApplicationSsoConfigRequestSamlSsoConfigOptionalRelayStates> OptionalRelayStates { get; set; }
            public class SetApplicationSsoConfigRequestSamlSsoConfigOptionalRelayStates : TeaModel {
                /// <summary>
                /// <para>The display name of the RelayState.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ram</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The RelayState value.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://ram.console.aliyun.com/">https://ram.console.aliyun.com/</a></para>
                /// </summary>
                [NameInMap("RelayState")]
                [Validation(Required=false)]
                public string RelayState { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable signature verification for SSO AuthnRequest. Default value: false. If this parameter is set to true, spSigningCertificates must be configured and the array cannot be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RequireAuthnRequestSigned")]
            [Validation(Required=false)]
            public bool? RequireAuthnRequestSigned { get; set; }

            /// <summary>
            /// <para>Specifies whether the response must be signed. ResponseSigned and AssertionSigned cannot both be set to false. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The response must be signed.</description></item>
            /// <item><description>false: The response does not need to be signed.</description></item>
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
            /// <para>The SAML entity ID of the application (SP).</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:cloudcomputing</para>
            /// </summary>
            [NameInMap("SpEntityId")]
            [Validation(Required=false)]
            public string SpEntityId { get; set; }

            /// <summary>
            /// <para>The array of SP signature verification certificates in PEM format. A maximum of two certificates are allowed, and they are shared by SSO and single logout (SLO). The format and validity of each certificate are verified during writing. If more than two certificates are provided, the request is rejected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;-----BEGIN CERTIFICATE----- MIIC0jCCAbqgAwIBAgIQXXXXX -----END CERTIFICATE-----&quot;]</para>
            /// </summary>
            [NameInMap("SpSigningCertificates")]
            [Validation(Required=false)]
            public List<string> SpSigningCertificates { get; set; }

            /// <summary>
            /// <para>The callback URL used by the SP to receive the LogoutResponse. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/api/slo/response">https://example.com/api/slo/response</a></para>
            /// </summary>
            [NameInMap("SpSloResponseUrl")]
            [Validation(Required=false)]
            public string SpSloResponseUrl { get; set; }

            /// <summary>
            /// <para>The SAML assertion consumer URL of the application (SP).</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://signin.aliyun.com/saml-role/sso">https://signin.aliyun.com/saml-role/sso</a></para>
            /// </summary>
            [NameInMap("SpSsoAcsUrl")]
            [Validation(Required=false)]
            public string SpSsoAcsUrl { get; set; }

        }

    }

}
