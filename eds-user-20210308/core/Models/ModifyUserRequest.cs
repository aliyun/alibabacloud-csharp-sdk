// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ModifyUserRequest : TeaModel {
        /// <summary>
        /// The email address of the convenience user. For a user-activated convenience user, the email address or mobile number must be verified. You can choose to verify the email address or the mobile number. For an administrator-activated convenience user, the email address and mobile number can be left empty.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The name of the user.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// The mobile number of the convenience user. For a user-activated convenience user, the email address or mobile number must be verified. You can choose to verify the email address or the mobile number. For an administrator-activated convenience user, the email address and mobile number can be left empty.
        /// 
        /// >  Accounts created on the International site (alibabacloud.com) do not support mobile number-based authentication.
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

    }

}
