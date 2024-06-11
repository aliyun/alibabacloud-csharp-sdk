// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class UpdateLoginProfileRequest : TeaModel {
        /// <summary>
        /// Specifies whether an MFA device must be attached to the RAM user upon logon.
        /// </summary>
        [NameInMap("MFABindRequired")]
        [Validation(Required=false)]
        public bool? MFABindRequired { get; set; }

        /// <summary>
        /// The logon password of the RAM user. The password must meet the password strength requirements.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies whether the RAM user must change the password upon logon.
        /// </summary>
        [NameInMap("PasswordResetRequired")]
        [Validation(Required=false)]
        public bool? PasswordResetRequired { get; set; }

        /// <summary>
        /// The name of the RAM user.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
