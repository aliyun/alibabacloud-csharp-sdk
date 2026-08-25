// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class DebugModelResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public DebugModelResponseBodyData Data { get; set; }
        public class DebugModelResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>mc-1</para>
            /// </summary>
            [NameInMap("connectionId")]
            [Validation(Required=false)]
            public string ConnectionId { get; set; }

            [NameInMap("debugSuccess")]
            [Validation(Required=false)]
            public bool? DebugSuccess { get; set; }

            /// <summary>
            /// <para>调试失败时的错误码。取值：MODEL_CONNECTION_NOT_READY（模型连接尚未发布就绪）、MODEL_CONNECTION_TEST_FAILED（平台调用网关失败）、UPSTREAM_MODEL_NOT_FOUND（模型服务商侧不存在该模型）、UPSTREAM_UNAUTHORIZED（模型服务商拒绝所配置的凭证）、UPSTREAM_RATE_LIMITED（模型服务商限流）、UPSTREAM_SERVER_ERROR（模型服务商服务端错误）、UPSTREAM_HTTP_ERROR（模型服务商返回其它非成功状态）、UPSTREAM_EMPTY_RESPONSE（模型服务商返回空响应）、UPSTREAM_INVALID_RESPONSE（模型服务商响应格式非法）、UPSTREAM_MODEL_ERROR（模型服务商拒绝本次请求）、MODEL_RESPONSE_INVALID（响应解析失败）。</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPSTREAM_MODEL_ERROR</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>调试失败时的错误描述，为固定脱敏文案，不透传模型服务商的原始错误详情。</para>
            /// 
            /// <b>Example:</b>
            /// <para>The model endpoint rejected the debug request.</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("inputTokens")]
            [Validation(Required=false)]
            public long? InputTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("latencyMs")]
            [Validation(Required=false)]
            public long? LatencyMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>model-1</para>
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("outputTokens")]
            [Validation(Required=false)]
            public long? OutputTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("response")]
            [Validation(Required=false)]
            public string Response { get; set; }

            /// <summary>
            /// <para>调试结果状态。取值：NORMAL（正常）、ABNORMAL（异常）。</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>request-1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
