// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateModelResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateModelResponseBodyData Data { get; set; }
        public class UpdateModelResponseBodyData : TeaModel {
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public UpdateModelResponseBodyDataCapabilities Capabilities { get; set; }
            public class UpdateModelResponseBodyDataCapabilities : TeaModel {
                [NameInMap("audio")]
                [Validation(Required=false)]
                public bool? Audio { get; set; }

                [NameInMap("document")]
                [Validation(Required=false)]
                public bool? Document { get; set; }

                [NameInMap("multiToolCall")]
                [Validation(Required=false)]
                public bool? MultiToolCall { get; set; }

                [NameInMap("reasoning")]
                [Validation(Required=false)]
                public bool? Reasoning { get; set; }

                [NameInMap("streamToolCall")]
                [Validation(Required=false)]
                public bool? StreamToolCall { get; set; }

                [NameInMap("toolCall")]
                [Validation(Required=false)]
                public bool? ToolCall { get; set; }

                [NameInMap("video")]
                [Validation(Required=false)]
                public bool? Video { get; set; }

                [NameInMap("vision")]
                [Validation(Required=false)]
                public bool? Vision { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mc-1</para>
            /// </summary>
            [NameInMap("connectionId")]
            [Validation(Required=false)]
            public string ConnectionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>128000</para>
            /// </summary>
            [NameInMap("contextSize")]
            [Validation(Required=false)]
            public long? ContextSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-08-09T00:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>131072</para>
            /// </summary>
            [NameInMap("maxTokens")]
            [Validation(Required=false)]
            public long? MaxTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>model-1</para>
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-max</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-08-09T00:00:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ws-1</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

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
