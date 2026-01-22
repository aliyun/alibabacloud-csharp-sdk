// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ChatWithDesensitizeResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ChatWithDesensitizeResponseBodyData Data { get; set; }
        public class ChatWithDesensitizeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The candidate array for model-generated content.</para>
            /// </summary>
            [NameInMap("Choices")]
            [Validation(Required=false)]
            public List<ChatWithDesensitizeResponseBodyDataChoices> Choices { get; set; }
            public class ChatWithDesensitizeResponseBodyDataChoices : TeaModel {
                /// <summary>
                /// <para>Finish reason: ● stop: The model reached a natural stop point or a specified stop sequence. ● length: Generation ended because the maximum number of tokens was reached. ● tool_calls: The model stopped because it needs to call a tool to proceed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>stop</para>
                /// </summary>
                [NameInMap("FinishReason")]
                [Validation(Required=false)]
                public string FinishReason { get; set; }

                /// <summary>
                /// <para>Token probability information of model output.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Logprobs")]
                [Validation(Required=false)]
                public Dictionary<string, object> Logprobs { get; set; }

                /// <summary>
                /// <para>The message body output by the model.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public ChatWithDesensitizeResponseBodyDataChoicesMessage Message { get; set; }
                public class ChatWithDesensitizeResponseBodyDataChoicesMessage : TeaModel {
                    /// <summary>
                    /// <para>The content of the model\&quot;s response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>你好呀！</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The internal reasoning content of the model.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>嗯，用户发了个“你好”，看起来是想打招呼...</para>
                    /// </summary>
                    [NameInMap("ReasoningContent")]
                    [Validation(Required=false)]
                    public string ReasoningContent { get; set; }

                    /// <summary>
                    /// <para>Message role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>system</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                }

            }

            /// <summary>
            /// <para>The Unix timestamp (in seconds) when the request was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1763710100</para>
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>Error message, provided when StatusCode is not 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The model used for this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>Error code, 200 for normal calls, others for exceptions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// <para>Error type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>invalid_request_error</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The token consumption information of this request.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public ChatWithDesensitizeResponseBodyDataUsage Usage { get; set; }
            public class ChatWithDesensitizeResponseBodyDataUsage : TeaModel {
                /// <summary>
                /// <para>The number of output tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CompletionTokens")]
                [Validation(Required=false)]
                public string CompletionTokens { get; set; }

                /// <summary>
                /// <para>Fine-grained classification of output tokens when using the Qwen-VL model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("CompletionTokensDetails")]
                [Validation(Required=false)]
                public Dictionary<string, string> CompletionTokensDetails { get; set; }

                /// <summary>
                /// <para>The number of input tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("PromptTokens")]
                [Validation(Required=false)]
                public string PromptTokens { get; set; }

                /// <summary>
                /// <para>Fine-grained classification of input tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("PromptTokensDetails")]
                [Validation(Required=false)]
                public Dictionary<string, string> PromptTokensDetails { get; set; }

                /// <summary>
                /// <para>The total number of tokens consumed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public string TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
