// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class TermQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public TermQueryResponseBodyData Data { get; set; }
        public class TermQueryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of items that failed processing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("failCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            /// <summary>
            /// <para>A list of identified intervention terms.</para>
            /// </summary>
            [NameInMap("terms")]
            [Validation(Required=false)]
            public List<TermQueryResponseBodyDataTerms> Terms { get; set; }
            public class TermQueryResponseBodyDataTerms : TeaModel {
                /// <summary>
                /// <para>The term in the source language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大模型</para>
                /// </summary>
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <para>The ID of the intervention term.</para>
                /// 
                /// <b>Example:</b>
                /// <para>92669963</para>
                /// </summary>
                [NameInMap("termId")]
                [Validation(Required=false)]
                public string TermId { get; set; }

                /// <summary>
                /// <para>The translated term in the target language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LLM</para>
                /// </summary>
                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C3C70C8F-E026-17D8-854E-7F8EF2F5C909</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates if the API call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
