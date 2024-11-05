// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListUserGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of user groups returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The user groups returned.</para>
        /// </summary>
        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<ListUserGroupsResponseBodyUserGroups> UserGroups { get; set; }
        public class ListUserGroupsResponseBodyUserGroups : TeaModel {
            /// <summary>
            /// <para>The description of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The number of users in the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MemberCount")]
            [Validation(Required=false)]
            public int? MemberCount { get; set; }

            /// <summary>
            /// <para>The ID of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

            /// <summary>
            /// <para>The name of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestGroup01</para>
            /// </summary>
            [NameInMap("UserGroupName")]
            [Validation(Required=false)]
            public string UserGroupName { get; set; }

        }

    }

}
