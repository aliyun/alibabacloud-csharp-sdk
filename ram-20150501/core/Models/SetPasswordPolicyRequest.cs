// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class SetPasswordPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether a password will expire. Valid values: <c>true</c> and <c>false</c>. Default value: <c>false</c>. If you leave this parameter unspecified, the default value false is used.</para>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to <c>true</c>, the Alibaba Cloud account to which the RAM users belong must reset the passwords before the RAM users can log on to the Alibaba Cloud Management Console.</description></item>
        /// <item><description>If you set this parameter to <c>false</c>, the RAM users can change the passwords after the passwords expire and then log on to the Alibaba Cloud Management Console.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HardExpiry")]
        [Validation(Required=false)]
        public bool? HardExpiry { get; set; }

        /// <summary>
        /// <para>The maximum number of permitted logon attempts within one hour. The number of logon attempts is reset to zero if a RAM user changes the password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxLoginAttemps")]
        [Validation(Required=false)]
        public int? MaxLoginAttemps { get; set; }

        /// <summary>
        /// <para>The number of days for which a password is valid. If you reset a password, the password validity period restarts. Default value: 0. The default value indicates that the password never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxPasswordAge")]
        [Validation(Required=false)]
        public int? MaxPasswordAge { get; set; }

        /// <summary>
        /// <para>The minimum number of characters in a password.</para>
        /// <para>Valid values: 8 to 32. Default value: 8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MinimumPasswordLength")]
        [Validation(Required=false)]
        public int? MinimumPasswordLength { get; set; }

        /// <summary>
        /// <para>The number of previous passwords that a RAM user is prevented from reusing. Default value: 0. The default value indicates that the RAM user can reuse previous passwords.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PasswordReusePrevention")]
        [Validation(Required=false)]
        public int? PasswordReusePrevention { get; set; }

        /// <summary>
        /// <para>Specifies whether a password must contain one or more lowercase letters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RequireLowercaseCharacters")]
        [Validation(Required=false)]
        public bool? RequireLowercaseCharacters { get; set; }

        /// <summary>
        /// <para>Specifies whether a password must contain one or more digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RequireNumbers")]
        [Validation(Required=false)]
        public bool? RequireNumbers { get; set; }

        /// <summary>
        /// <para>Specifies whether a password must contain one or more special characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RequireSymbols")]
        [Validation(Required=false)]
        public bool? RequireSymbols { get; set; }

        /// <summary>
        /// <para>Specifies whether a password must contain one or more uppercase letters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RequireUppercaseCharacters")]
        [Validation(Required=false)]
        public bool? RequireUppercaseCharacters { get; set; }

    }

}
