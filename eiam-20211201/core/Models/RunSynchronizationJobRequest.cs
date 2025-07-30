// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class RunSynchronizationJobRequest : TeaModel {
        /// <summary>
        /// <para>Synchronization task description</para>
        /// 
        /// <b>Example:</b>
        /// <para>描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>Whether initialize password</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PasswordInitialization")]
        [Validation(Required=false)]
        public bool? PasswordInitialization { get; set; }

        /// <summary>
        /// <para>Synchronization scope</para>
        /// </summary>
        [NameInMap("SynchronizationScopeConfig")]
        [Validation(Required=false)]
        public RunSynchronizationJobRequestSynchronizationScopeConfig SynchronizationScopeConfig { get; set; }
        public class RunSynchronizationJobRequestSynchronizationScopeConfig : TeaModel {
            /// <summary>
            /// <para>The group IDs.</para>
            /// </summary>
            [NameInMap("GroupIds")]
            [Validation(Required=false)]
            public List<string> GroupIds { get; set; }

            /// <summary>
            /// <para>The IDs of organizational units.</para>
            /// </summary>
            [NameInMap("OrganizationalUnitIds")]
            [Validation(Required=false)]
            public List<string> OrganizationalUnitIds { get; set; }

            /// <summary>
            /// <para>UserIds</para>
            /// </summary>
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        /// <summary>
        /// <para>The ID of the synchronization destination.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp_my664lwkhpicbyzirog3ngxxxxx</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the synchronization destination. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>identity_provider</description></item>
        /// <item><description>application</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>identity_provider</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>User identity types</para>
        /// </summary>
        [NameInMap("UserIdentityTypes")]
        [Validation(Required=false)]
        public List<string> UserIdentityTypes { get; set; }

    }

}
