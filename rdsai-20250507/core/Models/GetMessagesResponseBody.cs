// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The query results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetMessagesResponseBodyData> Data { get; set; }
        public class GetMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reply.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The instance rm-bp14as9914vd3**** you inquired about has a disk usage of 23%, so no storage expansion is needed at the moment. If you need to view detailed configurations, check performance monitoring, or perform other operations on a specific instance, please let me know your specific requirements.</para>
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
            /// <para>The time when the message was created. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1763986004</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The list of events.</para>
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<GetMessagesResponseBodyDataEvents> Events { get; set; }
            public class GetMessagesResponseBodyDataEvents : TeaModel {
                /// <summary>
                /// <para>The tool invocation approval status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pending</para>
                /// </summary>
                [NameInMap("ApprovalStatus")]
                [Validation(Required=false)]
                public string ApprovalStatus { get; set; }

                /// <summary>
                /// <para>The tool invocation ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>call-example</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>The conversation ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>conversation-example</para>
                /// </summary>
                [NameInMap("ConversationId")]
                [Validation(Required=false)]
                public string ConversationId { get; set; }

                /// <summary>
                /// <para>The tool invocation description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Search ContextDB records</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The message ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>message-example</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <para>The tool approval round ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>round-example</para>
                /// </summary>
                [NameInMap("RoundId")]
                [Validation(Required=false)]
                public string RoundId { get; set; }

                /// <summary>
                /// <para>The tool invocation parameters.</para>
                /// </summary>
                [NameInMap("ToolArguments")]
                [Validation(Required=false)]
                public Dictionary<string, object> ToolArguments { get; set; }

                /// <summary>
                /// <para>The tool name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>contextdb.search</para>
                /// </summary>
                [NameInMap("ToolName")]
                [Validation(Required=false)]
                public string ToolName { get; set; }

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

                /// <summary>
                /// <para>The uploaded file ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file-example</para>
                /// </summary>
                [NameInMap("UploadFileId")]
                [Validation(Required=false)]
                public string UploadFileId { get; set; }

            }

            /// <summary>
            /// <para>The query statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Disk usage of instance rm-bp14as9914vd3**** and whether capacity expansion is required</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The retrieved resources.</para>
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
        /// <para>The maximum number of query results.</para>
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
