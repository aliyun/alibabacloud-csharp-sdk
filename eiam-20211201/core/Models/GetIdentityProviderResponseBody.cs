// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetIdentityProviderResponseBody : TeaModel {
        [NameInMap("IdentityProviderDetail")]
        [Validation(Required=false)]
        public GetIdentityProviderResponseBodyIdentityProviderDetail IdentityProviderDetail { get; set; }
        public class GetIdentityProviderResponseBodyIdentityProviderDetail : TeaModel {
            /// <summary>
            /// <para>高阶配置能力</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AdvancedStatus")]
            [Validation(Required=false)]
            public string AdvancedStatus { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 对应的认证来源产品，okta or google or azure ad</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:idp:bytedance:lark</para>
            /// </summary>
            [NameInMap("AuthnSourceSupplier")]
            [Validation(Required=false)]
            public string AuthnSourceSupplier { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 认证方式类型 oidc or saml</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:authntype:oidc</para>
            /// </summary>
            [NameInMap("AuthnSourceType")]
            [Validation(Required=false)]
            public string AuthnSourceType { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 对应IdP是否支持认证</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AuthnStatus")]
            [Validation(Required=false)]
            public string AuthnStatus { get; set; }

            /// <summary>
            /// <para>创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1726021079000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 身份提供方描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>for poc test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>钉钉基础配置</para>
            /// </summary>
            [NameInMap("DingtalkAppConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkAppConfig DingtalkAppConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkAppConfig : TeaModel {
                /// <summary>
                /// <para>IDaaS EIAM 钉钉一方应用的AppKey</para>
                /// 
                /// <b>Example:</b>
                /// <para>41reopmwoy9s</para>
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <para>IDaaS EIAM 钉钉一方应用的AppSecret</para>
                /// 
                /// <b>Example:</b>
                /// <para>REOQ6Cl55kriOd8NOBeqWYLKpHR4p6fdZxxxx</para>
                /// </summary>
                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                /// <summary>
                /// <para>IDaaS EIAM 钉钉一方应用的corpId</para>
                /// 
                /// <b>Example:</b>
                /// <para>3756043633237690761</para>
                /// </summary>
                [NameInMap("CorpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>IDaaS EIAM 钉钉版本</para>
                /// 
                /// <b>Example:</b>
                /// <para>public_dingtalk</para>
                /// </summary>
                [NameInMap("DingtalkVersion")]
                [Validation(Required=false)]
                public string DingtalkVersion { get; set; }

            }

            /// <summary>
            /// <para>钉钉同步配置</para>
            /// </summary>
            [NameInMap("DingtalkProvisioningConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfig DingtalkProvisioningConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfig : TeaModel {
                /// <summary>
                /// <para>授权的钉钉部门</para>
                /// </summary>
                [NameInMap("AuthedDepartmentIds")]
                [Validation(Required=false)]
                public List<GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfigAuthedDepartmentIds> AuthedDepartmentIds { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfigAuthedDepartmentIds : TeaModel {
                    /// <summary>
                    /// <para>钉钉部门Id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123xxx444</para>
                    /// </summary>
                    [NameInMap("DeptId")]
                    [Validation(Required=false)]
                    public string DeptId { get; set; }

                    /// <summary>
                    /// <para>钉钉部门名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试部门</para>
                    /// </summary>
                    [NameInMap("DeptName")]
                    [Validation(Required=false)]
                    public string DeptName { get; set; }

                }

                /// <summary>
                /// <para>授权的钉钉账户列表</para>
                /// </summary>
                [NameInMap("AuthedUsers")]
                [Validation(Required=false)]
                public List<GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfigAuthedUsers> AuthedUsers { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfigAuthedUsers : TeaModel {
                    /// <summary>
                    /// <para>钉钉用户名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>钉钉用户userId</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>130308333929200479</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>钉钉企业corpId</para>
                /// 
                /// <b>Example:</b>
                /// <para>ding_xxxxx</para>
                /// </summary>
                [NameInMap("CorpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>钉钉企业名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试企业</para>
                /// </summary>
                [NameInMap("CorpName")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

            }

            /// <summary>
            /// <para>IDaaS EIAM 身份提供方外部ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_xxxx</para>
            /// </summary>
            [NameInMap("IdentityProviderExternalId")]
            [Validation(Required=false)]
            public string IdentityProviderExternalId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 身份提供方ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_mwpcwnhrimlr2horx7xgg7pp7y</para>
            /// </summary>
            [NameInMap("IdentityProviderId")]
            [Validation(Required=false)]
            public string IdentityProviderId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 身份提供方名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("IdentityProviderName")]
            [Validation(Required=false)]
            public string IdentityProviderName { get; set; }

            /// <summary>
            /// <para>身份提供方同步类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:idp:alibaba:dingtalk:push</para>
            /// </summary>
            [NameInMap("IdentityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 实例Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_x2df3bak3uwnapqm6xxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>飞书配置</para>
            /// </summary>
            [NameInMap("LarkConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailLarkConfig LarkConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailLarkConfig : TeaModel {
                /// <summary>
                /// <para>IDaaS EIAM 飞书自建应用的corpId</para>
                /// 
                /// <b>Example:</b>
                /// <para>cli_a7a99f53a317100c</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>IDaaS EIAM 飞书自建应用的AppSecret</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                [NameInMap("EncryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>IDaaS EIAM 飞书企业编码</para>
                /// 
                /// <b>Example:</b>
                /// <para>FX1231xxxx</para>
                /// </summary>
                [NameInMap("EnterpriseNumber")]
                [Validation(Required=false)]
                public string EnterpriseNumber { get; set; }

                [NameInMap("VerificationToken")]
                [Validation(Required=false)]
                public string VerificationToken { get; set; }

            }

            /// <summary>
            /// <para>最后一次状态检查结果</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("LastStatusCheckJobResult")]
            [Validation(Required=false)]
            public string LastStatusCheckJobResult { get; set; }

            /// <summary>
            /// <para>AD/LDAP身份提供方相关信息</para>
            /// </summary>
            [NameInMap("LdapConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailLdapConfig LdapConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailLdapConfig : TeaModel {
                /// <summary>
                /// <para>管理员密码</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXXX</para>
                /// </summary>
                [NameInMap("AdministratorPassword")]
                [Validation(Required=false)]
                public string AdministratorPassword { get; set; }

                /// <summary>
                /// <para>管理员账号</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
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
                /// <para>127.xx.xx.100</para>
                /// </summary>
                [NameInMap("LdapServerHost")]
                [Validation(Required=false)]
                public string LdapServerHost { get; set; }

                /// <summary>
                /// <para>ad/ldap 服务器地址</para>
                /// 
                /// <b>Example:</b>
                /// <para>389</para>
                /// </summary>
                [NameInMap("LdapServerPort")]
                [Validation(Required=false)]
                public int? LdapServerPort { get; set; }

                /// <summary>
                /// <para>startTls是否开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("StartTlsStatus")]
                [Validation(Required=false)]
                public string StartTlsStatus { get; set; }

            }

            /// <summary>
            /// <para>锁定原因</para>
            /// 
            /// <b>Example:</b>
            /// <para>financial</para>
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            [NameInMap("LogoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            /// <summary>
            /// <para>网络端点ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae_mx4vsadfe6govkqkwckxxxx</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointId")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointId { get; set; }

            /// <summary>
            /// <para>OIDC IdP配置。</para>
            /// </summary>
            [NameInMap("OidcConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfig OidcConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfig : TeaModel {
                /// <summary>
                /// <para>OIDC客户端认证配置。</para>
                /// </summary>
                [NameInMap("AuthnParam")]
                [Validation(Required=false)]
                public GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfigAuthnParam AuthnParam { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfigAuthnParam : TeaModel {
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
                public GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfigEndpointConfig EndpointConfig { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfigEndpointConfig : TeaModel {
                    /// <summary>
                    /// <para>oAuth2 授权端点。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/oauth/authorize">https://example.com/oauth/authorize</a></para>
                    /// </summary>
                    [NameInMap("AuthorizationEndpoint")]
                    [Validation(Required=false)]
                    public string AuthorizationEndpoint { get; set; }

                    /// <summary>
                    /// <para>OIDC issuer信息。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/oauth">https://example.com/oauth</a></para>
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// <para>OIDC jwks地址。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/oauth/jwks">https://example.com/oauth/jwks</a></para>
                    /// </summary>
                    [NameInMap("JwksUri")]
                    [Validation(Required=false)]
                    public string JwksUri { get; set; }

                    /// <summary>
                    /// <para>oAuth2 Token端点。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/oauth/token">https://example.com/oauth/token</a></para>
                    /// </summary>
                    [NameInMap("TokenEndpoint")]
                    [Validation(Required=false)]
                    public string TokenEndpoint { get; set; }

                    /// <summary>
                    /// <para>OIDC 用户信息端点。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/oauth/userinfo">https://example.com/oauth/userinfo</a></para>
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
            public GetIdentityProviderResponseBodyIdentityProviderDetailUdPullConfig UdPullConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailUdPullConfig : TeaModel {
                /// <summary>
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
                /// <para>同步入配置信息</para>
                /// </summary>
                [NameInMap("UdSyncScopeConfig")]
                [Validation(Required=false)]
                public GetIdentityProviderResponseBodyIdentityProviderDetailUdPullConfigUdSyncScopeConfig UdSyncScopeConfig { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailUdPullConfigUdSyncScopeConfig : TeaModel {
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
                    /// <para>ou_123xxxx</para>
                    /// </summary>
                    [NameInMap("TargetScope")]
                    [Validation(Required=false)]
                    public string TargetScope { get; set; }

                }

            }

            /// <summary>
            /// <para>IDaaS EIAM 是否支持UD同步</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("UdPullStatus")]
            [Validation(Required=false)]
            public string UdPullStatus { get; set; }

            /// <summary>
            /// <para>同步出配置</para>
            /// </summary>
            [NameInMap("UdPushConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailUdPushConfig UdPushConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailUdPushConfig : TeaModel {
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
                /// <para>同步出配置信息</para>
                /// </summary>
                [NameInMap("UdSyncScopeConfigs")]
                [Validation(Required=false)]
                public List<GetIdentityProviderResponseBodyIdentityProviderDetailUdPushConfigUdSyncScopeConfigs> UdSyncScopeConfigs { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailUdPushConfigUdSyncScopeConfigs : TeaModel {
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
                    /// <para>ou_123xxxx</para>
                    /// </summary>
                    [NameInMap("TargetScope")]
                    [Validation(Required=false)]
                    public string TargetScope { get; set; }

                }

            }

            /// <summary>
            /// <para>同步出能力</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("UdPushStatus")]
            [Validation(Required=false)]
            public string UdPushStatus { get; set; }

            /// <summary>
            /// <para>更新时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1726021079000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>企业微信</para>
            /// </summary>
            [NameInMap("WeComConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailWeComConfig WeComConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailWeComConfig : TeaModel {
                /// <summary>
                /// <para>IDaaS EIAM 企业微信自建应用的Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>1242350</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>授权回调域</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/xxxx">https://example.com/xxxx</a></para>
                /// </summary>
                [NameInMap("AuthorizeCallbackDomain")]
                [Validation(Required=false)]
                public string AuthorizeCallbackDomain { get; set; }

                /// <summary>
                /// <para>IDaaS EIAM 企业微信自建应用的corpId</para>
                /// 
                /// <b>Example:</b>
                /// <para>3562012953454577801</para>
                /// </summary>
                [NameInMap("CorpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>IDaaS EIAM 企业微信自建应用的corpSecret</para>
                /// 
                /// <b>Example:</b>
                /// <para>weaseiszjskejskaj12sjeszojxxxx</para>
                /// </summary>
                [NameInMap("CorpSecret")]
                [Validation(Required=false)]
                public string CorpSecret { get; set; }

                /// <summary>
                /// <para>可信域名</para>
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
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
