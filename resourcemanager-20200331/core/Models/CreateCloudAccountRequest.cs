// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateCloudAccountRequest : TeaModel {
        /// <summary>
        /// The display name of the member account.
        /// 
        /// The name must be 2 to 50 characters in length and can contain letters, digits, underscores (\_), periods (.), and hyphens (-).
        /// 
        /// The name must be unique in the current resource directory.
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The email address used to log on to the cloud account.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The ID of the parent folder.
        /// </summary>
        [NameInMap("ParentFolderId")]
        [Validation(Required=false)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// The ID of the settlement account. If you do not specify this parameter, the current account is used for settlement.
        /// </summary>
        [NameInMap("PayerAccountId")]
        [Validation(Required=false)]
        public string PayerAccountId { get; set; }

    }

}
