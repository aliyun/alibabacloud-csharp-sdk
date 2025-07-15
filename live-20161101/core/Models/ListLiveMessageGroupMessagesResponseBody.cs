// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveMessageGroupMessagesResponseBody : TeaModel {
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
        /// <para>Details about the messages.</para>
        /// </summary>
        [NameInMap("MessageList")]
        [Validation(Required=false)]
        public List<ListLiveMessageGroupMessagesResponseBodyMessageList> MessageList { get; set; }
        public class ListLiveMessageGroupMessagesResponseBodyMessageList : TeaModel {
            /// <summary>
            /// <para>The message body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>step2 helo, cc group</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// <para>The ID of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-1-1-0</para>
            /// </summary>
            [NameInMap("MsgTid")]
            [Validation(Required=false)]
            public string MsgTid { get; set; }

            /// <summary>
            /// <para>The type of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MsgType")]
            [Validation(Required=false)]
            public long? MsgType { get; set; }

            /// <summary>
            /// <para>The details about the user who sent the message.</para>
            /// </summary>
            [NameInMap("Sender")]
            [Validation(Required=false)]
            public ListLiveMessageGroupMessagesResponseBodyMessageListSender Sender { get; set; }
            public class ListLiveMessageGroupMessagesResponseBodyMessageListSender : TeaModel {
                /// <summary>
                /// <para>The ID of the user who sent the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>uid2</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The additional information about the user who sent the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testusermeta2</para>
                /// </summary>
                [NameInMap("UserInfo")]
                [Validation(Required=false)]
                public string UserInfo { get; set; }

            }

            /// <summary>
            /// <para>The sequence number of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SeqNumber")]
            [Validation(Required=false)]
            public long? SeqNumber { get; set; }

            /// <summary>
            /// <para>The time when the message was sent. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1697081134</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The total number of messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalMessages")]
            [Validation(Required=false)]
            public long? TotalMessages { get; set; }

        }

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
        /// <para>1668FDC3-63D7-102F-B5D4-3D2F91D1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
