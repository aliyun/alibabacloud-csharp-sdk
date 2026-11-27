// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListChatRecordDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("ResultData")]
        [Validation(Required=false)]
        public ListChatRecordDetailResponseBodyResultData ResultData { get; set; }
        public class ListChatRecordDetailResponseBodyResultData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>The query result.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListChatRecordDetailResponseBodyResultDataData> Data { get; set; }
            public class ListChatRecordDetailResponseBodyResultDataData : TeaModel {
                /// <summary>
                /// <para>The end time of the online session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614578410000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The list of online session details.</para>
                /// </summary>
                [NameInMap("MessageList")]
                [Validation(Required=false)]
                public List<ListChatRecordDetailResponseBodyResultDataDataMessageList> MessageList { get; set; }
                public class ListChatRecordDetailResponseBodyResultDataDataMessageList : TeaModel {
                    /// <summary>
                    /// <para>The content of the sent message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hello</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The time when the message was sent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1614578400000</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The message type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MSG</para>
                    /// </summary>
                    [NameInMap("MsgType")]
                    [Validation(Required=false)]
                    public string MsgType { get; set; }

                    /// <summary>
                    /// <para>The account that sent the message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>account1</para>
                    /// </summary>
                    [NameInMap("SenderName")]
                    [Validation(Required=false)]
                    public string SenderName { get; set; }

                    /// <summary>
                    /// <para>The type of the sender. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: customer.</description></item>
                    /// <item><description><b>2</b>: customer service representative.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("SenderType")]
                    [Validation(Required=false)]
                    public long? SenderType { get; set; }

                }

                /// <summary>
                /// <para>The account of the customer service representative.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:123@123.com">123@123.com</a></para>
                /// </summary>
                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                /// <summary>
                /// <para>The start time of the online session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614578400000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OnePageSize")]
            [Validation(Required=false)]
            public long? OnePageSize { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public long? TotalResults { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the API call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
