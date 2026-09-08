// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListVisitorChatMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVisitorChatMessagesResponseBodyData Data { get; set; }
        public class ListVisitorChatMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Message list</para>
            /// </summary>
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ListVisitorChatMessagesResponseBodyDataMessages> Messages { get; set; }
            public class ListVisitorChatMessagesResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// <para>Message content</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;variables&quot;:{},&quot;text&quot;:&quot;Hi，我是小云~ 很高兴遇见你！&quot;,&quot;contentType&quot;:&quot;Text&quot;}</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Call ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>chat-65382141036853491</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>Sender profile picture URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxxx.com/avatar.png">http://xxxxx.com/avatar.png</a></para>
                /// </summary>
                [NameInMap("SenderAvatarUrl")]
                [Validation(Required=false)]
                public string SenderAvatarUrl { get; set; }

                /// <summary>
                /// <para>Sender user ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>fcd020fe-****-1a272a174a7d</para>
                /// </summary>
                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                /// <summary>
                /// <para>Sender name</para>
                /// 
                /// <b>Example:</b>
                /// <para>访客1</para>
                /// </summary>
                [NameInMap("SenderName")]
                [Validation(Required=false)]
                public string SenderName { get; set; }

                /// <summary>
                /// <para>Sender type</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>ADMIN</b>: system</para>
                /// </description></item>
                /// <item><description><para><b>CUSTOMER</b>: visitor</para>
                /// </description></item>
                /// <item><description><para><b>AGENT</b>: agent</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOMER</para>
                /// </summary>
                [NameInMap("SenderType")]
                [Validation(Required=false)]
                public string SenderType { get; set; }

                /// <summary>
                /// <para>UNIX timestamp</para>
                /// 
                /// <b>Example:</b>
                /// <para>1696126980371</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            /// <summary>
            /// <para>Token for the next page</para>
            /// 
            /// <b>Example:</b>
            /// <para>1737193352340::7463707254.EAUNIT</para>
            /// </summary>
            [NameInMap("NextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>8707EB29-BAED-4302-B999-40BA61877437</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
