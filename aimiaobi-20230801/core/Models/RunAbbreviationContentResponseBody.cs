// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunAbbreviationContentResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the output is complete. True means it is complete.</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public bool? End { get; set; }

        /// <summary>
        /// <para>The streaming output header, which contains general return information.</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunAbbreviationContentResponseBodyHeader Header { get; set; }
        public class RunAbbreviationContentResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>Error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>403</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>Error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pop sign mismatch, please check.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>result-generated</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>Event description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>模型生成事件</para>
            /// </summary>
            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <para>The session ID for a single session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3cd10828-0e42-471c-8f1a-931cde20b035</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The task ID for a single generation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d3be9981-ca2d-4e17-bf31-1c0a628e9f99</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Trace ID for the request chain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2150451a17191950923411783e2927</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>Result payload, JSON structure</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunAbbreviationContentResponseBodyPayload Payload { get; set; }
        public class RunAbbreviationContentResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>Output content object.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunAbbreviationContentResponseBodyPayloadOutput Output { get; set; }
            public class RunAbbreviationContentResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>Output content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是测试输出</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>Large Language Model (LLM) token usage information.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunAbbreviationContentResponseBodyPayloadUsage Usage { get; set; }
            public class RunAbbreviationContentResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>Number of input tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>Number of output tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>Total number of tokens.</para>
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
        /// <para>Unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d3be9981-ca2d-4e17-bf31-1c0a628e9f99</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
