// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunLegalAdviceConsultationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Request.Signature.Error</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>744419D0-671A-5997-9840-E8AE48356194</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseMarkdown")]
        [Validation(Required=false)]
        public string ResponseMarkdown { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Round")]
        [Validation(Required=false)]
        public int? Round { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Usage")]
        [Validation(Required=false)]
        public RunLegalAdviceConsultationResponseBodyUsage Usage { get; set; }
        public class RunLegalAdviceConsultationResponseBodyUsage : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("InputTokens")]
            [Validation(Required=false)]
            public int? InputTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>700</para>
            /// </summary>
            [NameInMap("OutputTokens")]
            [Validation(Required=false)]
            public int? OutputTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("TotalTokens")]
            [Validation(Required=false)]
            public int? TotalTokens { get; set; }

        }

        [NameInMap("contents")]
        [Validation(Required=false)]
        public string Contents { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

    }

}
