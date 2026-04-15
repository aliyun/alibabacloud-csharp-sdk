// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DocumentParseService20260414.Models
{
    public class DocumentParseTestApiResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DocumentParseTestApiResponseBodyData Data { get; set; }
        public class DocumentParseTestApiResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[\&quot;LTAI5tQcqrTt1jrRbZf7mHFs\&quot;]</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BAA69D16-9453-5A8F-AE3C-498D956A0A73</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public DocumentParseTestApiResponseBodyDataUsage Usage { get; set; }
            public class DocumentParseTestApiResponseBodyDataUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public int? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public int? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public int? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
