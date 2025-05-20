// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetChatListResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data structure.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetChatListResponseBodyData Data { get; set; }
        public class GetChatListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Q&amp;A list.</para>
            /// </summary>
            [NameInMap("chatList")]
            [Validation(Required=false)]
            public List<ChatItem> ChatList { get; set; }

            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>Page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// <para>Total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("totalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
