// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateUserProvisioningRequest : TeaModel {
        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-003qew84****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The new deletion policy. This policy specifies how to handle synchronized Resource Access Management (RAM) users when the Resource Access Management (RAM) user synchronization is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Delete: Delete the users. When the Resource Access Management (RAM) user synchronization is deleted, the system deletes the Resource Access Management (RAM) users that have been synchronized from CloudSSO to Resource Access Management (RAM).</description></item>
        /// <item><description>Keep: Keep the users. When the Resource Access Management (RAM) user synchronization is deleted, the system retains the Resource Access Management (RAM) users that have been synchronized from CloudSSO to Resource Access Management (RAM).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Delete</para>
        /// </summary>
        [NameInMap("NewDeletionStrategy")]
        [Validation(Required=false)]
        public string NewDeletionStrategy { get; set; }

        /// <summary>
        /// <para>The new description of the Resource Access Management (RAM) user synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description*****</para>
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// <para>The new duplication strategy. This strategy specifies how to handle name conflicts when a CloudSSO user is synchronized to Resource Access Management (RAM) user with the same name already exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>KeepBoth: Keep both users. When a CloudSSO user is synchronized to Resource Access Management (RAM) user with the same name already exists, the system appends the <c>_sso</c> suffix to the CloudSSO username and attempts to create a RAM user with the new username.</description></item>
        /// <item><description>TakeOver: Replace the existing user. When a CloudSSO user is synchronized to Resource Access Management (RAM) user with the same name already exists, the system directly replaces the existing RAM user with the synchronized CloudSSO user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KeepBoth</para>
        /// </summary>
        [NameInMap("NewDuplicationStrategy")]
        [Validation(Required=false)]
        public string NewDuplicationStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the Resource Access Management (RAM) user synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>up-002axzhapcbz6e63****</para>
        /// </summary>
        [NameInMap("UserProvisioningId")]
        [Validation(Required=false)]
        public string UserProvisioningId { get; set; }

    }

}
