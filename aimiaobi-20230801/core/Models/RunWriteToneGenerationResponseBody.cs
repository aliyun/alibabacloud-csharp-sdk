// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunWriteToneGenerationResponseBody : TeaModel {
        /// <summary>
        /// <para>Response headers.</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunWriteToneGenerationResponseBodyHeader Header { get; set; }
        public class RunWriteToneGenerationResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>Error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccessForbid</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>Error message returned when the call fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Server-sent event (SSE).</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-failed</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>Session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F1953EE6-157C-40DC-BBF1-87C98AC27C51</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F1953EE6-157C-40DC-BBF1-87C98AC27C51</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>End-to-end trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F1953EE6-157C-40DC-BBF1-87C98AC27C51</para>
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
        public RunWriteToneGenerationResponseBodyPayload Payload { get; set; }
        public class RunWriteToneGenerationResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>Output data.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunWriteToneGenerationResponseBodyPayloadOutput Output { get; set; }
            public class RunWriteToneGenerationResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>Generated text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
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
            public RunWriteToneGenerationResponseBodyPayloadUsage Usage { get; set; }
            public class RunWriteToneGenerationResponseBodyPayloadUsage : TeaModel {
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>Total number of tokens used in this call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
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
        /// <para>FB698445-61DA-5361-BF73-1C5F1157E888</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
