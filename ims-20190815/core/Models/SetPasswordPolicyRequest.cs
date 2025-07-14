// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetPasswordPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to disable logon after the password expires. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: After the password expires, you cannot use the password to log on to the console. You can log on to the console only after you reset the password by using your Alibaba Cloud account or as a RAM user that has administrative rights.</description></item>
        /// <item><description>false: After the password expires, you can change the password to log on to the console. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HardExpire")]
        [Validation(Required=false)]
        public bool? HardExpire { get; set; }

        /// <summary>
        /// <para>The maximum number of password retries. If you enter the wrong passwords for the specified consecutive times, the account is locked for one hour.</para>
        /// <para>Valid values: 0 to 32.</para>
        /// <para>The default value is 0, which indicates that the password retries are not limited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxLoginAttemps")]
        [Validation(Required=false)]
        public int? MaxLoginAttemps { get; set; }

        /// <summary>
        /// <para>The validity period of the password.</para>
        /// <para>Valid values: 0 to 1095. Unit: days.</para>
        /// <para>The default value is 0, which indicates that the password never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxPasswordAge")]
        [Validation(Required=false)]
        public int? MaxPasswordAge { get; set; }

        /// <summary>
        /// <para>The minimum number of unique characters in the password.</para>
        /// <para>Valid values: 0 to 8.</para>
        /// <para>The default value is 0, which indicates that no limits are imposed on the number of unique characters in a password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinimumPasswordDifferentCharacter")]
        [Validation(Required=false)]
        public int? MinimumPasswordDifferentCharacter { get; set; }

        /// <summary>
        /// <para>The minimum number of characters in the password.</para>
        /// <para>Valid values: 8 to 32. Default value: 8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinimumPasswordLength")]
        [Validation(Required=false)]
        public int? MinimumPasswordLength { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude the username from the password. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: A password cannot contain the username.</description></item>
        /// <item><description>false: A password can contain the username. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordNotContainUserName")]
        [Validation(Required=false)]
        public bool? PasswordNotContainUserName { get; set; }

        /// <summary>
        /// <para>The policy for password history check.</para>
        /// <para>The previous N passwords cannot be reused. Valid values of N: 0 to 24.</para>
        /// <para>The default value is 0, which indicates that RAM users can reuse previous passwords.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PasswordReusePrevention")]
        [Validation(Required=false)]
        public int? PasswordReusePrevention { get; set; }

        /// <summary>
        /// <para>Specifies whether the password must contain lowercase letters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RequireLowercaseCharacters")]
        [Validation(Required=false)]
        public bool? RequireLowercaseCharacters { get; set; }

        /// <summary>
        /// <para>Specifies whether the password must contain digits. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RequireNumbers")]
        [Validation(Required=false)]
        public bool? RequireNumbers { get; set; }

        /// <summary>
        /// <para>Specifies whether the password must contain special characters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RequireSymbols")]
        [Validation(Required=false)]
        public bool? RequireSymbols { get; set; }

        /// <summary>
        /// <para>Specifies whether the password must contain uppercase letters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RequireUppercaseCharacters")]
        [Validation(Required=false)]
        public bool? RequireUppercaseCharacters { get; set; }

    }

}
