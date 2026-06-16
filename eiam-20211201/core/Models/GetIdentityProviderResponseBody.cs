// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetIdentityProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the identity provider.</para>
        /// </summary>
        [NameInMap("IdentityProviderDetail")]
        [Validation(Required=false)]
        public GetIdentityProviderResponseBodyIdentityProviderDetail IdentityProviderDetail { get; set; }
        public class GetIdentityProviderResponseBodyIdentityProviderDetail : TeaModel {
            /// <summary>
            /// <para>The status of the advanced configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>disabled</c></para>
            /// </description></item>
            /// <item><description><para><c>enabled</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AdvancedStatus")]
            [Validation(Required=false)]
            public string AdvancedStatus { get; set; }

            /// <summary>
            /// <para>The authentication source product, such as Okta, Google, or Azure AD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>DingTalk: <c>urn:alibaba:idaas:idp:alibaba:dingtalk</c></para>
            /// </description></item>
            /// <item><description><para>LDAP: <c>urn:alibaba:idaas:idp:unknown:ldap</c></para>
            /// </description></item>
            /// <item><description><para>Alibaba Cloud IDaaS: <c>urn:alibaba:idaas:idp:alibaba:idaas</c></para>
            /// </description></item>
            /// <item><description><para>WeCom: <c>urn:alibaba:idaas:idp:tencent:wecom</c></para>
            /// </description></item>
            /// <item><description><para>Lark: <c>urn:alibaba:idaas:idp:bytedance:lark</c></para>
            /// </description></item>
            /// <item><description><para>Active Directory: <c>urn:alibaba:idaas:idp:microsoft:ad</c></para>
            /// </description></item>
            /// <item><description><para>Azure Active Directory: <c>urn:alibaba:idaas:idp:microsoft:aad</c></para>
            /// </description></item>
            /// <item><description><para>Alibaba Cloud SASE: <c>urn:alibaba:idaas:idp:alibaba:sase</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:idp:bytedance:lark</para>
            /// </summary>
            [NameInMap("AuthnSourceSupplier")]
            [Validation(Required=false)]
            public string AuthnSourceSupplier { get; set; }

            /// <summary>
            /// <para>The authentication protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>OIDC: <c>urn:alibaba:idaas:authntype:oidc</c></para>
            /// </description></item>
            /// <item><description><para>SAML: <c>urn:alibaba:idaas:authntype:saml2</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:authntype:oidc</para>
            /// </summary>
            [NameInMap("AuthnSourceType")]
            [Validation(Required=false)]
            public string AuthnSourceType { get; set; }

            /// <summary>
            /// <para>Indicates whether the identity provider supports authentication. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>disabled</c></para>
            /// </description></item>
            /// <item><description><para><c>enabled</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AuthnStatus")]
            [Validation(Required=false)]
            public string AuthnStatus { get; set; }

            /// <summary>
            /// <para>The time when the identity provider was created, represented as a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1726021079000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>for poc test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The basic configuration for DingTalk.</para>
            /// </summary>
            [NameInMap("DingtalkAppConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkAppConfig DingtalkAppConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkAppConfig : TeaModel {
                /// <summary>
                /// <para>The AppKey of your first-party application in DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>41reopmwoy9s</para>
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <para>The AppSecret of your first-party application in DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REOQ6Cl55kriOd8NOBeqWYLKpHR4p6fdZxxxx</para>
                /// </summary>
                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                /// <summary>
                /// <para>The corporate ID of your first-party application in DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3756043633237690761</para>
                /// </summary>
                [NameInMap("CorpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The version of DingTalk QR code login.</para>
                /// 
                /// <b>Example:</b>
                /// <para>old_version</para>
                /// </summary>
                [NameInMap("DingtalkLoginVersion")]
                [Validation(Required=false)]
                public string DingtalkLoginVersion { get; set; }

                /// <summary>
                /// <para>The DingTalk edition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Standard DingTalk: <c>public_dingtalk</c></para>
                /// </description></item>
                /// <item><description><para>Exclusive DingTalk: <c>private_dingtalk</c></para>
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
                /// <para>The encryption key for your first-party application in DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29003eb11d0a28b4802a6f02fb8aa25dff730e2ac26ffd200d</para>
                /// </summary>
                [NameInMap("EncryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>The verification token for your first-party application in DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5ba9c127a7abe029003eb11d0a28b4802a6f02fb8aa25dff730e2ac26ffd200d</para>
                /// </summary>
                [NameInMap("VerificationToken")]
                [Validation(Required=false)]
                public string VerificationToken { get; set; }

            }

            /// <summary>
            /// <para>The DingTalk provisioning configuration. This parameter is returned only for DingTalk identity providers.</para>
            /// </summary>
            [NameInMap("DingtalkProvisioningConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfig DingtalkProvisioningConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfig : TeaModel {
                /// <summary>
                /// <para>The authorized DingTalk departments.</para>
                /// </summary>
                [NameInMap("AuthedDepartmentIds")]
                [Validation(Required=false)]
                public List<GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfigAuthedDepartmentIds> AuthedDepartmentIds { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfigAuthedDepartmentIds : TeaModel {
                    /// <summary>
                    /// <para>The department ID in DingTalk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123xxx444</para>
                    /// </summary>
                    [NameInMap("DeptId")]
                    [Validation(Required=false)]
                    public string DeptId { get; set; }

                    /// <summary>
                    /// <para>The department name in DingTalk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_department</para>
                    /// </summary>
                    [NameInMap("DeptName")]
                    [Validation(Required=false)]
                    public string DeptName { get; set; }

                }

                /// <summary>
                /// <para>The list of authorized DingTalk user accounts.</para>
                /// </summary>
                [NameInMap("AuthedUsers")]
                [Validation(Required=false)]
                public List<GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfigAuthedUsers> AuthedUsers { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailDingtalkProvisioningConfigAuthedUsers : TeaModel {
                    /// <summary>
                    /// <para>The user name in DingTalk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zhangsan</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The user ID in DingTalk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>130308333929200479</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The corporate ID in DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ding_xxxxx</para>
                /// </summary>
                [NameInMap("CorpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The corporate name in DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_enterprise</para>
                /// </summary>
                [NameInMap("CorpName")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

            }

            /// <summary>
            /// <para>Endpoint metadata</para>
            /// </summary>
            [NameInMap("EndpointMetadata")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailEndpointMetadata EndpointMetadata { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailEndpointMetadata : TeaModel {
                /// <summary>
                /// <para>SAML ACS address</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://9test.aliyunidaas.com/login/saml2/idp_nhlraxfiwsx7w7zp26qzyoxxxx/acs">https://9test.aliyunidaas.com/login/saml2/idp_nhlraxfiwsx7w7zp26qzyoxxxx/acs</a></para>
                /// </summary>
                [NameInMap("SamlAcsEndpoint")]
                [Validation(Required=false)]
                public string SamlAcsEndpoint { get; set; }

                /// <summary>
                /// <para>SAML EntityId</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://9test.aliyunidaas.com/login/saml2/idp_nhlraxfiwsx7w7zp26qzyoxxxx/meta">https://9test.aliyunidaas.com/login/saml2/idp_nhlraxfiwsx7w7zp26qzyoxxxx/meta</a></para>
                /// </summary>
                [NameInMap("SamlEntityId")]
                [Validation(Required=false)]
                public string SamlEntityId { get; set; }

                /// <summary>
                /// <para>SAML metadata address</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://9test.aliyunidaas.com/login/saml2/idp_nhlraxfiwsx7w7zp26qzyoxxxx/meta">https://9test.aliyunidaas.com/login/saml2/idp_nhlraxfiwsx7w7zp26qzyoxxxx/meta</a></para>
                /// </summary>
                [NameInMap("SamlMetaEndpoint")]
                [Validation(Required=false)]
                public string SamlMetaEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The external ID of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_xxxx</para>
            /// </summary>
            [NameInMap("IdentityProviderExternalId")]
            [Validation(Required=false)]
            public string IdentityProviderExternalId { get; set; }

            /// <summary>
            /// <para>The identity provider ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_mwpcwnhrimlr2horx7xgg7pp7y</para>
            /// </summary>
            [NameInMap("IdentityProviderId")]
            [Validation(Required=false)]
            public string IdentityProviderId { get; set; }

            /// <summary>
            /// <para>The identity provider name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("IdentityProviderName")]
            [Validation(Required=false)]
            public string IdentityProviderName { get; set; }

            /// <summary>
            /// <para>The provisioning type of the identity provider.</para>
            /// <list type="bullet">
            /// <item><description><para>Inbound DingTalk: <c>urn:alibaba:idaas:idp:alibaba:dingtalk:pull</c></para>
            /// </description></item>
            /// <item><description><para>Outbound DingTalk: <c>urn:alibaba:idaas:idp:alibaba:dingtalk:push</c></para>
            /// </description></item>
            /// <item><description><para>Inbound WeCom: <c>urn:alibaba:idaas:idp:tencent:wecom:pull</c></para>
            /// </description></item>
            /// <item><description><para>Inbound Lark: <c>urn:alibaba:idaas:idp:bytedance:lark:pull</c></para>
            /// </description></item>
            /// <item><description><para>Inbound AD: <c>urn:alibaba:idaas:idp:microsoft:ad:pull</c></para>
            /// </description></item>
            /// <item><description><para>Inbound LDAP: <c>urn:alibaba:idaas:idp:unknown:ldap:pull</c></para>
            /// </description></item>
            /// <item><description><para>Standard OIDC: <c>urn:alibaba:idaas:idp:standard:oidc</c></para>
            /// </description></item>
            /// <item><description><para>Customized OIDC for SASE: <c>urn:alibaba:idaas:idp:alibaba:sase</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:idp:alibaba:dingtalk:push</para>
            /// </summary>
            [NameInMap("IdentityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_x2df3bak3uwnapqm6xxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The configuration for Lark.</para>
            /// </summary>
            [NameInMap("LarkConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailLarkConfig LarkConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailLarkConfig : TeaModel {
                /// <summary>
                /// <para>The App ID of your custom application in Lark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cli_a7a99f53a317100c</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The App Secret of your custom application in Lark.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                /// <summary>
                /// <para>The encryption key for your custom application in Lark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VkdWw91mdkrjVFr3ObNwefap21dfbZbK</para>
                /// </summary>
                [NameInMap("EncryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>The enterprise code for Lark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FX1231xxxx</para>
                /// </summary>
                [NameInMap("EnterpriseNumber")]
                [Validation(Required=false)]
                public string EnterpriseNumber { get; set; }

                /// <summary>
                /// <para>The Verification Token of your custom application in Lark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VkdWw91mdkrjVFr3ObNwefap21dfbZbK</para>
                /// </summary>
                [NameInMap("VerificationToken")]
                [Validation(Required=false)]
                public string VerificationToken { get; set; }

            }

            /// <summary>
            /// <para>The result of the last status check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("LastStatusCheckJobResult")]
            [Validation(Required=false)]
            public string LastStatusCheckJobResult { get; set; }

            /// <summary>
            /// <para>The information about the AD/LDAP identity provider.</para>
            /// </summary>
            [NameInMap("LdapConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailLdapConfig LdapConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailLdapConfig : TeaModel {
                /// <summary>
                /// <para>The password of the AD/LDAP administrator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXXX</para>
                /// </summary>
                [NameInMap("AdministratorPassword")]
                [Validation(Required=false)]
                public string AdministratorPassword { get; set; }

                /// <summary>
                /// <para>The username of the AD/LDAP administrator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("AdministratorUsername")]
                [Validation(Required=false)]
                public string AdministratorUsername { get; set; }

                /// <summary>
                /// <para>Indicates whether to verify the certificate fingerprint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>disabled</c></para>
                /// </description></item>
                /// <item><description><para><c>enabled</c></para>
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
                /// <para>The communication protocol for AD/LDAP.</para>
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
                /// <para>127.xx.xx.100</para>
                /// </summary>
                [NameInMap("LdapServerHost")]
                [Validation(Required=false)]
                public string LdapServerHost { get; set; }

                /// <summary>
                /// <para>The port of the AD/LDAP server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>389</para>
                /// </summary>
                [NameInMap("LdapServerPort")]
                [Validation(Required=false)]
                public int? LdapServerPort { get; set; }

                /// <summary>
                /// <para>Indicates whether StartTLS is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>disabled</c></para>
                /// </description></item>
                /// <item><description><para><c>enabled</c></para>
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
            /// <para>The lock reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>financial</para>
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// <para>The URL of the custom logo for the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img.alicdn.com/imgextra/i4/O1CN01lvYwpv1aGowQXDML9_!!6000000003303-0-tps-580-580.jpg">https://img.alicdn.com/imgextra/i4/O1CN01lvYwpv1aGowQXDML9_!!6000000003303-0-tps-580-580.jpg</a></para>
            /// </summary>
            [NameInMap("LogoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            /// <summary>
            /// <para>The network access endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae_mx4vsadfe6govkqkwckxxxx</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointId")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointId { get; set; }

            /// <summary>
            /// <para>The OIDC identity provider configuration.</para>
            /// </summary>
            [NameInMap("OidcConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfig OidcConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfig : TeaModel {
                /// <summary>
                /// <para>The OIDC client authentication configuration.</para>
                /// </summary>
                [NameInMap("AuthnParam")]
                [Validation(Required=false)]
                public GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfigAuthnParam AuthnParam { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfigAuthnParam : TeaModel {
                    /// <summary>
                    /// <para>The OIDC authentication method.</para>
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
                public GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfigEndpointConfig EndpointConfig { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailOidcConfigEndpointConfig : TeaModel {
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
                    /// <para>The OIDC JWKS URI.</para>
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
                /// <para>The list of OIDC authorization scopes.</para>
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
                /// <para>The algorithm for Proof Key for Code Exchange (PKCE). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>SHA256: <c>S256</c></para>
                /// </description></item>
                /// <item><description><para>Plaintext: <c>plain</c></para>
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
                /// <para>Indicates whether to use PKCE in the authorization code grant type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PkceRequired")]
                [Validation(Required=false)]
                public bool? PkceRequired { get; set; }

            }

            /// <summary>
            /// <para>The SAML identity provider configuration.</para>
            /// </summary>
            [NameInMap("SamlConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailSamlConfig SamlConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailSamlConfig : TeaModel {
                /// <summary>
                /// <para>Binding Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-REDIRECT</para>
                /// </summary>
                [NameInMap("BindingMethod")]
                [Validation(Required=false)]
                public string BindingMethod { get; set; }

                /// <summary>
                /// <para>The list of signing certificates for the SAML identity provider.</para>
                /// </summary>
                [NameInMap("Certificates")]
                [Validation(Required=false)]
                public List<GetIdentityProviderResponseBodyIdentityProviderDetailSamlConfigCertificates> Certificates { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailSamlConfigCertificates : TeaModel {
                    /// <summary>
                    /// <para>The metadata of the certificate.</para>
                    /// </summary>
                    [NameInMap("CertificateMetadata")]
                    [Validation(Required=false)]
                    public GetIdentityProviderResponseBodyIdentityProviderDetailSamlConfigCertificatesCertificateMetadata CertificateMetadata { get; set; }
                    public class GetIdentityProviderResponseBodyIdentityProviderDetailSamlConfigCertificatesCertificateMetadata : TeaModel {
                        /// <summary>
                        /// <para>Certificate expiration on or before</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1704067200000</para>
                        /// </summary>
                        [NameInMap("NotAfter")]
                        [Validation(Required=false)]
                        public long? NotAfter { get; set; }

                        /// <summary>
                        /// <para>Certificate not valid before</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1672531200000</para>
                        /// </summary>
                        [NameInMap("NotBefore")]
                        [Validation(Required=false)]
                        public long? NotBefore { get; set; }

                    }

                    /// <summary>
                    /// <para>The content of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-----BEGIN CERTIFICATE----- MIIC0jCCAbqgAwIBAgIQXXXXX -----END CERTIFICATE-----</para>
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
                /// <para>Maximum clock skew</para>
                /// 
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("MaxClockSkew")]
                [Validation(Required=false)]
                public long? MaxClockSkew { get; set; }

                /// <summary>
                /// <para>Is request signing required?</para>
                /// 
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
            /// <para>The inbound synchronization configuration.</para>
            /// </summary>
            [NameInMap("UdPullConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailUdPullConfig UdPullConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailUdPullConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether group synchronization is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>disabled</c></para>
                /// </description></item>
                /// <item><description><para><c>enabled</c></para>
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
                /// <para>Indicates whether to process incremental callback data from the identity provider. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>disabled</c></para>
                /// </description></item>
                /// <item><description><para><c>enabled</c></para>
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
                /// <para>The synchronization scope configuration.</para>
                /// </summary>
                [NameInMap("UdSyncScopeConfig")]
                [Validation(Required=false)]
                public GetIdentityProviderResponseBodyIdentityProviderDetailUdPullConfigUdSyncScopeConfig UdSyncScopeConfig { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailUdPullConfigUdSyncScopeConfig : TeaModel {
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
                    /// <para>ou_123xxxx</para>
                    /// </summary>
                    [NameInMap("TargetScope")]
                    [Validation(Required=false)]
                    public string TargetScope { get; set; }

                }

            }

            /// <summary>
            /// <para>Indicates whether inbound synchronization is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>disabled</c></para>
            /// </description></item>
            /// <item><description><para><c>enabled</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("UdPullStatus")]
            [Validation(Required=false)]
            public string UdPullStatus { get; set; }

            /// <summary>
            /// <para>The outbound synchronization configuration.</para>
            /// </summary>
            [NameInMap("UdPushConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailUdPushConfig UdPushConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailUdPushConfig : TeaModel {
                /// <summary>
                /// <para>This parameter is reserved for future use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>disabled</para>
                /// </summary>
                [NameInMap("IncrementalCallbackStatus")]
                [Validation(Required=false)]
                public string IncrementalCallbackStatus { get; set; }

                /// <summary>
                /// <para>The list of synchronization scope configurations.</para>
                /// </summary>
                [NameInMap("UdSyncScopeConfigs")]
                [Validation(Required=false)]
                public List<GetIdentityProviderResponseBodyIdentityProviderDetailUdPushConfigUdSyncScopeConfigs> UdSyncScopeConfigs { get; set; }
                public class GetIdentityProviderResponseBodyIdentityProviderDetailUdPushConfigUdSyncScopeConfigs : TeaModel {
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
                    /// <para>ou_123xxxx</para>
                    /// </summary>
                    [NameInMap("TargetScope")]
                    [Validation(Required=false)]
                    public string TargetScope { get; set; }

                }

            }

            /// <summary>
            /// <para>Indicates whether outbound synchronization is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>disabled</c></para>
            /// </description></item>
            /// <item><description><para><c>enabled</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("UdPushStatus")]
            [Validation(Required=false)]
            public string UdPushStatus { get; set; }

            /// <summary>
            /// <para>The last update time, represented as a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1726021079000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The configuration information for WeCom.</para>
            /// </summary>
            [NameInMap("WeComConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyIdentityProviderDetailWeComConfig WeComConfig { get; set; }
            public class GetIdentityProviderResponseBodyIdentityProviderDetailWeComConfig : TeaModel {
                /// <summary>
                /// <para>The ID of your custom application in WeCom.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1242350</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The authorized callback domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/xxxx">https://example.com/xxxx</a></para>
                /// </summary>
                [NameInMap("AuthorizeCallbackDomain")]
                [Validation(Required=false)]
                public string AuthorizeCallbackDomain { get; set; }

                /// <summary>
                /// <para>The corporate ID of your custom application in WeCom.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3562012953454577801</para>
                /// </summary>
                [NameInMap("CorpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The secret of your custom application in WeCom.</para>
                /// 
                /// <b>Example:</b>
                /// <para>weaseiszjskejskaj12sjeszojxxxx</para>
                /// </summary>
                [NameInMap("CorpSecret")]
                [Validation(Required=false)]
                public string CorpSecret { get; set; }

                /// <summary>
                /// <para>The trusted domain.</para>
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
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
