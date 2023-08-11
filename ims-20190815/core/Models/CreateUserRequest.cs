// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// The description.
        /// 
        /// The description must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// The display name of the RAM user.
        /// 
        /// The name must be 1 to 24 characters in length.
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The email address of the RAM user.
        /// 
        /// > This parameter is valid only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The mobile number of the RAM user.
        /// 
        /// Format: Country code-Mobile phone number.
        /// 
        /// > This parameter is valid only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("MobilePhone")]
        [Validation(Required=false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// The tag value.
        /// 
        /// Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be a up to128 characters in length and cannot contain `http://` or `https://`. The tag value cannot start with `acs:`.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateUserRequestTag> Tag { get; set; }
        public class CreateUserRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N.
            /// 
            /// Valid values of N: 1 to 20. You cannot specify empty strings as tag keys. The tag key can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N.
            /// 
            /// Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be a up to128 characters in length and cannot contain `http://` or `https://`. The tag value cannot start with `acs:`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The logon name of the RAM user.
        /// 
        /// The name is in the format of `<username>@<AccountAlias>.onaliyun.com`. `<username>` indicates the name of the RAM user. `<AccountAlias>.onaliyun.com` indicates the default domain name. For more information about how to obtain the default domain name, see [GetDefaultDomain](~~186720~~).
        /// 
        /// The value of `UserPrincipalName` must be 1 to 128 characters in length and can contain letters, digits, periods (.), hyphens (-), and underscores (\_). The value of `<username>` must be 1 to 64 characters in length.
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
