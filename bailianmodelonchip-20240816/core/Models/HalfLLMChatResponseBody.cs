// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class HalfLLMChatResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public HalfLLMChatResponseBodyData Data { get; set; }
        public class HalfLLMChatResponseBodyData : TeaModel {
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
            public HalfLLMChatResponseBodyDataOutput Output { get; set; }
            public class HalfLLMChatResponseBodyDataOutput : TeaModel {
                [NameInMap("choices")]
                [Validation(Required=false)]
                public List<HalfLLMChatResponseBodyDataOutputChoices> Choices { get; set; }
                public class HalfLLMChatResponseBodyDataOutputChoices : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("finishReason")]
                    [Validation(Required=false)]
                    public string FinishReason { get; set; }

                    [NameInMap("message")]
                    [Validation(Required=false)]
                    public HalfLLMChatResponseBodyDataOutputChoicesMessage Message { get; set; }
                    public class HalfLLMChatResponseBodyDataOutputChoicesMessage : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>0sIRZDNncmCfBagzy534x2PH</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

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
        /// <para>5DD2E24F-93A2-551D-B192-8DBBEEFE9129</para>
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
