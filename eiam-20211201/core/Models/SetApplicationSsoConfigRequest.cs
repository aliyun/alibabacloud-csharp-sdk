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
        /// <para>The client token that is used to ensure the idempotence of the request. Generate a unique value from your client. The value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see How to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-examplexxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The initial single sign-on (SSO) logon method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>only_app_init_sso: Only application-initiated SSO is supported. This is the default value for OIDC protocol applications. When a SAML application uses this method, InitLoginUrl must be specified.</description></item>
        /// <item><description>idaas_or_app_init_sso: Both IDaaS portal-initiated and application-initiated SSO are supported. This is the default value for SAML protocol applications. When an OIDC protocol application uses this method, InitLoginUrl must be specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>only_app_init_sso</para>
        /// </summary>
        [NameInMap("InitLoginType")]
        [Validation(Required=false)]
        public string InitLoginType { get; set; }

        /// <summary>
        /// <para>The initial single sign-on (SSO) logon trigger URL.
        /// This parameter is required when an OIDC protocol application sets InitLoginType to idaas_or_app_init_sso.
        /// This parameter is required when a SAML protocol application sets InitLoginType to only_app_init_sso.</para>
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
        /// <para>The SSO configuration parameters for an OIDC-based application.</para>
        /// </summary>
        [NameInMap("OidcSsoConfig")]
        [Validation(Required=false)]
        public SetApplicationSsoConfigRequestOidcSsoConfig OidcSsoConfig { get; set; }
        public class SetApplicationSsoConfigRequestOidcSsoConfig : TeaModel {
            /// <summary>
            /// <para>The validity period of the issued access token. Unit: seconds. Default value: 1200 (20 minutes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("AccessTokenEffectiveTime")]
            [Validation(Required=false)]
            public long? AccessTokenEffectiveTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the application is allowed to act as a public client to request the IDaaS EIAM authorization server. This parameter can be enabled only in authorization code mode and device mode. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowedPublicClient")]
            [Validation(Required=false)]
            public bool? AllowedPublicClient { get; set; }

            /// <summary>
            /// <para>The validity period of the issued code. Unit: seconds. Default value: 60 (1 minute).</para>
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
            /// <para>The OIDC standard parameter scope, which specifies the range of user attributes that can be returned by the userinfo endpoint or the id_token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>profile，email</para>
            /// </summary>
            [NameInMap("GrantScopes")]
            [Validation(Required=false)]
            public List<string> GrantScopes { get; set; }

            /// <summary>
            /// <para>The list of supported OIDC grant types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>authorization_code</para>
            /// </summary>
            [NameInMap("GrantTypes")]
            [Validation(Required=false)]
            public List<string> GrantTypes { get; set; }

            /// <summary>
            /// <para>The validity period of the issued ID token. Unit: seconds. Default value: 300 (5 minutes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("IdTokenEffectiveTime")]
            [Validation(Required=false)]
            public long? IdTokenEffectiveTime { get; set; }

            /// <summary>
            /// <para>The ID of the authentication source used in password mode. This parameter takes effect only when the GrantTypes specified for the OIDC application include the password mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ia_password</para>
            /// </summary>
            [NameInMap("PasswordAuthenticationSourceId")]
            [Validation(Required=false)]
            public string PasswordAuthenticationSourceId { get; set; }

            /// <summary>
            /// <para>Specifies whether TOTP-based secondary authentication is required for password mode. This parameter takes effect only when the GrantTypes specified for the OIDC application include the password mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PasswordTotpMfaRequired")]
            [Validation(Required=false)]
            public bool? PasswordTotpMfaRequired { get; set; }

            /// <summary>
            /// <para>The algorithm used to calculate the Code Challenge in PKCE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S256</para>
            /// </summary>
            [NameInMap("PkceChallengeMethods")]
            [Validation(Required=false)]
            public List<string> PkceChallengeMethods { get; set; }

            /// <summary>
            /// <para>Specifies whether Proof Key for Code Exchange (PKCE) (RFC 7636) is required for application SSO.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PkceRequired")]
            [Validation(Required=false)]
            public bool? PkceRequired { get; set; }

            /// <summary>
            /// <para>The list of logout callback URIs supported by the application.</para>
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
            /// <para>The validity period of the issued refresh token. Unit: seconds. Default value: 86400 (1 day).</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("RefreshTokenEffective")]
            [Validation(Required=false)]
            public long? RefreshTokenEffective { get; set; }

            /// <summary>
            /// <para>The response types supported by the application when OidcSsoConfig.GrantTypes includes the implicit grant type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>token id_token</para>
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
        /// <para>The SSO configuration parameters for a SAML-based application.</para>
        /// </summary>
        [NameInMap("SamlSsoConfig")]
        [Validation(Required=false)]
        public SetApplicationSsoConfigRequestSamlSsoConfig SamlSsoConfig { get; set; }
        public class SetApplicationSsoConfigRequestSamlSsoConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether the assertion needs to be signed. ResponseSigned and AssertionSigned cannot both be set to false.</para>
            /// <list type="bullet">
            /// <item><description>true: The assertion is signed.</description></item>
            /// <item><description>false: The assertion is not signed.</description></item>
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
            /// <para>The default RelayState value. When a single sign-on (SSO) logon request is initiated by EIAM, the SAML Response provided by EIAM specifies the RelayState as this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://home.console.aliyun.com">https://home.console.aliyun.com</a></para>
            /// </summary>
            [NameInMap("DefaultRelayState")]
            [Validation(Required=false)]
            public string DefaultRelayState { get; set; }

            /// <summary>
            /// <para>The Entity ID that represents the IdP identity in the SAML protocol. URL format and URN format are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/">https://example.com/</a></para>
            /// </summary>
            [NameInMap("IdPEntityId")]
            [Validation(Required=false)]
            public string IdPEntityId { get; set; }

            /// <summary>
            /// <para>The NameID format defined by the SAML protocol standard. Valid values:</para>
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
            /// <para>The expression used to generate the actual NameID value in the SAML protocol.</para>
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
            /// <para>Specifies whether SSO AuthnRequest signature verification is enabled. Default value: false. If set to true, spSigningCertificates must be configured (the array must not be empty).</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RequireAuthnRequestSigned")]
            [Validation(Required=false)]
            public bool? RequireAuthnRequestSigned { get; set; }

            /// <summary>
            /// <para>Specifies whether the response needs to be signed. ResponseSigned and AssertionSigned cannot both be set to false.</para>
            /// <list type="bullet">
            /// <item><description>true: The response is signed.</description></item>
            /// <item><description>false: The response is not signed.</description></item>
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
            /// <para>The SAML EntityId of the application (SP).</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:cloudcomputing</para>
            /// </summary>
            [NameInMap("SpEntityId")]
            [Validation(Required=false)]
            public string SpEntityId { get; set; }

            /// <summary>
            /// <para>The array of SP signature verification certificates in PEM format. A maximum of two certificates are allowed and are shared by SSO and SLO. Each certificate is validated for format and validity upon write. Requests with more than two certificates are rejected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE----- MIIC0jCCAbqgAwIBAgIQXXXXX -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("SpSigningCertificates")]
            [Validation(Required=false)]
            public List<string> SpSigningCertificates { get; set; }

            /// <summary>
            /// <para>The URL on the SP side that receives the LogoutResponse. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/api/slo/response">https://example.com/api/slo/response</a></para>
            /// </summary>
            [NameInMap("SpSloResponseUrl")]
            [Validation(Required=false)]
            public string SpSloResponseUrl { get; set; }

            /// <summary>
            /// <para>The SAML assertion consumer service URL of the application (SP).</para>
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
