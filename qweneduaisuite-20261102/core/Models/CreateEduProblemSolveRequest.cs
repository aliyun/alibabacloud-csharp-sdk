// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102.Models
{
    public class CreateEduProblemSolveRequest : TeaModel {
        /// <summary>
        /// <para><b>The question image container.</b></para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public CreateEduProblemSolveRequestQuery Query { get; set; }
        public class CreateEduProblemSolveRequestQuery : TeaModel {
            /// <summary>
            /// <para><b>The image information.</b></para>
            /// </summary>
            [NameInMap("image")]
            [Validation(Required=false)]
            public CreateEduProblemSolveRequestQueryImage Image { get; set; }
            public class CreateEduProblemSolveRequestQueryImage : TeaModel {
                /// <summary>
                /// <para><b>The Base64-encoded image</b>. If both this parameter and the URL are provided, this parameter takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iVBORw0KGgoAAAANSUhEUgAAAAUA...</para>
                /// </summary>
                [NameInMap("base64")]
                [Validation(Required=false)]
                public string Base64 { get; set; }

                /// <summary>
                /// <para><b>The image format</b>: jpg, jpeg, or png. The value must match the actual file format.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jpg</para>
                /// </summary>
                [NameInMap("format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The URL of a single question image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://your-cdn.example.com/question.jpg">https://your-cdn.example.com/question.jpg</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019F593F-D6EE-5F44-819A-6CDA127D1637</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
