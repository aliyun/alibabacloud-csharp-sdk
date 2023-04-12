// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class SetMemberDeletionPermissionRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the member deletion feature. Valid values:
        /// 
        /// *   Enabled: enables the member deletion feature.
        /// *   Disabled: disables the member deletion feature.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
