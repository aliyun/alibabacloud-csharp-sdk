// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetPasswordPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to prevent a RAM user from logging on after the password expires. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: After the password expires, the RAM user cannot log on to the console. The password must be reset by the Alibaba Cloud account or a RAM user with administrative permissions before the RAM user can log on.</para>
        /// </description></item>
        /// <item><description><para>false (default): After the password expires, the RAM user can change the password and then log on.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HardExpire")]
        [Validation(Required=false)]
        public bool? HardExpire { get; set; }

        /// <summary>
        /// <para>The validity period of an initial password. An initial password is the password that is set when you create a RAM user or re-enable console logon.</para>
        /// <para>Valid values: 0 to 90. Unit: days.</para>
        /// <para>Default value: 14.</para>
        /// <para>A value of 0 disables this feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("InitialPasswordAge")]
        [Validation(Required=false)]
        public int? InitialPasswordAge { get; set; }

        [NameInMap("InterceptRiskPasswordOnApi")]
        [Validation(Required=false)]
        public bool? InterceptRiskPasswordOnApi { get; set; }

        /// <summary>
        /// <para>The maximum number of consecutive logon failures that are allowed. If the number of failures is reached, the account is locked for one hour.</para>
        /// <para>Valid values: 0 to 32.</para>
        /// <para>Default value: 0. A value of 0 disables this feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxLoginAttemps")]
        [Validation(Required=false)]
        public int? MaxLoginAttemps { get; set; }

        /// <summary>
        /// <para>The validity period of a password.</para>
        /// <para>Valid values: 0 to 1095. Unit: days.</para>
        /// <para>Default value: 0. A value of 0 indicates that the password never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxPasswordAge")]
        [Validation(Required=false)]
        public int? MaxPasswordAge { get; set; }

        /// <summary>
        /// <para>The minimum number of unique characters in a password.</para>
        /// <para>Valid values: 0 to 8.</para>
        /// <para>Default value: 0. A value of 0 indicates that no limit is imposed on the number of unique characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinimumPasswordDifferentCharacter")]
        [Validation(Required=false)]
        public int? MinimumPasswordDifferentCharacter { get; set; }

        /// <summary>
        /// <para>The minimum length of the password.</para>
        /// <para>Valid values: 8 to 32. Default value: 8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinimumPasswordLength")]
        [Validation(Required=false)]
        public int? MinimumPasswordLength { get; set; }

        /// <summary>
        /// <para>Specifies whether the password can contain the username. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The password cannot contain the username.</para>
        /// </description></item>
        /// <item><description><para>false (default): The password can contain the username.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordNotContainUserName")]
        [Validation(Required=false)]
        public bool? PasswordNotContainUserName { get; set; }

        /// <summary>
        /// <para>The number of previous passwords that cannot be reused.</para>
        /// <para>Valid values: 0 to 24.</para>
        /// <para>Default value: 0. A value of 0 disables this feature.</para>
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
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false (default)</para>
        /// </description></item>
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
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false (default)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RequireNumbers")]
        [Validation(Required=false)]
        public bool? RequireNumbers { get; set; }

        /// <summary>
        /// <para>Specifies whether the password must contain symbols. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false (default)</para>
        /// </description></item>
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
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false (default)</para>
        /// </description></item>
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
