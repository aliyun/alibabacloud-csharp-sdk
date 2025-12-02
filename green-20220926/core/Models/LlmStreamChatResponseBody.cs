// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class LlmStreamChatResponseBody : TeaModel {
        /// <summary>
        /// <para>List of model generation results</para>
        /// </summary>
        [NameInMap("Choices")]
        [Validation(Required=false)]
        public List<LlmStreamChatResponseBodyChoices> Choices { get; set; }
        public class LlmStreamChatResponseBodyChoices : TeaModel {
            /// <summary>
            /// <para>Incremental content object</para>
            /// </summary>
            [NameInMap("Delta")]
            [Validation(Required=false)]
            public LlmStreamChatResponseBodyChoicesDelta Delta { get; set; }
            public class LlmStreamChatResponseBodyChoicesDelta : TeaModel {
                /// <summary>
                /// <para>Real-time generated text content</para>
                /// 
                /// <b>Example:</b>
                /// <para>我是Deepseek-V3，有什么可以帮你</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Role identifier</para>
                /// 
                /// <b>Example:</b>
                /// <para>assistant</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <para>For streaming output, it is null while generating and becomes \&quot;stop\&quot; if the generation ends due to a stop token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stop</para>
            /// </summary>
            [NameInMap("FinishReason")]
            [Validation(Required=false)]
            public string FinishReason { get; set; }

            /// <summary>
            /// <para>Stream sequence number</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>Token probability information</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Logprobs")]
            [Validation(Required=false)]
            public string Logprobs { get; set; }

        }

        /// <summary>
        /// <para>Timestamp of session creation</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750990728</para>
        /// </summary>
        [NameInMap("Created")]
        [Validation(Required=false)]
        public long? Created { get; set; }

        /// <summary>
        /// <para>Streaming response error information content</para>
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public LlmStreamChatResponseBodyError Error { get; set; }
        public class LlmStreamChatResponseBodyError : TeaModel {
            /// <summary>
            /// <para>Error code</para>
            /// 
            /// <b>Example:</b>
            /// <para>data_inspection_failed</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Error message</para>
            /// 
            /// <b>Example:</b>
            /// <para>Input data may contain inappropriate content.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Parameter that caused the error</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            /// <summary>
            /// <para>Error type</para>
            /// 
            /// <b>Example:</b>
            /// <para>data_inspection_failed</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Unique ID for this session</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatcmpl-777bce52-93d3-9f8c-89c3-e99884f4f57f</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Model identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>deepseek-v3</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Response type</para>
        /// 
        /// <b>Example:</b>
        /// <para>chat.completion.chunk</para>
        /// </summary>
        [NameInMap("Object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        /// <summary>
        /// <para>Unique request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>21d296d6-594e-97de-812f-925ec6e05673</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>System fingerprint</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("SystemFingerprint")]
        [Validation(Required=false)]
        public string SystemFingerprint { get; set; }

        /// <summary>
        /// <para>Token usage</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
