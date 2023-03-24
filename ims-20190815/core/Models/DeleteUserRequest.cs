// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class DeleteUserRequest : TeaModel {
        /// <summary>
        /// The ID of the RAM user.
        /// 
        /// >  You must specify only one of the following parameters: `UserPrincipalName` and `UserId`.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// The logon name of the RAM user.
        /// 
        /// >  You must specify only one of the following parameters: `UserPrincipalName` and `UserId`.
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
