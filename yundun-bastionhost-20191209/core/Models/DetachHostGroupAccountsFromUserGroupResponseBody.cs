// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DetachHostGroupAccountsFromUserGroupResponseBody : TeaModel {
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
        public List<DetachHostGroupAccountsFromUserGroupResponseBodyResults> Results { get; set; }
        public class DetachHostGroupAccountsFromUserGroupResponseBodyResults : TeaModel {
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
            /// The result of revoking permissions on the specified host accounts from the user group.
            /// </summary>
            [NameInMap("HostAccountNames")]
            [Validation(Required=false)]
            public List<DetachHostGroupAccountsFromUserGroupResponseBodyResultsHostAccountNames> HostAccountNames { get; set; }
            public class DetachHostGroupAccountsFromUserGroupResponseBodyResultsHostAccountNames : TeaModel {
                /// <summary>
                /// The return code that indicates whether permissions on the specified host account were revoked from the specified user group. Valid values:
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
                /// The name of the host account.
                /// </summary>
                [NameInMap("HostAccountName")]
                [Validation(Required=false)]
                public string HostAccountName { get; set; }

                /// <summary>
                /// This parameter is deprecated.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// The ID of the host group.
            /// </summary>
            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The ID of the group.
            /// </summary>
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

    }

}
