// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CheckLiveMessageUsersOnlineResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>178F572F-AECF-100B-937A-B8047B4D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of users queried.</para>
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<CheckLiveMessageUsersOnlineResponseBodyUserList> UserList { get; set; }
        public class CheckLiveMessageUsersOnlineResponseBodyUserList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the user is online.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uid1</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
