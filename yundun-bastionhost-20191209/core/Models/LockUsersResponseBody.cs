// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class LockUsersResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the call.
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<LockUsersResponseBodyResults> Results { get; set; }
        public class LockUsersResponseBodyResults : TeaModel {
            /// <summary>
            /// The return code that indicates whether the call was successful. Valid values:
            /// 
            /// *   **OK**: The call was successful.
            /// 
            /// *   **UNEXPECTED**: An unknown error occurred.
            /// 
            /// *   **INVALID_ARGUMENT**: A request parameter is invalid.
            /// 
            ///     **
            /// 
            ///     **Note**Make sure that the request parameters are valid and call the operation again.
            /// 
            /// *   **OBJECT_NOT_FOUND**: The specified object on which you want to perform the operation does not exist.
            /// 
            ///     **
            /// 
            ///     **Note**Check whether the specified ID of the bastion host exists, whether the specified hosts exist, and whether the specified host IDs are valid. Then, call the operation again.
            /// 
            /// *   **OBJECT_AlREADY_EXISTS**: The specified object on which you want to perform the operation already exists.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
