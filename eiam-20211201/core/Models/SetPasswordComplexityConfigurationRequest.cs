// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetPasswordComplexityConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The password complexity rules.</para>
        /// </summary>
        [NameInMap("PasswordComplexityRules")]
        [Validation(Required=false)]
        public List<SetPasswordComplexityConfigurationRequestPasswordComplexityRules> PasswordComplexityRules { get; set; }
        public class SetPasswordComplexityConfigurationRequestPasswordComplexityRules : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PasswordMinLength")]
        [Validation(Required=false)]
        public int? PasswordMinLength { get; set; }

    }

}
