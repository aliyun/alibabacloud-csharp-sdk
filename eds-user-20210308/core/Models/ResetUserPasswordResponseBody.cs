// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ResetUserPasswordResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of resetting the password of the convenience user.
        /// </summary>
        [NameInMap("ResetUsersResult")]
        [Validation(Required=false)]
        public ResetUserPasswordResponseBodyResetUsersResult ResetUsersResult { get; set; }
        public class ResetUserPasswordResponseBodyResetUsersResult : TeaModel {
            /// <summary>
            /// The information about the convenience users whose passwords failed to be reset.
            /// </summary>
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<ResetUserPasswordResponseBodyResetUsersResultFailedUsers> FailedUsers { get; set; }
            public class ResetUserPasswordResponseBodyResetUsersResultFailedUsers : TeaModel {
                /// <summary>
                /// The ID of the convenience user whose password failed to be reset.
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
            /// The convenience users to which the system sent a password reset email.
            /// </summary>
            [NameInMap("ResetUsers")]
            [Validation(Required=false)]
            public List<string> ResetUsers { get; set; }

        }

    }

}
