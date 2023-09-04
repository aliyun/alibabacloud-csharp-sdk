// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetMFAAuthenticationSettingsResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether MFA is enabled for all users. Valid values:
        /// 
        /// *   Enabled: MFA is enabled for all users.
        /// *   Byuser: User-specific settings are applied.
        /// *   Disabled: MFA is disabled for all users.
        /// </summary>
        [NameInMap("MFAAuthenticationAdvanceSettings")]
        [Validation(Required=false)]
        public string MFAAuthenticationAdvanceSettings { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
