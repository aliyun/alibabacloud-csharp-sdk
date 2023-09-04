// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetMFAAuthenticationSettingInfoResponseBody : TeaModel {
        /// <summary>
        /// The MFA setting of all users.
        /// </summary>
        [NameInMap("MFAAuthenticationSettingInfo")]
        [Validation(Required=false)]
        public GetMFAAuthenticationSettingInfoResponseBodyMFAAuthenticationSettingInfo MFAAuthenticationSettingInfo { get; set; }
        public class GetMFAAuthenticationSettingInfoResponseBodyMFAAuthenticationSettingInfo : TeaModel {
            /// <summary>
            /// The MFA policy of all users. Valid values:
            /// 
            /// *   Enabled: MFA is enabled for all users.
            /// *   Byuser: User-specific settings are applied. For more information about how to configure MFA for a single user, see [UpdateUserMFAAuthenticationSettings](~~450135~~).
            /// *   Disabled: MFA is disabled for all users.
            /// *   OnlyRiskyLogin: MFA is required only for unusual logons.
            /// </summary>
            [NameInMap("MfaAuthenticationAdvanceSettings")]
            [Validation(Required=false)]
            public string MfaAuthenticationAdvanceSettings { get; set; }

            /// <summary>
            /// The MFA policy for unusual logons. Valid values:
            /// 
            /// *   Autonomous: MFA is prompted for users who initiated unusual logons. However, the users are allowed to skip MFA. If an MFA device is bound to a user who initiated an unusual logon, the user must pass MFA.
            /// *   EnforceVerify: MFA is required. If no MFA devices are bound to a user who initiated an unusual logon, the user must bind an MFA device. If an MFA device is already bound to a user who initiated an unusual logon, the user must pass MFA.
            /// 
            /// > This parameter is displayed only when Byuser or OnlyRiskyLogin is returned for the MfaAuthenticationAdvanceSettings parameter.
            /// </summary>
            [NameInMap("OperationForRiskLogin")]
            [Validation(Required=false)]
            public string OperationForRiskLogin { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
