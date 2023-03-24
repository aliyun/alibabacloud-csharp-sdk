// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateAccessKeyRequest : TeaModel {
        /// <summary>
        /// The status of the AccessKey pair. Valid values:
        /// 
        /// *   Active
        /// *   Inactive
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The AccessKey ID of the AccessKey pair for which you want to modify the status.
        /// </summary>
        [NameInMap("UserAccessKeyId")]
        [Validation(Required=false)]
        public string UserAccessKeyId { get; set; }

        /// <summary>
        /// The logon name of the RAM user.
        /// 
        /// If this parameter is empty, the status of the AccessKey pair for the current user is modified.
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
