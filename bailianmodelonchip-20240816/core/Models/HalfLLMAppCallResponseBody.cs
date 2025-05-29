// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class HalfLLMAppCallResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public HalfLLMAppCallResponseBodyData Data { get; set; }
        public class HalfLLMAppCallResponseBodyData : TeaModel {
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
            public HalfLLMAppCallResponseBodyDataOutput Output { get; set; }
            public class HalfLLMAppCallResponseBodyDataOutput : TeaModel {
                [NameInMap("choices")]
                [Validation(Required=false)]
                public List<HalfLLMAppCallResponseBodyDataOutputChoices> Choices { get; set; }
                public class HalfLLMAppCallResponseBodyDataOutputChoices : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("finishReason")]
                    [Validation(Required=false)]
                    public string FinishReason { get; set; }

                    [NameInMap("message")]
                    [Validation(Required=false)]
                    public HalfLLMAppCallResponseBodyDataOutputChoicesMessage Message { get; set; }
                    public class HalfLLMAppCallResponseBodyDataOutputChoicesMessage : TeaModel {
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
            public HalfLLMAppCallResponseBodyDataRt Rt { get; set; }
            public class HalfLLMAppCallResponseBodyDataRt : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>443</para>
                /// </summary>
                [NameInMap("firstRt")]
                [Validation(Required=false)]
                public long? FirstRt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4432</para>
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
            public HalfLLMAppCallResponseBodyDataUsages Usages { get; set; }
            public class HalfLLMAppCallResponseBodyDataUsages : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>356</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>698</para>
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
        /// <para>D7FEF19A-8B65-5914-9FA3-F26E820294B4</para>
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
