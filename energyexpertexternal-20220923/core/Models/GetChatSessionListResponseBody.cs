// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetChatSessionListResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetChatSessionListResponseBodyData Data { get; set; }
        public class GetChatSessionListResponseBodyData : TeaModel {
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
            /// <para>分页大小。</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>Session list.</para>
            /// </summary>
            [NameInMap("sessionList")]
            [Validation(Required=false)]
            public List<GetChatSessionListResponseBodyDataSessionList> SessionList { get; set; }
            public class GetChatSessionListResponseBodyDataSessionList : TeaModel {
                /// <summary>
                /// <para>Report creation timestamp, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-01T14:45:17Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Folder ID, used to specify the scope of documents to be queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3493370b-4884-47dd-95ed-49038769af53</para>
                /// </summary>
                [NameInMap("folderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                /// <summary>
                /// <para>Session name</para>
                /// 
                /// <b>Example:</b>
                /// <para>student_app_spelling</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Q&amp;A session ID, used to record multiple Q&amp;As of the same user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5c748ef9-3f23-4b5a-916f-966c0d2c6dcd</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>Modification time, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-30T02:05:03Z</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>User ID of the current session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12222</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

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
            /// <para>Total number of pages</para>
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
