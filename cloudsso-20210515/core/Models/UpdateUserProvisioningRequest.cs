// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateUserProvisioningRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-003qew84****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The new deletion policy. The policy is used to manage synchronized users when you delete the RAM user provisioning. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Delete: When you delete the RAM user provisioning, the system deletes the synchronized users.</description></item>
        /// <item><description>Keep: When you delete the RAM user provisioning, the system retains the synchronized users.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Delete</para>
        /// </summary>
        [NameInMap("NewDeletionStrategy")]
        [Validation(Required=false)]
        public string NewDeletionStrategy { get; set; }

        /// <summary>
        /// <para>The new description of the RAM user provisioning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description*****</para>
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// <para>The new conflict handling policy. The policy is used when a RAM user has the same username as the CloudSSO user who is synchronized to RAM. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>KeepBoth: When a CloudSSO user is synchronized to RAM, if a RAM user who has the same username as the CloudSSO user exists, the system creates a RAM user whose username is the username of the CloudSSO user plus the suffix <c>_sso</c>.</description></item>
        /// <item><description>TakeOver: When a CloudSSO user is synchronized to RAM, if a RAM user who has the same username as the CloudSSO user exists, the system replaces the RAM user with the CloudSSO user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KeepBoth</para>
        /// </summary>
        [NameInMap("NewDuplicationStrategy")]
        [Validation(Required=false)]
        public string NewDuplicationStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user provisioning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>up-002axzhapcbz6e63****</para>
        /// </summary>
        [NameInMap("UserProvisioningId")]
        [Validation(Required=false)]
        public string UserProvisioningId { get; set; }

    }

}
