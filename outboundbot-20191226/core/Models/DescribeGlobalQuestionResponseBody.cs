// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeGlobalQuestionResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the global question.</para>
        /// </summary>
        [NameInMap("GlobalQuestion")]
        [Validation(Required=false)]
        public DescribeGlobalQuestionResponseBodyGlobalQuestion GlobalQuestion { get; set; }
        public class DescribeGlobalQuestionResponseBodyGlobalQuestion : TeaModel {
            /// <summary>
            /// <para>The answers to the global question.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;你好,我是你的专属客服顾问.&quot;]</para>
            /// </summary>
            [NameInMap("Answers")]
            [Validation(Required=false)]
            public string Answers { get; set; }

            /// <summary>
            /// <para>The ID of the global question.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f160ec2e-94f2-4c03-87be-ece5b52d5dd9</para>
            /// </summary>
            [NameInMap("GlobalQuestionId")]
            [Validation(Required=false)]
            public string GlobalQuestionId { get; set; }

            /// <summary>
            /// <para>The name of the global question.</para>
            /// 
            /// <b>Example:</b>
            /// <para>你是谁-全局问题</para>
            /// </summary>
            [NameInMap("GlobalQuestionName")]
            [Validation(Required=false)]
            public string GlobalQuestionName { get; set; }

            /// <summary>
            /// <para>The type of the global question.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMMON</para>
            /// </summary>
            [NameInMap("GlobalQuestionType")]
            [Validation(Required=false)]
            public string GlobalQuestionType { get; set; }

            /// <summary>
            /// <para>The questions mapped to this global question.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;你是谁&quot;,&quot;你叫什么&quot;]</para>
            /// </summary>
            [NameInMap("Questions")]
            [Validation(Required=false)]
            public string Questions { get; set; }

            /// <summary>
            /// <para>The ID of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>290e06a5-6de2-4cc8-8a9c-72b7c152256c</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
