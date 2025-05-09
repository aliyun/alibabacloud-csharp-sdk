// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListVisitorChatMessagesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVisitorChatMessagesResponseBodyData Data { get; set; }
        public class ListVisitorChatMessagesResponseBodyData : TeaModel {
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ListVisitorChatMessagesResponseBodyDataMessages> Messages { get; set; }
            public class ListVisitorChatMessagesResponseBodyDataMessages : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>chat-65382141036853491</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxxxx.com/avatar.png">http://xxxxx.com/avatar.png</a></para>
                /// </summary>
                [NameInMap("SenderAvatarUrl")]
                [Validation(Required=false)]
                public string SenderAvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fcd020fe-****-1a272a174a7d</para>
                /// </summary>
                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                [NameInMap("SenderName")]
                [Validation(Required=false)]
                public string SenderName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CUSTOMER</para>
                /// </summary>
                [NameInMap("SenderType")]
                [Validation(Required=false)]
                public string SenderType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1696126980371</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1737193352340::7463707254.EAUNIT</para>
            /// </summary>
            [NameInMap("NextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8707EB29-BAED-4302-B999-40BA61877437</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
