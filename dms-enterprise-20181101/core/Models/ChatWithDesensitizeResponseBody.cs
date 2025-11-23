// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ChatWithDesensitizeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ChatWithDesensitizeResponseBodyData Data { get; set; }
        public class ChatWithDesensitizeResponseBodyData : TeaModel {
            [NameInMap("Choices")]
            [Validation(Required=false)]
            public List<ChatWithDesensitizeResponseBodyDataChoices> Choices { get; set; }
            public class ChatWithDesensitizeResponseBodyDataChoices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>stop</para>
                /// </summary>
                [NameInMap("FinishReason")]
                [Validation(Required=false)]
                public string FinishReason { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public ChatWithDesensitizeResponseBodyDataChoicesMessage Message { get; set; }
                public class ChatWithDesensitizeResponseBodyDataChoicesMessage : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>你好呀！</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>嗯，用户发了个“你好”，看起来是想打招呼...</para>
                    /// </summary>
                    [NameInMap("ReasoningContent")]
                    [Validation(Required=false)]
                    public string ReasoningContent { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>system</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1763710100</para>
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public ChatWithDesensitizeResponseBodyDataUsage Usage { get; set; }
            public class ChatWithDesensitizeResponseBodyDataUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CompletionTokens")]
                [Validation(Required=false)]
                public string CompletionTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("PromptTokens")]
                [Validation(Required=false)]
                public string PromptTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public string TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
