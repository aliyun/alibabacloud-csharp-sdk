// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListUsersForApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The IDs of the accounts.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListUsersForApplicationResponseBodyUsers> Users { get; set; }
        public class ListUsersForApplicationResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>应用角色列表。</para>
            /// </summary>
            [NameInMap("ApplicationRoles")]
            [Validation(Required=false)]
            public List<ListUsersForApplicationResponseBodyUsersApplicationRoles> ApplicationRoles { get; set; }
            public class ListUsersForApplicationResponseBodyUsersApplicationRoles : TeaModel {
                /// <summary>
                /// <para>应用角色标识。</para>
                /// 
                /// <b>Example:</b>
                /// <para>app_role_mkv7rgt4ds8d8v0qtzev2mxxxx</para>
                /// </summary>
                [NameInMap("ApplicationRoleId")]
                [Validation(Required=false)]
                public string ApplicationRoleId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
