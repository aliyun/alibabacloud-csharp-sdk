// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListAuthorizedUsersForDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE8EE2F1-4880-46BC-A704-5CF63EAF9A04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of users that have permissions on the specified instance.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListAuthorizedUsersForDatabaseResponseBodyUsers> Users { get; set; }
        public class ListAuthorizedUsersForDatabaseResponseBodyUsers : TeaModel {
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
            /// <para>The user IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51****</para>
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

        }

    }

}
