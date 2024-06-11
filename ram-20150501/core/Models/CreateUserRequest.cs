// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// The description of the RAM user.
        /// 
        /// The description must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// The display name of the RAM user.
        /// 
        /// The display name must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The email address of the RAM user.
        /// 
        /// >  This parameter applies only to the China site (aliyun.com).
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The mobile phone number of the RAM user.
        /// 
        /// Format: Country code-Mobile phone number.
        /// 
        /// >  This parameter applies only to the China site (aliyun.com).
        /// </summary>
        [NameInMap("MobilePhone")]
        [Validation(Required=false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// The username of the RAM user.
        /// 
        /// The username must be 1 to 64 characters in length, and can contain letters, digits, periods (.), hyphens (-), and underscores (_).
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
