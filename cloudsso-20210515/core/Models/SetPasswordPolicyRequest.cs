// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetPasswordPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The number of password retries.</para>
        /// <para>If you enter wrong passwords for the specified consecutive times, the account is locked for 1 hour.</para>
        /// <para>Valid values: 0 to 32. The value 0 specifies that the number of password retries is not limited.</para>
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
        /// <para>The minimum number of unique characters in a password.</para>
        /// <para>The minimum value is 0, which specifies that the minimum number of unique characters in a password is not limited. The maximum value is the value of the <c>MinPasswordLength</c> parameter.</para>
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
        /// <para>Specifies whether a password can contain the username. Valid value:</para>
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
        /// <para>The previous N passwords cannot be reused. Valid values of N: 0 to 24. The value 0 specifies that all historical passwords can be reused.</para>
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

    }

}
