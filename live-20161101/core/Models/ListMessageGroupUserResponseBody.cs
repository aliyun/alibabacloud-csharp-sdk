// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListMessageGroupUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-****-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListMessageGroupUserResponseBodyResult Result { get; set; }
        public class ListMessageGroupUserResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the current page is followed by another page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The current page is followed by another page.</description></item>
            /// <item><description>false: The current page is not followed by another page.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>The total number of users in the message group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            /// <summary>
            /// <para>Details about the users.</para>
            /// </summary>
            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<ListMessageGroupUserResponseBodyResultUserList> UserList { get; set; }
            public class ListMessageGroupUserResponseBodyResultUserList : TeaModel {
                /// <summary>
                /// <para>The time when the user joined the message group. The value is a UTC timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12**45</para>
                /// </summary>
                [NameInMap("JoinTime")]
                [Validation(Required=false)]
                public long? JoinTime { get; set; }

                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de1<b>a0,hu</b>9</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
