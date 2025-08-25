// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class AssessSharpnessResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AssessSharpnessResponseBodyData Data { get; set; }
        public class AssessSharpnessResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("Sharpness")]
            [Validation(Required=false)]
            public float? Sharpness { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C0B594A1-383E-4F97-A740-0D51CF8E37D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
