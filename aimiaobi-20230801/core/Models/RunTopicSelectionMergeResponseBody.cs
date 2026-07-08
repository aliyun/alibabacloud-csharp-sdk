// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunTopicSelectionMergeResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the response packet is complete</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public bool? End { get; set; }

        /// <summary>
        /// <para>Response header</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunTopicSelectionMergeResponseBodyHeader Header { get; set; }
        public class RunTopicSelectionMergeResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>Error code</para>
            /// 
            /// <b>Example:</b>
            /// <para>错误码</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>Error message</para>
            /// 
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>SSE event. Values: task-started, task-finished, or task-failed</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-started</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>Parent session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("OriginSessionId")]
            [Validation(Required=false)]
            public string OriginSessionId { get; set; }

            /// <summary>
            /// <para>Session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>HTTP status code</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public int? StatusCode { get; set; }

            /// <summary>
            /// <para>Task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>End-to-end trace ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>全链路ID</para>
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
        public RunTopicSelectionMergeResponseBodyPayload Payload { get; set; }
        public class RunTopicSelectionMergeResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>Output</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunTopicSelectionMergeResponseBodyPayloadOutput Output { get; set; }
            public class RunTopicSelectionMergeResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>Text generation result</para>
                /// 
                /// <b>Example:</b>
                /// <para>文本生成结果</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>Merged topic selection object</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public TopicSelection Topic { get; set; }

            }

            /// <summary>
            /// <para>Token usage</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunTopicSelectionMergeResponseBodyPayloadUsage Usage { get; set; }
            public class RunTopicSelectionMergeResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>Number of input tokens</para>
                /// 
                /// <b>Example:</b>
                /// <para>78</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>Number of output tokens used</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>Detailed token consumption</para>
                /// </summary>
                [NameInMap("TokenMap")]
                [Validation(Required=false)]
                public Dictionary<string, long?> TokenMap { get; set; }

                /// <summary>
                /// <para>Total number of tokens used in this call</para>
                /// 
                /// <b>Example:</b>
                /// <para>38</para>
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
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
