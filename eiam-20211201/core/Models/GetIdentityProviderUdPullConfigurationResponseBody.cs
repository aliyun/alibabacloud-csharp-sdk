// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetIdentityProviderUdPullConfigurationResponseBody : TeaModel {
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
        /// <para>Inbound Synchronization Configuration Information</para>
        /// </summary>
        [NameInMap("UdPullConfiguration")]
        [Validation(Required=false)]
        public GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfiguration UdPullConfiguration { get; set; }
        public class GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfiguration : TeaModel {
            /// <summary>
            /// <para>Group Synchronization Status
            /// Possible values:</para>
            /// <para>Disabled: disabled</para>
            /// <para>Enabled: enabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("GroupSyncStatus")]
            [Validation(Required=false)]
            public string GroupSyncStatus { get; set; }

            /// <summary>
            /// <para>Identity provider ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_my664lwkhpicbyzirog3xxxxx</para>
            /// </summary>
            [NameInMap("IdentityProviderId")]
            [Validation(Required=false)]
            public string IdentityProviderId { get; set; }

            /// <summary>
            /// <para>Incremental Callback Status: Whether to process incremental callback data from the IdP</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("IncrementalCallbackStatus")]
            [Validation(Required=false)]
            public string IncrementalCallbackStatus { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>LDAP Synchronization Side Related Configuration Information</para>
            /// </summary>
            [NameInMap("LdapUdPullConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationLdapUdPullConfig LdapUdPullConfig { get; set; }
            public class GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationLdapUdPullConfig : TeaModel {
                /// <summary>
                /// <para>Group Member Identifier</para>
                /// 
                /// <b>Example:</b>
                /// <para>group</para>
                /// </summary>
                [NameInMap("GroupMemberAttributeName")]
                [Validation(Required=false)]
                public string GroupMemberAttributeName { get; set; }

                /// <summary>
                /// <para>Group ObjectClass</para>
                /// 
                /// <b>Example:</b>
                /// <para>member</para>
                /// </summary>
                [NameInMap("GroupObjectClass")]
                [Validation(Required=false)]
                public string GroupObjectClass { get; set; }

                /// <summary>
                /// <para>Group Custom Filter</para>
                /// 
                /// <b>Example:</b>
                /// <para>(|(cn=test)(group=<a href="mailto:test@test.com">test@test.com</a>))</para>
                /// </summary>
                [NameInMap("GroupObjectClassCustomFilter")]
                [Validation(Required=false)]
                public string GroupObjectClassCustomFilter { get; set; }

                /// <summary>
                /// <para>Organization ObjectClass</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou,top</para>
                /// </summary>
                [NameInMap("OrganizationUnitObjectClass")]
                [Validation(Required=false)]
                public string OrganizationUnitObjectClass { get; set; }

                /// <summary>
                /// <para>User ObjectClass</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou,top</para>
                /// </summary>
                [NameInMap("UserObjectClass")]
                [Validation(Required=false)]
                public string UserObjectClass { get; set; }

                /// <summary>
                /// <para>User ObjectClass Custom Filter</para>
                /// 
                /// <b>Example:</b>
                /// <para>(|(cn=test)(mail=<a href="mailto:test@test.com">test@test.com</a>))</para>
                /// </summary>
                [NameInMap("UserObjectClassCustomFilter")]
                [Validation(Required=false)]
                public string UserObjectClassCustomFilter { get; set; }

            }

            /// <summary>
            /// <para>Scheduled sync configuration</para>
            /// </summary>
            [NameInMap("PeriodicSyncConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationPeriodicSyncConfig PeriodicSyncConfig { get; set; }
            public class GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationPeriodicSyncConfig : TeaModel {
                /// <summary>
                /// <para>Cron expression</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 45 1 * * ?</para>
                /// </summary>
                [NameInMap("PeriodicSyncCron")]
                [Validation(Required=false)]
                public string PeriodicSyncCron { get; set; }

                /// <summary>
                /// <para>Execution time slots, for example 3,5, meaning the task runs once between 03:00–04:00 and once between 05:00–06:00.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[3,5]</para>
                /// </summary>
                [NameInMap("PeriodicSyncTimes")]
                [Validation(Required=false)]
                public int? PeriodicSyncTimes { get; set; }

                /// <summary>
                /// <para>type</para>
                /// 
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("PeriodicSyncType")]
                [Validation(Required=false)]
                public string PeriodicSyncType { get; set; }

            }

            /// <summary>
            /// <para>Scheduled Validation Status: Whether to periodically validate data discrepancies between IDaaS and the Identity Provider. Possible values:</para>
            /// <para>Disabled: disabled</para>
            /// <para>Enabled: enabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>Inbound Synchronization Protection Rule Configuration</para>
            /// </summary>
            [NameInMap("PullProtectedRule")]
            [Validation(Required=false)]
            public GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationPullProtectedRule PullProtectedRule { get; set; }
            public class GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationPullProtectedRule : TeaModel {
                /// <summary>
                /// <para>Group Deletion Threshold: If the number of deleted groups exceeds this value, the synchronization task will be terminated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("GroupDeletedThreshold")]
                [Validation(Required=false)]
                public int? GroupDeletedThreshold { get; set; }

                /// <summary>
                /// <para>Organization Deletion Threshold: If the number of deleted organizations exceeds this value, the synchronization task will be terminated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("OrganizationalUnitDeletedThreshold")]
                [Validation(Required=false)]
                public int? OrganizationalUnitDeletedThreshold { get; set; }

                /// <summary>
                /// <para>Account Deletion Threshold: If the number of deleted users exceeds this value, the synchronization task will be terminated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("UserDeletedThreshold")]
                [Validation(Required=false)]
                public int? UserDeletedThreshold { get; set; }

            }

            /// <summary>
            /// <para>Synchronization Scope Configuration Information</para>
            /// </summary>
            [NameInMap("UdSyncScopeConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationUdSyncScopeConfig UdSyncScopeConfig { get; set; }
            public class GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationUdSyncScopeConfig : TeaModel {
                /// <summary>
                /// <para>Synchronization Source Node</para>
                /// </summary>
                [NameInMap("SourceScopes")]
                [Validation(Required=false)]
                public List<string> SourceScopes { get; set; }

                /// <summary>
                /// <para>Synchronization Target Node</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou_asjdfhaskfhw213mnsj33sXXX</para>
                /// </summary>
                [NameInMap("TargetScope")]
                [Validation(Required=false)]
                public string TargetScope { get; set; }

            }

        }

    }

}
