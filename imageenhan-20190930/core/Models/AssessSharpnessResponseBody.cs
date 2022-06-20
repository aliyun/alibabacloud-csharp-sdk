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
            [NameInMap("Sharpness")]
            [Validation(Required=false)]
            public float? Sharpness { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
