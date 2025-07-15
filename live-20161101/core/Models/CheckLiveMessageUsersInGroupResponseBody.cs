// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CheckLiveMessageUsersInGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F1F68D81-1543-1FE4-B56E-82200DD2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of users queried.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<CheckLiveMessageUsersInGroupResponseBodyUsers> Users { get; set; }
        public class CheckLiveMessageUsersInGroupResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>Indicates whether the user is in the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
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
