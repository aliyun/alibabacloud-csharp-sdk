// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetPasswordPolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The number of password retries.
        /// 
        /// If you enter wrong passwords for the specified consecutive times, the account is locked for 1 hour.
        /// 
        /// Valid values: 0 to 32. The value 0 specifies that the number of password retries is not limited.
        /// </summary>
        [NameInMap("MaxLoginAttempts")]
        [Validation(Required=false)]
        public int? MaxLoginAttempts { get; set; }

        /// <summary>
        /// The validity period of a password.
        /// 
        /// Valid values: 1 to 120. Unit: days.
        /// </summary>
        [NameInMap("MaxPasswordAge")]
        [Validation(Required=false)]
        public int? MaxPasswordAge { get; set; }

        /// <summary>
        /// The minimum number of unique characters in a password.
        /// 
        /// The minimum value is 0, which specifies that the minimum number of unique characters in a password is not limited. The maximum value is the value of the `MinPasswordLength` parameter.
        /// </summary>
        [NameInMap("MinPasswordDifferentChars")]
        [Validation(Required=false)]
        public int? MinPasswordDifferentChars { get; set; }

        /// <summary>
        /// The minimum password length.
        /// 
        /// Valid values: 8 to 32 characters.
        /// </summary>
        [NameInMap("MinPasswordLength")]
        [Validation(Required=false)]
        public int? MinPasswordLength { get; set; }

        /// <summary>
        /// Specifies whether a password can contain the username. Valid value:
        /// 
        /// *   true: A password cannot contain the username.
        /// *   false: A password can contain the username.
        /// </summary>
        [NameInMap("PasswordNotContainUsername")]
        [Validation(Required=false)]
        public bool? PasswordNotContainUsername { get; set; }

        /// <summary>
        /// The policy for password history check.
        /// 
        /// The previous N passwords cannot be reused. Valid values of N: 0 to 24. The value 0 specifies that all historical passwords can be reused.
        /// 
        /// >  Passwords that are generated before January 5, 2024 are not counted as historical passwords.
        /// </summary>
        [NameInMap("PasswordReusePrevention")]
        [Validation(Required=false)]
        public int? PasswordReusePrevention { get; set; }

    }

}
