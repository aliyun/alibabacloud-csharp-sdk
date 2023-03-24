// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetPasswordPolicyRequest : TeaModel {
        /// <summary>
        /// Specifies whether to disable logon after the password expires. Valid values:
        /// 
        /// *   true: After the password expires, you cannot use the password to log on to the console. You can log on to the console only after you reset the password by using your Alibaba Cloud account or as a RAM user that has administrative rights.
        /// *   false: After the password expires, you can change the password to log on to the console. This is the default value.
        /// </summary>
        [NameInMap("HardExpire")]
        [Validation(Required=false)]
        public bool? HardExpire { get; set; }

        /// <summary>
        /// The maximum number of password retries. If you enter the wrong passwords for the specified consecutive times, the account is locked for one hour.
        /// 
        /// Valid values: 0 to 32.
        /// 
        /// The default value is 0, which indicates that the password retries are not limited.
        /// </summary>
        [NameInMap("MaxLoginAttemps")]
        [Validation(Required=false)]
        public int? MaxLoginAttemps { get; set; }

        /// <summary>
        /// The validity period of the password.
        /// 
        /// Valid values: 0 to 1095. Unit: days.
        /// 
        /// The default value is 0, which indicates that the password never expires.
        /// </summary>
        [NameInMap("MaxPasswordAge")]
        [Validation(Required=false)]
        public int? MaxPasswordAge { get; set; }

        /// <summary>
        /// The minimum number of unique characters in the password.
        /// 
        /// Valid values: 0 to 8.
        /// 
        /// The default value is 0, which indicates that no limits are imposed on the number of unique characters in a password.
        /// </summary>
        [NameInMap("MinimumPasswordDifferentCharacter")]
        [Validation(Required=false)]
        public int? MinimumPasswordDifferentCharacter { get; set; }

        /// <summary>
        /// The minimum number of characters in the password.
        /// 
        /// Valid values: 8 to 32. Default value: 8.
        /// </summary>
        [NameInMap("MinimumPasswordLength")]
        [Validation(Required=false)]
        public int? MinimumPasswordLength { get; set; }

        /// <summary>
        /// Specifies whether to exclude the username from the password. Valid values:
        /// 
        /// *   true: A password cannot contain the username.
        /// *   false: A password can contain the username. This is the default value.
        /// </summary>
        [NameInMap("PasswordNotContainUserName")]
        [Validation(Required=false)]
        public bool? PasswordNotContainUserName { get; set; }

        /// <summary>
        /// The policy for password history check.
        /// 
        /// The previous N passwords cannot be reused. Valid values of N: 0 to 24.
        /// 
        /// The default value is 0, which indicates that RAM users can reuse previous passwords.
        /// </summary>
        [NameInMap("PasswordReusePrevention")]
        [Validation(Required=false)]
        public int? PasswordReusePrevention { get; set; }

        /// <summary>
        /// Specifies whether the password must contain lowercase letters. Default value: false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("RequireLowercaseCharacters")]
        [Validation(Required=false)]
        public bool? RequireLowercaseCharacters { get; set; }

        /// <summary>
        /// Specifies whether the password must contain digits. Default value: false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("RequireNumbers")]
        [Validation(Required=false)]
        public bool? RequireNumbers { get; set; }

        /// <summary>
        /// Specifies whether the password must contain special characters. Default value: false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("RequireSymbols")]
        [Validation(Required=false)]
        public bool? RequireSymbols { get; set; }

        /// <summary>
        /// Specifies whether the password must contain uppercase letters. Default value: false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("RequireUppercaseCharacters")]
        [Validation(Required=false)]
        public bool? RequireUppercaseCharacters { get; set; }

    }

}
