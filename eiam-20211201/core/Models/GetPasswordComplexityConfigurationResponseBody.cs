// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetPasswordComplexityConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The password complexity configurations.</para>
        /// </summary>
        [NameInMap("PasswordComplexityConfiguration")]
        [Validation(Required=false)]
        public GetPasswordComplexityConfigurationResponseBodyPasswordComplexityConfiguration PasswordComplexityConfiguration { get; set; }
        public class GetPasswordComplexityConfigurationResponseBodyPasswordComplexityConfiguration : TeaModel {
            /// <summary>
            /// <para>The password complexity rules.</para>
            /// </summary>
            [NameInMap("PasswordComplexityRules")]
            [Validation(Required=false)]
            public List<GetPasswordComplexityConfigurationResponseBodyPasswordComplexityConfigurationPasswordComplexityRules> PasswordComplexityRules { get; set; }
            public class GetPasswordComplexityConfigurationResponseBodyPasswordComplexityConfigurationPasswordComplexityRules : TeaModel {
                /// <summary>
                /// <para>The type of the password check. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>inclusion_upper_case: The password must contain uppercase letters.</description></item>
                /// <item><description>inclusion_lower_case: The password must contain lowercase letters.</description></item>
                /// <item><description>inclusion_special_case: The password must contain one or more of the following special characters: @ % + \ / \&quot; ! # $ ^ ? : , ( ) { } [ ] ~ - _ .</description></item>
                /// <item><description>inclusion_number: The password must contain digits.</description></item>
                /// <item><description>exclusion_username: The password cannot contain a username.</description></item>
                /// <item><description>exclusion_email: The password cannot contain an email prefix.</description></item>
                /// <item><description>exclusion_phone_number: The password cannot contain a mobile number.</description></item>
                /// <item><description>exclusion_display_name: The password cannot contain a display name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>inclusion_upper_case</para>
                /// </summary>
                [NameInMap("PasswordCheckType")]
                [Validation(Required=false)]
                public string PasswordCheckType { get; set; }

            }

            /// <summary>
            /// <para>The minimum number of characters in a password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PasswordMinLength")]
            [Validation(Required=false)]
            public int? PasswordMinLength { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
