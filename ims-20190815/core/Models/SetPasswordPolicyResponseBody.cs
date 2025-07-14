// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetPasswordPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the password policy.</para>
        /// </summary>
        [NameInMap("PasswordPolicy")]
        [Validation(Required=false)]
        public SetPasswordPolicyResponseBodyPasswordPolicy PasswordPolicy { get; set; }
        public class SetPasswordPolicyResponseBodyPasswordPolicy : TeaModel {
            /// <summary>
            /// <para>Indicates whether to disable logon after the password expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HardExpire")]
            [Validation(Required=false)]
            public bool? HardExpire { get; set; }

            /// <summary>
            /// <para>The maximum number of password retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxLoginAttemps")]
            [Validation(Required=false)]
            public int? MaxLoginAttemps { get; set; }

            /// <summary>
            /// <para>The validity period of the password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxPasswordAge")]
            [Validation(Required=false)]
            public int? MaxPasswordAge { get; set; }

            /// <summary>
            /// <para>The minimum number of unique characters in the password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MinimumPasswordDifferentCharacter")]
            [Validation(Required=false)]
            public int? MinimumPasswordDifferentCharacter { get; set; }

            /// <summary>
            /// <para>The minimum number of characters in the password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MinimumPasswordLength")]
            [Validation(Required=false)]
            public int? MinimumPasswordLength { get; set; }

            /// <summary>
            /// <para>Indicates whether to exclude the username from the password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PasswordNotContainUserName")]
            [Validation(Required=false)]
            public bool? PasswordNotContainUserName { get; set; }

            /// <summary>
            /// <para>The policy for password history check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PasswordReusePrevention")]
            [Validation(Required=false)]
            public int? PasswordReusePrevention { get; set; }

            /// <summary>
            /// <para>Indicates whether the password must contain lowercase letters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RequireLowercaseCharacters")]
            [Validation(Required=false)]
            public bool? RequireLowercaseCharacters { get; set; }

            /// <summary>
            /// <para>Indicates whether the password must contain digits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RequireNumbers")]
            [Validation(Required=false)]
            public bool? RequireNumbers { get; set; }

            /// <summary>
            /// <para>Indicates whether the password must contain special characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RequireSymbols")]
            [Validation(Required=false)]
            public bool? RequireSymbols { get; set; }

            /// <summary>
            /// <para>Indicates whether the password must contain uppercase letters.</para>
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
