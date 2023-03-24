// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateLoginProfileRequest : TeaModel {
        /// <summary>
        /// Specifies whether multi-factor authentication (MFA) must be enabled. Valid values:
        /// 
        /// *   true. The value true indicates that the RAM user must bind an MFA device at the next logon.
        /// *   false.
        /// </summary>
        [NameInMap("MFABindRequired")]
        [Validation(Required=false)]
        public bool? MFABindRequired { get; set; }

        /// <summary>
        /// The new password that is used to log on to the console.
        /// 
        /// The password must meet the complexity requirements.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies whether the RAM user must reset the password at the next logon. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("PasswordResetRequired")]
        [Validation(Required=false)]
        public bool? PasswordResetRequired { get; set; }

        /// <summary>
        /// The status of password-based logon. Valid values:
        /// 
        /// *   Active
        /// *   Inactive
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The logon name of the RAM user.
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
