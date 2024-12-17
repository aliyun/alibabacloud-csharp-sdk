// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>认证配置</para>
        /// </summary>
        [NameInMap("AuthnConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAuthnConfig AuthnConfig { get; set; }
        public class CreateIdentityProviderRequestAuthnConfig : TeaModel {
            /// <summary>
            /// <para>对应IdP是否支持认证</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AuthnStatus")]
            [Validation(Required=false)]
            public string AuthnStatus { get; set; }

            /// <summary>
            /// <para>是否支持自动更新密码</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AutoUpdatePasswordStatus")]
            [Validation(Required=false)]
            public string AutoUpdatePasswordStatus { get; set; }

        }

        /// <summary>
        /// <para>自动创建账户账户规则配置。</para>
        /// </summary>
        [NameInMap("AutoCreateUserConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAutoCreateUserConfig AutoCreateUserConfig { get; set; }
        public class CreateIdentityProviderRequestAutoCreateUserConfig : TeaModel {
            /// <summary>
            /// <para>自动创建账户是否开启</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AutoCreateUserStatus")]
            [Validation(Required=false)]
            public string AutoCreateUserStatus { get; set; }

            [NameInMap("TargetOrganizationalUnitIds")]
            [Validation(Required=false)]
            public List<string> TargetOrganizationalUnitIds { get; set; }

        }

        /// <summary>
        /// <para>自动更新账户规则配置。</para>
        /// </summary>
        [NameInMap("AutoUpdateUserConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestAutoUpdateUserConfig AutoUpdateUserConfig { get; set; }
        public class CreateIdentityProviderRequestAutoUpdateUserConfig : TeaModel {
            /// <summary>
            /// <para>自动更新账户是否开启</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AutoUpdateUserStatus")]
            [Validation(Required=false)]
            public string AutoUpdateUserStatus { get; set; }

        }

        /// <summary>
        /// <para>账户绑定规则配置。</para>
        /// </summary>
        [NameInMap("BindingConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestBindingConfig BindingConfig { get; set; }
        public class CreateIdentityProviderRequestBindingConfig : TeaModel {
            /// <summary>
            /// <para>自动匹配账户的规则</para>
            /// </summary>
            [NameInMap("AutoMatchUserProfileExpressions")]
            [Validation(Required=false)]
            public List<CreateIdentityProviderRequestBindingConfigAutoMatchUserProfileExpressions> AutoMatchUserProfileExpressions { get; set; }
            public class CreateIdentityProviderRequestBindingConfigAutoMatchUserProfileExpressions : TeaModel {
                /// <summary>
                /// <para>表达式的类型</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>filed</para>
                /// </summary>
                [NameInMap("ExpressionMappingType")]
                [Validation(Required=false)]
                public string ExpressionMappingType { get; set; }

                /// <summary>
                /// <para>映射属性取值表达式</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idpUser.phoneNumber</para>
                /// </summary>
                [NameInMap("SourceValueExpression")]
                [Validation(Required=false)]
                public string SourceValueExpression { get; set; }

                /// <summary>
                /// <para>映射目标属性名称</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user.username</para>
                /// </summary>
                [NameInMap("TargetField")]
                [Validation(Required=false)]
                public string TargetField { get; set; }

                /// <summary>
                /// <para>映射目标属性名称</para>
                /// </summary>
                [NameInMap("TargetFieldDescription")]
                [Validation(Required=false)]
                public string TargetFieldDescription { get; set; }

            }

            /// <summary>
            /// <para>自动匹配账户是否开启</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AutoMatchUserStatus")]
            [Validation(Required=false)]
            public string AutoMatchUserStatus { get; set; }

            /// <summary>
            /// <para>用户手动绑定账户功能是否开启</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("MappingBindingStatus")]
            [Validation(Required=false)]
            public string MappingBindingStatus { get; set; }

        }

        /// <summary>
        /// <para>钉钉配置</para>
        /// </summary>
        [NameInMap("DingtalkAppConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestDingtalkAppConfig DingtalkAppConfig { get; set; }
        public class CreateIdentityProviderRequestDingtalkAppConfig : TeaModel {
            /// <summary>
            /// <para>钉钉一方应用的AppKey</para>
            /// 
            /// <b>Example:</b>
            /// <para>Xczngvfemo4e</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>钉钉一方应用的AppSecret</para>
            /// 
            /// <b>Example:</b>
            /// <para>5d405a12a6f84ad4ab05ee09axxxx</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <para>钉钉一方应用的corpId</para>
            /// 
            /// <b>Example:</b>
            /// <para>3075680424786133505</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>钉钉版本</para>
            /// 
            /// <b>Example:</b>
            /// <para>public_dingtalk</para>
            /// </summary>
            [NameInMap("DingtalkVersion")]
            [Validation(Required=false)]
            public string DingtalkVersion { get; set; }

        }

        /// <summary>
        /// <para>身份提供方名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("IdentityProviderName")]
        [Validation(Required=false)]
        public string IdentityProviderName { get; set; }

        /// <summary>
        /// <para>身份提供发类型</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:alibaba:idaas:idp:alibaba:dingtalk:push</para>
        /// </summary>
        [NameInMap("IdentityProviderType")]
        [Validation(Required=false)]
        public string IdentityProviderType { get; set; }

        /// <summary>
        /// <para>IDaaS EIAM实例的ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>飞书配置</para>
        /// </summary>
        [NameInMap("LarkConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestLarkConfig LarkConfig { get; set; }
        public class CreateIdentityProviderRequestLarkConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cli_xxxx</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>KiiLzh5Dueh4wbLxxxx</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FSX123111xxx</para>
            /// </summary>
            [NameInMap("EnterpriseNumber")]
            [Validation(Required=false)]
            public string EnterpriseNumber { get; set; }

        }

        /// <summary>
        /// <para>AD/LDAP配置</para>
        /// </summary>
        [NameInMap("LdapConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestLdapConfig LdapConfig { get; set; }
        public class CreateIdentityProviderRequestLdapConfig : TeaModel {
            /// <summary>
            /// <para>管理员密码</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("AdministratorPassword")]
            [Validation(Required=false)]
            public string AdministratorPassword { get; set; }

            /// <summary>
            /// <para>管理员账号</para>
            /// 
            /// <b>Example:</b>
            /// <para>DC=example,DC=com</para>
            /// </summary>
            [NameInMap("AdministratorUsername")]
            [Validation(Required=false)]
            public string AdministratorUsername { get; set; }

            /// <summary>
            /// <para>是否验证指纹证书</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("CertificateFingerprintStatus")]
            [Validation(Required=false)]
            public string CertificateFingerprintStatus { get; set; }

            /// <summary>
            /// <para>证书指纹列表</para>
            /// </summary>
            [NameInMap("CertificateFingerprints")]
            [Validation(Required=false)]
            public List<string> CertificateFingerprints { get; set; }

            /// <summary>
            /// <para>组成员标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>member</para>
            /// </summary>
            [NameInMap("GroupMemberAttributeName")]
            [Validation(Required=false)]
            public string GroupMemberAttributeName { get; set; }

            /// <summary>
            /// <para>组objectClass</para>
            /// 
            /// <b>Example:</b>
            /// <para>group</para>
            /// </summary>
            [NameInMap("GroupObjectClass")]
            [Validation(Required=false)]
            public string GroupObjectClass { get; set; }

            /// <summary>
            /// <para>组自定义Filter</para>
            /// 
            /// <b>Example:</b>
            /// <para>(|(cn=test)(group=<a href="mailto:test@test.com">test@test.com</a>))</para>
            /// </summary>
            [NameInMap("GroupObjectClassCustomFilter")]
            [Validation(Required=false)]
            public string GroupObjectClassCustomFilter { get; set; }

            /// <summary>
            /// <para>通信协议</para>
            /// 
            /// <b>Example:</b>
            /// <para>ldap</para>
            /// </summary>
            [NameInMap("LdapProtocol")]
            [Validation(Required=false)]
            public string LdapProtocol { get; set; }

            /// <summary>
            /// <para>ad/ldap 服务器地址</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.xx.xx.89</para>
            /// </summary>
            [NameInMap("LdapServerHost")]
            [Validation(Required=false)]
            public string LdapServerHost { get; set; }

            /// <summary>
            /// <para>端口号</para>
            /// 
            /// <b>Example:</b>
            /// <para>636</para>
            /// </summary>
            [NameInMap("LdapServerPort")]
            [Validation(Required=false)]
            public int? LdapServerPort { get; set; }

            /// <summary>
            /// <para>组织objectClass</para>
            /// 
            /// <b>Example:</b>
            /// <para>organizationUnit,top</para>
            /// </summary>
            [NameInMap("OrganizationUnitObjectClass")]
            [Validation(Required=false)]
            public string OrganizationUnitObjectClass { get; set; }

            /// <summary>
            /// <para>startTls是否开启</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("StartTlsStatus")]
            [Validation(Required=false)]
            public string StartTlsStatus { get; set; }

            /// <summary>
            /// <para>用户登录标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>userPrincipalName, mail</para>
            /// </summary>
            [NameInMap("UserLoginIdentifier")]
            [Validation(Required=false)]
            public string UserLoginIdentifier { get; set; }

            /// <summary>
            /// <para>用户objectClass</para>
            /// 
            /// <b>Example:</b>
            /// <para>person,user</para>
            /// </summary>
            [NameInMap("UserObjectClass")]
            [Validation(Required=false)]
            public string UserObjectClass { get; set; }

            /// <summary>
            /// <para>用户自定义Filter</para>
            /// 
            /// <b>Example:</b>
            /// <para>(|(cn=test)(mail=<a href="mailto:test@test.com">test@test.com</a>))</para>
            /// </summary>
            [NameInMap("UserObjectClassCustomFilter")]
            [Validation(Required=false)]
            public string UserObjectClassCustomFilter { get; set; }

        }

        [NameInMap("LogoUrl")]
        [Validation(Required=false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// <para>网络端点ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>nae_examplexxxx</para>
        /// </summary>
        [NameInMap("NetworkAccessEndpointId")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointId { get; set; }

        /// <summary>
        /// <para>OIDC IdP配置。</para>
        /// </summary>
        [NameInMap("OidcConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestOidcConfig OidcConfig { get; set; }
        public class CreateIdentityProviderRequestOidcConfig : TeaModel {
            /// <summary>
            /// <para>OIDC客户端认证配置。</para>
            /// </summary>
            [NameInMap("AuthnParam")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestOidcConfigAuthnParam AuthnParam { get; set; }
            public class CreateIdentityProviderRequestOidcConfigAuthnParam : TeaModel {
                /// <summary>
                /// <para>OIDC/oAuth2 认证方法。</para>
                /// 
                /// <b>Example:</b>
                /// <para>client_secret_post</para>
                /// </summary>
                [NameInMap("AuthnMethod")]
                [Validation(Required=false)]
                public string AuthnMethod { get; set; }

                /// <summary>
                /// <para>OIDC/oAuth2 客户端ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>mkv7rgt4d7i4u7zqtzev2mxxxx</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>OIDC/oAuth2 客户端密钥。</para>
                /// 
                /// <b>Example:</b>
                /// <para>CSEHDddddddxxxxuxkJEHPveWRXBGqVqRsxxxx</para>
                /// </summary>
                [NameInMap("ClientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

            }

            /// <summary>
            /// <para>OIDC 端点配置。</para>
            /// </summary>
            [NameInMap("EndpointConfig")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestOidcConfigEndpointConfig EndpointConfig { get; set; }
            public class CreateIdentityProviderRequestOidcConfigEndpointConfig : TeaModel {
                /// <summary>
                /// <para>oAuth2 授权端点。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/authorize">https://example.com/auth/authorize</a></para>
                /// </summary>
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>OIDC issuer信息。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth">https://example.com/auth</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>OIDC jwks地址。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/jwks">https://example.com/auth/jwks</a></para>
                /// </summary>
                [NameInMap("JwksUri")]
                [Validation(Required=false)]
                public string JwksUri { get; set; }

                /// <summary>
                /// <para>oAuth2 Token端点。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/token">https://example.com/auth/token</a></para>
                /// </summary>
                [NameInMap("TokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

                /// <summary>
                /// <para>OIDC 用户信息端点。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth/userinfo">https://example.com/auth/userinfo</a></para>
                /// </summary>
                [NameInMap("UserinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>OIDC标准参数，如profile、email等</para>
            /// 
            /// <b>Example:</b>
            /// <para>openid</para>
            /// </summary>
            [NameInMap("GrantScopes")]
            [Validation(Required=false)]
            public List<string> GrantScopes { get; set; }

            /// <summary>
            /// <para>OIDC授权类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>authorization_code</para>
            /// </summary>
            [NameInMap("GrantType")]
            [Validation(Required=false)]
            public string GrantType { get; set; }

            /// <summary>
            /// <para>支持的PKCE算法类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>S256</para>
            /// </summary>
            [NameInMap("PkceChallengeMethod")]
            [Validation(Required=false)]
            public string PkceChallengeMethod { get; set; }

            /// <summary>
            /// <para>AuthorizationCode授权模式下是否使用PKCE。</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PkceRequired")]
            [Validation(Required=false)]
            public bool? PkceRequired { get; set; }

        }

        /// <summary>
        /// <para>同步入配置</para>
        /// </summary>
        [NameInMap("UdPullConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestUdPullConfig UdPullConfig { get; set; }
        public class CreateIdentityProviderRequestUdPullConfig : TeaModel {
            /// <summary>
            /// <para>是否支持组同步，默认为disabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("GroupSyncStatus")]
            [Validation(Required=false)]
            public string GroupSyncStatus { get; set; }

            /// <summary>
            /// <para>增量回调状态，是否处理来自IdP的增量回调数据</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("IncrementalCallbackStatus")]
            [Validation(Required=false)]
            public string IncrementalCallbackStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>同步入配置信息</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("UdSyncScopeConfig")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestUdPullConfigUdSyncScopeConfig UdSyncScopeConfig { get; set; }
            public class CreateIdentityProviderRequestUdPullConfigUdSyncScopeConfig : TeaModel {
                /// <summary>
                /// <para>同步来源节点</para>
                /// </summary>
                [NameInMap("SourceScopes")]
                [Validation(Required=false)]
                public List<string> SourceScopes { get; set; }

                /// <summary>
                /// <para>同步目标节点</para>
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
        /// <para>同步出配置</para>
        /// </summary>
        [NameInMap("UdPushConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestUdPushConfig UdPushConfig { get; set; }
        public class CreateIdentityProviderRequestUdPushConfig : TeaModel {
            /// <summary>
            /// <para>增量回调状态，是否处理来自IdP的增量回调数据</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("IncrementalCallbackStatus")]
            [Validation(Required=false)]
            public string IncrementalCallbackStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>同步出配置信息</para>
            /// </summary>
            [NameInMap("UdSyncScopeConfigs")]
            [Validation(Required=false)]
            public List<CreateIdentityProviderRequestUdPushConfigUdSyncScopeConfigs> UdSyncScopeConfigs { get; set; }
            public class CreateIdentityProviderRequestUdPushConfigUdSyncScopeConfigs : TeaModel {
                /// <summary>
                /// <para>同步来源节点</para>
                /// </summary>
                [NameInMap("SourceScopes")]
                [Validation(Required=false)]
                public List<string> SourceScopes { get; set; }

                /// <summary>
                /// <para>同步目标节点</para>
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
        /// <para>WeCom配置</para>
        /// </summary>
        [NameInMap("WeComConfig")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestWeComConfig WeComConfig { get; set; }
        public class CreateIdentityProviderRequestWeComConfig : TeaModel {
            /// <summary>
            /// <para>企业微信自建应用的Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>278231941749863339</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>授权回调域</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.aliyunidaas.com/xxxx">https://xxx.aliyunidaas.com/xxxx</a></para>
            /// </summary>
            [NameInMap("AuthorizeCallbackDomain")]
            [Validation(Required=false)]
            public string AuthorizeCallbackDomain { get; set; }

            /// <summary>
            /// <para>企业微信自建应用的corpId</para>
            /// 
            /// <b>Example:</b>
            /// <para>3756043633237690761</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>企业微信自建应用的corpSecret</para>
            /// 
            /// <b>Example:</b>
            /// <para>CSEHDddddddxxxxuxkJEHPveWRXBGqVqRsxxxx</para>
            /// </summary>
            [NameInMap("CorpSecret")]
            [Validation(Required=false)]
            public string CorpSecret { get; set; }

            /// <summary>
            /// <para>可信域名</para>
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
