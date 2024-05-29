// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetPasswordComplexityConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The password complexity configurations.
        /// </summary>
        [NameInMap("PasswordComplexityConfiguration")]
        [Validation(Required=false)]
        public GetPasswordComplexityConfigurationResponseBodyPasswordComplexityConfiguration PasswordComplexityConfiguration { get; set; }
        public class GetPasswordComplexityConfigurationResponseBodyPasswordComplexityConfiguration : TeaModel {
            /// <summary>
            /// The password complexity rules.
            /// </summary>
            [NameInMap("PasswordComplexityRules")]
            [Validation(Required=false)]
            public List<GetPasswordComplexityConfigurationResponseBodyPasswordComplexityConfigurationPasswordComplexityRules> PasswordComplexityRules { get; set; }
            public class GetPasswordComplexityConfigurationResponseBodyPasswordComplexityConfigurationPasswordComplexityRules : TeaModel {
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
            /// </summary>
            [NameInMap("PasswordMinLength")]
            [Validation(Required=false)]
            public int? PasswordMinLength { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
