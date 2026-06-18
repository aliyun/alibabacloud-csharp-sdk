// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListChatRecordDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A return value of 200 indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("ResultData")]
        [Validation(Required=false)]
        public ListChatRecordDetailResponseBodyResultData ResultData { get; set; }
        public class ListChatRecordDetailResponseBodyResultData : TeaModel {
            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>Query result data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListChatRecordDetailResponseBodyResultDataData> Data { get; set; }
            public class ListChatRecordDetailResponseBodyResultDataData : TeaModel {
                /// <summary>
                /// <para>Online End Time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614578410000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>A list of detailed online session information.</para>
                /// </summary>
                [NameInMap("MessageList")]
                [Validation(Required=false)]
                public List<ListChatRecordDetailResponseBodyResultDataDataMessageList> MessageList { get; set; }
                public class ListChatRecordDetailResponseBodyResultDataDataMessageList : TeaModel {
                    /// <summary>
                    /// <para>The content of the sent message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>你好</para>
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
                    /// <para>Message type.</para>
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
                    /// <para>The type of sender. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: Membership</description></item>
                    /// <item><description><b>2</b>: Customer service</description></item>
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
                /// <para>Servicer Account</para>
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
            /// <para>Page size</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OnePageSize")]
            [Validation(Required=false)]
            public long? OnePageSize { get; set; }

            /// <summary>
            /// <para>Total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public long? TotalResults { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
