// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateUserMFAAuthenticationSettingsRequest : TeaModel {
        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The ID of the user.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Specifies whether to enable MFA for the user. Valid values:
        /// 
        /// *   Enabled: enables MFA for the user.
        /// *   Disabled: disables MFA for the user.
        /// </summary>
        [NameInMap("UserMFAAuthenticationSettings")]
        [Validation(Required=false)]
        public string UserMFAAuthenticationSettings { get; set; }

    }

}
