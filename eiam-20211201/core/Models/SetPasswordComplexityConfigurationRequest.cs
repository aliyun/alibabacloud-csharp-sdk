// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetPasswordComplexityConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to disable logon with a weak password.</para>
        /// </summary>
        [NameInMap("DisabledWeakPasswordLogin")]
        [Validation(Required=false)]
        public bool? DisabledWeakPasswordLogin { get; set; }

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
        /// <para>The list of password complexity rules.</para>
        /// </summary>
        [NameInMap("PasswordComplexityRules")]
        [Validation(Required=false)]
        public List<SetPasswordComplexityConfigurationRequestPasswordComplexityRules> PasswordComplexityRules { get; set; }
        public class SetPasswordComplexityConfigurationRequestPasswordComplexityRules : TeaModel {
            /// <summary>
            /// <para>The password check type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>inclusion_upper_case: The password must contain uppercase letters.</para>
            /// </description></item>
            /// <item><description><para>inclusion_lower_case: The password must contain lowercase letters.</para>
            /// </description></item>
            /// <item><description><para>inclusion_special_case: The password must contain special characters. The special characters are \<c>( @ % + \\ / \\&quot; ! # $ ^ ? : , ( ) { } [ ] \\~ - _ . )\\</c>.</para>
            /// </description></item>
            /// <item><description><para>inclusion_number: The password must contain digits.</para>
            /// </description></item>
            /// <item><description><para>exclusion_username: The password cannot contain the username.</para>
            /// </description></item>
            /// <item><description><para>exclusion_email: The password cannot contain the mailbox.</para>
            /// </description></item>
            /// <item><description><para>exclusion_phone_number: The password cannot contain the phone number.</para>
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
