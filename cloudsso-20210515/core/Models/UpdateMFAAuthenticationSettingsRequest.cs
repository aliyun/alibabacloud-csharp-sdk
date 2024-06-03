// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateMFAAuthenticationSettingsRequest : TeaModel {
        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Specifies whether to enable MFA for all users. Valid value:
        /// 
        /// - Enabled: enables MFA for all users.
        /// - Byuser: uses user-specific settings. For more information about how to configure MFA for a single user, see [UpdateUserMFAAuthenticationSettings](https://help.aliyun.com/document_detail/450135.html).
        /// - Disabled: disables MFA for all users.
        /// - OnlyRiskyLogin: MFA is required only for unusual logons.
        /// </summary>
        [NameInMap("MFAAuthenticationSettings")]
        [Validation(Required=false)]
        public string MFAAuthenticationSettings { get; set; }

        /// <summary>
        /// Specifies whether MFA is required for users who initiated unusual logons. Valid value:
        /// 
        /// - Autonomous: MFA is prompted for users who initiated unusual logons. However, the users are allowed to skip MFA. If an MFA device is bound to a user who initiated an unusual logon, the user must pass MFA.
        /// 
        /// - EnforceVerify: MFA is required. If no MFA devices are bound to a user who initiated an unusual logon, the user must bind an MFA device. If an MFA device is already bound to a user who initiated an unusual logon, the user must pass MFA.
        /// </summary>
        [NameInMap("OperationForRiskLogin")]
        [Validation(Required=false)]
        public string OperationForRiskLogin { get; set; }

    }

}
