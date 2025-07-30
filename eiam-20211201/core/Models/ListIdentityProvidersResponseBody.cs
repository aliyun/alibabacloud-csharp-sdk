// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListIdentityProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>Identity provider information array.</para>
        /// </summary>
        [NameInMap("IdentityProviders")]
        [Validation(Required=false)]
        public List<ListIdentityProvidersResponseBodyIdentityProviders> IdentityProviders { get; set; }
        public class ListIdentityProvidersResponseBodyIdentityProviders : TeaModel {
            /// <summary>
            /// <para>Advanced configuration capabilities</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AdvancedStatus")]
            [Validation(Required=false)]
            public string AdvancedStatus { get; set; }

            /// <summary>
            /// <para>Authentication source product.</para>
            /// <list type="bullet">
            /// <item><description>urn:alibaba:idaas:idp:okta:okta</description></item>
            /// <item><description>urn:alibaba:idaas:idp:google:account</description></item>
            /// <item><description>urn:alibaba:idaas:idp:microsoft:aad</description></item>
            /// <item><description>urn:alibaba:idaas:idp:microsoft:ad</description></item>
            /// <item><description>urn:alibaba:idaas:idp:bytedance:lark</description></item>
            /// <item><description>urn:alibaba:idaas:idp:unknown:ldap</description></item>
            /// <item><description>urn:alibaba:idaas:idp:alibaba:idaas</description></item>
            /// <item><description>urn:alibaba:idaas:idp:tencent:wecom</description></item>
            /// <item><description>urn:alibaba:idaas:idp:alibaba:aliyunram</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:idp:bytedance:lark</para>
            /// </summary>
            [NameInMap("AuthnSourceSupplier")]
            [Validation(Required=false)]
            public string AuthnSourceSupplier { get; set; }

            /// <summary>
            /// <para>Authentication method type.</para>
            /// <list type="bullet">
            /// <item><description>urn:alibaba:idaas:authntype:oidc</description></item>
            /// <item><description>urn:alibaba:idaas:authntype:saml2</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:authntype:oidc</para>
            /// </summary>
            [NameInMap("AuthnSourceType")]
            [Validation(Required=false)]
            public string AuthnSourceType { get; set; }

            /// <summary>
            /// <para>Does the corresponding IdP support authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AuthnStatus")]
            [Validation(Required=false)]
            public string AuthnStatus { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1712561597000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the Identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Identity provider external ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_123xxx</para>
            /// </summary>
            [NameInMap("IdentityProviderExternalId")]
            [Validation(Required=false)]
            public string IdentityProviderExternalId { get; set; }

            /// <summary>
            /// <para>Identity provider ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_m5b5wd5s2hpq4t6iaehhXXX</para>
            /// </summary>
            [NameInMap("IdentityProviderId")]
            [Validation(Required=false)]
            public string IdentityProviderId { get; set; }

            /// <summary>
            /// <para>Identity provider name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ceshi</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:idp:bytedance:lark:pull</para>
            /// </summary>
            [NameInMap("IdentityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>Incremental callback status, whether to process the incremental callback data from IdP.</para>
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
            /// <para>Last status check result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("LastStatusCheckJobResult")]
            [Validation(Required=false)]
            public string LastStatusCheckJobResult { get; set; }

            /// <summary>
            /// <para>The reason why write operations are locked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ConfigNotReady.UuidIsNul</para>
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// <para>IdP logo url.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cdn-cn-hangzhou.aliyunidaas.com/xx/logos/xx">https://cdn-cn-hangzhou.aliyunidaas.com/xx/logos/xx</a></para>
            /// </summary>
            [NameInMap("LogoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            /// <summary>
            /// <para>Regular verification status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>Whether support UD synchronization.Values:</para>
            /// <list type="bullet">
            /// <item><description>enabled</description></item>
            /// <item><description>disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("UdPullStatus")]
            [Validation(Required=false)]
            public string UdPullStatus { get; set; }

            /// <summary>
            /// <para>When supporting the range in the UD of ud_pullIDaaS side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_2buqmxsa3ltyqkjgpwfijurXXX</para>
            /// </summary>
            [NameInMap("UdPullTargetScope")]
            [Validation(Required=false)]
            public string UdPullTargetScope { get; set; }

            /// <summary>
            /// <para>Synchronize capabilities</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("UdPushStatus")]
            [Validation(Required=false)]
            public string UdPushStatus { get; set; }

            /// <summary>
            /// <para>The time when the service was updated.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
