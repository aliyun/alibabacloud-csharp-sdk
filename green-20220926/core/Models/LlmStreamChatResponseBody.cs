// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class LlmStreamChatResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of model generation results.</para>
        /// </summary>
        [NameInMap("Choices")]
        [Validation(Required=false)]
        public List<LlmStreamChatResponseBodyChoices> Choices { get; set; }
        public class LlmStreamChatResponseBodyChoices : TeaModel {
            /// <summary>
            /// <para>The incremental content object.</para>
            /// </summary>
            [NameInMap("Delta")]
            [Validation(Required=false)]
            public LlmStreamChatResponseBodyChoicesDelta Delta { get; set; }
            public class LlmStreamChatResponseBodyChoicesDelta : TeaModel {
                /// <summary>
                /// <para>The text content generated in real time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>I am Deepseek-V3. How can I help you?</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The role identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>assistant</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <para>During streaming output, this value is null while content is being generated. When generation is complete, the value is stop if the generation ended due to a stop token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stop</para>
            /// </summary>
            [NameInMap("FinishReason")]
            [Validation(Required=false)]
            public string FinishReason { get; set; }

            /// <summary>
            /// <para>The stream sequence number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>The token probability information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Logprobs")]
            [Validation(Required=false)]
            public string Logprobs { get; set; }

        }

        /// <summary>
        /// <para>The timestamp when the session was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750990728</para>
        /// </summary>
        [NameInMap("Created")]
        [Validation(Required=false)]
        public long? Created { get; set; }

        /// <summary>
        /// <para>The fault information content in the streaming response.</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public LlmStreamChatResponseBodyError Error { get; set; }
        public class LlmStreamChatResponseBodyError : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data_inspection_failed</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Input data may contain inappropriate content.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The parameter that caused the error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            /// <summary>
            /// <para>The error type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data_inspection_failed</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of this session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatcmpl-777bce52-93d3-9f8c-89c3-e99884f4f57f</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The model identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deepseek-v3</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The response type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chat.completion.chunk</para>
        /// </summary>
        [NameInMap("Object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21d296d6-594e-97de-812f-925ec6e05673</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The system fingerprint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("SystemFingerprint")]
        [Validation(Required=false)]
        public string SystemFingerprint { get; set; }

        /// <summary>
        /// <para>The token usage information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
