// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateModelResponseBody : TeaModel {
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
        /// <para>The model information after creation.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateModelResponseBodyData Data { get; set; }
        public class CreateModelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The model capability configuration.</para>
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public CreateModelResponseBodyDataCapabilities Capabilities { get; set; }
            public class CreateModelResponseBodyDataCapabilities : TeaModel {
                /// <summary>
                /// <para>Specifies whether the model supports audio input or output.</para>
                /// </summary>
                [NameInMap("audio")]
                [Validation(Required=false)]
                public bool? Audio { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports document input.</para>
                /// </summary>
                [NameInMap("document")]
                [Validation(Required=false)]
                public bool? Document { get; set; }

                /// <summary>
                /// <para>Specifies whether the model is able to invoke multiple tools in a single response.</para>
                /// </summary>
                [NameInMap("multiToolCall")]
                [Validation(Required=false)]
                public bool? MultiToolCall { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports reasoning capabilities.</para>
                /// </summary>
                [NameInMap("reasoning")]
                [Validation(Required=false)]
                public bool? Reasoning { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports streaming tool calling.</para>
                /// </summary>
                [NameInMap("streamToolCall")]
                [Validation(Required=false)]
                public bool? StreamToolCall { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports tool calling.</para>
                /// </summary>
                [NameInMap("toolCall")]
                [Validation(Required=false)]
                public bool? ToolCall { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports video input.</para>
                /// </summary>
                [NameInMap("video")]
                [Validation(Required=false)]
                public bool? Video { get; set; }

                /// <summary>
                /// <para>Specifies whether the model supports image input.</para>
                /// </summary>
                [NameInMap("vision")]
                [Validation(Required=false)]
                public bool? Vision { get; set; }

            }

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
            /// <para>The model context window size, in tokens. The value must be a positive integer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128000</para>
            /// </summary>
            [NameInMap("contextSize")]
            [Validation(Required=false)]
            public long? ContextSize { get; set; }

            /// <summary>
            /// <para>The resource creation time in RFC 3339 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-09T00:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The model description. Maximum length: 255 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The maximum number of output tokens supported per model generation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131072</para>
            /// </summary>
            [NameInMap("maxTokens")]
            [Validation(Required=false)]
            public long? MaxTokens { get; set; }

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
            /// <para>The upstream model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-max</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The resource last update time in RFC 3339 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-09T00:00:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-1</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

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
