// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// The new description of the RAM user.
        /// 
        /// The description must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("NewComments")]
        [Validation(Required=false)]
        public string NewComments { get; set; }

        /// <summary>
        /// The new display name of the RAM user.
        /// 
        /// The name must be 1 to 24 characters in length.
        /// </summary>
        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

        /// <summary>
        /// The new email address of the RAM user.
        /// 
        /// > This parameter is valid only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("NewEmail")]
        [Validation(Required=false)]
        public string NewEmail { get; set; }

        /// <summary>
        /// The new mobile phone number of the RAM user.
        /// 
        /// Format: \<Country code>-\<Mobile phone number>.
        /// 
        /// > This parameter is valid only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("NewMobilePhone")]
        [Validation(Required=false)]
        public string NewMobilePhone { get; set; }

        /// <summary>
        /// The new logon name of the RAM user.
        /// 
        /// The name is in the format of `<username>@<AccountAlias>.onaliyun.com`. `<username>` indicates the name of the RAM user. `<AccountAlias>.onaliyun.com` indicates the default domain name.
        /// 
        /// The value of `UserPrincipalName` must be 1 to 128 characters in length and can contain letters, digits, periods (.), hyphens (-), and underscores (\_). The value of `<username>` must be 1 to 64 characters in length.
        /// </summary>
        [NameInMap("NewUserPrincipalName")]
        [Validation(Required=false)]
        public string NewUserPrincipalName { get; set; }

        /// <summary>
        /// The ID of the RAM user.
        /// 
        /// > You must specify only one of the following parameters: `UserPrincipalName` and `UserId`.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// The logon name of the RAM user.
        /// 
        /// > You must specify only one of the following parameters: `UserPrincipalName` and `UserId`.
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
