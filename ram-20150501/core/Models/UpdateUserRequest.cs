// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
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
        /// The name must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

        /// <summary>
        /// The new email address of the RAM user.
        /// 
        /// >  This parameter can be returned only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("NewEmail")]
        [Validation(Required=false)]
        public string NewEmail { get; set; }

        /// <summary>
        /// The new mobile phone number of the RAM user.
        /// 
        /// Format: \\<Country code>-\\<Mobile phone number>.
        /// 
        /// >  This parameter can be returned only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("NewMobilePhone")]
        [Validation(Required=false)]
        public string NewMobilePhone { get; set; }

        /// <summary>
        /// The new username of the RAM user.
        /// 
        /// The username must be 1 to 64 characters in length, and can contain letters, digits, periods (.), hyphens (-), and underscores (_).
        /// </summary>
        [NameInMap("NewUserName")]
        [Validation(Required=false)]
        public string NewUserName { get; set; }

        /// <summary>
        /// The username of the RAM user.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
