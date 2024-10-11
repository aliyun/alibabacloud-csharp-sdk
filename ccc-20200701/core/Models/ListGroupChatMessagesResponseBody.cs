// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListGroupChatMessagesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGroupChatMessagesResponseBodyData Data { get; set; }
        public class ListGroupChatMessagesResponseBodyData : TeaModel {
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ListGroupChatMessagesResponseBodyDataMessages> Messages { get; set; }
            public class ListGroupChatMessagesResponseBodyDataMessages : TeaModel {
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
                /// <para>false</para>
                /// </summary>
                [NameInMap("Recalled")]
                [Validation(Required=false)]
                public bool? Recalled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxxxx.com">http://xxxxx.com</a></para>
                /// </summary>
                [NameInMap("SenderAvatarUrl")]
                [Validation(Required=false)]
                public string SenderAvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>64bb4ececc34fc5ec1ca1153</para>
                /// </summary>
                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-agent@test-instanceId</para>
                /// </summary>
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
            /// <para>54d1a616d95a4a01ba58967a9115b649</para>
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
        /// <b>Example:</b>
        /// <para>2263B273-AC1B-44EB-BA98-87F2322C6780</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
