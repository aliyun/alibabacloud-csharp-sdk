// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class TermEditResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public TermEditResponseBodyData Data { get; set; }
        public class TermEditResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of items that failed to be processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("failCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            /// <summary>
            /// <para>An array of intervention term objects.</para>
            /// </summary>
            [NameInMap("terms")]
            [Validation(Required=false)]
            public List<TermEditResponseBodyDataTerms> Terms { get; set; }
            public class TermEditResponseBodyDataTerms : TeaModel {
                /// <summary>
                /// <para>The source text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>大模型</para>
                /// </summary>
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <para>The term ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>92669964</para>
                /// </summary>
                [NameInMap("termId")]
                [Validation(Required=false)]
                public string TermId { get; set; }

                /// <summary>
                /// <para>The target text.</para>
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
        /// <para>The message.</para>
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
        /// <para>1DCD50EC-D218-1844-9CD8-E97CAB9D31BE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
