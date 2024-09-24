// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UnlockUsersResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of unlocking the convenience user.
        /// </summary>
        [NameInMap("UnlockUsersResult")]
        [Validation(Required=false)]
        public UnlockUsersResponseBodyUnlockUsersResult UnlockUsersResult { get; set; }
        public class UnlockUsersResponseBodyUnlockUsersResult : TeaModel {
            /// <summary>
            /// The convenience users that failed to be unlocked.
            /// </summary>
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<UnlockUsersResponseBodyUnlockUsersResultFailedUsers> FailedUsers { get; set; }
            public class UnlockUsersResponseBodyUnlockUsersResultFailedUsers : TeaModel {
                /// <summary>
                /// The ID of the convenience user that failed to be unlocked.
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
            /// The convenience users that were unlocked.
            /// </summary>
            [NameInMap("UnlockedUsers")]
            [Validation(Required=false)]
            public List<string> UnlockedUsers { get; set; }

        }

    }

}
