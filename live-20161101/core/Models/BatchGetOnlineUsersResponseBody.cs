// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class BatchGetOnlineUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-****-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public BatchGetOnlineUsersResponseBodyResult Result { get; set; }
        public class BatchGetOnlineUsersResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The array of objects</para>
            /// </summary>
            [NameInMap("OnlineUsers")]
            [Validation(Required=false)]
            public List<BatchGetOnlineUsersResponseBodyResultOnlineUsers> OnlineUsers { get; set; }
            public class BatchGetOnlineUsersResponseBodyResultOnlineUsers : TeaModel {
                /// <summary>
                /// <para>The UTC timestamp when the user joined the message group. Unit: milliseconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>12**45</para>
                /// </summary>
                [NameInMap("JoinTime")]
                [Validation(Required=false)]
                public long? JoinTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the user is online. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The user is online.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The user is offline.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Online")]
                [Validation(Required=false)]
                public bool? Online { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de1**a0</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
