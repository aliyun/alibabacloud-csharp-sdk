// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetPasswordComplexityConfigurationRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The password complexity rules.
        /// </summary>
        [NameInMap("PasswordComplexityRules")]
        [Validation(Required=false)]
        public List<SetPasswordComplexityConfigurationRequestPasswordComplexityRules> PasswordComplexityRules { get; set; }
        public class SetPasswordComplexityConfigurationRequestPasswordComplexityRules : TeaModel {
            /// <summary>
            /// The type of the password check. Valid values:
            /// 
            /// *   inclusion_upper_case: The password must contain uppercase letters.
            /// *   inclusion_lower_case: The password must contain lowercase letters.
            /// *   inclusion_special_case: The password must contain one or more of the following special characters: @ % + \\ / \\" ! # $ ^ ? : , ( ) { } [ ] ~ - _ .
            /// *   inclusion_number: The password must contain digits.
            /// *   exclusion_username: The password cannot contain a username.
            /// *   exclusion_email: The password cannot contain an email prefix.
            /// *   exclusion_phone_number: The password cannot contain a mobile number.
            /// *   exclusion_display_name: The password cannot contain a display name.
            /// </summary>
            [NameInMap("PasswordCheckType")]
            [Validation(Required=false)]
            public string PasswordCheckType { get; set; }

        }

        /// <summary>
        /// The minimum number of characters in a password.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PasswordMinLength")]
        [Validation(Required=false)]
        public int? PasswordMinLength { get; set; }

    }

}
