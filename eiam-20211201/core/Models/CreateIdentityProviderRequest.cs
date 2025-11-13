// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>Authentication configuration information.</para>
        /// </summary>
        [NameInMap("AuthnConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAuthnConfig AuthnConfig { get; set; }
        public class CreateIdentityProviderRequestAuthnConfig : TeaModel {
            /// <summary>
            /// <para>Whether the corresponding IdP supports authentication. Value range:</para>
            /// <list type="bullet">
            /// <item><description><para>Disabled: disabled</para>
            /// </description></item>
            /// <item><description><para>Enabled: enabled</para>
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
            /// <para>Whether automatic password update is supported. Value range:</para>
            /// <list type="bullet">
            /// <item><description><para>Disabled: disabled</para>
            /// </description></item>
            /// <item><description><para>Enabled: enabled</para>
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
        /// <para>Auto-create account rule configuration.</para>
        /// </summary>
        [NameInMap("AutoCreateUserConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAutoCreateUserConfig AutoCreateUserConfig { get; set; }
        public class CreateIdentityProviderRequestAutoCreateUserConfig : TeaModel {
            /// <summary>
            /// <para>Whether auto-creation of accounts is enabled. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>Disabled: disabled</para>
            /// </description></item>
            /// <item><description><para>Enabled: enabled</para>
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
            /// <para>Target organizational unit IDs collection.</para>
            /// </summary>
            [NameInMap("TargetOrganizationalUnitIds")]
            [Validation(Required=false)]
            public List<string> TargetOrganizationalUnitIds { get; set; }

        }

        /// <summary>
        /// <para>Auto-update account rule configuration.</para>
        /// </summary>
        [NameInMap("AutoUpdateUserConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAutoUpdateUserConfig AutoUpdateUserConfig { get; set; }
        public class CreateIdentityProviderRequestAutoUpdateUserConfig : TeaModel {
            /// <summary>
            /// <para>Whether auto-updating of accounts is enabled. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>Disabled: disabled</para>
            /// </description></item>
            /// <item><description><para>Enabled: enabled</para>
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
        /// <para>OIDC identity provider account binding rule configuration.</para>
        /// </summary>
        [NameInMap("BindingConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestBindingConfig BindingConfig { get; set; }
        public class CreateIdentityProviderRequestBindingConfig : TeaModel {
            /// <summary>
            /// <para>List of rules for automatically matching accounts.</para>
            /// </summary>
            [NameInMap("AutoMatchUserProfileExpressions")]
            [Validation(Required=false)]
            public List<CreateIdentityProviderRequestBindingConfigAutoMatchUserProfileExpressions> AutoMatchUserProfileExpressions { get; set; }
            public class CreateIdentityProviderRequestBindingConfigAutoMatchUserProfileExpressions : TeaModel {
                /// <summary>
                /// <para>Type of the expression. Value range:</para>
                /// <list type="bullet">
                /// <item><description><para>Field: filed</para>
                /// </description></item>
                /// <item><description><para>Expression: expression</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>filed</para>
                /// </summary>
                [NameInMap("ExpressionMappingType")]
                [Validation(Required=false)]
                public string ExpressionMappingType { get; set; }

                /// <summary>
                /// <para>Expression for the mapped attribute value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idpUser.phoneNumber</para>
                /// </summary>
                [NameInMap("SourceValueExpression")]
                [Validation(Required=false)]
                public string SourceValueExpression { get; set; }

                /// <summary>
                /// <para>Name of the target attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.username</para>
                /// </summary>
                [NameInMap("TargetField")]
                [Validation(Required=false)]
                public string TargetField { get; set; }

                /// <summary>
                /// <para>Description of the target attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.username</para>
                /// </summary>
                [NameInMap("TargetFieldDescription")]
                [Validation(Required=false)]
                public string TargetFieldDescription { get; set; }

            }

            /// <summary>
            /// <para>Whether automatic account matching is enabled. Value range:</para>
            /// <list type="bullet">
            /// <item><description><para>Disabled: disabled</para>
            /// </description></item>
            /// <item><description><para>Enabled: enabled</para>
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
            /// <para>Whether the user manual account binding function is enabled. Value range:</para>
            /// <list type="bullet">
            /// <item><description><para>Disabled: disabled</para>
            /// </description></item>
            /// <item><description><para>Enabled: enabled</para>
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
        /// <para>Idp client token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>DingTalk configuration information.</para>
        /// </summary>
        [NameInMap("DingtalkAppConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestDingtalkAppConfig DingtalkAppConfig { get; set; }
        public class CreateIdentityProviderRequestDingtalkAppConfig : TeaModel {
            /// <summary>
            /// <para>AppKey of the DingTalk application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Xczngvfemo4e</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>AppSecret of the DingTalk application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5d405a12a6f84ad4ab05ee09axxxx</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <para>CorpId of the DingTalk application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3075680424786133505</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>DingTalk edition. Valid values:</para>
            /// <para>public_dingtalk – Standard DingTalk.</para>
            /// <para>private_dingtalk – Dedicated DingTalk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>public_dingtalk</para>
            /// </summary>
            [NameInMap("DingtalkVersion")]
            [Validation(Required=false)]
            public string DingtalkVersion { get; set; }

            /// <summary>
            /// <para>DingTalk encrypt key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29003eb11d0a28b4802a6f02fb8aa25dff730e2ac26ffd200dxxxx</para>
            /// </summary>
            [NameInMap("EncryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            /// <summary>
            /// <para>DingTalk verification token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5ba9c127a7abe029003eb11d0a28b4802a6f02fb8aa25dff730e2ac26ffd200dxxxx</para>
            /// </summary>
            [NameInMap("VerificationToken")]
            [Validation(Required=false)]
            public string VerificationToken { get; set; }

        }

        /// <summary>
        /// <para>Identity provider name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("IdentityProviderName")]
        [Validation(Required=false)]
        public string IdentityProviderName { get; set; }

        /// <summary>
        /// <para>Identity provider synchronization type.</para>
        /// <list type="bullet">
        /// <item><description><para>Inbound to DingTalk: urn:alibaba:idaas:idp:alibaba:dingtalk:pull</para>
        /// </description></item>
        /// <item><description><para>Outbound to DingTalk: urn:alibaba:idaas:idp:alibaba:dingtalk:push</para>
        /// </description></item>
        /// <item><description><para>Inbound to WeCom: urn:alibaba:idaas:idp:tencent:wecom:pull</para>
        /// </description></item>
        /// <item><description><para>Inbound to Lark: urn:alibaba:idaas:idp:bytedance:lark:pull</para>
        /// </description></item>
        /// <item><description><para>Inbound to AD: urn:alibaba:idaas:idp:microsoft:ad:pull</para>
        /// </description></item>
        /// <item><description><para>Inbound to LDAP: urn:alibaba:idaas:idp:unknown:ldap:pull</para>
        /// </description></item>
        /// <item><description><para>Standard OIDC: urn:alibaba:idaas:idp:standard:oidc</para>
        /// </description></item>
        /// <item><description><para>SASE Custom OIDC: urn:alibaba:idaas:idp:alibaba:sase</para>
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
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Lark (Feishu) configuration information.</para>
        /// </summary>
        [NameInMap("LarkConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestLarkConfig LarkConfig { get; set; }
        public class CreateIdentityProviderRequestLarkConfig : TeaModel {
            /// <summary>
            /// <para>Lark (Feishu) app appId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cli_xxxx</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Lark (Feishu) app secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KiiLzh5Dueh4wbLxxxx</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <para>Lark (Feishu) encrypt key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29003eb11d0a28b4802a6f02fb8aa25dff730e2ac26ffd200dxxxx</para>
            /// </summary>
            [NameInMap("EncryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            /// <summary>
            /// <para>Lark (Feishu) enterprise number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FSX123111xxx</para>
            /// </summary>
            [NameInMap("EnterpriseNumber")]
            [Validation(Required=false)]
            public string EnterpriseNumber { get; set; }

            /// <summary>
            /// <para>Lark (Feishu)  verification token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5ba9c127a7abe029003eb11d0a28b4802a6f02fb8aa25dff730e2ac26ffd200dxxxx</para>
            /// </summary>
            [NameInMap("VerificationToken")]
            [Validation(Required=false)]
            public string VerificationToken { get; set; }

        }

        /// <summary>
        /// <para>AD/LDAP configuration information.</para>
        /// </summary>
        [NameInMap("LdapConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestLdapConfig LdapConfig { get; set; }
        public class CreateIdentityProviderRequestLdapConfig : TeaModel {
            /// <summary>
            /// <para>Administrator password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("AdministratorPassword")]
            [Validation(Required=false)]
            public string AdministratorPassword { get; set; }

            /// <summary>
            /// <para>Administrator username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DC=example,DC=com</para>
            /// </summary>
            [NameInMap("AdministratorUsername")]
            [Validation(Required=false)]
            public string AdministratorUsername { get; set; }

            /// <summary>
            /// <para>Whether to verify the certificate fingerprint. Value range:</para>
            /// <list type="bullet">
            /// <item><description><para>Disabled: disabled</para>
            /// </description></item>
            /// <item><description><para>Enabled: enabled</para>
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
            /// <para>List of certificate fingerprints.</para>
            /// </summary>
            [NameInMap("CertificateFingerprints")]
            [Validation(Required=false)]
            public List<string> CertificateFingerprints { get; set; }

            /// <summary>
            /// <para>Group member attribute name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>member</para>
            /// </summary>
            [NameInMap("GroupMemberAttributeName")]
            [Validation(Required=false)]
            public string GroupMemberAttributeName { get; set; }

            /// <summary>
            /// <para>Group ObjectClass.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group</para>
            /// </summary>
            [NameInMap("GroupObjectClass")]
            [Validation(Required=false)]
            public string GroupObjectClass { get; set; }

            /// <summary>
            /// <para>Custom filter for Group ObjectClass.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(|(cn=test)(group=<a href="mailto:test@test.com">test@test.com</a>))</para>
            /// </summary>
            [NameInMap("GroupObjectClassCustomFilter")]
            [Validation(Required=false)]
            public string GroupObjectClassCustomFilter { get; set; }

            /// <summary>
            /// <para>Communication protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ldap</para>
            /// </summary>
            [NameInMap("LdapProtocol")]
            [Validation(Required=false)]
            public string LdapProtocol { get; set; }

            /// <summary>
            /// <para>AD/LDAP server address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.xx.xx.89</para>
            /// </summary>
            [NameInMap("LdapServerHost")]
            [Validation(Required=false)]
            public string LdapServerHost { get; set; }

            /// <summary>
            /// <para>AD/LDAP port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>636</para>
            /// </summary>
            [NameInMap("LdapServerPort")]
            [Validation(Required=false)]
            public int? LdapServerPort { get; set; }

            /// <summary>
            /// <para>Organization Unit ObjectClass.</para>
            /// 
            /// <b>Example:</b>
            /// <para>organizationUnit,top</para>
            /// </summary>
            [NameInMap("OrganizationUnitObjectClass")]
            [Validation(Required=false)]
            public string OrganizationUnitObjectClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ou</para>
            /// </summary>
            [NameInMap("OrganizationalUnitRdn")]
            [Validation(Required=false)]
            public string OrganizationalUnitRdn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordSyncStatus")]
            [Validation(Required=false)]
            public string PasswordSyncStatus { get; set; }

            /// <summary>
            /// <para>Whether startTLS is enabled. Value range:</para>
            /// <list type="bullet">
            /// <item><description><para>Disabled: disabled</para>
            /// </description></item>
            /// <item><description><para>Enabled: enabled</para>
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
            /// <para>User login identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>userPrincipalName, mail</para>
            /// </summary>
            [NameInMap("UserLoginIdentifier")]
            [Validation(Required=false)]
            public string UserLoginIdentifier { get; set; }

            /// <summary>
            /// <para>User ObjectClass.</para>
            /// 
            /// <b>Example:</b>
            /// <para>person,user</para>
            /// </summary>
            [NameInMap("UserObjectClass")]
            [Validation(Required=false)]
            public string UserObjectClass { get; set; }

            /// <summary>
            /// <para>Custom filter for User ObjectClass.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(|(cn=test)(mail=<a href="mailto:test@test.com">test@test.com</a>))</para>
            /// </summary>
            [NameInMap("UserObjectClassCustomFilter")]
            [Validation(Required=false)]
            public string UserObjectClassCustomFilter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("UserRdn")]
            [Validation(Required=false)]
            public string UserRdn { get; set; }

        }

        /// <summary>
        /// <para>IdP logo url.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-image://idaas_23aqr2ye554csg33dqpch5eu3q/tmp/d17d9adc-a943-45e7-ba0c-2838dddexxxxx</para>
        /// </summary>
        [NameInMap("LogoUrl")]
        [Validation(Required=false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// <para>The unique identifier of the network access endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nae_examplexxxx</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointId")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointId { get; set; }

        /// <summary>
        /// <para>OIDC IdP configuration.</para>
        /// </summary>
        [NameInMap("OidcConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestOidcConfig OidcConfig { get; set; }
        public class CreateIdentityProviderRequestOidcConfig : TeaModel {
            /// <summary>
            /// <para>OIDC client authentication configuration.</para>
            /// </summary>
            [NameInMap("AuthnParam")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestOidcConfigAuthnParam AuthnParam { get; set; }
            public class CreateIdentityProviderRequestOidcConfigAuthnParam : TeaModel {
                /// <summary>
                /// <para>OIDC authentication method. Value range:</para>
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
                /// <para>The ID of the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mkv7rgt4d7i4u7zqtzev2mxxxx</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The  secret of the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CSEHDddddddxxxxuxkJEHPveWRXBGqVqRsxxxx</para>
                /// </summary>
                [NameInMap("ClientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

            }

            /// <summary>
            /// <para>OIDC endpoint configuration.</para>
            /// </summary>
            [NameInMap("EndpointConfig")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestOidcConfigEndpointConfig EndpointConfig { get; set; }
            public class CreateIdentityProviderRequestOidcConfigEndpointConfig : TeaModel {
                /// <summary>
                /// <para>OIDC authorization endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/authorize">https://example.com/auth/authorize</a></para>
                /// </summary>
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>OIDC issuer information.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth">https://example.com/auth</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>OIDC jwks uri.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/jwks">https://example.com/auth/jwks</a></para>
                /// </summary>
                [NameInMap("JwksUri")]
                [Validation(Required=false)]
                public string JwksUri { get; set; }

                /// <summary>
                /// <para>OIDC token endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/token">https://example.com/auth/token</a></para>
                /// </summary>
                [NameInMap("TokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

                /// <summary>
                /// <para>OIDC user info endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/userinfo">https://example.com/auth/userinfo</a></para>
                /// </summary>
                [NameInMap("UserinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>OIDC grant scopes collection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openid</para>
            /// </summary>
            [NameInMap("GrantScopes")]
            [Validation(Required=false)]
            public List<string> GrantScopes { get; set; }

            /// <summary>
            /// <para>OIDC grant type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>authorization_code</para>
            /// </summary>
            [NameInMap("GrantType")]
            [Validation(Required=false)]
            public string GrantType { get; set; }

            /// <summary>
            /// <para>PKCE algorithm. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>SHA256: S256</para>
            /// </description></item>
            /// <item><description><para>Plain text: plain</para>
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
            /// <para>Whether to use PKCE in the AuthorizationCode grant mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PkceRequired")]
            [Validation(Required=false)]
            public bool? PkceRequired { get; set; }

        }

        /// <summary>
        /// <para>Inbound synchronization configuration information.</para>
        /// </summary>
        [NameInMap("UdPullConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestUdPullConfig UdPullConfig { get; set; }
        public class CreateIdentityProviderRequestUdPullConfig : TeaModel {
            /// <summary>
            /// <para>Whether group synchronization is supported. The default value is disabled. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>Disabled: disabled</para>
            /// </description></item>
            /// <item><description><para>Enabled: enabled</para>
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
            /// <para>Incremental callback status, indicating whether to process incremental callback data from the IdP. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>Disabled: disabled</para>
            /// </description></item>
            /// <item><description><para>Enabled: enabled</para>
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
            /// <para>Scheduled configuration verification.</para>
            /// </summary>
            [NameInMap("PeriodicSyncConfig")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestUdPullConfigPeriodicSyncConfig PeriodicSyncConfig { get; set; }
            public class CreateIdentityProviderRequestUdPullConfigPeriodicSyncConfig : TeaModel {
                /// <summary>
                /// <para>cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 45 1 * * ?</para>
                /// </summary>
                [NameInMap("PeriodicSyncCron")]
                [Validation(Required=false)]
                public string PeriodicSyncCron { get; set; }

                /// <summary>
                /// <para>Collection of time points.</para>
                /// </summary>
                [NameInMap("PeriodicSyncTimes")]
                [Validation(Required=false)]
                public List<int?> PeriodicSyncTimes { get; set; }

                /// <summary>
                /// <para>type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("PeriodicSyncType")]
                [Validation(Required=false)]
                public string PeriodicSyncType { get; set; }

            }

            /// <summary>
            /// <para>Periodic check status, indicating whether to periodically check the data differences between EIAM and the identity provider. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>Disabled: disabled</para>
            /// </description></item>
            /// <item><description><para>Enabled: enabled</para>
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
            /// <para>Synchronization scope configuration information.</para>
            /// </summary>
            [NameInMap("UdSyncScopeConfig")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestUdPullConfigUdSyncScopeConfig UdSyncScopeConfig { get; set; }
            public class CreateIdentityProviderRequestUdPullConfigUdSyncScopeConfig : TeaModel {
                /// <summary>
                /// <para>List of source nodes for synchronization.</para>
                /// </summary>
                [NameInMap("SourceScopes")]
                [Validation(Required=false)]
                public List<string> SourceScopes { get; set; }

                /// <summary>
                /// <para>Synchronize target node, and fill in the IDaaS organization ID.</para>
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
        /// <para>Outbound synchronization configuration information.</para>
        /// </summary>
        [NameInMap("UdPushConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestUdPushConfig UdPushConfig { get; set; }
        public class CreateIdentityProviderRequestUdPushConfig : TeaModel {
            /// <summary>
            /// <para>Incremental callback status. This field is reserved and currently not in use; please ignore it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("IncrementalCallbackStatus")]
            [Validation(Required=false)]
            public string IncrementalCallbackStatus { get; set; }

            [NameInMap("PeriodicSyncConfig")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestUdPushConfigPeriodicSyncConfig PeriodicSyncConfig { get; set; }
            public class CreateIdentityProviderRequestUdPushConfigPeriodicSyncConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0 45 1 * * ?</para>
                /// </summary>
                [NameInMap("PeriodicSyncCron")]
                [Validation(Required=false)]
                public string PeriodicSyncCron { get; set; }

                [NameInMap("PeriodicSyncTimes")]
                [Validation(Required=false)]
                public List<int?> PeriodicSyncTimes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("PeriodicSyncType")]
                [Validation(Required=false)]
                public string PeriodicSyncType { get; set; }

            }

            /// <summary>
            /// <para>Periodic check status. This field is currently not in use, please ignore it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>Outbound synchronization configuration information.</para>
            /// </summary>
            [NameInMap("UdSyncScopeConfigs")]
            [Validation(Required=false)]
            public List<CreateIdentityProviderRequestUdPushConfigUdSyncScopeConfigs> UdSyncScopeConfigs { get; set; }
            public class CreateIdentityProviderRequestUdPushConfigUdSyncScopeConfigs : TeaModel {
                /// <summary>
                /// <para>List of source nodes for synchronization.</para>
                /// </summary>
                [NameInMap("SourceScopes")]
                [Validation(Required=false)]
                public List<string> SourceScopes { get; set; }

                /// <summary>
                /// <para>Target node for synchronization.</para>
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
        /// <para>WeCom configuration information.</para>
        /// </summary>
        [NameInMap("WeComConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestWeComConfig WeComConfig { get; set; }
        public class CreateIdentityProviderRequestWeComConfig : TeaModel {
            /// <summary>
            /// <para>Agent ID of the self-built WeCom application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>278231941749863339</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>Authorization callback domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.aliyunidaas.com/xxxx">https://xxx.aliyunidaas.com/xxxx</a></para>
            /// </summary>
            [NameInMap("AuthorizeCallbackDomain")]
            [Validation(Required=false)]
            public string AuthorizeCallbackDomain { get; set; }

            /// <summary>
            /// <para>Corp ID of the self-built WeCom application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3756043633237690761</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>Corp Secret of the self-built WeCom application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CSEHDddddddxxxxuxkJEHPveWRXBGqVqRsxxxx</para>
            /// </summary>
            [NameInMap("CorpSecret")]
            [Validation(Required=false)]
            public string CorpSecret { get; set; }

            /// <summary>
            /// <para>Trusted domain.</para>
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
