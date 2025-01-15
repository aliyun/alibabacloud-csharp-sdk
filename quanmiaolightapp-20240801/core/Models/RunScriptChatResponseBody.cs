// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunScriptChatResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public bool? End { get; set; }

        [NameInMap("header")]
        [Validation(Required=false)]
        public RunScriptChatResponseBodyHeader Header { get; set; }
        public class RunScriptChatResponseBodyHeader : TeaModel {
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
            /// <para>result-generated</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("eventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>F8A35034-EDCF-5C50-95A5-1044316F36E3</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>147648697127_914847410985_1730600302167</para>
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
            /// <para>2150432017236011824686132ecdbc</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("payload")]
        [Validation(Required=false)]
        public RunScriptChatResponseBodyPayload Payload { get; set; }
        public class RunScriptChatResponseBodyPayload : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public RunScriptChatResponseBodyPayloadOutput Output { get; set; }
            public class RunScriptChatResponseBodyPayloadOutput : TeaModel {
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public RunScriptChatResponseBodyPayloadUsage Usage { get; set; }
            public class RunScriptChatResponseBodyPayloadUsage : TeaModel {
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
