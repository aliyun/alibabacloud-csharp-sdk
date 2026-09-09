// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class DebugModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. The value SUCCESS indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The model debugging result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public DebugModelResponseBodyData Data { get; set; }
        public class DebugModelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The model connection ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mc-1</para>
            /// </summary>
            [NameInMap("connectionId")]
            [Validation(Required=false)]
            public string ConnectionId { get; set; }

            /// <summary>
            /// <para>Indicates whether the model debugging was successful.</para>
            /// </summary>
            [NameInMap("debugSuccess")]
            [Validation(Required=false)]
            public bool? DebugSuccess { get; set; }

            /// <summary>
            /// <para>The error code returned when debugging fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPSTREAM_MODEL_ERROR</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when debugging fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The model endpoint rejected the debug request.</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The number of input tokens consumed by this model debugging request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("inputTokens")]
            [Validation(Required=false)]
            public long? InputTokens { get; set; }

            /// <summary>
            /// <para>The time consumed by this model debugging call, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("latencyMs")]
            [Validation(Required=false)]
            public long? LatencyMs { get; set; }

            /// <summary>
            /// <para>The model ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model-1</para>
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// <para>The number of output tokens consumed by this model debugging response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("outputTokens")]
            [Validation(Required=false)]
            public long? OutputTokens { get; set; }

            /// <summary>
            /// <para>The text response returned by the model when debugging succeeds. This value is empty when debugging fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("response")]
            [Validation(Required=false)]
            public string Response { get; set; }

            /// <summary>
            /// <para>The debug result status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. The value 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request processing result message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
