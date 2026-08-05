// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListMessageGroupUserResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-****-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListMessageGroupUserResponseBodyResult Result { get; set; }
        public class ListMessageGroupUserResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether there is a next page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: There is a next page.</description></item>
            /// <item><description>false: There is no next page.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>Total number of message group users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            /// <summary>
            /// <para>User list.</para>
            /// </summary>
            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<ListMessageGroupUserResponseBodyResultUserList> UserList { get; set; }
            public class ListMessageGroupUserResponseBodyResultUserList : TeaModel {
                /// <summary>
                /// <para>UTC timestamp when the user joined the message group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12**45</para>
                /// </summary>
                [NameInMap("JoinTime")]
                [Validation(Required=false)]
                public long? JoinTime { get; set; }

                /// <summary>
                /// <para>User ID.</para>
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
