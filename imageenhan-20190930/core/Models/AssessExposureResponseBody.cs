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
            [NameInMap("Exposure")]
            [Validation(Required=false)]
            public float? Exposure { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
