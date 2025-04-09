// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeGlobalQuestionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GlobalQuestion")]
        [Validation(Required=false)]
        public DescribeGlobalQuestionResponseBodyGlobalQuestion GlobalQuestion { get; set; }
        public class DescribeGlobalQuestionResponseBodyGlobalQuestion : TeaModel {
            [NameInMap("Answers")]
            [Validation(Required=false)]
            public string Answers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f160ec2e-94f2-4c03-87be-ece5b52d5dd9</para>
            /// </summary>
            [NameInMap("GlobalQuestionId")]
            [Validation(Required=false)]
            public string GlobalQuestionId { get; set; }

            [NameInMap("GlobalQuestionName")]
            [Validation(Required=false)]
            public string GlobalQuestionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COMMON</para>
            /// </summary>
            [NameInMap("GlobalQuestionType")]
            [Validation(Required=false)]
            public string GlobalQuestionType { get; set; }

            [NameInMap("Questions")]
            [Validation(Required=false)]
            public string Questions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>290e06a5-6de2-4cc8-8a9c-72b7c152256c</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
