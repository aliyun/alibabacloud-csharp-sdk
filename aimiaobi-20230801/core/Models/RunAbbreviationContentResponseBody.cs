// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunAbbreviationContentResponseBody : TeaModel {
        [NameInMap("End")]
        [Validation(Required=false)]
        public bool? End { get; set; }

        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunAbbreviationContentResponseBodyHeader Header { get; set; }
        public class RunAbbreviationContentResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>403</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pop sign mismatch, please check.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>result-generated</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>模型生成事件</para>
            /// </summary>
            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3cd10828-0e42-471c-8f1a-931cde20b035</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d3be9981-ca2d-4e17-bf31-1c0a628e9f99</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2150451a17191950923411783e2927</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunAbbreviationContentResponseBodyPayload Payload { get; set; }
        public class RunAbbreviationContentResponseBodyPayload : TeaModel {
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunAbbreviationContentResponseBodyPayloadOutput Output { get; set; }
            public class RunAbbreviationContentResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>这是测试输出</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunAbbreviationContentResponseBodyPayloadUsage Usage { get; set; }
            public class RunAbbreviationContentResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d3be9981-ca2d-4e17-bf31-1c0a628e9f99</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
