// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateLoginProfileRequest : TeaModel {
        /// <summary>
        /// Specifies whether multi-factor authentication (MFA) must be enabled. Valid values:
        /// 
        /// *   true: MFA must be enabled. The RAM user must bind an MFA device at the next logon.
        /// *   false: MFA is not enabled. This is the default value.
        /// </summary>
        [NameInMap("MFABindRequired")]
        [Validation(Required=false)]
        public bool? MFABindRequired { get; set; }

        /// <summary>
        /// The password that is used to log on to the console.
        /// 
        /// The password must meet the complexity requirements.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies whether the RAM user must reset the password at the next logon. Default value: false. Valid values:
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
        /// *   Active: Password-based logon is enabled. This is the default value.
        /// *   Inactive: Password-based logon is disabled.
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
