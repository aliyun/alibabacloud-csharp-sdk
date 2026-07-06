// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetPasswordPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether logon is blocked after a password expires.</para>
        /// <list type="bullet">
        /// <item><description><para>true: After a password expires, the RAM user cannot log on to the console. An Alibaba Cloud account owner or a RAM administrator must reset the password before the RAM user can log on.</para>
        /// </description></item>
        /// <item><description><para>false (default): After a password expires, the RAM user can change the password and then log on.</para>
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
        /// <para>Validity period for initial passwords. Initial passwords apply to newly created RAM users or users whose console logon settings are re-enabled.</para>
        /// <para>Valid values: 0 to 90. Unit: days.</para>
        /// <para>Default value: 14.</para>
        /// <para>A value of 0 disables this constraint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("InitialPasswordAge")]
        [Validation(Required=false)]
        public int? InitialPasswordAge { get; set; }

        /// <summary>
        /// <para>Specifies whether threat passwords are blocked when set using APIs.</para>
        /// <para>Default value: false</para>
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
        [NameInMap("InterceptRiskPasswordOnApi")]
        [Validation(Required=false)]
        public bool? InterceptRiskPasswordOnApi { get; set; }

        /// <summary>
        /// <para>Maximum number of failed password attempts. After the specified number of consecutive incorrect password attempts, the account is locked for one hour.</para>
        /// <para>Valid values: 0 to 32.</para>
        /// <para>Default value: 0, which disables this constraint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxLoginAttemps")]
        [Validation(Required=false)]
        public int? MaxLoginAttemps { get; set; }

        /// <summary>
        /// <para>Password validity period.</para>
        /// <para>Valid values: 0 to 1095. Unit: days.</para>
        /// <para>Default value: 0, which means passwords never expire.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxPasswordAge")]
        [Validation(Required=false)]
        public int? MaxPasswordAge { get; set; }

        /// <summary>
        /// <para>Minimum number of unique characters in a password.</para>
        /// <para>Valid values: 0 to 8.</para>
        /// <para>Default value: 0, which imposes no restriction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinimumPasswordDifferentCharacter")]
        [Validation(Required=false)]
        public int? MinimumPasswordDifferentCharacter { get; set; }

        /// <summary>
        /// <para>Minimum password length.</para>
        /// <para>Valid values: 8 to 32.</para>
        /// <para>Default value: 8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinimumPasswordLength")]
        [Validation(Required=false)]
        public int? MinimumPasswordLength { get; set; }

        /// <summary>
        /// <para>Specifies whether passwords must not contain the user name.</para>
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
        [NameInMap("PasswordNotContainUserName")]
        [Validation(Required=false)]
        public bool? PasswordNotContainUserName { get; set; }

        /// <summary>
        /// <para>Prevents reuse of previous passwords.</para>
        /// <para>Valid values: 0 to 24. This value specifies how many previous passwords are blocked from reuse.</para>
        /// <para>Default value: 0, which disables this constraint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PasswordReusePrevention")]
        [Validation(Required=false)]
        public int? PasswordReusePrevention { get; set; }

        /// <summary>
        /// <para>Specifies whether passwords must contain lowercase letters.</para>
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
        /// <para>Specifies whether passwords must contain numbers.</para>
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
        /// <para>Specifies whether passwords must contain special characters.</para>
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
        /// <para>Specifies whether passwords must contain uppercase letters.</para>
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
