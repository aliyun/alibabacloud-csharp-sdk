// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListMessageGroupUserByIdResponseBody : TeaModel {
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
        /// <para>Return result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListMessageGroupUserByIdResponseBodyResult Result { get; set; }
        public class ListMessageGroupUserByIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether there is a next page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: There is a next page.</para>
            /// </description></item>
            /// <item><description><para>false: There is no next page.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>Total number of users queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            /// <summary>
            /// <para>User list information.</para>
            /// </summary>
            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<ListMessageGroupUserByIdResponseBodyResultUserList> UserList { get; set; }
            public class ListMessageGroupUserByIdResponseBodyResultUserList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the user is muted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Muted.</para>
                /// </description></item>
                /// <item><description><para>false: Not muted.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsMute")]
                [Validation(Required=false)]
                public bool? IsMute { get; set; }

                /// <summary>
                /// <para>Mute type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>group: All members in the message group are muted.</para>
                /// </description></item>
                /// <item><description><para>user: Individual user is muted.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("MuteBy")]
                [Validation(Required=false)]
                public List<string> MuteBy { get; set; }

                /// <summary>
                /// <para>Profile picture URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;<a href="http://www.aliyundoc.com/xxyy.png">http://www.aliyundoc.com/xxyy.png</a>&quot;</para>
                /// </summary>
                [NameInMap("UserAvatar")]
                [Validation(Required=false)]
                public string UserAvatar { get; set; }

                /// <summary>
                /// <para>Custom user information content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12e</para>
                /// </summary>
                [NameInMap("UserExtension")]
                [Validation(Required=false)]
                public string UserExtension { get; set; }

                /// <summary>
                /// <para>User ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ad***</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>User nickname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxyy</para>
                /// </summary>
                [NameInMap("UserNick")]
                [Validation(Required=false)]
                public string UserNick { get; set; }

            }

        }

    }

}
