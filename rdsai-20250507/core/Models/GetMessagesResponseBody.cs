// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetMessagesResponseBodyData> Data { get; set; }
        public class GetMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The answer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The disk usage of instance rm-bp14as9914vd3**** is 23%, and scaling is not required for now. If you need to view the detailed configurations or performance monitoring of a specific instance, or perform other operations, let me know your specific requirements!</para>
            /// </summary>
            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            /// <summary>
            /// <para>The conversation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9cbbe885-b240-4803-9d15-6781a3fd****</para>
            /// </summary>
            [NameInMap("ConversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
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

            [NameInMap("GenerationFinishedAt")]
            [Validation(Required=false)]
            public string GenerationFinishedAt { get; set; }

            [NameInMap("GenerationStartedAt")]
            [Validation(Required=false)]
            public string GenerationStartedAt { get; set; }

            [NameInMap("GenerationStatus")]
            [Validation(Required=false)]
            public string GenerationStatus { get; set; }

            /// <summary>
            /// <para>The message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>84dc9f9b-424a-404d-9c36-35e9d000****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("LastSentEntryId")]
            [Validation(Required=false)]
            public string LastSentEntryId { get; set; }

            [NameInMap("MessageFiles")]
            [Validation(Required=false)]
            public List<GetMessagesResponseBodyDataMessageFiles> MessageFiles { get; set; }
            public class GetMessagesResponseBodyDataMessageFiles : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("PreviewUrl")]
                [Validation(Required=false)]
                public string PreviewUrl { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The query statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>What is the disk usage of instance rm-bp14as9914vd3****, and is scaling required?</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The retrieval resources.</para>
            /// </summary>
            [NameInMap("RetrieverResources")]
            [Validation(Required=false)]
            public List<object> RetrieverResources { get; set; }

            [NameInMap("StreamKey")]
            [Validation(Required=false)]
            public string StreamKey { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether there is a next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
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
