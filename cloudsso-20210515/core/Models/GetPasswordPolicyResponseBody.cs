// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetPasswordPolicyResponseBody : TeaModel {
        /// <summary>
        /// The password policy.
        /// </summary>
        [NameInMap("PasswordPolicy")]
        [Validation(Required=false)]
        public GetPasswordPolicyResponseBodyPasswordPolicy PasswordPolicy { get; set; }
        public class GetPasswordPolicyResponseBodyPasswordPolicy : TeaModel {
            /// <summary>
            /// Indicates whether to disable logon after a password expires. Valid values:
            /// 
            /// *   true: disables logon after a password expires.
            /// *   false: does not disable logon after a password expires.
            /// </summary>
            [NameInMap("HardExpire")]
            [Validation(Required=false)]
            public bool? HardExpire { get; set; }

            /// <summary>
            /// The number of password retries.
            /// 
            /// If wrong passwords are entered for the specified consecutive times, the account is locked for 1 hour.
            /// 
            /// Valid values: 0 to 32. The value 0 indicates that the number of password retries is not limited.
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
            /// The maximum password length.
            /// </summary>
            [NameInMap("MaxPasswordLength")]
            [Validation(Required=false)]
            public int? MaxPasswordLength { get; set; }

            /// <summary>
            /// The minimum number of different characters in a password.
            /// 
            /// The minimum value is 0, which indicates that the minimum number of different characters in a password is not limited. The maximum value is the value of the `MinPasswordLength` parameter.
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
            /// Indicates whether to exclude the username from the password. Valid values:
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
            /// The previous N passwords cannot be reused. Valid values of N: 0 to 24. The value 0 indicates that all historical passwords can be reused.
            /// 
            /// >  Passwords that are generated before January 5, 2024 are not counted as historical passwords.
            /// </summary>
            [NameInMap("PasswordReusePrevention")]
            [Validation(Required=false)]
            public int? PasswordReusePrevention { get; set; }

            /// <summary>
            /// Indicates whether lowercase letters are required in a password. Valid values:
            /// 
            /// *   true: Lowercase letters are required in a password.
            /// *   false: Lowercase letters are not required in a password.
            /// </summary>
            [NameInMap("RequireLowerCaseChars")]
            [Validation(Required=false)]
            public bool? RequireLowerCaseChars { get; set; }

            /// <summary>
            /// Indicates whether digits are required in a password. Valid values:
            /// 
            /// *   true: Digits are required in a password.
            /// *   false: Digits are not required in a password.
            /// </summary>
            [NameInMap("RequireNumbers")]
            [Validation(Required=false)]
            public bool? RequireNumbers { get; set; }

            /// <summary>
            /// Indicates whether special characters are required in a password. Valid values:
            /// 
            /// *   true: Special characters are required in a password.
            /// *   false: Special characters are not required in a password.
            /// </summary>
            [NameInMap("RequireSymbols")]
            [Validation(Required=false)]
            public bool? RequireSymbols { get; set; }

            /// <summary>
            /// Indicates whether uppercase letters are required in a password. Valid values:
            /// 
            /// *   true: Uppercase letters are required in a password.
            /// *   false: Uppercase letters are not required in a password.
            /// </summary>
            [NameInMap("RequireUpperCaseChars")]
            [Validation(Required=false)]
            public bool? RequireUpperCaseChars { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
