// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetPasswordPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The password policy.</para>
        /// </summary>
        [NameInMap("PasswordPolicy")]
        [Validation(Required=false)]
        public GetPasswordPolicyResponseBodyPasswordPolicy PasswordPolicy { get; set; }
        public class GetPasswordPolicyResponseBodyPasswordPolicy : TeaModel {
            /// <summary>
            /// <para>Indicates whether to disable logon after a password expires. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: disables logon after a password expires.</description></item>
            /// <item><description>false: does not disable logon after a password expires.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HardExpire")]
            [Validation(Required=false)]
            public bool? HardExpire { get; set; }

            /// <summary>
            /// <para>The number of password retries.</para>
            /// <para>If wrong passwords are entered for the specified consecutive times, the account is locked for 1 hour.</para>
            /// <para>Valid values: 0 to 32. The value 0 indicates that the number of password retries is not limited.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxLoginAttempts")]
            [Validation(Required=false)]
            public int? MaxLoginAttempts { get; set; }

            /// <summary>
            /// <para>The validity period of a password.</para>
            /// <para>Valid values: 1 to 120. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("MaxPasswordAge")]
            [Validation(Required=false)]
            public int? MaxPasswordAge { get; set; }

            /// <summary>
            /// <para>The maximum password length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("MaxPasswordLength")]
            [Validation(Required=false)]
            public int? MaxPasswordLength { get; set; }

            /// <summary>
            /// <para>The minimum number of different characters in a password.</para>
            /// <para>The minimum value is 0, which indicates that the minimum number of different characters in a password is not limited. The maximum value is the value of the <c>MinPasswordLength</c> parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MinPasswordDifferentChars")]
            [Validation(Required=false)]
            public int? MinPasswordDifferentChars { get; set; }

            /// <summary>
            /// <para>The minimum password length.</para>
            /// <para>Valid values: 8 to 32 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MinPasswordLength")]
            [Validation(Required=false)]
            public int? MinPasswordLength { get; set; }

            /// <summary>
            /// <para>Indicates whether to exclude the username from the password. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: A password cannot contain the username.</description></item>
            /// <item><description>false: A password can contain the username.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PasswordNotContainUsername")]
            [Validation(Required=false)]
            public bool? PasswordNotContainUsername { get; set; }

            /// <summary>
            /// <para>The policy for password history check.</para>
            /// <para>The previous N passwords cannot be reused. Valid values of N: 0 to 24. The value 0 indicates that all historical passwords can be reused.</para>
            /// <remarks>
            /// <para> Passwords that are generated before January 5, 2024 are not counted as historical passwords.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PasswordReusePrevention")]
            [Validation(Required=false)]
            public int? PasswordReusePrevention { get; set; }

            /// <summary>
            /// <para>Indicates whether lowercase letters are required in a password. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Lowercase letters are required in a password.</description></item>
            /// <item><description>false: Lowercase letters are not required in a password.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RequireLowerCaseChars")]
            [Validation(Required=false)]
            public bool? RequireLowerCaseChars { get; set; }

            /// <summary>
            /// <para>Indicates whether digits are required in a password. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Digits are required in a password.</description></item>
            /// <item><description>false: Digits are not required in a password.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RequireNumbers")]
            [Validation(Required=false)]
            public bool? RequireNumbers { get; set; }

            /// <summary>
            /// <para>Indicates whether special characters are required in a password. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Special characters are required in a password.</description></item>
            /// <item><description>false: Special characters are not required in a password.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RequireSymbols")]
            [Validation(Required=false)]
            public bool? RequireSymbols { get; set; }

            /// <summary>
            /// <para>Indicates whether uppercase letters are required in a password. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Uppercase letters are required in a password.</description></item>
            /// <item><description>false: Uppercase letters are not required in a password.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RequireUpperCaseChars")]
            [Validation(Required=false)]
            public bool? RequireUpperCaseChars { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7C6E839-FB65-59BE-B753-003AA8AF7DF7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
