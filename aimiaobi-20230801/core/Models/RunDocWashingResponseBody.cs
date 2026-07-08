// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDocWashingResponseBody : TeaModel {
        /// <summary>
        /// <para>Is the response package finished?</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public bool? End { get; set; }

        /// <summary>
        /// <para>Response header</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunDocWashingResponseBodyHeader Header { get; set; }
        public class RunDocWashingResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>Event type</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-finished</para>
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
            /// <para>Request ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>Session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>20247a52-23e2-46fb-943d-309cdee2bc6d</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

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
            /// <para>Full link ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>2150451a17191950923411783e2927</para>
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
        public RunDocWashingResponseBodyPayload Payload { get; set; }
        public class RunDocWashingResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>Output</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunDocWashingResponseBodyPayloadOutput Output { get; set; }
            public class RunDocWashingResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>Output content</para>
                /// 
                /// <b>Example:</b>
                /// <para>文本生成结果</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>Token consumption</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunDocWashingResponseBodyPayloadUsage Usage { get; set; }
            public class RunDocWashingResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>Number of input tokens</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
