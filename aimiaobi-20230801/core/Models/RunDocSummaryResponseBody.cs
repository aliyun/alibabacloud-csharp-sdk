// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDocSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>response header</para>
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public RunDocSummaryResponseBodyHeader Header { get; set; }
        public class RunDocSummaryResponseBodyHeader : TeaModel {
            /// <summary>
            /// <para>error code</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>error message</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Type of management event</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-started</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <para>Description of the management event</para>
            /// 
            /// <b>Example:</b>
            /// <para>模型生成事件</para>
            /// </summary>
            [NameInMap("EventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <para>session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>92e16ccb-92b6-4894-abbf-fc6e2929a0df</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>Job ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>b057f2fa-2277-477b-babf-cbc062307828</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>End-to-end trace ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>2150451a17191950923411783e2927</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>response body</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public RunDocSummaryResponseBodyPayload Payload { get; set; }
        public class RunDocSummaryResponseBodyPayload : TeaModel {
            /// <summary>
            /// <para>Outputs</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public RunDocSummaryResponseBodyPayloadOutput Output { get; set; }
            public class RunDocSummaryResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <para>Summary content</para>
                /// 
                /// <b>Example:</b>
                /// <para>总结内容</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }

            /// <summary>
            /// <para>LLM token usage information</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public RunDocSummaryResponseBodyPayloadUsage Usage { get; set; }
            public class RunDocSummaryResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <para>Quantity of tokens used in the input</para>
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
        /// <para>3259D344-E871-5DE0-8FFE-CDA21F8D4382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
