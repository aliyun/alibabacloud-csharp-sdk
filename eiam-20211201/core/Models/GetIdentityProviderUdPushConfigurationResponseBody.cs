// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetIdentityProviderUdPushConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Outbound synchronization configuration</para>
        /// </summary>
        [NameInMap("UdPushConfiguration")]
        [Validation(Required=false)]
        public GetIdentityProviderUdPushConfigurationResponseBodyUdPushConfiguration UdPushConfiguration { get; set; }
        public class GetIdentityProviderUdPushConfigurationResponseBodyUdPushConfiguration : TeaModel {
            /// <summary>
            /// <para>Identity provider ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_na2rzpyc67zr7ixdfy35zgrxxx</para>
            /// </summary>
            [NameInMap("IdentityProviderId")]
            [Validation(Required=false)]
            public string IdentityProviderId { get; set; }

            /// <summary>
            /// <para>Incremental callback status. Indicates whether incremental callback data from the IdP is processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("IncrementalCallbackStatus")]
            [Validation(Required=false)]
            public string IncrementalCallbackStatus { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_7vdv3olzk36gymwtlaq6fixxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>LDAP synchronization-side configuration</para>
            /// </summary>
            [NameInMap("LdapUdPushConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderUdPushConfigurationResponseBodyUdPushConfigurationLdapUdPushConfig LdapUdPushConfig { get; set; }
            public class GetIdentityProviderUdPushConfigurationResponseBodyUdPushConfigurationLdapUdPushConfig : TeaModel {
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
                /// <para>Organization RDN</para>
                /// 
                /// <b>Example:</b>
                /// <para>ou</para>
                /// </summary>
                [NameInMap("OrganizationalUnitRdn")]
                [Validation(Required=false)]
                public string OrganizationalUnitRdn { get; set; }

                /// <summary>
                /// <para>Password synchronization status</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("PasswordSyncStatus")]
                [Validation(Required=false)]
                public string PasswordSyncStatus { get; set; }

                /// <summary>
                /// <para>User ObjectClass</para>
                /// 
                /// <b>Example:</b>
                /// <para>user,top</para>
                /// </summary>
                [NameInMap("UserObjectClass")]
                [Validation(Required=false)]
                public string UserObjectClass { get; set; }

                /// <summary>
                /// <para>User RDN</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn</para>
                /// </summary>
                [NameInMap("UserRdn")]
                [Validation(Required=false)]
                public string UserRdn { get; set; }

            }

            /// <summary>
            /// <para>Periodic verification configuration</para>
            /// </summary>
            [NameInMap("PeriodicSyncConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderUdPushConfigurationResponseBodyUdPushConfigurationPeriodicSyncConfig PeriodicSyncConfig { get; set; }
            public class GetIdentityProviderUdPushConfigurationResponseBodyUdPushConfigurationPeriodicSyncConfig : TeaModel {
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
                /// <para>Collection of time points</para>
                /// </summary>
                [NameInMap("PeriodicSyncTimes")]
                [Validation(Required=false)]
                public List<string> PeriodicSyncTimes { get; set; }

                /// <summary>
                /// <para>Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>cron</para>
                /// </summary>
                [NameInMap("PeriodicSyncType")]
                [Validation(Required=false)]
                public string PeriodicSyncType { get; set; }

            }

            /// <summary>
            /// <para>Periodic verification status</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("PeriodicSyncStatus")]
            [Validation(Required=false)]
            public string PeriodicSyncStatus { get; set; }

            /// <summary>
            /// <para>Outbound synchronization configuration details</para>
            /// </summary>
            [NameInMap("UdSyncScopeConfigs")]
            [Validation(Required=false)]
            public List<GetIdentityProviderUdPushConfigurationResponseBodyUdPushConfigurationUdSyncScopeConfigs> UdSyncScopeConfigs { get; set; }
            public class GetIdentityProviderUdPushConfigurationResponseBodyUdPushConfigurationUdSyncScopeConfigs : TeaModel {
                /// <summary>
                /// <para>Source nodes for synchronization</para>
                /// </summary>
                [NameInMap("SourceScopes")]
                [Validation(Required=false)]
                public List<string> SourceScopes { get; set; }

                /// <summary>
                /// <para>Target node for synchronization</para>
                /// 
                /// <b>Example:</b>
                /// <para>604352338</para>
                /// </summary>
                [NameInMap("TargetScope")]
                [Validation(Required=false)]
                public string TargetScope { get; set; }

            }

        }

    }

}
