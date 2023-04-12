// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class SetMemberDeletionPermissionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the management account of the resource directory.
        /// </summary>
        [NameInMap("ManagementAccountId")]
        [Validation(Required=false)]
        public string ManagementAccountId { get; set; }

        /// <summary>
        /// The status of the member deletion feature. Valid values:
        /// 
        /// *   Enabled: The feature is enabled.
        /// *   Disabled: The feature is disabled.
        /// </summary>
        [NameInMap("MemberDeletionStatus")]
        [Validation(Required=false)]
        public string MemberDeletionStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource directory.
        /// </summary>
        [NameInMap("ResourceDirectoryId")]
        [Validation(Required=false)]
        public string ResourceDirectoryId { get; set; }

    }

}
