// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token to ensure request idempotence. This value must be unique across requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-examplexxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configuration for the DingTalk identity provider.</para>
        /// </summary>
        [NameInMap("DingtalkAppConfig")]
        [Validation(Required=false)]
        public UpdateIdentityProviderRequestDingtalkAppConfig DingtalkAppConfig { get; set; }
        public class UpdateIdentityProviderRequestDingtalkAppConfig : TeaModel {
            /// <summary>
            /// <para>The AppKey of the DingTalk application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49nyeaqumk7f</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>The AppSecret of the DingTalk application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86nozWFL2CxgwnhKiXaG8dN4keLPkUNc5xxxx</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <para>The version of the DingTalk QR code login.</para>
            /// 
            /// <b>Example:</b>
            /// <para>new_version</para>
            /// </summary>
            [NameInMap("DingtalkLoginVersion")]
            [Validation(Required=false)]
            public string DingtalkLoginVersion { get; set; }

            /// <summary>
            /// <para>The EncryptKey of the DingTalk application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VkdWw91mdkrjVFr3ObNwefap21dfxxxx</para>
            /// </summary>
            [NameInMap("EncryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            /// <summary>
            /// <para>The verification token of the DingTalk application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myDingApp_VerifyTokenxxxxx</para>
            /// </summary>
            [NameInMap("VerificationToken")]
            [Validation(Required=false)]
            public string VerificationToken { get; set; }

        }

        /// <summary>
        /// <para>The ID of the identity provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp_my664lwkhpicbyzirog3xxxxx</para>
        /// </summary>
        [NameInMap("IdentityProviderId")]
        [Validation(Required=false)]
        public string IdentityProviderId { get; set; }

        /// <summary>
        /// <para>The name of the identity provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("IdentityProviderName")]
        [Validation(Required=false)]
        public string IdentityProviderName { get; set; }

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
        /// <para>The configuration for the Lark identity provider.</para>
        /// </summary>
        [NameInMap("LarkConfig")]
        [Validation(Required=false)]
        public UpdateIdentityProviderRequestLarkConfig LarkConfig { get; set; }
        public class UpdateIdentityProviderRequestLarkConfig : TeaModel {
            /// <summary>
            /// <para>The application ID of the custom application in Lark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cli_xxxx</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application secret of the custom application in Lark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KiiLzh5Dueh4wbLxxxx</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <para>The EncryptKey of the custom application in Lark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VkdWw91mdkrjVFr3ObNwefap21dfbZbKxxxx</para>
            /// </summary>
            [NameInMap("EncryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            /// <summary>
            /// <para>The verification token of the custom application in Lark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>feishuVerifyTokenxxxxx</para>
            /// </summary>
            [NameInMap("VerificationToken")]
            [Validation(Required=false)]
            public string VerificationToken { get; set; }

        }

        /// <summary>
        /// <para>The configuration for the Active Directory (AD) or Lightweight Directory Access Protocol (LDAP) identity provider.</para>
        /// </summary>
        [NameInMap("LdapConfig")]
        [Validation(Required=false)]
        public UpdateIdentityProviderRequestLdapConfig LdapConfig { get; set; }
        public class UpdateIdentityProviderRequestLdapConfig : TeaModel {
            /// <summary>
            /// <para>The password for the administrator account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("AdministratorPassword")]
            [Validation(Required=false)]
            public string AdministratorPassword { get; set; }

            /// <summary>
            /// <para>The administrator account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DC=example,DC=com</para>
            /// </summary>
            [NameInMap("AdministratorUsername")]
            [Validation(Required=false)]
            public string AdministratorUsername { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable certificate fingerprint verification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>disabled</c>: Verification is disabled.</para>
            /// </description></item>
            /// <item><description><para><c>enabled</c>: Verification is enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("CertificateFingerprintStatus")]
            [Validation(Required=false)]
            public string CertificateFingerprintStatus { get; set; }

            /// <summary>
            /// <para>The list of certificate fingerprints.</para>
            /// </summary>
            [NameInMap("CertificateFingerprints")]
            [Validation(Required=false)]
            public List<string> CertificateFingerprints { get; set; }

            /// <summary>
            /// <para>The communication protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ldap</para>
            /// </summary>
            [NameInMap("LdapProtocol")]
            [Validation(Required=false)]
            public string LdapProtocol { get; set; }

            /// <summary>
            /// <para>The server address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.xx.xx.89</para>
            /// </summary>
            [NameInMap("LdapServerHost")]
            [Validation(Required=false)]
            public string LdapServerHost { get; set; }

            /// <summary>
            /// <para>The port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>636</para>
            /// </summary>
            [NameInMap("LdapServerPort")]
            [Validation(Required=false)]
            public int? LdapServerPort { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable StartTLS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>disabled</c>: StartTLS is disabled.</para>
            /// </description></item>
            /// <item><description><para><c>enabled</c>: StartTLS is enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("StartTlsStatus")]
            [Validation(Required=false)]
            public string StartTlsStatus { get; set; }

        }

        /// <summary>
        /// <para>The URL of the application logo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas-image://idaas_23aqr2ye554csg33dqpch5exxxx/tmp/d17d9adc-a943-45e7-ba0c-2838dddea678xxxx</para>
        /// </summary>
        [NameInMap("LogoUrl")]
        [Validation(Required=false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// <para>The ID of the network access endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nae_examplexxxx</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointId")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointId { get; set; }

        /// <summary>
        /// <para>The OpenID Connect (OIDC) configuration.</para>
        /// </summary>
        [NameInMap("OidcConfig")]
        [Validation(Required=false)]
        public UpdateIdentityProviderRequestOidcConfig OidcConfig { get; set; }
        public class UpdateIdentityProviderRequestOidcConfig : TeaModel {
            /// <summary>
            /// <para>The OIDC client authentication configuration.</para>
            /// </summary>
            [NameInMap("AuthnParam")]
            [Validation(Required=false)]
            public UpdateIdentityProviderRequestOidcConfigAuthnParam AuthnParam { get; set; }
            public class UpdateIdentityProviderRequestOidcConfigAuthnParam : TeaModel {
                /// <summary>
                /// <para>The OIDC client authentication method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>client_secret_basic</c></para>
                /// </description></item>
                /// <item><description><para><c>client_secret_post</c></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>client_secret_post</para>
                /// </summary>
                [NameInMap("AuthnMethod")]
                [Validation(Required=false)]
                public string AuthnMethod { get; set; }

                /// <summary>
                /// <para>The OIDC client secret.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CSEHDddddddxxxxuxkJEHPveWRXBGqVqRsxxxx</para>
                /// </summary>
                [NameInMap("ClientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

            }

            /// <summary>
            /// <para>The OIDC endpoint configuration.</para>
            /// </summary>
            [NameInMap("EndpointConfig")]
            [Validation(Required=false)]
            public UpdateIdentityProviderRequestOidcConfigEndpointConfig EndpointConfig { get; set; }
            public class UpdateIdentityProviderRequestOidcConfigEndpointConfig : TeaModel {
                /// <summary>
                /// <para>The OIDC authorization endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/oauth/authorize">https://example.com/oauth/authorize</a></para>
                /// </summary>
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC issuer.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/oauth">https://example.com/oauth</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The JSON Web Key Set (JWKS) URI.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/oauth/jwks">https://example.com/oauth/jwks</a></para>
                /// </summary>
                [NameInMap("JwksUri")]
                [Validation(Required=false)]
                public string JwksUri { get; set; }

                /// <summary>
                /// <para>The OIDC token endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/oauth/token">https://example.com/oauth/token</a></para>
                /// </summary>
                [NameInMap("TokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC userinfo endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/oauth/userinfo">https://example.com/oauth/userinfo</a></para>
                /// </summary>
                [NameInMap("UserinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The OIDC authorization scopes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openid</para>
            /// </summary>
            [NameInMap("GrantScopes")]
            [Validation(Required=false)]
            public List<string> GrantScopes { get; set; }

            /// <summary>
            /// <para>The OIDC grant type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>authorization_code</para>
            /// </summary>
            [NameInMap("GrantType")]
            [Validation(Required=false)]
            public string GrantType { get; set; }

            /// <summary>
            /// <para>The Proof Key for Code Exchange (PKCE) method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>S256</c>: The SHA-256 algorithm.</para>
            /// </description></item>
            /// <item><description><para><c>plain</c>: The plaintext format.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S256</para>
            /// </summary>
            [NameInMap("PkceChallengeMethod")]
            [Validation(Required=false)]
            public string PkceChallengeMethod { get; set; }

            /// <summary>
            /// <para>Specifies whether PKCE is required for the authorization code grant type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PkceRequired")]
            [Validation(Required=false)]
            public bool? PkceRequired { get; set; }

        }

        /// <summary>
        /// <para>The configuration for the SAML identity provider.</para>
        /// </summary>
        [NameInMap("SamlConfig")]
        [Validation(Required=false)]
        public UpdateIdentityProviderRequestSamlConfig SamlConfig { get; set; }
        public class UpdateIdentityProviderRequestSamlConfig : TeaModel {
            /// <summary>
            /// <para>The SAML binding method for the SSO request. Valid values are <c>HTTP-POST</c> and <c>HTTP-REDIRECT</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP-REDIRECT</para>
            /// </summary>
            [NameInMap("BindingMethod")]
            [Validation(Required=false)]
            public string BindingMethod { get; set; }

            /// <summary>
            /// <para>The signing certificates from the SAML identity provider.</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<UpdateIdentityProviderRequestSamlConfigCertificates> Certificates { get; set; }
            public class UpdateIdentityProviderRequestSamlConfigCertificates : TeaModel {
                /// <summary>
                /// <para>The content of the signing certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-----BEGIN CERTIFICATE----- MIIC0jCCAbqgAwIBAgIQXXXXX-----END CERTIFICATE-----</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }

            /// <summary>
            /// <para>The entity ID of the SAML identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://dc.test.com/adfs/services/trust">http://dc.test.com/adfs/services/trust</a></para>
            /// </summary>
            [NameInMap("IdPEntityId")]
            [Validation(Required=false)]
            public string IdPEntityId { get; set; }

            /// <summary>
            /// <para>The single sign-on (SSO) URL of the SAML identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dc.test.com/adfs/ls/">https://dc.test.com/adfs/ls/</a></para>
            /// </summary>
            [NameInMap("IdPSsoUrl")]
            [Validation(Required=false)]
            public string IdPSsoUrl { get; set; }

            /// <summary>
            /// <para>The maximum allowed clock skew, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("MaxClockSkew")]
            [Validation(Required=false)]
            public long? MaxClockSkew { get; set; }

            /// <summary>
            /// <para>Specifies whether the SAML authentication request must be signed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RequireRequestSigned")]
            [Validation(Required=false)]
            public bool? RequireRequestSigned { get; set; }

            /// <summary>
            /// <para>Specifies whether the assertions in the SAML response must be signed.</para>
            /// </summary>
            [NameInMap("WantAssertionsSigned")]
            [Validation(Required=false)]
            public bool? WantAssertionsSigned { get; set; }

            /// <summary>
            /// <para>Specifies whether the SAML response must be signed.</para>
            /// </summary>
            [NameInMap("WantResponseSigned")]
            [Validation(Required=false)]
            public bool? WantResponseSigned { get; set; }

        }

        /// <summary>
        /// <para>The configuration for the WeCom identity provider.</para>
        /// </summary>
        [NameInMap("WeComConfig")]
        [Validation(Required=false)]
        public UpdateIdentityProviderRequestWeComConfig WeComConfig { get; set; }
        public class UpdateIdentityProviderRequestWeComConfig : TeaModel {
            /// <summary>
            /// <para>The agent ID of the custom application in WeCom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1237403</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The authorized callback domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.aliyunidaas.com/xxxxx">https://xxx.aliyunidaas.com/xxxxx</a></para>
            /// </summary>
            [NameInMap("AuthorizeCallbackDomain")]
            [Validation(Required=false)]
            public string AuthorizeCallbackDomain { get; set; }

            /// <summary>
            /// <para>The CorpSecret of the custom application in WeCom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CSEHDddddddxxxxuxkJEHPveWRXBGqVqRsxxxx</para>
            /// </summary>
            [NameInMap("CorpSecret")]
            [Validation(Required=false)]
            public string CorpSecret { get; set; }

            /// <summary>
            /// <para>The trusted domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.aliyunidaas.com">https://xxx.aliyunidaas.com</a></para>
            /// </summary>
            [NameInMap("TrustableDomain")]
            [Validation(Required=false)]
            public string TrustableDomain { get; set; }

        }

    }

}
