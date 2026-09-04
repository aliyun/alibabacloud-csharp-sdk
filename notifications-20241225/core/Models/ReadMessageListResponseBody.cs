// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadMessageListResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned when the call fails. For more information, see error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The execution result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReadMessageListResponseBodyData Data { get; set; }
        public class ReadMessageListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>A reserved field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// <para>A reserved field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public List<ReadMessageListResponseBodyDataRows> Rows { get; set; }
            public class ReadMessageListResponseBodyDataRows : TeaModel {
                /// <summary>
                /// <para>The category code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("CategoryCode")]
                [Validation(Required=false)]
                public string CategoryCode { get; set; }

                /// <summary>
                /// <para>The message category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>活动消息</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <para>A reserved field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Class")]
                [Validation(Required=false)]
                public string Class { get; set; }

                /// <summary>
                /// <para>The message class ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ClassId")]
                [Validation(Required=false)]
                public long? ClassId { get; set; }

                /// <summary>
                /// <para>The message content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;消息内容示例“</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The deletion flag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public int? Deleted { get; set; }

                /// <summary>
                /// <para>The time when the message was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1723772244000</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public long? GmtCreated { get; set; }

                /// <summary>
                /// <para>The time when the message was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1723772244000</para>
                /// </summary>
                [NameInMap("GmtUpdate")]
                [Validation(Required=false)]
                public long? GmtUpdate { get; set; }

                /// <summary>
                /// <para>A reserved field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("MassId")]
                [Validation(Required=false)]
                public long? MassId { get; set; }

                /// <summary>
                /// <para>A reserved field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <para>The message ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3727683838</para>
                /// </summary>
                [NameInMap("MsgId")]
                [Validation(Required=false)]
                public long? MsgId { get; set; }

                /// <summary>
                /// <para>The read status. A value of 0 indicates unread. A value of 1 indicates read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <para>The message title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;标题示例“</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The highlighted title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>title</para>
                /// </summary>
                [NameInMap("Titleh")]
                [Validation(Required=false)]
                public string Titleh { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5F62766-1C2F-1F56-A39D-63E3D30F0633</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values: true: The call was successful. false: The call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
