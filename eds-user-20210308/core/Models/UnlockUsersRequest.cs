// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UnlockUsersRequest : TeaModel {
        /// <summary>
        /// The date on which the convenience users are automatically locked.
        /// </summary>
        [NameInMap("AutoLockTime")]
        [Validation(Required=false)]
        public string AutoLockTime { get; set; }

        /// <summary>
        /// The usernames of the convenience users that you want to unlock.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
