// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListModelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of SUCCESS indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of models.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListModelsResponseBodyItems> Items { get; set; }
        public class ListModelsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The model capability configuration.</para>
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public ListModelsResponseBodyItemsCapabilities Capabilities { get; set; }
            public class ListModelsResponseBodyItemsCapabilities : TeaModel {
                /// <summary>
                /// <para>Indicates whether the model supports audio input or output.</para>
                /// </summary>
                [NameInMap("audio")]
                [Validation(Required=false)]
                public bool? Audio { get; set; }

                /// <summary>
                /// <para>Indicates whether the model supports document input.</para>
                /// </summary>
                [NameInMap("document")]
                [Validation(Required=false)]
                public bool? Document { get; set; }

                /// <summary>
                /// <para>Indicates whether the model supports invoking multiple tools in a single response.</para>
                /// </summary>
                [NameInMap("multiToolCall")]
                [Validation(Required=false)]
                public bool? MultiToolCall { get; set; }

                /// <summary>
                /// <para>Indicates whether the model supports reasoning capabilities.</para>
                /// </summary>
                [NameInMap("reasoning")]
                [Validation(Required=false)]
                public bool? Reasoning { get; set; }

                /// <summary>
                /// <para>Indicates whether the model supports streaming tool calling.</para>
                /// </summary>
                [NameInMap("streamToolCall")]
                [Validation(Required=false)]
                public bool? StreamToolCall { get; set; }

                /// <summary>
                /// <para>Indicates whether the model supports tool calling.</para>
                /// </summary>
                [NameInMap("toolCall")]
                [Validation(Required=false)]
                public bool? ToolCall { get; set; }

                /// <summary>
                /// <para>Indicates whether the model supports video input.</para>
                /// </summary>
                [NameInMap("video")]
                [Validation(Required=false)]
                public bool? Video { get; set; }

                /// <summary>
                /// <para>Indicates whether the model supports image input.</para>
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
            /// <para>The time when the resource was created, in RFC 3339 UTC format.</para>
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
            /// <para>The maximum number of output tokens supported by the model in a single generation.</para>
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
            /// <para>The time when the resource was last updated, in RFC 3339 UTC format.</para>
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
        /// <para>The number of results per page. Valid values: 0 to 100. If this parameter is not set or set to 0, the default value 10 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The message of the request processing result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token. Pass the token returned from the previous query. An empty response indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bW9kZWwtbWFuYWdlbWVudC1vZmZzZXQ6bW9kZWw6MTA</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

        /// <summary>
        /// <para>The total number of resources that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
