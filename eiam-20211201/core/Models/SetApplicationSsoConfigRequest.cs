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
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see How to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-examplexxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The SSO initiation method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>only_app_init_sso: SSO is initiated only by the application. This is the default value for OIDC applications. If you set this parameter to this value for a SAML application, you must specify InitLoginUrl.</para>
        /// </description></item>
        /// <item><description><para>idaas_or_app_init_sso: SSO can be initiated by the IDaaS console or the application. This is the default value for SAML applications. If you set this parameter to this value for an OIDC application, you must specify InitLoginUrl.</para>
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
        /// <para>The URL that is used to initiate SSO. You must specify this parameter if you set InitLoginType to idaas_or_app_init_sso for an OIDC application. You must specify this parameter if you set InitLoginType to only_app_init_sso for a SAML application.</para>
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
        /// <para>The SSO properties for an application that uses the OIDC protocol.</para>
        /// </summary>
        [NameInMap("OidcSsoConfig")]
        [Validation(Required=false)]
        public SetApplicationSsoConfigRequestOidcSsoConfig OidcSsoConfig { get; set; }
        public class SetApplicationSsoConfigRequestOidcSsoConfig : TeaModel {
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
            /// <para>Specifies whether the application is allowed to act as a public client to request the IDaaS authorization server. This parameter can be enabled only for the authorization code grant type and the device authorization grant type. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowedPublicClient")]
            [Validation(Required=false)]
            public bool? AllowedPublicClient { get; set; }

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
            public List<SetApplicationSsoConfigRequestOidcSsoConfigCustomClaims> CustomClaims { get; set; }
            public class SetApplicationSsoConfigRequestOidcSsoConfigCustomClaims : TeaModel {
                /// <summary>
                /// <para>The name of the claim.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Role&quot;</para>
                /// </summary>
                [NameInMap("ClaimName")]
                [Validation(Required=false)]
                public string ClaimName { get; set; }

                /// <summary>
                /// <para>The expression used to generate the value of the claim.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.dict.applicationRole</para>
                /// </summary>
                [NameInMap("ClaimValueExpression")]
                [Validation(Required=false)]
                public string ClaimValueExpression { get; set; }

            }

            /// <summary>
            /// <para>The scope parameter in the OIDC protocol. This parameter specifies the scope of user information that can be returned by the userinfo endpoint or included in the ID token.</para>
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
            /// <para>300</para>
            /// </summary>
            [NameInMap("IdTokenEffectiveTime")]
            [Validation(Required=false)]
            public long? IdTokenEffectiveTime { get; set; }

            /// <summary>
            /// <para>The ID of the identity source for the resource owner password credentials grant type. This parameter is valid only when the GrantTypes for the OIDC application is set to password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ia_password</para>
            /// </summary>
            [NameInMap("PasswordAuthenticationSourceId")]
            [Validation(Required=false)]
            public string PasswordAuthenticationSourceId { get; set; }

            /// <summary>
            /// <para>Specifies whether Time-based One-time Password (TOTP) multi-factor authentication (MFA) is required for the resource owner password credentials grant type. This parameter is valid only when the GrantTypes for the OIDC application is set to password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PasswordTotpMfaRequired")]
            [Validation(Required=false)]
            public bool? PasswordTotpMfaRequired { get; set; }

            /// <summary>
            /// <para>The algorithm used to compute the code challenge in PKCE.</para>
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
            /// <para>The list of post-logout redirect URIs that the application supports.</para>
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
            /// <para>The response type supported by the application when OidcSsoConfig.GrantTypes is set to implicit.</para>
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
        /// <para>The SSO properties for an application that uses the SAML protocol.</para>
        /// </summary>
        [NameInMap("SamlSsoConfig")]
        [Validation(Required=false)]
        public SetApplicationSsoConfigRequestSamlSsoConfig SamlSsoConfig { get; set; }
        public class SetApplicationSsoConfigRequestSamlSsoConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether the assertion must be signed. ResponseSigned and AssertionSigned cannot both be false.</para>
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
            /// <para>The configurations of additional user attributes in the SAML assertion.</para>
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
            /// <para>The default value of RelayState. When an SSO request is initiated by IDaaS, the SAML response provided by IDaaS contains this value for RelayState.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://home.console.aliyun.com">https://home.console.aliyun.com</a></para>
            /// </summary>
            [NameInMap("DefaultRelayState")]
            [Validation(Required=false)]
            public string DefaultRelayState { get; set; }

            /// <summary>
            /// <para>The entity ID of the identity provider (IdP) in the SAML protocol. The value can be in a URL or URN format.</para>
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
            /// <item><description><para>urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified: The format is not specified. The application determines how to parse the NameID.</para>
            /// </description></item>
            /// <item><description><para>urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress: The email address format.</para>
            /// </description></item>
            /// <item><description><para>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent: The persistent NameID.</para>
            /// </description></item>
            /// <item><description><para>urn:oasis:names:tc:SAML:2.0:nameid-format:transient: The transient NameID.</para>
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
            /// <para>The expression used to generate the value of the NameID in the SAML protocol.</para>
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
                /// <para>The value of RelayState.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://ram.console.aliyun.com/">https://ram.console.aliyun.com/</a></para>
                /// </summary>
                [NameInMap("RelayState")]
                [Validation(Required=false)]
                public string RelayState { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the response must be signed. ResponseSigned and AssertionSigned cannot both be false.</para>
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
            /// <para>The entity ID of the application (service provider) that uses SAML.</para>
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

    }

}
