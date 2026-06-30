// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ExecuteAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExecuteAgentResponseBodyData Data { get; set; }
        public class ExecuteAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>If streaming output is used, this value is null during generation. When generation is complete, the value is stop if the generation ended due to a stop token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stop</para>
            /// </summary>
            [NameInMap("FinishReason")]
            [Validation(Required=false)]
            public string FinishReason { get; set; }

            /// <summary>
            /// <para>The number of input tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InputTokens")]
            [Validation(Required=false)]
            public long? InputTokens { get; set; }

            /// <summary>
            /// <para>The request ID returned by the large language model service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>106C6CA0-282D-4AF7-85F0-D2D24***</para>
            /// </summary>
            [NameInMap("LlmRequestId")]
            [Validation(Required=false)]
            public string LlmRequestId { get; set; }

            /// <summary>
            /// <para>The number of output tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("OutputTokens")]
            [Validation(Required=false)]
            public long? OutputTokens { get; set; }

            /// <summary>
            /// <para>The result returned by the large language model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这段对话似乎是客服与客户之间关于一个服务或产品的讨论，但具体内容难以明确理解，因为对话中的言语比较零散和抽象。</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The total number of tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("TotalTokens")]
            [Validation(Required=false)]
            public long? TotalTokens { get; set; }

            /// <summary>
            /// <para>The number of times the plus model was used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TyxmPlusCount")]
            [Validation(Required=false)]
            public string TyxmPlusCount { get; set; }

            /// <summary>
            /// <para>The number of times the turbo model was used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TyxmTurboCount")]
            [Validation(Required=false)]
            public string TyxmTurboCount { get; set; }

        }

        /// <summary>
        /// <para>The error message returned when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F190ADE9-619A-447D-84E3-7E241A5C428E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. The caller can use this field to determine whether the request was successful. Valid values: <b>true</b>: The request was successful. <b>false/null</b>: The request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
