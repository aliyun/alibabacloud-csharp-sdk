// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetApplicationSsoConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>Idp client token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-examplexxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        /// <para>The Open ID Connect (OIDC)-based SSO configuration attributes of the application.</para>
        /// </summary>
        [NameInMap("OidcSsoConfig")]
        [Validation(Required=false)]
        public SetApplicationSsoConfigRequestOidcSsoConfig OidcSsoConfig { get; set; }
        public class SetApplicationSsoConfigRequestOidcSsoConfig : TeaModel {
            /// <summary>
            /// <para>The validity period of the issued access token. Unit: seconds. Default value: 1200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("AccessTokenEffectiveTime")]
            [Validation(Required=false)]
            public long? AccessTokenEffectiveTime { get; set; }

            [NameInMap("AllowedPublicClient")]
            [Validation(Required=false)]
            public bool? AllowedPublicClient { get; set; }

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
            public List<SetApplicationSsoConfigRequestOidcSsoConfigCustomClaims> CustomClaims { get; set; }
            public class SetApplicationSsoConfigRequestOidcSsoConfigCustomClaims : TeaModel {
                /// <summary>
                /// <para>The claim name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Role&quot;</para>
                /// </summary>
                [NameInMap("ClaimName")]
                [Validation(Required=false)]
                public string ClaimName { get; set; }

                /// <summary>
                /// <para>The expression that is used to calculate the value of the claim.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.dict.applicationRole</para>
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
            /// <para>The authorization types that are supported for OIDC protocols.</para>
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
            /// <para>300</para>
            /// </summary>
            [NameInMap("IdTokenEffectiveTime")]
            [Validation(Required=false)]
            public long? IdTokenEffectiveTime { get; set; }

            /// <summary>
            /// <para>The ID of the identity authentication source in password mode. Configure this parameter only when the value of the GrantTypes parameter includes the password mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ia_password</para>
            /// </summary>
            [NameInMap("PasswordAuthenticationSourceId")]
            [Validation(Required=false)]
            public string PasswordAuthenticationSourceId { get; set; }

            /// <summary>
            /// <para>Specifies whether time-based one-time password (TOTP) authentication is required in password mode. Configure this parameter only when the value of the GrantTypes parameter includes the password mode.</para>
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
            /// <para>Specifies whether the SSO of the application requires Proof Key for Code Exchange (PKCE) (RFC 7636).</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PkceRequired")]
            [Validation(Required=false)]
            public bool? PkceRequired { get; set; }

            /// <summary>
            /// <para>The logout redirect URIs that are supported by the application.</para>
            /// </summary>
            [NameInMap("PostLogoutRedirectUris")]
            [Validation(Required=false)]
            public List<string> PostLogoutRedirectUris { get; set; }

            /// <summary>
            /// <para>The redirect URIs that are supported by the application.</para>
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
            /// <para>The response types that are supported by the application. Configure this parameter when the value of the GrantTypes parameter includes the implicit mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>token id_token</para>
            /// </summary>
            [NameInMap("ResponseTypes")]
            [Validation(Required=false)]
            public List<string> ResponseTypes { get; set; }

            /// <summary>
            /// <para>The custom expression that is used to calculate the subject ID returned for the ID token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user.userid</para>
            /// </summary>
            [NameInMap("SubjectIdExpression")]
            [Validation(Required=false)]
            public string SubjectIdExpression { get; set; }

        }

        /// <summary>
        /// <para>The Security Assertion Markup Language (SAML)-based SSO configuration attributes of the application.</para>
        /// </summary>
        [NameInMap("SamlSsoConfig")]
        [Validation(Required=false)]
        public SetApplicationSsoConfigRequestSamlSsoConfig SamlSsoConfig { get; set; }
        public class SetApplicationSsoConfigRequestSamlSsoConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to calculate the signature for the assertion. You cannot set the ResponseSigned and AssertionSigned parameters to false at the same time. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
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
                /// <para>The expression that is used to generate the value of the attribute in the SAML assertion.</para>
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
            /// <para>IdP entityId.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/">https://example.com/</a></para>
            /// </summary>
            [NameInMap("IdPEntityId")]
            [Validation(Required=false)]
            public string IdPEntityId { get; set; }

            /// <summary>
            /// <para>The format of the NameID element in the SAML assertion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified: No format is specified. How to resolve the NameID element depends on the application.</description></item>
            /// <item><description>urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress: The NameID element must be an email address.</description></item>
            /// <item><description>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent: The NameID element must be persistent.</description></item>
            /// <item><description>urn:oasis:names:tc:SAML:2.0:nameid-format:transient: The NameID element must be transient.</description></item>
            /// </list>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified: No format is specified. This is the default value.</description></item>
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
            /// <para>user.email</para>
            /// </summary>
            [NameInMap("NameIdValueExpression")]
            [Validation(Required=false)]
            public string NameIdValueExpression { get; set; }

            /// <summary>
            /// <para>Optional relayStates</para>
            /// </summary>
            [NameInMap("OptionalRelayStates")]
            [Validation(Required=false)]
            public List<SetApplicationSsoConfigRequestSamlSsoConfigOptionalRelayStates> OptionalRelayStates { get; set; }
            public class SetApplicationSsoConfigRequestSamlSsoConfigOptionalRelayStates : TeaModel {
                /// <summary>
                /// <para>RelayState displayName</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ram</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>RelayState value</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example">https://example</a> .aliyun.com</para>
                /// </summary>
                [NameInMap("RelayState")]
                [Validation(Required=false)]
                public string RelayState { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to calculate the signature for the response. You cannot set the ResponseSigned and AssertionSigned parameters to false at the same time. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ResponseSigned")]
            [Validation(Required=false)]
            public bool? ResponseSigned { get; set; }

            /// <summary>
            /// <para>The algorithm that is used to calculate the signature for the SAML assertion.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>RSA-SHA256: the Rivest-Shamir-Adleman (RSA)-Secure Hash Algorithm 256 (SHA-256) algorithm.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RSA-SHA256</para>
            /// </summary>
            [NameInMap("SignatureAlgorithm")]
            [Validation(Required=false)]
            public string SignatureAlgorithm { get; set; }

            /// <summary>
            /// <para>The entity ID of the application in SAML.</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:cloudcomputing</para>
            /// </summary>
            [NameInMap("SpEntityId")]
            [Validation(Required=false)]
            public string SpEntityId { get; set; }

            /// <summary>
            /// <para>The Assertion Consumer Service (ACS) URL of the application in SAML.</para>
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
