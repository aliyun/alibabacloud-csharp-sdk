// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class BatchTranslateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchTranslateResponseBodyData Data { get; set; }
        public class BatchTranslateResponseBodyData : TeaModel {
            [NameInMap("translationList")]
            [Validation(Required=false)]
            public List<BatchTranslateResponseBodyDataTranslationList> TranslationList { get; set; }
            public class BatchTranslateResponseBodyDataTranslationList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public long? Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Featured Double Color Ball experts: Liu Ke and A Wang both hit the second prize, winning 1.43 million!</para>
                /// </summary>
                [NameInMap("translation")]
                [Validation(Required=false)]
                public string Translation { get; set; }

                [NameInMap("usage")]
                [Validation(Required=false)]
                public BatchTranslateResponseBodyDataTranslationListUsage Usage { get; set; }
                public class BatchTranslateResponseBodyDataTranslationListUsage : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>480</para>
                    /// </summary>
                    [NameInMap("inputTokens")]
                    [Validation(Required=false)]
                    public long? InputTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>520</para>
                    /// </summary>
                    [NameInMap("outputTokens")]
                    [Validation(Required=false)]
                    public long? OutputTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("totalTokens")]
                    [Validation(Required=false)]
                    public long? TotalTokens { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3BE338D3-16B1-513F-8DD2-57C8528DEAAA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
