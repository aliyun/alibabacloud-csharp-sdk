// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class AssessExposureResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AssessExposureResponseBodyData Data { get; set; }
        public class AssessExposureResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("Exposure")]
            [Validation(Required=false)]
            public float? Exposure { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4EF3C65B-C3CC-425B-AFB3-2FE6B98C578B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
