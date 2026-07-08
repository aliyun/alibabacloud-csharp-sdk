// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunCommentGenerationResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the response is complete.</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public bool? End { get; set; }

        /// <summary>
        /// <para>Response header.</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunCommentGenerationResponseBodyHeader Header { get; set; }
        public class RunCommentGenerationResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>Event name.</para>
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
            /// <para>可空</para>
            /// </summary>
            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <para>Request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>Session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0bd58ea2-dc38-45da-ac02-17f05cb9040b</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>Response body.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunCommentGenerationResponseBodyPayload Payload { get; set; }
        public class RunCommentGenerationResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>Output data.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunCommentGenerationResponseBodyPayloadOutput Output { get; set; }
            public class RunCommentGenerationResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>Generated comment text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>评论内容</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>Token usage.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunCommentGenerationResponseBodyPayloadUsage Usage { get; set; }
            public class RunCommentGenerationResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>Number of input tokens used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>Number of output tokens used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>Total number of tokens used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
