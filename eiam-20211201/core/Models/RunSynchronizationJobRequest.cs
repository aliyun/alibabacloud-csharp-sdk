// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class RunSynchronizationJobRequest : TeaModel {
        /// <summary>
        /// <para>The description of the synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description_text</para>
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
        /// <para>Specifies whether to initialize the password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PasswordInitialization")]
        [Validation(Required=false)]
        public bool? PasswordInitialization { get; set; }

        /// <summary>
        /// <para>The configuration of the synchronization scope.</para>
        /// </summary>
        [NameInMap("SynchronizationScopeConfig")]
        [Validation(Required=false)]
        public RunSynchronizationJobRequestSynchronizationScopeConfig SynchronizationScopeConfig { get; set; }
        public class RunSynchronizationJobRequestSynchronizationScopeConfig : TeaModel {
            /// <summary>
            /// <para>The list of group IDs.</para>
            /// </summary>
            [NameInMap("GroupIds")]
            [Validation(Required=false)]
            public List<string> GroupIds { get; set; }

            /// <summary>
            /// <para>The list of organizational unit IDs.</para>
            /// </summary>
            [NameInMap("OrganizationalUnitIds")]
            [Validation(Required=false)]
            public List<string> OrganizationalUnitIds { get; set; }

            /// <summary>
            /// <para>The list of user IDs.</para>
            /// </summary>
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        /// <summary>
        /// <para>The ID of the synchronization target.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp_my664lwkhpicbyzirog3ngxxxxx</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the synchronization target. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>identity_provider: The identity provider.</para>
        /// </description></item>
        /// <item><description><para>application: The application.</para>
        /// </description></item>
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
        /// <para>The list of unique user identifiers.</para>
        /// </summary>
        [NameInMap("UserIdentityTypes")]
        [Validation(Required=false)]
        public List<string> UserIdentityTypes { get; set; }

    }

}
