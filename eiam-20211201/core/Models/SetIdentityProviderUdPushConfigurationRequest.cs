// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetIdentityProviderUdPushConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>IDaaS的身份提供方主键id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp_11111</para>
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
        /// <para>IDaaS EIAM的实例id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eiam-111ccc1111</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LdapUdPushConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPushConfigurationRequestLdapUdPushConfig LdapUdPushConfig { get; set; }
        public class SetIdentityProviderUdPushConfigurationRequestLdapUdPushConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ou,top</para>
            /// </summary>
            [NameInMap("OrganizationUnitObjectClass")]
            [Validation(Required=false)]
            public string OrganizationUnitObjectClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ou</para>
            /// </summary>
            [NameInMap("OrganizationalUnitRdn")]
            [Validation(Required=false)]
            public string OrganizationalUnitRdn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordSyncStatus")]
            [Validation(Required=false)]
            public string PasswordSyncStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user,top</para>
            /// </summary>
            [NameInMap("UserObjectClass")]
            [Validation(Required=false)]
            public string UserObjectClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("UserRdn")]
            [Validation(Required=false)]
            public string UserRdn { get; set; }

        }

        [NameInMap("PeriodicSyncConfig")]
        [Validation(Required=false)]
        public SetIdentityProviderUdPushConfigurationRequestPeriodicSyncConfig PeriodicSyncConfig { get; set; }
        public class SetIdentityProviderUdPushConfigurationRequestPeriodicSyncConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0 45 1 * * ?</para>
            /// </summary>
            [NameInMap("PeriodicSyncCron")]
            [Validation(Required=false)]
            public string PeriodicSyncCron { get; set; }

            [NameInMap("PeriodicSyncTimes")]
            [Validation(Required=false)]
            public List<int?> PeriodicSyncTimes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cron</para>
            /// </summary>
            [NameInMap("PeriodicSyncType")]
            [Validation(Required=false)]
            public string PeriodicSyncType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>disabled</para>
        /// </summary>
        [NameInMap("PeriodicSyncStatus")]
        [Validation(Required=false)]
        public string PeriodicSyncStatus { get; set; }

        /// <summary>
        /// <para>同步出配置信息</para>
        /// </summary>
        [NameInMap("UdSyncScopeConfigs")]
        [Validation(Required=false)]
        public List<SetIdentityProviderUdPushConfigurationRequestUdSyncScopeConfigs> UdSyncScopeConfigs { get; set; }
        public class SetIdentityProviderUdPushConfigurationRequestUdSyncScopeConfigs : TeaModel {
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
            /// <para>6537211</para>
            /// </summary>
            [NameInMap("TargetScope")]
            [Validation(Required=false)]
            public string TargetScope { get; set; }

        }

    }

}
