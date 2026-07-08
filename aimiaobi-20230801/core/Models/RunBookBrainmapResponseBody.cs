// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunBookBrainmapResponseBody : TeaModel {
        /// <summary>
        /// <para>The response header.</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunBookBrainmapResponseBodyHeader Header { get; set; }
        public class RunBookBrainmapResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-failed</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>The event description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>模型生成事件</para>
            /// </summary>
            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3cd10828-0e42-471c-8f1a-931cde20b035</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0bc1409b17210096103458421ec62e</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>The response payload.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunBookBrainmapResponseBodyPayload Payload { get; set; }
        public class RunBookBrainmapResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>The generated output.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunBookBrainmapResponseBodyPayloadOutput Output { get; set; }
            public class RunBookBrainmapResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>The mind map content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;xxxx&quot;:&quot;xxx&quot;}</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }

            /// <summary>
            /// <para>Details about token usage.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunBookBrainmapResponseBodyPayloadUsage Usage { get; set; }
            public class RunBookBrainmapResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>The input token count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The output token count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>The total token count.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
