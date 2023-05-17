// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class LockUsersResponseBody : TeaModel {
        [NameInMap("LockUsersResult")]
        [Validation(Required=false)]
        public LockUsersResponseBodyLockUsersResult LockUsersResult { get; set; }
        public class LockUsersResponseBodyLockUsersResult : TeaModel {
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<LockUsersResponseBodyLockUsersResultFailedUsers> FailedUsers { get; set; }
            public class LockUsersResponseBodyLockUsersResultFailedUsers : TeaModel {
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            [NameInMap("LockedUsers")]
            [Validation(Required=false)]
            public List<string> LockedUsers { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
