// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class GetRealPersonVerificationResultResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRealPersonVerificationResultResponseBodyData Data { get; set; }
        public class GetRealPersonVerificationResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public bool? Passed { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10FC953D-7C0C-4915-8949-34E3246E5B79</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
