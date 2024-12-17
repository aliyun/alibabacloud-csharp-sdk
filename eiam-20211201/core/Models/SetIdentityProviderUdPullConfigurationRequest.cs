// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetIdentityProviderUdPullConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>组同步状态</para>
        /// 
        /// <b>Example:</b>
        /// <para>disabled</para>
        /// </summary>
        [NameInMap("GroupSyncStatus")]
        [Validation(Required=false)]
        public string GroupSyncStatus { get; set; }

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
        /// <para>增量回调状态，是否处理来自IdP的增量回调数据</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disabled</para>
        /// </summary>
        [NameInMap("IncrementalCallbackStatus")]
        [Validation(Required=false)]
        public string IncrementalCallbackStatus { get; set; }

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
        /// <para>ldap同步侧相关配置信息</para>
        /// </summary>
        [NameInMap("LdapUdPullConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPullConfigurationRequestLdapUdPullConfig LdapUdPullConfig { get; set; }
        public class SetIdentityProviderUdPullConfigurationRequestLdapUdPullConfig : TeaModel {
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
            /// <para>组织ObjectClass</para>
            /// 
            /// <b>Example:</b>
            /// <para>organizationUnit,top</para>
            /// </summary>
            [NameInMap("OrganizationUnitObjectClass")]
            [Validation(Required=false)]
            public string OrganizationUnitObjectClass { get; set; }

            /// <summary>
            /// <para>用户ObjectClass</para>
            /// 
            /// <b>Example:</b>
            /// <para>userPrincipalName, mail</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>disabled</para>
        /// </summary>
        [NameInMap("PeriodicSyncStatus")]
        [Validation(Required=false)]
        public string PeriodicSyncStatus { get; set; }

        /// <summary>
        /// <para>同步入保护规则,根据IdP的type做解析</para>
        /// </summary>
        [NameInMap("PullProtectedRule")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPullConfigurationRequestPullProtectedRule PullProtectedRule { get; set; }
        public class SetIdentityProviderUdPullConfigurationRequestPullProtectedRule : TeaModel {
            /// <summary>
            /// <para>同步保护规则-删除组数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("GroupDeletedThreshold")]
            [Validation(Required=false)]
            public int? GroupDeletedThreshold { get; set; }

            /// <summary>
            /// <para>钉钉一方应用同步保护规则-删除组织数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OrganizationalUnitDeletedThreshold")]
            [Validation(Required=false)]
            public int? OrganizationalUnitDeletedThreshold { get; set; }

            /// <summary>
            /// <para>钉钉一方应用同步保护规则-删除账户数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("UserDeletedThreshold")]
            [Validation(Required=false)]
            public int? UserDeletedThreshold { get; set; }

        }

        /// <summary>
        /// <para>同步入配置信息</para>
        /// </summary>
        [NameInMap("UdSyncScopeConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPullConfigurationRequestUdSyncScopeConfig UdSyncScopeConfig { get; set; }
        public class SetIdentityProviderUdPullConfigurationRequestUdSyncScopeConfig : TeaModel {
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
            /// <para>ou_asdaq1addsxzdq1XXX</para>
            /// </summary>
            [NameInMap("TargetScope")]
            [Validation(Required=false)]
            public string TargetScope { get; set; }

        }

    }

}
