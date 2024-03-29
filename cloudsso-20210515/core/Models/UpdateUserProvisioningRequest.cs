// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateUserProvisioningRequest : TeaModel {
        /// <summary>
        /// The ID of the resource directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The new deletion policy. The policy is used to manage synchronized users when you delete the RAM user provisioning. Valid values:
        /// 
        /// *   Delete: When you delete the RAM user provisioning, the system deletes the synchronized users.
        /// *   Keep: When you delete the RAM user provisioning, the system retains the synchronized users.
        /// </summary>
        [NameInMap("NewDeletionStrategy")]
        [Validation(Required=false)]
        public string NewDeletionStrategy { get; set; }

        /// <summary>
        /// The new description of the RAM user provisioning.
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// The new conflict handling policy. The policy is used when a RAM user has the same username as the CloudSSO user who is synchronized to RAM. Valid values:
        /// 
        /// *   KeepBoth: When a CloudSSO user is synchronized to RAM, if a RAM user who has the same username as the CloudSSO user exists, the system creates a RAM user whose username is the username of the CloudSSO user plus the suffix `_sso`.
        /// *   TakeOver: When a CloudSSO user is synchronized to RAM, if a RAM user who has the same username as the CloudSSO user exists, the system replaces the RAM user with the CloudSSO user.
        /// </summary>
        [NameInMap("NewDuplicationStrategy")]
        [Validation(Required=false)]
        public string NewDuplicationStrategy { get; set; }

        /// <summary>
        /// The ID of the RAM user provisioning.
        /// </summary>
        [NameInMap("UserProvisioningId")]
        [Validation(Required=false)]
        public string UserProvisioningId { get; set; }

    }

}
