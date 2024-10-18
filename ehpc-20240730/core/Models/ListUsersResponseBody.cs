// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The information about the users.</para>
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
                /// <para>The time when the user was first added.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2014-08-22T17:46:47</para>
                /// </summary>
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public string AddTime { get; set; }

                /// <summary>
                /// <para>The name of the permission group. Valid values:</para>
                /// <para>users: ordinary permissions, which are suitable for regular users that need only to submit and debug jobs.</para>
                /// <para>wheel: sudo permissions, which are suitable for administrators who need to manage clusters. In addition to submitting and debugging jobs, you can also run sudo commands to install software and restart nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>users</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// <para>The permission group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testuser</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
