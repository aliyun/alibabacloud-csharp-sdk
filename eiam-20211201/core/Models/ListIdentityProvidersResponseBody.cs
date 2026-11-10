// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListIdentityProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of identity providers.</para>
        /// </summary>
        [NameInMap("IdentityProviders")]
        [Validation(Required=false)]
        public List<ListIdentityProvidersResponseBodyIdentityProviders> IdentityProviders { get; set; }
        public class ListIdentityProvidersResponseBodyIdentityProviders : TeaModel {
            /// <summary>
            /// <para>Specifies whether the advanced configuration capability is enabled. Valid values:</para>
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
            [NameInMap("AdvancedStatus")]
            [Validation(Required=false)]
            public string AdvancedStatus { get; set; }

            /// <summary>
            /// <para>The authentication source product, such as Okta, Google, or Azure AD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>urn:alibaba:idaas:idp:alibaba:dingtalk: DingTalk.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:unknown:ldap: LDAP.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:alibaba:idaas: Alibaba Cloud IDaaS.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:tencent:wecom: WeCom.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:bytedance:lark: Lark.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:microsoft:ad: Active Directory.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:microsoft:aad: Azure Active Directory.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:alibaba:sase: Alibaba Cloud SASE.</para>
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
            /// <para>The authentication method type, which can be OIDC or SAML. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>urn:alibaba:idaas:authntype:oidc: OIDC.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:authntype:saml2: SAML.</para>
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
            /// <para>Specifies whether the IdP supports authentication. Valid values:</para>
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
            [NameInMap("AuthnStatus")]
            [Validation(Required=false)]
            public string AuthnStatus { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1712561597000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The external ID of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_123</para>
            /// </summary>
            [NameInMap("IdentityProviderExternalId")]
            [Validation(Required=false)]
            public string IdentityProviderExternalId { get; set; }

            /// <summary>
            /// <para>The identity provider ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_m5b5wd5s2hpq4t6iaehhXXX</para>
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
            /// <para>The identity provider synchronization type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>urn:alibaba:idaas:idp:alibaba:dingtalk:pull: Inbound DingTalk.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:alibaba:dingtalk:push: Outbound DingTalk.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:tencent:wecom:pull: Inbound WeCom.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:bytedance:lark:pull: Inbound Lark.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:microsoft:ad:pull: Inbound Active Directory.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:unknown:ldap:pull: Inbound LDAP.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:standard:oidc: Standard OIDC.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:idp:alibaba:sase: SASE custom OIDC.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:idp:bytedance:lark:pull</para>
            /// </summary>
            [NameInMap("IdentityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>The incremental callback status, which specifies whether to process incremental callback data from the IdP. Valid values:</para>
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
            [NameInMap("IncrementalCallbackStatus")]
            [Validation(Required=false)]
            public string IncrementalCallbackStatus { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_pbf4dth34l2qb7mydpntXXX</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The result of the last status check. A synchronization task can be triggered only when the identity provider status check result is success before synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("LastStatusCheckJobResult")]
            [Validation(Required=false)]
            public string LastStatusCheckJobResult { get; set; }

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
            /// <para>The custom logo URL of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cdn-cn-hangzhou.aliyunidaas.com/xx/logos/xx">https://cdn-cn-hangzhou.aliyunidaas.com/xx/logos/xx</a></para>
            /// </summary>
            [NameInMap("LogoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            /// <summary>
            /// <para>The periodic verification status, which specifies whether to periodically verify data differences between EIAM and the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>Specifies whether the inbound synchronization feature is supported. Valid values:</para>
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
            [NameInMap("UdPullStatus")]
            [Validation(Required=false)]
            public string UdPullStatus { get; set; }

            /// <summary>
            /// <para>The synchronization target node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_2buqmxsa3ltyqkjgpwfijurXXX</para>
            /// </summary>
            [NameInMap("UdPullTargetScope")]
            [Validation(Required=false)]
            public string UdPullTargetScope { get; set; }

            /// <summary>
            /// <para>Specifies whether the outbound synchronization capability is enabled. Valid values:</para>
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
            [NameInMap("UdPushStatus")]
            [Validation(Required=false)]
            public string UdPushStatus { get; set; }

            /// <summary>
            /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1712561597000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
