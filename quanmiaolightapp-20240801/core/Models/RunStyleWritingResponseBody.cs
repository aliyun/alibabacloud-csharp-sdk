// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunStyleWritingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public bool? End { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;event&quot;:&quot;task-progress-start-generating&quot;,&quot;sessionId&quot;:&quot;3cd10828-0e42-471c-8f1a-931cde20b035&quot;,&quot;taskId&quot;:&quot;d3be9981-ca2d-4e17-bf31-1c0a628e9f99&quot;,&quot;traceId&quot;:&quot;66bef4a7f5d61ff3c43f3b710574e175&quot;}</para>
        /// </summary>
        [NameInMap("header")]
        [Validation(Required=false)]
        public RunStyleWritingResponseBodyHeader Header { get; set; }
        public class RunStyleWritingResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>403</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pop sign mismatch, please check log.</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-progress-start-generating</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("eventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0EB27AE3-CA53-5FAE-83C6-EE66CA4DF5DF</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3cd10828-0e42-471c-8f1a-931cde20b035</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d3be9981-ca2d-4e17-bf31-1c0a628e9f99</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2150451a17191950923411783e2927</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("payload")]
        [Validation(Required=false)]
        public RunStyleWritingResponseBodyPayload Payload { get; set; }
        public class RunStyleWritingResponseBodyPayload : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public RunStyleWritingResponseBodyPayloadOutput Output { get; set; }
            public class RunStyleWritingResponseBodyPayloadOutput : TeaModel {
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///         &quot;inputTokens&quot;: 1816,
            ///         &quot;outputTokens&quot;: 96,
            ///         &quot;totalTokens&quot;: 1912
            ///     }</para>
            /// </summary>
            [NameInMap("usage")]
            [Validation(Required=false)]
            public RunStyleWritingResponseBodyPayloadUsage Usage { get; set; }
            public class RunStyleWritingResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("totalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

    }

}
