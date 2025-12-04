// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateIdentityProviderRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>钉钉出基本信息</para>
        /// </summary>
        [NameInMap("DingtalkAppConfig")]
        [Validation(Required=false)]
        public UpdateIdentityProviderRequestDingtalkAppConfig DingtalkAppConfig { get; set; }
        public class UpdateIdentityProviderRequestDingtalkAppConfig : TeaModel {
            /// <summary>
            /// <para>钉钉一方应用的AppKey</para>
            /// 
            /// <b>Example:</b>
            /// <para>49nyeaqumk7f</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>钉钉一方应用的AppSecret</para>
            /// 
            /// <b>Example:</b>
            /// <para>86nozWFL2CxgwnhKiXaG8dN4keLPkUNc5xxxx</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingtalk</para>
            /// </summary>
            [NameInMap("DingtalkLoginVersion")]
            [Validation(Required=false)]
            public string DingtalkLoginVersion { get; set; }

            [NameInMap("EncryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            [NameInMap("VerificationToken")]
            [Validation(Required=false)]
            public string VerificationToken { get; set; }

        }

        /// <summary>
        /// <para>IDaaS的身份提供方主键id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp_my664lwkhpicbyzirog3xxxxx</para>
        /// </summary>
        [NameInMap("IdentityProviderId")]
        [Validation(Required=false)]
        public string IdentityProviderId { get; set; }

        /// <summary>
        /// <para>身份提供方名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("IdentityProviderName")]
        [Validation(Required=false)]
        public string IdentityProviderName { get; set; }

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
        public UpdateIdentityProviderRequestLarkConfig LarkConfig { get; set; }
        public class UpdateIdentityProviderRequestLarkConfig : TeaModel {
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

            [NameInMap("EncryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            [NameInMap("VerificationToken")]
            [Validation(Required=false)]
            public string VerificationToken { get; set; }

        }

        /// <summary>
        /// <para>AD/LDAP基本信息</para>
        /// </summary>
        [NameInMap("LdapConfig")]
        [Validation(Required=false)]
        public UpdateIdentityProviderRequestLdapConfig LdapConfig { get; set; }
        public class UpdateIdentityProviderRequestLdapConfig : TeaModel {
            /// <summary>
            /// <para>管理员密码</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
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
            /// <para>startTls是否开启</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("StartTlsStatus")]
            [Validation(Required=false)]
            public string StartTlsStatus { get; set; }

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
        public UpdateIdentityProviderRequestOidcConfig OidcConfig { get; set; }
        public class UpdateIdentityProviderRequestOidcConfig : TeaModel {
            /// <summary>
            /// <para>OIDC客户端认证配置。</para>
            /// </summary>
            [NameInMap("AuthnParam")]
            [Validation(Required=false)]
            public UpdateIdentityProviderRequestOidcConfigAuthnParam AuthnParam { get; set; }
            public class UpdateIdentityProviderRequestOidcConfigAuthnParam : TeaModel {
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
            public UpdateIdentityProviderRequestOidcConfigEndpointConfig EndpointConfig { get; set; }
            public class UpdateIdentityProviderRequestOidcConfigEndpointConfig : TeaModel {
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
        /// <para>企业微信基本信息</para>
        /// </summary>
        [NameInMap("WeComConfig")]
        [Validation(Required=false)]
        public UpdateIdentityProviderRequestWeComConfig WeComConfig { get; set; }
        public class UpdateIdentityProviderRequestWeComConfig : TeaModel {
            /// <summary>
            /// <para>企业微信自建应用的Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>1237403</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>授权回调域</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.aliyunidaas.com/xxxxx">https://xxx.aliyunidaas.com/xxxxx</a></para>
            /// </summary>
            [NameInMap("AuthorizeCallbackDomain")]
            [Validation(Required=false)]
            public string AuthorizeCallbackDomain { get; set; }

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
            /// <para><a href="https://xxx.aliyunidaas.com">https://xxx.aliyunidaas.com</a></para>
            /// </summary>
            [NameInMap("TrustableDomain")]
            [Validation(Required=false)]
            public string TrustableDomain { get; set; }

        }

    }

}
