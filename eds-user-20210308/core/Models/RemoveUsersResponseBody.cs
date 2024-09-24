// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class RemoveUsersResponseBody : TeaModel {
        /// <summary>
        /// The result of removing the convenience user.
        /// </summary>
        [NameInMap("RemoveUsersResult")]
        [Validation(Required=false)]
        public RemoveUsersResponseBodyRemoveUsersResult RemoveUsersResult { get; set; }
        public class RemoveUsersResponseBodyRemoveUsersResult : TeaModel {
            /// <summary>
            /// The convenience users that failed to be removed.
            /// </summary>
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<RemoveUsersResponseBodyRemoveUsersResultFailedUsers> FailedUsers { get; set; }
            public class RemoveUsersResponseBodyRemoveUsersResultFailedUsers : TeaModel {
                /// <summary>
                /// The ID of the convenience user that failed to be removed.
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
            /// The convenience users that were removed.
            /// </summary>
            [NameInMap("RemovedUsers")]
            [Validation(Required=false)]
            public List<string> RemovedUsers { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
