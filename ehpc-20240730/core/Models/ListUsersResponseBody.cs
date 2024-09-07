// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The information about the users.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListUsersResponseBodyUsers Users { get; set; }
        public class ListUsersResponseBodyUsers : TeaModel {
            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyUsersUserInfo> UserInfo { get; set; }
            public class ListUsersResponseBodyUsersUserInfo : TeaModel {
                /// <summary>
                /// The time when the user was first added.
                /// </summary>
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public string AddTime { get; set; }

                /// <summary>
                /// The name of the permission group. Valid values:
                /// 
                /// users: ordinary permissions, which are suitable for regular users that need only to submit and debug jobs.
                /// 
                /// wheel: sudo permissions, which are suitable for administrators who need to manage clusters. In addition to submitting and debugging jobs, you can also run sudo commands to install software and restart nodes.
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// The permission group ID.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// The username.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
