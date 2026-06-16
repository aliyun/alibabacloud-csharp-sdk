// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>The authentication configurations.</para>
        /// </summary>
        [NameInMap("AuthnConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAuthnConfig AuthnConfig { get; set; }
        public class CreateIdentityProviderRequestAuthnConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether the IdP supports authentication. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled</para>
            /// </description></item>
            /// <item><description><para>enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AuthnStatus")]
            [Validation(Required=false)]
            public string AuthnStatus { get; set; }

            /// <summary>
            /// <para>Specifies whether to automatically update passwords. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled</para>
            /// </description></item>
            /// <item><description><para>enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AutoUpdatePasswordStatus")]
            [Validation(Required=false)]
            public string AutoUpdatePasswordStatus { get; set; }

        }

        /// <summary>
        /// <para>The rule configurations for automatic account creation.</para>
        /// </summary>
        [NameInMap("AutoCreateUserConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAutoCreateUserConfig AutoCreateUserConfig { get; set; }
        public class CreateIdentityProviderRequestAutoCreateUserConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically create accounts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled</para>
            /// </description></item>
            /// <item><description><para>enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AutoCreateUserStatus")]
            [Validation(Required=false)]
            public string AutoCreateUserStatus { get; set; }

            /// <summary>
            /// <para>The collection of target organizational unit IDs.</para>
            /// </summary>
            [NameInMap("TargetOrganizationalUnitIds")]
            [Validation(Required=false)]
            public List<string> TargetOrganizationalUnitIds { get; set; }

        }

        /// <summary>
        /// <para>The rule configurations for automatic account updates.</para>
        /// </summary>
        [NameInMap("AutoUpdateUserConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAutoUpdateUserConfig AutoUpdateUserConfig { get; set; }
        public class CreateIdentityProviderRequestAutoUpdateUserConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically update accounts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled</para>
            /// </description></item>
            /// <item><description><para>enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AutoUpdateUserStatus")]
            [Validation(Required=false)]
            public string AutoUpdateUserStatus { get; set; }

        }

        /// <summary>
        /// <para>The account binding rule configurations for the OIDC identity provider.</para>
        /// </summary>
        [NameInMap("BindingConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestBindingConfig BindingConfig { get; set; }
        public class CreateIdentityProviderRequestBindingConfig : TeaModel {
            /// <summary>
            /// <para>The list of rules for automatically matching accounts.</para>
            /// </summary>
            [NameInMap("AutoMatchUserProfileExpressions")]
            [Validation(Required=false)]
            public List<CreateIdentityProviderRequestBindingConfigAutoMatchUserProfileExpressions> AutoMatchUserProfileExpressions { get; set; }
            public class CreateIdentityProviderRequestBindingConfigAutoMatchUserProfileExpressions : TeaModel {
                /// <summary>
                /// <para>The type of the expression. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>field</para>
                /// </description></item>
                /// <item><description><para>expression</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>field</para>
                /// </summary>
                [NameInMap("ExpressionMappingType")]
                [Validation(Required=false)]
                public string ExpressionMappingType { get; set; }

                /// <summary>
                /// <para>The expression for the value of the mapped attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idpUser.phoneNumber</para>
                /// </summary>
                [NameInMap("SourceValueExpression")]
                [Validation(Required=false)]
                public string SourceValueExpression { get; set; }

                /// <summary>
                /// <para>The name of the target mapped attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.username</para>
                /// </summary>
                [NameInMap("TargetField")]
                [Validation(Required=false)]
                public string TargetField { get; set; }

                /// <summary>
                /// <para>The name of the mapping\&quot;s target property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("TargetFieldDescription")]
                [Validation(Required=false)]
                public string TargetFieldDescription { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to automatically match accounts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled</para>
            /// </description></item>
            /// <item><description><para>enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AutoMatchUserStatus")]
            [Validation(Required=false)]
            public string AutoMatchUserStatus { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow users to manually bind accounts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled</para>
            /// </description></item>
            /// <item><description><para>enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("MappingBindingStatus")]
            [Validation(Required=false)]
            public string MappingBindingStatus { get; set; }

        }

        /// <summary>
        /// <para>A client token used to ensure the idempotence of the request. Generate a unique value from your client for each request. The ClientToken can only contain ASCII characters. Note: If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may be different for each API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clientToken_20250704_Axxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The DingTalk configurations.</para>
        /// </summary>
        [NameInMap("DingtalkAppConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestDingtalkAppConfig DingtalkAppConfig { get; set; }
        public class CreateIdentityProviderRequestDingtalkAppConfig : TeaModel {
            /// <summary>
            /// <para>The AppKey of the DingTalk application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Xczngvfemo4e</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>The AppSecret of the DingTalk application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5d405a12a6f84ad4ab05ee09axxxx</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <para>The CorpId of the DingTalk application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>307568042478613xxxx</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The DingTalk version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>public_dingtalk: Standard DingTalk</para>
            /// </description></item>
            /// <item><description><para>private_dingtalk: Enterprise DingTalk</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>public_dingtalk</para>
            /// </summary>
            [NameInMap("DingtalkVersion")]
            [Validation(Required=false)]
            public string DingtalkVersion { get; set; }

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
            /// <para>The VerificationToken of the DingTalk application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myDingApp_VerifyTokenxxxxx</para>
            /// </summary>
            [NameInMap("VerificationToken")]
            [Validation(Required=false)]
            public string VerificationToken { get; set; }

        }

        /// <summary>
        /// <para>The name of the identity provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("IdentityProviderName")]
        [Validation(Required=false)]
        public string IdentityProviderName { get; set; }

        /// <summary>
        /// <para>The synchronization type of the identity provider.</para>
        /// <list type="bullet">
        /// <item><description><para>Inbound DingTalk: urn:alibaba:idaas:idp:alibaba:dingtalk:pull</para>
        /// </description></item>
        /// <item><description><para>Outbound DingTalk: urn:alibaba:idaas:idp:alibaba:dingtalk:push</para>
        /// </description></item>
        /// <item><description><para>Inbound WeCom: urn:alibaba:idaas:idp:tencent:wecom:pull</para>
        /// </description></item>
        /// <item><description><para>Inbound Lark: urn:alibaba:idaas:idp:bytedance:lark:pull</para>
        /// </description></item>
        /// <item><description><para>Inbound AD: urn:alibaba:idaas:idp:microsoft:ad:pull</para>
        /// </description></item>
        /// <item><description><para>Inbound LDAP: urn:alibaba:idaas:idp:unknown:ldap:pull</para>
        /// </description></item>
        /// <item><description><para>Standard OIDC: urn:alibaba:idaas:idp:standard:oidc</para>
        /// </description></item>
        /// <item><description><para>SASE-specific OIDC: urn:alibaba:idaas:idp:alibaba:sase</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:alibaba:idaas:idp:alibaba:dingtalk:push</para>
        /// </summary>
        [NameInMap("IdentityProviderType")]
        [Validation(Required=false)]
        public string IdentityProviderType { get; set; }

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
        /// <para>The Lark configurations.</para>
        /// </summary>
        [NameInMap("LarkConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestLarkConfig LarkConfig { get; set; }
        public class CreateIdentityProviderRequestLarkConfig : TeaModel {
            /// <summary>
            /// <para>The AppId of the Lark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cli_xxxx</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The App Secret of the Lark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KiiLzh5Dueh4wbLxxxx</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <para>The EncryptKey of the custom Lark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VkdWw91mdkrjVFr3ObNwefap21dfxxxx</para>
            /// </summary>
            [NameInMap("EncryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            /// <summary>
            /// <para>The enterprise code of Lark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FSX123111xxx</para>
            /// </summary>
            [NameInMap("EnterpriseNumber")]
            [Validation(Required=false)]
            public string EnterpriseNumber { get; set; }

            /// <summary>
            /// <para>The VerificationToken of the custom Lark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>feishuVerifyTokenxxxxx</para>
            /// </summary>
            [NameInMap("VerificationToken")]
            [Validation(Required=false)]
            public string VerificationToken { get; set; }

        }

        /// <summary>
        /// <para>The AD/LDAP configurations.</para>
        /// </summary>
        [NameInMap("LdapConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestLdapConfig LdapConfig { get; set; }
        public class CreateIdentityProviderRequestLdapConfig : TeaModel {
            /// <summary>
            /// <para>The administrator password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
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
            /// <para>Specifies whether to verify the certificate fingerprint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled</para>
            /// </description></item>
            /// <item><description><para>enabled</para>
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
            /// <para>The group member identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>member</para>
            /// </summary>
            [NameInMap("GroupMemberAttributeName")]
            [Validation(Required=false)]
            public string GroupMemberAttributeName { get; set; }

            /// <summary>
            /// <para>The objectClass for groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group</para>
            /// </summary>
            [NameInMap("GroupObjectClass")]
            [Validation(Required=false)]
            public string GroupObjectClass { get; set; }

            /// <summary>
            /// <para>The custom filter for groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(|(cn=test)(group=<a href="mailto:test@test.com">test@test.com</a>))</para>
            /// </summary>
            [NameInMap("GroupObjectClassCustomFilter")]
            [Validation(Required=false)]
            public string GroupObjectClassCustomFilter { get; set; }

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
            /// <para>The address of the AD/LDAP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.xx.xx.89</para>
            /// </summary>
            [NameInMap("LdapServerHost")]
            [Validation(Required=false)]
            public string LdapServerHost { get; set; }

            /// <summary>
            /// <para>The port number of the AD/LDAP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>636</para>
            /// </summary>
            [NameInMap("LdapServerPort")]
            [Validation(Required=false)]
            public int? LdapServerPort { get; set; }

            /// <summary>
            /// <para>The objectClass for organizational units.</para>
            /// 
            /// <b>Example:</b>
            /// <para>organizationUnit,top</para>
            /// </summary>
            [NameInMap("OrganizationUnitObjectClass")]
            [Validation(Required=false)]
            public string OrganizationUnitObjectClass { get; set; }

            /// <summary>
            /// <para>The RDN for organizational units.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou</para>
            /// </summary>
            [NameInMap("OrganizationalUnitRdn")]
            [Validation(Required=false)]
            public string OrganizationalUnitRdn { get; set; }

            /// <summary>
            /// <para>The switch for password synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordSyncStatus")]
            [Validation(Required=false)]
            public string PasswordSyncStatus { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable StartTLS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled</para>
            /// </description></item>
            /// <item><description><para>enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("StartTlsStatus")]
            [Validation(Required=false)]
            public string StartTlsStatus { get; set; }

            /// <summary>
            /// <para>The user logon identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>userPrincipalName, mail</para>
            /// </summary>
            [NameInMap("UserLoginIdentifier")]
            [Validation(Required=false)]
            public string UserLoginIdentifier { get; set; }

            /// <summary>
            /// <para>The objectClass for users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>person,user</para>
            /// </summary>
            [NameInMap("UserObjectClass")]
            [Validation(Required=false)]
            public string UserObjectClass { get; set; }

            /// <summary>
            /// <para>The custom filter for users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(|(cn=test)(mail=<a href="mailto:test@test.com">test@test.com</a>))</para>
            /// </summary>
            [NameInMap("UserObjectClassCustomFilter")]
            [Validation(Required=false)]
            public string UserObjectClassCustomFilter { get; set; }

            /// <summary>
            /// <para>The RDN for users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("UserRdn")]
            [Validation(Required=false)]
            public string UserRdn { get; set; }

        }

        /// <summary>
        /// <para>The URL of the application logo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-image://xxxx_23aqr2ye554csg33dqpch5eu3q/tmp/d17d9adc-a943-45e7-ba0c-2838dddea678</para>
        /// </summary>
        [NameInMap("LogoUrl")]
        [Validation(Required=false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// <para>The network endpoint ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nae_examplexxxx</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointId")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointId { get; set; }

        /// <summary>
        /// <para>The OIDC IdP configurations.</para>
        /// </summary>
        [NameInMap("OidcConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestOidcConfig OidcConfig { get; set; }
        public class CreateIdentityProviderRequestOidcConfig : TeaModel {
            /// <summary>
            /// <para>The OIDC client authentication configurations.</para>
            /// </summary>
            [NameInMap("AuthnParam")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestOidcConfigAuthnParam AuthnParam { get; set; }
            public class CreateIdentityProviderRequestOidcConfigAuthnParam : TeaModel {
                /// <summary>
                /// <para>The OIDC authentication method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>client_secret_basic</para>
                /// </description></item>
                /// <item><description><para>client_secret_post</para>
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
                /// <para>The OIDC client ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mkv7rgt4d7i4u7zqtzev2mxxxx</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The OpenID Connect (OIDC) client secret.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CSEHDddddddxxxxuxkJEHPveWRXBGqVqRsxxxx</para>
                /// </summary>
                [NameInMap("ClientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

            }

            /// <summary>
            /// <para>The OIDC endpoint configurations.</para>
            /// </summary>
            [NameInMap("EndpointConfig")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestOidcConfigEndpointConfig EndpointConfig { get; set; }
            public class CreateIdentityProviderRequestOidcConfigEndpointConfig : TeaModel {
                /// <summary>
                /// <para>The OIDC authorization endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/authorize">https://example.com/auth/authorize</a></para>
                /// </summary>
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC issuer.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth">https://example.com/auth</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The OIDC JWKS URI.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/jwks">https://example.com/auth/jwks</a></para>
                /// </summary>
                [NameInMap("JwksUri")]
                [Validation(Required=false)]
                public string JwksUri { get; set; }

                /// <summary>
                /// <para>The OIDC token endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/token">https://example.com/auth/token</a></para>
                /// </summary>
                [NameInMap("TokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

                /// <summary>
                /// <para>The OIDC user information endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/userinfo">https://example.com/auth/userinfo</a></para>
                /// </summary>
                [NameInMap("UserinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The collection of OIDC authorization scopes.</para>
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
            /// <para>The PKCE algorithm. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>S256: SHA256</para>
            /// </description></item>
            /// <item><description><para>plain: Plaintext</para>
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
            /// <para>Specifies whether to use PKCE in the Authorization Code grant type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PkceRequired")]
            [Validation(Required=false)]
            public bool? PkceRequired { get; set; }

        }

        [NameInMap("SamlConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestSamlConfig SamlConfig { get; set; }
        public class CreateIdentityProviderRequestSamlConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>HTTP-REDIRECT</para>
            /// </summary>
            [NameInMap("BindingMethod")]
            [Validation(Required=false)]
            public string BindingMethod { get; set; }

            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<CreateIdentityProviderRequestSamlConfigCertificates> Certificates { get; set; }
            public class CreateIdentityProviderRequestSamlConfigCertificates : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>-----BEGIN CERTIFICATE----- MIIC0jCCAbqgAwIBAgIQXXXXX-----END CERTIFICATE-----</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://dc.test.com/adfs/services/trust">http://dc.test.com/adfs/services/trust</a></para>
            /// </summary>
            [NameInMap("IdPEntityId")]
            [Validation(Required=false)]
            public string IdPEntityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://dc.test.com/adfs/ls/">https://dc.test.com/adfs/ls/</a></para>
            /// </summary>
            [NameInMap("IdPSsoUrl")]
            [Validation(Required=false)]
            public string IdPSsoUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("MaxClockSkew")]
            [Validation(Required=false)]
            public long? MaxClockSkew { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RequireRequestSigned")]
            [Validation(Required=false)]
            public bool? RequireRequestSigned { get; set; }

            [NameInMap("WantAssertionsSigned")]
            [Validation(Required=false)]
            public bool? WantAssertionsSigned { get; set; }

            [NameInMap("WantResponseSigned")]
            [Validation(Required=false)]
            public bool? WantResponseSigned { get; set; }

        }

        /// <summary>
        /// <para>The inbound synchronization configurations.</para>
        /// </summary>
        [NameInMap("UdPullConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestUdPullConfig UdPullConfig { get; set; }
        public class CreateIdentityProviderRequestUdPullConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to synchronize groups. The default value is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled</para>
            /// </description></item>
            /// <item><description><para>enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("GroupSyncStatus")]
            [Validation(Required=false)]
            public string GroupSyncStatus { get; set; }

            /// <summary>
            /// <para>The status of incremental callbacks. Specifies whether to process incremental callback data from the identity provider (IdP). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled</para>
            /// </description></item>
            /// <item><description><para>enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("IncrementalCallbackStatus")]
            [Validation(Required=false)]
            public string IncrementalCallbackStatus { get; set; }

            /// <summary>
            /// <para>The configuration for periodic synchronization.</para>
            /// </summary>
            [NameInMap("PeriodicSyncConfig")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestUdPullConfigPeriodicSyncConfig PeriodicSyncConfig { get; set; }
            public class CreateIdentityProviderRequestUdPullConfigPeriodicSyncConfig : TeaModel {
                /// <summary>
                /// <para>The cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 45 1 * * ?</para>
                /// </summary>
                [NameInMap("PeriodicSyncCron")]
                [Validation(Required=false)]
                public string PeriodicSyncCron { get; set; }

                /// <summary>
                /// <para>The collection of running time points.</para>
                /// </summary>
                [NameInMap("PeriodicSyncTimes")]
                [Validation(Required=false)]
                public List<int?> PeriodicSyncTimes { get; set; }

                /// <summary>
                /// <para>The type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("PeriodicSyncType")]
                [Validation(Required=false)]
                public string PeriodicSyncType { get; set; }

            }

            /// <summary>
            /// <para>The status of periodic synchronization. Specifies whether to periodically check for data differences between IDaaS and the IdP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled</para>
            /// </description></item>
            /// <item><description><para>enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>The synchronization scope configurations.</para>
            /// </summary>
            [NameInMap("UdSyncScopeConfig")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestUdPullConfigUdSyncScopeConfig UdSyncScopeConfig { get; set; }
            public class CreateIdentityProviderRequestUdPullConfigUdSyncScopeConfig : TeaModel {
                /// <summary>
                /// <para>The list of source nodes for synchronization.</para>
                /// </summary>
                [NameInMap("SourceScopes")]
                [Validation(Required=false)]
                public List<string> SourceScopes { get; set; }

                /// <summary>
                /// <para>The target node for synchronization. Enter the IDaaS organization ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou_lyhyy6p7yf7mdrdiq5xxxx</para>
                /// </summary>
                [NameInMap("TargetScope")]
                [Validation(Required=false)]
                public string TargetScope { get; set; }

            }

        }

        /// <summary>
        /// <para>The outbound synchronization configurations.</para>
        /// </summary>
        [NameInMap("UdPushConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestUdPushConfig UdPushConfig { get; set; }
        public class CreateIdentityProviderRequestUdPushConfig : TeaModel {
            /// <summary>
            /// <para>The status of incremental callbacks. This parameter is not in use. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("IncrementalCallbackStatus")]
            [Validation(Required=false)]
            public string IncrementalCallbackStatus { get; set; }

            /// <summary>
            /// <para>The periodic synchronization configurations.</para>
            /// </summary>
            [NameInMap("PeriodicSyncConfig")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestUdPushConfigPeriodicSyncConfig PeriodicSyncConfig { get; set; }
            public class CreateIdentityProviderRequestUdPushConfigPeriodicSyncConfig : TeaModel {
                /// <summary>
                /// <para>The cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 45 1 * * ?</para>
                /// </summary>
                [NameInMap("PeriodicSyncCron")]
                [Validation(Required=false)]
                public string PeriodicSyncCron { get; set; }

                /// <summary>
                /// <para>The collection of running time points.</para>
                /// </summary>
                [NameInMap("PeriodicSyncTimes")]
                [Validation(Required=false)]
                public List<int?> PeriodicSyncTimes { get; set; }

                /// <summary>
                /// <para>The type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("PeriodicSyncType")]
                [Validation(Required=false)]
                public string PeriodicSyncType { get; set; }

            }

            /// <summary>
            /// <para>The status of periodic synchronization. This parameter is not in use. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>The configurations of the outbound synchronization scope.</para>
            /// </summary>
            [NameInMap("UdSyncScopeConfigs")]
            [Validation(Required=false)]
            public List<CreateIdentityProviderRequestUdPushConfigUdSyncScopeConfigs> UdSyncScopeConfigs { get; set; }
            public class CreateIdentityProviderRequestUdPushConfigUdSyncScopeConfigs : TeaModel {
                /// <summary>
                /// <para>The list of source nodes for synchronization.</para>
                /// </summary>
                [NameInMap("SourceScopes")]
                [Validation(Required=false)]
                public List<string> SourceScopes { get; set; }

                /// <summary>
                /// <para>The target node for synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou_lyhyy6p7yf7mdrdiq5xxxx</para>
                /// </summary>
                [NameInMap("TargetScope")]
                [Validation(Required=false)]
                public string TargetScope { get; set; }

            }

        }

        /// <summary>
        /// <para>The WeCom configurations.</para>
        /// </summary>
        [NameInMap("WeComConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestWeComConfig WeComConfig { get; set; }
        public class CreateIdentityProviderRequestWeComConfig : TeaModel {
            /// <summary>
            /// <para>The agent ID of the custom WeCom application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>278231941749863339</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The authorized callback domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.aliyunidaas.com/xxxx">https://xxx.aliyunidaas.com/xxxx</a></para>
            /// </summary>
            [NameInMap("AuthorizeCallbackDomain")]
            [Validation(Required=false)]
            public string AuthorizeCallbackDomain { get; set; }

            /// <summary>
            /// <para>The CorpId of the custom WeCom application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3756043633237690761</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The CorpSecret of the custom WeCom application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CSEHDddddddxxxxuxkJEHPveWRXBGqVqRsxxxx</para>
            /// </summary>
            [NameInMap("CorpSecret")]
            [Validation(Required=false)]
            public string CorpSecret { get; set; }

            /// <summary>
            /// <para>The trusted domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.aliyunidaas.com/">https://xxx.aliyunidaas.com/</a></para>
            /// </summary>
            [NameInMap("TrustableDomain")]
            [Validation(Required=false)]
            public string TrustableDomain { get; set; }

        }

    }

}
