// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetIdentityProviderUdPushConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the identity provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp_11111</para>
        /// </summary>
        [NameInMap("IdentityProviderId")]
        [Validation(Required=false)]
        public string IdentityProviderId { get; set; }

        /// <summary>
        /// <para>Specifies whether to process incremental callback data from the IdP.</para>
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
        /// <para>eiam-111ccc1111</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The configurations for LDAP push synchronization.</para>
        /// </summary>
        [NameInMap("LdapUdPushConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPushConfigurationRequestLdapUdPushConfig LdapUdPushConfig { get; set; }
        public class SetIdentityProviderUdPushConfigurationRequestLdapUdPushConfig : TeaModel {
            /// <summary>
            /// <para>The object class for organizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou,top</para>
            /// </summary>
            [NameInMap("OrganizationUnitObjectClass")]
            [Validation(Required=false)]
            public string OrganizationUnitObjectClass { get; set; }

            /// <summary>
            /// <para>The RDN for organizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou</para>
            /// </summary>
            [NameInMap("OrganizationalUnitRdn")]
            [Validation(Required=false)]
            public string OrganizationalUnitRdn { get; set; }

            /// <summary>
            /// <para>Specifies whether to synchronize passwords.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordSyncStatus")]
            [Validation(Required=false)]
            public string PasswordSyncStatus { get; set; }

            /// <summary>
            /// <para>The object class for users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user,top</para>
            /// </summary>
            [NameInMap("UserObjectClass")]
            [Validation(Required=false)]
            public string UserObjectClass { get; set; }

            /// <summary>
            /// <para>The Relative Distinguished Name (RDN) for users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("UserRdn")]
            [Validation(Required=false)]
            public string UserRdn { get; set; }

        }

        /// <summary>
        /// <para>The configuration for periodic synchronization.</para>
        /// </summary>
        [NameInMap("PeriodicSyncConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPushConfigurationRequestPeriodicSyncConfig PeriodicSyncConfig { get; set; }
        public class SetIdentityProviderUdPushConfigurationRequestPeriodicSyncConfig : TeaModel {
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
            /// <para>A collection of time points.</para>
            /// </summary>
            [NameInMap("PeriodicSyncTimes")]
            [Validation(Required=false)]
            public List<int?> PeriodicSyncTimes { get; set; }

            /// <summary>
            /// <para>The type of periodic synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cron</para>
            /// </summary>
            [NameInMap("PeriodicSyncType")]
            [Validation(Required=false)]
            public string PeriodicSyncType { get; set; }

        }

        /// <summary>
        /// <para>The status of periodic synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disabled</para>
        /// </summary>
        [NameInMap("PeriodicSyncStatus")]
        [Validation(Required=false)]
        public string PeriodicSyncStatus { get; set; }

        /// <summary>
        /// <para>The push synchronization configurations.</para>
        /// </summary>
        [NameInMap("UdSyncScopeConfigs")]
        [Validation(Required=false)]
        public List<SetIdentityProviderUdPushConfigurationRequestUdSyncScopeConfigs> UdSyncScopeConfigs { get; set; }
        public class SetIdentityProviderUdPushConfigurationRequestUdSyncScopeConfigs : TeaModel {
            /// <summary>
            /// <para>The source nodes for synchronization.</para>
            /// </summary>
            [NameInMap("SourceScopes")]
            [Validation(Required=false)]
            public List<string> SourceScopes { get; set; }

            /// <summary>
            /// <para>The target node for synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6537211</para>
            /// </summary>
            [NameInMap("TargetScope")]
            [Validation(Required=false)]
            public string TargetScope { get; set; }

        }

    }

}
