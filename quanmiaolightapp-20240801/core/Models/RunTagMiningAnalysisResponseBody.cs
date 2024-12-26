// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunTagMiningAnalysisResponseBody : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public RunTagMiningAnalysisResponseBodyHeader Header { get; set; }
        public class RunTagMiningAnalysisResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AccessForbidden</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-finished</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("payload")]
        [Validation(Required=false)]
        public RunTagMiningAnalysisResponseBodyPayload Payload { get; set; }
        public class RunTagMiningAnalysisResponseBodyPayload : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public RunTagMiningAnalysisResponseBodyPayloadOutput Output { get; set; }
            public class RunTagMiningAnalysisResponseBodyPayloadOutput : TeaModel {
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public RunTagMiningAnalysisResponseBodyPayloadUsage Usage { get; set; }
            public class RunTagMiningAnalysisResponseBodyPayloadUsage : TeaModel {
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

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>085BE2D2-BB7E-59A6-B688-F2CB32124E7F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
