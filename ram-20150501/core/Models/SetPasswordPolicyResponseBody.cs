// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class SetPasswordPolicyResponseBody : TeaModel {
        /// <summary>
        /// The password policy.
        /// </summary>
        [NameInMap("PasswordPolicy")]
        [Validation(Required=false)]
        public SetPasswordPolicyResponseBodyPasswordPolicy PasswordPolicy { get; set; }
        public class SetPasswordPolicyResponseBodyPasswordPolicy : TeaModel {
            /// <summary>
            /// Indicates whether a password expires.
            /// 
            /// Valid values: `true` and `false`. Default value: `false`. If the parameter is unspecified, the default value false is returned.
            /// 
            /// *   If this parameter is set to `true`, the Alibaba Cloud account to which the RAM users belong must reset the password before the RAM users can log on to the Alibaba Cloud Management Console.
            /// *   If this parameter is set to `false`, the RAM users can change the passwords after the passwords expire and then log on to the Alibaba Cloud Management Console.
            /// </summary>
            [NameInMap("HardExpiry")]
            [Validation(Required=false)]
            public bool? HardExpiry { get; set; }

            /// <summary>
            /// The maximum number of permitted logon attempts within one hour. The number of logon attempts is reset to zero if a RAM user changes the password.
            /// </summary>
            [NameInMap("MaxLoginAttemps")]
            [Validation(Required=false)]
            public int? MaxLoginAttemps { get; set; }

            /// <summary>
            /// The number of days for which a password is valid. Default value: 0. The default value indicates that the password never expires.
            /// </summary>
            [NameInMap("MaxPasswordAge")]
            [Validation(Required=false)]
            public int? MaxPasswordAge { get; set; }

            /// <summary>
            /// The minimum required number of characters in a password.
            /// </summary>
            [NameInMap("MinimumPasswordLength")]
            [Validation(Required=false)]
            public int? MinimumPasswordLength { get; set; }

            /// <summary>
            /// The number of previous passwords that a RAM user is prevented from reusing. Default value: 0. The default value indicates that the RAM user can reuse previous passwords.
            /// </summary>
            [NameInMap("PasswordReusePrevention")]
            [Validation(Required=false)]
            public int? PasswordReusePrevention { get; set; }

            /// <summary>
            /// Indicates whether a password must contain one or more lowercase letters.
            /// </summary>
            [NameInMap("RequireLowercaseCharacters")]
            [Validation(Required=false)]
            public bool? RequireLowercaseCharacters { get; set; }

            /// <summary>
            /// Indicates whether a password must contain one or more digits.
            /// </summary>
            [NameInMap("RequireNumbers")]
            [Validation(Required=false)]
            public bool? RequireNumbers { get; set; }

            /// <summary>
            /// Indicates whether a password must contain one or more special characters.
            /// </summary>
            [NameInMap("RequireSymbols")]
            [Validation(Required=false)]
            public bool? RequireSymbols { get; set; }

            /// <summary>
            /// Indicates whether a password must contain one or more uppercase letters.
            /// </summary>
            [NameInMap("RequireUppercaseCharacters")]
            [Validation(Required=false)]
            public bool? RequireUppercaseCharacters { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
