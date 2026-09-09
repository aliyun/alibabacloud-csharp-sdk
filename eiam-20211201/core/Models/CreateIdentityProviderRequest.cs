// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>The authentication configuration.</para>
        /// </summary>
        [NameInMap("AuthnConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAuthnConfig AuthnConfig { get; set; }
        public class CreateIdentityProviderRequestAuthnConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether the corresponding IdP supports authentication. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disabled: Disabled.</description></item>
            /// <item><description>enabled: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AuthnStatus")]
            [Validation(Required=false)]
            public string AuthnStatus { get; set; }

            /// <summary>
            /// <para>Specifies whether automatic password update is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disabled: Disabled.</description></item>
            /// <item><description>enabled: Enabled.</description></item>
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
        /// <para>The automatic creation rule configuration for accounts.</para>
        /// </summary>
        [NameInMap("AutoCreateUserConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAutoCreateUserConfig AutoCreateUserConfig { get; set; }
        public class CreateIdentityProviderRequestAutoCreateUserConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether automatic creation of accounts is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled: Disabled.</para>
            /// </description></item>
            /// <item><description><para>enabled: Enabled.</para>
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
        /// <para>The automatic account update rule configuration.</para>
        /// </summary>
        [NameInMap("AutoUpdateUserConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAutoUpdateUserConfig AutoUpdateUserConfig { get; set; }
        public class CreateIdentityProviderRequestAutoUpdateUserConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether automatic account update is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled: Disabled.</para>
            /// </description></item>
            /// <item><description><para>enabled: Enabled.</para>
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
        /// <para>The account binding rule configuration for the OIDC identity provider.</para>
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
                /// <item><description>field: field</description></item>
                /// <item><description>expression: expression</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>field</para>
                /// </summary>
                [NameInMap("ExpressionMappingType")]
                [Validation(Required=false)]
                public string ExpressionMappingType { get; set; }

                /// <summary>
                /// <para>The expression for the mapped attribute value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idpUser.phoneNumber</para>
                /// </summary>
                [NameInMap("SourceValueExpression")]
                [Validation(Required=false)]
                public string SourceValueExpression { get; set; }

                /// <summary>
                /// <para>The name of the target attribute for mapping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.username</para>
                /// </summary>
                [NameInMap("TargetField")]
                [Validation(Required=false)]
                public string TargetField { get; set; }

                /// <summary>
                /// <para>The name of the target attribute for mapping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("TargetFieldDescription")]
                [Validation(Required=false)]
                public string TargetFieldDescription { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether automatic account matching is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disabled: Disabled.</description></item>
            /// <item><description>enabled: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AutoMatchUserStatus")]
            [Validation(Required=false)]
            public string AutoMatchUserStatus { get; set; }

            /// <summary>
            /// <para>Specifies whether the manual account binding feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disabled: Disabled.</description></item>
            /// <item><description>enabled: Enabled.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. Generate a parameter value from your client to ensure that the value is unique among different requests. ClientToken supports only ASCII characters. If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may vary for each API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clientToken_20250704_Axxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The DingTalk configuration.</para>
        /// </summary>
        [NameInMap("DingtalkAppConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestDingtalkAppConfig DingtalkAppConfig { get; set; }
        public class CreateIdentityProviderRequestDingtalkAppConfig : TeaModel {
            /// <summary>
            /// <para>The appKey of the DingTalk first-party application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Xczngvfemo4e</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>The appSecret of the DingTalk first-party application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5d405a12a6f84ad4ab05ee09axxxx</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <para>The corpId of the DingTalk first-party application.</para>
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
            /// <item><description><para>public_dingtalk: Standard DingTalk.</para>
            /// </description></item>
            /// <item><description><para>private_dingtalk: Exclusive DingTalk.</para>
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
        /// <para>The synchronization type of the identity provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>urn:alibaba:idaas:idp:alibaba:dingtalk:pull: inbound DingTalk</description></item>
        /// <item><description>urn:alibaba:idaas:idp:alibaba:dingtalk:push: outbound DingTalk</description></item>
        /// <item><description>urn:alibaba:idaas:idp:tencent:wecom:pull: inbound WeCom</description></item>
        /// <item><description>urn:alibaba:idaas:idp:bytedance:lark:pull: inbound Lark</description></item>
        /// <item><description>urn:alibaba:idaas:idp:microsoft:ad:pull: inbound AD</description></item>
        /// <item><description>urn:alibaba:idaas:idp:unknown:ldap:pull: inbound LDAP</description></item>
        /// <item><description>urn:alibaba:idaas:idp:standard:oidc: standard OIDC</description></item>
        /// <item><description>urn:alibaba:idaas:idp:alibaba:sase: SASE custom OIDC</description></item>
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
        /// <para>The Lark configuration information.</para>
        /// </summary>
        [NameInMap("LarkConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestLarkConfig LarkConfig { get; set; }
        public class CreateIdentityProviderRequestLarkConfig : TeaModel {
            /// <summary>
            /// <para>The Lark application AppId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cli_xxxx</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The Lark application Secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KiiLzh5Dueh4wbLxxxx</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <para>The encryptKey of the Lark custom application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VkdWw91mdkrjVFr3ObNwefap21dfxxxx</para>
            /// </summary>
            [NameInMap("EncryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            /// <summary>
            /// <para>The Lark enterprise number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FSX123111xxx</para>
            /// </summary>
            [NameInMap("EnterpriseNumber")]
            [Validation(Required=false)]
            public string EnterpriseNumber { get; set; }

            /// <summary>
            /// <para>The verificationToken of the Lark custom application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>feishuVerifyTokenxxxxx</para>
            /// </summary>
            [NameInMap("VerificationToken")]
            [Validation(Required=false)]
            public string VerificationToken { get; set; }

        }

        /// <summary>
        /// <para>The AD/LDAP configuration information.</para>
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
            /// <item><description><para>disabled: Disabled.</para>
            /// </description></item>
            /// <item><description><para>enabled: Enabled.</para>
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
            /// <para>The group member attribute name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>member</para>
            /// </summary>
            [NameInMap("GroupMemberAttributeName")]
            [Validation(Required=false)]
            public string GroupMemberAttributeName { get; set; }

            /// <summary>
            /// <para>The group ObjectClass.</para>
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
            /// <para>The AD/LDAP server address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.xx.xx.89</para>
            /// </summary>
            [NameInMap("LdapServerHost")]
            [Validation(Required=false)]
            public string LdapServerHost { get; set; }

            /// <summary>
            /// <para>The AD/LDAP port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>636</para>
            /// </summary>
            [NameInMap("LdapServerPort")]
            [Validation(Required=false)]
            public int? LdapServerPort { get; set; }

            /// <summary>
            /// <para>The organization ObjectClass.</para>
            /// 
            /// <b>Example:</b>
            /// <para>organizationUnit,top</para>
            /// </summary>
            [NameInMap("OrganizationUnitObjectClass")]
            [Validation(Required=false)]
            public string OrganizationUnitObjectClass { get; set; }

            /// <summary>
            /// <para>The organization RDN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou</para>
            /// </summary>
            [NameInMap("OrganizationalUnitRdn")]
            [Validation(Required=false)]
            public string OrganizationalUnitRdn { get; set; }

            /// <summary>
            /// <para>Specifies whether password synchronization is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordSyncStatus")]
            [Validation(Required=false)]
            public string PasswordSyncStatus { get; set; }

            /// <summary>
            /// <para>Specifies whether StartTLS is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled: Disabled.</para>
            /// </description></item>
            /// <item><description><para>enabled: Enabled.</para>
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
            /// <para>The user ObjectClass.</para>
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
            /// <para>The user RDN.</para>
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
        /// <para>The network access endpoint ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nae_examplexxxx</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointId")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointId { get; set; }

        /// <summary>
        /// <para>The OIDC IdP configuration.</para>
        /// </summary>
        [NameInMap("OidcConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestOidcConfig OidcConfig { get; set; }
        public class CreateIdentityProviderRequestOidcConfig : TeaModel {
            /// <summary>
            /// <para>The OIDC client authentication configuration.</para>
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
                /// <para>The OIDC issuer information.</para>
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
                /// <para>The OIDC UserInfo endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/userinfo">https://example.com/auth/userinfo</a></para>
                /// </summary>
                [NameInMap("UserinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The collection of OIDC grant scopes.</para>
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
            /// <item><description><para>SHA256: S256</para>
            /// </description></item>
            /// <item><description><para>plaintext: plain</para>
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
            /// <para>Specifies whether to use PKCE in AuthorizationCode grant mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PkceRequired")]
            [Validation(Required=false)]
            public bool? PkceRequired { get; set; }

        }

        /// <summary>
        /// <para>The SAML IdP configuration.</para>
        /// </summary>
        [NameInMap("SamlConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestSamlConfig SamlConfig { get; set; }
        public class CreateIdentityProviderRequestSamlConfig : TeaModel {
            /// <summary>
            /// <para>The binding type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP-REDIRECT</para>
            /// </summary>
            [NameInMap("BindingMethod")]
            [Validation(Required=false)]
            public string BindingMethod { get; set; }

            /// <summary>
            /// <para>The certificate list of the IdP.</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<CreateIdentityProviderRequestSamlConfigCertificates> Certificates { get; set; }
            public class CreateIdentityProviderRequestSamlConfigCertificates : TeaModel {
                /// <summary>
                /// <para>The certificate content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-----BEGIN CERTIFICATE----- MIIC0jCCAbqgAwIBAgIQXXXXX-----END CERTIFICATE-----</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }

            /// <summary>
            /// <para>The EntityId of the IdP.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://dc.test.com/adfs/services/trust">http://dc.test.com/adfs/services/trust</a></para>
            /// </summary>
            [NameInMap("IdPEntityId")]
            [Validation(Required=false)]
            public string IdPEntityId { get; set; }

            /// <summary>
            /// <para>The logon URL of the IdP.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dc.test.com/adfs/ls/">https://dc.test.com/adfs/ls/</a></para>
            /// </summary>
            [NameInMap("IdPSsoUrl")]
            [Validation(Required=false)]
            public string IdPSsoUrl { get; set; }

            /// <summary>
            /// <para>The maximum clock skew.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("MaxClockSkew")]
            [Validation(Required=false)]
            public long? MaxClockSkew { get; set; }

            /// <summary>
            /// <para>Specifies whether requests must be signed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RequireRequestSigned")]
            [Validation(Required=false)]
            public bool? RequireRequestSigned { get; set; }

            /// <summary>
            /// <para>Specifies whether the external IdP must sign the Assertion.</para>
            /// </summary>
            [NameInMap("WantAssertionsSigned")]
            [Validation(Required=false)]
            public bool? WantAssertionsSigned { get; set; }

            /// <summary>
            /// <para>Specifies whether the external IdP must sign the Response.</para>
            /// </summary>
            [NameInMap("WantResponseSigned")]
            [Validation(Required=false)]
            public bool? WantResponseSigned { get; set; }

        }

        /// <summary>
        /// <para>The inbound synchronization configuration.</para>
        /// </summary>
        [NameInMap("UdPullConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestUdPullConfig UdPullConfig { get; set; }
        public class CreateIdentityProviderRequestUdPullConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether group synchronization is supported. Default value: disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disabled: Disabled.</description></item>
            /// <item><description>enabled: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("GroupSyncStatus")]
            [Validation(Required=false)]
            public string GroupSyncStatus { get; set; }

            /// <summary>
            /// <para>The incremental callback status. Specifies whether to process incremental callback data from the IdP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disabled</description></item>
            /// <item><description>enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("IncrementalCallbackStatus")]
            [Validation(Required=false)]
            public string IncrementalCallbackStatus { get; set; }

            /// <summary>
            /// <para>The periodic verification configuration.</para>
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
                /// <para>The collection of execution time points.</para>
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
            /// <para>Specifies whether to periodically verify data differences between EIAM and the identity provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disabled: Disabled.</description></item>
            /// <item><description>enabled: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>The synchronization scope configuration.</para>
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
                /// <para>The target node for synchronization. Set this parameter to an IDaaS organization ID.</para>
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
        /// <para>The outbound synchronization configuration.</para>
        /// </summary>
        [NameInMap("UdPushConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestUdPushConfig UdPushConfig { get; set; }
        public class CreateIdentityProviderRequestUdPushConfig : TeaModel {
            /// <summary>
            /// <para>The incremental callback status. This field is not yet enabled. Ignore this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("IncrementalCallbackStatus")]
            [Validation(Required=false)]
            public string IncrementalCallbackStatus { get; set; }

            /// <summary>
            /// <para>The periodic verification configuration.</para>
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
                /// <para>The collection of execution time points.</para>
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
            /// <para>The periodic verification status. This field is not yet enabled. Ignore this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>The outbound synchronization configuration.</para>
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
        /// <para>The WeCom configuration information.</para>
        /// </summary>
        [NameInMap("WeComConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestWeComConfig WeComConfig { get; set; }
        public class CreateIdentityProviderRequestWeComConfig : TeaModel {
            /// <summary>
            /// <para>The agentId of the WeCom self-built application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>278231941749863339</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The authorization callback domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.aliyunidaas.com/xxxx">https://xxx.aliyunidaas.com/xxxx</a></para>
            /// </summary>
            [NameInMap("AuthorizeCallbackDomain")]
            [Validation(Required=false)]
            public string AuthorizeCallbackDomain { get; set; }

            /// <summary>
            /// <para>The corpId of the WeCom self-built application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3756043633237690761</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The corpSecret of the WeCom self-built application.</para>
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
            /// <para><a href="https://xxx.aliyunidaas.com/">https://xxx.aliyunidaas.com/</a></para>
            /// </summary>
            [NameInMap("TrustableDomain")]
            [Validation(Required=false)]
            public string TrustableDomain { get; set; }

        }

    }

}
