// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListAuthorizedUsersForInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. You can use the request ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of users that have permissions on the specified instance.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListAuthorizedUsersForInstanceResponseBodyUsers> Users { get; set; }
        public class ListAuthorizedUsersForInstanceResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The UID of the user\&quot;s Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>164882191****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51***</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The nickname of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_test</para>
            /// </summary>
            [NameInMap("UserNickName")]
            [Validation(Required=false)]
            public string UserNickName { get; set; }

            /// <summary>
            /// <para>The real name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user01</para>
            /// </summary>
            [NameInMap("UserRealName")]
            [Validation(Required=false)]
            public string UserRealName { get; set; }

        }

    }

}
