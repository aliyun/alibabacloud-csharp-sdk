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
            /// <para>Indicates whether advanced configuration is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled: The feature is disabled.</para>
            /// </description></item>
            /// <item><description><para>enabled: The feature is enabled.</para>
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
            /// <para>The authentication source product, such as Okta, Google, or Azure AD.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>DingTalk: urn:alibaba:idaas:idp:alibaba:dingtalk</para>
            /// </description></item>
            /// <item><description><para>LDAP: urn:alibaba:idaas:idp:unknown:ldap</para>
            /// </description></item>
            /// <item><description><para>Alibaba Cloud IDaaS: urn:alibaba:idaas:idp:alibaba:idaas</para>
            /// </description></item>
            /// <item><description><para>WeCom: urn:alibaba:idaas:idp:tencent:wecom</para>
            /// </description></item>
            /// <item><description><para>Lark: urn:alibaba:idaas:idp:bytedance:lark</para>
            /// </description></item>
            /// <item><description><para>Active Directory: urn:alibaba:idaas:idp:microsoft:ad</para>
            /// </description></item>
            /// <item><description><para>Azure Active Directory: urn:alibaba:idaas:idp:microsoft:aad</para>
            /// </description></item>
            /// <item><description><para>Alibaba Cloud SASE: urn:alibaba:idaas:idp:alibaba:sase</para>
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
            /// <para>The authentication method type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>OIDC: urn:alibaba:idaas:authntype:oidc</para>
            /// </description></item>
            /// <item><description><para>SAML: urn:alibaba:idaas:authntype:saml2</para>
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
            /// <item><description><para>disabled: Authentication is disabled.</para>
            /// </description></item>
            /// <item><description><para>enabled: Authentication is enabled.</para>
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
            /// <para>The time when the identity provider was created. This is a UNIX timestamp. Unit: milliseconds.</para>
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
            /// <para>xxxx</para>
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
            /// <item><description><para>Custom OIDC for SASE: urn:alibaba:idaas:idp:alibaba:sase</para>
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
            /// <para>The incremental callback status. This indicates whether to process incremental callback data from the identity provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled: The feature is disabled.</para>
            /// </description></item>
            /// <item><description><para>enabled: The feature is enabled.</para>
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
            /// <para>The result of the last status check. A sync task can be triggered only when the status check of the identity provider returns \<c>success\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("LastStatusCheckJobResult")]
            [Validation(Required=false)]
            public string LastStatusCheckJobResult { get; set; }

            /// <summary>
            /// <para>The reason why the identity provider is locked.</para>
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
            /// <para><a href="https://cdn-cn-hangzhou.aliyunidaas.com/xx/logos/xx">https://cdn-cn-hangzhou.aliyunidaas.com/xx/logos/xx</a></para>
            /// </summary>
            [NameInMap("LogoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            /// <summary>
            /// <para>The periodic check status. This indicates whether to periodically check for data inconsistencies between IDaaS and the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether inbound synchronization is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled: The feature is disabled.</para>
            /// </description></item>
            /// <item><description><para>enabled: The feature is enabled.</para>
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
            /// <para>The target node for synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_2buqmxsa3ltyqkjgpwfijurXXX</para>
            /// </summary>
            [NameInMap("UdPullTargetScope")]
            [Validation(Required=false)]
            public string UdPullTargetScope { get; set; }

            /// <summary>
            /// <para>Indicates whether outbound synchronization is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>disabled: The feature is disabled.</para>
            /// </description></item>
            /// <item><description><para>enabled: The feature is enabled.</para>
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
            /// <para>The time when the identity provider was last updated. This is a UNIX timestamp. Unit: milliseconds.</para>
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
