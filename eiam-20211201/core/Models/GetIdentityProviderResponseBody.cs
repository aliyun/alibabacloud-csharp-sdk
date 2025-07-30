// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetIdentityProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>Identity provider Information.</para>
        /// </summary>
        [NameInMap("IdentityProviderDetail")]
        [Validation(Required=false)]
        public GetIdentityProviderResponseBodyIdentityProviderDetail IdentityProviderDetail { get; set; }
        public class GetIdentityProviderResponseBodyIdentityProviderDetail : TeaModel {
            /// <summary>
            /// <para>Advanced configuration capability. 
            /// Value range:<br>Disabled: disabled<br>Enable: enabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AdvancedStatus")]
            [Validation(Required=false)]
            public string AdvancedStatus { get; set; }

            /// <summary>
            /// <para>The corresponding identity provider product, e.g., Okta, Google, or Azure AD. Possible values:</para>
            /// <para>DingTalk: urn:alibaba:idaas:idp:alibaba:dingtalk</para>
            /// <para>LDAP: urn:alibaba:idaas:idp:unknown:ldap</para>
            /// <para>Alibaba Cloud IDaaS: urn:alibaba:idaas:idp:alibaba:idaas</para>
            /// <para>WeCom (Enterprise WeChat): urn:alibaba:idaas:idp:tencent:wecom</para>
            /// <para>Lark (Feishu): urn:alibaba:idaas:idp:bytedance:lark</para>
            /// <para>Active Directory: urn:alibaba:idaas:idp:microsoft:ad</para>
            /// <para>Azure Active Directory: urn:alibaba:idaas:idp:microsoft:aad</para>
            /// <para>Alibaba Cloud SASE: urn:alibaba:idaas:idp:alibaba:sase</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:idp:bytedance:lark</para>
            /// </summary>
            [NameInMap("AuthnSourceSupplier")]
            [Validation(Required=false)]
            public string AuthnSourceSupplier { get; set; }

            /// <summary>
            /// <para>Authentication type — OIDC or SAML. Possible values:</para>
            /// <para>OIDC: urn:alibaba:idaas:authntype:oidc</para>
            /// <para>SAML: urn:alibaba:idaas:authntype:saml2</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:authntype:oidc</para>
            /// </summary>
            [NameInMap("AuthnSourceType")]
            [Validation(Required=false)]
            public string AuthnSourceType { get; set; }

            /// <summary>
            /// <para>Whether the corresponding IdP supports authentication. Value range: 
            /// Disabled: disabled<br>Enabled: enabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AuthnStatus")]
            [Validation(Required=false)]
            public string AuthnStatus { get; set; }

            /// <summary>
            /// <para>The time when the version was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1726021079000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Identity provider description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>for poc test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>DingTalk Basic Configuration</para>
            /// </summary>
            [NameInMap("DingtalkAppConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkAppConfig DingtalkAppConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkAppConfig : TeaModel {
                /// <summary>
                /// <para>The AppKey for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>41reopmwoy9s</para>
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <para>The details of the application secret.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REOQ6Cl55kriOd8NOBeqWYLKpHR4p6fdZxxxx</para>
                /// </summary>
                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                /// <summary>
                /// <para>DingTalk corpId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3756043633237690761</para>
                /// </summary>
                [NameInMap("CorpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>DingTalk Version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>public_dingtalk</para>
                /// </summary>
                [NameInMap("DingtalkVersion")]
                [Validation(Required=false)]
                public string DingtalkVersion { get; set; }

                /// <summary>
                /// <para>DingTalk  encrypt key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29003eb11d0a28b4802a6f02fb8aa25dff730e2ac26ffdxxx</para>
                /// </summary>
                [NameInMap("EncryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>DingTalk  verification token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5ba9c127a7abe029003eb11d0a28b4802a6f02fb8aa25dff730e2ac26ffxxxxx</para>
                /// </summary>
                [NameInMap("VerificationToken")]
                [Validation(Required=false)]
                public string VerificationToken { get; set; }

            }

            /// <summary>
            /// <para>DingTalk synchronous configuration.</para>
            /// </summary>
            [NameInMap("DingtalkProvisioningConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfig DingtalkProvisioningConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfig : TeaModel {
                /// <summary>
                /// <para>List of authorized DingTalk departments.</para>
                /// </summary>
                [NameInMap("AuthedDepartmentIds")]
                [Validation(Required=false)]
                public List<GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfigAuthedDepartmentIds> AuthedDepartmentIds { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfigAuthedDepartmentIds : TeaModel {
                    /// <summary>
                    /// <para>Department ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123xxx444</para>
                    /// </summary>
                    [NameInMap("DeptId")]
                    [Validation(Required=false)]
                    public string DeptId { get; set; }

                    /// <summary>
                    /// <para>Department name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_xxx</para>
                    /// </summary>
                    [NameInMap("DeptName")]
                    [Validation(Required=false)]
                    public string DeptName { get; set; }

                }

                /// <summary>
                /// <para>Authorized DingTalk account list.</para>
                /// </summary>
                [NameInMap("AuthedUsers")]
                [Validation(Required=false)]
                public List<GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfigAuthedUsers> AuthedUsers { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfigAuthedUsers : TeaModel {
                    /// <summary>
                    /// <para>DingTalk user name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zhangsan</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>DingTalk user id.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>13030833392920xxx</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>DingTalk enterprise corpId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ding_xxxxx</para>
                /// </summary>
                [NameInMap("CorpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The name of the company.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_xxx</para>
                /// </summary>
                [NameInMap("CorpName")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

            }

            /// <summary>
            /// <para>Identity provider external ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_xxxx</para>
            /// </summary>
            [NameInMap("IdentityProviderExternalId")]
            [Validation(Required=false)]
            public string IdentityProviderExternalId { get; set; }

            /// <summary>
            /// <para>Identity provider ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_mwpcwnhrimlr2horx7xgg7xxxx</para>
            /// </summary>
            [NameInMap("IdentityProviderId")]
            [Validation(Required=false)]
            public string IdentityProviderId { get; set; }

            /// <summary>
            /// <para>Identity provider name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("IdentityProviderName")]
            [Validation(Required=false)]
            public string IdentityProviderName { get; set; }

            /// <summary>
            /// <para>Identity provider type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:idp:alibaba:dingtalk:push</para>
            /// </summary>
            [NameInMap("IdentityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_x2df3bak3uwnapqm6xxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Lark configuration.</para>
            /// </summary>
            [NameInMap("LarkConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailLarkConfig LarkConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailLarkConfig : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cli_a7a99f53a317xxxx</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                /// <summary>
                /// <para>Feishu encryptKey.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c5db46da8d4b751a7878e5d670402fb60e4d2391de3fa01f7c9e6353f6d1xxxxx</para>
                /// </summary>
                [NameInMap("EncryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>Feishu enterprise code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FX1231xxxx</para>
                /// </summary>
                [NameInMap("EnterpriseNumber")]
                [Validation(Required=false)]
                public string EnterpriseNumber { get; set; }

                /// <summary>
                /// <para>Feishu verificationToken.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c5db46da8d4b751a7878e5d670402fb60e4d2391de3fa01f7c9e6353f6d1xxxxx</para>
                /// </summary>
                [NameInMap("VerificationToken")]
                [Validation(Required=false)]
                public string VerificationToken { get; set; }

            }

            /// <summary>
            /// <para>Last status check result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("LastStatusCheckJobResult")]
            [Validation(Required=false)]
            public string LastStatusCheckJobResult { get; set; }

            /// <summary>
            /// <para>AD/LDAP Identity provider information.</para>
            /// </summary>
            [NameInMap("LdapConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailLdapConfig LdapConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailLdapConfig : TeaModel {
                /// <summary>
                /// <para>Administrator password.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXXX</para>
                /// </summary>
                [NameInMap("AdministratorPassword")]
                [Validation(Required=false)]
                public string AdministratorPassword { get; set; }

                /// <summary>
                /// <para>Administrator username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("AdministratorUsername")]
                [Validation(Required=false)]
                public string AdministratorUsername { get; set; }

                /// <summary>
                /// <para>Whether to verify the fingerprint certificate.</para>
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
                /// <para>Ldap protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ldap</para>
                /// </summary>
                [NameInMap("LdapProtocol")]
                [Validation(Required=false)]
                public string LdapProtocol { get; set; }

                /// <summary>
                /// <para>ldap server host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.xx.xx.100</para>
                /// </summary>
                [NameInMap("LdapServerHost")]
                [Validation(Required=false)]
                public string LdapServerHost { get; set; }

                /// <summary>
                /// <para>ldap server port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>389</para>
                /// </summary>
                [NameInMap("LdapServerPort")]
                [Validation(Required=false)]
                public int? LdapServerPort { get; set; }

                /// <summary>
                /// <para>StartTls status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("StartTlsStatus")]
                [Validation(Required=false)]
                public string StartTlsStatus { get; set; }

            }

            /// <summary>
            /// <para>The reason why write operations on the instance are locked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>financial</para>
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// <para>The URL of the application logo.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img.alicdn.com/imgextra/i4/O1CN01OB8fJj22fpoZm4sd0_!!6000000007148-2-tps-149-xxx.png">https://img.alicdn.com/imgextra/i4/O1CN01OB8fJj22fpoZm4sd0_!!6000000007148-2-tps-149-xxx.png</a></para>
            /// </summary>
            [NameInMap("LogoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            /// <summary>
            /// <para>The unique identifier of the network access endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae_mx4vsadfe6govkqkwckxxxx</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointId")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointId { get; set; }

            /// <summary>
            /// <para>OIDC IdP configuration.</para>
            /// </summary>
            [NameInMap("OidcConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfig OidcConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfig : TeaModel {
                /// <summary>
                /// <para>OIDC client authentication configuration.</para>
                /// </summary>
                [NameInMap("AuthnParam")]
                [Validation(Required=false)]
                public GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfigAuthnParam AuthnParam { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfigAuthnParam : TeaModel {
                    /// <summary>
                    /// <para>OIDC/OAuth2 authentication method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>client_secret_post</para>
                    /// </summary>
                    [NameInMap("AuthnMethod")]
                    [Validation(Required=false)]
                    public string AuthnMethod { get; set; }

                    /// <summary>
                    /// <para>The client ID of the device whose access credential you want to query.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mkv7rgt4d7i4u7zqtzev2mxxxx</para>
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// <para>The application secret registered with the OIDC authentication service.</para>
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
                public GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfigEndpointConfig EndpointConfig { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfigEndpointConfig : TeaModel {
                    /// <summary>
                    /// <para>OAuth2 authorization endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/oauth/authorize">https://example.com/oauth/authorize</a></para>
                    /// </summary>
                    [NameInMap("AuthorizationEndpoint")]
                    [Validation(Required=false)]
                    public string AuthorizationEndpoint { get; set; }

                    /// <summary>
                    /// <para>The CA that issued the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/oauth">https://example.com/oauth</a></para>
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// <para>Jwks uri.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/oauth/jwks">https://example.com/oauth/jwks</a></para>
                    /// </summary>
                    [NameInMap("JwksUri")]
                    [Validation(Required=false)]
                    public string JwksUri { get; set; }

                    /// <summary>
                    /// <para>Token endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/oauth/token">https://example.com/oauth/token</a></para>
                    /// </summary>
                    [NameInMap("TokenEndpoint")]
                    [Validation(Required=false)]
                    public string TokenEndpoint { get; set; }

                    /// <summary>
                    /// <para>OIDC user info endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/oauth/userinfo">https://example.com/oauth/userinfo</a></para>
                    /// </summary>
                    [NameInMap("UserinfoEndpoint")]
                    [Validation(Required=false)]
                    public string UserinfoEndpoint { get; set; }

                }

                /// <summary>
                /// <para>OIDC authorization scope list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>openid</para>
                /// </summary>
                [NameInMap("GrantScopes")]
                [Validation(Required=false)]
                public List<string> GrantScopes { get; set; }

                /// <summary>
                /// <para>OIDC authorization grant type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>authorization_code</para>
                /// </summary>
                [NameInMap("GrantType")]
                [Validation(Required=false)]
                public string GrantType { get; set; }

                /// <summary>
                /// <para>Supported PKCE code challenge methods.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S256</para>
                /// </summary>
                [NameInMap("PkceChallengeMethod")]
                [Validation(Required=false)]
                public string PkceChallengeMethod { get; set; }

                /// <summary>
                /// <para>Whether to use PKCE in authorization code grant flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PkceRequired")]
                [Validation(Required=false)]
                public bool? PkceRequired { get; set; }

            }

            /// <summary>
            /// <para>Sync in configuration.</para>
            /// </summary>
            [NameInMap("UdPullConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailUdPullConfig UdPullConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailUdPullConfig : TeaModel {
                /// <summary>
                /// <para>Whether to enable group synchronization. Possible values:</para>
                /// <para>Disabled: disabled</para>
                /// <para>Enabled: enabled</para>
                /// 
                /// <b>Example:</b>
                /// <para>disabled</para>
                /// </summary>
                [NameInMap("GroupSyncStatus")]
                [Validation(Required=false)]
                public string GroupSyncStatus { get; set; }

                /// <summary>
                /// <para>Incremental callback status: Whether to process incremental callback data from the IdP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>disabled</para>
                /// </summary>
                [NameInMap("IncrementalCallbackStatus")]
                [Validation(Required=false)]
                public string IncrementalCallbackStatus { get; set; }

                /// <summary>
                /// <para>Inbound synchronization configuration Information.</para>
                /// </summary>
                [NameInMap("UdSyncScopeConfig")]
                [Validation(Required=false)]
                public GetIdentityProviderResponseBodyIdentityProviderDetailUdPullConfigUdSyncScopeConfig UdSyncScopeConfig { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailUdPullConfigUdSyncScopeConfig : TeaModel {
                    /// <summary>
                    /// <para>Synchronization source node.</para>
                    /// </summary>
                    [NameInMap("SourceScopes")]
                    [Validation(Required=false)]
                    public List<string> SourceScopes { get; set; }

                    /// <summary>
                    /// <para>Synchronization target node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ou_123xxxx</para>
                    /// </summary>
                    [NameInMap("TargetScope")]
                    [Validation(Required=false)]
                    public string TargetScope { get; set; }

                }

            }

            /// <summary>
            /// <para>Indicates whether the IDaaS EIAM system supports UD (User Directory) synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("UdPullStatus")]
            [Validation(Required=false)]
            public string UdPullStatus { get; set; }

            /// <summary>
            /// <para>Outbound synchronization configuration.</para>
            /// </summary>
            [NameInMap("UdPushConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailUdPushConfig UdPushConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailUdPushConfig : TeaModel {
                /// <summary>
                /// <para>Incremental callback status: Whether to process incremental callback data from the IdP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>disabled</para>
                /// </summary>
                [NameInMap("IncrementalCallbackStatus")]
                [Validation(Required=false)]
                public string IncrementalCallbackStatus { get; set; }

                /// <summary>
                /// <para>Outbound synchronization configuration Information.</para>
                /// </summary>
                [NameInMap("UdSyncScopeConfigs")]
                [Validation(Required=false)]
                public List<GetIdentityProviderResponseBodyIdentityProviderDetailUdPushConfigUdSyncScopeConfigs> UdSyncScopeConfigs { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailUdPushConfigUdSyncScopeConfigs : TeaModel {
                    /// <summary>
                    /// <para>Synchronization source node.</para>
                    /// </summary>
                    [NameInMap("SourceScopes")]
                    [Validation(Required=false)]
                    public List<string> SourceScopes { get; set; }

                    /// <summary>
                    /// <para>Synchronization target node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ou_123xxxx</para>
                    /// </summary>
                    [NameInMap("TargetScope")]
                    [Validation(Required=false)]
                    public string TargetScope { get; set; }

                }

            }

            /// <summary>
            /// <para>Outbound synchronization capability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("UdPushStatus")]
            [Validation(Required=false)]
            public string UdPushStatus { get; set; }

            /// <summary>
            /// <para>The time when the serviceInstance  was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1726021079000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>WeCom configuration.</para>
            /// </summary>
            [NameInMap("WeComConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailWeComConfig WeComConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailWeComConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the load generator. This parameter is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1242350</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>Authorization callback domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/xxxx">https://example.com/xxxx</a></para>
                /// </summary>
                [NameInMap("AuthorizeCallbackDomain")]
                [Validation(Required=false)]
                public string AuthorizeCallbackDomain { get; set; }

                /// <summary>
                /// <para>CorpId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>356201295345457xxxxx</para>
                /// </summary>
                [NameInMap("CorpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>Corp secret.</para>
                /// 
                /// <b>Example:</b>
                /// <para>weaseiszjskejskaj12sjeszojxxxx</para>
                /// </summary>
                [NameInMap("CorpSecret")]
                [Validation(Required=false)]
                public string CorpSecret { get; set; }

                /// <summary>
                /// <para>Trusted domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com">https://example.com</a></para>
                /// </summary>
                [NameInMap("TrustableDomain")]
                [Validation(Required=false)]
                public string TrustableDomain { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
