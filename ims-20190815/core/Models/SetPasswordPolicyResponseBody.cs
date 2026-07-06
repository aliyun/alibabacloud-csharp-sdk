// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetPasswordPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the password policy.</para>
        /// </summary>
        [NameInMap("PasswordPolicy")]
        [Validation(Required=false)]
        public SetPasswordPolicyResponseBodyPasswordPolicy PasswordPolicy { get; set; }
        public class SetPasswordPolicyResponseBodyPasswordPolicy : TeaModel {
            /// <summary>
            /// <para>Indicates whether logon is blocked after a password expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HardExpire")]
            [Validation(Required=false)]
            public bool? HardExpire { get; set; }

            /// <summary>
            /// <para>The validity period for initial passwords.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("InitialPasswordAge")]
            [Validation(Required=false)]
            public int? InitialPasswordAge { get; set; }

            /// <summary>
            /// <para>Indicates whether threat passwords are blocked when set using APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("InterceptRiskPasswordOnApi")]
            [Validation(Required=false)]
            public bool? InterceptRiskPasswordOnApi { get; set; }

            /// <summary>
            /// <para>Maximum number of failed password attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxLoginAttemps")]
            [Validation(Required=false)]
            public int? MaxLoginAttemps { get; set; }

            /// <summary>
            /// <para>The password validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxPasswordAge")]
            [Validation(Required=false)]
            public int? MaxPasswordAge { get; set; }

            /// <summary>
            /// <para>Minimum number of unique characters in a password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MinimumPasswordDifferentCharacter")]
            [Validation(Required=false)]
            public int? MinimumPasswordDifferentCharacter { get; set; }

            /// <summary>
            /// <para>Minimum password length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MinimumPasswordLength")]
            [Validation(Required=false)]
            public int? MinimumPasswordLength { get; set; }

            /// <summary>
            /// <para>Indicates whether passwords must not contain the user name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PasswordNotContainUserName")]
            [Validation(Required=false)]
            public bool? PasswordNotContainUserName { get; set; }

            /// <summary>
            /// <para>Prevents reuse of previous passwords.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PasswordReusePrevention")]
            [Validation(Required=false)]
            public int? PasswordReusePrevention { get; set; }

            /// <summary>
            /// <para>Indicates whether passwords must contain lowercase letters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RequireLowercaseCharacters")]
            [Validation(Required=false)]
            public bool? RequireLowercaseCharacters { get; set; }

            /// <summary>
            /// <para>Indicates whether passwords must contain numbers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RequireNumbers")]
            [Validation(Required=false)]
            public bool? RequireNumbers { get; set; }

            /// <summary>
            /// <para>Indicates whether passwords must contain special characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RequireSymbols")]
            [Validation(Required=false)]
            public bool? RequireSymbols { get; set; }

            /// <summary>
            /// <para>Indicates whether passwords must contain uppercase letters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RequireUppercaseCharacters")]
            [Validation(Required=false)]
            public bool? RequireUppercaseCharacters { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FB5551F-B2ED-40D4-8392-1E4AC2384EFD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
