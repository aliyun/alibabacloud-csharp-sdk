// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateUserStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The new status of the user. Valid values:
        /// 
        /// *   Enabled: The logon of the user is enabled.
        /// *   Disabled: The logon of the user is disabled.
        /// </summary>
        [NameInMap("NewStatus")]
        [Validation(Required=false)]
        public string NewStatus { get; set; }

        /// <summary>
        /// The ID of the user.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
