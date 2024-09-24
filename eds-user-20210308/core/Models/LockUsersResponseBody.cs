// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class LockUsersResponseBody : TeaModel {
        /// <summary>
        /// The result of the locking the convenience user.
        /// </summary>
        [NameInMap("LockUsersResult")]
        [Validation(Required=false)]
        public LockUsersResponseBodyLockUsersResult LockUsersResult { get; set; }
        public class LockUsersResponseBodyLockUsersResult : TeaModel {
            /// <summary>
            /// The convenience users that failed to be locked.
            /// </summary>
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<LockUsersResponseBodyLockUsersResultFailedUsers> FailedUsers { get; set; }
            public class LockUsersResponseBodyLockUsersResultFailedUsers : TeaModel {
                /// <summary>
                /// The ID of the convenience user that failed to be locked.
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// The error code.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            /// <summary>
            /// The convenience users that were locked.
            /// </summary>
            [NameInMap("LockedUsers")]
            [Validation(Required=false)]
            public List<string> LockedUsers { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
