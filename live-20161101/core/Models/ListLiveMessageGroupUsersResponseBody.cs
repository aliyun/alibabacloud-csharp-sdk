// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveMessageGroupUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the group queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grouptest</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current page is followed by another page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Hasmore")]
        [Validation(Required=false)]
        public bool? Hasmore { get; set; }

        /// <summary>
        /// <para>The starting page number for the next query. A value of 0 indicates that no further pages can be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public long? NextPageToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1D75BEA-1329-116F-B29C-76F3F200****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details about the users.</para>
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<ListLiveMessageGroupUsersResponseBodyUserList> UserList { get; set; }
        public class ListLiveMessageGroupUsersResponseBodyUserList : TeaModel {
            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uid1</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The additional information about the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>info1</para>
            /// </summary>
            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public string UserInfo { get; set; }

        }

    }

}
