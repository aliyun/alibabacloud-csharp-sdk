// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetMessagesResponseBodyData> Data { get; set; }
        public class GetMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The response to the query.</para>
            /// </summary>
            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            /// <summary>
            /// <para>The ID of the conversation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9cbbe885-b240-4803-9d15-6781a3fd****</para>
            /// </summary>
            [NameInMap("ConversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            /// <summary>
            /// <para>The creation time of the conversation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1763986004</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<GetMessagesResponseBodyDataEvents> Events { get; set; }
            public class GetMessagesResponseBodyDataEvents : TeaModel {
                [NameInMap("answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                [NameInMap("event")]
                [Validation(Required=false)]
                public string Event { get; set; }

            }

            /// <summary>
            /// <para>The feedback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>like</para>
            /// </summary>
            [NameInMap("Feedback")]
            [Validation(Required=false)]
            public string Feedback { get; set; }

            /// <summary>
            /// <para>The message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>84dc9f9b-424a-404d-9c36-35e9d000****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The query statement.</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The retriever resources.</para>
            /// </summary>
            [NameInMap("RetrieverResources")]
            [Validation(Required=false)]
            public List<object> RetrieverResources { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the current page is followed by a page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
