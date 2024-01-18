// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListUsersAsyncResponseBody : TeaModel {
        /// <summary>
        /// The ID of the asynchronous task.
        /// </summary>
        [NameInMap("AsyncId")]
        [Validation(Required=false)]
        public string AsyncId { get; set; }

        /// <summary>
        /// The status of the asynchronous task.
        /// </summary>
        [NameInMap("AsyncStatus")]
        [Validation(Required=false)]
        public string AsyncStatus { get; set; }

        /// <summary>
        /// The number of the page returned. Pages start from page 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of users.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The list of users.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListUsersAsyncResponseBodyUsers Users { get; set; }
        public class ListUsersAsyncResponseBodyUsers : TeaModel {
            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public List<ListUsersAsyncResponseBodyUsersUserInfo> UserInfo { get; set; }
            public class ListUsersAsyncResponseBodyUsersUserInfo : TeaModel {
                /// <summary>
                /// The time when the user was created.
                /// </summary>
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public string AddTime { get; set; }

                /// <summary>
                /// The user groups.
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// The user group ID.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The username of the account.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
