// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class BatchTranslateResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code for the overall API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response payload that contains the translation results.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchTranslateResponseBodyData Data { get; set; }
        public class BatchTranslateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An array of translation results, one for each text provided in the request.</para>
            /// </summary>
            [NameInMap("translationList")]
            [Validation(Required=false)]
            public List<BatchTranslateResponseBodyDataTranslationList> TranslationList { get; set; }
            public class BatchTranslateResponseBodyDataTranslationList : TeaModel {
                /// <summary>
                /// <para>The status code for the individual translation within the batch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public long? Code { get; set; }

                /// <summary>
                /// <para>The language code of the detected source language.</para>
                /// </summary>
                [NameInMap("detectedLang")]
                [Validation(Required=false)]
                public string DetectedLang { get; set; }

                /// <summary>
                /// <para>The zero-based index of this result, which corresponds to the order of the source text in the original request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// <para>The status message for the individual translation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The translated text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>What will the weather be like tomorrow?</para>
                /// </summary>
                [NameInMap("translation")]
                [Validation(Required=false)]
                public string Translation { get; set; }

                /// <summary>
                /// <para>An object detailing the token usage for this translation.</para>
                /// </summary>
                [NameInMap("usage")]
                [Validation(Required=false)]
                public BatchTranslateResponseBodyDataTranslationListUsage Usage { get; set; }
                public class BatchTranslateResponseBodyDataTranslationListUsage : TeaModel {
                    /// <summary>
                    /// <para>The number of tokens in the source text.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>53</para>
                    /// </summary>
                    [NameInMap("inputTokens")]
                    [Validation(Required=false)]
                    public long? InputTokens { get; set; }

                    /// <summary>
                    /// <para>The number of tokens in the generated translation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("outputTokens")]
                    [Validation(Required=false)]
                    public long? OutputTokens { get; set; }

                    /// <summary>
                    /// <para>The total number of tokens processed for the translation (the sum of <c>inputTokens</c> and <c>outputTokens</c>).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>61</para>
                    /// </summary>
                    [NameInMap("totalTokens")]
                    [Validation(Required=false)]
                    public long? TotalTokens { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier for the request. Use this ID for tracing and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3BE338D3-16B1-513F-8DD2-57C8528DEAAA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
