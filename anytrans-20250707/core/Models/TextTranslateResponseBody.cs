// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class TextTranslateResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data object returned by the request.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public TextTranslateResponseBodyData Data { get; set; }
        public class TextTranslateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The detected source language.</para>
            /// </summary>
            [NameInMap("detectedLang")]
            [Validation(Required=false)]
            public string DetectedLang { get; set; }

            /// <summary>
            /// <para>The translated text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>How does Mogujie solve the data annotation challenge by building a platform?</para>
            /// </summary>
            [NameInMap("translation")]
            [Validation(Required=false)]
            public string Translation { get; set; }

            /// <summary>
            /// <para>Details about the Tokens consumed by the request.</para>
            /// </summary>
            [NameInMap("usage")]
            [Validation(Required=false)]
            public TextTranslateResponseBodyDataUsage Usage { get; set; }
            public class TextTranslateResponseBodyDataUsage : TeaModel {
                /// <summary>
                /// <para>The number of Tokens in the input text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>491</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The number of Tokens in the output text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>The total number of Tokens consumed by the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>891</para>
                /// </summary>
                [NameInMap("totalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

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
        /// <para>A message that provides details about the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>299C57B2-EBB4-57E2-A6FE-723B874ACB74</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
