// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DetachHostAccountsFromUserResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the call.
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<DetachHostAccountsFromUserResponseBodyResults> Results { get; set; }
        public class DetachHostAccountsFromUserResponseBodyResults : TeaModel {
            /// <summary>
            /// The return code that indicates whether the call was successful. Valid values:
            /// 
            /// *   **OK**: The call was successful.
            /// *   **UNEXPECTED**: An unknown error occurred.
            /// *   **INVALID_ARGUMENT**: A request parameter is invalid.
            /// *   **OBJECT_NOT_FOUND**: The specified object on which you want to perform the operation does not exist.
            /// *   **OBJECT_AlREADY_EXISTS**: The specified object on which you want to perform the operation already exists.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The result of revoking permissions on the specified host accounts from the user.
            /// </summary>
            [NameInMap("HostAccounts")]
            [Validation(Required=false)]
            public List<DetachHostAccountsFromUserResponseBodyResultsHostAccounts> HostAccounts { get; set; }
            public class DetachHostAccountsFromUserResponseBodyResultsHostAccounts : TeaModel {
                /// <summary>
                /// The return code that indicates whether permissions on the specified host account were revoked from the user. Valid values:
                /// 
                /// *   **OK**: The call was successful.
                /// *   **UNEXPECTED**: An unknown error occurred.
                /// *   **INVALID_ARGUMENT**: A request parameter is invalid.
                /// *   **OBJECT_NOT_FOUND**: The specified object on which you want to perform the operation does not exist.
                /// *   **OBJECT_AlREADY_EXISTS**: The specified object on which you want to perform the operation already exists.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The ID of the host account.
                /// </summary>
                [NameInMap("HostAccountId")]
                [Validation(Required=false)]
                public string HostAccountId { get; set; }

                /// <summary>
                /// This parameter is deprecated.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// The ID of the host.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

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
