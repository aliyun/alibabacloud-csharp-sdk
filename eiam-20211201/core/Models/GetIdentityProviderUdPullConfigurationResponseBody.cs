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
        /// <para>The inbound synchronization configuration.</para>
        /// </summary>
        [NameInMap("UdPullConfiguration")]
        [Validation(Required=false)]
        public GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfiguration UdPullConfiguration { get; set; }
        public class GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfiguration : TeaModel {
            /// <summary>
            /// <para>The group synchronization status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disabled</description></item>
            /// <item><description>enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("GroupSyncStatus")]
            [Validation(Required=false)]
            public string GroupSyncStatus { get; set; }

            /// <summary>
            /// <para>The identity provider ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_my664lwkhpicbyzirog3xxxxx</para>
            /// </summary>
            [NameInMap("IdentityProviderId")]
            [Validation(Required=false)]
            public string IdentityProviderId { get; set; }

            /// <summary>
            /// <para>The incremental callback status, which specifies whether to process incremental callback data from the IdP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disabled</description></item>
            /// <item><description>enabled.</description></item>
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
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The LDAP synchronization configuration.</para>
            /// </summary>
            [NameInMap("LdapUdPullConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationLdapUdPullConfig LdapUdPullConfig { get; set; }
            public class GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationLdapUdPullConfig : TeaModel {
                /// <summary>
                /// <para>The group member identifier attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group</para>
                /// </summary>
                [NameInMap("GroupMemberAttributeName")]
                [Validation(Required=false)]
                public string GroupMemberAttributeName { get; set; }

                /// <summary>
                /// <para>The group ObjectClass.</para>
                /// 
                /// <b>Example:</b>
                /// <para>member</para>
                /// </summary>
                [NameInMap("GroupObjectClass")]
                [Validation(Required=false)]
                public string GroupObjectClass { get; set; }

                /// <summary>
                /// <para>The custom filter for groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(|(cn=test)(group=<a href="mailto:test@test.com">test@test.com</a>))</para>
                /// </summary>
                [NameInMap("GroupObjectClassCustomFilter")]
                [Validation(Required=false)]
                public string GroupObjectClassCustomFilter { get; set; }

                /// <summary>
                /// <para>The organizational unit ObjectClass.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou,top</para>
                /// </summary>
                [NameInMap("OrganizationUnitObjectClass")]
                [Validation(Required=false)]
                public string OrganizationUnitObjectClass { get; set; }

                /// <summary>
                /// <para>The user ObjectClass.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou,top</para>
                /// </summary>
                [NameInMap("UserObjectClass")]
                [Validation(Required=false)]
                public string UserObjectClass { get; set; }

                /// <summary>
                /// <para>The custom filter for users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(|(cn=test)(mail=<a href="mailto:test@test.com">test@test.com</a>))</para>
                /// </summary>
                [NameInMap("UserObjectClassCustomFilter")]
                [Validation(Required=false)]
                public string UserObjectClassCustomFilter { get; set; }

            }

            /// <summary>
            /// <para>The periodic synchronization configuration.</para>
            /// </summary>
            [NameInMap("PeriodicSyncConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationPeriodicSyncConfig PeriodicSyncConfig { get; set; }
            public class GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationPeriodicSyncConfig : TeaModel {
                /// <summary>
                /// <para>The cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 45 1 * * ?</para>
                /// </summary>
                [NameInMap("PeriodicSyncCron")]
                [Validation(Required=false)]
                public string PeriodicSyncCron { get; set; }

                /// <summary>
                /// <para>The execution time points. For example, [3, 5] indicates that synchronization runs once between 3:00 and 4:00 and once between 5:00 and 6:00.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[3,5]</para>
                /// </summary>
                [NameInMap("PeriodicSyncTimes")]
                [Validation(Required=false)]
                public int? PeriodicSyncTimes { get; set; }

                /// <summary>
                /// <para>The periodic synchronization type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("PeriodicSyncType")]
                [Validation(Required=false)]
                public string PeriodicSyncType { get; set; }

            }

            /// <summary>
            /// <para>The periodic verification status, which specifies whether to periodically verify data differences between IDaaS and the identity provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disabled</description></item>
            /// <item><description>enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>The inbound synchronization protection rule configuration.</para>
            /// </summary>
            [NameInMap("PullProtectedRule")]
            [Validation(Required=false)]
            public GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationPullProtectedRule PullProtectedRule { get; set; }
            public class GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationPullProtectedRule : TeaModel {
                /// <summary>
                /// <para>The threshold for the number of deleted groups. If the number of deleted groups exceeds this value, the synchronization task is terminated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("GroupDeletedThreshold")]
                [Validation(Required=false)]
                public int? GroupDeletedThreshold { get; set; }

                /// <summary>
                /// <para>The threshold for the number of deleted organizational units. If the number of deleted organizational units exceeds this value, the synchronization task is terminated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("OrganizationalUnitDeletedThreshold")]
                [Validation(Required=false)]
                public int? OrganizationalUnitDeletedThreshold { get; set; }

                /// <summary>
                /// <para>The threshold for the number of deleted accounts. If the number of deleted users exceeds this value, the synchronization task is terminated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("UserDeletedThreshold")]
                [Validation(Required=false)]
                public int? UserDeletedThreshold { get; set; }

            }

            /// <summary>
            /// <para>The synchronization scope configuration.</para>
            /// </summary>
            [NameInMap("UdSyncScopeConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationUdSyncScopeConfig UdSyncScopeConfig { get; set; }
            public class GetIdentityProviderUdPullConfigurationResponseBodyUdPullConfigurationUdSyncScopeConfig : TeaModel {
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
                /// <para>ou_asjdfhaskfhw213mnsj33sXXX</para>
                /// </summary>
                [NameInMap("TargetScope")]
                [Validation(Required=false)]
                public string TargetScope { get; set; }

            }

        }

    }

}
