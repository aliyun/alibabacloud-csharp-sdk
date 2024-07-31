// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgUserGroupQueryUserListResponseBody : TeaModel {
        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DsgUserGroupQueryUserListResponseBodyData> Data { get; set; }
        public class DsgUserGroupQueryUserListResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the user.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The type of the user. Valid values:
            /// 
            /// *   1 to 5: Alibaba Cloud account
            /// *   6: RAM role
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public int? AccountType { get; set; }

            /// <summary>
            /// The user ID or role ID.
            /// </summary>
            [NameInMap("BaseId")]
            [Validation(Required=false)]
            public string BaseId { get; set; }

            /// <summary>
            /// The parent user ID. This parameter is required if a RAM user is used.
            /// </summary>
            [NameInMap("ParentAccountId")]
            [Validation(Required=false)]
            public string ParentAccountId { get; set; }

            /// <summary>
            /// The name of the Alibaba Cloud account or RAM role. The return value of this parameter must be used if the user group is created by using an Alibaba Cloud account or a RAM role.
            /// </summary>
            [NameInMap("YunAccount")]
            [Validation(Required=false)]
            public string YunAccount { get; set; }

        }

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

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
