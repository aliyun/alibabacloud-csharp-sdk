// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of message objects.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetMessagesResponseBodyData> Data { get; set; }
        public class GetMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AI-generated response to the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>您询问的实例rm-bp14as9914vd3**** 磁盘使用率为23%，暂时不需要进行扩容。如果您需要进一步查看某个实例的详细配置、性能监控或进行其他操作，请告诉我具体需求！</para>
            /// </summary>
            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            /// <summary>
            /// <para>The unique identifier for the conversation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9cbbe885-b240-4803-9d15-6781a3fd****</para>
            /// </summary>
            [NameInMap("ConversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            /// <summary>
            /// <para>The Unix timestamp (in seconds) when the message was created.</para>
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
            /// <para>The user\&quot;s feedback on the answer, such as &quot;like&quot; or &quot;dislike&quot;.</para>
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
            /// <para>The unique identifier for the message.</para>
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

            /// <summary>
            /// <para>The user\&quot;s query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>实例rm-bp14as9914vd3**** 磁盘使用率，是否需要扩容</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The resources that were retrieved to generate the answer.</para>
            /// </summary>
            [NameInMap("RetrieverResources")]
            [Validation(Required=false)]
            public List<object> RetrieverResources { get; set; }

            [NameInMap("StreamKey")]
            [Validation(Required=false)]
            public string StreamKey { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether there are more messages to retrieve.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The value of the Limit parameter used for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>The unique identifier for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
