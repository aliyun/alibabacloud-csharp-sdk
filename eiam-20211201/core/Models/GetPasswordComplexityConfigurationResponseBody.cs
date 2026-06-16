// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetPasswordComplexityConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The password complexity policy configuration.</para>
        /// </summary>
        [NameInMap("PasswordComplexityConfiguration")]
        [Validation(Required=false)]
        public GetPasswordComplexityConfigurationResponseBodyPasswordComplexityConfiguration PasswordComplexityConfiguration { get; set; }
        public class GetPasswordComplexityConfigurationResponseBodyPasswordComplexityConfiguration : TeaModel {
            /// <summary>
            /// <para>Indicates whether logon with a weak password is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisabledWeakPasswordLogin")]
            [Validation(Required=false)]
            public bool? DisabledWeakPasswordLogin { get; set; }

            /// <summary>
            /// <para>The time when the weak password logon restriction takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1773383634936</para>
            /// </summary>
            [NameInMap("DisabledWeakPasswordLoginStartedAt")]
            [Validation(Required=false)]
            public long? DisabledWeakPasswordLoginStartedAt { get; set; }

            /// <summary>
            /// <para>The list of password complexity rules.</para>
            /// </summary>
            [NameInMap("PasswordComplexityRules")]
            [Validation(Required=false)]
            public List<GetPasswordComplexityConfigurationResponseBodyPasswordComplexityConfigurationPasswordComplexityRules> PasswordComplexityRules { get; set; }
            public class GetPasswordComplexityConfigurationResponseBodyPasswordComplexityConfigurationPasswordComplexityRules : TeaModel {
                /// <summary>
                /// <para>The password check type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>inclusion_upper_case: The password must contain uppercase letters.</para>
                /// </description></item>
                /// <item><description><para>inclusion_lower_case: The password must contain lowercase letters.</para>
                /// </description></item>
                /// <item><description><para>inclusion_special_case: The password must contain at least one of the following special characters: \<c> @ % + \\ / \\&quot; ! # $ ^ ? : , ( ) { } [ ] \\~ - _ . \\</c>.</para>
                /// </description></item>
                /// <item><description><para>inclusion_number: The password must contain digits.</para>
                /// </description></item>
                /// <item><description><para>exclusion_username: The password cannot contain the username.</para>
                /// </description></item>
                /// <item><description><para>exclusion_email: The password cannot contain the email address.</para>
                /// </description></item>
                /// <item><description><para>exclusion_phone_number: The password cannot contain the mobile number.</para>
                /// </description></item>
                /// <item><description><para>exclusion_display_name: The password cannot contain the display name.</para>
                /// </description></item>
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
            /// <para>The minimum password length.</para>
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
