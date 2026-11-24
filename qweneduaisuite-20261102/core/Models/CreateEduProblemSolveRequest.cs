// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102.Models
{
    public class CreateEduProblemSolveRequest : TeaModel {
        /// <summary>
        /// <para>The query information.</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public CreateEduProblemSolveRequestQuery Query { get; set; }
        public class CreateEduProblemSolveRequestQuery : TeaModel {
            /// <summary>
            /// <para>The query image.</para>
            /// </summary>
            [NameInMap("image")]
            [Validation(Required=false)]
            public CreateEduProblemSolveRequestQueryImage Image { get; set; }
            public class CreateEduProblemSolveRequestQueryImage : TeaModel {
                /// <summary>
                /// <para>The Base64 encoding of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/9j/4AAQSkZJRgABAQAASABIAAD/4QCMRXhpZgAATU0AK...</para>
                /// </summary>
                [NameInMap("base64")]
                [Validation(Required=false)]
                public string Base64 { get; set; }

                /// <summary>
                /// <para>The image format. Valid values: jpg, jpeg, and png. The value must match the actual file format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jpg</para>
                /// </summary>
                [NameInMap("format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxx/xxx.jpg">https://xxx/xxx.jpg</a></para>
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
