// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunGenerateQuestionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Response header</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunGenerateQuestionsResponseBodyHeader Header { get; set; }
        public class RunGenerateQuestionsResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>Error code</para>
            /// 
            /// <b>Example:</b>
            /// <para>RateLimit</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>Error message returned when the call fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Event name</para>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>Event description</para>
            /// 
            /// <b>Example:</b>
            /// <para>模型生成事件</para>
            /// </summary>
            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <para>Session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3cd10828-0e42-471c-8f1a-931cde20b035</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>Task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>d3be9981-ca2d-4e17-bf31-1c0a628e9f99</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Trace ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>0bc3b4b417362160345997589e5f6e</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>Response body</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunGenerateQuestionsResponseBodyPayload Payload { get; set; }
        public class RunGenerateQuestionsResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>Outputs</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunGenerateQuestionsResponseBodyPayloadOutput Output { get; set; }
            public class RunGenerateQuestionsResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>Question content</para>
                /// 
                /// <b>Example:</b>
                /// <para>问题1\n问题2\n问题3\n</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }

            /// <summary>
            /// <para>Token usage</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunGenerateQuestionsResponseBodyPayloadUsage Usage { get; set; }
            public class RunGenerateQuestionsResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>Number of input tokens used</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>Number of output tokens</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>Total number of tokens</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
