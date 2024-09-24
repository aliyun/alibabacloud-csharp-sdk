// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreateUsersResponseBody : TeaModel {
        /// <summary>
        /// The result of user creation.
        /// </summary>
        [NameInMap("CreateResult")]
        [Validation(Required=false)]
        public CreateUsersResponseBodyCreateResult CreateResult { get; set; }
        public class CreateUsersResponseBodyCreateResult : TeaModel {
            /// <summary>
            /// Details of the created convenience users.
            /// </summary>
            [NameInMap("CreatedUsers")]
            [Validation(Required=false)]
            public List<CreateUsersResponseBodyCreateResultCreatedUsers> CreatedUsers { get; set; }
            public class CreateUsersResponseBodyCreateResultCreatedUsers : TeaModel {
                /// <summary>
                /// The email address of the end user.
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// The name of the end user.
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// The mobile number of the end user.
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// The display name of the end user.
                /// </summary>
                [NameInMap("RealNickName")]
                [Validation(Required=false)]
                public string RealNickName { get; set; }

                /// <summary>
                /// The remarks of the end user.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            /// <summary>
            /// Details of the convenience users that failed to be created.
            /// </summary>
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<CreateUsersResponseBodyCreateResultFailedUsers> FailedUsers { get; set; }
            public class CreateUsersResponseBodyCreateResultFailedUsers : TeaModel {
                /// <summary>
                /// The email address of the end user.
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// The name of the end user.
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// The error code returned if the request failed.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message returned.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The mobile number of the end user.
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
