// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>Authentication configuration.</para>
        /// </summary>
        [NameInMap("AuthnConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAuthnConfig AuthnConfig { get; set; }
        public class CreateIdentityProviderRequestAuthnConfig : TeaModel {
            /// <summary>
            /// <para>Whether the corresponding IdP supports authentication. Valid values:</para>
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
            /// <para>Whether automatic password update is supported. Valid values:</para>
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
        /// <para>Automatic account creation rule configuration.</para>
        /// </summary>
        [NameInMap("AutoCreateUserConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAutoCreateUserConfig AutoCreateUserConfig { get; set; }
        public class CreateIdentityProviderRequestAutoCreateUserConfig : TeaModel {
            /// <summary>
            /// <para>Whether automatic account creation is enabled. Valid values:</para>
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
            /// <para>Set of target organizational unit IDs.</para>
            /// </summary>
            [NameInMap("TargetOrganizationalUnitIds")]
            [Validation(Required=false)]
            public List<string> TargetOrganizationalUnitIds { get; set; }

        }

        /// <summary>
        /// <para>Automatic account update rule configuration.</para>
        /// </summary>
        [NameInMap("AutoUpdateUserConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAutoUpdateUserConfig AutoUpdateUserConfig { get; set; }
        public class CreateIdentityProviderRequestAutoUpdateUserConfig : TeaModel {
            /// <summary>
            /// <para>Whether automatic account update is enabled. Valid values:</para>
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
            /// <para>List of rules for automatic account matching.</para>
            /// </summary>
            [NameInMap("AutoMatchUserProfileExpressions")]
            [Validation(Required=false)]
            public List<CreateIdentityProviderRequestBindingConfigAutoMatchUserProfileExpressions> AutoMatchUserProfileExpressions { get; set; }
            public class CreateIdentityProviderRequestBindingConfigAutoMatchUserProfileExpressions : TeaModel {
                /// <summary>
                /// <para>Expression type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Field: field</para>
                /// </description></item>
                /// <item><description><para>Expression: expression</para>
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
                /// <para>Mapping attribute value expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idpUser.phoneNumber</para>
                /// </summary>
                [NameInMap("SourceValueExpression")]
                [Validation(Required=false)]
                public string SourceValueExpression { get; set; }

                /// <summary>
                /// <para>Mapping target attribute name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.username</para>
                /// </summary>
                [NameInMap("TargetField")]
                [Validation(Required=false)]
                public string TargetField { get; set; }

                /// <summary>
                /// <para>Mapping target attribute description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("TargetFieldDescription")]
                [Validation(Required=false)]
                public string TargetFieldDescription { get; set; }

            }

            /// <summary>
            /// <para>Whether automatic account matching is enabled. Valid values:</para>
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
            /// <para>Whether the manual account binding feature is enabled. Valid values:</para>
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
        /// <para>Client token used to ensure the idempotency of the request. Generate a parameter value from your client to ensure the value is unique across different requests. ClientToken only supports ASCII characters. If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may be different for each API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clientToken_20250704_Axxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>DingTalk configuration.</para>
        /// </summary>
        [NameInMap("DingtalkAppConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestDingtalkAppConfig DingtalkAppConfig { get; set; }
        public class CreateIdentityProviderRequestDingtalkAppConfig : TeaModel {
            /// <summary>
            /// <para>AppKey of the DingTalk first-party application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Xczngvfemo4e</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>AppSecret of the DingTalk first-party application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5d405a12a6f84ad4ab05ee09axxxx</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <para>CorpId of the DingTalk first-party application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>307568042478613xxxx</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>DingTalk version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Standard DingTalk: public_dingtalk</para>
            /// </description></item>
            /// <item><description><para>Exclusive DingTalk: private_dingtalk</para>
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
            /// <para>DingTalk application EncryptKey.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VkdWw91mdkrjVFr3ObNwefap21dfxxxx</para>
            /// </summary>
            [NameInMap("EncryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            /// <summary>
            /// <para>DingTalk application VerificationToken.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myDingApp_VerifyTokenxxxxx</para>
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
        /// <para>Lark configuration.</para>
        /// </summary>
        [NameInMap("LarkConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestLarkConfig LarkConfig { get; set; }
        public class CreateIdentityProviderRequestLarkConfig : TeaModel {
            /// <summary>
            /// <para>Lark application AppId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cli_xxxx</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Lark application Secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KiiLzh5Dueh4wbLxxxx</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <para>EncryptKey of the Lark self-built application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VkdWw91mdkrjVFr3ObNwefap21dfxxxx</para>
            /// </summary>
            [NameInMap("EncryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            /// <summary>
            /// <para>Lark enterprise code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FSX123111xxx</para>
            /// </summary>
            [NameInMap("EnterpriseNumber")]
            [Validation(Required=false)]
            public string EnterpriseNumber { get; set; }

            /// <summary>
            /// <para>VerificationToken of the Lark self-built application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>feishuVerifyTokenxxxxx</para>
            /// </summary>
            [NameInMap("VerificationToken")]
            [Validation(Required=false)]
            public string VerificationToken { get; set; }

        }

        /// <summary>
        /// <para>AD/LDAP configuration.</para>
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
            /// <para>Administrator account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DC=example,DC=com</para>
            /// </summary>
            [NameInMap("AdministratorUsername")]
            [Validation(Required=false)]
            public string AdministratorUsername { get; set; }

            /// <summary>
            /// <para>Whether to verify certificate fingerprint. Valid values:</para>
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
            /// <para>Certificate fingerprint list.</para>
            /// </summary>
            [NameInMap("CertificateFingerprints")]
            [Validation(Required=false)]
            public List<string> CertificateFingerprints { get; set; }

            /// <summary>
            /// <para>Group member attribute.</para>
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
            /// <para>Group custom filter.</para>
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
            /// <para>Organization ObjectClass.</para>
            /// 
            /// <b>Example:</b>
            /// <para>organizationUnit,top</para>
            /// </summary>
            [NameInMap("OrganizationUnitObjectClass")]
            [Validation(Required=false)]
            public string OrganizationUnitObjectClass { get; set; }

            /// <summary>
            /// <para>Organization RDN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou</para>
            /// </summary>
            [NameInMap("OrganizationalUnitRdn")]
            [Validation(Required=false)]
            public string OrganizationalUnitRdn { get; set; }

            /// <summary>
            /// <para>Password synchronization switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordSyncStatus")]
            [Validation(Required=false)]
            public string PasswordSyncStatus { get; set; }

            /// <summary>
            /// <para>Whether startTLS is enabled. Valid values:</para>
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
            /// <para>User custom filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(|(cn=test)(mail=<a href="mailto:test@test.com">test@test.com</a>))</para>
            /// </summary>
            [NameInMap("UserObjectClassCustomFilter")]
            [Validation(Required=false)]
            public string UserObjectClassCustomFilter { get; set; }

            /// <summary>
            /// <para>User RDN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("UserRdn")]
            [Validation(Required=false)]
            public string UserRdn { get; set; }

        }

        /// <summary>
        /// <para>Application logo URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-image://xxxx_23aqr2ye554csg33dqpch5eu3q/tmp/d17d9adc-a943-45e7-ba0c-2838dddea678</para>
        /// </summary>
        [NameInMap("LogoUrl")]
        [Validation(Required=false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// <para>Network access endpoint ID.</para>
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
                /// <para>OIDC authentication method. Valid values:</para>
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
                /// <para>OIDC client ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mkv7rgt4d7i4u7zqtzev2mxxxx</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>OIDC client secret.</para>
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
                /// <para>OIDC issuer.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth">https://example.com/auth</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>OIDC JWKS URI.</para>
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
                /// <para>OIDC UserInfo endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/userinfo">https://example.com/auth/userinfo</a></para>
                /// </summary>
                [NameInMap("UserinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>OIDC grant scopes.</para>
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
            /// <para>PKCE algorithm. Valid values:</para>
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
            /// <para>Whether to use PKCE in Authorization Code grant mode.</para>
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
        /// <para>Inbound synchronization configuration.</para>
        /// </summary>
        [NameInMap("UdPullConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestUdPullConfig UdPullConfig { get; set; }
        public class CreateIdentityProviderRequestUdPullConfig : TeaModel {
            /// <summary>
            /// <para>Whether group synchronization is supported. Default: disabled. Valid values:</para>
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
            /// <para>Incremental callback status. Specifies whether to process incremental callback data from the IdP. Valid values:</para>
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
            /// <para>Periodic verification configuration.</para>
            /// </summary>
            [NameInMap("PeriodicSyncConfig")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestUdPullConfigPeriodicSyncConfig PeriodicSyncConfig { get; set; }
            public class CreateIdentityProviderRequestUdPullConfigPeriodicSyncConfig : TeaModel {
                /// <summary>
                /// <para>Cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 45 1 * * ?</para>
                /// </summary>
                [NameInMap("PeriodicSyncCron")]
                [Validation(Required=false)]
                public string PeriodicSyncCron { get; set; }

                /// <summary>
                /// <para>Set of execution time points.</para>
                /// </summary>
                [NameInMap("PeriodicSyncTimes")]
                [Validation(Required=false)]
                public List<int?> PeriodicSyncTimes { get; set; }

                /// <summary>
                /// <para>Type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("PeriodicSyncType")]
                [Validation(Required=false)]
                public string PeriodicSyncType { get; set; }

            }

            /// <summary>
            /// <para>Periodic verification status. Specifies whether to periodically verify data differences between EIAM and the identity provider. Valid values:</para>
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
            /// <para>Synchronization scope configuration.</para>
            /// </summary>
            [NameInMap("UdSyncScopeConfig")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestUdPullConfigUdSyncScopeConfig UdSyncScopeConfig { get; set; }
            public class CreateIdentityProviderRequestUdPullConfigUdSyncScopeConfig : TeaModel {
                /// <summary>
                /// <para>Source synchronization node list.</para>
                /// </summary>
                [NameInMap("SourceScopes")]
                [Validation(Required=false)]
                public List<string> SourceScopes { get; set; }

                /// <summary>
                /// <para>Target synchronization node. Enter the IDaaS organization ID.</para>
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
        /// <para>Outbound synchronization configuration.</para>
        /// </summary>
        [NameInMap("UdPushConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestUdPushConfig UdPushConfig { get; set; }
        public class CreateIdentityProviderRequestUdPushConfig : TeaModel {
            /// <summary>
            /// <para>Incremental callback status. This field is not yet enabled. Please ignore it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("IncrementalCallbackStatus")]
            [Validation(Required=false)]
            public string IncrementalCallbackStatus { get; set; }

            /// <summary>
            /// <para>Periodic verification configuration.</para>
            /// </summary>
            [NameInMap("PeriodicSyncConfig")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestUdPushConfigPeriodicSyncConfig PeriodicSyncConfig { get; set; }
            public class CreateIdentityProviderRequestUdPushConfigPeriodicSyncConfig : TeaModel {
                /// <summary>
                /// <para>Cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 45 1 * * ?</para>
                /// </summary>
                [NameInMap("PeriodicSyncCron")]
                [Validation(Required=false)]
                public string PeriodicSyncCron { get; set; }

                /// <summary>
                /// <para>Set of execution time points.</para>
                /// </summary>
                [NameInMap("PeriodicSyncTimes")]
                [Validation(Required=false)]
                public List<int?> PeriodicSyncTimes { get; set; }

                /// <summary>
                /// <para>Type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("PeriodicSyncType")]
                [Validation(Required=false)]
                public string PeriodicSyncType { get; set; }

            }

            /// <summary>
            /// <para>Periodic verification status. This field is not yet enabled. Please ignore it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>Outbound synchronization configuration.</para>
            /// </summary>
            [NameInMap("UdSyncScopeConfigs")]
            [Validation(Required=false)]
            public List<CreateIdentityProviderRequestUdPushConfigUdSyncScopeConfigs> UdSyncScopeConfigs { get; set; }
            public class CreateIdentityProviderRequestUdPushConfigUdSyncScopeConfigs : TeaModel {
                /// <summary>
                /// <para>Source synchronization node list.</para>
                /// </summary>
                [NameInMap("SourceScopes")]
                [Validation(Required=false)]
                public List<string> SourceScopes { get; set; }

                /// <summary>
                /// <para>Target synchronization node.</para>
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
        /// <para>WeCom configuration.</para>
        /// </summary>
        [NameInMap("WeComConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestWeComConfig WeComConfig { get; set; }
        public class CreateIdentityProviderRequestWeComConfig : TeaModel {
            /// <summary>
            /// <para>AgentId of the WeCom self-built application.</para>
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
            /// <para>CorpId of the WeCom self-built application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3756043633237690761</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>CorpSecret of the WeCom self-built application.</para>
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
