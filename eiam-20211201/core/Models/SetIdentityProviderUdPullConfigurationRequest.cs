// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetIdentityProviderUdPullConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>Group synchronization status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disabled</para>
        /// </summary>
        [NameInMap("GroupSyncStatus")]
        [Validation(Required=false)]
        public string GroupSyncStatus { get; set; }

        /// <summary>
        /// <para>Identity provider ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp_my664lwkhpicbyzirog3xxxxx</para>
        /// </summary>
        [NameInMap("IdentityProviderId")]
        [Validation(Required=false)]
        public string IdentityProviderId { get; set; }

        /// <summary>
        /// <para>Incremental callback status, whether to process incremental callback data from IdP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disabled</para>
        /// </summary>
        [NameInMap("IncrementalCallbackStatus")]
        [Validation(Required=false)]
        public string IncrementalCallbackStatus { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Ldap ud pull config</para>
        /// </summary>
        [NameInMap("LdapUdPullConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPullConfigurationRequestLdapUdPullConfig LdapUdPullConfig { get; set; }
        public class SetIdentityProviderUdPullConfigurationRequestLdapUdPullConfig : TeaModel {
            /// <summary>
            /// <para>Group member attribute name</para>
            /// 
            /// <b>Example:</b>
            /// <para>memberxxx</para>
            /// </summary>
            [NameInMap("GroupMemberAttributeName")]
            [Validation(Required=false)]
            public string GroupMemberAttributeName { get; set; }

            /// <summary>
            /// <para>GroupObjectClass</para>
            /// 
            /// <b>Example:</b>
            /// <para>groupxxx</para>
            /// </summary>
            [NameInMap("GroupObjectClass")]
            [Validation(Required=false)]
            public string GroupObjectClass { get; set; }

            /// <summary>
            /// <para>GroupObjectClass custom filter</para>
            /// 
            /// <b>Example:</b>
            /// <para>(|(cn=test)(group=<a href="mailto:test@test.com">test@test.com</a>))</para>
            /// </summary>
            [NameInMap("GroupObjectClassCustomFilter")]
            [Validation(Required=false)]
            public string GroupObjectClassCustomFilter { get; set; }

            /// <summary>
            /// <para>OrganizationUnitObjectClass</para>
            /// 
            /// <b>Example:</b>
            /// <para>organizationUnitxxx,top</para>
            /// </summary>
            [NameInMap("OrganizationUnitObjectClass")]
            [Validation(Required=false)]
            public string OrganizationUnitObjectClass { get; set; }

            /// <summary>
            /// <para>UserObjectClass</para>
            /// 
            /// <b>Example:</b>
            /// <para>userPrincipalNamexxx, mail</para>
            /// </summary>
            [NameInMap("UserObjectClass")]
            [Validation(Required=false)]
            public string UserObjectClass { get; set; }

            /// <summary>
            /// <para>UserObjectClass custom filter</para>
            /// 
            /// <b>Example:</b>
            /// <para>(|(cn=test)(mail=<a href="mailto:test@test.com">test@test.com</a>))</para>
            /// </summary>
            [NameInMap("UserObjectClassCustomFilter")]
            [Validation(Required=false)]
            public string UserObjectClassCustomFilter { get; set; }

        }

        /// <summary>
        /// <para>Periodic synchronize config</para>
        /// </summary>
        [NameInMap("PeriodicSyncConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPullConfigurationRequestPeriodicSyncConfig PeriodicSyncConfig { get; set; }
        public class SetIdentityProviderUdPullConfigurationRequestPeriodicSyncConfig : TeaModel {
            /// <summary>
            /// <para>Periodic synchronize cron</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 45 1 * * ?</para>
            /// </summary>
            [NameInMap("PeriodicSyncCron")]
            [Validation(Required=false)]
            public string PeriodicSyncCron { get; set; }

            /// <summary>
            /// <para>Periodic synchronize times</para>
            /// </summary>
            [NameInMap("PeriodicSyncTimes")]
            [Validation(Required=false)]
            public List<int?> PeriodicSyncTimes { get; set; }

            /// <summary>
            /// <para>Periodic synchronize type</para>
            /// 
            /// <b>Example:</b>
            /// <para>cron</para>
            /// </summary>
            [NameInMap("PeriodicSyncType")]
            [Validation(Required=false)]
            public string PeriodicSyncType { get; set; }

        }

        /// <summary>
        /// <para>Periodic synchronize status</para>
        /// 
        /// <b>Example:</b>
        /// <para>disabled</para>
        /// </summary>
        [NameInMap("PeriodicSyncStatus")]
        [Validation(Required=false)]
        public string PeriodicSyncStatus { get; set; }

        /// <summary>
        /// <para>Synchronize protected rule</para>
        /// </summary>
        [NameInMap("PullProtectedRule")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPullConfigurationRequestPullProtectedRule PullProtectedRule { get; set; }
        public class SetIdentityProviderUdPullConfigurationRequestPullProtectedRule : TeaModel {
            /// <summary>
            /// <para>Group deleted threshold</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("GroupDeletedThreshold")]
            [Validation(Required=false)]
            public int? GroupDeletedThreshold { get; set; }

            /// <summary>
            /// <para>OrganizationalUnit deleted threshold</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OrganizationalUnitDeletedThreshold")]
            [Validation(Required=false)]
            public int? OrganizationalUnitDeletedThreshold { get; set; }

            /// <summary>
            /// <para>User deleted threshold</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("UserDeletedThreshold")]
            [Validation(Required=false)]
            public int? UserDeletedThreshold { get; set; }

        }

        /// <summary>
        /// <para>Synchronize configuration information.</para>
        /// </summary>
        [NameInMap("UdSyncScopeConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPullConfigurationRequestUdSyncScopeConfig UdSyncScopeConfig { get; set; }
        public class SetIdentityProviderUdPullConfigurationRequestUdSyncScopeConfig : TeaModel {
            /// <summary>
            /// <para>Synchronize source scopes</para>
            /// </summary>
            [NameInMap("SourceScopes")]
            [Validation(Required=false)]
            public List<string> SourceScopes { get; set; }

            /// <summary>
            /// <para>Synchronize target scope</para>
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
