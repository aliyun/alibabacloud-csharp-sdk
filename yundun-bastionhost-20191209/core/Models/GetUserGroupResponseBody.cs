// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the user group returned.</para>
        /// </summary>
        [NameInMap("UserGroup")]
        [Validation(Required=false)]
        public GetUserGroupResponseBodyUserGroup UserGroup { get; set; }
        public class GetUserGroupResponseBodyUserGroup : TeaModel {
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
            /// <para>The ID of the group.</para>
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
            /// <para>UserGroup01</para>
            /// </summary>
            [NameInMap("UserGroupName")]
            [Validation(Required=false)]
            public string UserGroupName { get; set; }

        }

    }

}
