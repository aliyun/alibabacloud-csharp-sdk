// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetIdentityProviderUdPullConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The group synchronization status. Valid values:</para>
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
        [NameInMap("GroupSyncStatus")]
        [Validation(Required=false)]
        public string GroupSyncStatus { get; set; }

        /// <summary>
        /// <para>The identity provider ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp_my664lwkhpicbyzirog3xxxxx</para>
        /// </summary>
        [NameInMap("IdentityProviderId")]
        [Validation(Required=false)]
        public string IdentityProviderId { get; set; }

        /// <summary>
        /// <para>The status of incremental callback. This parameter specifies whether to process incremental callback data from the IdP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>disabled: The feature is disabled.</para>
        /// </description></item>
        /// <item><description><para>enabled: The feature is enabled.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The configurations of LDAP synchronization.</para>
        /// </summary>
        [NameInMap("LdapUdPullConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPullConfigurationRequestLdapUdPullConfig LdapUdPullConfig { get; set; }
        public class SetIdentityProviderUdPullConfigurationRequestLdapUdPullConfig : TeaModel {
            /// <summary>
            /// <para>The group member identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>member</para>
            /// </summary>
            [NameInMap("GroupMemberAttributeName")]
            [Validation(Required=false)]
            public string GroupMemberAttributeName { get; set; }

            /// <summary>
            /// <para>The group objectClass.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group</para>
            /// </summary>
            [NameInMap("GroupObjectClass")]
            [Validation(Required=false)]
            public string GroupObjectClass { get; set; }

            /// <summary>
            /// <para>The custom group filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(|(cn=test)(group=<a href="mailto:test@test.com">test@test.com</a>))</para>
            /// </summary>
            [NameInMap("GroupObjectClassCustomFilter")]
            [Validation(Required=false)]
            public string GroupObjectClassCustomFilter { get; set; }

            /// <summary>
            /// <para>The organizational unit objectClass.</para>
            /// 
            /// <b>Example:</b>
            /// <para>organizationUnit,top</para>
            /// </summary>
            [NameInMap("OrganizationUnitObjectClass")]
            [Validation(Required=false)]
            public string OrganizationUnitObjectClass { get; set; }

            /// <summary>
            /// <para>The user objectClass.</para>
            /// 
            /// <b>Example:</b>
            /// <para>userPrincipalName, mail</para>
            /// </summary>
            [NameInMap("UserObjectClass")]
            [Validation(Required=false)]
            public string UserObjectClass { get; set; }

            /// <summary>
            /// <para>The custom user filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(|(cn=test)(mail=<a href="mailto:test@test.com">test@test.com</a>))</para>
            /// </summary>
            [NameInMap("UserObjectClassCustomFilter")]
            [Validation(Required=false)]
            public string UserObjectClassCustomFilter { get; set; }

        }

        /// <summary>
        /// <para>The scheduled synchronization configuration.</para>
        /// </summary>
        [NameInMap("PeriodicSyncConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPullConfigurationRequestPeriodicSyncConfig PeriodicSyncConfig { get; set; }
        public class SetIdentityProviderUdPullConfigurationRequestPeriodicSyncConfig : TeaModel {
            /// <summary>
            /// <para>The cron expression. This parameter is required when periodicSyncType is set to cron.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 45 1 * * ?</para>
            /// </summary>
            [NameInMap("PeriodicSyncCron")]
            [Validation(Required=false)]
            public string PeriodicSyncCron { get; set; }

            /// <summary>
            /// <para>The time points for synchronization. This parameter is required when periodicSyncType is set to time. For example, if you set this parameter to [3, 5], the synchronization is performed from 03:00 to 04:00 and from 05:00 to 06:00.</para>
            /// </summary>
            [NameInMap("PeriodicSyncTimes")]
            [Validation(Required=false)]
            public List<int?> PeriodicSyncTimes { get; set; }

            /// <summary>
            /// <para>The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cron</para>
            /// </summary>
            [NameInMap("PeriodicSyncType")]
            [Validation(Required=false)]
            public string PeriodicSyncType { get; set; }

        }

        /// <summary>
        /// <para>The status of scheduled check. This parameter specifies whether to periodically check for data inconsistencies between IDaaS and the IdP. Valid values:</para>
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
        [NameInMap("PeriodicSyncStatus")]
        [Validation(Required=false)]
        public string PeriodicSyncStatus { get; set; }

        /// <summary>
        /// <para>The inbound synchronization protection rule.</para>
        /// </summary>
        [NameInMap("PullProtectedRule")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPullConfigurationRequestPullProtectedRule PullProtectedRule { get; set; }
        public class SetIdentityProviderUdPullConfigurationRequestPullProtectedRule : TeaModel {
            /// <summary>
            /// <para>The threshold for the number of groups to be deleted. If the number of groups to be deleted exceeds this value, the synchronization task is stopped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("GroupDeletedThreshold")]
            [Validation(Required=false)]
            public int? GroupDeletedThreshold { get; set; }

            /// <summary>
            /// <para>The threshold for the number of organizational units to be deleted. If the number of organizational units to be deleted exceeds this value, the synchronization task is stopped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OrganizationalUnitDeletedThreshold")]
            [Validation(Required=false)]
            public int? OrganizationalUnitDeletedThreshold { get; set; }

            /// <summary>
            /// <para>The threshold for the number of users to be deleted. If the number of users to be deleted exceeds this value, the synchronization task is stopped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("UserDeletedThreshold")]
            [Validation(Required=false)]
            public int? UserDeletedThreshold { get; set; }

        }

        /// <summary>
        /// <para>The inbound synchronization configuration.</para>
        /// </summary>
        [NameInMap("UdSyncScopeConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPullConfigurationRequestUdSyncScopeConfig UdSyncScopeConfig { get; set; }
        public class SetIdentityProviderUdPullConfigurationRequestUdSyncScopeConfig : TeaModel {
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
            /// <para>ou_asdaq1addsxzdq1XXX</para>
            /// </summary>
            [NameInMap("TargetScope")]
            [Validation(Required=false)]
            public string TargetScope { get; set; }

        }

    }

}
