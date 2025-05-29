// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class HalfLLMImageOcrResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public HalfLLMImageOcrResponseBodyData Data { get; set; }
        public class HalfLLMImageOcrResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("output")]
            [Validation(Required=false)]
            public HalfLLMImageOcrResponseBodyDataOutput Output { get; set; }
            public class HalfLLMImageOcrResponseBodyDataOutput : TeaModel {
                [NameInMap("choices")]
                [Validation(Required=false)]
                public List<HalfLLMImageOcrResponseBodyDataOutputChoices> Choices { get; set; }
                public class HalfLLMImageOcrResponseBodyDataOutputChoices : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("finishReason")]
                    [Validation(Required=false)]
                    public string FinishReason { get; set; }

                    [NameInMap("message")]
                    [Validation(Required=false)]
                    public HalfLLMImageOcrResponseBodyDataOutputChoicesMessage Message { get; set; }
                    public class HalfLLMImageOcrResponseBodyDataOutputChoicesMessage : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>assistant</para>
                        /// </summary>
                        [NameInMap("role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4Oy0zoqcjcclBgREcZvXF12y</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("rt")]
            [Validation(Required=false)]
            public HalfLLMImageOcrResponseBodyDataRt Rt { get; set; }
            public class HalfLLMImageOcrResponseBodyDataRt : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>635</para>
                /// </summary>
                [NameInMap("firstRt")]
                [Validation(Required=false)]
                public long? FirstRt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8571</para>
                /// </summary>
                [NameInMap("totalRt")]
                [Validation(Required=false)]
                public long? TotalRt { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0sIRZDNncmCfBagzy534x2PH</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("usages")]
            [Validation(Required=false)]
            public HalfLLMImageOcrResponseBodyDataUsages Usages { get; set; }
            public class HalfLLMImageOcrResponseBodyDataUsages : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>771</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>563</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

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
        /// <para>4Oy0zoqcjcclBgREcZvXF12y</para>
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
        public string Success { get; set; }

    }

}
