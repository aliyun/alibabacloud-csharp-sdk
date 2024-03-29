// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class DeleteUserProvisioningRequest : TeaModel {
        /// <summary>
        /// The deletion policy. The policy is used to manage synchronized users when you delete the RAM user provisioning. Valid values:
        /// 
        /// *   Delete: When you delete the RAM user provisioning, the system deletes the synchronized users.
        /// *   Keep: When you delete the RAM user provisioning, the system retains the synchronized users.
        /// 
        /// >  If you do not specify this parameter, the deletion policy that is configured when you create the RAM user provisioning is used.
        /// </summary>
        [NameInMap("DeletionStrategy")]
        [Validation(Required=false)]
        public string DeletionStrategy { get; set; }

        /// <summary>
        /// The ID of the resource directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The ID of the RAM user provisioning.
        /// </summary>
        [NameInMap("UserProvisioningId")]
        [Validation(Required=false)]
        public string UserProvisioningId { get; set; }

    }

}
